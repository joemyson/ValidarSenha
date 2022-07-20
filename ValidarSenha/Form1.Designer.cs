
namespace ValidarSenha
{
    partial class Frm_ValidaSenha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.btn_verSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(12, 45);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(218, 20);
            this.Txt_Senha.TabIndex = 0;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(65, 22);
            this.lbl_Resultado.TabIndex = 1;
            this.lbl_Resultado.Text = "label1";
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(245, 42);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(111, 23);
            this.Btn_reset.TabIndex = 2;
            this.Btn_reset.Text = "Limpa";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_verSenha
            // 
            this.btn_verSenha.Location = new System.Drawing.Point(245, 71);
            this.btn_verSenha.Name = "btn_verSenha";
            this.btn_verSenha.Size = new System.Drawing.Size(111, 23);
            this.btn_verSenha.TabIndex = 3;
            this.btn_verSenha.Text = "Ver Senha";
            this.btn_verSenha.UseVisualStyleBackColor = true;
            this.btn_verSenha.Click += new System.EventHandler(this.btn_verSenha_Click);
            // 
            // Frm_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btn_verSenha);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Name = "Frm_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Button btn_verSenha;
    }
}

