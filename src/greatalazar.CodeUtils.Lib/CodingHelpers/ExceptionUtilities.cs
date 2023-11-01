using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class ExceptionUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fail(string message) => throw new Exception(message);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Fail(string formattedMessage, params object[] objects) =>
		throw new Exception(formattedMessage.Format(objects));
}