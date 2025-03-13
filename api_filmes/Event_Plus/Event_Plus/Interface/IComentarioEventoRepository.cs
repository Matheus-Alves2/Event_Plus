using Event_plus.Domains;

namespace Event_Plus.Interface
{
    public interface IComentarioEventoRepository
    {
        void Cadastrar(ComentariosEventos comentarioseventos);

        List<ComentariosEventos> Listar();

        void Deletar(Guid id);

        ComentariosEventos BuscarPorId(Guid idUsuarios, Guid IdEventos);
    }
}
