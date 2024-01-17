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
            SuspendLayout();
            // 
            // AllMatchinFiles
            // 
            AllMatchinFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllMatchinFiles.FormattingEnabled = true;
            AllMatchinFiles.Items.AddRange(new object[] { "No Items Found" });
            AllMatchinFiles.Location = new Point(12, 34);
            AllMatchinFiles.Name = "AllMatchinFiles";
            AllMatchinFiles.Size = new Size(776, 334);
            AllMatchinFiles.TabIndex = 0;
            // 
            // Continue
            // 
            Continue.Anchor = AnchorStyles.Bottom;
            Continue.Cursor = Cursors.Hand;
            Continue.DialogResult = DialogResult.Continue;
            Continue.Location = new Point(341, 374);
            Continue.Name = "Continue";
            Continue.Size = new Size(125, 47);
            Continue.TabIndex = 1;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = true;
            Continue.Click += Continue_Click;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(12, 11);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(80, 20);
            pathLabel.TabIndex = 2;
            pathLabel.Text = "Root Path: ";
            // 
            // FoundFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pathLabel);
            Controls.Add(Continue);
            Controls.Add(AllMatchinFiles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FoundFiles";
            Text = "Select from the Found Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox AllMatchinFiles;
        private Button Continue;
        private Label pathLabel;
    }
}