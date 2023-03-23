namespace greatalazar.CodeUtils.Lib.ExceptionHandling;

//TODO: add a way to handle exception
public static class Handle
{
	public static ExceptionActionWrapper Try(Action action) => new ExceptionActionWrapper(action);

	public static ExceptionActionWrapper Catch<T>(this ExceptionActionWrapper exceptionActionWrapper, Action<Exception> action)
	{
		exceptionActionWrapper.AddExceptionHandler(typeof(T), action);
		return exceptionActionWrapper;
	}

	public static ExceptionActionWrapper Finally(this ExceptionActionWrapper exceptionActionWrapper, Action finallyAction)
	{
		exceptionActionWrapper.FinallyAction = finallyAction;
		return exceptionActionWrapper;
	}
}
