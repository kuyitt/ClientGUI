namespace ClientGUI
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            displayBox = new TextBox();
            formatBox = new TextBox();
            send = new Button();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Location = new Point(12, 12);
            displayBox.Multiline = true;
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.ScrollBars = ScrollBars.Vertical;
            displayBox.Size = new Size(428, 266);
            displayBox.TabIndex = 0;
            // 
            // formatBox
            // 
            formatBox.Location = new Point(12, 284);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(368, 23);
            formatBox.TabIndex = 1;
            // 
            // send
            // 
            send.BackColor = Color.Cyan;
            send.Location = new Point(386, 284);
            send.Name = "send";
            send.Size = new Size(54, 23);
            send.TabIndex = 2;
            send.Text = "Send";
            send.UseVisualStyleBackColor = false;
            send.Click += send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(454, 319);
            Controls.Add(send);
            Controls.Add(formatBox);
            Controls.Add(displayBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox displayBox;
        private TextBox formatBox;
        private Button send;
    }
}
