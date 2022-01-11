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

namespace CncDataSaver.UI
{
    public partial class CreateOffset<T> : Form
        where T : class
    {
        public CreateOffset(DbSet<T> dbWay)
        {
            InitializeComponent();

            dataGridView.DataSource = dbWay.Local.ToBindingList();
        }
        private void CreateOffset_Load(object sender, EventArgs e)
        {

        }

        private void CreateOffset_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
