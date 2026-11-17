using api2.Models;

namespace api2.Interfaces
{
    public interface ImarcaRepository
    {
        List<Marca> ListarTodos();

        // R - Read: busca um curso pelo Id (ou null se não achar).
        Marca? BuscarPorId(int id);

        // C - Create: cadastra um curso novo.
        void Cadastrar(Marca curso);
    }
}
