using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.Model
{
	public class ComplexInfoModel: ObservableObject
	{
		private string key;
		/// <summary>
		/// Key值
		/// </summary>
		public string Key
		{
			get { return key; }
			set { key = value; RaisePropertyChanged(() => Key); }
		}


		private string text;
		/// <summary>
		/// Text值
		/// </summary>
		public string Text
		{
			get { return text; }
			set { text = value; RaisePropertyChanged(() => Text); }
		}
	}
}
