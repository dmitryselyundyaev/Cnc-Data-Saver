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

namespace CncDataSave.UI
{
    public partial class ViewOffset<T> : Form
        where T : class
    {
        CncDataSaverContext db;
        DbSet<T> set;
        public ViewOffset(DbSet<T> set, CncDataSaverContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();
        }

        private void ViewOffset_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка поиска в базе,с фильтрами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxProductBlank.Checked)
            {
                if (checkBoxPickAllTime.Checked)
                {
                    listBoxViewDataList.DataSource = set.Local.ToBindingList();
                }
                else
                {
                    var source = db.OffsetData.Where(u => u.Created == dateTimePickerForView.Value.Date).ToList();
                    listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                }

            }
            else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) || string.IsNullOrEmpty(comboBoxProductDiameterView.Text) || string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
            {
                MessageBox.Show("Заполните параметры сортамента", "Ошибка заполнения данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBoxPickAllTime.Checked)
                {
                    var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                    var source = db.OffsetData
                        .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                        .Where(u => u.Product.Diameter == convertedDiameter)
                        .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).ToList();
                    listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                }
                else
                {
                    var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                    var source = db.OffsetData
                        .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                        .Where(u => u.Product.Diameter == convertedDiameter)
                        .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                        .Where(u => u.Created == dateTimePickerForView.Value.Date).ToList();
                    listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                }
            }

        }
    }
}
