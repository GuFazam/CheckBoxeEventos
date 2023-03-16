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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            String txt = ""; // escrever na tela
            if (chkMaca.Checked) //se  checkBoxMaçã estiver selecionado ele vai escrever na tela maçã e assim por diante
            {
                txt += chkMaca.Text + ", ";
            }
            if (chkPera.Checked) 
            {
                txt += chkPera.Text + ", ";
            }
            if (chkUva.Checked) 
            {
                txt += chkUva.Text + ", ";
            }
            if (chkAbacaxi.Checked) 
            {
                txt += chkAbacaxi.Text + ", ";
            }
            if (chkMorango.Checked)
            {
                txt += chkMorango.Text + ", ";
            }
            if (chkBanana.Checked)
            {
                txt += chkBanana.Text + ", ";
            }
            if (chkMamao.Checked)
            {
                txt += chkMamao.Text + ", ";
            }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "A fruta escolhida foi..."); // exibe a mensagem e as frutas escolhidas
        }
    }
}
