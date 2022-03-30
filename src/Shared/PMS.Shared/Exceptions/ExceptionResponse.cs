using System.Net;

namespace PMS.Shared.Exceptions;

public sealed record ExceptionResponse(object Response, HttpStatusCode StatusCode);