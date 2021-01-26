
namespace Componentes
{
    partial class f_principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_listaVc = new System.Windows.Forms.TextBox();
            this.tb_veículo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um veículo";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(207, 29);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 31);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // tb_listaVc
            // 
            this.tb_listaVc.Location = new System.Drawing.Point(21, 66);
            this.tb_listaVc.Multiline = true;
            this.tb_listaVc.Name = "tb_listaVc";
            this.tb_listaVc.Size = new System.Drawing.Size(280, 261);
            this.tb_listaVc.TabIndex = 2;
            this.tb_listaVc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_veículo
            // 
            this.tb_veículo.Location = new System.Drawing.Point(21, 33);
            this.tb_veículo.Name = "tb_veículo";
            this.tb_veículo.Size = new System.Drawing.Size(170, 22);
            this.tb_veículo.TabIndex = 3;
            // 
            // f_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 358);
            this.Controls.Add(this.tb_veículo);
            this.Controls.Add(this.tb_listaVc);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "f_principal";
            this.Text = "Componentes ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_listaVc;
        private System.Windows.Forms.TextBox tb_veículo;
    }
}

