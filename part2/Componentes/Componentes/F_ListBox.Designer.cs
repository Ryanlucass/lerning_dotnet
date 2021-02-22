
namespace Componentes
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.l_carro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.ItemHeight = 16;
            this.lb_carros.Location = new System.Drawing.Point(12, 25);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(234, 180);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(275, 45);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(156, 22);
            this.tb_carro.TabIndex = 1;
            // 
            // l_carro
            // 
            this.l_carro.AutoSize = true;
            this.l_carro.Location = new System.Drawing.Point(275, 22);
            this.l_carro.Name = "l_carro";
            this.l_carro.Size = new System.Drawing.Size(43, 17);
            this.l_carro.TabIndex = 2;
            this.l_carro.Text = "Carro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 417);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_carro);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.MaximizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label l_carro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}