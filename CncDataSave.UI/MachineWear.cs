using CncDataSaver.BL.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CncDataSave.UI
{
    public partial class MachineWear<T> : Form
        where T : class
    {
        readonly CncDataSaverContext db;
        private readonly DbSet<T> set;

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
        /// <summary>
        /// Check axis wear button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AxisCheckButton_Click(object sender, EventArgs e)
        {
            // Based on first threading pass.
            var channelOneDataX = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel1.X2).Average();
            Channel1X.Text = string.Format("{0:N4}", channelOneDataX);
            // Based on finishing pass.
            var channelOneDataY = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel1.Y4).Average();
            Channel1Y.Text = string.Format("{0:N4}", channelOneDataY);
            // Based on zajust.
            var channelOneDataZ = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Macro.Zajust).Average();
            Channel1Z.Text = string.Format("{0:N4}", channelOneDataZ);
            // Based on chamfer.
            var channelTwoDataX = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel2.X2).Average();
            Channel2X.Text = string.Format("{0:N4}", channelTwoDataX);
            // Based on facing.
            var channelTwoDataZ = db.OffsetData.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel2.Z1).Average();
            Channel2Z.Text = string.Format("{0:N4}", channelTwoDataZ);

        }
    }
}
