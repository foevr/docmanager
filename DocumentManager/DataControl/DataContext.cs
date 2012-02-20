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
using DocumentManager.Web;

namespace DocumentManager.DataControl
{
    public abstract class DataContext
    {
        private static volatile DOCMGDomainContext _context = null;
        private static object _objLock = new object();

        public static DOCMGDomainContext Context
        {
            get
            {
                if (_context == null)
                {
                    lock (_objLock)
                    {
                        if (_context == null)
                        {
                            _context = new DOCMGDomainContext();
                        }
                    }
                }
                return _context;
            }
        }
    }
}
