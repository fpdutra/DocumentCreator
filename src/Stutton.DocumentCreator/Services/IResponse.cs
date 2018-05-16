﻿namespace Stutton.DocumentCreator.Services
{
    public interface IResponse
    {
        bool Success { get; }
        ResponseCode Code { get; }
        string Message { get; }
    }

    public interface IResponse<out T>
    {
        bool Success { get; }
        ResponseCode Code { get; }
        string Message { get; }
        T Value { get; }
    }
}
