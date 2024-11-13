namespace ResizeImagesApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            resizeButton = new Button();
            radioButton1500 = new RadioButton();
            sizeLabel1 = new Label();
            radioButton1000 = new RadioButton();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // resizeButton
            // 
            resizeButton.Font = new Font("Courier New", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resizeButton.Location = new Point(18, 33);
            resizeButton.Margin = new Padding(5);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(232, 143);
            resizeButton.TabIndex = 0;
            resizeButton.Text = "Add images to resize";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += resizeButton_Click;
            // 
            // radioButton1500
            // 
            radioButton1500.AutoSize = true;
            radioButton1500.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1500.Location = new Point(139, 212);
            radioButton1500.Name = "radioButton1500";
            radioButton1500.Size = new Size(119, 27);
            radioButton1500.TabIndex = 3;
            radioButton1500.TabStop = true;
            radioButton1500.Text = "1500 px";
            radioButton1500.UseVisualStyleBackColor = true;
            // 
            // sizeLabel1
            // 
            sizeLabel1.AutoSize = true;
            sizeLabel1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sizeLabel1.Location = new Point(14, 181);
            sizeLabel1.Name = "sizeLabel1";
            sizeLabel1.Size = new Size(238, 22);
            sizeLabel1.TabIndex = 4;
            sizeLabel1.Text = "select maximum size";
            // 
            // radioButton1000
            // 
            radioButton1000.AutoSize = true;
            radioButton1000.Checked = true;
            radioButton1000.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1000.Location = new Point(14, 212);
            radioButton1000.Name = "radioButton1000";
            radioButton1000.Size = new Size(119, 27);
            radioButton1000.TabIndex = 5;
            radioButton1000.TabStop = true;
            radioButton1000.Text = "1000 px";
            radioButton1000.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(268, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 29);
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 259);
            Controls.Add(radioButton1000);
            Controls.Add(sizeLabel1);
            Controls.Add(radioButton1500);
            Controls.Add(resizeButton);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Resize Images";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resizeButton;
        private CheckBox qualityCheckBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton1500;
        private Label sizeLabel1;
        private RadioButton radioButton1000;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
    }
}
