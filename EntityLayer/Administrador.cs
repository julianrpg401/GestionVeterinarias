﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Administrador
    {
        public int AdminId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Tel { get; set; }
    }
}
