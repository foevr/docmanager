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
using DevExpress.Xpf.LayoutControl;
using System.Diagnostics;

namespace DocumentManager.Navigate
{
    public partial class NavigateItem : LayoutItem
    {
        public event MouseButtonEventHandler Click;

        public string Text
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }

        private StateName currentState= StateName.Inactived;

        public NavigateItem()
        {
            InitializeComponent();
        }

        private void txt_MouseEnter(object sender, MouseEventArgs e)
        {
//            VisualStateManager.GoToState(txt, StateName.Actived.ToString(), true);
            if(currentState== StateName.Inactived)
                ChangeState(StateName.Actived);
        }

        private void txt_MouseLeave(object sender, MouseEventArgs e)
        {
            if (currentState == StateName.Actived)
                ChangeState(StateName.Inactived);
        }

        private Storyboard sb;
        private ColorAnimation ca;
        public void ChangeState(StateName state)
        {
            currentState = state;
            Color color;
            switch(state)
            {
                case StateName.Actived:
                    color = App.GetResourceByKey<SolidColorBrush>("COLOR_FONT_ACTIVE").Color;
                    break;
                case StateName.Inactived:
                    color = App.GetResourceByKey<SolidColorBrush>("COLOR_FONT_INACTIVE").Color;
                    break;
                case StateName.Selected:
                    color = App.GetResourceByKey<SolidColorBrush>("COLOR_PRIMARY").Color;
                    break;
                default :
                    color = App.GetResourceByKey<SolidColorBrush>("COLOR_FONT_ACTIVE").Color;
                    break;
            }
            if(ca==null)
            {
                ca = new ColorAnimation {Duration =App.COLOR_CHANGEDURATION};
            }
            ca.To = color;
            if(sb==null)
            {
                sb = new Storyboard();
                sb.Children.Add(ca);
                Storyboard.SetTarget(ca, txt);
                Storyboard.SetTargetProperty(ca, new PropertyPath("(Foreground).(Color)"));
            }
            sb.Begin();
        }

        public enum StateName
        {
            Actived,
            Inactived,
            Selected
        }

        private void txt_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Click != null)
                Click(this, e);
        }
    }
}
