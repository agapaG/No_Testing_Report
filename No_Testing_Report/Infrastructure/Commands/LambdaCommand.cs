using No_Testing_Report.Infrastructure.Commands.Base;
using System;

namespace No_Testing_Report.Infrastructure.Commands
{
	internal class LambdaCommand : BaseCommand
	{
		private readonly Action<object> Exequte;
		private readonly Func<object, bool> CanExequte;

		public LambdaCommand(Action<object> exequte, Func<object, bool> canExequte = null)
		{
			Exequte = exequte ?? throw new ArgumentNullException(nameof(exequte));
			CanExequte = canExequte;
		}

		public override bool CanExecute(object parameter) => CanExequte?.Invoke(parameter) ?? true;

		public override void Execute(object parameter)
		{
			if (!CanExecute(parameter))
				return;
			Exequte(parameter);
		}
	}
}
