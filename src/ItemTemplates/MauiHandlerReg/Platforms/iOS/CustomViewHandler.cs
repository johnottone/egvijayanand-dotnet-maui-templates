﻿using TPlatformView = UIKit.UIView;
using $basenamespace$.Controls;
using Microsoft.Maui.Handlers;

namespace $basenamespace$.Handlers
{
    public partial class $safeitemname$ : ViewHandler<I$fileinputname$, TPlatformView>
    {
        protected override TPlatformView CreatePlatformView() => new TPlatformView();

        protected override void ConnectHandler(TPlatformView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(TPlatformView platformView)
        {
            base.DisconnectHandler(platformView);
        }
    }
}
