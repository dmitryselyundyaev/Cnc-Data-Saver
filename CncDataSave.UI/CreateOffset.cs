using CncDataSaver.BL.Model;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CncDataSave.UI
{
    public partial class CreateOffset<T> : Form
        where T : class
    {
        readonly CncDataSaverContext db;
        private readonly DbSet<T> set;

        public CreateOffset(DbSet<T> set, CncDataSaverContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();

        }

        private void CreateOffset_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Default colours for combobox.
        /// </summary>
        private void OffsetComboBoxTextColourDef()
        {
            comboBoxThreadType.BackColor = Color.Gray;
            comboBoxProductDiameter.BackColor = Color.Gray;
            comboBoxMachineNumber.BackColor = Color.Gray;
        }

        /// <summary>
        /// Button to save offset to data base.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveOffsetToDB_Click_1(object sender, EventArgs e)
        {
            labelIsSaved.Hide();
            if (string.IsNullOrEmpty(comboBoxThreadType.Text) || string.IsNullOrEmpty(comboBoxProductDiameter.Text) || string.IsNullOrEmpty(comboBoxMachineNumber.Text))
            {
                MessageBox.Show("Заполните параметры сортамента", "Ошибка заполнения данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrEmpty(comboBoxThreadType.Text))
                {
                    comboBoxThreadType.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(comboBoxProductDiameter.Text))
                {
                    comboBoxProductDiameter.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(comboBoxMachineNumber.Text))
                {
                    comboBoxMachineNumber.BackColor = Color.Red;
                }
            }

            else
            {
                OffsetComboBoxTextColourDef();
                set.Load();
                var systemName = Environment.UserName;
                User currentUser;
                if (db.Users.Any(u => u.UserName == systemName))
                {
                    currentUser = db.Users.FirstOrDefault(u => u.UserName == systemName);
                }
                else
                {
                    currentUser = new User();
                    currentUser.UserName = systemName;
                    db.Users.Add(currentUser);
                    db.SaveChanges();
                }
                #region Getting data from text box.
                var addedCh1 = new Channel1();
                addedCh1.X1 = Convert.ToDecimal(maskedTextBoxX1.Text);
                addedCh1.Z1 = Convert.ToDecimal(maskedTextBoxZ1.Text);
                addedCh1.X2 = Convert.ToDecimal(maskedTextBoxX2.Text);
                addedCh1.Z2 = Convert.ToDecimal(maskedTextBoxZ2.Text);
                addedCh1.X3 = Convert.ToDecimal(maskedTextBoxX3.Text);
                addedCh1.Z3 = Convert.ToDecimal(maskedTextBoxZ3.Text);
                addedCh1.X4 = Convert.ToDecimal(maskedTextBoxX4.Text);
                addedCh1.Z4 = Convert.ToDecimal(maskedTextBoxZ4.Text);
                addedCh1.X5 = Convert.ToDecimal(maskedTextBoxX5.Text);
                addedCh1.Z5 = Convert.ToDecimal(maskedTextBoxZ5.Text);
                addedCh1.X6 = Convert.ToDecimal(maskedTextBoxX6.Text);
                addedCh1.Z6 = Convert.ToDecimal(maskedTextBoxZ6.Text);
                addedCh1.X7 = Convert.ToDecimal(maskedTextBoxX7.Text);
                addedCh1.Z7 = Convert.ToDecimal(maskedTextBoxZ7.Text);
                addedCh1.Y1 = Convert.ToDecimal(maskedTextBoxY1.Text);
                addedCh1.Y2 = Convert.ToDecimal(maskedTextBoxY2.Text);
                addedCh1.Y3 = Convert.ToDecimal(maskedTextBoxY3.Text);
                addedCh1.Y4 = Convert.ToDecimal(maskedTextBoxY4.Text);
                var addedCh2 = new Channel2();
                addedCh2.X1 = Convert.ToDecimal(maskedTextBoxCH2X1.Text);
                addedCh2.Z1 = Convert.ToDecimal(maskedTextBoxCH2Z1.Text);
                addedCh2.X2 = Convert.ToDecimal(maskedTextBoxCH2X2.Text);
                addedCh2.Z2 = Convert.ToDecimal(maskedTextBoxCH2Z2.Text);
                addedCh2.X3 = Convert.ToDecimal(maskedTextBoxCH2X3.Text);
                addedCh2.Z3 = Convert.ToDecimal(maskedTextBoxCH2Z3.Text);
                addedCh2.X4 = Convert.ToDecimal(maskedTextBoxCH2X4.Text);
                addedCh2.Z4 = Convert.ToDecimal(maskedTextBoxCH2Z4.Text);
                addedCh2.X5 = Convert.ToDecimal(maskedTextBoxCH2X5.Text);
                addedCh2.Z5 = Convert.ToDecimal(maskedTextBoxCH2Z5.Text);
                addedCh2.X6 = Convert.ToDecimal(maskedTextBoxCH2X6.Text);
                addedCh2.Z6 = Convert.ToDecimal(maskedTextBoxCH2Z6.Text);
                addedCh2.X7 = Convert.ToDecimal(maskedTextBoxCH2X7.Text);
                addedCh2.Z7 = Convert.ToDecimal(maskedTextBoxCH2Z7.Text);
                var addedOffset = new Macro();
                addedOffset.OdSeal = Convert.ToDecimal(maskedTextBoxSealStandoff.Text);
                addedOffset.Standoff = Convert.ToDecimal(maskedTextBoxStandoff.Text);
                if (string.IsNullOrEmpty(maskedTextBoxThrPass.Text)||Convert.ToDouble(maskedTextBoxThrPass.Text) <= 0)
                {
                    addedOffset.ThreadPass = 1;
                }
                else
                {
                    addedOffset.ThreadPass = Convert.ToDecimal(maskedTextBoxThrPass.Text);
                }
                addedOffset.Zajust = Convert.ToDecimal(maskedTextBoxZajust.Text);
                addedOffset.Conicity = Convert.ToDecimal(maskedTextBoxConicity.Text);
                var addedGeometry = new Product();
                addedGeometry.Diameter = Convert.ToInt32(comboBoxProductDiameter.Text);
                addedGeometry.ThreadType = comboBoxThreadType.Text;
                db.Products.Add(addedGeometry);
                db.Channel1.Add(addedCh1);
                db.Channel2.Add(addedCh2);
                db.Macros.Add(addedOffset);
                var offsetAdd = new OffsetData();
                offsetAdd.Channel1 = addedCh1;
                offsetAdd.Channel2 = addedCh2;
                offsetAdd.Macro = addedOffset;
                offsetAdd.Product = addedGeometry;
                offsetAdd.UserId = currentUser.UserId;
                offsetAdd.Machine = comboBoxMachineNumber.Text;
                offsetAdd.Created = DateTime.Now;
                offsetAdd.Comment = textBoxComment.Text;
                var dbCount = db.OffsetData.Count();
                db.OffsetData.Add(offsetAdd);
                #endregion
                db.SaveChanges();
                if (db.OffsetData.Count() > dbCount)
                {
                    labelIsSaved.Show();
                }
                else
                {
                    labelIsSaved.BackColor = Color.Red;
                    labelIsSaved.Text = "Не выполнено";
                    labelIsSaved.Show();
                }
            }
            
        }

        private void CreateOffset_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIsSaved_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxZajust_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxThrPass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxSealStandoff_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxStandoff_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxConicity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2Z1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCH2X1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxY4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxY3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxY2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxY1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxZ1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxX1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMachineNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProductDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxThreadType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
