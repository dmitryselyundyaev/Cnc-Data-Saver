
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelMainChild = new System.Windows.Forms.Panel();
            this.buttonStopApp = new System.Windows.Forms.Button();
            this.ViewOffset = new System.Windows.Forms.Button();
            this.AddOffset = new System.Windows.Forms.Button();
            this.AxisCheck = new System.Windows.Forms.Button();
            this.DefProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMainChild
            // 
            this.panelMainChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainChild.BackColor = System.Drawing.Color.Silver;
            this.panelMainChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainChild.Location = new System.Drawing.Point(4, 32);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(1570, 813);
            this.panelMainChild.TabIndex = 1;
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
            // ViewOffset
            // 
            this.ViewOffset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ViewOffset.Location = new System.Drawing.Point(215, 4);
            this.ViewOffset.Name = "ViewOffset";
            this.ViewOffset.Size = new System.Drawing.Size(205, 26);
            this.ViewOffset.TabIndex = 4;
            this.ViewOffset.Text = "Просмотр оффеста";
            this.ViewOffset.UseVisualStyleBackColor = false;
            this.ViewOffset.Click += new System.EventHandler(this.ViewOffset_Click);
            // 
            // AddOffset
            // 
            this.AddOffset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddOffset.Location = new System.Drawing.Point(4, 4);
            this.AddOffset.Name = "AddOffset";
            this.AddOffset.Size = new System.Drawing.Size(205, 26);
            this.AddOffset.TabIndex = 5;
            this.AddOffset.Text = "Добавление оффсета";
            this.AddOffset.UseVisualStyleBackColor = false;
            this.AddOffset.Click += new System.EventHandler(this.AddOffset_Click);
            // 
            // AxisCheck
            // 
            this.AxisCheck.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AxisCheck.Location = new System.Drawing.Point(426, 4);
            this.AxisCheck.Name = "AxisCheck";
            this.AxisCheck.Size = new System.Drawing.Size(205, 26);
            this.AxisCheck.TabIndex = 6;
            this.AxisCheck.Text = "Проверка геометри осей";
            this.AxisCheck.UseVisualStyleBackColor = false;
            this.AxisCheck.Click += new System.EventHandler(this.AxisCheck_Click);
            // 
            // DefProgram
            // 
            this.DefProgram.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DefProgram.Location = new System.Drawing.Point(637, 4);
            this.DefProgram.Name = "DefProgram";
            this.DefProgram.Size = new System.Drawing.Size(205, 26);
            this.DefProgram.TabIndex = 7;
            this.DefProgram.Text = "Исходные программы";
            this.DefProgram.UseVisualStyleBackColor = false;
            this.DefProgram.Click += new System.EventHandler(this.DefProgram_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1578, 849);
            this.Controls.Add(this.DefProgram);
            this.Controls.Add(this.AxisCheck);
            this.Controls.Add(this.AddOffset);
            this.Controls.Add(this.ViewOffset);
            this.Controls.Add(this.buttonStopApp);
            this.Controls.Add(this.panelMainChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelMainChild;
        private System.Windows.Forms.Button buttonStopApp;
        private System.Windows.Forms.Button ViewOffset;
        private System.Windows.Forms.Button AddOffset;
        private System.Windows.Forms.Button AxisCheck;
        private System.Windows.Forms.Button DefProgram;
    }
}

