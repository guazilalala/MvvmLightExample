using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.Model
{
	public class WelcomeModel : ObservableObject
	{
		private string introduction;

		public string Introduction
		{
			get => introduction;
			set { introduction = value; RaisePropertyChanged(() => Introduction); }
		}
	}
}
