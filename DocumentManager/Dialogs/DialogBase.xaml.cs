using DevExpress.Xpf.Core;

namespace DocumentManager.Dialogs
{
    public partial class DialogBase : DXDialog
    {
        public DialogBase()
        {
            this.Loaded += DXDialog_Loaded;
            this.Opened += DXDialog_Opened;
            this.Closed += new System.EventHandler(DialogBase_Closed); ;
            InitializeComponent();
        }


        private new void Show()
        {
            base.Show();
        }

        public override void ShowDialog()
        {
            base.ShowDialog();
        }

        private void DXDialog_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void DXDialog_Opened(object sender, System.EventArgs e)
        {
            (App.Current.RootVisual as MainPage).sbRootRadius5.Begin();
        }

        private void DialogBase_Closed(object sender, System.EventArgs e)
        {
            (App.Current.RootVisual as MainPage).sbRootRadius0.Begin();
        }
    }
}
