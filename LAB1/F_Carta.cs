using ArbolB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class F_Carta : Form
    {
        Usuario usuario = new Usuario();
        public F_Carta()
        {
            InitializeComponent();
        }

        private void btn_Code_Decode_Click(object sender, EventArgs e)
        {
            int ind = cbCartas.SelectedIndex;
            if (usuario.carta[ind].codificado == 0)
            {
                btn_Code_Decode.Text = "Decodificar";
                List<int> compressed = LZWCompresscs.Compress(usuario.carta[ind].mensaje);
                Console.WriteLine(string.Join(", ", compressed));
                MessageBox.Show("Carta codificada correctamente");
                usuario.carta[ind].mensaje = "";
                usuario.carta[ind].comp = compressed;
                usuario.carta[ind].codificado = 1;
            }
            else
            {
                btn_Code_Decode.Text = "Decodificar";
                string decompressed = LZWCompresscs.Decompress(usuario.carta[ind].comp);
                MessageBox.Show("Carta decodificada correctamente");
                usuario.carta[ind].mensaje = decompressed;
                usuario.carta[ind].comp.Clear();
                usuario.carta[ind].codificado = 0;
            }
        }

        private void F_Carta_Load(object sender, EventArgs e)
        {
            usuario = Singleton.Instance.usuario_con_carta;
            string info = "Nombre: " + Singleton.Instance.usuario_con_carta.name;
            string info2 = "DPI: " + Singleton.Instance.usuario_con_carta.dpi;
            string info3 = "Dirección: " + Singleton.Instance.usuario_con_carta.address;
            rtxtInfo.Text = info + "\r\n" + info2 + "\r\n" + info3;

            cbCartas.Items.Clear();
            for (int i = 0; i < usuario.carta.Count; i++)
            {
                string auxCb = "Carta " + (i + 1);
                cbCartas.Items.Add(auxCb);
            }
        }

        private void btn_MostrarCarta_Click(object sender, EventArgs e)
        {
            rtxtCarta.Clear();
            int index = cbCartas.SelectedIndex;
            if (usuario.carta[index].codificado == 0)
            {
                rtxtCarta.Text = usuario.carta[index].mensaje;
            }
            else
            {
                MessageBox.Show("Esta carta ha sido codificada y no se puede mostrar");
                rtxtCarta.Text = "CODIFICADO";
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Usuario userMod = new Usuario();
            userMod = usuario;
            Singleton.Instance.ArbolBU.patch(userMod);
            this.Close();
            Menu_Principal cc = new Menu_Principal();
            cc.actualizar_valores();
        }
    }
}
