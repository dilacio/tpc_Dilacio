﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ciudad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }
    }
}
