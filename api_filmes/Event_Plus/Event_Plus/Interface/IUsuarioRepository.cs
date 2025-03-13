using Event_plus.Domains;

namespace Event_Plus.Interface
{
    public interface IUsuarioRepository
    {
        void Casdastrar(Usuarios novoUsuario);

        List<Usuarios> Listar();

        void Atualizar(Guid id Usuarios usuario);

        void Deletar (Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);

        Usuarios BuscarPorId(Guid id);
    }
}
