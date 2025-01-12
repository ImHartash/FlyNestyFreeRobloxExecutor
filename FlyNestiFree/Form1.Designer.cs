namespace FlyNestiFree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.attach = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.scriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.loadstring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scriptTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(950, 35);
            this.title.TabIndex = 0;
            this.title.Text = "FlyNesty by HqHacks";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_mouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_mouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_mouseUp);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Gray;
            this.close.Location = new System.Drawing.Point(924, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 35);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(890, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 35);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "M";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // attach
            // 
            this.attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.attach.FlatAppearance.BorderSize = 0;
            this.attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attach.ForeColor = System.Drawing.Color.White;
            this.attach.Location = new System.Drawing.Point(12, 515);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(133, 31);
            this.attach.TabIndex = 5;
            this.attach.Text = "Execute";
            this.attach.UseVisualStyleBackColor = false;
            this.attach.Click += new System.EventHandler(this.attach_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(290, 515);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(133, 31);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(429, 515);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 31);
            this.save.TabIndex = 7;
            this.save.Text = "Save As";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inject.FlatAppearance.BorderSize = 0;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inject.ForeColor = System.Drawing.Color.White;
            this.inject.Location = new System.Drawing.Point(659, 515);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(133, 31);
            this.inject.TabIndex = 8;
            this.inject.Text = "Inject";
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(798, 515);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(140, 31);
            this.refresh.TabIndex = 9;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // filesList
            // 
            this.filesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.filesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesList.ForeColor = System.Drawing.Color.White;
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 18;
            this.filesList.Items.AddRange(new object[] {
            "welcome.txt"});
            this.filesList.Location = new System.Drawing.Point(798, 41);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(140, 468);
            this.filesList.TabIndex = 10;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // scriptTextBox
            // 
            this.scriptTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.scriptTextBox.AutoScrollMinSize = new System.Drawing.Size(635, 46);
            this.scriptTextBox.BackBrush = null;
            this.scriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptTextBox.CharHeight = 23;
            this.scriptTextBox.CharWidth = 13;
            this.scriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.scriptTextBox.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.scriptTextBox.ForeColor = System.Drawing.Color.White;
            this.scriptTextBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.scriptTextBox.IsReplaceMode = false;
            this.scriptTextBox.LineNumberColor = System.Drawing.Color.Thistle;
            this.scriptTextBox.Location = new System.Drawing.Point(12, 41);
            this.scriptTextBox.Name = "scriptTextBox";
            this.scriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.scriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.scriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("scriptTextBox.ServiceColors")));
            this.scriptTextBox.ServiceLinesColor = System.Drawing.Color.Black;
            this.scriptTextBox.Size = new System.Drawing.Size(780, 468);
            this.scriptTextBox.TabIndex = 11;
            this.scriptTextBox.Text = "-- Welcome to FlyNesty Executor (Free Version)\r\n-- flynesty.xyz";
            this.scriptTextBox.Zoom = 100;
            // 
            // loadstring
            // 
            this.loadstring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadstring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadstring.FlatAppearance.BorderSize = 0;
            this.loadstring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadstring.ForeColor = System.Drawing.Color.White;
            this.loadstring.Location = new System.Drawing.Point(151, 515);
            this.loadstring.Name = "loadstring";
            this.loadstring.Size = new System.Drawing.Size(133, 31);
            this.loadstring.TabIndex = 12;
            this.loadstring.Text = "Load";
            this.loadstring.UseVisualStyleBackColor = false;
            this.loadstring.Click += new System.EventHandler(this.loadstring_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(950, 558);
            this.Controls.Add(this.loadstring);
            this.Controls.Add(this.scriptTextBox);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyNesty Free - Roblox Executor";
            ((System.ComponentModel.ISupportInitialize)(this.scriptTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ListBox filesList;
        private FastColoredTextBoxNS.FastColoredTextBox scriptTextBox;
        private System.Windows.Forms.Button loadstring;
    }
}

