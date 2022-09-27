using ArbolB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public ArbolB<Usuario> ArbolBU = new ArbolB<Usuario>(5, Usuario.Compare_DPI); //declarar el arbol y el comparador que se usará
        public List<Usuario> listaEncontrados = new List<Usuario>(); //lista que se desplegará 
        public List<Carta> cartas = new List<Carta>(); //cartas que se cargaran en el form
        LZ78 c_d_78 = new LZ78(); //se declará el codificador para las empresas 
        public Usuario usuario_con_carta = new Usuario();

        private Singleton()
        {
            

        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
