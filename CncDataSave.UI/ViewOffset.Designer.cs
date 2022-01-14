
namespace CncDataSave.UI
{
    partial class ViewOffset<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMachineNumberView = new System.Windows.Forms.ComboBox();
            this.comboBoxProductDiameterView = new System.Windows.Forms.ComboBox();
            this.comboBoxThreadTypeView = new System.Windows.Forms.ComboBox();
            this.dateTimePickerForView = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPickAllTime = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxViewDataList = new System.Windows.Forms.ListBox();
            this.checkBoxProductBlank = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(918, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Тип резьбы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(937, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Диаметр:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(948, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Станок:";
            // 
            // comboBoxMachineNumberView
            // 
            this.comboBoxMachineNumberView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxMachineNumberView.FormattingEnabled = true;
            this.comboBoxMachineNumberView.Items.AddRange(new object[] {
            "РНС 1",
            "РНС 2"});
            this.comboBoxMachineNumberView.Location = new System.Drawing.Point(1013, 182);
            this.comboBoxMachineNumberView.Name = "comboBoxMachineNumberView";
            this.comboBoxMachineNumberView.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMachineNumberView.TabIndex = 56;
            // 
            // comboBoxProductDiameterView
            // 
            this.comboBoxProductDiameterView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxProductDiameterView.FormattingEnabled = true;
            this.comboBoxProductDiameterView.Items.AddRange(new object[] {
            "245",
            "168",
            "324",
            "426"});
            this.comboBoxProductDiameterView.Location = new System.Drawing.Point(1013, 140);
            this.comboBoxProductDiameterView.Name = "comboBoxProductDiameterView";
            this.comboBoxProductDiameterView.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProductDiameterView.TabIndex = 55;
            // 
            // comboBoxThreadTypeView
            // 
            this.comboBoxThreadTypeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxThreadTypeView.FormattingEnabled = true;
            this.comboBoxThreadTypeView.Items.AddRange(new object[] {
            "ОТТМ",
            "ОТТГ",
            "ВМЗ-1",
            "БАТРЕСС",
            "ВМЗ-4"});
            this.comboBoxThreadTypeView.Location = new System.Drawing.Point(1013, 98);
            this.comboBoxThreadTypeView.Name = "comboBoxThreadTypeView";
            this.comboBoxThreadTypeView.Size = new System.Drawing.Size(121, 24);
            this.comboBoxThreadTypeView.TabIndex = 54;
            // 
            // dateTimePickerForView
            // 
            this.dateTimePickerForView.Location = new System.Drawing.Point(1185, 115);
            this.dateTimePickerForView.Name = "dateTimePickerForView";
            this.dateTimePickerForView.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerForView.TabIndex = 60;
            // 
            // checkBoxPickAllTime
            // 
            this.checkBoxPickAllTime.AutoSize = true;
            this.checkBoxPickAllTime.Location = new System.Drawing.Point(1185, 143);
            this.checkBoxPickAllTime.Name = "checkBoxPickAllTime";
            this.checkBoxPickAllTime.Size = new System.Drawing.Size(117, 21);
            this.checkBoxPickAllTime.TabIndex = 61;
            this.checkBoxPickAllTime.Text = "За все время";
            this.checkBoxPickAllTime.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1185, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 36);
            this.button1.TabIndex = 62;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxViewDataList
            // 
            this.listBoxViewDataList.FormattingEnabled = true;
            this.listBoxViewDataList.ItemHeight = 16;
            this.listBoxViewDataList.Location = new System.Drawing.Point(921, 286);
            this.listBoxViewDataList.Name = "listBoxViewDataList";
            this.listBoxViewDataList.Size = new System.Drawing.Size(554, 548);
            this.listBoxViewDataList.TabIndex = 63;
            // 
            // checkBoxProductBlank
            // 
            this.checkBoxProductBlank.AutoSize = true;
            this.checkBoxProductBlank.Location = new System.Drawing.Point(1013, 212);
            this.checkBoxProductBlank.Name = "checkBoxProductBlank";
            this.checkBoxProductBlank.Size = new System.Drawing.Size(130, 21);
            this.checkBoxProductBlank.TabIndex = 64;
            this.checkBoxProductBlank.Text = "Любой оффсет";
            this.checkBoxProductBlank.UseVisualStyleBackColor = true;
            // 
            // ViewOffset
            // 
            this.ClientSize = new System.Drawing.Size(1532, 884);
            this.Controls.Add(this.checkBoxProductBlank);
            this.Controls.Add(this.listBoxViewDataList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxPickAllTime);
            this.Controls.Add(this.dateTimePickerForView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMachineNumberView);
            this.Controls.Add(this.comboBoxProductDiameterView);
            this.Controls.Add(this.comboBoxThreadTypeView);
            this.Name = "ViewOffset";
            this.Load += new System.EventHandler(this.ViewOffset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMachineNumberView;
        private System.Windows.Forms.ComboBox comboBoxProductDiameterView;
        private System.Windows.Forms.ComboBox comboBoxThreadTypeView;
        private System.Windows.Forms.DateTimePicker dateTimePickerForView;
        private System.Windows.Forms.CheckBox checkBoxPickAllTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxViewDataList;
        private System.Windows.Forms.CheckBox checkBoxProductBlank;
    }
}