using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] NahodnaCisla(int prvky, int Od, int Do)
        {
            int[] pole = new int[prvky];
            Random rnd = new Random();

            for (int i = 0; i < prvky; i++)
            {
                pole[i] = rnd.Next(Od, Do);
            }

            return pole;
        }

        void ZobrazeniListbox(int[] pole, ListBox lb)
        {
            foreach (int prvek in pole)
            {
                lb.Items.Add(prvek);
            }
        }

        void Prohozeni(int[] pole, ListBox lb)
        {
            int max = 0;
            int pozice = 0;
            int i = 0;
            foreach(int prvek in pole)
            {
                if (prvek > max)
                {
                    max = prvek;
                    pozice = i;
                }
                i++;
            }

            int kybl = pole[pole.Length - 1];
            pole[pole.Length - 1] = pole[pozice];
            pole[pozice] = kybl;

            foreach (int cislo in pole)
            {
                lb.Items.Add(cislo);
            }
        }

        int prvky;
        int Od;
        int Do;

        private void button1_Click(object sender, EventArgs e)
        {
            int prvky = int.Parse(textBox1.Text);
            int Od = int.Parse(textBox2.Text);
            int Do = int.Parse(textBox3.Text);


            ZobrazeniListbox(NahodnaCisla(prvky, Od, Do), listBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prohozeni(NahodnaCisla(prvky, Od, Do), listBox1);
        }
    }
}
