namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class ExceptionUtilities
{
	public static void Fail(string message) => throw new Exception(message);

	public static void Fail(string formattedMessage, params object[] objects) =>
		throw new Exception(formattedMessage.Format(objects));
}