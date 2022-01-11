using CncDataSaver.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CncDataSaver.BL;



namespace CncDataSave.UI
{
    public partial class Main : Form
    {
        CncDataSaverContext db;

        public Main()
        {
            InitializeComponent();
            db = new CncDataSaverContext();

            
        }

        private void добавитьОффсетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreateOffset = new CreateOffset<User>(db.Users,db);
            CreateOffset.Show();
        }

        private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
