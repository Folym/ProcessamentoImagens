using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;
            pictBoxImg2.Image = null;
        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativo(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnHorizontalcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_horizontalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnVerticalcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_verticalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnPretoeBrancocomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.preto_brancoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnRotacaoDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image.Height,image.Width);
            imageBitmap = (Bitmap)image;
            Filtros.rotacionaDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverteRB_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteRBDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnDiagonalcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_diagonalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverteRBsemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteRB(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void PretoBrancoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.preto_branco(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void EspH_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_horizontal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void EspV_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_vertical(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void EspD_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_diagonal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image.Height,image.Width);
            imageBitmap = (Bitmap)image;
            Filtros.rotaciona(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalR_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalVermelho(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalG_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalVerde(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalB_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalAzul(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalRDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalVermelhoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalGDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalVerdeDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void CanalBDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.canalAzulDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }
    }
}
