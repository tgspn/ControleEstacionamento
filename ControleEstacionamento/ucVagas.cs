using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento
{
    public partial class ucVagas : UserControl
    {
        public ucVagas()
        {
            InitializeComponent();
            dic = new Dictionary<Modelos.VagaModelo, Rectangle>();
        }
        private Dictionary<Modelos.VagaModelo, Rectangle> dic;

        public void AdicionarVagas(IEnumerable<Modelos.VagaModelo> vagas)
        {
            Modelos.VagaModelo[] vagasArray = vagas.ToArray();
            var vagaPoints = new Point[] {
            new Point(61, 11),
            new Point(181, 11),
            new Point(301, 11),
            new Point(421, 11),
            new Point(541, 11),
            new Point(641, 221),

            new Point(541, 390),
            new Point(421, 390),
            new Point(301, 390),
            new Point(181, 390),
            new Point(61, 390) };

            //61, 390, 98, 140
            for (int i = 0; i < vagasArray.Count(); i++)
            {
                var item = vagasArray[i];
                if (i == 5)
                    dic.Add(item, new Rectangle(vagaPoints[i].X, vagaPoints[i].Y, 139, 98));
                else
                    dic.Add(item, new Rectangle(vagaPoints[i].X, vagaPoints[i].Y, 98, 140));
            }
            this.Invalidate();
        }



        private void ucVagas_Load(object sender, EventArgs e)
        {

        }

        private void ucVagas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLines(new Pen(Color.Black), new PointF[]
            {
                new PointF(10, 150),
                //vaga 1
                new PointF(60,150),
                new PointF(60,10),
                new PointF(160,10),
                new PointF(160,150),
                //vaga 2
                new PointF(180,150),
                new PointF(180,10),
                new PointF(280,10),
                new PointF(280,150),
                //vaga 3
                new PointF(300,150),
                new PointF(300,10),
                new PointF(400,10),
                new PointF(400,150),
                //vaga 4
                new PointF(420,150),
                new PointF(420,10),
                new PointF(520,10),
                new PointF(520,150),
                //vaga 5
                new PointF(540,150),
                new PointF(540,10),
                new PointF(640,10),
                new PointF(640,150),
                //vaga 6
                new PointF(640,220),
                new PointF(780,220),
                new PointF(780,320),
                new PointF(640,320),
                //vaga 7
                new PointF(640,390),
                new PointF(640,530),
                new PointF(540,530),
                new PointF(540,390),
                //vaga 8
                new PointF(520,390),
                new PointF(520,530),
                new PointF(420,530),
                new PointF(420,390),
                //vaga 9
                new PointF(400,390),
                new PointF(400,530),
                new PointF(300,530),
                new PointF(300,390),
                //vaga 10
                new PointF(280,390),
                new PointF(280,530),
                new PointF(180,530),
                new PointF(180,390),
                //vaga 11
                new PointF(160,390),
                new PointF(160,530),
                new PointF(60,530),
                new PointF(60,390),

                new PointF(10,390),

            });

            g.DrawLines(new Pen(Color.Black), new PointF[]
            {
                 new PointF(10,250),
                new PointF(60,250),
            });

            g.DrawBezier(Pens.Black,
                60, 250, 65, 260, 65, 260, 60, 270);

            g.DrawLines(new Pen(Color.Black), new PointF[]
           {

                new PointF(60,270),
                new PointF(10,270),
           });

            foreach (var item in dic)
            {

                g.FillRectangle(Brushes.LawnGreen, item.Value);
                g.DrawString(item.Key.NumeroVaga, this.Font, Brushes.Black, new Point(item.Value.X, item.Value.Y));

            }
            //g.FillRectangle(Brushes.LawnGreen, 61, 390, 98, 140);
            //g.DrawString("AB-1", this.Font, Brushes.Black, new Point(61, 390));

        }
    }



}
