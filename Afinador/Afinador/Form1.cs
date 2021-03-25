using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Afinador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\M.wav");
            sound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\A.wav");
            sound.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\D.wav");
            sound.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\G.wav");
            sound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\B.wav");
            sound.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\34-AfinadorViolão\e.wav");
            sound.Play();
        }
    }
}
