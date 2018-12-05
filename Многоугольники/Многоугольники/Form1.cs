using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Многоугольники
{

    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
        byte algorithm_choice = 0; // 0 - По определению, 1 - Джарвис
        int pressDownX;
        int pressDownY;
        byte choice = 1;
        List<Shape> L = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //антимерцание
            L.Add(new Triangle(this.ClientSize.Width / 2, this.ClientSize.Height / 2)); //стартовый треугольник в середине
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape S in L)
            {
                S.DO_NOT_DELETE_FLAG = false;
            }
            Graphics gr = e.Graphics;
            //построение выпуклой оболочки
            #region CONVEX_HULL_BUILD
            if (L.Count > 2) //Если число вершин больше 2-х, запускаем выбор алгоритма построения выпуклой оболочки и сами алгоритмы
            {
                switch (algorithm_choice)
                {
                    case 0:
                        #region BY_DEFENITION
                        bool higher_or_right;
                        bool lower_or_left;
                        for (int n = 0; n < L.Count - 1; n++)
                        {
                            for (int l = n + 1; l < L.Count; l++)
                            {
                                higher_or_right = false;
                                lower_or_left = false;
                                if (L[n].X == L[l].X) //обработка случая, в котором точки на одной прямой по x (только левее или только правее)
                                {
                                    for (int z = 0; z < L.Count; z++)
                                    {
                                        if (z == n || z == l) //если индекс проверяемой точки совпадает с индексом одной из точек пар, по которой мы построили прямую, нам она не нужна в принципе
                                        {
                                            continue;
                                        }
                                        if (L[z].X > L[n].X) // точка правее врямой
                                        {
                                            higher_or_right = true;
                                        }
                                        if (L[z].X < L[n].X) // точка левее прямой 
                                        {
                                            lower_or_left = true;
                                        }
                                    }
                                    if ((higher_or_right == true || lower_or_left == true) & !(higher_or_right == true & lower_or_left == true)) // рисование линии, если всё ок,higher = левее, lower 
                                    {
                                        L[n].DO_NOT_DELETE_FLAG = true;
                                        L[l].DO_NOT_DELETE_FLAG = true;
                                        e.Graphics.DrawLine(pen, L[n].X, L[n].Y, L[l].X, L[l].Y);

                                    }
                                }
                                else //нормальный случай, в котором точки не находятся друг над другом по х
                                {
                                    // y = kx + b , находим коэфф-ы k и b для данной прямой
                                    float k = (float)-(L[l].Y - L[n].Y) / (float)(L[n].X - L[l].X);
                                    float b = L[n].Y - L[n].X * k;

                                    for (int z = 0; z < L.Count; z++)
                                    {
                                        if (z == n || z == l) //если индекс проверяемой точки совпадает с индексом одной из точек пар, по которой мы построили прямую, нам она не нужна в принципе
                                        {
                                            continue;
                                        }
                                        if ((L[z].X * k + b) > L[z].Y) //левая часть приведётся к float из-за домножения
                                        {
                                            higher_or_right = true;
                                        }
                                        if ((L[z].X * k + b) < L[z].Y) //левая часть приведётся к float из-за домножения
                                        {
                                            lower_or_left = true;
                                        }
                                    }
                                    if ((higher_or_right == true || lower_or_left == true) & !(higher_or_right == true && lower_or_left == true)) //рисование линии, если всё ок 
                                    {
                                        L[n].DO_NOT_DELETE_FLAG = true;
                                        L[l].DO_NOT_DELETE_FLAG = true;
                                        e.Graphics.DrawLine(pen, L[n].X, L[n].Y, L[l].X, L[l].Y);
                                        continue;
                                    }
                                }
                            }
                        }


                        #endregion
                        break;
                    case 1:
                        #region JARVIS
                        //нахождение самой левой и нижней точки y = max / x = min
                        int Biggest_Y;
                        int Lowest_X;
                        // переменные выше используются только в начале процесса
                        int Index = 0;  //начальная точка оболочки
                        int Current_point; // Начальная точка вектора, построение следующего идёт от New_Point
                        int New_point = 0; //точка, становящаяся новой вершиной, отсюда идёт построение
                        int Potential_point = 0;//Переменная, необходимая для сравнения 
                                                //    int Buffer=0;
                        float Cosine; //косинус угла
                        float new_Cosine;
                        Biggest_Y = L[0].Y;
                        for (int n = 0; n < L.Count; n++) //прогоняем весь лист точек, ищем max y;  
                        {
                            if (L[n].Y > Biggest_Y)
                            {
                                Biggest_Y = L[n].Y; //найдена точка с большим Y - перезаписываем индекс
                                Index = n;
                            }
                        }
                        Lowest_X = L[0].X;
                        for (int n = 0; n < L.Count; n++) //прогоняем все точки с максимальным y (условно - на одной прямой), ищем самую левую (x - наим)
                        {
                            if (L[n].X < Lowest_X && L[n].Y == Biggest_Y)
                            {
                                Lowest_X = L[n].X;
                                Index = n;
                            }
                        }

                        //точка найдена, строим первый угол, наименьший (следовательно, косинус наибольший)
                        //INDEX - начальная точка, ей и останется
                        Cosine = -2; //начальный косинус, т.к ищем мы косинус изначально наибольший, то cos - минимально возможный
                        for (int i = 0; i < L.Count; i++) //перебор первого угла , сравнение синуса
                        {
                            if (i == Index) //вектор, начинающийся и заканчивающийся одной и той же точкой. ХММММ.
                            {
                                continue;
                            }
                            int x, y;
                            x = L[i].X - L[Index].X;
                            y = L[i].Y - L[Index].Y;
                            // так как здесь второй вектор - всегда прямая, параллельная oX, то её параметры просто (2,0). Нам лишь нужен сонаправленный oX вектор, лежаший на этой прямой
                            new_Cosine = (float)(x * 2.0 + y * 0) / ((float)(Math.Sqrt(x * x + y * y) * Math.Sqrt(2.0)));
                            // выше - вектор с точками (вершинами) Index и I 
                            // так как здесь второй вектор - всегда прямая, параллельная oX, то её параметры просто (2,0). Нам лишь нужен сонаправленный oX вектор, лежаший на этой прямой
                            if (new_Cosine > Cosine)
                            {
                                Cosine = new_Cosine;
                                New_point = i;
                            }
                        }
                        //Первая линия найдена, рисуем
                        L[Index].DO_NOT_DELETE_FLAG = true;
                        L[New_point].DO_NOT_DELETE_FLAG = true;
                        e.Graphics.DrawLine(pen, L[Index].X, L[Index].Y, L[New_point].X, L[New_point].Y);




                        Current_point = Index;
                        //ищем остальные линии. Теперь угол нам нужен везде наибольший. (Косинус - наименьший)


                        while(New_point != Index)
                        {
                            Cosine = 2; //т.к ищем наименьший, начинаем с наибольшего
                            for (int i = 0; i <= L.Count - 1; i++)
                            {
                                if (i == New_point || i == Current_point)
                                {
                                    continue;
                                }

                                int x, y, x1, y1; //Переменные для вычисления векторов
                                                  //Вектор, с которым ведётся работа сейчас
                                x = L[Current_point].X - L[New_point].X;
                                y = L[Current_point].Y - L[New_point].Y;
                                //Потенциальный вектор
                                x1 = L[i].X - L[New_point].X;
                                y1 = L[i].Y - L[New_point].Y;
                                new_Cosine = (x * x1 + y * y1) / ((float)(Math.Sqrt(x * x + y * y) * Math.Sqrt(x1 * x1 + y1 * y1)));
                                if (new_Cosine < Cosine)
                                {
                                    Cosine = new_Cosine;
                                    Potential_point = i; //потенциальная точка в итоге станет конечной новой линии
                                }
                            }

                            L[New_point].DO_NOT_DELETE_FLAG = true;
                            L[Potential_point].DO_NOT_DELETE_FLAG = true;
                            e.Graphics.DrawLine(pen, L[New_point].X, L[New_point].Y, L[Potential_point].X, L[Potential_point].Y);

                            // Назначаем новые опорные точки 
                            Current_point = New_point;
                            New_point = Potential_point;
                        }
                        #endregion
                        break;
                }
            }
            else
            {
                foreach(Shape S in L) // предотвращение стирания вершин, когда их меньше трёх
                {
                    S.DO_NOT_DELETE_FLAG = true;
                }
            }
            #endregion  
            foreach (Shape S in L) //отрисовка листа
            {
                S.Draw(gr);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pressDownX = e.X;
            pressDownY = e.Y;
            bool m = false;
            foreach (Shape S in L) // проверяем, попал ли курсор в фигуру 
            {
                S.FlagUpdater(e.X, e.Y);
                if (S.FLAG == true)
                {
                    m = true;
                }
            }
            if (m == true) //попадание в фигуру
            {
                if (e.Button == MouseButtons.Right) //удаление, перетаскивание реализовано проверкой на попадание + Mouse move методом 
                {
                    for (int i = L.Count - 1; i >= 0; i--) //удаление самой "верхней" (позднее созданной) вершины 
                    {

                        L[i].FlagUpdater(e.X, e.Y);
                        if (L[i].FLAG == true)
                        {
                            L.RemoveAt(i);
                            this.Refresh();
                            break;
                        }
                    }

                }
                else
                {
                    foreach (Shape S in L)   ////"защита" от нажатия на лкм, когда мы ничего не сделали
                    {
                        S.DO_NOT_DELETE_FLAG = true;
                    }
                }
            }
            else //мы никуда не попали
            {
                if (e.Button == MouseButtons.Left) //рисование на пустой области ЛКМ, на ПКМ ничего нет 
                {
                    switch (choice)
                    {
                        case 1:
                            L.Add(new Triangle(e.X, e.Y));
                            Refresh();
                            break;
                        case 2:
                            L.Add(new Ellipse(e.X, e.Y));
                            Refresh();
                            break;
                        case 3:
                            L.Add(new Rectangle(e.X, e.Y));
                            Refresh();
                            break;
                    }

                }
                else //"защита" от нажатия на пкм, когда мы никуда не попадаем 
                {
                    foreach (Shape S in L)
                    {
                        S.DO_NOT_DELETE_FLAG = true;
                    }
                }
            }
            if (L.Count > 2)
            {
                bool k = false;
                for (int l = 0; l < L.Count; l++) // Очистка при построении выпуклых оболочек
                {
                    if (L[l].DO_NOT_DELETE_FLAG == false)
                    {
                        L.RemoveAt(l);
                        l = l - 1;
                        k = true;
                    }
                }
                if (k)
                {
                    Refresh();
                }

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (L.Count > 2)
            {
                bool m = false;
                for (int l = 0; l < L.Count; l++) // Очистка при построении выпуклых оболочек
                {
                    if (L[l].DO_NOT_DELETE_FLAG == false)
                    {
                        L.RemoveAt(l);
                        l = l - 1;
                        m = true;
                    }
                }
                if (m)
                {
                    Refresh();
                }

            }
            foreach (Shape S in L) //все объекты станут несдвигаемыми
            {
                S.FLAG = false;
                S.DO_NOT_DELETE_FLAG = false;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e) //двигается всё тут 
        {
            foreach (Shape S in L)
            {
                if (S.FLAG == true)
                {
                    S.X = S.X + e.X - pressDownX;
                    S.Y = S.Y + e.Y - pressDownY;
                    Refresh();
                }
            }
            pressDownX = e.X;
            pressDownY = e.Y;
        }
        private void triangleToolStripMenuItem_Click(object sender, EventArgs e) // кнопка треугольника 
        {
            choice = 1;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e) // кнопка круга
        {
            choice = 2;
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e) // кнопка квадрата
        {
            choice = 3;
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e) //По определению
        {
            algorithm_choice = 0;
            Refresh(); // При нажатии на пункт в меню перерисовывается оболочка другим алгоритмом
        }
        private void jarvisToolStripMenuItem_Click(object sender, EventArgs e) //Джарвис
        {
            algorithm_choice = 1;
            Refresh(); // При нажатии на пункт в меню перерисовывается оболочка другим алгоритмом
        }
    }
    }