using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 橘子桌面宠物;

//kimi写了自己的api调用方式

public partial class AskForm1 : Form
{
    public AskForm1()
    {
        InitializeComponent();
    }

    private void AskForm1_Load(object sender, EventArgs e)
    {
        Size = new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7);
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 60 / 100);
        TopMost = true;
        ShowInTaskbar = false;
    }

    private async void askButton1_Click(object sender, EventArgs e)
    {
        await askAI();
    }

    private async Task askAI()
    {
        WriteIsThinkingText(true);
        // string url = "http://www.kufengai.cn/asset/model/qwens-72b.php?prompt=" + askBox1.Text;
        // WebClient client = new WebClient();
        // HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        // string html = client.DownloadString(url);
        // doc.LoadHtml(html);
        // string jsonText = doc.DocumentNode.InnerText;
        // JObject json = JObject.Parse(jsonText);
        // WriteIsThinkingText(false);
        // string text = json["text"].ToString().Substring(0, json["text"].ToString().Count() - 24); // 旧代码，api已失效
        try
        {
            KimiApi kimiApi = new("sk-bGRGiYYyX9RxmZbWvvarfj8N2UNDgpiN91mYLV8pSUD35sLP", "https://api.moonshot.cn/v1/chat/completions"); // 请不要滥用token
            MessageBox.Show(await kimiApi.ChatAI(askBox1.Text));
            WriteIsThinkingText(false);
        }
        catch (Exception)
        {
            WriteIsThinkingText(false);
        }
    }

    private static void WriteIsThinkingText(bool isThinking)
    {
        do
        {
            try
            {
                File.WriteAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt", isThinking ? "1" : "0");
            }
            catch (Exception)
            {
                continue;
            }

            break;
        } while (true);
    }
}

public class KimiApi(string apiKey, string apiUrl) // 本class的作者为kimi ai
{
    public async Task<string> ChatAI(string input)
    {
        var requestBody = new
        {
            model = "moonshot-v1-8k", // 模型ID，根据实际情况替换
            messages = new[]
            {
                new { role = "system", content = "你是一个AI助手" },
                new { role = "user", content = input }
            },
            stream = true
        };

        string json = JsonConvert.SerializeObject(requestBody);
        StringContent content = new(json, Encoding.UTF8, "application/json");
        HttpRequestMessage request = new()
        {
            Method = HttpMethod.Post,
            RequestUri = new(apiUrl),
            Content = content
        };
        request.Headers.Add("Authorization", $"Bearer {apiKey}");

        using HttpClient client = new();
        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        StringBuilder fullResponse = new();
        using (Stream stream = await response.Content.ReadAsStreamAsync())
        using (StreamReader reader = new(stream))
        {
            while (!reader.EndOfStream)
            {
                string line = await reader.ReadLineAsync();
                if (!line.StartsWith("data:"))
                {
                    continue;
                }

                string jsonString = line.Substring(5).Trim();
                if (jsonString is "[DONE]")
                {
                    break;
                }

                JObject jsonObj = JObject.Parse(jsonString);
                string? contentDelta = jsonObj["choices"]?[0]?["delta"]?["content"]?.ToString();
                if (contentDelta is not null)
                {
                    fullResponse.Append(contentDelta);
                }
            }
        }

        return fullResponse.ToString();
    }
}