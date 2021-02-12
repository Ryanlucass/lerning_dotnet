
namespace Componentes
{
    partial class F_CheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CheckedListBox));
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrar_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar_lista = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            resources.GetString("clb_transportes.Items"),
            resources.GetString("clb_transportes.Items1"),
            resources.GetString("clb_transportes.Items2"),
            resources.GetString("clb_transportes.Items3")});
            resources.ApplyResources(this.clb_transportes, "clb_transportes");
            this.clb_transportes.Name = "clb_transportes";
            // 
            // btn_mostrar_selecionados
            // 
            resources.ApplyResources(this.btn_mostrar_selecionados, "btn_mostrar_selecionados");
            this.btn_mostrar_selecionados.Name = "btn_mostrar_selecionados";
            this.btn_mostrar_selecionados.Click += new System.EventHandler(this.btn_mostrar_selecionados_Click);
            // 
            // btn_limpar
            // 
            resources.ApplyResources(this.btn_limpar, "btn_limpar");
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar_lista
            // 
            resources.ApplyResources(this.btn_resetar_lista, "btn_resetar_lista");
            this.btn_resetar_lista.Name = "btn_resetar_lista";
            this.btn_resetar_lista.UseVisualStyleBackColor = true;
            this.btn_resetar_lista.Click += new System.EventHandler(this.btn_resetar_lista_Click);
            // 
            // tb_NovoTransporte
            // 
            resources.ApplyResources(this.tb_NovoTransporte, "tb_NovoTransporte");
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            // 
            // btn_addNovoTransporte
            // 
            resources.ApplyResources(this.btn_addNovoTransporte, "btn_addNovoTransporte");
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // F_CheckedListBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_resetar_lista);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrar_selecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CheckedListBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_CheckedListBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrar_selecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar_lista;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Button btn_addNovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}