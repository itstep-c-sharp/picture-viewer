namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewBox = new System.Windows.Forms.PictureBox();
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenItem,
            this.CloseItem,
            this.ExitItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.folderToolStripMenuItem.Text = "&Folder";
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(181, 26);
            this.OpenItem.Text = "&Open";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // CloseItem
            // 
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CloseItem.Size = new System.Drawing.Size(181, 26);
            this.CloseItem.Text = "&Close";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitItem.Size = new System.Drawing.Size(181, 26);
            this.ExitItem.Text = "&Exit";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramItem,
            this.AuthorItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // ProgramItem
            // 
            this.ProgramItem.Name = "ProgramItem";
            this.ProgramItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ProgramItem.Size = new System.Drawing.Size(191, 26);
            this.ProgramItem.Text = "&Program";
            // 
            // AuthorItem
            // 
            this.AuthorItem.Name = "AuthorItem";
            this.AuthorItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AuthorItem.Size = new System.Drawing.Size(191, 26);
            this.AuthorItem.Text = "&Author";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // FilesList
            // 
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 18;
            this.FilesList.Location = new System.Drawing.Point(0, 28);
            this.FilesList.Name = "FilesList";
            this.FilesList.ScrollAlwaysVisible = true;
            this.FilesList.Size = new System.Drawing.Size(246, 560);
            this.FilesList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.Forward);
            this.groupBox1.Controls.Add(this.Backward);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(246, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(246, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1124, 450);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотр";
            // 
            // ViewBox
            // 
            this.ViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBox.Image = global::PictureViewer.Properties.Resources.logo2;
            this.ViewBox.Location = new System.Drawing.Point(3, 20);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(1118, 427);
            this.ViewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewBox.TabIndex = 0;
            this.ViewBox.TabStop = false;
            // 
            // Backward
            // 
            this.Backward.Location = new System.Drawing.Point(46, 43);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(126, 32);
            this.Backward.TabIndex = 0;
            this.Backward.Text = "<<<";
            this.Backward.UseVisualStyleBackColor = true;
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(188, 43);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(126, 32);
            this.Forward.TabIndex = 1;
            this.Forward.Text = ">>>";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(352, 43);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(98, 32);
            this.Start.TabIndex = 2;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(464, 43);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(98, 32);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(577, 43);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(98, 32);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(690, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 28);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(808, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(269, 30);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотрщик изображений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ViewBox;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
    }
}

