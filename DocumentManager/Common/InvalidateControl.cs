using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DocumentManager.Common
{
    public class InvalidateControl : IDisposable
    {
        private Storyboard sb;
        private ColorAnimation ca;
        private InvalidateControl()
        {
        }

        private Control _control;

        public InvalidateControl(Control control)
        {
            _control = control;
            sb = new Storyboard();
            ca = new ColorAnimation();
            sb.Children.Add(ca);
            Storyboard.SetTarget(ca, control);
            Storyboard.SetTargetProperty(ca, new PropertyPath("(Background).(Color)"));
            ca.Duration = App.COLOR_ALARMDURATION;
            ca.To = App.GetResourceByKey<SolidColorBrush>("COLOR_PRIMARY").Color;
            ca.AutoReverse = true;
            ca.RepeatBehavior = new RepeatBehavior(2);
            sb.Completed += sb_Completed;

        }

        private Brush brush = null;
        public void StartAlarm()
        {
            brush = _control.Background;
            _control.Background = new SolidColorBrush();
            sb.Begin();
        }
        void sb_Completed(object sender, EventArgs e)
        {
            _control.Background = brush;
        }


        public void Dispose()
        {
            _control = null;
            brush = null;

            this.ca = null;
            this.sb = null;
        }
    }
}
