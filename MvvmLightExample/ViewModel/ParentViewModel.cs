using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MvvmLightExample.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.ViewModel
{
	public class ParentViewModel : ViewModelBase
	{
		public ParentViewModel()
		{
			OpenChildCommand = new RelayCommand(() => MessengerInstance.Send(new OpenChildWindowMessage("text")));
		}


		public RelayCommand OpenChildCommand { get; }

		private void ShowChildView()
		{
		}
	}
}
