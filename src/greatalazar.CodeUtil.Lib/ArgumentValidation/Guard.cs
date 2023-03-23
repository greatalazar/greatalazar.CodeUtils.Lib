using System.Numerics;

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

public static class NumericArgumentValidation
{
	public static Argument<T> GreaterThan<T>(this Argument<T> argument, T value) where T : INumber<T>
	{
		if (argument.ParamValue >= value)
			throw new ArgumentOutOfRangeException(argument.ParamName);

		return argument;
	}

	public static Argument<T> LesserThan<T>(this Argument<T> argument, T value) where T : INumber<T>
	{
		if (argument.ParamValue <= value)
			throw new ArgumentOutOfRangeException(argument.ParamName);

		return argument;
	}
}