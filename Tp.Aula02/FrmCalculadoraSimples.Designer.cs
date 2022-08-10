namespace Tp.Aula02
{
    partial class FrmCalculadoraSimples
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
            this.lblCalc = new System.Windows.Forms.Label();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbVisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalc.Location = new System.Drawing.Point(305, 53);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(190, 25);
            this.lblCalc.TabIndex = 0;
            this.lblCalc.Text = "Calculadora Simples";
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(250, 176);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(61, 41);
            this.btnNum7.TabIndex = 1;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(333, 176);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(61, 41);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(416, 176);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(61, 41);
            this.btnNum9.TabIndex = 3;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(501, 176);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(50, 41);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(501, 223);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 41);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(416, 223);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(61, 41);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(333, 223);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(61, 41);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(250, 223);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(61, 41);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(501, 270);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(50, 41);
            this.btnMulti.TabIndex = 12;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(416, 270);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(61, 41);
            this.btnNum3.TabIndex = 11;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(333, 270);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(61, 41);
            this.btnNum2.TabIndex = 10;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(250, 270);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(61, 41);
            this.btnNum1.TabIndex = 9;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(501, 317);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 41);
            this.btnDivision.TabIndex = 16;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(416, 317);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(61, 41);
            this.btnEquals.TabIndex = 15;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(333, 317);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(61, 41);
            this.btnNum0.TabIndex = 14;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(250, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 41);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbVisor
            // 
            this.txbVisor.Enabled = false;
            this.txbVisor.Location = new System.Drawing.Point(250, 122);
            this.txbVisor.Name = "txbVisor";
            this.txbVisor.Size = new System.Drawing.Size(301, 23);
            this.txbVisor.TabIndex = 17;
            this.txbVisor.TextChanged += new System.EventHandler(this.txbVisor_TextChanged);
            // 
            // FrmCalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbVisor);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.lblCalc);
            this.Name = "FrmCalculadoraSimples";
            this.Text = "Calculadora Simples ";
            this.Load += new System.EventHandler(this.FrmCalculadoraSimples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCalc;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnSum;
        private Button btnSub;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnMulti;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnDivision;
        private Button btnEquals;
        private Button btnNum0;
        private Button btnClear;
        private TextBox txbVisor;
    }
}