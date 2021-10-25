using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbOne1
{
    public partial class Form1 : Form
    {
        int var1 = 0;
        int var2 = 0;
        int var3 = 0;
        int var4 = 0;
        int p = 0;
        int n = 0;
        int z = 0;
        int arranjo = 0;
        int fatorial = 0;

        
        public Form1()
        {
            InitializeComponent();            
        }

        public void Clear()
        {
            int var1 = 0;
            int var2 = 0;
            int p = 0;
            int n = 0;
            int z = 0;
            int arranjo = 0;
            int fatorial = 0;

            ckb1.Checked = false;
            ckb2.Checked = false;
            txb1.Text=("");
            txb2.Text=("");
            txb3.Text=("");
            listB1.Text=("");
            progressBar1.Value = 0;
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Por Favor, " + "\n" + "Escolha uma opção");

            txb1.Enabled = false;
            txb2.Enabled = false;
            txb3.Enabled = false;
            btn1.Enabled = false;
        }

        private void Ckb1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb1.Checked == true)
            {
                ckb2.Enabled = false;
                txb1.Enabled = true;
                txb2.Enabled = true;
                txb3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione uma opção!");

                ckb2.Enabled = true;
                txb1.Enabled = false;
                txb2.Enabled = false;
                txb3.Enabled = false;
            }
        }

        private void Ckb2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb2.Checked == true)
            {
                ckb1.Enabled = false;
                txb3.Enabled = true;
                txb1.Enabled = false;
                txb2.Enabled = false;

            }
            else
            {
                MessageBox.Show("Selecione uma opção!");

                ckb1.Enabled = true;
                txb1.Enabled = false;
                txb2.Enabled = false;
                txb3.Enabled = false;
            }
        }

        private void Txb1_TextChanged_1(object sender, EventArgs e)
        {
            
            var1 = Convert.ToInt32(txb1.Text);

            if (var1 != 0)
            {
                if (var2 != 0)
                {
                    btn1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Favor digitar um valor no campo: 'Formato do Agrupamento'");
                }
            }
            else
            {
                MessageBox.Show("Favor digite algum valor");
            }
        }

        private void Txb2_TextChanged_1(object sender, EventArgs e)
        {
            var2 = Convert.ToInt32(txb2.Text);

            if(var2 != 0)
            {
                if (var1 != 0)
                {
                    btn1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Favor digitar um valor no campo: 'Número de Elementos'");
                }
            }
            else
            {
                MessageBox.Show("Favor digite algum valor");
            }
        }



        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 20;
        }

        public void Progresso()
        {
            while (z <= 100)
            {
                if (z == 100)
                {                    
                    break;                    
                }
                else
                {
                    progressBar1.Value += 1;
                    z++;
                }
                
            }

        }
        
        private void Btn1_Click(object sender, EventArgs e)
        {
            Progresso();

            //var3 = Convert.ToInt32(txb1.Text);

            //var4 = Convert.ToInt32(txb2.Text);

            for (int i = 1; i <= (2 - var1); i++)
            {
                listB1.Items.Add(Convert.ToString(i + " fatorial= " + fatorial));
                arranjo = i;
                fatorial = arranjo * i;                
            }

            p = (var1 - var2);
            n = (arranjo);

            MessageBox.Show("Resposta: " + n);

            Clear();
        }

        
    }
}
