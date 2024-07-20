namespace Duplicatero
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            getFileButton = new Button();
            fileName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            separator = new TextBox();
            PutInFolderCheck = new CheckBox();
            opendestination = new CheckBox();
            duplicatesAmount = new RichTextBox();
            FinalMessage = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(146, 284);
            button1.Name = "button1";
            button1.Size = new Size(120, 67);
            button1.TabIndex = 0;
            button1.Text = "Start Operation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // getFileButton
            // 
            getFileButton.Location = new Point(12, 68);
            getFileButton.Name = "getFileButton";
            getFileButton.Size = new Size(120, 37);
            getFileButton.TabIndex = 1;
            getFileButton.Text = "Get File";
            getFileButton.UseVisualStyleBackColor = true;
            getFileButton.Click += button2_Click;
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.Location = new Point(146, 79);
            fileName.Name = "fileName";
            fileName.Size = new Size(17, 15);
            fileName.TabIndex = 2;
            fileName.Text = "__";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 3;
            label1.Text = "Duplicate Any file X amount of time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 4;
            label2.Text = "Duplicatero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Duplicates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Separator";
            // 
            // separator
            // 
            separator.Location = new Point(100, 141);
            separator.Name = "separator";
            separator.Size = new Size(319, 23);
            separator.TabIndex = 8;
            // 
            // PutInFolderCheck
            // 
            PutInFolderCheck.AutoSize = true;
            PutInFolderCheck.Location = new Point(12, 179);
            PutInFolderCheck.Name = "PutInFolderCheck";
            PutInFolderCheck.RightToLeft = RightToLeft.Yes;
            PutInFolderCheck.Size = new Size(102, 19);
            PutInFolderCheck.TabIndex = 9;
            PutInFolderCheck.Text = "Put in a Folder";
            PutInFolderCheck.UseVisualStyleBackColor = true;
            PutInFolderCheck.CheckedChanged += PutInFolderCheck_CheckedChanged;
            // 
            // opendestination
            // 
            opendestination.AutoSize = true;
            opendestination.Location = new Point(12, 204);
            opendestination.Name = "opendestination";
            opendestination.RightToLeft = RightToLeft.Yes;
            opendestination.Size = new Size(199, 19);
            opendestination.TabIndex = 11;
            opendestination.Text = "Open Destination after operation";
            opendestination.UseVisualStyleBackColor = true;
            // 
            // duplicatesAmount
            // 
            duplicatesAmount.DetectUrls = false;
            duplicatesAmount.Location = new Point(100, 107);
            duplicatesAmount.MaxLength = 1000;
            duplicatesAmount.Name = "duplicatesAmount";
            duplicatesAmount.Size = new Size(319, 23);
            duplicatesAmount.TabIndex = 12;
            duplicatesAmount.Text = "0";
            // 
            // FinalMessage
            // 
            FinalMessage.BorderStyle = BorderStyle.None;
            FinalMessage.DetectUrls = false;
            FinalMessage.Location = new Point(12, 229);
            FinalMessage.MaxLength = 1000;
            FinalMessage.Name = "FinalMessage";
            FinalMessage.ReadOnly = true;
            FinalMessage.Size = new Size(407, 49);
            FinalMessage.TabIndex = 13;
            FinalMessage.Text = "XXXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 367);
            Controls.Add(FinalMessage);
            Controls.Add(duplicatesAmount);
            Controls.Add(opendestination);
            Controls.Add(PutInFolderCheck);
            Controls.Add(separator);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fileName);
            Controls.Add(getFileButton);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(447, 406);
            MinimumSize = new Size(447, 406);
            Name = "Form1";
            Text = "Duplicatero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button getFileButton;
        private Label fileName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox separator;
        private CheckBox PutInFolderCheck;
        private CheckBox opendestination;
        private RichTextBox duplicatesAmount;
        private RichTextBox FinalMessage;
    }
}
