namespace Academy.Service.Exceptions;

internal class GroupAlreadyExistsException:Exception
{
    public GroupAlreadyExistsException() : base() { }
    public GroupAlreadyExistsException(string message):base(message) { } 
    public GroupAlreadyExistsException(string message, Exception exception):base(message, exception) { }
}
