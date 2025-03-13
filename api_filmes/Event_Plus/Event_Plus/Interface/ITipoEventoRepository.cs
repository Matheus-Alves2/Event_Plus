using EventPlus_.Domains;

namespace Event_Plus.Interface
{
    public interface ITipoEventoRepository
    {
        void Cadastrar(TiposEventos tipoEventos);
        List<TiposEventos> Listar();
        void Atualizar(Guid id, TiposEventos tiposeventos);
        void Deletar(Guid id);
        TiposEventos BuscarPorId(Guid id);
    }

}
