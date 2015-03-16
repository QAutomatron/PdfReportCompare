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
            this.startButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.setSourcePathButton = new System.Windows.Forms.Button();
            this.setTargetPathButton = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.targetPath = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.silentModeCheckBox = new System.Windows.Forms.CheckBox();
            this.targetCountTextLabel = new System.Windows.Forms.Label();
            this.targetCountValueLabel = new System.Windows.Forms.Label();
            this.sourceCountTextLabel = new System.Windows.Forms.Label();
            this.sourceCountValueLabel = new System.Windows.Forms.Label();
            this.diffCountValueLabel = new System.Windows.Forms.Label();
            this.diffCountTextLabel = new System.Windows.Forms.Label();
            this.errCountTextLabel = new System.Windows.Forms.Label();
            this.errCountValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 406);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(449, 86);
            this.logTextBox.TabIndex = 1;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(447, 15);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.btnOptions_Click);
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
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(13, 390);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(28, 13);
            this.logLabel.TabIndex = 8;
            this.logLabel.Text = "Log:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 498);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(510, 23);
            this.progressBar.TabIndex = 9;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 100);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(506, 287);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            // 
            // silentModeCheckBox
            // 
            this.silentModeCheckBox.AutoSize = true;
            this.silentModeCheckBox.Checked = true;
            this.silentModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.silentModeCheckBox.Location = new System.Drawing.Point(359, 21);
            this.silentModeCheckBox.Name = "silentModeCheckBox";
            this.silentModeCheckBox.Size = new System.Drawing.Size(82, 17);
            this.silentModeCheckBox.TabIndex = 11;
            this.silentModeCheckBox.Text = "Silent Mode";
            this.silentModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // targetCountTextLabel
            // 
            this.targetCountTextLabel.AutoSize = true;
            this.targetCountTextLabel.Location = new System.Drawing.Point(464, 428);
            this.targetCountTextLabel.Name = "targetCountTextLabel";
            this.targetCountTextLabel.Size = new System.Drawing.Size(41, 13);
            this.targetCountTextLabel.TabIndex = 12;
            this.targetCountTextLabel.Text = "Target:";
            // 
            // targetCountValueLabel
            // 
            this.targetCountValueLabel.AutoSize = true;
            this.targetCountValueLabel.Location = new System.Drawing.Point(509, 428);
            this.targetCountValueLabel.Name = "targetCountValueLabel";
            this.targetCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.targetCountValueLabel.TabIndex = 13;
            this.targetCountValueLabel.Text = "0";
            // 
            // sourceCountTextLabel
            // 
            this.sourceCountTextLabel.AutoSize = true;
            this.sourceCountTextLabel.Location = new System.Drawing.Point(464, 406);
            this.sourceCountTextLabel.Name = "sourceCountTextLabel";
            this.sourceCountTextLabel.Size = new System.Drawing.Size(44, 13);
            this.sourceCountTextLabel.TabIndex = 14;
            this.sourceCountTextLabel.Text = "Source:";
            // 
            // sourceCountValueLabel
            // 
            this.sourceCountValueLabel.AutoSize = true;
            this.sourceCountValueLabel.Location = new System.Drawing.Point(509, 406);
            this.sourceCountValueLabel.Name = "sourceCountValueLabel";
            this.sourceCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.sourceCountValueLabel.TabIndex = 15;
            this.sourceCountValueLabel.Text = "0";
            // 
            // diffCountValueLabel
            // 
            this.diffCountValueLabel.AutoSize = true;
            this.diffCountValueLabel.Location = new System.Drawing.Point(509, 451);
            this.diffCountValueLabel.Name = "diffCountValueLabel";
            this.diffCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.diffCountValueLabel.TabIndex = 16;
            this.diffCountValueLabel.Text = "0";
            // 
            // diffCountTextLabel
            // 
            this.diffCountTextLabel.AutoSize = true;
            this.diffCountTextLabel.Location = new System.Drawing.Point(464, 451);
            this.diffCountTextLabel.Name = "diffCountTextLabel";
            this.diffCountTextLabel.Size = new System.Drawing.Size(26, 13);
            this.diffCountTextLabel.TabIndex = 17;
            this.diffCountTextLabel.Text = "Diff:";
            // 
            // errCountTextLabel
            // 
            this.errCountTextLabel.AutoSize = true;
            this.errCountTextLabel.Location = new System.Drawing.Point(464, 479);
            this.errCountTextLabel.Name = "errCountTextLabel";
            this.errCountTextLabel.Size = new System.Drawing.Size(37, 13);
            this.errCountTextLabel.TabIndex = 19;
            this.errCountTextLabel.Text = "Errors:";
            // 
            // errCountValueLabel
            // 
            this.errCountValueLabel.AutoSize = true;
            this.errCountValueLabel.Location = new System.Drawing.Point(509, 479);
            this.errCountValueLabel.Name = "errCountValueLabel";
            this.errCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.errCountValueLabel.TabIndex = 18;
            this.errCountValueLabel.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 523);
            this.Controls.Add(this.errCountTextLabel);
            this.Controls.Add(this.errCountValueLabel);
            this.Controls.Add(this.diffCountTextLabel);
            this.Controls.Add(this.diffCountValueLabel);
            this.Controls.Add(this.sourceCountValueLabel);
            this.Controls.Add(this.sourceCountTextLabel);
            this.Controls.Add(this.targetCountValueLabel);
            this.Controls.Add(this.targetCountTextLabel);
            this.Controls.Add(this.silentModeCheckBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.targetPath);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.setTargetPathButton);
            this.Controls.Add(this.setSourcePathButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 561);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(554, 561);
            this.Name = "MainWindow";
            this.Text = "ReportCompare";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button setSourcePathButton;
        private System.Windows.Forms.Button setTargetPathButton;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox targetPath;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.CheckBox silentModeCheckBox;
        private System.Windows.Forms.Label targetCountTextLabel;
        private System.Windows.Forms.Label targetCountValueLabel;
        private System.Windows.Forms.Label sourceCountTextLabel;
        private System.Windows.Forms.Label sourceCountValueLabel;
        private System.Windows.Forms.Label diffCountValueLabel;
        private System.Windows.Forms.Label diffCountTextLabel;
        private System.Windows.Forms.Label errCountTextLabel;
        private System.Windows.Forms.Label errCountValueLabel;
    }
}