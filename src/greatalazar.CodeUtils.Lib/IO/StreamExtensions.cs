using greatalazar.CodeUtils.Lib.ArgumentValidation;
using System.Buffers;

namespace greatalazar.CodeUtils.Lib.IO;

public static class StreamExtensions
{
	public const int DefaultBufferSize = 1024 * 1024 * 8;

	public static async Task CopyToAsync(this Stream source,
		Stream destination,
		int bufferSize = DefaultBufferSize,
		bool resetPositionTo0 = true,
		CancellationToken token = default,
		Func<long, Task>? HandleProgress = default)
	{
		Guard.Argument(source, nameof(source)).CanRead();
		Guard.Argument(destination, nameof(destination)).CanWrite();

		Guard.Argument(bufferSize, nameof(bufferSize))
			.LesserThan(int.MaxValue);

		if (token.IsCancellationRequested)
			return;

		if (resetPositionTo0)
			source.Position = destination.Position = 0;

		var buffer = ArrayPool<byte>.Shared.Rent(bufferSize);

		try
		{
			int bytesRead;
			while ((bytesRead = await source.ReadAsync(new Memory<byte>(buffer), token)) != 0)
			{
				await destination.WriteAsync(buffer, 0, bytesRead, token);

				if (HandleProgress != null)
					_ = HandleProgress(source.Position);
			}
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buffer);
		}
	}
}
