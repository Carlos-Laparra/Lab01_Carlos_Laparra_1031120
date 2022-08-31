using ArbolB;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB1
{
    public partial class Menu_Principal : Form
    {
        ArbolB<Usuario> ArbolBU = new ArbolB<Usuario>(5, Usuario.Compare_DPI);
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try { 
                //se inicializa el arbol y se realiza proceso de leida del csv
                
                string route = @"C:\Users\celap\Desktop\input.csv";
                if (File.Exists(route))
                {
                    string[] FileData = File.ReadAllLines(route);
                    foreach (var item in FileData)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            string[] lista = item.Split(";");
                            Usuario? user = JsonSerializer.Deserialize<Usuario>(lista[1]);
                            if (lista[0] == "INSERT")
                            {
                                ArbolBU.Add(user);
                            }
                            else if (lista[0] == "DELETE")
                            {
                                ArbolBU.Delete(user);
                            }
                            else if (lista[0] == "PATCH")
                            {
                                ArbolBU.patch(user);
                            }
                        }
                    }
                }

                MessageBox.Show("Archivo CSV cargado con éxito");
                lblBuscar.Visible = true;
                txtBuscar.Visible = true;
                btnBuscar.Visible = true;

            }
            catch {
                MessageBox.Show("Error al cargar el archivo CSV");
            }
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != ""){
                rtxtNombres.Clear();
                ArbolBU.changeComparador(Usuario.Compare_Name);
                Usuario aux = new Usuario();
                aux.name = txtBuscar.Text;
                ArbolBU.Recorridos(aux);
                if (ArbolBU.pre.Count != 0)
                {
                    rtxtNombres.Visible = true;
                    for (int i =0; i < ArbolBU.pre.Count; i++)
                    {
                        Usuario auxE = new Usuario();
                        auxE = ArbolBU.pre[i];
                        rtxtNombres.Text += auxE.name + "    " + auxE.dpi + "    " + auxE.datebirth + "    " + auxE.address + "\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario");
                }

            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún usuario para buscar");
            }
        }
    }
}