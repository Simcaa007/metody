using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ulozit(TextBox tb)
        {
            int[] pole = new int[tb.Lines.Length];
            int radek = 0;
            foreach (string line in tb.Lines)
            {
                int cislo = int.Parse(line);
                pole[radek] = cislo;
                radek++;
            }
            return pole;
        }

        void zobrazit(int[] pole, ListBox lb)
        {
            foreach (int i in pole)
            {
                lb.Items.Add(i);
            }
        }

        bool rostouci(int[] pole)
        {
            foreach(int i in pole)
            {
                if (pole[i] > pole[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        int[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            // ULOZIT
            pole = new int[0];
            ulozit(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ZOBRAZIT
            zobrazit(ulozit(textBox1), listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ROSTOUCI?
            if (!rostouci(ulozit(textBox1)))
            {
                MessageBox.Show("Neni rostoucí");
            }
            else
            {
                MessageBox.Show("Je rostoucí");
            }
        }
    }
}
