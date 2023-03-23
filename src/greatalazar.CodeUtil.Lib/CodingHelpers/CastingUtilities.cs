using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class CastingUtilities
{
	#region casting helpers

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CastTo<T>(this object ip) => (T)ip;

	#endregion
}