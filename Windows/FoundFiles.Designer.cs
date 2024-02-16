namespace DataExtractionEngine.Windows
{
    partial class FoundFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoundFiles));
            AllMatchinFiles = new CheckedListBox();
            Continue = new Button();
            pathLabel = new Label();
            GetData = new Button();
            trackingExtract = new Button();
            SuspendLayout();
            // 
            // AllMatchinFiles
            // 
            AllMatchinFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllMatchinFiles.FormattingEnabled = true;
            AllMatchinFiles.Items.AddRange(new object[] { "No Items Found" });
            AllMatchinFiles.Location = new Point(10, 26);
            AllMatchinFiles.Margin = new Padding(3, 2, 3, 2);
            AllMatchinFiles.Name = "AllMatchinFiles";
            AllMatchinFiles.Size = new Size(680, 238);
            AllMatchinFiles.TabIndex = 0;
            // 
            // Continue
            // 
            Continue.Anchor = AnchorStyles.Bottom;
            Continue.Cursor = Cursors.Hand;
            Continue.DialogResult = DialogResult.Continue;
            Continue.Location = new Point(298, 280);
            Continue.Margin = new Padding(3, 2, 3, 2);
            Continue.Name = "Continue";
            Continue.Size = new Size(109, 35);
            Continue.TabIndex = 1;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = true;
            Continue.Click += Continue_Click;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(10, 8);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(65, 15);
            pathLabel.TabIndex = 2;
            pathLabel.Text = "Root Path: ";
            // 
            // GetData
            // 
            GetData.Location = new Point(10, 280);
            GetData.Name = "GetData";
            GetData.Size = new Size(120, 35);
            GetData.TabIndex = 3;
            GetData.Text = "Get Data";
            GetData.UseVisualStyleBackColor = true;
            GetData.Click += GetData_Click;
            // 
            // trackingExtract
            // 
            trackingExtract.Location = new Point(531, 280);
            trackingExtract.Name = "trackingExtract";
            trackingExtract.Size = new Size(131, 35);
            trackingExtract.TabIndex = 4;
            trackingExtract.Text = "Extract Tracking Data";
            trackingExtract.UseVisualStyleBackColor = true;
            trackingExtract.Click += trackingExtract_Click;
            // 
            // FoundFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(trackingExtract);
            Controls.Add(GetData);
            Controls.Add(pathLabel);
            Controls.Add(Continue);
            Controls.Add(AllMatchinFiles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FoundFiles";
            Text = "Select from the Found Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox AllMatchinFiles;
        private Button Continue;
        private Label pathLabel;
        private Button GetData;
        private Button trackingExtract;
    }
}