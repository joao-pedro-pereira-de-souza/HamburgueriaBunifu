namespace Design01
{
    partial class CardProd
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardProd));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.statusRating = new Bunifu.UI.WinForms.BunifuRating();
            this.ptbImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 50);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Duplo Hamburguer com chedder, cebolas assadas e picles  ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.lblTitulo.Location = new System.Drawing.Point(10, 183);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 21);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.lblValor.Location = new System.Drawing.Point(10, 266);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(207, 33);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Value";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // statusRating
            // 
            this.statusRating.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statusRating.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.statusRating.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statusRating.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statusRating.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.statusRating.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.statusRating.InnerRadius = 2F;
            this.statusRating.Location = new System.Drawing.Point(136, 190);
            this.statusRating.Name = "statusRating";
            this.statusRating.OuterRadius = 6F;
            this.statusRating.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.statusRating.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.statusRating.ReadOnly = false;
            this.statusRating.RightClickToClear = false;
            this.statusRating.Size = new System.Drawing.Size(81, 14);
            this.statusRating.TabIndex = 4;
            this.statusRating.Text = "bunifuRating1";
            this.statusRating.Value = 2;
            // 
            // ptbImage
            // 
            this.ptbImage.ActiveImage = null;
            this.ptbImage.AllowAnimations = true;
            this.ptbImage.AllowBuffering = false;
            this.ptbImage.AllowToggling = false;
            this.ptbImage.AllowZooming = false;
            this.ptbImage.AllowZoomingOnFocus = true;
            this.ptbImage.BackColor = System.Drawing.Color.Transparent;
            this.ptbImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbImage.ErrorImage")));
            this.ptbImage.FadeWhenInactive = false;
            this.ptbImage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ptbImage.Image = global::Design01.Properties.Resources.cheeseburger;
            this.ptbImage.ImageActive = null;
            this.ptbImage.ImageLocation = null;
            this.ptbImage.ImageMargin = 0;
            this.ptbImage.ImageSize = new System.Drawing.Size(225, 168);
            this.ptbImage.ImageZoomSize = new System.Drawing.Size(225, 168);
            this.ptbImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbImage.InitialImage")));
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Rotation = 0;
            this.ptbImage.ShowActiveImage = true;
            this.ptbImage.ShowCursorChanges = true;
            this.ptbImage.ShowImageBorders = true;
            this.ptbImage.ShowSizeMarkers = false;
            this.ptbImage.Size = new System.Drawing.Size(225, 168);
            this.ptbImage.TabIndex = 5;
            this.ptbImage.ToolTipText = "";
            this.ptbImage.WaitOnLoad = false;
            this.ptbImage.Zoom = 0;
            this.ptbImage.ZoomSpeed = 10;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            // 
            // CardProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.statusRating);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "CardProd";
            this.Size = new System.Drawing.Size(225, 306);
//            this.Click += new System.EventHandler(this.CardProd_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblValor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.UI.WinForms.BunifuRating statusRating;
        public Bunifu.UI.WinForms.BunifuImageButton ptbImage;
    }
}
