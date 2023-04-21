using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Snake
{
    public class FocusBindableProperty : VisualElement
    {
        public static readonly BindableProperty FocusProperty = BindableProperty.Create(
            "Focus",
            typeof(bool),
            typeof(FocusBindableProperty), 
            default,
            propertyChanged: OnPropertyChanged);

        public static bool GetFocus(VisualElement target) => (bool)target.GetValue(FocusProperty);

        public static void SetFocus(VisualElement target, bool value) => target.SetValue(FocusProperty, value);

        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var target = bindable as Entry;
            if (target != null && (bool)newValue)
            {
                if (target.IsLoaded)
                {
                    target.Focus();
                }
                else
                {
                    target.Loaded += Target_Loaded;
                }
            }
        }

        private static void Target_Loaded(object sender, EventArgs e)
        {
            var target = sender as Entry;
            target.Focus();
            target.Loaded -= Target_Loaded;
        }
    }
}
