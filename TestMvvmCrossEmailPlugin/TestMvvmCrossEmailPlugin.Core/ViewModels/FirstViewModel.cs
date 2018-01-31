using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Email;

namespace TestMvvmCrossEmailPlugin.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        readonly IMvxComposeEmailTaskEx _emailService;

        public IMvxCommand SendEmailCommand => new MvxCommand(SendEmail);

        public FirstViewModel(IMvxComposeEmailTaskEx emailService)
        {
            _emailService = emailService;
        }

        public void SendEmail()
        {
            var body =
                "<html><body>" +
                "<h1><font color=red>Hello MvvmCross!</font></h1>" +
                "<p>Lorem ipsum dolor sit amet consectetuer adipiscing elit, sed" +
                " diem nonummy nibh euismod tincidunt ut lacreet dolore magna " +
                "aliguam erat volutpat.Ut wisis enim ad minim veniam, quis nostrud " +
                "exerci tution ullamcorper suscipit lobortis nisl ut aliquip ex ea " +
                "commodoconsequat.</p>" +
                "</body></html>";

            _emailService.ComposeEmail(new string[] { "test@test.com" }, subject: "Is there a bug?", body: body, isHtml: true);
        }
    }
}
