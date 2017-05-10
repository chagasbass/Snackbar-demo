﻿using System;
namespace Snackbar
{
	public interface IUserNotificationService
	{
		void Snack(string message, int duration = 2000, string actionText = null, Action<object> action = null);
	}
}
