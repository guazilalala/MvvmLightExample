using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.ViewModel
{
	public class ChildViewModel : ViewModelBase
	{
		private string messageFromParent;
		public string MessageFromParent {
			get { return messageFromParent; }
			set {
				messageFromParent = value;
				RaisePropertyChanged(() => MessageFromParent);
			}
		}
		public ChildViewModel()
		{
		}

	}
}
