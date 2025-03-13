using Event_Plus.Context;
using Event_Plus.Interface;

namespace Event_Plus.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly Evento_Context _context;
        public TipoEventoRepository(Evento_Context contexto)
        {
            _context = contexto;
        }
        public void Atualizar(Guid id, TiposEventos tiposeventos)
        {
            try
            {
                EventPlus_.Domains.TipoEvento? tipoEvento = _context.TipoEvento.Find(id);
                TiposEventos tipoeventobuscado = tipoEvento;
;               if(tipoeventobuscado != null)
                {
                    tipoeventobuscado.Nome = tipoeventobuscado.Nome;
                }
                _context.SavedChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TiposEventos BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEventos tipoEventos)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposEventos> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
