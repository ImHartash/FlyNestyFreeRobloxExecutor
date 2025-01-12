using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace FlyNestiFree
{
    public partial class LoadString : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private FastColoredTextBox textBox;

        public LoadString(FastColoredTextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isDragging = false;
            }
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private async void load_Click(object sender, EventArgs e)
        {
            String url = URL.Text;
            String content = await getExternLuaContent(url);
            if (content == "")
            {
                MessageBox.Show("Failed to get content from website.");
            }
            textBox.Text = content;
            this.Close();
        }

        private async Task<String> getExternLuaContent(String url)
        {
            String content = "";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(url);
                    responseMessage.EnsureSuccessStatusCode();
                    content = await responseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }

            return content;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
