using CncDataSaver.BL.Model;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CncDataSaver.BL;

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

        private void CreateOffset_Load_1(object sender, EventArgs e)
        {

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
            }
            else
            {
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
    }
}
