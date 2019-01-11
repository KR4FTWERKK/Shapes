using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многоугольники
{
    public partial class Form2 : Form
    {
        public event RadiusEventHandler RC;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Привязываем событие, "классифицированное" делегатом и связываем его с объектом класса RadiusEventArgs через конструктор
            if (RC != null)
            {
                this.RC(this, new RadiusEventArgs(trackBar1.Value));
            }
           
        }
    }
}
