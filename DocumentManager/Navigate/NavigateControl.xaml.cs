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

namespace DocumentManager.Navigate
{
    public partial class NavigateControl : UserControl
    {
        private List<string> _items = new List<string>();
        public NavigateControl()
        {
            InitializeComponent();
            lgMain.Children.Clear();
        }
        #region control the navigate items
        public NavigateItem AddItem(string item)
        {
            _items.Add(item);
            var nav= InitNavigateItem(item);
            lgMain.Children.Add(nav);
            return null;
        }

        public NavigateItem AddItemAt(string item, int index)
        {
            if (index > _items.Count)
                return null;
            _items.Insert(index, item);
            var nav= InitNavigateItem(item);
            lgMain.Children.Insert(index, nav);
            return null;
        }

        public void RemoveItemAt(int index)
        {
            if (index >= _items.Count)
                return;
            _items.RemoveAt(index);
            lgMain.Children.RemoveAt(index);
        }

        public void RemoveItem(string item)
        {
            if (!_items.Contains(item))
                return;
            int index = _items.IndexOf(item);
            _items.RemoveAt(index);
            lgMain.Children.RemoveAt(index);
        }

        public NavigateItem GetItemAt(int index)
        {
            if (lgMain.Children.Count <= index)
                return null;
            return lgMain.Children[index] as NavigateItem;
        }

        public string GetItemIndexAt(int index)
        {
            if (_items.Count <= index)
                return null;
            return _items[index];
        }

        #endregion

        private NavigateItem InitNavigateItem(string text)
        {
            var item = new NavigateItem {Text = text};
            return item;
        }
    }
}
