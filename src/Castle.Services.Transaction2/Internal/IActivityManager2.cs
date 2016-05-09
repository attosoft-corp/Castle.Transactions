﻿namespace Castle.Services.Transaction.Internal
{
	public interface IActivityManager2
	{
		bool TryGetCurrentActivity(out Activity2 activity);

		Activity2 EnsureActivityExists();
		
//		Activity2 StackNewActivity();

		void NotifyPop(Activity2 activity2);
		
	}
}