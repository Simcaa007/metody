using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SoucetArPosl(int a1, int a2, int n, out int soucet, out int posledni, out int diference)
        {
            diference = a2 - a1;
            posledni = a1 + (n - 1) * diference;
            soucet = n * (a1 + posledni) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = int.Parse(textBox1.Text);
            int a2 = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);

            SoucetArPosl(a1, a2, n, out int soucet, out int posledni, out int diference);

            MessageBox.Show($"Součet: {soucet}\nPoslední člen: {posledni}\nDiference: {diference}");
        }
    }
}
