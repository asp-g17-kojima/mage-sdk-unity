﻿namespace Wizcorp.MageSDK.Utils
{
	public class Singleton<T>
		where T : class, new()
	{
		public static T Instance
		{
			get { return instance ?? (instance = new T()); }
		}

		// Instance functions
		private static T instance;

		// Hack which makes sure the _instance property is set during the T class constructor
		protected Singleton()
		{
			instance = (T)(object)this;
		}
	}
}