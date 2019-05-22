namespace Utilidades
{
    partial class Operaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbRuta = new System.Windows.Forms.TextBox();
            this.LblRuta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRuta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbRuta
            // 
            this.TbRuta.Location = new System.Drawing.Point(58, 17);
            this.TbRuta.Name = "TbRuta";
            this.TbRuta.Size = new System.Drawing.Size(281, 20);
            this.TbRuta.TabIndex = 0;
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(17, 20);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(36, 13);
            this.LblRuta.TabIndex = 1;
            this.LblRuta.Text = "Ruta: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRuta);
            this.panel1.Controls.Add(this.TbRuta);
            this.panel1.Controls.Add(this.LblRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // BtnRuta
            // 
            this.BtnRuta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRuta.Location = new System.Drawing.Point(345, 16);
            this.BtnRuta.Name = "BtnRuta";
            this.BtnRuta.Size = new System.Drawing.Size(26, 23);
            this.BtnRuta.TabIndex = 2;
            this.BtnRuta.Text = "...";
            this.BtnRuta.UseVisualStyleBackColor = true;
            this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Operaciones";
            this.Text = "Utilidades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbRuta;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRuta;
    }
}

