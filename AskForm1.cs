using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using System.Net;
namespace 橘子桌面宠物
{
    //kimi写了自己的api调用方式
   
    public partial class AskForm1 : Form
    {
        public AskForm1()
        {
            InitializeComponent();
        }
        private void AskForm1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7);
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 60 / 100);

        }
        private async void askButton1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => askAI());
        }
        async void askAI()
        {
            WebClient client = new WebClient();
            WriteisThinkingtxt(true);
            /*string url = "http://www.kufengai.cn/asset/model/qwens-72b.php?prompt=" + askBox1.Text;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            string jsonText = doc.DocumentNode.InnerText;
            JObject json = JObject.Parse(jsonText);
            WriteisThinkingtxt(false);
            string text = json["text"].ToString().Substring(0, json["text"].ToString().Count() - 24);*///旧代码，api已失效
            try
            {
                var kimiApi = new KimiApi("sk-bGRGiYYyX9RxmZbWvvarfj8N2UNDgpiN91mYLV8pSUD35sLP", "https://api.moonshot.cn/v1/chat/completions");//请不要滥用token
                MessageBox.Show(await kimiApi.ChatAI(askBox1.Text));
                WriteisThinkingtxt(false);
            }
            catch (Exception)
            {
                WriteisThinkingtxt(false);

            }
        }
        void WriteisThinkingtxt(bool isThinking)
        {
            w:
            try
            {
                if (isThinking==true)
                {
                    File.WriteAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt", "1");
                }
                else
                {
                    File.WriteAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt", "0");
                }
            }
            catch (Exception)
            {
                goto w;
            }
        }
    }
    public class KimiApi//本class的作者为kimi ai
    {
        private string _apiKey;
        private string _apiUrl;

        public KimiApi(string apiKey, string apiUrl)
        {
            _apiKey = apiKey;
            _apiUrl = apiUrl;
        }

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

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_apiUrl),
                Content = content
            };
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");

            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                var fullResponse = new StringBuilder();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = await reader.ReadLineAsync();
                        if (line.StartsWith("data:"))
                        {
                            var jsonString = line.Substring(5).Trim();
                            if (jsonString == "[DONE]")
                            {
                                break;
                            }
                            var jsonObj = JObject.Parse(jsonString);
                            var contentDelta = jsonObj["choices"]?[0]?["delta"]?["content"]?.ToString();
                            if (contentDelta != null)
                            {
                                fullResponse.Append(contentDelta);
                            }
                        }
                    }
                }
                return fullResponse.ToString();
            }
        }
    }
}
