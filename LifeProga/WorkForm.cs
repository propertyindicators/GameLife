using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeProga
{
    /// <summary>
    /// Форма, в которой происходит отрисовка Жизни
    /// </summary>
    public partial class WorkForm : Form
    {
        bool workflag = true;//реализация кнопки останова

        public WorkForm()
        {
            InitializeComponent();
        }

        public void MyInit(MyLife ml)
        {
            FLab.Text = "Рабочее окно";
            this.Size = new Size(MySize.mainsize * MySize.scalling + 23, MySize.mainsize * MySize.scalling + 66);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.OutBox.Size = new Size(MySize.mainsize * MySize.scalling + 1, MySize.mainsize * MySize.scalling + 1);
            this.OutBox.Location = new Point(3, 23);
            this.OutBox.Visible = true;
            this.OutBox.Image = ml.GetImage();
            //this.Invalidate();
        }

        public void MyWork(MyLife l)
        {
            while (true)
            {
                if (workflag) { l.Evolute(); OutBox.Image = l.GetImage(); Application.DoEvents(); }
                System.Threading.Thread.Sleep(LifeSleep.count);
            }
        }

    }
}
