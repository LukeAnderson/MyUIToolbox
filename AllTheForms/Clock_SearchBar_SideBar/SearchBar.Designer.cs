namespace MyUIToolBox.AllTheForms
{
    partial class SearchBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBarLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBarLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBarLayoutPanel
            // 
            this.searchBarLayoutPanel.ColumnCount = 2;
            this.searchBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.searchBarLayoutPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchBarLayoutPanel.Controls.Add(this.searchTextBox, 0, 0);
            this.searchBarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBarLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchBarLayoutPanel.Name = "searchBarLayoutPanel";
            this.searchBarLayoutPanel.RowCount = 1;
            this.searchBarLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchBarLayoutPanel.Size = new System.Drawing.Size(220, 43);
            this.searchBarLayoutPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(108, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 37);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(99, 38);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Search";
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBarLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(0, 43);
            this.MinimumSize = new System.Drawing.Size(220, 43);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(220, 43);
            this.searchBarLayoutPanel.ResumeLayout(false);
            this.searchBarLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchBarLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}
