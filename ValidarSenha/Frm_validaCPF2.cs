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
    public partial class Frm_validaCPF2 : Form
    {
        public Frm_validaCPF2()
        {
            InitializeComponent();
        }

        private void btn_valida_Click(object sender, EventArgs e)
        {
            string V_conteudo;
            V_conteudo = Msk_textbox.Text;
            V_conteudo = V_conteudo.Replace(".", "").Replace("-", "");
            V_conteudo = V_conteudo.Trim();

            if (V_conteudo == "")
            {
                MessageBox.Show("Você tem que incluir o CPF", "Alerta de Situação do CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 

                if (MessageBox.Show("Deseja valida o CPF", "Caixa de Dialogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool validaCpf = false;
                    validaCpf = Classe_uteis.Valida(Msk_textbox.Text);
                    if (validaCpf == true)
                    {
                        MessageBox.Show("CPF VALIDO", "Alerta de Situação do CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("CPF INVALIDO", "Alerta de Situação do CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);



                    }

                }

            }

        }


        private void btn_limpa_Click(object sender, EventArgs e)
        {
            Msk_textbox.Text = "";
        }
    }
}
