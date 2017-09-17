using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LifeProga
{
    /// <summary>
    /// Класс, который содержит всю базовую и текущую (рабочую) информацию о конкретном полотне Жизни,
    /// а также методы отработки циклов жизни и прорисовки полотна
    /// </summary>
   public class MyLife
    {
        bool[,] mainarr;
        /// <summary>
        /// базовый конструктор создает пустой массив "клеток" (булевских переменных) нужного размера и заполняет его false
        /// </summary>
        public MyLife()
        {
            mainarr = new bool[MySize.mainsize, MySize.mainsize];
            for (int i=0;i<MySize.mainsize;i++) { for (int ii=0;ii<MySize.mainsize;ii++) { mainarr[i, ii] = false; } }
        }

        /// <summary>
        /// конструктор создает пустой массив "клеток" (булевских переменных) нужного размера 
        /// и заполняет его центр инициализирующим рисунком
        /// </summary>
        /// <param name="init">инициализирующий рисунок</param>
        public MyLife(LifeInitType init):this()
        {
            //определяем центр холста в точках
            int cxy = Convert.ToInt32(Math.Round((double)MySize.mainsize/2-0.05));
            foreach (Point p in init.points)
            {
                mainarr[cxy + p.X, cxy + p.Y] = true;
            }

        }

        /// <summary>
        /// Метод отрабатывает один цикл Жизни
        /// </summary>
        public void Evolute()
        {
            bool[,]  newarr = new bool[MySize.mainsize, MySize.mainsize];
            
            for (int i = 0; i < MySize.mainsize; i++)
            {
                for (int ii = 0; ii < MySize.mainsize; ii++)
                {
                    newarr[i, ii] = MyCheck(i, ii);
                }
            }
            mainarr = newarr;
        }

        /// <summary>
        /// Метод возвращает текущее полотно Жизни в виде рисунка Bitmap, учитывая заданный размер и масштабирование
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImage()
        {
            //Прорисовка сетки
            Bitmap tBitmap = new Bitmap(MySize.mainsize*MySize.scalling + 1, MySize.mainsize * MySize.scalling + 1);
            Graphics g = Graphics.FromImage(tBitmap);
            using (g)
            {
                g.Clear(Color.White);
                SolidBrush p = new SolidBrush(Color.Green);
                //рисуем квадратики
                for (int i = 0; i < MySize.mainsize; i++)
                {
                    for (int ii = 0; ii < MySize.mainsize; ii++)
                    {
                        if (mainarr[i, ii]) { g.FillRectangle(p, i * MySize.scalling, ii * MySize.scalling,  MySize.scalling, MySize.scalling); }
                    }
                }
            }
            return tBitmap;
        }

        /// <summary>
        /// Метод проверяет условия выживания/возникновения/гибели для одной клетки с указанными координатами на текущем полотне,
        /// метод задает логику жизни
        /// </summary>
        /// <param name="x">x координата клетки</param>
        /// <param name="y">y координата клетки</param>
        /// <returns>возвращает новое состояние клетки</returns>
        private bool MyCheck(int x, int y)
        {
            //собираем количества вокруг включая точку (в квадрате 3х3)
            int lcount = 0;
            for(int i=x-1;i<=x+1;i++)
            {
                for(int ii=y-1;ii<=y+1;ii++)
                {
                    if (i < 0 || i >= MySize.mainsize || ii < 0 || ii >= MySize.mainsize) { }
                    else
                    {
                        if (mainarr[i,ii]) { lcount = lcount + 1; }//если есть "клетка" - увеличиваем счетчик на 1
                    }
                }
            }
            if (lcount >= 2 && lcount <= 4) { return true; } else { return false; }
        }
    }

    /// <summary>
    /// Класс для создания инициализирующих рисунков
    /// </summary>
    public class LifeInitType
    {
        public List<Point> points { get; set; }
    }
}
