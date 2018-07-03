namespace MyUIToolBox.AllTheForms.RadioButtonTable
{
    partial class RadioButtonTableForm
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
            this.radioButtonTable1 = new MyUIToolBox.AllTheForms.RadioButtonTable.RadioButtonTable();
            this.SuspendLayout();
            // 
            // radioButtonTable1
            // 
            this.radioButtonTable1.ButtonsText = new string[] {
        "These are",
        "changed with",
        "a string array property",
        "in the",
        "design"};
            this.radioButtonTable1.LabelText = "Label Text Property Change";
            this.radioButtonTable1.LabelTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTable1.LeftMargin = 50;
            this.radioButtonTable1.Location = new System.Drawing.Point(209, 144);
            this.radioButtonTable1.Name = "radioButtonTable1";
            this.radioButtonTable1.NumberOfButtons = 5;
            this.radioButtonTable1.Size = new System.Drawing.Size(252, 175);
            this.radioButtonTable1.TabIndex = 0;
            // 
            // RadioButtonTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonTable1);
            this.Name = "RadioButtonTableForm";
            this.Text = "RadioButtonTableForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonTable radioButtonTable1;
    }
}