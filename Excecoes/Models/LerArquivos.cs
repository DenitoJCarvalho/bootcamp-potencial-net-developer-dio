using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes.Models
{
  public class LerArquivos
  {
    /// <summary>
    /// Essa variável pega o arquivo que irá ser lido.
    /// </summary>
    string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

    #region Apresentar Arquivo sem parâmetro
    /// <summary>
    /// Essa função pega o arquivo passado como string e apresenta todas a linhas desse arquivo.
    /// </summary>
    public void ApresentarArquivo()
    {
      foreach (var linha in linhas)
      {
        Console.WriteLine(linha);
      }
    }
    #endregion

    #region Apresentar Arquivo com parâmetro pathFile
    /// <summary>
    /// Podemos passar um caminho como string para que ele pegue o arquivo e apresente todas as linhas desse arquivo.
    /// </summary>
    /// <param name="pathFile"></param>
    public void ApresentarArquivo(string pathFile)
    {
      // try - tenta executar as instruções que passo dentro dele.
      try
      {
        linhas = File.ReadAllLines(pathFile);

        foreach (var linha in linhas)
        {
          Console.WriteLine(linha);
        }
      }
      catch (FileNotFoundException ex)
      {
        //Catch - lança a exceção para que possa averiguar o erro que está ocorrendo.
        Console.WriteLine($"Caminho de arquivo informado não encontrado. {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Não foi possível encontrar o arquivo. Contate o administratador. {ex.Message}");
      }
      finally
      {
        //Finaliza as intruções do bloco
        Console.WriteLine($"Finalizando processo");
      }
    }
    #endregion

    #region apresentar Arquivo com parâmetro pathFile e extension

    /// <summary>
    /// Podemos passar um caminho como string e uma extensão com string para que ele pegue o arquivo mais a extensão e apresente todas as linhas desse arquivo.
    /// </summary>
    /// <param name="pathFile"></param>
    /// <param name="extension"></param>
    /// <exception cref="Exception"></exception>
    public void ApresentarArquivo(string pathFile, string extension)
    {
      string path = $"{pathFile}.{extension}";

      linhas = File.ReadAllLines(path);

      if (pathFile != null && extension != null)
      {
        foreach (var linha in linhas)
        {
          Console.WriteLine(linha);
        }
      }
      else
      {
        throw new Exception("Não foi possível ler o arquivo informado");
      }
    }
    #endregion
  }
}