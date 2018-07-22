// // -----------------------------------------------------------------------
// //  <copyright file="Study1Context.cs" company="Tencent">
// //  Copyright (C) Tencent. All Rights Reserved.
// //  </copyright>
// //  <author>leowfeng(冯伟)</author>
// <summary>
//  view 与 mediator 通过dispatcher来交互
//  mediator 持有view可以直接访问view中的方法
//  通过mediatorbind来绑定的话创建view就会同步创建mediator 具体创建的地方在View的父类
//  父类通过awake或者start都可以创建对应的mediator，但是框架启动的时候立刻调用awake会应为创建流程还没走完，导致创建失败。
//  所以第一次会通过start来创建
// </summary>
// // -----------------------------------------------------------------------

using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine.UI;

namespace Assets.Scripts.View.Login
{
    using strange.extensions.mediation.impl;

    public class LoginView:View
    {
        [Inject]
        public IEventDispatcher dispatcher { get; set; }

        public Button loginButton;

        internal void OnInit()
        {
            loginButton.onClick.AddListener((() => { dispatcher.Dispatch(UIEventDef.Click_Login_Button); }));
        }
    }
}