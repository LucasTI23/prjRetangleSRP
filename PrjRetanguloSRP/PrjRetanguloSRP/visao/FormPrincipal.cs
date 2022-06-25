using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjRetanguloSRP.visao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        modelo.RetanguloMatematico ret;
        controle.RetanguloGrafico RG;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ret = new modelo.RetanguloMatematico(
                Double.Parse(txtL1.Text),
                Double.Parse(txtL2.Text)
                );
            lbResposta.Text = String.Format("Area: {0}, Perimetro:{1}",
                ret.Area(), ret.Perimetro());
        }

        private void btnPlotar_Click(object sender, EventArgs e)
        {
            if (ret == null)
            {
                btnCalcular_Click(sender, e);
            }
            else
            {
                ret.L1 = Double.Parse(txtL1.Text);
                ret.L2 = Double.Parse(txtL2.Text);
            }
            RG = new controle.RetanguloGrafico(ret);
            RG.Desenhar(10, 10, pnGrafico.CreateGraphics());
        }

        private void pnGrafico_MouseClick(object sender, MouseEventArgs e)
        {
            if (RG != null)
            {
                ret.L1 = Double.Parse(txtL1.Text);
                ret.L2 = Double.Parse(txtL2.Text);
                RG.Desenhar(e.X, e.Y, pnGrafico.CreateGraphics());
            }
        }
    }
}
