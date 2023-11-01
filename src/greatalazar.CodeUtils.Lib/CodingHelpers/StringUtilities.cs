using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class StringUtilities
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string Format(this string ip, params object[] arr) => string.Format(ip, arr);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsNullOrEmpty(this string ip) => string.IsNullOrEmpty(ip);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsNullOrWhiteSpace(this string ip) => string.IsNullOrWhiteSpace(ip);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static (string Key, string Value) ParseKeyValue(this string ip, string separator = "=")
	{
		if (!ip.Contains(separator)) throw new Exception("ip does not contains separator");

		var key = ip.Substring(0, ip.IndexOf("="));
		var val = ip.Substring(key.Length + 1, ip.Length - (key.Length + 1));

		return (key, val);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string ToKeyValueString(this KeyValuePair<string, string> ip, string seprator = "=")
	{
		return $"{ip.Key}{seprator}{ip.Value}";
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string RemoveEmojis(this string ip)
	{
		return Regex.Replace(ip, @"\p{Cs}", "");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string JoinStrings(this IEnumerable<string> ip, string separator = ", ")
	{
		return string.Join(separator, ip);
	}
}
