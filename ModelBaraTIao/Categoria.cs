using System;
using System.Collections.Generic;
using System.Text;

namespace ModelBaraTIao
{
    class Categoria
    {

        public int Id { get; set; }

        public int Descricao { get; set; }

        public int? IdCategoriaPai { get; set; }

        public Categoria CategoriaPai { get; set; }
    }
}
