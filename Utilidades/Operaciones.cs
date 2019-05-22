using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Utilidades {

    public partial class Operaciones : Form {

        public Operaciones() { InitializeComponent(); }

        private void BtnRuta_Click(object sender, EventArgs e) {

            var dialogo = new CommonOpenFileDialog { IsFolderPicker = true };

            if (dialogo.ShowDialog() == CommonFileDialogResult.Ok) { MessageBox.Show("You selected: " + dialogo.FileName); }

        }

    }

}