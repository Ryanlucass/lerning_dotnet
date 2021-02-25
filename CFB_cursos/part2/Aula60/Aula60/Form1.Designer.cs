
namespace Aula60
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.lb_link = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ok.Location = new System.Drawing.Point(300, 177);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(215, 56);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_link.Location = new System.Drawing.Point(298, 236);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(217, 25);
            this.lb_link.TabIndex = 1;
            this.lb_link.Text = "Youtube.com/cfbcursos";
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(303, 149);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(212, 22);
            this.tb_text.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 489);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.btn_ok);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "F_Principal";
            this.Text = "Convert Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.TextBox tb_text;
    }
}

