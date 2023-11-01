namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class Guard
{
	public static Argument<T> Argument<T>(T paramVal, string paramName)
	{
		return new Argument<T>()
		{
			ParamValue = paramVal,
			ParamName = paramName
		};
	}
}