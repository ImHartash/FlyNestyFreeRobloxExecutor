using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace FlyNestiFree
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private String scriptsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts");

        private LoadString loadString = null;

        private Color targetColor;
        private Color startColor;
        private Timer timer;
        private int animationStep;
        private const int animationDuration = 30;
        private const int steps = 20;

        private Panel loadingOverlay;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            loadFileList();

            scriptTextBox.Language = FastColoredTextBoxNS.Language.Lua;
            scriptTextBox.ShowScrollBars = false;

            //timer = new Timer();
            //timer.Interval = animationDuration / steps;
            //timer.Tick += Timer_Tick;

            //startColor = Color.Transparent;
            //targetColor = Color.FromArgb(50, Color.Gray);    
        }

        private void loadFileList()
        {
            if (!Directory.Exists(scriptsFolder))
            {
                Directory.CreateDirectory(scriptsFolder);
            }

            filesList.Items.Clear();
            var files = Directory.GetFiles(scriptsFolder, "*.*")
                .Where(f => f.EndsWith(".txt") || f.EndsWith(".lua"))
                .Select(Path.GetFileName);
            filesList.Items.AddRange(files.ToArray());
        }

        private void title_mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void title_mouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void title_mouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isDragging = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.scriptTextBox.Clear();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadFileList();
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesList.SelectedItem != null)
            {
                String filePath = Path.Combine(scriptsFolder, filesList.SelectedItem.ToString());
                try
                {
                    scriptTextBox.Text = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Internal error while reading file: {ex.Message}");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = scriptsFolder;
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, scriptTextBox.Text);
                        MessageBox.Show("File successfully saved!");
                        loadFileList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Internal error while saving file: {ex.Message}");
                    }
                }
            }
        }

        private void attach_Click(object sender, EventArgs e)
        {
            if (!API.execExecuteLuaScript(scriptTextBox.Text))
            {
                MessageBox.Show("Failed to attach Lua Code.");
            }
            else
            {
                MessageBox.Show("Successfully attached lua code!");
            }
        }

        private void inject_Click(object sender, EventArgs e)
        {
            bool result = API.execInject();
            if (result)
            {
                //inject.Enabled = false;
                MessageBox.Show("Successfully Injected!");
            }
            else
            {
                MessageBox.Show("Failed to inject.");
            }
        }

        private void loadstring_Click(object sender, EventArgs e)
        {
            if (loadString == null)
            {
                loadString = new LoadString(this.scriptTextBox);
                loadString.Show();

                loadString.FormClosed += (a, b) =>
                {
                    loadString = null;
                };
            }
            else
            {
                loadString.Close();
                loadString = null;
            }
        }

        private void button_hover(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Control control = sender as Control;
            control.BackColor = Color.Transparent;
        }

        private void button_unhover(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            Control control = sender as Control;
            control.BackColor = Color.Transparent;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (animationStep < steps)
            {
                // Рассчитываем текущий цвет
                int r = (int)(startColor.R + (targetColor.R - startColor.R) * (animationStep / (float)steps));
                int g = (int)(startColor.G + (targetColor.G - startColor.G) * (animationStep / (float)steps));
                int b = (int)(startColor.B + (targetColor.B - startColor.B) * (animationStep / (float)steps));
                this.BackColor = Color.FromArgb(r, g, b);

                animationStep++;
            }
            else
            {
                timer.Stop();
                startColor = this.BackColor;

                if (this.BackColor != targetColor)
                {
                    targetColor = Color.Red;
                }
            }
        }
    }
}
