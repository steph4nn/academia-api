using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IDbService _dbService;
        public UsuarioService(IDbService dbService)
    {
        _dbService = dbService;
    }
        public async Task<Usuario> GetUsuario()
        {
            var usuario = await _dbService.GetAsync<Usuario>("SELECT * FROM public.usuario where id_usuario=1",new { });
            return usuario;
        }
    }
}