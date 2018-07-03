namespace MyUIToolBox.AllTheForms.SideBarPagination
{
    partial class sideBarPaginationForm
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
            this.sideBarPagination1 = new MyUIToolBox.AllTheForms.Clock_SearchBar_SideBar.SideBarPagination();
            this.SuspendLayout();
            // 
            // sideBarPagination1
            // 
            this.sideBarPagination1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarPagination1.Location = new System.Drawing.Point(0, 0);
            this.sideBarPagination1.Name = "sideBarPagination1";
            this.sideBarPagination1.NumberOfButtons = 3;
            this.sideBarPagination1.Size = new System.Drawing.Size(821, 538);
            this.sideBarPagination1.TabIndex = 0;
            // 
            // sideBarPaginationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 538);
            this.Controls.Add(this.sideBarPagination1);
            this.Name = "sideBarPaginationForm";
            this.Text = "sideBarPaginationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Clock_SearchBar_SideBar.SideBarPagination sideBarPagination1;
    }
}