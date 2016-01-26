using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlocNotasCurso.Model;

namespace BlocNotasCurso.Service
{
    public interface IServicioDatos
    {
        #region Usuario

        Task<Usuario> ValidarUsuario(Usuario us);
        Task<Usuario> AddUsuario(Usuario us);
        Task<Usuario> UpdateUsuario(Usuario us, string id);
        Task DeleteUsuario(string id);

        #endregion

        #region Bloc

        Task Addbloc(Bloc bloc);
        Task<List<Bloc>> GetBlocs(string usuario);
        Task DeleteBloc(Bloc bloc);
        Task UpdateBloc(Bloc bloc);
        #endregion
    }
}