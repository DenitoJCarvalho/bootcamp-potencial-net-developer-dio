using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
  public class Curso
  {
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    /// <summary>
    /// No tipo temos um tipo de retorno, Nome do método normalmente indicando a ação que irá resultar, parâmetros, também conhecido como argumentos, formando assim uma assinatura de método.
    /// </summary>
    /// <param name="aluno"></param>
    #region Adicionar aluno 
    public void AdicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }
    #endregion

    /// <summary>
    /// Retorna a quantidade de alunos que estão matriculados.
    /// </summary>
    /// <returns></returns>
    #region Obter Quantidade de Alunos Matriculados
    public int ObterQuantidadeDeAlunosMatriculados()
    {
      int quantidade = Alunos.Count;
      return quantidade;
    }
    #endregion

    /// <summary>
    /// Faz a remoção de um aluno matriculado
    /// </summary>
    /// <param name="aluno"></param>
    #region Remover aluno
    public void RemoverAluno(Pessoa aluno)
    {
      Alunos.Remove(aluno);
    }
    #endregion

    /// <summary>
    /// Lista todos os alunos matriculados
    /// </summary>
    #region Listar Aluno
    public void ListarAlunos()
    {
      Console.WriteLine($"Alunos do curso de {Nome}");
      foreach (Pessoa aluno in Alunos)
      {
        Console.WriteLine(aluno.NomeCompleto);
      }
    }
    #endregion
  }
}