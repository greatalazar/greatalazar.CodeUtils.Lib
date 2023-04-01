using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class LoopUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop(int _x, Action<int> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop2(int _x, int _y, Action<int, int> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			for (int y = 0; y < _y; y++)
			{
				callback(x, y);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop3(int _x, int _y, int _z, Action<int, int, int> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			for (int y = 0; y < _y; y++)
			{
				for (int z = 0; z < _z; z++)
				{
					callback(x, y, z);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void DoWhileLoop(Action callback, Func<bool> whileConditionResolve)
	{
		do
		{
			callback();
		}
		while (whileConditionResolve());
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WhileLoop(Func<bool> whileConditionResolve, Action callback)
	{
		while (whileConditionResolve())
		{
			callback();
		}
	}
}
