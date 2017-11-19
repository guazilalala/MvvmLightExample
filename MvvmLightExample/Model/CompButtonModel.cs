using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.Model
{
	public class CompButtonModel : ObservableObject
	{
		public CompButtonModel()
		{

		}

		private string content;

		public string Content
		{
			get => content;
			set
			{
				content = value; RaisePropertyChanged(() => Content);
			}
		}

		private bool isCheck;

		public bool IsCheck
		{
			get => isCheck;
			set
			{
				isCheck = value;
				RaisePropertyChanged(()=> IsCheck);
			}
		}

	}

}

