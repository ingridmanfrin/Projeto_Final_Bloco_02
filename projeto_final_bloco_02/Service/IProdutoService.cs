using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAll();
        Task<Produto?> GetById(long id);
        Task<IEnumerable<Produto>> GetByNome(string nome);
        Task<IEnumerable<Produto>> GetByPrecoIntervalo(decimal min, decimal max);
        Task<Produto?> Create(Produto produto);
        Task<Produto?> Update(Produto produto);
        Task Delete(Produto produto);
    }
}
