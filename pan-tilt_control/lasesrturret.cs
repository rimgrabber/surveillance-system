## use the platform .NETframework in Visual Studio and operate the pan-tilt using laser  first
## C# code using mouse to control turret

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


namespace laserturret
{
    public partial class Form1 : Form
    {
        public Stopwatch watch { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            port.Open();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            writetoPort(new Point(e.X, e.Y));
        }

        public void writetoPort(Point coordinates)
        {
            if (watch.ElapsedMilliseconds > 15)
            {
                watch = Stopwatch.StartNew();

                port.Write(String.Format("X{0}Y{1}",
               (coordinates.X / (Size.Width / 180)),
               (coordinates.Y / (Size.Height / 90))));
            }

        }
    }
}
