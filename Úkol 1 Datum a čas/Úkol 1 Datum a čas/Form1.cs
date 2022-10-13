using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_1_Datum_a_čas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Nejstarsi = new DateTime();
            string vstup = "";
            Nejstarsi = DateTime.Today;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                vstup = textBox1.Lines[i];
                if(vstup > Nejstarsi)
                {
                    Nejstarsi = vstup;
                }
            }
            OdpovedLabel.Text = Nejstarsi.ToString();
        }
    }
}
