namespace PrjRetanguloSRP.visao
{
    partial class FormPrincipal
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbResposta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGrafico = new System.Windows.Forms.Panel();
            this.btnPlotar = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSuperior.Controls.Add(this.btnPlotar);
            this.pnSuperior.Controls.Add(this.lbResposta);
            this.pnSuperior.Controls.Add(this.btnCalcular);
            this.pnSuperior.Controls.Add(this.txtL2);
            this.pnSuperior.Controls.Add(this.txtL1);
            this.pnSuperior.Controls.Add(this.label2);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(593, 133);
            this.pnSuperior.TabIndex = 0;
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.Black;
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResposta.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.Lime;
            this.lbResposta.Location = new System.Drawing.Point(0, 93);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(591, 38);
            this.lbResposta.TabIndex = 3;
            this.lbResposta.Text = "Resposta";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 24);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 54);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtL2
            // 
            this.txtL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtL2.Location = new System.Drawing.Point(136, 58);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(65, 20);
            this.txtL2.TabIndex = 1;
            this.txtL2.Text = "0";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(27, 58);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(57, 20);
            this.txtL1.TabIndex = 0;
            this.txtL1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lado 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1:";
            // 
            // pnGrafico
            // 
            this.pnGrafico.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGrafico.Location = new System.Drawing.Point(12, 139);
            this.pnGrafico.Name = "pnGrafico";
            this.pnGrafico.Size = new System.Drawing.Size(569, 296);
            this.pnGrafico.TabIndex = 1;
            this.pnGrafico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnGrafico_MouseClick);
            // 
            // btnPlotar
            // 
            this.btnPlotar.Location = new System.Drawing.Point(421, 25);
            this.btnPlotar.Name = "btnPlotar";
            this.btnPlotar.Size = new System.Drawing.Size(141, 54);
            this.btnPlotar.TabIndex = 4;
            this.btnPlotar.Text = "PLOTAR";
            this.btnPlotar.UseVisualStyleBackColor = true;
            this.btnPlotar.Click += new System.EventHandler(this.btnPlotar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 447);
            this.Controls.Add(this.pnGrafico);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Retangulo";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlotar;
        private System.Windows.Forms.Panel pnGrafico;
    }
}