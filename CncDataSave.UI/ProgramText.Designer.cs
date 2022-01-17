
namespace CncDataSave.UI
{
    partial class ProgramText
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("BTC", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("OTTM", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("ВМЗ-1", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("ВМЗ-4", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Table");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Вспомогательные программы", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            this.treeViewListOfPrograms = new System.Windows.Forms.TreeView();
            this.textBoxProgramView = new System.Windows.Forms.TextBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewListOfPrograms
            // 
            this.treeViewListOfPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewListOfPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewListOfPrograms.Location = new System.Drawing.Point(45, 89);
            this.treeViewListOfPrograms.Name = "treeViewListOfPrograms";
            treeNode19.Name = "DimensionBTC";
            treeNode19.Text = "Dimension";
            treeNode20.Name = "CalculationBTC";
            treeNode20.Text = "Calculation";
            treeNode21.Name = "ProcessBTC";
            treeNode21.Text = "Process";
            treeNode22.Name = "BTC";
            treeNode22.Text = "BTC";
            treeNode23.Name = "DimensionOTTM";
            treeNode23.Text = "Dimension";
            treeNode24.Name = "CalculationOTTM";
            treeNode24.Text = "Calculation";
            treeNode25.Name = "ProcessOTTM";
            treeNode25.Text = "Process";
            treeNode26.Name = "OTTM";
            treeNode26.Text = "OTTM";
            treeNode27.Name = "DimensionVSW-1";
            treeNode27.Text = "Dimension";
            treeNode28.Name = "CalculationVSW-1";
            treeNode28.Text = "Calculation";
            treeNode29.Name = "ProcessVSW-1";
            treeNode29.Text = "Process";
            treeNode30.Name = "VSW-1";
            treeNode30.Text = "ВМЗ-1";
            treeNode31.Name = "DimensionVSW-4";
            treeNode31.Text = "Dimension";
            treeNode32.Name = "CalculationVSW-4";
            treeNode32.Text = "Calculation";
            treeNode33.Name = "ProcessVSW-4";
            treeNode33.Text = "Process";
            treeNode34.Name = "VSW-4";
            treeNode34.Text = "ВМЗ-4";
            treeNode35.Name = "Table";
            treeNode35.Text = "Table";
            treeNode36.Name = "SidePrograms";
            treeNode36.Text = "Вспомогательные программы";
            this.treeViewListOfPrograms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode26,
            treeNode30,
            treeNode34,
            treeNode36});
            this.treeViewListOfPrograms.Size = new System.Drawing.Size(368, 496);
            this.treeViewListOfPrograms.TabIndex = 0;
            this.treeViewListOfPrograms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewListOfPrograms_AfterSelect);
            // 
            // textBoxProgramView
            // 
            this.textBoxProgramView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgramView.Location = new System.Drawing.Point(579, 31);
            this.textBoxProgramView.Multiline = true;
            this.textBoxProgramView.Name = "textBoxProgramView";
            this.textBoxProgramView.ReadOnly = true;
            this.textBoxProgramView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProgramView.Size = new System.Drawing.Size(672, 667);
            this.textBoxProgramView.TabIndex = 1;
            this.textBoxProgramView.TextChanged += new System.EventHandler(this.textBoxProgramView_TextChanged);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(1099, 704);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(152, 26);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "Очистить";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(40, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Каталог";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(585, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Содержание";
            // 
            // ProgramText
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1552, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.textBoxProgramView);
            this.Controls.Add(this.treeViewListOfPrograms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramText";
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.Programs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewListOfPrograms;
        private System.Windows.Forms.TextBox textBoxProgramView;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}