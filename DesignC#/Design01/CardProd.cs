using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design01
{
    public partial class CardProd : UserControl
    {
        public int idProd;

        public CardProd()
        {
            InitializeComponent();
        }

      
        private void ptbImage_Click(object sender, EventArgs e)
        {
          
            FrmProd prod = new FrmProd();

            prod.lblTitulo.Text = lblTitulo.Text;

            prod.lblStatus.Text = lblStatus.Text;
            prod.lblValor.Text = lblValor.Text;

            prod.pictureBox1.Image = ptbImage.Image;

            prod.ShowDialog();
        }
    }
}
