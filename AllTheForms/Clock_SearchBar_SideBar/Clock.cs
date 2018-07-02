using System;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms
{
    public partial class Clock : UserControl
    {
        Timer secondTimer;
        public Clock()
        {
            InitializeComponent();

            secondTimer = new Timer();
            secondTimer.Tick += new EventHandler(second_Tick);
            secondTimer.Start();
        }

        //this is called once a second.
        private void second_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
