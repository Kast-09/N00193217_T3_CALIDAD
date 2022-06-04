using SANCHEZ_T3.WEB.DB;

namespace SANCHEZ_T3.WEB.Repositorios
{
    public interface IUsuarioRepositorio
    {

    }
    public class UsuarioRepositorio
    {
        private DbEntities _DbEntities;

        public UsuarioRepositorio(DbEntities dbEntities)
        {
            _DbEntities = dbEntities;
        }
    }
}
