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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new WorkForm();
            MyLife l = new MyLife(InitDict.pic["крестик"]);
            f.MyInit(l);
            f.Show();
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);
            f.MyWork(l);
        }
    }
}
