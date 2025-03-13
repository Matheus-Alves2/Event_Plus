using Event_plus.Domains;
using EventPlus_.Domains;

namespace Event_Plus.Interface
{
    public interface ITipoUsuarioRepository
    {
        void Casdastrar(TipoUsuario tipoEvento);

        List<TipoEvento> Listar();

        void Atualizar(Guid id TipoUsuario  tipoUsuario);

        void Deletar(Guid id);

        TipoEvento BuscarPorId(Guid id);
    }
}
