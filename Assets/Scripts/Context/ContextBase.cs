// -----------------------------------------------------------------------
//  <copyright file="ContextBase.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using strange.extensions.command.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace Assets.Scripts.Context
{
    public class ContextBase
    {
        [Inject]
        public IInjectionBinder injectionBinder { get; set; }

        [Inject]
        public ICommandBinder commandBinder { get; set; }

        [Inject]
        public IMediationBinder mediationBinder { get; set; }

        [Inject]
        public IEventDispatcher dispatcher { get; set; }

        public ContextBase()
        {
            
        }

        public virtual void Binder()
        {

        }
    }
}