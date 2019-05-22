namespace Utilidades.Archivos.Nuevo
{
    partial class Nuevo
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
            this.components = new System.ComponentModel.Container();
            this.BtnRuta = new System.Windows.Forms.Button();
            this.TbRuta = new System.Windows.Forms.TextBox();
            this.LblRuta = new System.Windows.Forms.Label();
            this.LbTiposArchi = new System.Windows.Forms.ListBox();
            this.LbFormatoArchi = new System.Windows.Forms.ListBox();
            this.TbNombreArchi = new System.Windows.Forms.TextBox();
            this.BtnCrearArchi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnRuta
            // 
            this.BtnRuta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRuta.Location = new System.Drawing.Point(349, 11);
            this.BtnRuta.Name = "BtnRuta";
            this.BtnRuta.Size = new System.Drawing.Size(26, 23);
            this.BtnRuta.TabIndex = 5;
            this.BtnRuta.Text = "...";
            this.BtnRuta.UseVisualStyleBackColor = true;
            this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
            // 
            // TbRuta
            // 
            this.TbRuta.AllowDrop = true;
            this.TbRuta.Location = new System.Drawing.Point(62, 12);
            this.TbRuta.Name = "TbRuta";
            this.TbRuta.Size = new System.Drawing.Size(281, 20);
            this.TbRuta.TabIndex = 3;
            this.TbRuta.DoubleClick += new System.EventHandler(this.TbRuta_DoubleClick);
            this.TbRuta.Enter += new System.EventHandler(this.TbRuta_Enter);
            this.TbRuta.MouseHover += new System.EventHandler(this.TbRuta_MouseHover);
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(21, 15);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(36, 13);
            this.LblRuta.TabIndex = 4;
            this.LblRuta.Text = "Ruta: ";
            // 
            // LbTiposArchi
            // 
            this.LbTiposArchi.FormattingEnabled = true;
            this.LbTiposArchi.Location = new System.Drawing.Point(62, 48);
            this.LbTiposArchi.Name = "LbTiposArchi";
            this.LbTiposArchi.Size = new System.Drawing.Size(120, 186);
            this.LbTiposArchi.TabIndex = 6;
            this.LbTiposArchi.SelectedIndexChanged += new System.EventHandler(this.LbTiposArchi_SelectedIndexChanged);
            // 
            // LbFormatoArchi
            // 
            this.LbFormatoArchi.FormattingEnabled = true;
            this.LbFormatoArchi.Location = new System.Drawing.Point(223, 48);
            this.LbFormatoArchi.Name = "LbFormatoArchi";
            this.LbFormatoArchi.Size = new System.Drawing.Size(120, 186);
            this.LbFormatoArchi.TabIndex = 7;
            // 
            // TbNombreArchi
            // 
            this.TbNombreArchi.Location = new System.Drawing.Point(77, 251);
            this.TbNombreArchi.Name = "TbNombreArchi";
            this.TbNombreArchi.Size = new System.Drawing.Size(193, 20);
            this.TbNombreArchi.TabIndex = 8;
            // 
            // BtnCrearArchi
            // 
            this.BtnCrearArchi.Location = new System.Drawing.Point(277, 248);
            this.BtnCrearArchi.Name = "BtnCrearArchi";
            this.BtnCrearArchi.Size = new System.Drawing.Size(98, 23);
            this.BtnCrearArchi.TabIndex = 9;
            this.BtnCrearArchi.Text = "Crear Archivo";
            this.BtnCrearArchi.UseVisualStyleBackColor = true;
            this.BtnCrearArchi.Click += new System.EventHandler(this.BtnCrearArchi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre: ";
            // 
            // Tooltip
            // 
            this.Tooltip.AutoPopDelay = 5000;
            this.Tooltip.InitialDelay = 50;
            this.Tooltip.ReshowDelay = 100;
            this.Tooltip.StripAmpersands = true;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCrearArchi);
            this.Controls.Add(this.TbNombreArchi);
            this.Controls.Add(this.LbFormatoArchi);
            this.Controls.Add(this.LbTiposArchi);
            this.Controls.Add(this.BtnRuta);
            this.Controls.Add(this.TbRuta);
            this.Controls.Add(this.LblRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRuta;
        private System.Windows.Forms.TextBox TbRuta;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.ListBox LbTiposArchi;
        private System.Windows.Forms.ListBox LbFormatoArchi;
        private System.Windows.Forms.TextBox TbNombreArchi;
        private System.Windows.Forms.Button BtnCrearArchi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}