using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using Microsoft.EntityFrameworkCore;

namespace microservcolegio.Secretaria.Services;
public class AlunoService : IAlunoService
{
    private RepositoryDbContext _dbContext;
    public AlunoService(RepositoryDbContext dbContext){
        this._dbContext = dbContext;
    }
    
    public async Task<List<Aluno>> GetAllAsync()
    {
        var listaAlunos = await _dbContext.Alunos.ToListAsync();
        return listaAlunos;
    }

    public async Task<Aluno> SaveAsync(Aluno aluno)
    {
        await this._dbContext.AddAsync(aluno);
        await this._dbContext.SaveChangesAsync();
        
        return aluno;
    }
}
