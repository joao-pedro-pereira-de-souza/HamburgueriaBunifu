using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design01
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Insert pagas

            // page2
            SubFrm2 sub2 = new SubFrm2();

            sub2.TopLevel = false;
            pnlContainer.Controls.Add(sub2);

            sub2.Dock = DockStyle.Top;

            sub2.Show();
            //

            // page 1
            subFrmIndex sub = new subFrmIndex();

            sub.TopLevel = false;
            pnlContainer.Controls.Add(sub);

            sub.Dock = DockStyle.Top;

            sub.Show();
            //
            //

        }

    }
}
