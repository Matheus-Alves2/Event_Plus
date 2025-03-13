using Event_plus.Domains;

namespace Event_Plus.Interface
{
    public interface IPresencasEventosRepository
    {
        public interface IUsuarioRepository
        {
            void Atualizar(Guid id, PresencasEventos presencasEventos);
            void Deletar(Guid id);
            List<PresencasEventos> Listar();
            PresencasEventos BuscarPorId(Guid id);
            List<PresencasEventos> ListarMinhasPresencas(Guid id);
            void Inscrever(PresencasEventos inscreverPresenca);

        }
    }
}
