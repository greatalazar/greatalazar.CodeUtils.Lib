namespace greatalazar.CodeUtils.Lib.ExceptionHandling;

public class ExceptionActionWrapper
{
	#region props

	public Action Action { get; set; }

	//TODO: change dictionary to better performance key=>value collection
	//TODO: change list to better performance collection like hash map
	public Dictionary<Type, List<Action<Exception>>> ExceptionHandlers { get; set; } = new Dictionary<Type, List<Action<Exception>>>();
	public Action? FinallyAction { get; set; }

	#endregion

	#region ctor

	public ExceptionActionWrapper(Action action)
	{
		Action = action;
	}

	#endregion

	#region methods

	public void AddExceptionHandler(Type type, Action<Exception> action)
	{
		if (!ExceptionHandlers.Keys.Contains(type))
			ExceptionHandlers[type] = new List<Action<Exception>>();

		ExceptionHandlers[type].Add(action);
	}

	public void Invoke()
	{
		try
		{
			Action.Invoke();
		}
		catch (Exception ex)
		{
			ExceptionHandlers.ToList().ForEach(x =>
			{
				if (ex.GetType().Equals(x.Key))
				{
					x.Value.ForEach(x => x.Invoke(ex));
				}
				else
				{
					//if handled just re-throw the exception
					throw ex;
				}
			});
		}
		finally
		{
			FinallyAction?.Invoke();
		}
	}

	#endregion
}