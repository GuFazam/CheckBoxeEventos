using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxeEventos
{
    public partial class Form1 : Form
    {
        List <CheckBox> frutas = new List <CheckBox> (); // cria uma lista e uma variavel (fruta) essa lista será utilizada para fazer "o Foreach" ser percorrido!
        public Form1()
        {
            InitializeComponent();
            frutas.Add(chkMaca); // essas são as variaveis a serem chamadas pelo Foreach
            frutas.Add(chkPera); // "frutas" é por causa da lista e o Add é para adcionar os checkBox
            frutas.Add(chkUva);
            frutas.Add(chkAbacaxi);
            frutas.Add(chkMorango);
            frutas.Add(chkBanana);
            frutas.Add(chkMamao);
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            String txt = ""; // escrever na tela

            foreach (CheckBox t in frutas)// variavel t de total
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "Sua escolha: ");

            //if (chkMaca.Checked) //se  checkBoxMaçã estiver selecionado ele vai escrever na tela maçã e assim por diante
            //{
            //    txt += chkMaca.Text + ", ";
            //}
            //if (chkPera.Checked) 
            //{
            //    txt += chkPera.Text + ", ";
            //}
            //if (chkUva.Checked) 
            //{
            //    txt += chkUva.Text + ", ";
            //}
            //if (chkAbacaxi.Checked) 
            //{
            //    txt += chkAbacaxi.Text + ", ";
            //}
            //if (chkMorango.Checked)
            //{
            //    txt += chkMorango.Text + ", ";
            //}
            //if (chkBanana.Checked)
            //{
            //    txt += chkBanana.Text + ", ";
            //}
            //if (chkMamao.Checked)
            //{
            //    txt += chkMamao.Text + ", ";
            //}
            //MessageBox.Show(" A fruta escolhida foi: " + txt, "A fruta escolhida foi..."); // exibe a mensagem e as frutas escolhidas
        }

        private void chkMaca_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMaca.Checked)
            //{
            //    MessageBox.Show(" O item Maçã marcado!");
            //}
        }

        private void chkPera_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkPera.Checked)
            //{
            //    MessageBox.Show(" O item Pêra marcado!");
            //}
        }

        private void chkUva_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkUva.Checked)
            //{
            //    MessageBox.Show(" O item Uva marcado!");
            //}
        }

        private void chkAbacaxi_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAbacaxi.Checked)
            //{
            //    MessageBox.Show(" O item Abacaxi marcado!");
            //}
        }

        private void chkMorango_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMorango.Checked)
            //{
            //    MessageBox.Show(" O item Morango marcado!");
            //}
        }

        private void chkBanana_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkBanana.Checked)
            //{
            //    MessageBox.Show(" O item Banana marcado!");
            //}
        }

        private void chkMamao_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMamao.Checked)
            //{
            //    MessageBox.Show(" O item Mamão marcado!");
            //}
        }
    }
}
