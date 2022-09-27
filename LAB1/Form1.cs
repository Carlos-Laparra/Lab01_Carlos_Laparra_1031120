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
using System.ComponentModel;

namespace LAB1
{
    public partial class Menu_Principal : Form
    {
        //variables que se usará en el form
        ArbolB<Usuario> ArbolBU = new ArbolB<Usuario>(5, Usuario.Compare_DPI); //declarar el arbol y el comparador que se usará
        List<Usuario> listaEncontrados = new List<Usuario>(); //lista que se desplegará 
        List<Carta> cartas = new List<Carta>(); //cartas que se cargaran en el form
        LZ78 c_d_78 = new LZ78(); //se declará el codificador para las empresas 
        Usuario usuario_c_c = new Usuario();
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
                if (OFD_CARGAR.ShowDialog() == DialogResult.OK)
                {                   
                    string route = OFD_CARGAR.FileName;
                    if (File.Exists(route))
                    {
                        string[] FileData = File.ReadAllLines(route);
                        foreach (var item in FileData)
                        {
                            if (!string.IsNullOrEmpty(item))
                            {
                                string[] lista = item.Split(";");
                                Usuario? user = JsonSerializer.Deserialize<Usuario>(lista[1]);
                                //valida que acción se debe realizar
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
                     // si el archivo se carga de manera correcta activa ciertos componenetes para continuar con el proceso
                    MessageBox.Show("Archivo CSV cargado con éxito");
                    lblBuscar.Visible = true;
                    txtBuscar.Visible = true;
                    btnBuscar.Visible = true;
                    btn_Cartas.Visible = true;
                }

            }
            catch {
                MessageBox.Show("Error al cargar el archivo CSV");
            }
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //variable que validará si buscar por nombre o buscar por dpi
            bool val_d_n = int.TryParse(txtBuscar.Text.Substring(0,1), out int num);
            if (txtBuscar.Text != ""){
                rtxtNombres.Clear();
                //valicaciones nada mas 
                if (val_d_n) {
                    //cambia el comparador para que al momento de mostrar muestres los posibles dpis que se estén buscando
                    ArbolBU.changeComparador(Usuario.Compare_DPI_byLength);
                    Usuario aux = new Usuario();
                    aux.dpi = txtBuscar.Text;
                    //busca en el arbol
                    ArbolBU.Recorridos(aux);
                    if (ArbolBU.pre.Count != 0)
                    {
                        //si se encontró algún valor se sigue con el proceso para desplegar en pantalla
                        listaEncontrados.Clear();
                        rtxtNombres.Visible = true;
                        cbElegirUser.Visible = true;
                        btnVerCompanies.Visible = true;
                        for (int i = 0; i < ArbolBU.pre.Count; i++)
                        {
                            Usuario auxE = new Usuario();
                            auxE = ArbolBU.pre[i];
                            rtxtNombres.Text += auxE.name + "    " + auxE.dpi + "    " + auxE.datebirth + "    " + auxE.address + "\r\n";
                            listaEncontrados.Add(auxE);
                        }
                        llenarComboBox();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario");
                    }
                }
                else {
                    //mismo procedimiento pero para buscar por nombre
                    ArbolBU.changeComparador(Usuario.Compare_Name);
                    Usuario aux = new Usuario();
                    aux.name = txtBuscar.Text;
                    ArbolBU.Recorridos(aux);
                    if (ArbolBU.pre.Count != 0)
                    {
                        listaEncontrados.Clear();
                        rtxtNombres.Visible = true;
                        cbElegirUser.Visible = true;
                        btnVerCompanies.Visible = true;
                        for (int i = 0; i < ArbolBU.pre.Count; i++)
                        {
                            Usuario auxE = new Usuario();
                            auxE = ArbolBU.pre[i];
                            rtxtNombres.Text += auxE.name + "    " + auxE.dpi + "    " + auxE.datebirth + "    " + auxE.address + "\r\n";
                            listaEncontrados.Add(auxE);
                        }
                        llenarComboBox();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún usuario para buscar");
            }
        }

        public void llenarComboBox()
        {
            //metodo para llenar el combo box con la información correspondiente
            cbElegirUser.Items.Clear();
            for (int i=0; i < listaEncontrados.Count; i++)
            {
                string auxCb = listaEncontrados[i].name + ", " + listaEncontrados[i].dpi;
                cbElegirUser.Items.Add(auxCb);
            }
        }

        private void btnVerCompanies_Click(object sender, EventArgs e)
        {
            rtxtNombres.Clear();
            int companieSelected = cbElegirUser.SelectedIndex;
            if (listaEncontrados[companieSelected].codificado == 0)
            {
                btn_Code_Decode.Text = "Codificar";
            }
            else
            {
                btn_Code_Decode.Text = "Decodificar";
            }
            string showRtxt = "";
            showRtxt = listaEncontrados[companieSelected].name + "\r\n" + listaEncontrados[companieSelected].dpi + "\r\n" + listaEncontrados[companieSelected].address + "\r\n" + listaEncontrados[companieSelected].datebirth + "\r\n\r\n" + "Compañías:" + "\r\n";
            string comapniesR = "";
            for (int i=0; i < listaEncontrados[companieSelected].companies.Count; i++)
            {
                comapniesR += listaEncontrados[companieSelected].companies[i] + "\r\n";
            }
            
            rtxtNombres.Text = showRtxt + comapniesR;
            btn_Code_Decode.Visible = true;

            if (listaEncontrados[companieSelected].carta.Count != 0)
            {
                btn_VerCartas.Visible = true;
                usuario_c_c = listaEncontrados[companieSelected];
            }
            else
            {
                btn_VerCartas.Visible = false;
            }


        }

        private void btn_Code_Decode_Click(object sender, EventArgs e)
        {
            int cpS = cbElegirUser.SelectedIndex;
            if (listaEncontrados[cpS].codificado == 0)
            {
                btn_Code_Decode.Text = "Decodificar";
                /*espacio espacio espacio espacio espacio*/
                List<string> bytesConverted = new List<string>();
                string rec = "";
                for (int i = 0; i < 4; i++)
                {
                    rec += rtxtNombres.Lines[i].ToString() + "\r\n";
                }
                for (int i = 0; i < listaEncontrados[cpS].companies.Count; i++)
                {
                    string content = listaEncontrados[cpS].companies[i] + listaEncontrados[cpS].dpi;
                    byte[] bytes = Encoding.ASCII.GetBytes(content);
                    bytesConverted.Add(Encoding.ASCII.GetString(c_d_78.Encode(bytes)));
                }
                Usuario userMod = new Usuario();
                userMod = listaEncontrados[cpS];
                userMod.companies = bytesConverted;
                userMod.codificado = 1;
                ArbolBU.patch(userMod);
                rtxtNombres.Clear();
                rtxtNombres.Text = rec + "\r\nCOMPAÑÍAS CODIFICADAS POR DPI";
            }
            else
            {
                btn_Code_Decode.Text = "Codificar";
                string recDec = "";
                List<string> bytesDeconverted = new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    recDec += rtxtNombres.Lines[i].ToString() + "\r\n";
                }
                for (int i = 0; i < listaEncontrados[cpS].companies.Count; i++)
                {
                    string filter = "";
                    string contentDec = listaEncontrados[cpS].companies[i];
                    byte[] bytesDec = Encoding.ASCII.GetBytes(contentDec);
                    filter = Encoding.ASCII.GetString(c_d_78.Decode(bytesDec, listaEncontrados[cpS].dpi));
                    bytesDeconverted.Add(c_d_78.separeDpi(filter, listaEncontrados[cpS].dpi));
                    //listaEncontrados[cpS].companies[i] = bytesConverted[i];
                }

                Usuario userModDec = new Usuario();
                userModDec = listaEncontrados[cpS];
                userModDec.companies = bytesDeconverted;
                userModDec.codificado = 0;
                ArbolBU.patch(userModDec);

                string companiesDec = "\r\nCompañias:\r\n";
                for (int i = 0; i < listaEncontrados[cpS].companies.Count; i++)
                {
                    companiesDec += listaEncontrados[cpS].companies[i] + "\r\n";
                }

                rtxtNombres.Clear();
                rtxtNombres.Text = recDec + companiesDec;
            }

            


        }

        private void btn_Cartas_Click(object sender, EventArgs e)
        {
            try
            {
                int cartas_cargadas = 0;
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowDialog();
                string selectedPath = dlg.SelectedPath;

                var files = System.IO.Directory.GetFiles(selectedPath, "*.*", System.IO.SearchOption.AllDirectories);


                foreach (string file in files)
                {
                    string[] primerAux = file.Split('\\');
                    string primerAuxVal = primerAux[primerAux.Length - 1];
                    string[] segundoAux = primerAuxVal.Split('-');
                    string segundoAuxVal = segundoAux[1];

                    ArbolBU.changeComparador(Usuario.Compare_DPI_byLength);
                    Usuario aux = new Usuario();
                    aux.dpi = segundoAuxVal;
                    //busca en el arbol
                    ArbolBU.Recorridos(aux);
                    string line = "";
                    string message = "";
                    if (ArbolBU.pre.Count != 0)
                    {
                        cartas_cargadas++;
                        //si se encontró algún valor se sigue con el proceso para desplegar en pantalla
                        Carta auxCarta = new Carta();
                        auxCarta.key = segundoAuxVal;
                        StreamReader sr = new StreamReader(file);
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            message += line;
                            line = sr.ReadLine();
                        }
                        auxCarta.mensaje = codificar_carta(message);
                        auxCarta.codificado = 0;

                        Usuario userMod = new Usuario();
                        userMod = ArbolBU.pre[0];
                        userMod.carta.Add(auxCarta);
                        ArbolBU.patch(userMod);
                    }
                    else
                    {
                        //MessageBox.Show("No se encontró ningún usuario con el DPI: " + segundoAux[1] + "\r\nCon número de carta: " + segundoAux[2]);
                    }
                }
                MessageBox.Show("Se han cargado " + cartas_cargadas + " cartas exitosamente");
            }
            catch
            {
                MessageBox.Show("Se produjo un error al cargar las cartas");
            }
        }

        public string codificar_carta(string message)
        {
            List<int> compressed = LZWCompresscs.Compress(message);
            string comp = string.Join(", ", compressed);

            string decomp = LZWCompresscs.Decompress(compressed);
            return decomp;
        }

        public void de_codificar_carta()
        {

        }

        private void btn_VerCartas_Click(object sender, EventArgs e)
        {
            F_Carta nnnn = new F_Carta();
            Singleton.Instance.ArbolBU = ArbolBU;
            Singleton.Instance.usuario_con_carta = usuario_c_c;
            nnnn.Show();
        }


        public void actualizar_valores()
        {
            ArbolBU = Singleton.Instance.ArbolBU;
        }
    }
}