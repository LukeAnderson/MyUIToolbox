﻿namespace MyUIToolBox.AllTheForms
{
    partial class SideBar
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
            this.sidebarLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // sidebarLayoutPanel
            // 
            this.sidebarLayoutPanel.ColumnCount = 1;
            this.sidebarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarLayoutPanel.Name = "sidebarLayoutPanel";
            this.sidebarLayoutPanel.RowCount = 1;
            this.sidebarLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarLayoutPanel.Size = new System.Drawing.Size(160, 413);
            this.sidebarLayoutPanel.TabIndex = 0;
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebarLayoutPanel);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(160, 413);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sidebarLayoutPanel;
    }
}
