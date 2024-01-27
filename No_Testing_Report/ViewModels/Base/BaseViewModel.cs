﻿
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace No_Testing_Report.ViewModels.Base
{
	internal class BaseViewModel
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null)
		{
			//Генерация события
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}

		protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? PropertyName = null)
		{
			if (Equals(field, value))
				return false;
			field = value;
			OnPropertyChanged(PropertyName);
			return true;
		}

	}
}
