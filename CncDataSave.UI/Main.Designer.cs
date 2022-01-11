
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
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОффсетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьОффсетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.режимыИСкоростиРезанияToolStripMenuItem,
            this.исходныеПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1585, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОффсетToolStripMenuItem,
            this.посмотретьОффсетToolStripMenuItem,
            this.проверитьСостояниеОсейToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            this.операцииToolStripMenuItem.Click += new System.EventHandler(this.операцииToolStripMenuItem_Click);
            // 
            // добавитьОффсетToolStripMenuItem
            // 
            this.добавитьОффсетToolStripMenuItem.Name = "добавитьОффсетToolStripMenuItem";
            this.добавитьОффсетToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.добавитьОффсетToolStripMenuItem.Text = "Добавить оффсет";
            this.добавитьОффсетToolStripMenuItem.Click += new System.EventHandler(this.добавитьОффсетToolStripMenuItem_Click);
            // 
            // посмотретьОффсетToolStripMenuItem
            // 
            this.посмотретьОффсетToolStripMenuItem.Name = "посмотретьОффсетToolStripMenuItem";
            this.посмотретьОффсетToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.посмотретьОффсетToolStripMenuItem.Text = "Посмотреть оффсет";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(549, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОффсетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьОффсетToolStripMenuItem;
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
        private System.Windows.Forms.Button button1;
    }
}

