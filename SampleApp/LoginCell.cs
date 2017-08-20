using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using SampleApp.Portable;

namespace SampleApp
{
    public partial class LoginCell : MvxTableViewCell
    {
        public LoginCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<LoginCell, LoginCellViewModel>();
                set.Bind(emailField).To(o => o.Username).For(i => i.Text);
                // set.Bind(emailField).To(p => p.LoggedInUser.UserName);
                //set.Bind().For(t => t.passwordField).To(p => p.Password);
                set.Bind(cancelBtn).To(io => io.Login);
                set.Bind(signInBtn.Tap()).For(c => c.Command).To(p => p.Login);
                set.Apply();

            });

        }

        internal void UpateCell()
        {
            ((FloatingTextField)emailField).IsUnderLined = true;

            var set = this.CreateBindingSet<LoginCell, UserViewModel>();
            set.Bind(emailField).To(p => p.UserName);
            //set.Bind().For(t => t.passwordField).To(p => p.Password);

            set.Bind(signInBtn).To(p => p.SignInCommand).Mode(MvvmCross.Binding.MvxBindingMode.TwoWay);
            set.Apply();

            ;

            //            signInBtn.TouchUpInside += (s, e) =>
            //            {
            //
            //            };

        }

        public String Email
        {
            get
            {
                return emailField.Text;
            }
            set
            {
                emailField.Text = value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}