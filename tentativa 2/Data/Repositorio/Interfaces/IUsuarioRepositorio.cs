using tentativa_2.Models;

namespace tentativa_2.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public void CadastrarUsuario(Usuario usuario);

        public Usuario ValidarUsuario(Usuario usuario);



    }
}