namespace SimpleChat.Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BtnSend = new Button();
            txtMessage = new TextBox();
            BtnClear = new Button();
            lstChat = new ListBox();
            SuspendLayout();
            // 
            // BtnSend
            // 
            BtnSend.Cursor = Cursors.Hand;
            BtnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSend.Location = new Point(535, 278);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(75, 28);
            BtnSend.TabIndex = 1;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(28, 278);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(490, 60);
            txtMessage.TabIndex = 2;
            // 
            // BtnClear
            // 
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(535, 310);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 28);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // lstChat
            // 
            lstChat.FormattingEnabled = true;
            lstChat.ItemHeight = 15;
            lstChat.Location = new Point(28, 12);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(582, 259);
            lstChat.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 351);
            Controls.Add(lstChat);
            Controls.Add(txtMessage);
            Controls.Add(BtnClear);
            Controls.Add(BtnSend);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Chat Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnSend;
        private TextBox txtMessage;
        private Button BtnClear;
        private ListBox lstChat;
    }
}
