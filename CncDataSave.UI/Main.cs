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
        readonly CncDataSaverContext db;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        public Main()
        {
            InitializeComponent();
            db = new CncDataSaverContext();
            LoginTextBox.Text = System.Environment.UserName;
            AddOffset.Enabled = false;
            ViewOffset.Enabled = false;
            AxisCheck.Enabled = false;
            DefProgram.Enabled = false;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HT_CAPTION;
            }
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
        private void OpenChildForm(Form childForm)
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

        private void ButtonStopApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainButtonColour()
        {
            if(activeForm != null)
            {
                AddOffset.BackColor = Color.Silver;
                ViewOffset.BackColor = Color.Silver;
                AxisCheck.BackColor = Color.Silver;
                DefProgram.BackColor = Color.Silver;
            }
        }
        private void MainButtonEnabled()
        {
            AddOffset.Enabled = true;
            ViewOffset.Enabled = true;
            AxisCheck.Enabled = true;
            DefProgram.Enabled = true;
        }
        private void AddOffset_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var createOffset = new CreateOffset<OffsetData>(db.OffsetData, db);
            OpenChildForm(createOffset);
            AddOffset.Enabled = false;
            AddOffset.BackColor = Color.Gray;
        }

        private void ViewOffset_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var viewOffset = new ViewOffset<OffsetData>(db.OffsetData, db);
            OpenChildForm(viewOffset);
            ViewOffset.Enabled = false;
            ViewOffset.BackColor = Color.Gray;
        }

        private void AxisCheck_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var wearCheck = new MachineWear<OffsetData>(db.OffsetData, db);
            OpenChildForm(wearCheck);
            AxisCheck.Enabled = false;
            AxisCheck.BackColor = Color.Gray;
        }

        private void DefProgram_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var programs = new ProgramText();
            OpenChildForm(programs);
            DefProgram.Enabled = false;
            DefProgram.BackColor = Color.Gray;
        }

        private void ButtonUserNext_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var currentUserLogin = db.Users.Any(u => u.UserName == LoginTextBox.Text);
            var currentUserPassword = db.Users.Where(u => u.UserName == LoginTextBox.Text).Any(u => u.UserPassword == PasswordCheckBox.Text);
            if (currentUserLogin && currentUserPassword)
            {
                MainButtonEnabled();
                LoginLabel.Text = "Вход успешный";
                LoginButton.Hide();
                LoginTextBox.Enabled = false;
                PasswordCheckBox.Enabled = false;
            }
            else
            {
                LoginLabel.Text = "Не верные данные";
            }
        }
    }
}
