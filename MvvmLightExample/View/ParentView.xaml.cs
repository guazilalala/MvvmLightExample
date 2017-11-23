using GalaSoft.MvvmLight.Messaging;
using MvvmLightExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MvvmLightExample.View
{
	/// <summary>
	/// ParentView.xaml 的交互逻辑
	/// </summary>
	public partial class ParentView : Window
	{
		public ParentView()
		{
			InitializeComponent();

			Messenger.Default.Register<object>(this, "ShowChildView",ShowChildView);

			this.Unloaded += (s,e)=> { Messenger.Default.Unregister(this);};



			Messenger.Default.Register<OpenChildWindowMessage>(
				this,
				msg =>
				{
					var window = new ChildView();
					var model = window.DataContext as ChildViewModel;
					if (model != null)
					{
						model.MessageFromParent = msg.SomeText;
					}
					window.ShowDialog();
				});
		}

		public string Msg { get; set; }


		private void ShowChildView(object obj)
		{
			new ChildView().Show();
		}
	}

	public class OpenChildWindowMessage
	{
		public OpenChildWindowMessage(string someText)
		{
			SomeText = someText;
		}

		public string SomeText { get; set; }
	}
}
