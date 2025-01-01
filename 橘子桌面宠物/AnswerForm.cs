using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 橘子桌面宠物
{
    public partial class AnswerForm : Form
    {
        string answer = null;
        bool mouseEnter=true;
        bool isClosing=false;
        public AnswerForm(string inputAnswer)
        {
            InitializeComponent();
            answer = inputAnswer;
        }

        private async void AnswerForm_Load(object sender, EventArgs e)
        {
            answerBox.Text = answer;
            /*
            do
            {
                if (isClosing)
                {
                    break;
                }
                if (mouseEnter&&this.Opacity!=1.00)
                {
                    for (double i = 0.50; i < 1.00; i+=0.01)
                    {
                        this.Opacity = i;
                        await Task.Delay(1);
                        if (!mouseEnter)
                        {
                            continue;
                        }
                    }
                    mouseEnter = false;
                }
                if (!mouseEnter && this.Opacity != 0.50)
                {
                    for (double i = 1.00; i >0.50; i -= 0.01)
                    {
                        this.Opacity = i;
                        await Task.Delay(1);
                        if (mouseEnter)
                        {
                            continue;
                        }
                    }
                    mouseEnter = true;
                }
                await Task.Delay(100);
            } while (true);*///这段代码有bug，为了避免不必要的性能消耗，暂时
        }

        private void AnswerForm_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter=true;
        }

        private void AnswerForm_MouseLeave(object sender, EventArgs e)
        {
            mouseEnter = false;
        }

        private async void closeThisWindowsButton_Click(object sender, EventArgs e)
        {
            isClosing=true;
            for (double i = 1.00; i > 0.00; i -= 0.01)
            {
                this.Opacity = i;
                await Task.Delay(1);
            }
            this.Close();
        }

        private async void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(answer, true);
            copyButton.ForeColor = Color.Green;
            copyButton.Text ="已复制";
            await Task.Delay(1000);
            copyButton.ForeColor = Color.Black;
            copyButton.Text = "复制到剪切板";
;        }
    }
}
