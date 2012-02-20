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
using System.Linq;
using DocumentManager.Web;

namespace DocumentManager.BusinessRuler
{
    public class Login
    {
        public TBUSER ValidateAuth(string userName, string password)
        {
            var user = DataControl.DataContext.Context.TBUSERs.FirstOrDefault(p => p.USERNAME.Equals(userName, StringComparison.OrdinalIgnoreCase));
            if (user != null && Common.MD5Convertor.Convert(password) == user.USERPWD)
            {
                return user;
            }
            return null;
        }
    }
}
