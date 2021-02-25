
namespace Componentes
{
    partial class F_LinkLabel
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
            System.Windows.Forms.Label tb_linkGerado;
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Link = new System.Windows.Forms.TextBox();
            this.ll_github = new System.Windows.Forms.LinkLabel();
            this.ll_Calc = new System.Windows.Forms.LinkLabel();
            this.ll_multipleLinks = new System.Windows.Forms.LinkLabel();
            this.btn_GetLink = new System.Windows.Forms.Button();
            this.ll_atual = new System.Windows.Forms.LinkLabel();
            this.tb_NameLink = new System.Windows.Forms.TextBox();
            this.btn_NameLink = new System.Windows.Forms.Button();
            this.lb_link = new System.Windows.Forms.Label();
            tb_linkGerado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_linkGerado
            // 
            tb_linkGerado.AutoSize = true;
            tb_linkGerado.Location = new System.Drawing.Point(12, 194);
            tb_linkGerado.Name = "tb_linkGerado";
            tb_linkGerado.Size = new System.Drawing.Size(86, 17);
            tb_linkGerado.TabIndex = 10;
            tb_linkGerado.Text = "Link Gerado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Link";
            // 
            // tb_Link
            // 
            this.tb_Link.Location = new System.Drawing.Point(13, 30);
            this.tb_Link.Name = "tb_Link";
            this.tb_Link.Size = new System.Drawing.Size(149, 22);
            this.tb_Link.TabIndex = 1;
            // 
            // ll_github
            // 
            this.ll_github.AutoSize = true;
            this.ll_github.Location = new System.Drawing.Point(213, 125);
            this.ll_github.Name = "ll_github";
            this.ll_github.Size = new System.Drawing.Size(52, 17);
            this.ll_github.TabIndex = 2;
            this.ll_github.TabStop = true;
            this.ll_github.Text = "GitHub";
            this.ll_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_github_LinkClicked);
            // 
            // ll_Calc
            // 
            this.ll_Calc.AutoSize = true;
            this.ll_Calc.Location = new System.Drawing.Point(10, 152);
            this.ll_Calc.Name = "ll_Calc";
            this.ll_Calc.Size = new System.Drawing.Size(117, 17);
            this.ll_Calc.TabIndex = 3;
            this.ll_Calc.TabStop = true;
            this.ll_Calc.Text = "Abrir Calculadora";
            this.ll_Calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Calc_LinkClicked);
            // 
            // ll_multipleLinks
            // 
            this.ll_multipleLinks.AutoSize = true;
            this.ll_multipleLinks.Location = new System.Drawing.Point(10, 125);
            this.ll_multipleLinks.Name = "ll_multipleLinks";
            this.ll_multipleLinks.Size = new System.Drawing.Size(174, 17);
            this.ll_multipleLinks.TabIndex = 4;
            this.ll_multipleLinks.TabStop = true;
            this.ll_multipleLinks.Text = "Google - Gmail - YouTube";
            this.ll_multipleLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multipleLinks_LinkClicked);
            // 
            // btn_GetLink
            // 
            this.btn_GetLink.Location = new System.Drawing.Point(180, 29);
            this.btn_GetLink.Name = "btn_GetLink";
            this.btn_GetLink.Size = new System.Drawing.Size(111, 23);
            this.btn_GetLink.TabIndex = 5;
            this.btn_GetLink.Text = "Gerar Link";
            this.btn_GetLink.UseVisualStyleBackColor = true;
            this.btn_GetLink.Click += new System.EventHandler(this.btn_GetLink_Click);
            // 
            // ll_atual
            // 
            this.ll_atual.AutoSize = true;
            this.ll_atual.Location = new System.Drawing.Point(10, 225);
            this.ll_atual.Name = "ll_atual";
            this.ll_atual.Size = new System.Drawing.Size(40, 17);
            this.ll_atual.TabIndex = 6;
            this.ll_atual.TabStop = true;
            this.ll_atual.Text = "Atual";
            this.ll_atual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_atual_LinkClicked);
            // 
            // tb_NameLink
            // 
            this.tb_NameLink.Location = new System.Drawing.Point(12, 59);
            this.tb_NameLink.Name = "tb_NameLink";
            this.tb_NameLink.Size = new System.Drawing.Size(150, 22);
            this.tb_NameLink.TabIndex = 7;
            // 
            // btn_NameLink
            // 
            this.btn_NameLink.Location = new System.Drawing.Point(180, 57);
            this.btn_NameLink.Name = "btn_NameLink";
            this.btn_NameLink.Size = new System.Drawing.Size(111, 23);
            this.btn_NameLink.TabIndex = 8;
            this.btn_NameLink.Text = "Nome Link";
            this.btn_NameLink.UseVisualStyleBackColor = true;
            this.btn_NameLink.Click += new System.EventHandler(this.btn_NameLink_Click);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(12, 99);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(41, 17);
            this.lb_link.TabIndex = 9;
            this.lb_link.Text = "Links";
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 314);
            this.Controls.Add(tb_linkGerado);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.btn_NameLink);
            this.Controls.Add(this.tb_NameLink);
            this.Controls.Add(this.ll_atual);
            this.Controls.Add(this.btn_GetLink);
            this.Controls.Add(this.ll_multipleLinks);
            this.Controls.Add(this.ll_Calc);
            this.Controls.Add(this.ll_github);
            this.Controls.Add(this.tb_Link);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Link;
        private System.Windows.Forms.LinkLabel ll_github;
        private System.Windows.Forms.LinkLabel ll_Calc;
        private System.Windows.Forms.LinkLabel ll_multipleLinks;
        private System.Windows.Forms.LinkLabel ll_atual;
        private System.Windows.Forms.TextBox tb_NameLink;
        private System.Windows.Forms.Button btn_NameLink;
        public System.Windows.Forms.Button btn_GetLink;
        private System.Windows.Forms.Label lb_link;
    }
}