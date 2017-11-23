/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MvvmLightExample.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MvvmLightExample.Common;
using MvvmLightExample.Model;


namespace MvvmLightExample.ViewModel
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// <para>
	/// See http://www.mvvmlight.net
	/// </para>
	/// </summary>
	public class ViewModelLocator
	{
		static ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			if (ViewModelBase.IsInDesignModeStatic)
			{
				SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
				SimpleIoc.Default.Register<INLogHelper, NLogHelper>();
			}
			else
			{
				SimpleIoc.Default.Register<IDataService, DataService>();
				SimpleIoc.Default.Register<INLogHelper, NLogHelper>();

			}

			SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<WelcomeViewModel>();
			SimpleIoc.Default.Register<BothWayBindViewlModel>();
			SimpleIoc.Default.Register<BindingAdvancedViewModel>();
			SimpleIoc.Default.Register<ParentViewModel>();
			SimpleIoc.Default.Register<ChildViewModel>();

		}

		/// <summary>
		/// Gets the Main property.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
			"CA1822:MarkMembersAsStatic",
			Justification = "This non-static member is needed for data binding purposes.")]
		public MainViewModel Main
		{
			get
			{
				return ServiceLocator.Current.GetInstance<MainViewModel>();
			}
		}

		public WelcomeViewModel Welcome
		{
			get
			{
				return ServiceLocator.Current.GetInstance<WelcomeViewModel>();
			}
		}

		public BothWayBindViewlModel BothWayBind
		{
			get
			{
				return ServiceLocator.Current.GetInstance<BothWayBindViewlModel>();
			}
		}

		public BindingAdvancedViewModel BindingAdvanced
		{
			get
			{
				return ServiceLocator.Current.GetInstance<BindingAdvancedViewModel>();
			}
		}

		public ParentViewModel Parent
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ParentViewModel>();
			}
		}

		public ChildViewModel Child
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ChildViewModel>();
			}
		}

		/// <summary>
		/// Cleans up all the resources.
		/// </summary>
		public static void Cleanup()
		{
		}
	}
}