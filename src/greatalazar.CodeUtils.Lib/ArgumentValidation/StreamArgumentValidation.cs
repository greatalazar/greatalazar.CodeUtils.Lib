using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.ArgumentValidation;

public static class StreamArgumentValidation
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<Stream> CanRead(this Argument<Stream> argument)
	{
		argument.NotNull();

		if (argument.ParamValue.CanRead == true)
			throw new NotSupportedException(argument.ParamName);

		return argument;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Argument<Stream> CanWrite(this Argument<Stream> argument)
	{
		argument.NotNull();

		if (argument.ParamValue.CanWrite == true)
			throw new NotSupportedException(argument.ParamName);

		return argument;
	}
}