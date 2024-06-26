using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;
using AcademiaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcademiaAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;


    public AlunoController(IAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result =  await _alunoService.GetAlunosList();


        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAluno(int id)
    {
        var result =  await _alunoService.GetAluno(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddAluno([FromBody]Aluno aluno)
    {
        try
        {
            var result = await _alunoService.CreateAluno(aluno);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAluno([FromBody]Aluno aluno)
    {
        var result =  await _alunoService.UpdateAluno(aluno);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAluno(int id)
        {
            try {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result =  await _alunoService.DeleteAluno(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}