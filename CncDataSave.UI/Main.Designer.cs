
namespace CncDataSave.UI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffsetViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьСостояниеОсейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаИнструментаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устранениеПодрезаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корректировкаНатягаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыИСкоростиРезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростиРезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныеПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вМЗ1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вМЗ4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТТМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТТГToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бАТРЕССToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вспомогательныеПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelMainChild = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationsToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.режимыИСкоростиРезанияToolStripMenuItem,
            this.исходныеПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateOffsetToolStripMenuItem,
            this.OffsetViewToolStripMenuItem,
            this.проверитьСостояниеОсейToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.OperationsToolStripMenuItem.Text = "Операции";
            this.OperationsToolStripMenuItem.Click += new System.EventHandler(this.операцииToolStripMenuItem_Click);
            // 
            // CreateOffsetToolStripMenuItem
            // 
            this.CreateOffsetToolStripMenuItem.Name = "CreateOffsetToolStripMenuItem";
            this.CreateOffsetToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.CreateOffsetToolStripMenuItem.Text = "Добавить оффсет";
            this.CreateOffsetToolStripMenuItem.Click += new System.EventHandler(this.CreateOffsetToolStripMenuItem_Click);
            // 
            // OffsetViewToolStripMenuItem
            // 
            this.OffsetViewToolStripMenuItem.Name = "OffsetViewToolStripMenuItem";
            this.OffsetViewToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.OffsetViewToolStripMenuItem.Text = "Посмотреть оффсет";
            this.OffsetViewToolStripMenuItem.Click += new System.EventHandler(this.OffsetViewToolStripMenuItem_Click);
            // 
            // проверитьСостояниеОсейToolStripMenuItem
            // 
            this.проверитьСостояниеОсейToolStripMenuItem.Name = "проверитьСостояниеОсейToolStripMenuItem";
            this.проверитьСостояниеОсейToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.проверитьСостояниеОсейToolStripMenuItem.Text = "Проверить состояние осей";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заменаИнструментаToolStripMenuItem,
            this.устранениеПодрезаToolStripMenuItem,
            this.корректировкаНатягаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // заменаИнструментаToolStripMenuItem
            // 
            this.заменаИнструментаToolStripMenuItem.Name = "заменаИнструментаToolStripMenuItem";
            this.заменаИнструментаToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.заменаИнструментаToolStripMenuItem.Text = "Замена инструмента";
            // 
            // устранениеПодрезаToolStripMenuItem
            // 
            this.устранениеПодрезаToolStripMenuItem.Name = "устранениеПодрезаToolStripMenuItem";
            this.устранениеПодрезаToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.устранениеПодрезаToolStripMenuItem.Text = "Устранение подреза";
            // 
            // корректировкаНатягаToolStripMenuItem
            // 
            this.корректировкаНатягаToolStripMenuItem.Name = "корректировкаНатягаToolStripMenuItem";
            this.корректировкаНатягаToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.корректировкаНатягаToolStripMenuItem.Text = "Корректировка натяга";
            // 
            // режимыИСкоростиРезанияToolStripMenuItem
            // 
            this.режимыИСкоростиРезанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скоростиРезанияToolStripMenuItem,
            this.режимыРаботыToolStripMenuItem});
            this.режимыИСкоростиРезанияToolStripMenuItem.Name = "режимыИСкоростиРезанияToolStripMenuItem";
            this.режимыИСкоростиРезанияToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.режимыИСкоростиРезанияToolStripMenuItem.Text = "Режимы и скорости резания";
            // 
            // скоростиРезанияToolStripMenuItem
            // 
            this.скоростиРезанияToolStripMenuItem.Name = "скоростиРезанияToolStripMenuItem";
            this.скоростиРезанияToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.скоростиРезанияToolStripMenuItem.Text = "Скорости резания";
            // 
            // режимыРаботыToolStripMenuItem
            // 
            this.режимыРаботыToolStripMenuItem.Name = "режимыРаботыToolStripMenuItem";
            this.режимыРаботыToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.режимыРаботыToolStripMenuItem.Text = "Режимы работы";
            // 
            // исходныеПрограммыToolStripMenuItem
            // 
            this.исходныеПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вМЗ1ToolStripMenuItem,
            this.вМЗ4ToolStripMenuItem,
            this.оТТМToolStripMenuItem,
            this.оТТГToolStripMenuItem,
            this.бАТРЕССToolStripMenuItem,
            this.вспомогательныеПрограммыToolStripMenuItem});
            this.исходныеПрограммыToolStripMenuItem.Name = "исходныеПрограммыToolStripMenuItem";
            this.исходныеПрограммыToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.исходныеПрограммыToolStripMenuItem.Text = "Исходные программы";
            // 
            // вМЗ1ToolStripMenuItem
            // 
            this.вМЗ1ToolStripMenuItem.Name = "вМЗ1ToolStripMenuItem";
            this.вМЗ1ToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.вМЗ1ToolStripMenuItem.Text = "ВМЗ - 1";
            // 
            // вМЗ4ToolStripMenuItem
            // 
            this.вМЗ4ToolStripMenuItem.Name = "вМЗ4ToolStripMenuItem";
            this.вМЗ4ToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.вМЗ4ToolStripMenuItem.Text = "ВМЗ - 4";
            // 
            // оТТМToolStripMenuItem
            // 
            this.оТТМToolStripMenuItem.Name = "оТТМToolStripMenuItem";
            this.оТТМToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.оТТМToolStripMenuItem.Text = "ОТТМ";
            // 
            // оТТГToolStripMenuItem
            // 
            this.оТТГToolStripMenuItem.Name = "оТТГToolStripMenuItem";
            this.оТТГToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.оТТГToolStripMenuItem.Text = "ОТТГ";
            // 
            // бАТРЕССToolStripMenuItem
            // 
            this.бАТРЕССToolStripMenuItem.Name = "бАТРЕССToolStripMenuItem";
            this.бАТРЕССToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.бАТРЕССToolStripMenuItem.Text = "БАТРЕСС";
            // 
            // вспомогательныеПрограммыToolStripMenuItem
            // 
            this.вспомогательныеПрограммыToolStripMenuItem.Name = "вспомогательныеПрограммыToolStripMenuItem";
            this.вспомогательныеПрограммыToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.вспомогательныеПрограммыToolStripMenuItem.Text = "Вспомогательные программы";
            // 
            // panelMainChild
            // 
            this.panelMainChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainChild.Location = new System.Drawing.Point(0, 30);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(1578, 820);
            this.panelMainChild.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1578, 849);
            this.Controls.Add(this.panelMainChild);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OffsetViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьСостояниеОсейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаИнструментаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устранениеПодрезаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корректировкаНатягаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимыИСкоростиРезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростиРезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимыРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныеПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вМЗ1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вМЗ4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТТМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТТГToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бАТРЕССToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вспомогательныеПрограммыToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelMainChild;
    }
}

