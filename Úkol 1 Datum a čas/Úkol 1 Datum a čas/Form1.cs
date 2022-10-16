using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            string JenomDen = Nejstarsi.ToString("d");
            string pomocna = "";
            string pomocna2 = JenomDen;
            Nejstarsi = DateTime.Today;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                pomocna = "";
                string text = textBox1.Lines[i];
                foreach (char c in text)
                {
                    if (c >= '0' && c < '9' || c == '/')
                    {
                        pomocna += c;
                    }
                }
                try
                {
                    if (Convert.ToDateTime(pomocna) < Convert.ToDateTime(JenomDen))
                    {

                        if (Convert.ToDateTime(pomocna2) > Convert.ToDateTime(pomocna))
                        {
                            pomocna2 = pomocna;
                            OdpovedLabel.Text = "Nejstarší člověk je: " + text;
                        }
                        else if (Convert.ToDateTime(pomocna) == Convert.ToDateTime(pomocna2))
                        {
                            OdpovedLabel.Text += "\na stejně starý je i: " + text;
                        }
                    }
                    else OdpovedLabel.Text = "Žádný člověk nenalezen";
                }
                catch
                {
                    MessageBox.Show("Pravděpodobně jsi zadal špatný formát data, závorky u nadpisu ti pomohou :D", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                OdpovedLabel.Text = Nejstarsi.ToString();
            }
        }
    }
}
