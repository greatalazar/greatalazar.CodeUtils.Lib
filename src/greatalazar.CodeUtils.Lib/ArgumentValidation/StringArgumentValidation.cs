using greatalazar.CodeUtils.Lib.CodingHelpers;
using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class StringArgumentValidation
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<string> NotNullOrEmpty(this Argument<string> argument)
	{
		if (argument.ParamValue.IsNullOrEmpty())
			throw new ArgumentNullException(argument.ParamName);

		return argument;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<string> NotNullOrWhiteSpace(this Argument<string> argument)
	{
		if (argument.ParamValue.IsNullOrWhiteSpace())
			throw new ArgumentNullException(argument.ParamName);

		return argument;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<string> Contains(this Argument<string> argument, string value)
	{
		argument.NotNullOrEmpty();

		if (argument.ParamValue.Contains(value))
			throw new ArgumentException(argument.ParamName);

		return argument;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<string> MinimumLength(this Argument<string> argument, uint minLength)
	{
		argument.NotNullOrEmpty();

		if (argument.ParamValue.Length >= minLength)
			throw new ArgumentException(argument.ParamName);

		return argument;
	}
}
