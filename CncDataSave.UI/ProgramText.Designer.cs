
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("BTC", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("OTTM", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ВМЗ-1", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Dimension");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Calculation");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Process");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ВМЗ-4", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Table");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Вспомогательные программы", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeViewListOfPrograms = new System.Windows.Forms.TreeView();
            this.textBoxProgramView = new System.Windows.Forms.TextBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewListOfPrograms
            // 
            this.treeViewListOfPrograms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.treeViewListOfPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewListOfPrograms.Location = new System.Drawing.Point(45, 89);
            this.treeViewListOfPrograms.Name = "treeViewListOfPrograms";
            treeNode1.Name = "DimensionBTC";
            treeNode1.Text = "Dimension";
            treeNode2.Name = "CalculationBTC";
            treeNode2.Text = "Calculation";
            treeNode3.Name = "ProcessBTC";
            treeNode3.Text = "Process";
            treeNode4.Name = "BTC";
            treeNode4.Text = "BTC";
            treeNode5.Name = "DimensionOTTM";
            treeNode5.Text = "Dimension";
            treeNode6.Name = "CalculationOTTM";
            treeNode6.Text = "Calculation";
            treeNode7.Name = "ProcessOTTM";
            treeNode7.Text = "Process";
            treeNode8.Name = "OTTM";
            treeNode8.Text = "OTTM";
            treeNode9.Name = "DimensionVSW-1";
            treeNode9.Text = "Dimension";
            treeNode10.Name = "CalculationVSW-1";
            treeNode10.Text = "Calculation";
            treeNode11.Name = "ProcessVSW-1";
            treeNode11.Text = "Process";
            treeNode12.Name = "VSW-1";
            treeNode12.Text = "ВМЗ-1";
            treeNode13.Name = "DimensionVSW-4";
            treeNode13.Text = "Dimension";
            treeNode14.Name = "CalculationVSW-4";
            treeNode14.Text = "Calculation";
            treeNode15.Name = "ProcessVSW-4";
            treeNode15.Text = "Process";
            treeNode16.Name = "VSW-4";
            treeNode16.Text = "ВМЗ-4";
            treeNode17.Name = "Table";
            treeNode17.Text = "Table";
            treeNode18.Name = "SidePrograms";
            treeNode18.Text = "Вспомогательные программы";
            this.treeViewListOfPrograms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode18});
            this.treeViewListOfPrograms.Size = new System.Drawing.Size(368, 496);
            this.treeViewListOfPrograms.TabIndex = 0;
            this.treeViewListOfPrograms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewListOfPrograms_AfterSelect);
            // 
            // textBoxProgramView
            // 
            this.textBoxProgramView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxProgramView.Location = new System.Drawing.Point(579, 31);
            this.textBoxProgramView.Multiline = true;
            this.textBoxProgramView.Name = "textBoxProgramView";
            this.textBoxProgramView.ReadOnly = true;
            this.textBoxProgramView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProgramView.Size = new System.Drawing.Size(672, 667);
            this.textBoxProgramView.TabIndex = 1;
            // 
            // CleanButton
            // 
            this.CleanButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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