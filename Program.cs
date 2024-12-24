Console.Clear();

try
{
    // var arr = new int[3] { 1, 2, 3 };
    // Console.WriteLine(arr[3]);

    //Salvar(null);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Você tentou acessar um indice inexistente");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.QuandoOcorreu);
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Oops! Algo deu errado");
}
finally
{
    Console.WriteLine("Chegou ao fim");
}

void Salvar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new MinhaException(DateTime.Now);
    }
}

public class MinhaException : Exception
{
    public DateTime QuandoOcorreu { get; set; }

    public MinhaException(DateTime date)
    {
        QuandoOcorreu = date;
    }
}