using EventPlus_.Domains;

namespace Event_Plus.Interface
{
    public interface IEventoRepository
    {
        void Cadastrar(Evento novoevento);

        List<Evento> Listar();

        void Atualiza(Guid id, Evento novoevento);

        void Deletar(Guid id);

        Evento BuscarPorId(Guid id);

        List<Evento> ListarProximosEventos(Guid id);

        List<Evento> ListarPorId(Guid id);
    }
}
