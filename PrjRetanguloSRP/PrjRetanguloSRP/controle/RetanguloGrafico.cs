using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjRetanguloSRP.controle
{
    class RetanguloGrafico
    {
        public modelo.RetanguloMatematico RM { get; set; }
        public RetanguloGrafico(modelo.RetanguloMatematico RM)
        {
            this.RM = RM;
        }
        public void Desenhar(double x, double y, Graphics g)
        {
            g.Clear(Color.MediumSlateBlue);
            Pen caneta = new Pen(Color.Black, 3);
            g.DrawRectangle(caneta, (int)x, (int)y, (int)RM.L1, (int)RM.L2);

            caneta.Color = Color.Gold;
            g.DrawEllipse(caneta, (int)x, (int)y, (int)RM.L1, (int)RM.L2);
        }
    }
}
