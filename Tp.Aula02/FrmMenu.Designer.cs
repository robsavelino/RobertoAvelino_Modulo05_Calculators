namespace Tp.Aula02
{
    partial class FrmMenu
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
            this.btnCalcSimples = new System.Windows.Forms.Button();
            this.btnCalcIMC = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcSimples
            // 
            this.btnCalcSimples.Location = new System.Drawing.Point(180, 179);
            this.btnCalcSimples.Name = "btnCalcSimples";
            this.btnCalcSimples.Size = new System.Drawing.Size(165, 64);
            this.btnCalcSimples.TabIndex = 0;
            this.btnCalcSimples.Text = "Calculadora Simples";
            this.btnCalcSimples.UseVisualStyleBackColor = true;
            this.btnCalcSimples.Click += new System.EventHandler(this.btnCalcSimples_Click);
            // 
            // btnCalcIMC
            // 
            this.btnCalcIMC.Location = new System.Drawing.Point(456, 179);
            this.btnCalcIMC.Name = "btnCalcIMC";
            this.btnCalcIMC.Size = new System.Drawing.Size(165, 64);
            this.btnCalcIMC.TabIndex = 1;
            this.btnCalcIMC.Text = "Calculadora IMC";
            this.btnCalcIMC.UseVisualStyleBackColor = true;
            this.btnCalcIMC.Click += new System.EventHandler(this.btnCalcIMC_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelect.Location = new System.Drawing.Point(225, 64);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(350, 25);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Selecione qual calculadora deseja usar";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 64);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnCalcIMC);
            this.Controls.Add(this.btnCalcSimples);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcSimples;
        private Button btnCalcIMC;
        private Label lblSelect;
        private Button btnClose;
    }
}