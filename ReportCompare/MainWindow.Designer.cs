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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.txtConsole.Location = new System.Drawing.Point(16, 299);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(506, 86);
            this.txtConsole.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 15);
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
            this.sourcePath.Size = new System.Drawing.Size(427, 20);
            this.sourcePath.TabIndex = 6;
            this.sourcePath.TextChanged += new System.EventHandler(this.sourcePath_TextChanged);
            // 
            // targetPath
            // 
            this.targetPath.Location = new System.Drawing.Point(95, 74);
            this.targetPath.Name = "targetPath";
            this.targetPath.Size = new System.Drawing.Size(427, 20);
            this.targetPath.TabIndex = 7;
            this.targetPath.TextChanged += new System.EventHandler(this.targetPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 391);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(510, 23);
            this.progressBar.TabIndex = 9;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 118);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.Size = new System.Drawing.Size(506, 161);
            this.dataGrid.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 426);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}