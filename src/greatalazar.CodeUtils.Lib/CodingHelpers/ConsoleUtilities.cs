using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class ConsoleUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string? PromptInputLine(this string str)
	{
		Console.Write(str);
		return Console.ReadLine();
	}
}