namespace MyUIToolBox.AllTheForms.WebBrowserPlus
{
    partial class WebBrowserPlusForm
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
            this.webBrowserPlus = new MyUIToolBox.AllTheForms.WebBrowserPlus.WebBrowserPlus();
            this.SuspendLayout();
            // 
            // webBrowserPlus
            // 
            this.webBrowserPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPlus.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPlus.Name = "webBrowserPlus";
            this.webBrowserPlus.Size = new System.Drawing.Size(800, 450);
            this.webBrowserPlus.TabIndex = 0;
            // 
            // WebBrowserPlusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserPlus);
            this.Name = "WebBrowserPlusForm";
            this.Text = "WebBrowserPlusForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowserPlus webBrowserPlus;
    }
}