using LV.Buniness.Core.Data;
using System;
using System.Threading.Tasks;

namespace LV.Buniness.Models.Fornecedores
{
    public interface IEnderecoRepository: IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
