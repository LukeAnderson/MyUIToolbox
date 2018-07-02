using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms
{
    public partial class SideBar : UserControl
    {

        private int numberOfButtons;

        public SideBar()
        {
            InitializeComponent();
        }


        [Description("Number of buttons in the sidebar"), Category("Appearance")]
        public int NumberOfButtons {
            get { return numberOfButtons; }
            set {
                numberOfButtons = value;
                // Call OnPropertyChanged whenever the property is updated
                OnNumberOfButtonsChanged(value);
            }
        }

        private void OnNumberOfButtonsChanged(int value)
        {
            sidebarLayoutPanel.Controls.Clear();

            //make rows
            //add the row styles
            for (int i = 0; i < numberOfButtons; i++)
            {
                sidebarLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }



            //add buttons
            Button button;

            for (int i = 0; i < NumberOfButtons; i++)
            {

                button = new Button
                {
                    Dock = DockStyle.Fill,
                    BackColor = SystemColors.ButtonFace,
                    Text = "Button " + sidebarLayoutPanel.Controls.Count.ToString()
                };
                sidebarLayoutPanel.Controls.Add(button);

            }
        }


       

    }
}
