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
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.inject = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.scriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scriptTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.IndianRed;
            this.close.Location = new System.Drawing.Point(964, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 35);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.SandyBrown;
            this.minimize.Location = new System.Drawing.Point(930, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 35);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "M";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.Transparent;
            this.inject.BackgroundImage = global::FlyNestiFree.Properties.Resources.injection;
            this.inject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inject.FlatAppearance.BorderSize = 0;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inject.ForeColor = System.Drawing.Color.White;
            this.inject.Location = new System.Drawing.Point(4, 479);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(35, 30);
            this.inject.TabIndex = 8;
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = global::FlyNestiFree.Properties.Resources.icons8_refresh_100;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(4, 442);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 31);
            this.refresh.TabIndex = 9;
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
            this.filesList.Location = new System.Drawing.Point(848, 41);
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
            this.scriptTextBox.Location = new System.Drawing.Point(45, 41);
            this.scriptTextBox.Name = "scriptTextBox";
            this.scriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.scriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.scriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("scriptTextBox.ServiceColors")));
            this.scriptTextBox.ServiceLinesColor = System.Drawing.Color.Black;
            this.scriptTextBox.Size = new System.Drawing.Size(797, 468);
            this.scriptTextBox.TabIndex = 11;
            this.scriptTextBox.Text = "-- Welcome to FlyNesty Executor (Free Version)\r\n-- flynesty.xyz";
            this.scriptTextBox.Zoom = 100;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = global::FlyNestiFree.Properties.Resources.icons8_save_as_96;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(4, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(35, 38);
            this.save.TabIndex = 7;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BackgroundImage = global::FlyNestiFree.Properties.Resources.icons8_erase_96;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.clear.Location = new System.Drawing.Point(4, 85);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(35, 38);
            this.clear.TabIndex = 6;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // attach
            // 
            this.attach.BackColor = System.Drawing.Color.Transparent;
            this.attach.BackgroundImage = global::FlyNestiFree.Properties.Resources.icons8_start_90;
            this.attach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attach.FlatAppearance.BorderSize = 0;
            this.attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attach.ForeColor = System.Drawing.Color.White;
            this.attach.Location = new System.Drawing.Point(4, 41);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(35, 38);
            this.attach.TabIndex = 5;
            this.attach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.attach.UseVisualStyleBackColor = false;
            this.attach.Click += new System.EventHandler(this.attach_Click);
            this.attach.MouseEnter += new System.EventHandler(this.button_hover);
            this.attach.MouseLeave += new System.EventHandler(this.button_unhover);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1000, 35);
            this.title.TabIndex = 0;
            this.title.Text = "FlyNesty";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_mouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_mouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_mouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 520);
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
            this.DoubleBuffered = true;
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
    }
}

