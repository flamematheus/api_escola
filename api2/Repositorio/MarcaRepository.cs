using api2.Contexts;
using api2.Interfaces;
using api2.Models;

namespace api2.Repositorio
{
    public class MarcaRepository : ImarcaRepository
    {
        private readonly ConcessionariaContext _context;

        // Injeção de dependência: a API entrega o EscolaContext pronto.
        public MarcaRepository(ConcessionariaContext context)
        {
            _context = context;
        }
        public Marca? BuscarPorId(int id)
        {
            return _context.Marca.Find(id);   // Find() -> busca pela chave primária (ou null)
        }

        public void Cadastrar(Marca marca)
        {
            _context.Marca.Add(marca);   // coloca na fila (marca para inserir)
            _context.SaveChanges();      // grava no banco
        }

        public List<Marca> ListarTodos()
        {
            return _context.Marca.ToList();   // ToList() -> busca todos os registros
        }
    }
}
