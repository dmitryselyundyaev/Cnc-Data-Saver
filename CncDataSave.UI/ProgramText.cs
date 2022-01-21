using CncDataSave.UI.Properties;
using System;
using System.Windows.Forms;

namespace CncDataSave.UI
{
    public partial class ProgramText : Form
    {
        public ProgramText()
        {
            InitializeComponent();
        }

        private void TreeViewListOfPrograms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewListOfPrograms.Click += TreeViewListOfPrograms_Click;
            
        }

        private void TreeViewListOfPrograms_Click(object sender, EventArgs e)
        {
            var content = treeViewListOfPrograms.SelectedNode;
            switch (content.Name)
            {
                case "DimensionBTC":
                    textBoxProgramView.Text = Resources.BTCDimension;
                    break;

                case "CalculationBTC":
                    textBoxProgramView.Text = Resources.BTCCalculation;
                    break;
                case "ProcessBTC":
                    textBoxProgramView.Text = Resources.BTCProcess;
                    break;
                case "DimensionOTTM":
                    textBoxProgramView.Text = Resources.BTCDimension;
                    break;

                case "CalculationOTTM":
                    textBoxProgramView.Text = Resources.BTCCalculation;
                    break;
                case "ProcessOTTM":
                    textBoxProgramView.Text = Resources.BTCProcess;
                    break;
                case "DimensionVSW-1":
                    textBoxProgramView.Text = Resources.BTCDimension;
                    break;

                case "CalculationVSW-1":
                    textBoxProgramView.Text = Resources.BTCCalculation;
                    break;
                case "ProcessVSW-1":
                    textBoxProgramView.Text = Resources.BTCProcess;
                    break;
                case "DimensionVSW-4":
                    textBoxProgramView.Text = Resources.BTCDimension;
                    break;

                case "CalculationVSW-4":
                    textBoxProgramView.Text = Resources.BTCCalculation;
                    break;
                case "ProcessVSW-4":
                    textBoxProgramView.Text = Resources.BTCProcess;
                    break;
            }
        }

        private void Programs_Load(object sender, EventArgs e)
        {

        }
        private void CleanButton_Click(object sender, EventArgs e)
        {
            textBoxProgramView.Text = null;
        }
    }
}
