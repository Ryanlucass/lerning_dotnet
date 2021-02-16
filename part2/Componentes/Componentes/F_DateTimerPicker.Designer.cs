
namespace Componentes
{
    partial class F_DateTimerPicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obter_data = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.btn_setar_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(342, 22);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obter_data
            // 
            this.btn_obter_data.Location = new System.Drawing.Point(399, 13);
            this.btn_obter_data.Name = "btn_obter_data";
            this.btn_obter_data.Size = new System.Drawing.Size(125, 23);
            this.btn_obter_data.TabIndex = 1;
            this.btn_obter_data.Text = "Obter Data";
            this.btn_obter_data.UseVisualStyleBackColor = true;
            this.btn_obter_data.Click += new System.EventHandler(this.btn_obter_data_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(13, 41);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(341, 22);
            this.tb_data.TabIndex = 2;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(255, 69);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(99, 22);
            this.tb_ano.TabIndex = 3;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(13, 69);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(99, 22);
            this.tb_dia.TabIndex = 4;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(129, 69);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(111, 22);
            this.tb_mes.TabIndex = 5;
            // 
            // btn_setar_data
            // 
            this.btn_setar_data.Location = new System.Drawing.Point(399, 69);
            this.btn_setar_data.Name = "btn_setar_data";
            this.btn_setar_data.Size = new System.Drawing.Size(125, 23);
            this.btn_setar_data.TabIndex = 9;
            this.btn_setar_data.Text = "Setar Data";
            this.btn_setar_data.UseVisualStyleBackColor = true;
            // 
            // F_DateTimerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 138);
            this.Controls.Add(this.btn_setar_data);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obter_data);
            this.Controls.Add(this.dtp_data);
            this.MinimizeBox = false;
            this.Name = "F_DateTimerPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DateTimerPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_obter_data;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Button btn_setar_data;
    }
}