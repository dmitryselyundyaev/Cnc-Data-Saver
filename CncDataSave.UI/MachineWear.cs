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

namespace CncDataSave.UI
{
    public partial class MachineWear<T> : Form
        where T : class
    {
        CncDataSaverContext db;
        DbSet<T> set;

        public MachineWear(DbSet<T> set, CncDataSaverContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();

        }

        private void MachineWear_Load(object sender, EventArgs e)
        {

        }

        private void AxisCheckButton_Click(object sender, EventArgs e)
        {
            // Based on first threading pass.
            var channelOneDataX = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(5).Select(u => u.Channel1.X2).Average();
            Channel1X.Text = channelOneDataX.ToString();
            // Based on finishing pass.
            var channelOneDataY = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(5).Select(u => u.Channel1.Y4).Average();
            Channel1Y.Text = channelOneDataY.ToString();
            // Based on zajust.
            var channelOneDataZ = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(5).Select(u => u.Macro.Zajust).Average();
            Channel1Z.Text = channelOneDataZ.ToString();
            // Based on chamfer.
            var channelTwoDataX = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(5).Select(u => u.Channel2.X2).Average();
            Channel2X.Text = channelTwoDataX.ToString();
            // Based on facing.
            var channelTwoDataZ = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(5).Select(u => u.Channel2.Z1).Average();
            Channel2Z.Text = channelTwoDataZ.ToString();

        }
    }
}
