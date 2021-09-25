using LV.Buniness.Core.Models;
using LV.Buniness.Models.Produtos;
using System.Collections.Generic;

namespace LV.Buniness.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public ICollection<Produto> Produtos { get; set; }

    }
}
