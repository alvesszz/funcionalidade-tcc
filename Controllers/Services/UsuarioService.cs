using FuncionalidadeTCC.Models;
using System;
using System.Collections.Generic; 
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadeTCC.Controllers.Services
{
    public class UsuarioService
    { /*: Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "";
        private string _token;
        public UsuarioService(string token)
        {
            _request = new Request();
            _token = token;
        }


        public async Task<ObservableCollection<Usuario>> GetPersonagensAsync()
        {
            string urlComplementar = string.Format("{0}", "/GetAll");
            ObservableCollection<Usuario> listaUsuarios = await
      _request.GetAsync<ObservableCollection<Usuario>>(apiUrlBase + urlComplementar, _token);
            return listaUsuarios;
        }
        public async Task<Usuario> GetUsuarioAsync(int usuarioId)
        {
            string urlComplementar = string.Format("/{0}", usuarioId);
            var usuarios = await _request.GetAsync<Usuario>(apiUrlBase + urlComplementar, _token);
            return usuarios;
        }
        public async Task<int> PostUsuarioAsync(Usuario p)
        {
            return await _request.PostReturnIntTokenAsync(apiUrlBase, p, _token);
        }
        public async Task<int> PutUsuarioAsync(Usuario p)
        {
            var result = await _request.PutAsync(apiUrlBase, p, _token);
            return result;
        }
        public async Task<int> DeleteUsuarioAsync(int usuarioId)
        {
            string urlComplementar = string.Format("/{0}", usuarioId);
            var result = await _request.DeleteAsync(apiUrlBase + urlComplementar, _token);
            return result;
        }*/

    }
}
  
    
