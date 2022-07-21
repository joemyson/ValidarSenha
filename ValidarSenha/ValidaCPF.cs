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
    public partial class ValidaCPF : Form
    {
        public ValidaCPF()
        {
            InitializeComponent();
        }

        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            Msk_textbox.Text = "";
            lbl_text.Text = "";

        }

      

        private void btn_valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = Valida(Msk_textbox.Text);
             if(validaCpf == true)
            {
                lbl_text.Text = "CPF VALIDO";
                lbl_text.ForeColor = Color.Green;
            }
            else
            {
                lbl_text.Text = "CPF INVALIDO";
                lbl_text.ForeColor = Color.Red;

            }

        }
    }
}
