
using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.panelMainChild = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordCheckBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonUserNext = new System.Windows.Forms.Button();
            this.buttonStopApp = new System.Windows.Forms.Button();
            this.ViewOffset = new System.Windows.Forms.Button();
            this.AddOffset = new System.Windows.Forms.Button();
            this.AxisCheck = new System.Windows.Forms.Button();
            this.DefProgram = new System.Windows.Forms.Button();
            this.panelMainChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelMainChild.Controls.Add(this.LabelPassword);
            this.panelMainChild.Controls.Add(this.labelUserName);
            this.panelMainChild.Controls.Add(this.LoginButton);
            this.panelMainChild.Controls.Add(this.PasswordCheckBox);
            this.panelMainChild.Controls.Add(this.LoginTextBox);
            this.panelMainChild.Controls.Add(this.pictureBox1);
            this.panelMainChild.Location = new System.Drawing.Point(4, 32);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(1570, 813);
            this.panelMainChild.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(774, 349);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(0, 17);
            this.LoginLabel.TabIndex = 5;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(689, 290);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 17);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Пароль";

            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(689, 221);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(131, 17);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Имя пользователя";

            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(777, 365);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(89, 25);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordCheckBox.Location = new System.Drawing.Point(711, 310);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.PasswordChar = '*';
            this.PasswordCheckBox.Size = new System.Drawing.Size(146, 22);
            this.PasswordCheckBox.TabIndex = 1;

            this.PasswordCheckBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginTextBox.Location = new System.Drawing.Point(711, 241);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(146, 22);
            this.LoginTextBox.TabIndex = 0;

            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(571, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 289);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;

            // 
            // ButtonUserNext
            // 
            this.ButtonUserNext.AccessibleDescription = "";
            this.ButtonUserNext.AccessibleName = "";
            this.ButtonUserNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUserNext.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUserNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUserNext.FlatAppearance.BorderSize = 0;
            this.ButtonUserNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonUserNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonUserNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUserNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUserNext.ImageKey = "(отсутствует)";
            this.ButtonUserNext.Location = new System.Drawing.Point(1407, 2);
            this.ButtonUserNext.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserNext.Name = "ButtonUserNext";
            this.ButtonUserNext.Size = new System.Drawing.Size(135, 30);
            this.ButtonUserNext.TabIndex = 8;
            this.ButtonUserNext.Tag = "";
            this.ButtonUserNext.Text = "Сменить пользователя";
            this.ButtonUserNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUserNext.UseVisualStyleBackColor = false;
            this.ButtonUserNext.Visible = false;
            this.ButtonUserNext.Click += new System.EventHandler(this.ButtonUserNext_Click);
            // 
            // buttonStopApp
            // 
            this.buttonStopApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopApp.BackgroundImage")));
            this.buttonStopApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStopApp.FlatAppearance.BorderSize = 0;
            this.buttonStopApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonStopApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonStopApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopApp.Location = new System.Drawing.Point(1545, 1);
            this.buttonStopApp.Name = "buttonStopApp";
            this.buttonStopApp.Size = new System.Drawing.Size(30, 30);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNCDataSaver";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMainChild.ResumeLayout(false);
            this.panelMainChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                LoginButton_Click(sender, e);
            }
        }


        #endregion
        private System.Windows.Forms.Panel panelMainChild;
        private System.Windows.Forms.Button buttonStopApp;
        private System.Windows.Forms.Button ViewOffset;
        private System.Windows.Forms.Button AxisCheck;
        private System.Windows.Forms.Button DefProgram;
        private System.Windows.Forms.TextBox PasswordCheckBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ButtonUserNext;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button AddOffset;
        private PictureBox pictureBox1;
    }
}

