using greatalazar.CodeUtils.Lib.ArgumentValidation;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class FileSystemUtilities
{
	//TODO: check if argument validation is actually necessary, to avoid double checking
	public static string AddSuffixToFileName(string fileName, string suffix)
	{
		Guard.Argument(fileName, nameof(fileName)).NotNullOrEmpty();
		Guard.Argument(suffix, nameof(suffix)).NotNullOrEmpty();

		return $"{Path.GetFileNameWithoutExtension(fileName)}{suffix}{Path.GetExtension(fileName)}";
	}

	public static string AddSuffixToFilePath(string filePath, string suffix)
	{
		Guard.Argument(filePath, nameof(filePath)).NotNullOrEmpty();
		Guard.Argument(suffix, nameof(suffix)).NotNullOrEmpty();

		return Path.Combine(Path.GetDirectoryName(filePath), AddSuffixToFileName(filePath, suffix));
	}

	public static string ChangeFileNameExtension(string fileName, string newExt)
	{
		Guard.Argument(fileName, nameof(fileName)).NotNullOrEmpty();
		Guard.Argument(newExt, nameof(newExt)).NotNullOrEmpty();

		return Path.GetFileNameWithoutExtension(fileName) + newExt;
	}

	public static string ChangeFilePathExtension(string filePath, string newExt)
	{
		Guard.Argument(filePath, nameof(filePath)).NotNullOrEmpty();
		Guard.Argument(newExt, nameof(newExt)).NotNullOrEmpty();

		return Path.Combine(Path.GetDirectoryName(filePath), ChangeFileNameExtension(filePath, newExt));
	}

	public static string ChangeFileDirectory(string filePath, string newDirectory)
	{
		Guard.Argument(filePath, nameof(filePath)).NotNullOrEmpty();
		Guard.Argument(newDirectory, nameof(newDirectory)).NotNullOrEmpty();

		return Path.Combine(newDirectory, Path.GetFileName(filePath));
	}

	public static FileInfo ToFileInfo(this string filePath)
	{
		return new FileInfo(filePath);
	}

	public static DirectoryInfo ToDirectoryInfo(this string filePath)
	{
		return new DirectoryInfo(filePath);
	}
}