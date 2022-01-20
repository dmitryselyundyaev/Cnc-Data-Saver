﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordCheckBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.buttonStopApp = new System.Windows.Forms.Button();
            this.ViewOffset = new System.Windows.Forms.Button();
            this.AddOffset = new System.Windows.Forms.Button();
            this.AxisCheck = new System.Windows.Forms.Button();
            this.DefProgram = new System.Windows.Forms.Button();
            this.ButtonUserNext = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.panelMainChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainChild
            // 
            this.panelMainChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainChild.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMainChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMainChild.BackgroundImage")));
            this.panelMainChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMainChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainChild.Controls.Add(this.LoginLabel);
            this.panelMainChild.Controls.Add(this.label2);
            this.panelMainChild.Controls.Add(this.label1);
            this.panelMainChild.Controls.Add(this.LoginButton);
            this.panelMainChild.Controls.Add(this.PasswordCheckBox);
            this.panelMainChild.Controls.Add(this.LoginTextBox);
            this.panelMainChild.Location = new System.Drawing.Point(4, 32);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(1570, 813);
            this.panelMainChild.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пользователя";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(114, 123);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(89, 25);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.Location = new System.Drawing.Point(57, 75);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.PasswordChar = '*';
            this.PasswordCheckBox.Size = new System.Drawing.Size(146, 22);
            this.PasswordCheckBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(57, 31);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(146, 22);
            this.LoginTextBox.TabIndex = 0;
            // 
            // buttonStopApp
            // 
            this.buttonStopApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopApp.BackgroundImage")));
            this.buttonStopApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStopApp.FlatAppearance.BorderSize = 0;
            this.buttonStopApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopApp.Location = new System.Drawing.Point(1545, 1);
            this.buttonStopApp.Name = "buttonStopApp";
            this.buttonStopApp.Size = new System.Drawing.Size(29, 30);
            this.buttonStopApp.TabIndex = 2;
            this.buttonStopApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStopApp.UseVisualStyleBackColor = false;
            this.buttonStopApp.Click += new System.EventHandler(this.ButtonStopApp_Click);
            // 
            // ViewOffset
            // 
            this.ViewOffset.BackColor = System.Drawing.Color.Silver;
            this.ViewOffset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.AddOffset.BackColor = System.Drawing.Color.Silver;
            this.AddOffset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AddOffset.FlatAppearance.BorderSize = 2;
            this.AddOffset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddOffset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddOffset.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.AxisCheck.BackColor = System.Drawing.Color.Silver;
            this.AxisCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.DefProgram.BackColor = System.Drawing.Color.Silver;
            this.DefProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DefProgram.Location = new System.Drawing.Point(637, 4);
            this.DefProgram.Name = "DefProgram";
            this.DefProgram.Size = new System.Drawing.Size(205, 26);
            this.DefProgram.TabIndex = 7;
            this.DefProgram.Text = "Исходные программы";
            this.DefProgram.UseVisualStyleBackColor = false;
            this.DefProgram.Click += new System.EventHandler(this.DefProgram_Click);
            // 
            // ButtonUserNext
            // 
            this.ButtonUserNext.BackColor = System.Drawing.Color.Silver;
            this.ButtonUserNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUserNext.Location = new System.Drawing.Point(848, 5);
            this.ButtonUserNext.Name = "ButtonUserNext";
            this.ButtonUserNext.Size = new System.Drawing.Size(205, 26);
            this.ButtonUserNext.TabIndex = 8;
            this.ButtonUserNext.Text = "Сменить пользователя";
            this.ButtonUserNext.UseVisualStyleBackColor = false;
            this.ButtonUserNext.Click += new System.EventHandler(this.ButtonUserNext_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(115, 100);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(0, 17);
            this.LoginLabel.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1578, 849);
            this.Controls.Add(this.ButtonUserNext);
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
            this.panelMainChild.ResumeLayout(false);
            this.panelMainChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelMainChild;
        private System.Windows.Forms.Button buttonStopApp;
        private System.Windows.Forms.Button ViewOffset;
        private System.Windows.Forms.Button AxisCheck;
        private System.Windows.Forms.Button DefProgram;
        private System.Windows.Forms.TextBox PasswordCheckBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ButtonUserNext;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button AddOffset;
    }
}

