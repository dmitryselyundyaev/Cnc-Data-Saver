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
using CncDataSaver.BL.Model;

namespace CncDataSaver.UI
{
    public partial class Main : Form
    {
        CncDataSaverContext db;
        public Main()
        {
            InitializeComponent();
            db = new CncDataSaverContext();
            
        }

        private void оффсетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createOffset = new CreateOffset<Offset>(db.Offsets);
            createOffset.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
