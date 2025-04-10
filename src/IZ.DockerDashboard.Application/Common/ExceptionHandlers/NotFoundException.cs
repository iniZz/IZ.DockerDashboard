using System.Net;

namespace IZ.DockerDashboard.Application.Common.ExceptionHandlers;

public class NotFoundException : ServerException
{
    public NotFoundException(string message)
        : base(message, HttpStatusCode.NotFound)
    {
    }

    public NotFoundException(string name, object key)
        : base($"Entity \"{name}\" with key ({key}) was not found.", HttpStatusCode.NotFound)
    {
    }
}