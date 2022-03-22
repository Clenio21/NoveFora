using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoveFora
{
    public partial class Form1 : Form
    {
        string numero;
        int tamanho = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = textBox1.Text;
            tamanho = numero.Length;
            int aux=0;
            do
            {
                for (int i = 0; i < tamanho; i++)
                {
                    aux += int.Parse(numero[i].ToString());
                }
                tamanho = aux.ToString().Length;
                if (tamanho>1)
                {
                    numero = aux.ToString();
                    aux = 0;
                }
                
            } while (tamanho > 1);
            MessageBox.Show(aux.ToString());
        }
    }
}
