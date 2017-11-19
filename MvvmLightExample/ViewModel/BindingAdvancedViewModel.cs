using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MvvmLightExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.ViewModel
{
	public class BindingAdvancedViewModel : ViewModelBase
	{
		public BindingAdvancedViewModel()
		{
			InitCombbox();
			InitSingleRadio();
			InitCompRadio();
		}

		#region 属性

		#region 下拉框相关
		private ComplexInfoModel combbox;

		/// <summary>
		/// 下拉框选中信息
		/// </summary>
		public ComplexInfoModel Combbox
		{
			get => combbox;
			set { combbox = value; RaisePropertyChanged(() => Combbox); }
		}

		private List<ComplexInfoModel> combboxList;

		public List<ComplexInfoModel> CombboxList
		{
			get => combboxList;
			set
			{
				combboxList = value; RaisePropertyChanged(() => CombboxList);
			}
		}



		#endregion

		#region 单选框相关
		private string singleRadio;
		public string SingleRadio
		{
			get => singleRadio;
			set
			{
				singleRadio = value;
				RaisePropertyChanged(() => SingleRadio);
			}
		}


		private bool isSingleRadioCheck;
		public bool IsSingleRadioCheck
		{
			get => isSingleRadioCheck;
			set
			{
				isSingleRadioCheck = value;
				RaisePropertyChanged(() => IsSingleRadioCheck);
			}
		}


		#endregion

		#region 组合单选框相关
		private List<CompButtonModel> radioButtons;
		/// <summary>
		/// 列表
		/// </summary>
		public List<CompButtonModel> RadioButtons
		{
			get => radioButtons;
			set
			{
				radioButtons = value;
				RaisePropertyChanged(() => RadioButtons);
			}
		}

		private CompButtonModel radioButton;

		/// <summary>
		/// 选中值
		/// </summary>
		public CompButtonModel RadioButton
		{
			get => radioButton;
			set
			{
				radioButton = value;
				RaisePropertyChanged(() => RadioButton);
			}
		}



		#endregion
		#endregion

		#region 命令
		private RelayCommand radioCheckCommand;
		/// <summary>
		/// 单选框命令
		/// </summary>
		public RelayCommand RadioCheckCommand
		{
			get
			{
				if (radioCheckCommand == null)
					radioCheckCommand = new RelayCommand(()=>ExcuteRadioCommand());
				return radioCheckCommand;
			}
			set => radioCheckCommand = value; }

		private void ExcuteRadioCommand()
		{
			RadioButton = RadioButtons.Where(p => p.IsCheck).FirstOrDefault();
		}
		#endregion

		#region 辅助方法
		private void InitCombbox()
		{
			CombboxList = new List<ComplexInfoModel>()
			{
				new ComplexInfoModel(){Key="1",Text="苹果"},
				new ComplexInfoModel(){Key="2",Text="香蕉"},
				new ComplexInfoModel(){Key="3",Text="梨"},
				new ComplexInfoModel(){Key="4",Text="樱桃"}
			};
		}

		private void InitSingleRadio()
		{
			SingleRadio = "喜欢吃苹果？";
			IsSingleRadioCheck = false;
		}

		private void InitCompRadio()
		{
			RadioButtons = new List<CompButtonModel>
			{
				new CompButtonModel{Content="苹果",IsCheck=false},
				new CompButtonModel{Content="香蕉",IsCheck=false},
				new CompButtonModel{Content="梨",IsCheck=false},
				new CompButtonModel{Content="樱桃",IsCheck=false},
			};
		}
		#endregion
	}
}
