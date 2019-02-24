using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LearnSmarter.Mobile.Forms.UI.Effects
{
    public class CornerRadiusEffect : RoutingEffect
    {
        public CornerRadiusEffect() : base("LearnSmarter.Mobile.Forms.UI.Effects.CornerRadiusEffect")
        {
        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.CreateAttached
            ("CornerRadius", typeof(int), typeof(CornerRadiusEffect), 0, propertyChanged: OnCornerRadiusChanged);

        public static int GetCornerRadius(BindableObject view) =>
            (int)view.GetValue(CornerRadiusProperty);

        public static void SetCornerRadius(BindableObject view, int value) =>
            view.SetValue(CornerRadiusProperty, value);

        private static void OnCornerRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
                return;

            var radius = (int)newValue;
            var effect = view.Effects.OfType<CornerRadiusEffect>().FirstOrDefault();

            if (radius > 0 && effect == null)
            {
                view.Effects.Add(new CornerRadiusEffect());
            }

            if (radius == 0 && effect != null)
                view.Effects.Remove(effect);
        }
    }
}
