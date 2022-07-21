using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarSenha
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void btn_hora_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "00:00";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();
        }

        private void btn_Cep_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "00000-000";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();

        }

        private void btn_moeda_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "$ 000.0000,00";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();

        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "00/00/0000";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();

        }

        private void btn_telefone_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "(00) 00000-0000";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();
        }

        private void btn_verConteudo_Click(object sender, EventArgs e)
        {
            lbl_conteudo.Text = Msk_Textbox.Text;
        }

        private void btn_senha_Click(object sender, EventArgs e)
        {
            Msk_Textbox.UseSystemPasswordChar = true;
            lbl_conteudo.Text = "";
            Msk_Textbox.Mask = "00000000";
            lbl_MascaraAtiva.Text = Msk_Textbox.Mask;
            Msk_Textbox.Text = "";
            Msk_Textbox.Focus();
        }
    }
}
