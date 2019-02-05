namespace Многоугольники
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarvisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Checked = true;
            this.triangleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.jarvisToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.algorithmToolStripMenuItem.Text = "   Algorithm";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Checked = true;
            this.basicToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // jarvisToolStripMenuItem
            // 
            this.jarvisToolStripMenuItem.Name = "jarvisToolStripMenuItem";
            this.jarvisToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.jarvisToolStripMenuItem.Text = "Jarvis";
            this.jarvisToolStripMenuItem.Click += new System.EventHandler(this.jarvisToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColorToolStripMenuItem,
            this.shapeColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.lineColorToolStripMenuItem.Text = "Line Color ";
            this.lineColorToolStripMenuItem.Click += new System.EventHandler(this.lineColorToolStripMenuItem_Click);
            // 
            // shapeColorToolStripMenuItem
            // 
            this.shapeColorToolStripMenuItem.Name = "shapeColorToolStripMenuItem";
            this.shapeColorToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.shapeColorToolStripMenuItem.Text = "Shape Color ";
            this.shapeColorToolStripMenuItem.Click += new System.EventHandler(this.shapeColorToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.algorithmToolStripMenuItem,
            this.radiusToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radiusToolStripMenuItem
            // 
            this.radiusToolStripMenuItem.Name = "radiusToolStripMenuItem";
            this.radiusToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.radiusToolStripMenuItem.Text = "Radius";
            this.radiusToolStripMenuItem.Click += new System.EventHandler(this.radiusToolStripMenuItem_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.Location = new System.Drawing.Point(493, 0);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(30, 28);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(451, 1);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(36, 26);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // IntervalBox
            // 
            this.IntervalBox.Location = new System.Drawing.Point(641, 3);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(100, 22);
            this.IntervalBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval:";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jarvisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeColorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem radiusToolStripMenuItem;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

