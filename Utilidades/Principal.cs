using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Utilidades.Archivos.Nuevo;

namespace Utilidades {

    public partial class Principal : Form {

        public Principal() { InitializeComponent(); }

        private void BtnNuevo_Click(object sender, EventArgs e) {

            var nuevo = new Nuevo();
            nuevo.ShowDialog();
        }

    }

}