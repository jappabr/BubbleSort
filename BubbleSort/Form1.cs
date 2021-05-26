using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public string[] nomes = { "Julio", "Amelia", "Henrique", "Silva", "Camila", "Rui", "Cesar", "Benedito", "Alonso",
        "Claudia", "Maria", "Lucas", "Renato", "Heloisa", "Vilma", "Wanessa", "Ricardo", "Daniela", "Mauro", "Antonio" };
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i<20; i++)
            {
                listBox1.Items.Add(nomes[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int j=0; j<19; j++)
            {
                for(int i=0; i<19; i++)
                {
                    string aux = "";
                    if (nomes[i].CompareTo(nomes[i+1]) >= 0)
                    {
                        aux = nomes[i];
                        nomes[i] = nomes[i + 1];
                        nomes[i + 1] = aux;
                    }
                }
            }
            listBox1.Items.Clear();
            for(int i=0; i<20; i++)
            {
                listBox1.Items.Add(nomes[i]);
            }
        }
    }
}
