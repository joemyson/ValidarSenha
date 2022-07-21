
namespace ValidarSenha
{
    partial class Frm_Mascara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hora = new System.Windows.Forms.Button();
            this.btn_Cep = new System.Windows.Forms.Button();
            this.lbl_conteudo = new System.Windows.Forms.Label();
            this.lbl_MascaraAtiva = new System.Windows.Forms.Label();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_moeda = new System.Windows.Forms.Button();
            this.btn_senha = new System.Windows.Forms.Button();
            this.btn_telefone = new System.Windows.Forms.Button();
            this.btn_verConteudo = new System.Windows.Forms.Button();
            this.Msk_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_hora
            // 
            this.btn_hora.Location = new System.Drawing.Point(23, 110);
            this.btn_hora.Name = "btn_hora";
            this.btn_hora.Size = new System.Drawing.Size(82, 37);
            this.btn_hora.TabIndex = 3;
            this.btn_hora.Text = "Hora";
            this.btn_hora.UseVisualStyleBackColor = true;
            this.btn_hora.Click += new System.EventHandler(this.btn_hora_Click);
            // 
            // btn_Cep
            // 
            this.btn_Cep.Location = new System.Drawing.Point(111, 110);
            this.btn_Cep.Name = "btn_Cep";
            this.btn_Cep.Size = new System.Drawing.Size(82, 37);
            this.btn_Cep.TabIndex = 5;
            this.btn_Cep.Text = "Cep";
            this.btn_Cep.UseVisualStyleBackColor = true;
            this.btn_Cep.Click += new System.EventHandler(this.btn_Cep_Click);
            // 
            // lbl_conteudo
            // 
            this.lbl_conteudo.AutoSize = true;
            this.lbl_conteudo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conteudo.Location = new System.Drawing.Point(23, 246);
            this.lbl_conteudo.Name = "lbl_conteudo";
            this.lbl_conteudo.Size = new System.Drawing.Size(39, 14);
            this.lbl_conteudo.TabIndex = 6;
            this.lbl_conteudo.Text = "label1";
            // 
            // lbl_MascaraAtiva
            // 
            this.lbl_MascaraAtiva.AutoSize = true;
            this.lbl_MascaraAtiva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.lbl_MascaraAtiva.Name = "lbl_MascaraAtiva";
            this.lbl_MascaraAtiva.Size = new System.Drawing.Size(39, 14);
            this.lbl_MascaraAtiva.TabIndex = 7;
            this.lbl_MascaraAtiva.Text = "label2";
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(23, 153);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(82, 37);
            this.btn_data.TabIndex = 8;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_moeda
            // 
            this.btn_moeda.Location = new System.Drawing.Point(199, 110);
            this.btn_moeda.Name = "btn_moeda";
            this.btn_moeda.Size = new System.Drawing.Size(82, 37);
            this.btn_moeda.TabIndex = 9;
            this.btn_moeda.Text = "Moeda";
            this.btn_moeda.UseVisualStyleBackColor = true;
            this.btn_moeda.Click += new System.EventHandler(this.btn_moeda_Click);
            // 
            // btn_senha
            // 
            this.btn_senha.Location = new System.Drawing.Point(111, 153);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(82, 37);
            this.btn_senha.TabIndex = 10;
            this.btn_senha.Text = "Senha";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // btn_telefone
            // 
            this.btn_telefone.Location = new System.Drawing.Point(199, 153);
            this.btn_telefone.Name = "btn_telefone";
            this.btn_telefone.Size = new System.Drawing.Size(82, 37);
            this.btn_telefone.TabIndex = 11;
            this.btn_telefone.Text = "Telefone";
            this.btn_telefone.UseVisualStyleBackColor = true;
            this.btn_telefone.Click += new System.EventHandler(this.btn_telefone_Click);
            // 
            // btn_verConteudo
            // 
            this.btn_verConteudo.Location = new System.Drawing.Point(23, 196);
            this.btn_verConteudo.Name = "btn_verConteudo";
            this.btn_verConteudo.Size = new System.Drawing.Size(258, 37);
            this.btn_verConteudo.TabIndex = 12;
            this.btn_verConteudo.Text = "Ver Conteudo";
            this.btn_verConteudo.UseVisualStyleBackColor = true;
            this.btn_verConteudo.Click += new System.EventHandler(this.btn_verConteudo_Click);
            // 
            // Msk_Textbox
            // 
            this.Msk_Textbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Textbox.Location = new System.Drawing.Point(23, 31);
            this.Msk_Textbox.Name = "Msk_Textbox";
            this.Msk_Textbox.Size = new System.Drawing.Size(258, 20);
            this.Msk_Textbox.TabIndex = 13;
            // 
            // Frm_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.Msk_Textbox);
            this.Controls.Add(this.btn_verConteudo);
            this.Controls.Add(this.btn_telefone);
            this.Controls.Add(this.btn_senha);
            this.Controls.Add(this.btn_moeda);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.lbl_MascaraAtiva);
            this.Controls.Add(this.lbl_conteudo);
            this.Controls.Add(this.btn_Cep);
            this.Controls.Add(this.btn_hora);
            this.Name = "Frm_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo de Mascara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hora;
        private System.Windows.Forms.Button btn_Cep;
        private System.Windows.Forms.Label lbl_conteudo;
        private System.Windows.Forms.Label lbl_MascaraAtiva;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_moeda;
        private System.Windows.Forms.Button btn_senha;
        private System.Windows.Forms.Button btn_telefone;
        private System.Windows.Forms.Button btn_verConteudo;
        private System.Windows.Forms.MaskedTextBox Msk_Textbox;
    }
}