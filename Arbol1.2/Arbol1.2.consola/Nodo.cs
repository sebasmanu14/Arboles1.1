﻿using System.Collections.Generic;

namespace Arbol1._2.consola
{
    class Nodo
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}
