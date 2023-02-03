using System;

namespace bf2srvWebAdmin.Common.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException(string message) : base(message)
    {
    }
}