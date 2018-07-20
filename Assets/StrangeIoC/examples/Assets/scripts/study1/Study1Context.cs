// -----------------------------------------------------------------------
//  <copyright file="Study1Context.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using Assets.StrangeIoC.examples.Assets.scripts.controller;
using Assets.StrangeIoC.examples.Assets.scripts.view;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace Assets.StrangeIoC.examples.Assets.scripts
{
    public class Study1Context:MVCSContext
    {
        public Study1Context(MonoBehaviour view) : base(view)
        {

        }

        protected override void mapBindings()
        {
            //injectionBinder.Bind<ICommandBinder>().To<EventCommandBinder>().ToSingleton();
            mediationBinder.Bind<StudyView1>().To<StudyMediator>();

            commandBinder.Bind(ContextEvent.START).To<StudyCommand1>().Once();
            base.mapBindings();

            
        }

        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>(); //Unbind to avoid a conflict!
            injectionBinder.Bind<ICommandBinder>().To<EventCommandBinder>().ToSingleton();
        }
    }
}