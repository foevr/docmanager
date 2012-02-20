using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DocumentManager.Dialogs
{
    public partial class LoginDialog : Dialogs.DialogBase
    {
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private Common.InvalidateControl _invalidate;
        public LoginDialog()
        {
            InitializeComponent();
            _invalidate = new Common.InvalidateControl(txtUserName);
        }

        // 对话框关闭处理逻辑，若为点击确定，且身份验证不通过，则取消关闭并提示，否则关闭
        private void DialogBase_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult != DevExpress.Xpf.Core.DialogResult.OK)
                return;

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                _invalidate.StartAlarm();
                e.Cancel = true;
                return;
            }

            // 身份验证
            BusinessRuler.Login loginbl = new BusinessRuler.Login();
            var user = loginbl.ValidateAuth(txtUserName.Text.Trim(), txtPassword.Text);
            if (user != null)
            {
                (App.Current as App).CurrentUser = user;
                DialogResult = DevExpress.Xpf.Core.DialogResult.OK;
            }
            else
            {
                daUnauth.To = Left;
                daUnauth.From = Left - 10;
                sbUnauth.Begin();
                e.Cancel = true;
            }
        }
    }
}
