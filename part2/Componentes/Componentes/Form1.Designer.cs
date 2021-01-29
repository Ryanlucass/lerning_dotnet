
namespace Componentes
{
    partial class F_Principal
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
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Label();
            this.tb_lista_veiculos = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(188, 26);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(92, 31);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(12, 30);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 22);
            this.tb_veiculo.TabIndex = 1;
            // tb_lista_veiculos
            // 
            this.tb_lista_veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lista_veiculos.Location = new System.Drawing.Point(12, 58);
            this.tb_lista_veiculos.Multiline = true;
            this.tb_lista_veiculos.Name = "tb_lista_veiculos";
            this.tb_lista_veiculos.Size = new System.Drawing.Size(268, 264);
            this.tb_lista_veiculos.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 328);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(268, 31);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_mostra
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(12, 366);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(268, 32);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar Todos os Veículos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 414);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_lista_veiculos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label btn_limpar;
        private System.Windows.Forms.TextBox tb_lista_veiculos;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_mostrar;
    }
}

