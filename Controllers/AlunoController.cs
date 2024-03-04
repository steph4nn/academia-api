using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;
using AcademiaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcademiaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;
    

    


    public AlunoController(IAlunoService employeeService)
    {
        _alunoService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result =  await _alunoService.GetAlunosList();


        return Ok(result);
    }

    [HttpGet("{cpf}")]
    public async Task<IActionResult> GetAluno(string cpf)
    {
        var result =  await _alunoService.GetAluno(cpf);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddAluno([FromBody]Aluno aluno)
    {
        var result =  await _alunoService.CreateAluno(aluno);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAluno([FromBody]Aluno aluno)
    {
        var result =  await _alunoService.UpdateAluno(aluno);

        return Ok(result);
    }

    [HttpDelete("{cpf}")]
    public async Task<IActionResult> DeleteAluno(string cpf)
    {
        var result =  await _alunoService.DeleteAluno(cpf);

        return Ok(result);
    }

    }
}