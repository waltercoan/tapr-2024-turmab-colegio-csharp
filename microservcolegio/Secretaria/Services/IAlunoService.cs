using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;

namespace microservcolegio.Secretaria.Services;

public interface IAlunoService
{
    Task<List<Aluno>> GetAllAsync();
    Task<Aluno> SaveAsync(Aluno aluno);
    Task<Aluno> UpdateAsync(String id, Aluno aluno);
    Task<Aluno> DeleteAsync(String id);
}
