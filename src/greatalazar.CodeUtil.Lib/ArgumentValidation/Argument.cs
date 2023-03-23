namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public readonly struct Argument<T>
{
	public T ParamValue { get; init; }
	public string ParamName { get; init; }
}