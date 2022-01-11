using CncDataSaver.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CncDataSaver.BL;
using System.Threading;

namespace CncDataSave.UI
{
    public partial class CreateOffset<T> : Form
        where T : class
    {
        CncDataSaverContext db;
        DbSet<T> set;

        public CreateOffset(DbSet<T> set, CncDataSaverContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void CreateOffset_Load(object sender, EventArgs e)
        {

        }

        private void CreateOffset_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
