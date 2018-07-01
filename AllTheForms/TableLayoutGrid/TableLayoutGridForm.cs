using System.Drawing;
using System.Windows.Forms;

namespace MyUIToolBox
{
    public partial class TableLayoutGridForm : Form
    {
        //just an empty form
        public TableLayoutGridForm()
        {
            InitializeComponent();

            //dynamically make a grid using tablelayout. Panels will be in each cell
            TableLayoutPanel grid = initializeGrid(8, 8,Color.LightBlue,Color.LightGoldenrodYellow);

            //access a panel at a position 
            int col = 1; int row = 4;
            Panel p = (Panel)grid.GetControlFromPosition(col,row);
        }

        public TableLayoutPanel initializeGrid(int numColumns,int numRows,Color colorA,Color colorB)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tlp.Dock = DockStyle.Fill;

   
            #region set row/column styles
            //add the row styles
            for (int i = 0; i <numRows; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }

            //add the column styles
            for(int i = 0; i < numColumns; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            #endregion

            //add the panels into the grid
            for (int i = 0; i < numColumns; i++)
            {
                for(int j = 0; j< numRows; j++)
                {
                    tlp.Controls.Add(MakePanelWithLabel(tlp.Controls.Count.ToString()), j, i);
                    tlp.GetControlFromPosition(j,i).BackColor = ((j+i) % 2) == 0 ? colorA : colorB;
                }
            }

            //add the table layout panel where you wnat
            Controls.Add(tlp);
            return tlp;
        }

        public Label MakeLabel(string labelText)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Margin = getNewMargin(label.Margin, 0);


            label.Text = labelText;
            return label;
        }

        public Panel MakePanel()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Margin = getNewMargin(panel.Margin, 0);
            return panel;
        }

        public Panel MakePanelWithLabel(string labelText)
        {
            Panel panel = MakePanel();
            panel.Controls.Add(MakeLabel(labelText));
            return panel;
        }

        public Padding getNewMargin(Padding margin, int all)
        {
            Padding newMargin = margin;
            newMargin.All = all;
            return newMargin;
        }
    }
}
