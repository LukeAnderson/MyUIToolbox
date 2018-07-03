using MyUIToolBox.AllTheForms;
using MyUIToolBox.AllTheForms.Clock_SearchBar_SideBar;
using MyUIToolBox.AllTheForms.SideBarPagination;
using System;
using System.Windows.Forms;

namespace MyUIToolBox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sideBarPaginationForm());
        }
    }
}
