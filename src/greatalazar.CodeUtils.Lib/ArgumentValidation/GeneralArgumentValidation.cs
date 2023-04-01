namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class GeneralArgumentValidation
{
	public static Argument<T> NotNull<T>(this Argument<T> argument) where T : class
	{
		if (argument.ParamValue == null)
			throw new ArgumentNullException(argument.ParamName);

		return argument;
	}
}
