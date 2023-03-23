using greatalazar.CodeUtils.Lib.ArgumentValidation;
using System.Threading.Tasks.Sources;

namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class FileSystemUtilities
{
    public static string AddSuffixToFileName(string fileName, string suffix)
	{
		return $"{Path.GetFileNameWithoutExtension(fileName)}{suffix}{Path.GetExtension(fileName)}";
	}

	public static string AddSuffixToFilePath(string filePath, string suffix)
	{
		return Path.Combine(Path.GetDirectoryName(filePath), AddSuffixToFileName(filePath, suffix));
	}

	public static string ChangeFileNameExtension(string fileName, string newExt)
	{
		return Path.GetFileNameWithoutExtension(fileName) + newExt;
	}

	public static string ChangeFilePathExtension(string filePath, string newExt)
	{
		Guard.Argument(filePath, nameof(filePath)).NotNullOrEmpty();

		return Path.Combine(Path.GetDirectoryName(filePath), ChangeFileNameExtension(filePath, newExt));
	}

	public static string ChangeFileDirectory(string filePath, string newDirectory)
	{
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