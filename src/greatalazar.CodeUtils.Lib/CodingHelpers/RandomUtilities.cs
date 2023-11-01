namespace greatalazar.CodeUtils.Lib.CodingHelpers;

public static class RandomUtilities
{
	public static float NextSingle(this Random random, float minValue, float maxValue) =>
		random.NextSingle() * (maxValue - minValue) + minValue;

	public static double NextDouble(this Random random, double minValue, double maxValue) =>
		random.NextDouble() * (maxValue - minValue) + minValue;
}