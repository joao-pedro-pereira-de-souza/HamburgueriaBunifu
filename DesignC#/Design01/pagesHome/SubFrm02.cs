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
    public partial class SubFrm2 : Form
    {
        public SubFrm2()
        {
            InitializeComponent();
        }

        #region Values CardProd
        // values CardProd

        List<string> listStatusHamb = new List<string>()
        { "potatoes with double ketchup",
            "potatoes seasoned with bacon and special sauce",
            "Tower with hamburger, potatoes, chedder cheese, onion and pickles."
        };

        List<string> listTituloHamb = new List<string>() { "traditionary", "medium", "Combo" };

        List<string> listValuesHamb = new List<string>() { "5,80", "5,00", "18,00" };

        List<int> listPoitsHamb = new List<int>() { 4, 5, 5 };

        List<Image> listImageHamb = new List<Image>()

        { Properties.Resources.batatasduploKetchup,Properties.Resources.batatasClass,Properties.Resources.batatascombo};

        #endregion

        private void SubFrm2_Load(object sender, EventArgs e)
        {

            #region inserting values ​​in cardProd

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

    }
}
