﻿using $basenamespace$.Controls;
using $rootnamespace$;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using System.ComponentModel;
using TPlatformView = UIKit.UIView;

[assembly: ExportRenderer(typeof($fileinputname$), typeof($safeitemname$))]

namespace $rootnamespace$
{
    public class $safeitemname$ : ViewRenderer<$fileinputname$, TPlatformView>
    {
        public $safeitemname$()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<$fileinputname$> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(new TPlatformView());
                }

                // Initialization
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

                // Handle property changes
        }
    }
}
