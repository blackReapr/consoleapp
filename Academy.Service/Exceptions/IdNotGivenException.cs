namespace Academy.Service.Exceptions;

internal class IdNotGivenException:Exception
{
    public IdNotGivenException() : base() { }
    public IdNotGivenException(string message): base(message) { }
    public IdNotGivenException(string message, Exception exception) : base(message, exception) { }
}
