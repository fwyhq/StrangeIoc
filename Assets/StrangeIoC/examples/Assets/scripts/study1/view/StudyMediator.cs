// -----------------------------------------------------------------------
//  <copyright file="StudyMediator.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using strange.extensions.mediation.impl;

namespace Assets.StrangeIoC.examples.Assets.scripts.view
{
    public class StudyMediator: EventMediator
    {
        [Inject]
        public StudyView1 view { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            view.SetViewText("i'm mediator");
        }
    }
}