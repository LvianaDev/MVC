using LV.Buniness.Core.Data;
using LV.Buniness.Models.Produtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LV.Buniness.Models.Fornecedores
{
    interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores(Guid id);
        Task<Produto> ObterProdutosFornecedor(Guid id);
    }
}
