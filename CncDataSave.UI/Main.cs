using CncDataSaver.BL.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace CncDataSave.UI
{
    public partial class Main : Form
    {

        readonly CncDataSaverContext db;
        /// <summary>
        /// Mouse position.
        /// </summary>
        private const int WM_NCHITTEST = 0x84;
        /// <summary>
        /// Window position.
        /// </summary>
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
        /// <summary>
        /// Method to make non frame for moving.
        /// </summary>
        /// <param name="m"></param>
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
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //Tips for close button and next user button.
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ButtonUserNext, "Сменить пользователя");
            toolTip.SetToolTip(buttonStopApp, "Закрыть приложени");
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
        /// <summary>
        /// App stop button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStopApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        /// <summary>
        /// Method for button default colors.
        /// </summary>
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
        /// <summary>
        /// Method for enable main buttons.
        /// </summary>
        private void MainButtonEnabled()
        {

            AddOffset.Enabled = true;
            ViewOffset.Enabled = true;
            AxisCheck.Enabled = true;
            DefProgram.Enabled = true;
        }
        /// <summary>
        /// Offset update form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOffset_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var createOffset = new CreateOffset<OffsetData>(db.OffsetData, db);
            OpenChildForm(createOffset);
            AddOffset.Enabled = false;
            AddOffset.BackColor = Color.Gray;
        }
        /// <summary>
        /// Offset view form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewOffset_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var viewOffset = new ViewOffset<OffsetData>(db.OffsetData, db);
            OpenChildForm(viewOffset);
            ViewOffset.Enabled = false;
            ViewOffset.BackColor = Color.Gray;
        }
        /// <summary>
        /// Axis wear check form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AxisCheck_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var wearCheck = new MachineWear<OffsetData>(db.OffsetData, db);
            OpenChildForm(wearCheck);
            AxisCheck.Enabled = false;
            AxisCheck.BackColor = Color.Gray;
        }
        /// <summary>
        /// CNC default programs form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefProgram_Click(object sender, EventArgs e)
        {
            MainButtonColour();
            MainButtonEnabled();
            var programs = new ProgramText();
            OpenChildForm(programs);
            DefProgram.Enabled = false;
            DefProgram.BackColor = Color.Gray;
        }
        /// <summary>
        /// Close current session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUserNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите данные нового пользователя", "Смена пользователя",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();

        }
        /// <summary>
        /// Login button for authorization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var currentUserLogin = db.Users.Any(u => u.UserName == LoginTextBox.Text);
            var currentUserPassword = db.Users.Where(u => u.UserName == LoginTextBox.Text).Any(u => u.UserPassword == PasswordCheckBox.Text);
            if (currentUserLogin && currentUserPassword)
            {
                MainButtonEnabled();
                LoginLabel.Text = "Вход успешный";
                LoginButton.Hide();
                ButtonUserNext.Visible = true;
                LoginTextBox.Enabled = false;
                PasswordCheckBox.Enabled = false;

            }
            else
            {
                LoginLabel.Text = "Не верные данные";
            }
        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordCheckBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
