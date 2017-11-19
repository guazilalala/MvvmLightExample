using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MvvmLightExample.Model;
using MvvmLightExample.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.ViewModel
{
	public class WelcomeViewModel : ViewModelBase
	{
		private WelcomeModel welcome;
		public WelcomeViewModel()
		{
			Welcome = new WelcomeModel { Introduction = "Hello World" };
		}

		public WelcomeModel Welcome
		{
			get => welcome;
			set { welcome = value; RaisePropertyChanged(() => Welcome); }
		}

		#region 启动新窗口

		private RelayCommand showBothWayBindWindow;
		public RelayCommand ShowBothWayBindWindow
		{
			get
			{
				if (showBothWayBindWindow == null)
					showBothWayBindWindow = new RelayCommand(()=>ExcuteShowBothWayBindWindow());
				return showBothWayBindWindow;
			}
			set
			{
				showBothWayBindWindow = value;
			}
		}

		private RelayCommand showBindingAdvancedWindow;

		public RelayCommand ShowBindingAdvancedWindow
		{
			get
			{
				if (showBindingAdvancedWindow == null)
					showBindingAdvancedWindow = new RelayCommand(() => ExcuteShowBindingAdvancedWindow());
				return showBindingAdvancedWindow;
			}
			set
			{
				showBindingAdvancedWindow = value;
			}
		}


		private void ExcuteShowBothWayBindWindow()
		{
			BothWayBindView bothWayBind = new BothWayBindView();
			bothWayBind.Show();
		}

		private void ExcuteShowBindingAdvancedWindow()
		{
			BindingAdvancedView bindingAdvanced = new BindingAdvancedView();
			bindingAdvanced.Show();
		}

		#endregion


	}
}
