﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaDosAPIREST.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}