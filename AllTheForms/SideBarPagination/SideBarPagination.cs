using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms.Clock_SearchBar_SideBar
{
    public partial class SideBarPagination : UserControl
    {


        private int numberOfPages;
        public List<Control> pages;



        public SideBarPagination()
        {
            InitializeComponent();
            pages = new List<Control>();
        }


        [Description("Number of buttons in the sidebar"), Category("Appearance")]
        public int NumberOfButtons {
            get { return numberOfPages; }
            set {
                numberOfPages = value;
                // Call OnPropertyChanged whenever the property is updated
                OnNumberOfPagesChanged(value);
            }



        }

        private void OnNumberOfPagesChanged(int value)
        {
            //set numberOfButtons for sideBar to make on its own
            sideBar1.NumberOfButtons = value;

            //make the pages
            Panel panel;
            for(int i = 0; i < value; i++)
            {
                panel = new Panel
                {
                    BackColor = Color.FromArgb((i * 30) % 255, (i * 70) % 255, (i * 110) % 255),
                    Dock = DockStyle.Fill
                };
                pages.Add(panel);
            }

            //show the first page.
            tableLayoutPanel.Controls.Add(pages[0]);



            //bind the pages to the buttons
            foreach (Button button in sideBar1.buttons)
            {
                button.Click += new EventHandler(sideButtonClicked);

            }







        }

        private void sideButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Control c = pages[int.Parse(button.Name)];
            tableLayoutPanel.Controls.RemoveAt(1);
            tableLayoutPanel.Controls.Add(c);
        }
    }
}
