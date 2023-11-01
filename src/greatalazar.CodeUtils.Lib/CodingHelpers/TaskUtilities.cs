using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class TaskUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ConfiguredTaskAwaitable CAF(this Task task) => task.ConfigureAwait(false);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ConfiguredTaskAwaitable<T> CAF<T>(this Task<T> task) => task.ConfigureAwait(false);
}