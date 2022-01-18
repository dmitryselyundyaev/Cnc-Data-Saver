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


        private void Main_Load(object sender, EventArgs e)
        {

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

        private void buttonStopApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mainButtonColour()
        {
            if(activeForm != null)
            {
                AddOffset.BackColor = Color.Silver;
                ViewOffset.BackColor = Color.Silver;
                AxisCheck.BackColor = Color.Silver;
                DefProgram.BackColor = Color.Silver;
            }
        }
        private void AddOffset_Click(object sender, EventArgs e)
        {
            mainButtonColour();
            var CreateOffset = new CreateOffset<OffsetData>(db.OffsetData, db);
            openChildForm(CreateOffset);
            AddOffset.BackColor = Color.Gray;
        }

        private void ViewOffset_Click(object sender, EventArgs e)
        {
            mainButtonColour();
            var viewOffset = new ViewOffset<OffsetData>(db.OffsetData, db);
            openChildForm(viewOffset);
            ViewOffset.BackColor = Color.Gray;
        }

        private void AxisCheck_Click(object sender, EventArgs e)
        {
            mainButtonColour();
            var wearCheck = new MachineWear<OffsetData>(db.OffsetData, db);
            openChildForm(wearCheck);
            AxisCheck.BackColor = Color.Gray;
        }

        private void DefProgram_Click(object sender, EventArgs e)
        {
            mainButtonColour();
            var programs = new ProgramText();
            openChildForm(programs);
            DefProgram.BackColor = Color.Gray;
        }
    }
}
