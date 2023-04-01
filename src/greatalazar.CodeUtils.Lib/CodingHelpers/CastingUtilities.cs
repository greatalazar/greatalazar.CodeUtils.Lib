using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class CastingUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CastTo<T>(this object ip) => (T)ip;
}