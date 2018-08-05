//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary>拼图IOC</summary>
//  -----------------------------------------------------------------------

using Assets.Scripts.View.ImageGame;

namespace Assets.Scripts.Context
{
    public class ImageContext:ContextBase
    {
        public override void Binder()
        {
            base.Binder();
            mediationBinder.Bind<ImageGameView>().To<ImageGameMediator>();
        }
    }
}