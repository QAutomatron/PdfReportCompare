namespace ReportCompare
{
    partial class OptionsWindow
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
            this.setPathToDiff = new System.Windows.Forms.Button();
            this.setPathToCompare = new System.Windows.Forms.Button();
            this.pathToCompareLabel = new System.Windows.Forms.Label();
            this.pathToDiffLabel = new System.Windows.Forms.Label();
            this.pathToCompareTextBox = new System.Windows.Forms.TextBox();
            this.pathToDiffTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setPathToDiff
            // 
            this.setPathToDiff.Location = new System.Drawing.Point(467, 43);
            this.setPathToDiff.Name = "setPathToDiff";
            this.setPathToDiff.Size = new System.Drawing.Size(31, 23);
            this.setPathToDiff.TabIndex = 0;
            this.setPathToDiff.Text = "...";
            this.setPathToDiff.UseVisualStyleBackColor = true;
            this.setPathToDiff.Click += new System.EventHandler(this.setPathToDiff_Click);
            // 
            // setPathToCompare
            // 
            this.setPathToCompare.Location = new System.Drawing.Point(467, 8);
            this.setPathToCompare.Name = "setPathToCompare";
            this.setPathToCompare.Size = new System.Drawing.Size(31, 23);
            this.setPathToCompare.TabIndex = 1;
            this.setPathToCompare.Text = "...";
            this.setPathToCompare.UseVisualStyleBackColor = true;
            this.setPathToCompare.Click += new System.EventHandler(this.setPathToCompare_Click);
            // 
            // pathToCompareLabel
            // 
            this.pathToCompareLabel.AutoSize = true;
            this.pathToCompareLabel.Location = new System.Drawing.Point(4, 14);
            this.pathToCompareLabel.Name = "pathToCompareLabel";
            this.pathToCompareLabel.Size = new System.Drawing.Size(83, 13);
            this.pathToCompareLabel.TabIndex = 2;
            this.pathToCompareLabel.Text = "pathToCompare";
            // 
            // pathToDiffLabel
            // 
            this.pathToDiffLabel.AutoSize = true;
            this.pathToDiffLabel.Location = new System.Drawing.Point(12, 43);
            this.pathToDiffLabel.Name = "pathToDiffLabel";
            this.pathToDiffLabel.Size = new System.Drawing.Size(57, 13);
            this.pathToDiffLabel.TabIndex = 3;
            this.pathToDiffLabel.Text = "pathToDiff";
            // 
            // pathToCompareTextBox
            // 
            this.pathToCompareTextBox.Location = new System.Drawing.Point(93, 11);
            this.pathToCompareTextBox.Name = "pathToCompareTextBox";
            this.pathToCompareTextBox.ReadOnly = true;
            this.pathToCompareTextBox.Size = new System.Drawing.Size(368, 20);
            this.pathToCompareTextBox.TabIndex = 4;
            // 
            // pathToDiffTextBox
            // 
            this.pathToDiffTextBox.Location = new System.Drawing.Point(93, 43);
            this.pathToDiffTextBox.Name = "pathToDiffTextBox";
            this.pathToDiffTextBox.ReadOnly = true;
            this.pathToDiffTextBox.Size = new System.Drawing.Size(368, 20);
            this.pathToDiffTextBox.TabIndex = 5;
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 78);
            this.Controls.Add(this.pathToDiffTextBox);
            this.Controls.Add(this.pathToCompareTextBox);
            this.Controls.Add(this.pathToDiffLabel);
            this.Controls.Add(this.pathToCompareLabel);
            this.Controls.Add(this.setPathToCompare);
            this.Controls.Add(this.setPathToDiff);
            this.Name = "OptionsWindow";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setPathToDiff;
        private System.Windows.Forms.Button setPathToCompare;
        private System.Windows.Forms.Label pathToCompareLabel;
        private System.Windows.Forms.Label pathToDiffLabel;
        private System.Windows.Forms.TextBox pathToCompareTextBox;
        private System.Windows.Forms.TextBox pathToDiffTextBox;
    }
}