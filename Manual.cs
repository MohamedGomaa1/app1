using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_genrator
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم تحضير الطالب احمد محمد حسين بنجاح ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home form04 = new Home();
            form04.Show();
            this.Close();
        }
    }
}
