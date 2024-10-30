using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using microservcolegio.Secretaria.Services;
using Microsoft.AspNetCore.Mvc;

namespace microservcolegio.Secretaria.Controllers;
[ApiController]
[Route("/api/v1/[controller]")]
public class AlunoController : ControllerBase
{
    private IAlunoService _service;
    public AlunoController(IAlunoService service){
        this._service = service;
    }
    [HttpGet]
    public async Task<IResult> Get(){
        var listaAlunos = await this._service.GetAllAsync();
        return Results.Ok(listaAlunos);
    }
    [HttpPost]
    public async Task<IResult> Post(Aluno aluno){
        if(aluno == null){
            return Results.BadRequest();
        }

        var alunoSalvo = await _service.SaveAsync(aluno);

        return Results.Ok(alunoSalvo);
    }
}