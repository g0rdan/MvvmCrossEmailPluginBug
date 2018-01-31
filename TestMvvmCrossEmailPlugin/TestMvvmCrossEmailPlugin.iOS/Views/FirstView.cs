using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TestMvvmCrossEmailPlugin.Core.ViewModels;

namespace TestMvvmCrossEmailPlugin.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(EmailButton).To(vm => vm.SendEmailCommand);
            set.Apply();
        }
    }
}
