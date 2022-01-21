using CncDataSave.UI.Properties;
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
        readonly CncDataSaverContext db;
        private readonly DbSet<T> set;
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
        /// Search button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (checkBoxProductBlank.Checked)
            {
                
                if (checkBoxPickAllTime.Checked)
                {
                    var source = db.OffsetData.OrderByDescending(u => u.OffsetDataId).ToList();
                    listBoxViewDataList.DataSource = source;
                }
                else
                {
                    var source = db.OffsetData.Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).OrderByDescending(u => u.OffsetDataId).ToList();
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
                        var source = db.OffsetData.Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData.Where(u => u.Machine == comboBoxMachineNumberView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if(!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                    }
                    else
                    {
                        var convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
                        var source = db.OffsetData
                            .Where(u=> u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
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
            textBoxStandoff.Text = string.Format("{0:N4}", selectedOffset.Macro.Standoff);
            textBoxStandoffSeal.Text = string.Format("{0:N4}", selectedOffset.Macro.OdSeal);
            textBoxThreadPasses.Text = string.Format("{0:N4}", selectedOffset.Macro.ThreadPass);
            textBoxZajust.Text = string.Format("{0:N4}", selectedOffset.Macro.Zajust);
            textBoxCommentView.Text = selectedOffset.Comment.ToString();
            #region X's and Z's 

            textBoxX1.Text = string.Format("{0:N4}", selectedOffset.Channel1.X1);
            textBoxX2.Text = string.Format("{0:N4}", selectedOffset.Channel1.X2);
            textBoxX3.Text = string.Format("{0:N4}", selectedOffset.Channel1.X3);
            textBoxX4.Text = string.Format("{0:N4}", selectedOffset.Channel1.X4);
            textBoxX5.Text = string.Format("{0:N4}", selectedOffset.Channel1.X5);
            textBoxX6.Text = string.Format("{0:N4}", selectedOffset.Channel1.X6);
            textBoxX7.Text = string.Format("{0:N4}", selectedOffset.Channel1.X7);
            textBoxZ1.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z1);
            textBoxZ2.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z2);
            textBoxZ3.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z3);
            textBoxZ4.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z4);
            textBoxZ5.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z5);
            textBoxZ6.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z6);
            textBoxZ7.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z7);
            textBoxY1.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y1);
            textBoxY2.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y2);
            textBoxY3.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y3);
            textBoxY4.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y4);
            textBoxCannel2X1.Text = string.Format("{0:N4}", selectedOffset.Channel2.X1);
            textBoxCannel2X2.Text = string.Format("{0:N4}", selectedOffset.Channel2.X2);
            textBoxCannel2X3.Text = string.Format("{0:N4}", selectedOffset.Channel2.X3);
            textBoxCannel2X4.Text = string.Format("{0:N4}", selectedOffset.Channel2.X4);
            textBoxCannel2X5.Text = string.Format("{0:N4}", selectedOffset.Channel2.X5);
            textBoxCannel2X6.Text = string.Format("{0:N4}", selectedOffset.Channel2.X6);
            textBoxCannel2X7.Text = string.Format("{0:N4}", selectedOffset.Channel2.X7);
            textBoxCannel2Z1.Text = string.Format("{0:N4}", selectedOffset.Channel2.Z1);
            textBoxCannel2Z2.Text = string.Format("{0:N4}", selectedOffset.Channel2.X2);
            textBoxCannel2Z3.Text = string.Format("{0:N4}", selectedOffset.Channel2.X3);
            textBoxCannel2Z4.Text = string.Format("{0:N4}", selectedOffset.Channel2.X4);
            textBoxCannel2Z5.Text = string.Format("{0:N4}", selectedOffset.Channel2.X5);
            textBoxCannel2Z6.Text = string.Format("{0:N4}", selectedOffset.Channel2.X6);
            textBoxCannel2Z7.Text = string.Format("{0:N4}", selectedOffset.Channel2.X7);
            #endregion
        }


    }
}
