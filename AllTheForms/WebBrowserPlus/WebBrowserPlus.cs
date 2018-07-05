using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms.WebBrowserPlus
{
    public partial class WebBrowserPlus : UserControl
    {
        public WebBrowserPlus()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoSearch();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Process.Start("InetCpl.Cpl");
        }
    }
}
