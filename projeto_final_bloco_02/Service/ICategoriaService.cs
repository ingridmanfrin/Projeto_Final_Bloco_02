using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Service
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAll();
        Task<Categoria?> GetById(long id);
        Task<IEnumerable<Categoria>> GetByTipo(string tipo);
        Task<Categoria?> Create(Categoria categoria);
        Task<Categoria?> Update(Categoria categoria);
        Task Delete(Categoria categoria);
    }
}
