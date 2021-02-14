
namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro ",
            "Avião ",
            "Navio ",
            "Ônibus ",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(10, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(211, 24);
            this.cb_transportes.TabIndex = 0;
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(239, 43);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(337, 23);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados ";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(407, 14);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(169, 25);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(239, 14);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(162, 25);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(337, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 25);
            this.textBox1.TabIndex = 5;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}