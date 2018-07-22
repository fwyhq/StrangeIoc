//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using Assets.Scripts.View.Login;
using Assets.Scripts.View.Main;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class StartCommand:EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {
            GameObject go = GameObject.Instantiate (Resources.Load("View/LoginView")) as GameObject;
            go.transform.parent = contextView.transform;
            dispatcher.AddListener(GameEventDef.Open_Main_View,this.OpenMainView);
        }

        private void OpenMainView()
        {
            GameObject go = GameObject.Instantiate(Resources.Load("View/MainView")) as GameObject;
            go.transform.parent = contextView.transform;
        }
    }
}