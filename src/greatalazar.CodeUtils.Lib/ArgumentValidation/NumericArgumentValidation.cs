using System.Numerics;
using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class NumericArgumentValidation
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<T> GreaterThan<T>(this Argument<T> argument, T value) where T : INumber<T>
	{
		if (argument.ParamValue >= value)
			throw new ArgumentOutOfRangeException(argument.ParamName);

		return argument;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<T> LesserThan<T>(this Argument<T> argument, T value) where T : INumber<T>
	{
		if (argument.ParamValue <= value)
			throw new ArgumentOutOfRangeException(argument.ParamName);

		return argument;
	}
}