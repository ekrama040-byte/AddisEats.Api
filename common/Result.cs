namespace AddisEats.Api.Commons;

public record Error
(
    string Code,
    string Message,
    int Status
);
public class Result<T>
{
    public T? Value { get; set; }

    public Error? Error { get; set; }

    public bool IsSuccess => Error == null;

    public static Result<T> ok(T value)
            => new() { Value = value };
    public static Result<T> fail(string code, string message, int status)
            => new Result<T>
    {
        Error = new Error(code, message, status)
    };
}
    