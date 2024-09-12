namespace Products.Application.Exceptions;

public class ValidationAppException : Exception
{
    /// <summary>
    /// IReadOnlyDictionary
    /// </summary>
    /// <value></value>
    public IReadOnlyDictionary<string, string[]> Errors { get; }

    /// <summary>
    /// ValidationAppException
    /// </summary>
    /// <param name="errors"></param>
    public ValidationAppException(IReadOnlyDictionary<string, string[]> errors)
        : base("Ocurrió un error con una o más validaciones.")
    {
        Errors = errors;
    }
}
