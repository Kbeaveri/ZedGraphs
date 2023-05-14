using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ZedGraphs
{
    public partial class Form1 : Form
    {
        int max_iter = 100;
        double a1 = -0.5;
        double a2 = 3;
        double R = 10;
        double Re_c;
        double Im_c;
        PointPairList list = new PointPairList();
        PointPairList list2 = new PointPairList();
        PointPairList list3 = new PointPairList();
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList();
        PointPairList list6 = new PointPairList();

        public Form1()
        {
            InitializeComponent();
            DrawGraph();
        }

        private void Maldenbrot()
        {
            double Im_z;
            double Re_z;
            double Im_z_copy;
            double Re_z_copy;
            double distans;
            for (double i = a1; i < a2; i += 0.005)
            {
                for (double j = a1; j < a2; j += 0.005)
                {
                    bool flag = false;
                    Im_z = 0;
                    Re_z = 0;
                    Im_c = j;
                    Re_c = i;
                    for (int count = 0; count < max_iter; count++)
                    {
                        Re_z_copy = Re_z - Re_z* Re_z + Im_z * Im_z + Re_c;
                        Im_z_copy = Im_z* Re_z + Im_c;
                        distans = Math.Sqrt(Math.Pow(Re_z_copy, 2) + Math.Pow(Im_z_copy, 2));
                        if (i == 0 && j == 0)
                        {
                            Console.WriteLine(count);
                        }
                        if (distans > R)
                        {
                            flag = true;
                            if (count < 5)
                            {
                                list2.Add(i, j);
                            }
                            else if (count < 10)
                            {
                                list3.Add(i, j);
                            }
                            else if (count < 15)
                            {
                                list4.Add(i, j);
                            }
                            else if (count < 30)
                            {
                                list5.Add(i, j);
                            }
                            else
                            {
                                list6.Add(i, j);
                            }
                            break;
                        }
                        Re_z = Re_z_copy;
                        Im_z = Im_z_copy;

                    }
                    if (flag == false)
                    {
                        list.Add(i, j);
                    }
            }
            }
        }
        private void DrawGraph()
        {
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых
            pane.CurveList.Clear();


            double xmin = -0.5;
            double xmax = 3;

            // Заполняем список точек
            Maldenbrot();
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.Black, SymbolType.Circle);
            LineItem myCurve2 = pane.AddCurve("Scatter", list2, Color.Red, SymbolType.Circle);
            LineItem myCurve3 = pane.AddCurve("Scatter", list3, Color.Green, SymbolType.Circle);
            LineItem myCurve4 = pane.AddCurve("Scatter", list4, Color.Gray, SymbolType.Circle);
            LineItem myCurve5 = pane.AddCurve("Scatter", list5, Color.Khaki, SymbolType.Circle);
            LineItem myCurve6 = pane.AddCurve("Scatter", list6, Color.Lime, SymbolType.Circle);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;
            myCurve2.Line.IsVisible = false;
            myCurve3.Line.IsVisible = false;
            myCurve4.Line.IsVisible = false;
            myCurve5.Line.IsVisible = false;
            myCurve6.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Black;
            myCurve2.Symbol.Fill.Color = Color.Red;
            myCurve3.Symbol.Fill.Color = Color.Green;
            myCurve4.Symbol.Fill.Color = Color.Gray;
            myCurve5.Symbol.Fill.Color = Color.Khaki;
            myCurve6.Symbol.Fill.Color = Color.Lime;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve2.Symbol.Fill.Type = FillType.Solid;
            myCurve3.Symbol.Fill.Type = FillType.Solid;
            myCurve4.Symbol.Fill.Type = FillType.Solid;
            myCurve5.Symbol.Fill.Type = FillType.Solid;
            myCurve6.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -0.5;
            pane.YAxis.Scale.Max = 1;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
    }
}
