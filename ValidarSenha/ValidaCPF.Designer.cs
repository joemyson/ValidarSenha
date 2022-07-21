
namespace ValidarSenha
{
    partial class ValidaCPF
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
            this.Msk_textbox = new System.Windows.Forms.MaskedTextBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_textbox
            // 
            this.Msk_textbox.Location = new System.Drawing.Point(12, 45);
            this.Msk_textbox.Mask = "000,000,000-00";
            this.Msk_textbox.Name = "Msk_textbox";
            this.Msk_textbox.Size = new System.Drawing.Size(218, 20);
            this.Msk_textbox.TabIndex = 0;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(12, 90);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(65, 22);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "label1";
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(245, 42);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(111, 23);
            this.btn_limpa.TabIndex = 2;
            this.btn_limpa.Text = "Limpa";
            this.btn_limpa.UseVisualStyleBackColor = true;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_valida
            // 
            this.btn_valida.Location = new System.Drawing.Point(245, 71);
            this.btn_valida.Name = "btn_valida";
            this.btn_valida.Size = new System.Drawing.Size(111, 23);
            this.btn_valida.TabIndex = 3;
            this.btn_valida.Text = "Validar";
            this.btn_valida.UseVisualStyleBackColor = true;
            this.btn_valida.Click += new System.EventHandler(this.btn_valida_Click);
            // 
            // ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btn_valida);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.Msk_textbox);
            this.Name = "ValidaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_textbox;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_valida;
    }
}