using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Design01
{
    public partial class subFrmIndex : Form
    {
        public subFrmIndex()
        {
            InitializeComponent();
        }

        #region Value CardProd

        List<string> listStatusHamb = new List<string>()
        { "Double hamburger with chedder, onions and pickles.",
            "Traditional double burger, lettuce, onion and tomato",
            "Tower with hamburger, potatoes, chedder cheese, onion and pickles."
        };

        List<string> listTituloHamb = new List<string>() { "Tradicional", "Basic", "Torre" };
        List<string> listValuesHamb = new List<string>() { "8,80", "7,50", "14,90" };

        List<int> listPoitsHamb = new List<int>() { 4, 3, 5 };

        List<Image> listImageHamb = new List<Image>()
        { Properties.Resources.cheeseburger,Properties.Resources.TradHamb,Properties.Resources.torreHamb};

        #endregion

        private void subFrmIndex_Load(object sender, EventArgs e)
        {
            // Add Transparent objects foradding Transparent to the objects above the pictureBox1(image background).

            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label5);
            pictureBox1.Controls.Add(label6);
            pictureBox1.Controls.Add(label2);
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(btnClose);
            pictureBox1.Controls.Add(btnWinMinus);
           


            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            btnClose.BackColor = Color.Transparent;
            btnWinMinus.BackColor = Color.Transparent;
          


            // 

            #region inserting values ​​in cardProd.

            cardProd1.lblTitulo.Text = listTituloHamb[0];
            cardProd2.lblTitulo.Text = listTituloHamb[1];
            cardProd3.lblTitulo.Text = listTituloHamb[2];

            cardProd1.lblStatus.Text = listStatusHamb[0];
            cardProd2.lblStatus.Text = listStatusHamb[1];
            cardProd3.lblStatus.Text = listStatusHamb[2];

            cardProd1.lblValor.Text = listValuesHamb[0];
            cardProd2.lblValor.Text = listValuesHamb[1];
            cardProd3.lblValor.Text = listValuesHamb[2];

            cardProd1.statusRating.Value = listPoitsHamb[0];
            cardProd2.statusRating.Value = listPoitsHamb[1];
            cardProd3.statusRating.Value = listPoitsHamb[2];

            cardProd1.ptbImage.Image = listImageHamb[0];
            cardProd2.ptbImage.Image = listImageHamb[1];
            cardProd3.ptbImage.Image = listImageHamb[2];

            #endregion

        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWinMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
