using GalaSoft.MvvmLight;
using MvvmLightExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.ViewModel
{
	public class BothWayBindViewlModel : ViewModelBase
	{

		public BothWayBindViewlModel()
		{
			UserInfo = new UserInfoModel();
		}

		#region 属性
		private UserInfoModel userInfo;

		public UserInfoModel UserInfo
		{
			get => userInfo;
			set { userInfo = value; RaisePropertyChanged(() => UserInfo); }
		}
		#endregion

		#region 命令

		#endregion

	}
}
