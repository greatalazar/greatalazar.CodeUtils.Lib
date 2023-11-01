using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class LoopUtilities
{
	//TODO: add a way to break
	#region ForLoop

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop(int _x, Action<int> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop(int start_x, int _x, Action<int> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoopAsync(int _x, Func<int, Task> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			await callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoopAsync(int start_x, int _x, Func<int, Task> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			await callback(x);
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
	public static void ForLoop2(int start_x, int start_y, int _x, int _y, Action<int, int> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			for (int y = start_y; y < _y; y++)
			{
				callback(x, y);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop2Async(int _x, int _y, Func<int, int, Task> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			for (int y = 0; y < _y; y++)
			{
				await callback(x, y);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop2Async(int start_x, int start_y, int _x, int _y, Func<int, int, Task> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			for (int y = start_y; y < _y; y++)
			{
				await callback(x, y);
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
	public static void ForLoop3(int start_x, int start_y, int start_z, int _x, int _y, int _z, Action<int, int, int> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			for (int y = start_y; y < _y; y++)
			{
				for (int z = start_z; z < _z; z++)
				{
					callback(x, y, z);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop3Async(int _x, int _y, int _z, Func<int, int, int, Task> callback)
	{
		for (int x = 0; x < _x; x++)
		{
			for (int y = 0; y < _y; y++)
			{
				for (int z = 0; z < _z; z++)
				{
					await callback(x, y, z);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop3Async(int start_x, int start_y, int start_z, int _x, int _y, int _z, Func<int, int, int, Task> callback)
	{
		for (int x = start_x; x < _x; x++)
		{
			for (int y = start_y; y < _y; y++)
			{
				for (int z = start_z; z < _z; z++)
				{
					await callback(x, y, z);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoopReversed(int _x, Action<int> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoopReversedAsync(int _x, Func<int, Task> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			await callback(x);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop2Reversed(int _x, int _y, Action<int, int> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			for (int y = _y; y >= 0; y--)
			{
				callback(x, y);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop2ReversedAsync(int _x, int _y, Func<int, int, Task> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			for (int y = _y; y >= 0; y--)
			{
				await callback(x, y);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForLoop3Reversed(int _x, int _y, int _z, Action<int, int, int> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			for (int y = _y; y >= 0; y--)
			{
				for (int z = _z; z >= 0; z--)
				{
					callback(x, y, z);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task ForLoop3ReversedAsync(int _x, int _y, int _z, Func<int, int, int, Task> callback)
	{
		for (int x = _x; x >= 0; x--)
		{
			for (int y = _y; y >= 0; y--)
			{
				for (int z = _z; z >= 0; z--)
				{
					await callback(x, y, z);
				}
			}
		}
	}

	#endregion

	#region foreach for all

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ForEach<T>(this IEnumerable<T> ip, Action<T> callback)
	{
		foreach (T item in ip)
		{
			callback(item);
		}
	}

	#endregion
}
