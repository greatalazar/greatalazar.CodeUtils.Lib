namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class StreamArgumentValidation
{
	public static Argument<Stream> CanRead(this Argument<Stream> argument)
	{
		argument.NotNull();

		if(argument.ParamValue.CanRead == true)
			throw new NotSupportedException(argument.ParamName);

		return argument;
	}

	public static Argument<Stream> CanWrite(this Argument<Stream> argument)
	{
		argument.NotNull();

		if (argument.ParamValue.CanWrite == true)
			throw new NotSupportedException(argument.ParamName);

		return argument;
	}
}