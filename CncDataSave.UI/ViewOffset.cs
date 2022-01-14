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
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (checkBoxProductBlank.Checked)
            {
                
                if (checkBoxPickAllTime.Checked)
                {
                    listBoxViewDataList.DataSource = set.Local.ToBindingList();
                }
                else
                {
                    var source = db.OffsetData.Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                    listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                }

            }
            else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
            {
                MessageBox.Show("Заполните параметры сортамента", "Ошибка заполнения данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) || !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) || !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
            {
                if (checkBoxPickAllTime.Checked)
                {
                    if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData.Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData.Where(u => u.Machine == comboBoxMachineNumberView.Text).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u=> u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }

                }
            }

        }

        private void listBoxViewDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxViewDataList.Click += ListBoxViewDataList_Click;
        }

        private void ListBoxViewDataList_Click(object sender, EventArgs e)
        {
            set.Load();
            OffsetData selectedOffset = (OffsetData)listBoxViewDataList.SelectedItem;
            textBoxOffsetName.Text = selectedOffset.ToString();
            textBoxCreatedBy.Text = selectedOffset.User.ToString();
            textBoxCreationDate.Text = selectedOffset.Created.ToString();
            textBoxMachineView.Text = selectedOffset.Machine;
            textBoxDiameterView.Text = selectedOffset.Product.Diameter.ToString();
            textBoxThreadTypeView.Text = selectedOffset.Product.ThreadType;
            textBoxStandoff.Text = selectedOffset.Macro.Standoff.ToString();
            textBoxStandoffSeal.Text = selectedOffset.Macro.OdSeal.ToString();
            textBoxThreadPasses.Text = selectedOffset.Macro.ThreadPass.ToString();
            textBoxZajust.Text = selectedOffset.Macro.Zajust.ToString();
            #region X's and Z's 

            textBoxX1.Text = selectedOffset.Channel1.X1.ToString();
            textBoxX2.Text = selectedOffset.Channel1.X2.ToString();
            textBoxX3.Text = selectedOffset.Channel1.X3.ToString();
            textBoxX4.Text = selectedOffset.Channel1.X4.ToString();
            textBoxX5.Text = selectedOffset.Channel1.X5.ToString();
            textBoxX6.Text = selectedOffset.Channel1.X6.ToString();
            textBoxX7.Text = selectedOffset.Channel1.X7.ToString();
            textBoxZ1.Text = selectedOffset.Channel1.Z1.ToString();
            textBoxZ2.Text = selectedOffset.Channel1.Z2.ToString();
            textBoxZ3.Text = selectedOffset.Channel1.Z3.ToString();
            textBoxZ4.Text = selectedOffset.Channel1.Z4.ToString();
            textBoxZ5.Text = selectedOffset.Channel1.Z5.ToString();
            textBoxZ6.Text = selectedOffset.Channel1.Z6.ToString();
            textBoxZ7.Text = selectedOffset.Channel1.Z7.ToString();
            textBoxY1.Text = selectedOffset.Channel1.Y1.ToString();
            textBoxY2.Text = selectedOffset.Channel1.Y2.ToString();
            textBoxY3.Text = selectedOffset.Channel1.Y3.ToString();
            textBoxY4.Text = selectedOffset.Channel1.Y4.ToString();
            textBoxCannel2X1.Text = selectedOffset.Channel2.X1.ToString();
            textBoxCannel2X2.Text = selectedOffset.Channel2.X2.ToString();
            textBoxCannel2X3.Text = selectedOffset.Channel2.X3.ToString();
            textBoxCannel2X4.Text = selectedOffset.Channel2.X4.ToString();
            textBoxCannel2X5.Text = selectedOffset.Channel2.X5.ToString();
            textBoxCannel2X6.Text = selectedOffset.Channel2.X6.ToString();
            textBoxCannel2X7.Text = selectedOffset.Channel2.X7.ToString();
            textBoxCannel2Z1.Text = selectedOffset.Channel2.Z1.ToString();
            textBoxCannel2Z2.Text = selectedOffset.Channel2.Z2.ToString();
            textBoxCannel2Z3.Text = selectedOffset.Channel2.Z3.ToString();
            textBoxCannel2Z4.Text = selectedOffset.Channel2.Z4.ToString();
            textBoxCannel2Z5.Text = selectedOffset.Channel2.Z5.ToString();
            textBoxCannel2Z6.Text = selectedOffset.Channel2.Z6.ToString();
            textBoxCannel2Z7.Text = selectedOffset.Channel2.Z7.ToString();
            #endregion
        }

        private void textBoxOffsetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
