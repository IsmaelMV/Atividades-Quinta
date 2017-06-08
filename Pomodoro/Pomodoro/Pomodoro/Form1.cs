using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        int  hora = 0, min = 0, seg = 0,hora2 = 0, min2 = 0, seg2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblestado.Text = "Praticar atividade";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            lblestado.Text = "Descanse";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            else if (min == 60)
            {
                hora++;
                min = 0;
            }

            lblTempo.Text = hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

            if (lblTempo.Text == "00:00:25")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Tempo de Atividade Encerrado, ative o seu tempo de descanso");
                    button2.Enabled = true;
                    lblTempo.Text = "00:00:00";
                    button1.Enabled = false; 
                    

                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seg2++;
            if (seg == 60)
            {
                min2++;
                seg = 0;
            }

            else if (min == 60)
            {
                hora2++;
                min = 0;
            }

            lblTempo2.Text = hora2.ToString().PadLeft(2, '0') + ":" + min2.ToString().PadLeft(2, '0') + ":" + seg2.ToString().PadLeft(2, '0');

            if (lblTempo2.Text == "00:00:10")
            {
                timer2.Enabled = false;
                MessageBox.Show("Tempo de descanso Encerrado, ative o seu tempo de atividade");
                //button2.Enabled = true;
                lblTempo2.Text = "00:00:00";
                button2.Enabled = false;
                button1.Enabled = true;
                seg = 0;
                seg2 = 0;
                min = 0;
                min2 = 0;
                hora = 0;
                hora2 = 0;

            }
        }
    }
}
