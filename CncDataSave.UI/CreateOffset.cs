using CncDataSaver.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CncDataSaver.BL;
using System.Threading;

namespace CncDataSave.UI
{
    public partial class CreateOffset<T> : Form
        where T : class
    {
        CncDataSaverContext db;
        DbSet<T> set;

        public CreateOffset(DbSet<T> set, CncDataSaverContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void CreateOffset_Load(object sender, EventArgs e)
        {

        }

        private void CreateOffset_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveOffsetToDB_Click_1(object sender, EventArgs e)
        {
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

                var addedCh1 = new Channel1();
                addedCh1.X1 = Convert.ToDouble(maskedTextBoxX1.Text);
                addedCh1.Z1 = Convert.ToDouble(maskedTextBoxZ1.Text);
                addedCh1.X2 = Convert.ToDouble(maskedTextBoxX2.Text);
                addedCh1.Z2 = Convert.ToDouble(maskedTextBoxZ2.Text);
                addedCh1.X3 = Convert.ToDouble(maskedTextBoxX3.Text);
                addedCh1.Z3 = Convert.ToDouble(maskedTextBoxZ3.Text);
                addedCh1.X4 = Convert.ToDouble(maskedTextBoxX4.Text);
                addedCh1.Z4 = Convert.ToDouble(maskedTextBoxZ4.Text);
                addedCh1.X5 = Convert.ToDouble(maskedTextBoxX5.Text);
                addedCh1.Z5 = Convert.ToDouble(maskedTextBoxZ5.Text);
                addedCh1.X6 = Convert.ToDouble(maskedTextBoxX6.Text);
                addedCh1.Z6 = Convert.ToDouble(maskedTextBoxZ6.Text);
                addedCh1.X7 = Convert.ToDouble(maskedTextBoxX7.Text);
                addedCh1.Z7 = Convert.ToDouble(maskedTextBoxZ7.Text);
                addedCh1.Y1 = Convert.ToDouble(maskedTextBoxY1.Text);
                addedCh1.Y2 = Convert.ToDouble(maskedTextBoxY2.Text);
                addedCh1.Y3 = Convert.ToDouble(maskedTextBoxY3.Text);
                addedCh1.Y4 = Convert.ToDouble(maskedTextBoxY4.Text);
                var addedCh2 = new Channel2();
                addedCh2.X1 = Convert.ToDouble(maskedTextBoxCH2X1.Text);
                addedCh2.Z1 = Convert.ToDouble(maskedTextBoxCH2Z1.Text);
                addedCh2.X2 = Convert.ToDouble(maskedTextBoxCH2X2.Text);
                addedCh2.Z2 = Convert.ToDouble(maskedTextBoxCH2Z2.Text);
                addedCh2.X3 = Convert.ToDouble(maskedTextBoxCH2X3.Text);
                addedCh2.Z3 = Convert.ToDouble(maskedTextBoxCH2Z3.Text);
                addedCh2.X4 = Convert.ToDouble(maskedTextBoxCH2X4.Text);
                addedCh2.Z4 = Convert.ToDouble(maskedTextBoxCH2Z4.Text);
                addedCh2.X5 = Convert.ToDouble(maskedTextBoxCH2X5.Text);
                addedCh2.Z5 = Convert.ToDouble(maskedTextBoxCH2Z5.Text);
                addedCh2.X6 = Convert.ToDouble(maskedTextBoxCH2X6.Text);
                addedCh2.Z6 = Convert.ToDouble(maskedTextBoxCH2Z6.Text);
                addedCh2.X7 = Convert.ToDouble(maskedTextBoxCH2X7.Text);
                addedCh2.Z7 = Convert.ToDouble(maskedTextBoxCH2Z7.Text);
                var addedOffset = new Macro();
                addedOffset.OdSeal = Convert.ToDouble(maskedTextBoxSealStandoff.Text);
                addedOffset.Standoff = Convert.ToDouble(maskedTextBoxStandoff.Text);
                if (string.IsNullOrEmpty(maskedTextBoxThrPass.Text)||Convert.ToDouble(maskedTextBoxThrPass.Text) <= 0)
                {
                    addedOffset.ThreadPass = 1;
                }
                else
                {
                    addedOffset.ThreadPass = Convert.ToDouble(maskedTextBoxThrPass.Text);
                }
                addedOffset.Zajust = Convert.ToDouble(maskedTextBoxZajust.Text);
                addedOffset.Conicity = Convert.ToDouble(maskedTextBoxConicity.Text);
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
                offsetAdd.Created = DateTime.Now.Date;
                db.OffsetData.Add(offsetAdd);
                db.SaveChanges();
            }
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
