using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MvvmLightExample.Common;
using MvvmLightExample.Model;
using MvvmLightExample.View;
using NLog;
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
		private INLogHelper _logger;
		public WelcomeViewModel(INLogHelper logger)
		{
			_logger = logger;
			Welcome = new WelcomeModel { Introduction = "Hello World" };
			_logger.Log(LogLevel.Error, "teset");
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
