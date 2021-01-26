
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lista_veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(188, 21);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(92, 31);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(12, 30);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 22);
            this.tb_veiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um Veículo";
            // 
            // tb_lista_veiculos
            // 
            this.tb_lista_veiculos.Location = new System.Drawing.Point(12, 58);
            this.tb_lista_veiculos.Multiline = true;
            this.tb_lista_veiculos.Name = "tb_lista_veiculos";
            this.tb_lista_veiculos.Size = new System.Drawing.Size(268, 264);
            this.tb_lista_veiculos.TabIndex = 3;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 362);
            this.Controls.Add(this.tb_lista_veiculos);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lista_veiculos;
    }
}

