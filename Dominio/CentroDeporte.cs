﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CentroDeporte
    {
        public int ID { get; set; }
        public Barrio Barrio { get; set; }
        public string Nombre { get; set; }

        public string Direccion { get; set; }
        public Usuario Dueño { get; set; }

        public TimeSpan TiempoMinCancelacion { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
