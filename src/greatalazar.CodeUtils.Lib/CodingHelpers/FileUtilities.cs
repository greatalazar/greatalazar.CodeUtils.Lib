using System.Runtime.CompilerServices;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class FileUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string ReadAllText(this FileInfo ip) => File.ReadAllText(ip.FullName);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task<string> ReadAllTextAsync(this FileInfo ip) => await File.ReadAllTextAsync(ip.FullName);

	public static string[] ReadAllLines(this FileInfo ip) => File.ReadAllLines(ip.FullName);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task<string[]> ReadAllLinesAsync(this FileInfo ip) => await File.ReadAllLinesAsync(ip.FullName);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte[] ReadAllBytes(this FileInfo ip) => File.ReadAllBytes(ip.FullName);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task<byte[]> ReadAllBytesAsync(this FileInfo ip) => await File.ReadAllBytesAsync(ip.FullName);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteAllText(this FileInfo ip, string content) => File.WriteAllText(ip.FullName, content);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task WriteAllTextAsync(this FileInfo ip, string content) => await File.WriteAllTextAsync(ip.FullName, content);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteAllLines(this FileInfo ip, IEnumerable<string> content) => File.WriteAllLines(ip.FullName, content);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task WriteAllLinesAsync(this FileInfo ip, IEnumerable<string> content) => await File.WriteAllLinesAsync(ip.FullName, content);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteAllBytes(this FileInfo ip, byte[] content) => File.WriteAllBytes(ip.FullName, content);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static async Task WriteAllBytesAsync(this FileInfo ip, byte[] content) => await File.WriteAllBytesAsync(ip.FullName, content);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Stream OpenFileRead(this FileInfo ip) => File.OpenRead(ip.FullName);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Stream OpenFileWrite(this FileInfo ip) => File.OpenWrite(ip.FullName);
}