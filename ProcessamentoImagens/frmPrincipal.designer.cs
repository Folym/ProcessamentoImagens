namespace ProcessamentoImagens
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            this.btnHorizontalcomDMA = new System.Windows.Forms.Button();
            this.btnVerticalcomDMA = new System.Windows.Forms.Button();
            this.PretoBrancoSemDMA = new System.Windows.Forms.Button();
            this.btnPretoeBrancocomDMA = new System.Windows.Forms.Button();
            this.btnRotacaoDMA = new System.Windows.Forms.Button();
            this.btnInverteRB = new System.Windows.Forms.Button();
            this.btnDiagonalcomDMA = new System.Windows.Forms.Button();
            this.EspH = new System.Windows.Forms.Button();
            this.EspV = new System.Windows.Forms.Button();
            this.btnInverteRBsemDMA = new System.Windows.Forms.Button();
            this.EspD = new System.Windows.Forms.Button();
            this.btnRot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 512);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(219, 512);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância sem DMA";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(219, 541);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Location = new System.Drawing.Point(433, 541);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnNegativoSemDMA
            // 
            this.btnNegativoSemDMA.Location = new System.Drawing.Point(433, 512);
            this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            this.btnNegativoSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoSemDMA.TabIndex = 110;
            this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // btnHorizontalcomDMA
            // 
            this.btnHorizontalcomDMA.Location = new System.Drawing.Point(5, 570);
            this.btnHorizontalcomDMA.Name = "btnHorizontalcomDMA";
            this.btnHorizontalcomDMA.Size = new System.Drawing.Size(101, 23);
            this.btnHorizontalcomDMA.TabIndex = 112;
            this.btnHorizontalcomDMA.Text = "EspH DMA";
            this.btnHorizontalcomDMA.UseVisualStyleBackColor = true;
            this.btnHorizontalcomDMA.Click += new System.EventHandler(this.btnHorizontalcomDMA_Click);
            // 
            // btnVerticalcomDMA
            // 
            this.btnVerticalcomDMA.Location = new System.Drawing.Point(112, 570);
            this.btnVerticalcomDMA.Name = "btnVerticalcomDMA";
            this.btnVerticalcomDMA.Size = new System.Drawing.Size(101, 23);
            this.btnVerticalcomDMA.TabIndex = 113;
            this.btnVerticalcomDMA.Text = "EspV DMA";
            this.btnVerticalcomDMA.UseVisualStyleBackColor = true;
            this.btnVerticalcomDMA.Click += new System.EventHandler(this.btnVerticalcomDMA_Click);
            // 
            // PretoBrancoSemDMA
            // 
            this.PretoBrancoSemDMA.Location = new System.Drawing.Point(647, 512);
            this.PretoBrancoSemDMA.Name = "PretoBrancoSemDMA";
            this.PretoBrancoSemDMA.Size = new System.Drawing.Size(208, 23);
            this.PretoBrancoSemDMA.TabIndex = 114;
            this.PretoBrancoSemDMA.Text = "Preto e Branco sem DMA";
            this.PretoBrancoSemDMA.UseVisualStyleBackColor = true;
            this.PretoBrancoSemDMA.Click += new System.EventHandler(this.PretoBrancoSemDMA_Click);
            // 
            // btnPretoeBrancocomDMA
            // 
            this.btnPretoeBrancocomDMA.Location = new System.Drawing.Point(647, 541);
            this.btnPretoeBrancocomDMA.Name = "btnPretoeBrancocomDMA";
            this.btnPretoeBrancocomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnPretoeBrancocomDMA.TabIndex = 115;
            this.btnPretoeBrancocomDMA.Text = "Preto e Branco com DMA";
            this.btnPretoeBrancocomDMA.UseVisualStyleBackColor = true;
            this.btnPretoeBrancocomDMA.Click += new System.EventHandler(this.btnPretoeBrancocomDMA_Click);
            // 
            // btnRotacaoDMA
            // 
            this.btnRotacaoDMA.Location = new System.Drawing.Point(219, 570);
            this.btnRotacaoDMA.Name = "btnRotacaoDMA";
            this.btnRotacaoDMA.Size = new System.Drawing.Size(101, 23);
            this.btnRotacaoDMA.TabIndex = 116;
            this.btnRotacaoDMA.Text = "Rot 90° DMA";
            this.btnRotacaoDMA.UseVisualStyleBackColor = true;
            this.btnRotacaoDMA.Click += new System.EventHandler(this.btnRotacaoDMA_Click);
            // 
            // btnInverteRB
            // 
            this.btnInverteRB.Location = new System.Drawing.Point(861, 541);
            this.btnInverteRB.Name = "btnInverteRB";
            this.btnInverteRB.Size = new System.Drawing.Size(208, 23);
            this.btnInverteRB.TabIndex = 117;
            this.btnInverteRB.Text = "InvertRB_DMA";
            this.btnInverteRB.UseVisualStyleBackColor = true;
            this.btnInverteRB.Click += new System.EventHandler(this.btnInverteRB_Click);
            // 
            // btnDiagonalcomDMA
            // 
            this.btnDiagonalcomDMA.Location = new System.Drawing.Point(1075, 541);
            this.btnDiagonalcomDMA.Name = "btnDiagonalcomDMA";
            this.btnDiagonalcomDMA.Size = new System.Drawing.Size(133, 23);
            this.btnDiagonalcomDMA.TabIndex = 118;
            this.btnDiagonalcomDMA.Text = "EspD DMA";
            this.btnDiagonalcomDMA.UseVisualStyleBackColor = true;
            this.btnDiagonalcomDMA.Click += new System.EventHandler(this.btnDiagonalcomDMA_Click);
            // 
            // EspH
            // 
            this.EspH.Location = new System.Drawing.Point(5, 541);
            this.EspH.Name = "EspH";
            this.EspH.Size = new System.Drawing.Size(101, 23);
            this.EspH.TabIndex = 119;
            this.EspH.Text = "EspH";
            this.EspH.UseVisualStyleBackColor = true;
            this.EspH.Click += new System.EventHandler(this.EspH_Click);
            // 
            // EspV
            // 
            this.EspV.Location = new System.Drawing.Point(112, 541);
            this.EspV.Name = "EspV";
            this.EspV.Size = new System.Drawing.Size(101, 23);
            this.EspV.TabIndex = 120;
            this.EspV.Text = "EspV";
            this.EspV.UseVisualStyleBackColor = true;
            this.EspV.Click += new System.EventHandler(this.EspV_Click);
            // 
            // btnInverteRBsemDMA
            // 
            this.btnInverteRBsemDMA.Location = new System.Drawing.Point(861, 512);
            this.btnInverteRBsemDMA.Name = "btnInverteRBsemDMA";
            this.btnInverteRBsemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnInverteRBsemDMA.TabIndex = 121;
            this.btnInverteRBsemDMA.Text = "InvertRB";
            this.btnInverteRBsemDMA.UseVisualStyleBackColor = true;
            this.btnInverteRBsemDMA.Click += new System.EventHandler(this.btnInverteRBsemDMA_Click);
            // 
            // EspD
            // 
            this.EspD.Location = new System.Drawing.Point(1075, 512);
            this.EspD.Name = "EspD";
            this.EspD.Size = new System.Drawing.Size(133, 23);
            this.EspD.TabIndex = 122;
            this.EspD.Text = "EspD";
            this.EspD.UseVisualStyleBackColor = true;
            this.EspD.Click += new System.EventHandler(this.EspD_Click);
            // 
            // btnRot
            // 
            this.btnRot.Location = new System.Drawing.Point(326, 570);
            this.btnRot.Name = "btnRot";
            this.btnRot.Size = new System.Drawing.Size(101, 23);
            this.btnRot.TabIndex = 123;
            this.btnRot.Text = "Rot 90°";
            this.btnRot.UseVisualStyleBackColor = true;
            this.btnRot.Click += new System.EventHandler(this.btnRot_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.btnRot);
            this.Controls.Add(this.EspD);
            this.Controls.Add(this.btnInverteRBsemDMA);
            this.Controls.Add(this.EspV);
            this.Controls.Add(this.EspH);
            this.Controls.Add(this.btnDiagonalcomDMA);
            this.Controls.Add(this.btnInverteRB);
            this.Controls.Add(this.btnRotacaoDMA);
            this.Controls.Add(this.btnPretoeBrancocomDMA);
            this.Controls.Add(this.PretoBrancoSemDMA);
            this.Controls.Add(this.btnVerticalcomDMA);
            this.Controls.Add(this.btnHorizontalcomDMA);
            this.Controls.Add(this.btnNegativoComDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnLuminanciaComDMA);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnHorizontalcomDMA;
        private System.Windows.Forms.Button btnVerticalcomDMA;
        private System.Windows.Forms.Button PretoBrancoSemDMA;
        private System.Windows.Forms.Button btnPretoeBrancocomDMA;
        private System.Windows.Forms.Button btnRotacaoDMA;
        private System.Windows.Forms.Button btnInverteRB;
        private System.Windows.Forms.Button btnDiagonalcomDMA;
        private System.Windows.Forms.Button EspH;
        private System.Windows.Forms.Button EspV;
        private System.Windows.Forms.Button btnInverteRBsemDMA;
        private System.Windows.Forms.Button EspD;
        private System.Windows.Forms.Button btnRot;
    }
}

