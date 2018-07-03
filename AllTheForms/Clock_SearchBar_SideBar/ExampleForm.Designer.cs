namespace MyUIToolBox.AllTheForms.Clock_SearchBar_SideBar
{
    partial class ExampleForm
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
            this.sideBar1 = new MyUIToolBox.AllTheForms.SideBar();
            this.searchBar1 = new MyUIToolBox.AllTheForms.SearchBar();
            this.clock1 = new MyUIToolBox.AllTheForms.Clock();
            this.sideBarPagination1 = new MyUIToolBox.AllTheForms.Clock_SearchBar_SideBar.SideBarPagination();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sideBar1.Location = new System.Drawing.Point(12, 12);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.NumberOfButtons = 5;
            this.sideBar1.Size = new System.Drawing.Size(125, 413);
            this.sideBar1.TabIndex = 2;
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBar1.Location = new System.Drawing.Point(187, 30);
            this.searchBar1.MaximumSize = new System.Drawing.Size(0, 43);
            this.searchBar1.MinimumSize = new System.Drawing.Size(220, 43);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(220, 43);
            this.searchBar1.TabIndex = 1;
            // 
            // clock1
            // 
            this.clock1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clock1.Location = new System.Drawing.Point(681, 403);
            this.clock1.Margin = new System.Windows.Forms.Padding(0);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(110, 22);
            this.clock1.TabIndex = 0;
            // 
            // sideBarPagination1
            // 
            this.sideBarPagination1.Location = new System.Drawing.Point(198, 112);
            this.sideBarPagination1.Name = "sideBarPagination1";
            this.sideBarPagination1.NumberOfButtons = 5;
            this.sideBarPagination1.Size = new System.Drawing.Size(383, 326);
            this.sideBarPagination1.TabIndex = 3;
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideBarPagination1);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.searchBar1);
            this.Controls.Add(this.clock1);
            this.Name = "ExampleForm";
            this.Text = "ExampleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Clock clock1;
        private SearchBar searchBar1;
        private SideBar sideBar1;
        private SideBarPagination sideBarPagination1;
    }
}