using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObrazacPDV oPDV = new ObrazacPDV(new ObrazacPDVArgs());
            bool jel = oPDV.CreateObrazacPDV();
            MessageBox.Show("Spremljeno: " + jel.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int start = 200;
                int stop = 215;
                int korak = 1;
                for (int i = start; i < stop; i += korak )
                {
                    Console.WriteLine(@"xml.AppendChild(Tijelo, Podatak" +i +");");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
