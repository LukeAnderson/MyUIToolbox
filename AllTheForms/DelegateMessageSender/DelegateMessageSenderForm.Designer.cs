namespace MyUIToolBox.AllTheForms
{
    partial class DelegateMessageSenderForm
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
            this.recieverRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.recieverRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.recieverRichTextBox3 = new System.Windows.Forms.RichTextBox();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recieverRichTextBox1
            // 
            this.recieverRichTextBox1.Location = new System.Drawing.Point(28, 286);
            this.recieverRichTextBox1.Name = "recieverRichTextBox1";
            this.recieverRichTextBox1.Size = new System.Drawing.Size(185, 116);
            this.recieverRichTextBox1.TabIndex = 0;
            this.recieverRichTextBox1.Text = "";
            // 
            // recieverRichTextBox2
            // 
            this.recieverRichTextBox2.Location = new System.Drawing.Point(250, 286);
            this.recieverRichTextBox2.Name = "recieverRichTextBox2";
            this.recieverRichTextBox2.Size = new System.Drawing.Size(168, 116);
            this.recieverRichTextBox2.TabIndex = 1;
            this.recieverRichTextBox2.Text = "";
            // 
            // recieverRichTextBox3
            // 
            this.recieverRichTextBox3.Location = new System.Drawing.Point(464, 286);
            this.recieverRichTextBox3.Name = "recieverRichTextBox3";
            this.recieverRichTextBox3.Size = new System.Drawing.Size(169, 116);
            this.recieverRichTextBox3.TabIndex = 2;
            this.recieverRichTextBox3.Text = "";
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.Location = new System.Drawing.Point(223, 54);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(223, 139);
            this.sendRichTextBox.TabIndex = 3;
            this.sendRichTextBox.Text = "Type a message to be sent to the others";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(281, 199);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(107, 53);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "send message";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "practice message system using delegate events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MessageSender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MessageReciever1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "MessageReciever2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "MessageReciever3";
            // 
            // DelegateMessageSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(676, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendRichTextBox);
            this.Controls.Add(this.recieverRichTextBox3);
            this.Controls.Add(this.recieverRichTextBox2);
            this.Controls.Add(this.recieverRichTextBox1);
            this.Name = "DelegateMessageSenderForm";
            this.ShowIcon = false;
            this.Text = "Delegate Practice Messaging System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox recieverRichTextBox1;
        private System.Windows.Forms.RichTextBox recieverRichTextBox2;
        private System.Windows.Forms.RichTextBox recieverRichTextBox3;
        private System.Windows.Forms.RichTextBox sendRichTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}