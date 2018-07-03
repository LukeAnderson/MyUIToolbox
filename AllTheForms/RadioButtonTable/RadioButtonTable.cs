using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUIToolBox.AllTheForms.RadioButtonTable
{
    public partial class RadioButtonTable : UserControl
    {

        private List<RadioButton> radioButtons;



        #region properties

        #region numberOfButtons
        private int numberOfButtons;
        [Description("Number of buttons in the table"), Category("Data")]
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
            tableLayoutPanel.Controls.Clear();

            var tableControls = tableLayoutPanel.Controls;

            //add the label
            tableControls.Add(MakeLabel(labelText));

            //add the buttons
            for (int i = 0; i < value; i++)
            {
                tableControls.Add(MakeRadioButton(i.ToString()));
            }
        }

        #endregion

        #region labelText
        private string labelText;
        [Description("Label text of table"), Category("Appearance")]
        public string LabelText {
            get { return labelText; }
            set {
                labelText = value;
                // Call OnPropertyChanged whenever the property is updated
                OnLabelTextChanged(value);
            }
        }


        private void OnLabelTextChanged(string value)
        {
            if (tableLayoutPanel.Controls.Count != 0)
            {
                tableLayoutPanel.Controls[0].Text = value;
            }
            else
                tableLayoutPanel.Controls.Add(MakeLabel(value));
        }
        #endregion

        #region buttonsText

        private string[] buttonsText;
        [Description("Text of buttons in the table"), Category("Data")]
        public string[] ButtonsText {
            get { return buttonsText; }
            set {
                buttonsText = value;
                OnButtonsTextChanged();
            }
        }

        private void OnButtonsTextChanged()
        {
            radioButtons.Clear();
            radioButtons.AddRange(tableLayoutPanel.Controls.OfType<RadioButton>());
            for (int i = 0; i < radioButtons.Count; i++)
            {
                radioButtons[i].Text = buttonsText[i];
            }
        }

        #endregion

        #region labelTextAlignment
        private ContentAlignment labelTextAlignment;
        [Description("Change content Alignment of the label"), Category("Data")]
        public ContentAlignment LabelTextAlignment {
            get { return labelTextAlignment; }
            set {
                labelTextAlignment = value;
                OnLabelTextAlignment();
            }
        }


        private void OnLabelTextAlignment()
        {
            if (tableLayoutPanel.Controls.Count != 0 && labelText != null)
            {
                ((Label)tableLayoutPanel.Controls[0]).TextAlign = labelTextAlignment;
            }
            else
                tableLayoutPanel.Controls.Add(MakeLabel(labelText));
        }
        #endregion

        #region  all buttons margin

        private int allButtonsLeftMargin;
        [Description("Change left margin of all the buttons"), Category("Data")]
        public int LeftMargin {
            get { return allButtonsLeftMargin; }
            set {
                allButtonsLeftMargin = value;
                OnAllButtonsLeftMarginChanged();
            }
        }

        private void OnAllButtonsLeftMarginChanged()
        {
            radioButtons.Clear();
            radioButtons.AddRange(tableLayoutPanel.Controls.OfType<RadioButton>());

            for (int i = 0; i < radioButtons.Count; i++)
            {
                var margin = radioButtons[i].Margin;
                margin.Left = allButtonsLeftMargin;
                radioButtons[i].Margin = margin;
            }

        }

        #endregion


        #endregion


        public RadioButtonTable()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>();
            labelTextAlignment = ContentAlignment.TopLeft;
            labelText = "label";
        }



        private Label MakeLabel(string text)
        {
            Label label = new Label
            {
                Text = text,
                Font = new Font("Arial", 14, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = labelTextAlignment
            };
            return label;
        }

        private RadioButton MakeRadioButton(string text)
        {
            RadioButton radioButton = new RadioButton
            {
                Text = text,
                Dock = DockStyle.Fill
            };
            return radioButton;
        }

        public RadioButton GetChecked()
        {
            return radioButtons.Find(x => x.Checked);
        }
    }
}
