//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using strange.extensions.mediation.impl;

namespace Assets.Scripts.View.Main
{
    public class MainMediator:EventMediator
    {
        [Inject]
        public MainView view { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
        
        }
    }
}