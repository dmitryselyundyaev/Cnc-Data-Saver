using CncDataSaver.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CncDataSaver.BL;



namespace CncDataSave.UI
{
    public partial class Main : Form
    {
        CncDataSaverContext db;
        /// <summary>
        /// Initialize components for main form.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            db = new CncDataSaverContext();

            
        }
        /// <summary>
        /// Opening offset creation tab in main panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreateOffset = new CreateOffset<OffsetData>(db.OffsetData,db);
            openChildForm(CreateOffset);
            
        }

        private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opening offset view tab in main panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OffsetViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ViewOffset = new ViewOffset<OffsetData>(db.OffsetData, db);
            openChildForm(ViewOffset);
        }
        /// <summary>
        /// Flag for method with child form.
        /// </summary>
        private Form activeForm = null;
        /// <summary>
        /// Method which operate child forms for main panel
        /// </summary>
        /// <param name="childForm">Child form for main panel</param>
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainChild.Controls.Add(childForm);
            panelMainChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
