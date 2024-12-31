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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            loadFileList();
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
                catch(Exception ex)
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
    }
}
