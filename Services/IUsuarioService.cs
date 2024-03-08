using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public interface IUsuarioService
    {
        Task<Usuario>GetUsuario();
    }
}