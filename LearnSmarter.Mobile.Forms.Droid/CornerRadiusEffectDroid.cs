using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LearnSmarter.Mobile.Core.Droid;
using LearnSmarter.Mobile.Forms.UI.Effects;
using Plugin.CurrentActivity;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportEffect(typeof(CornerRadiusEffectDroid), nameof(CornerRadiusEffect))]

namespace LearnSmarter.Mobile.Core.Droid
{
    public class CornerRadiusEffectDroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                PrepareContainer();
                SetCornerRadius();
            }
            catch { throw new NotImplementedException(); }
        }

        protected override void OnDetached()
        {
            try
            {
                Container.OutlineProvider = ViewOutlineProvider.Background;
            }
            catch { throw new NotImplementedException(); }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == CornerRadiusEffect.CornerRadiusProperty.PropertyName)
                SetCornerRadius();
        }

        private void PrepareContainer()
        {
            Container.ClipToOutline = true;
        }

        private void SetCornerRadius()
        {
            var cornerRadius = CornerRadiusEffect.GetCornerRadius(Element) * GetDensity();
            Container.OutlineProvider = new RoundedOutlineProvider(cornerRadius);
        }

        private static float GetDensity() =>
            CrossCurrentActivity.Current.Activity.Resources.DisplayMetrics.Density;

        private class RoundedOutlineProvider : ViewOutlineProvider
        {
            private readonly float _radius;

            public RoundedOutlineProvider(float radius)
            {
                _radius = radius;
            }

            public override void GetOutline(Android.Views.View view, Outline outline)
            {
                outline?.SetRoundRect(0, 0, view.Width, view.Height, _radius);
            }
        }
    }
}