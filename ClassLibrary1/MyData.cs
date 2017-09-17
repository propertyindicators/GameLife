using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LifeProga
{
    /// <summary>
    /// Гловальные константы размера полотна Жизни и масштабирования (коэффициента увеличения)
    /// </summary>
    public static class MySize
    {
        public static int mainsize = 611;
        public static int scalling = 1;
    }

    /// <summary>
    /// Гловальная константа времени задержки (в миллисекундах) между циклами жизни
    /// </summary>
    public static class LifeSleep
    {
        public static int count = 100;
    }

    /// <summary>
    /// Класс содержит словарь инициализирующих рисунков, заданніх точкасми, идин из которіх при инициализации помещяется в центр полотна
    /// </summary>
    public static class InitDict
    {
        public static Dictionary<string, LifeInitType> pic = new Dictionary<string, LifeInitType>()
        {
            { "прямоугольник", new LifeInitType() {  points = new List<Point>()
            { new Point(-1,-1), new Point(0,-1), new Point(1,-1), new Point(-1,0), new Point(-1,0),new Point(1,0), new Point(-1,1),new Point(0,1),new Point(1,1) } } },
            { "крестик", new LifeInitType() {  points = new List<Point>()
            { new Point(0,-2), new Point(0,-1), new Point(0,0),new Point(0,1), new Point(0,2), new Point(-2,0), new Point(-1,0), new Point(1,0),new Point(2,0) } } },
            { "пупер", new LifeInitType() {  points = new List<Point>()
            {   new Point(-1,-3),new Point(0,-3),new Point(1,-3),
                new Point(-1,-2), new Point(1,-2),
                new Point(-3,-1), new Point(-2,-1),new Point(-1,-1), new Point(1,-1), new Point(2,-1),new Point(3,-1),
                new Point(-3,0), new Point(3,0),
                new Point(-3,1), new Point(-2,1),new Point(-1,1), new Point(1,1), new Point(2,1),new Point(3,1),
                new Point(-1,2), new Point(1,2),
                new Point(-1,3), new Point(0,3),new Point(1,3)
            } } }
        };
    }



}

