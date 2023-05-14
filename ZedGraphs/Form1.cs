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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ZedGraphs
{
    public partial class Form1 : Form
    {
        int max_iter = 100;
        double a = 3;
        double R = 10;
        double Re_c;
        double Im_c;
        double Im_z = 0;
        double Re_z = 0;
        PointPairList list = new PointPairList();
        PointPairList list2 = new PointPairList();
        PointPairList list3 = new PointPairList();
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList();
        PointPairList list6 = new PointPairList();
        LineItem myCurve2;
        LineItem myCurve3;
        LineItem myCurve4;
        LineItem myCurve5;
        LineItem myCurve6;

        public Form1()
        {
            InitializeComponent();
        }

        private void Maldenbrot()
        {
            double Im_z2 = Im_z;
            double Re_z2 = Re_z;
            double Im_z_copy;
            double Re_z_copy;
            double distans;
            for (double i = -a; i < a; i += 0.005)
            {
                for (double j = -a; j < a; j += 0.005)
                {
                    bool flag = false;
                    Im_z2 = 0;
                    Re_z2 = 0;
                    Im_c = j;
                    Re_c = i;
                    for (int count = 0; count < max_iter; count++)
                    {
                        Re_z_copy = Re_z2 - Re_z2* Re_z2 + Im_z2 * Im_z2 + Re_c;
                        Im_z_copy = Im_z2* Re_z2 + Im_c;
                        distans = Math.Sqrt(Math.Pow(Re_z_copy, 2) + Math.Pow(Im_z_copy, 2));
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
                        Re_z2 = Re_z_copy;
                        Im_z2 = Im_z_copy;

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
            list.Clear();
            list2.Clear();
            list3.Clear();
            list4.Clear();
            list5.Clear();
            list6.Clear();

            // Очистим список кривых
            pane.CurveList.Clear();


            double xmin = -0.5;
            double xmax = 3;
            if (textBox_a.Text != "")
            {
                a = Convert.ToDouble(textBox_a.Text);
            }
            if (textBox_R.Text != "")
            {
                R = Convert.ToDouble(textBox_a.Text);
            }
            if (textBox_Rez.Text != "")
            {
                Re_z = Convert.ToDouble(textBox_a.Text);
            }
            if (textBox_Imz.Text != "")
            {
                Im_z = Convert.ToDouble(textBox_a.Text);
            }
            // Заполняем список точек
            Maldenbrot();
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.Black, SymbolType.Circle);
            if (color_choice.Checked == true)
            {
                myCurve2 = pane.AddCurve("< 5", list2, Color.Red, SymbolType.Circle);
                myCurve3 = pane.AddCurve("< 10", list3, Color.Green, SymbolType.Circle);
                myCurve4 = pane.AddCurve("< 15", list4, Color.Gray, SymbolType.Circle);
                myCurve5 = pane.AddCurve("< 30", list5, Color.Khaki, SymbolType.Circle);
                myCurve6 = pane.AddCurve("> 30", list6, Color.Lime, SymbolType.Circle);
            }

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;
            if (color_choice.Checked == true)
            {
                myCurve2.Line.IsVisible = false;
                myCurve3.Line.IsVisible = false;
                myCurve4.Line.IsVisible = false;
                myCurve5.Line.IsVisible = false;
                myCurve6.Line.IsVisible = false;
            }

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Black;
            if (color_choice.Checked == true)
            {
                myCurve2.Symbol.Fill.Color = Color.Red;
                myCurve3.Symbol.Fill.Color = Color.Green;
                myCurve4.Symbol.Fill.Color = Color.Gray;
                myCurve5.Symbol.Fill.Color = Color.Khaki;
                myCurve6.Symbol.Fill.Color = Color.Lime;
            }

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;
            if (color_choice.Checked == true)
            {
                myCurve2.Symbol.Fill.Type = FillType.Solid;
                myCurve3.Symbol.Fill.Type = FillType.Solid;
                myCurve4.Symbol.Fill.Type = FillType.Solid;
                myCurve5.Symbol.Fill.Type = FillType.Solid;
                myCurve6.Symbol.Fill.Type = FillType.Solid;
            }
            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -2;
            pane.YAxis.Scale.Max = 2;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();
            // Обновляем график
            zedGraph.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_Imz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
