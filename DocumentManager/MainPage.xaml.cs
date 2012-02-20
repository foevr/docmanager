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

namespace DocumentManager
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            var a = navigateControl1.AddItem("主页");
            navigateControl1.AddItem("合同");
            navigateControl1.AddItem("系统");
            navigateControl1.AddItem("注销");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            Dialogs.LoginDialog loginDialog = new Dialogs.LoginDialog();
            loginDialog.Closed += loginDialog_Closed;
            loginDialog.ShowDialog();
        }

        void loginDialog_Closed(object sender, EventArgs e)
        {
            var dialog = sender as Dialogs.LoginDialog;
            if (dialog != null && dialog.DialogResult == DevExpress.Xpf.Core.DialogResult.OK)
            {
                InitSystem();
            }
        }

        private void InitSystem()
        {
        }
    }
}
