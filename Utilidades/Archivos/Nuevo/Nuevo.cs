using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Utilidades.Archivos.Nuevo {

    public partial class Nuevo : Form {

        public static string       Recursos    = $@"{AppDomain.CurrentDomain.BaseDirectory}\Archivos\Nuevo\Archivos";
        public        List<string> Extensiones = new List<string>();

        public Nuevo() { InitializeComponent(); }

        private void BtnRuta_Click(object sender, EventArgs e) {
            var dialogo = new CommonOpenFileDialog { IsFolderPicker = true };

            if (dialogo.ShowDialog() != CommonFileDialogResult.Ok) {
                MessageBox.Show(@"Seleccione una ruta para guardar el nuevo archivo");

                return;

            }

            TbRuta.Text = dialogo.FileName;

        }

        private void Nuevo_Load(object sender, EventArgs e) {
            var carpetas = Directory.GetDirectories(Recursos);

            foreach (var nombre in carpetas.Select(carpeta => new DirectoryInfo(carpeta).Name)) LbTiposArchi.Items.Add(nombre);

        }

        private void LbTiposArchi_SelectedIndexChanged(object sender, EventArgs e) {
            LbFormatoArchi.Items.Clear();
            Extensiones.Clear();

            var formato  = LbTiposArchi.SelectedItem;
            var archivos = Directory.GetFiles($@"{Recursos}\{formato}\");

            foreach (var archivo in archivos) {
                var nombre = Path.GetFileNameWithoutExtension(archivo);
                Extensiones.Add(Path.GetExtension(archivo));
                LbFormatoArchi.Items.Add(nombre);
            }
        }

        private void BtnCrearArchi_Click(object sender, EventArgs e) {

            try {
                var ruta        = TbRuta.Text;
                var nombreArchi = TbNombreArchi.Text;

                var cond1 = string.IsNullOrEmpty(ruta);
                var cond2 = Path.IsPathRooted(ruta);

                var cond = cond1 || !cond2;

                if (cond) {
                    MessageBox.Show(@"Seleccione una ruta valida para guardar el nuevo archivo");

                    return;

                }

                if (LbFormatoArchi.SelectedIndex < 0) {
                    MessageBox.Show(@"Seleccione un formato de archivo");

                    return;
                }

                if (string.IsNullOrEmpty(nombreArchi)) {
                    MessageBox.Show(@"Seleccione un nombre para el archivo a crear");

                    return;
                }

                if (!Directory.Exists(ruta)) {
                    var crearDir = MessageBox.Show($@"Directorio no encontrado desea crear el directorio: '{ruta}'?", @"Atención!", MessageBoxButtons.YesNo);

                    if (crearDir == DialogResult.Yes) { Directory.CreateDirectory(ruta); }
                    else {
                        MessageBox.Show(@"Seleccione una ruta valida para guardar el nuevo archivo");

                        return;
                    }
                }

                var extension = Extensiones[LbFormatoArchi.SelectedIndex];
                var formato   = LbFormatoArchi.SelectedItem;
                var tipo      = LbTiposArchi.SelectedItem;

                var confirmacion = MessageBox.Show($@"Se creara el archivo: '{nombreArchi}{extension}' del tipo: '{formato}' en el directorio: '{ruta}' desea continuar?", @"Atención!", MessageBoxButtons.YesNo);

                var origen  = $@"{Recursos}\{tipo}\{formato}{extension}";
                var destino = $@"{Path.GetFullPath(ruta)}\{nombreArchi}{extension}";

                if (confirmacion != DialogResult.Yes) return;

                if (!File.Exists(destino)) { File.Copy(origen, destino, false); }
                else {
                    var reemplazo = MessageBox.Show($@"El archivo: '{destino}' ya existe desea reemplazarlo?", @"Atención!", MessageBoxButtons.YesNo);

                    if (reemplazo != DialogResult.Yes) return;

                    File.Copy(origen, destino, true);
                }

                MessageBox.Show(@"Archivo Creado Correctamente");

                TbRuta.Text = "";
                TbNombreArchi.Text = "";
                LbFormatoArchi.Items.Clear();
                LbTiposArchi.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void TbRuta_DoubleClick(object sender, EventArgs e) {
            TbRuta.SelectionStart  = 0;
            TbRuta.SelectionLength = TbRuta.Text.Length;
        }

        private void TbRuta_Enter(object sender, EventArgs e) {
            TbRuta.SelectionStart  = TbRuta.Text.Length;
            TbRuta.SelectionLength = 0;
        }

        private void TbRuta_MouseHover(object sender, EventArgs e) { Tooltip.Show(TbRuta.Text, TbRuta); }

    }

}