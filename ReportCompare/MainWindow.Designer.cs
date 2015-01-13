namespace ReportCompare
{
    partial class MainWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.setSourcePathButton = new System.Windows.Forms.Button();
            this.setTargetPathButton = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.targetPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(13, 106);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(270, 144);
            this.txtConsole.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // setSourcePathButton
            // 
            this.setSourcePathButton.Location = new System.Drawing.Point(12, 42);
            this.setSourcePathButton.Name = "setSourcePathButton";
            this.setSourcePathButton.Size = new System.Drawing.Size(75, 23);
            this.setSourcePathButton.TabIndex = 3;
            this.setSourcePathButton.Text = "Source";
            this.setSourcePathButton.UseVisualStyleBackColor = true;
            this.setSourcePathButton.Click += new System.EventHandler(this.setSourcePathButton_Click);
            // 
            // setTargetPathButton
            // 
            this.setTargetPathButton.Location = new System.Drawing.Point(13, 71);
            this.setTargetPathButton.Name = "setTargetPathButton";
            this.setTargetPathButton.Size = new System.Drawing.Size(75, 23);
            this.setTargetPathButton.TabIndex = 4;
            this.setTargetPathButton.Text = "Target";
            this.setTargetPathButton.UseVisualStyleBackColor = true;
            this.setTargetPathButton.Click += new System.EventHandler(this.setTargetPathButton_Click);
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(95, 44);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.ReadOnly = true;
            this.sourcePath.Size = new System.Drawing.Size(188, 20);
            this.sourcePath.TabIndex = 6;
            // 
            // targetPath
            // 
            this.targetPath.Location = new System.Drawing.Point(95, 74);
            this.targetPath.Name = "targetPath";
            this.targetPath.ReadOnly = true;
            this.targetPath.Size = new System.Drawing.Size(188, 20);
            this.targetPath.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 262);
            this.Controls.Add(this.targetPath);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.setTargetPathButton);
            this.Controls.Add(this.setSourcePathButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnStart);
            this.Name = "MainWindow";
            this.Text = "ReportCompare";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button setSourcePathButton;
        private System.Windows.Forms.Button setTargetPathButton;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox targetPath;
    }
}