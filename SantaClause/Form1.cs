using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClause
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int obstSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_tick1(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Obst1.Left -= obstSpeed;
            Obst2.Left -= obstSpeed;
            Obst3.Left -= obstSpeed;
            Obst4.Left -= obstSpeed;
            

            if(Obst1.Left < -100)
            {
                Obst1.Left = 500;
                
            }

            if(Obst4.Left < -100)
            {
                Obst4.Left = 600;
                
            }
            if(Obst2.Left < -100)
            {
                Obst2.Left = 500;
                
            }
            if(Obst3.Left < -100)
            {
                Obst3.Left = 600;
                
            }
            if(Santa.Top < -25)
            {
                gameOVer();
            }

            if(Santa.Bounds.IntersectsWith(Obst1.Bounds) || Santa.Bounds.IntersectsWith(Obst2.Bounds) || Santa.Bounds.IntersectsWith(Obst3.Bounds) ||
                Santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOVer();
            }           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Santa_Click(object sender, EventArgs e)
        {

        }

        private void Obst1_Click(object sender, EventArgs e)
        {

        }

        private void gameOVer()
        {
            timer1.Stop();
            
        }
    }
}
