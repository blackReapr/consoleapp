namespace Academy.Service.Exceptions;

internal class GroupDoesNotExistException:Exception
{
    public GroupDoesNotExistException() : base() { }
    public GroupDoesNotExistException(string message) : base(message) { }
    public GroupDoesNotExistException(string message, Exception exception) : base(message, exception) { }
}
