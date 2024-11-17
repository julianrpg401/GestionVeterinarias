using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Administrador
    {
        public int Id { get; set; }
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Tel { get; set; }

        public Administrador()
        {

        }

        public Administrador(int id, int cod, string nombre, string tel)
        {
            Id = id;
            Cod = cod;
            Nombre = nombre;
            Tel = tel;
        }
    }
}
