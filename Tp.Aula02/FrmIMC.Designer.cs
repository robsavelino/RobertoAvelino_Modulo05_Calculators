namespace Tp.Aula02
{
    partial class FrmIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pctbImagem1 = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSaidaIMC = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(261, 162);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(261, 199);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(309, 154);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(255, 23);
            this.txbPeso.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(309, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 31);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(457, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 31);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pctbImagem1
            // 
            this.pctbImagem1.Image = ((System.Drawing.Image)(resources.GetObject("pctbImagem1.Image")));
            this.pctbImagem1.Location = new System.Drawing.Point(309, 56);
            this.pctbImagem1.Name = "pctbImagem1";
            this.pctbImagem1.Size = new System.Drawing.Size(255, 72);
            this.pctbImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbImagem1.TabIndex = 6;
            this.pctbImagem1.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(222, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(437, 25);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Calculadora de Indice de Massa Corporea = IMC";
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // lblSaidaIMC
            // 
            this.lblSaidaIMC.AutoSize = true;
            this.lblSaidaIMC.Location = new System.Drawing.Point(261, 343);
            this.lblSaidaIMC.Name = "lblSaidaIMC";
            this.lblSaidaIMC.Size = new System.Drawing.Size(101, 15);
            this.lblSaidaIMC.TabIndex = 8;
            this.lblSaidaIMC.Text = "Resultado do IMC";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(309, 191);
            this.txbAltura.MaxLength = 3;
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(255, 23);
            this.txbAltura.TabIndex = 2;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(570, 162);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(20, 15);
            this.lblKg.TabIndex = 10;
            this.lblKg.Text = "kg";
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Location = new System.Drawing.Point(570, 199);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(24, 15);
            this.lblCm.TabIndex = 11;
            this.lblCm.Text = "cm";
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.lblSaidaIMC);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pctbImagem1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.MaximizeBox = false;
            this.Name = "frmIMC";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPeso;
        private Label lblAltura;
        private TextBox txbPeso;
        private Button btnCalcular;
        private Button btnLimpar;
        private PictureBox pctbImagem1;
        private Label lblTexto;
        private Label lblSaidaIMC;
        private TextBox txbAltura;
        private Label lblKg;
        private Label lblCm;
    }
}