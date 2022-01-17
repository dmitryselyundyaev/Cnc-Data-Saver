
using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffsetViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WearCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаИнструментаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устранениеПодрезаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корректировкаНатягаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыИСкоростиРезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростиРезанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelMainChild = new System.Windows.Forms.Panel();
            this.buttonStopApp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationsToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.режимыИСкоростиРезанияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateOffsetToolStripMenuItem,
            this.OffsetViewToolStripMenuItem,
            this.WearCheckToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.OperationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OperationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OperationsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.OperationsToolStripMenuItem.Text = "Операции";
            this.OperationsToolStripMenuItem.Click += new System.EventHandler(this.операцииToolStripMenuItem_Click);
            // 
            // CreateOffsetToolStripMenuItem
            // 
            this.CreateOffsetToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateOffsetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CreateOffsetToolStripMenuItem.Name = "CreateOffsetToolStripMenuItem";
            this.CreateOffsetToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.CreateOffsetToolStripMenuItem.Text = "Добавить оффсет";
            this.CreateOffsetToolStripMenuItem.Click += new System.EventHandler(this.CreateOffsetToolStripMenuItem_Click);
            // 
            // OffsetViewToolStripMenuItem
            // 
            this.OffsetViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OffsetViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OffsetViewToolStripMenuItem.Name = "OffsetViewToolStripMenuItem";
            this.OffsetViewToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.OffsetViewToolStripMenuItem.Text = "Посмотреть оффсет";
            this.OffsetViewToolStripMenuItem.Click += new System.EventHandler(this.OffsetViewToolStripMenuItem_Click);
            // 
            // WearCheckToolStripMenuItem
            // 
            this.WearCheckToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WearCheckToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.WearCheckToolStripMenuItem.Name = "WearCheckToolStripMenuItem";
            this.WearCheckToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.WearCheckToolStripMenuItem.Text = "Проверить состояние осей";
            this.WearCheckToolStripMenuItem.Click += new System.EventHandler(this.WearCheckToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заменаИнструментаToolStripMenuItem,
            this.устранениеПодрезаToolStripMenuItem,
            this.корректировкаНатягаToolStripMenuItem});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // заменаИнструментаToolStripMenuItem
            // 
            this.заменаИнструментаToolStripMenuItem.Name = "заменаИнструментаToolStripMenuItem";
            this.заменаИнструментаToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.заменаИнструментаToolStripMenuItem.Text = "Замена инструмента";
            // 
            // устранениеПодрезаToolStripMenuItem
            // 
            this.устранениеПодрезаToolStripMenuItem.Name = "устранениеПодрезаToolStripMenuItem";
            this.устранениеПодрезаToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.устранениеПодрезаToolStripMenuItem.Text = "Устранение подреза";
            // 
            // корректировкаНатягаToolStripMenuItem
            // 
            this.корректировкаНатягаToolStripMenuItem.Name = "корректировкаНатягаToolStripMenuItem";
            this.корректировкаНатягаToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.корректировкаНатягаToolStripMenuItem.Text = "Корректировка натяга";
            // 
            // режимыИСкоростиРезанияToolStripMenuItem
            // 
            this.режимыИСкоростиРезанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скоростиРезанияToolStripMenuItem,
            this.режимыРаботыToolStripMenuItem,
            this.ProgramsToolStripMenuItem});
            this.режимыИСкоростиРезанияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.режимыИСкоростиРезанияToolStripMenuItem.Name = "режимыИСкоростиРезанияToolStripMenuItem";
            this.режимыИСкоростиРезанияToolStripMenuItem.Size = new System.Drawing.Size(274, 29);
            this.режимыИСкоростиРезанияToolStripMenuItem.Text = "Режимы и скорости резания";
            // 
            // скоростиРезанияToolStripMenuItem
            // 
            this.скоростиРезанияToolStripMenuItem.Name = "скоростиРезанияToolStripMenuItem";
            this.скоростиРезанияToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.скоростиРезанияToolStripMenuItem.Text = "Скорости резания";
            // 
            // режимыРаботыToolStripMenuItem
            // 
            this.режимыРаботыToolStripMenuItem.Name = "режимыРаботыToolStripMenuItem";
            this.режимыРаботыToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.режимыРаботыToolStripMenuItem.Text = "Режимы работы";
            // 
            // ProgramsToolStripMenuItem
            // 
            this.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem";
            this.ProgramsToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.ProgramsToolStripMenuItem.Text = "Исходные программы";
            this.ProgramsToolStripMenuItem.Click += new System.EventHandler(this.ProgramsToolStripMenuItem_Click);
            // 
            // panelMainChild
            // 
            this.panelMainChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainChild.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMainChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainChild.Location = new System.Drawing.Point(4, 32);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(1570, 813);
            this.panelMainChild.TabIndex = 1;
            this.panelMainChild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainChild_Paint);
            // 
            // buttonStopApp
            // 
            this.buttonStopApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopApp.BackgroundImage")));
            this.buttonStopApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStopApp.FlatAppearance.BorderSize = 0;
            this.buttonStopApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopApp.Location = new System.Drawing.Point(1545, 4);
            this.buttonStopApp.Name = "buttonStopApp";
            this.buttonStopApp.Size = new System.Drawing.Size(29, 27);
            this.buttonStopApp.TabIndex = 2;
            this.buttonStopApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStopApp.UseVisualStyleBackColor = false;
            this.buttonStopApp.Click += new System.EventHandler(this.buttonStopApp_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1578, 849);
            this.Controls.Add(this.buttonStopApp);
            this.Controls.Add(this.panelMainChild);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
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
        private System.Windows.Forms.ToolStripMenuItem WearCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаИнструментаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устранениеПодрезаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корректировкаНатягаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимыИСкоростиРезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростиРезанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимыРаботыToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelMainChild;
        private System.Windows.Forms.Button buttonStopApp;
        private System.Windows.Forms.ToolStripMenuItem ProgramsToolStripMenuItem;
    }
}

