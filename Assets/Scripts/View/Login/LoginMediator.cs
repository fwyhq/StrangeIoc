//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using strange.extensions.mediation.impl;

namespace Assets.Scripts.View.Login
{
    public class LoginMediator:EventMediator
    {
        [Inject]
        public LoginView view { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            view.OnInit();
            view.dispatcher.AddListener(UIEventDef.Click_Login_Button,this.OnClickLogin);
            view.dispatcher.AddListener(UIEventDef.Click_Change_Mode_Simple, this.OnClickSimpleMode);
            view.dispatcher.AddListener(UIEventDef.Click_Change_Mode_Special, this.OnClickSpecialMode);
            view.dispatcher.AddListener(UIEventDef.Click_GameObject_Show, this.OnClickShow);
            view.dispatcher.AddListener(UIEventDef.Click_GameObject_Hide, this.OnClickHide);
            
        }

        private void OnClickLogin()
        {
            //UnityEngine.Application.OpenURL("https://itunes.apple.com/ye/app/一起来捉妖/id1262982086?mt=8");
            dispatcher.Dispatch(GameEventDef.Open_Main_View);
        }

        private void OnClickSimpleMode()
        {
            dispatcher.Dispatch(GameEventDef.Change_Mode_Simple);
        }

        private void OnClickSpecialMode()
        {
            dispatcher.Dispatch(GameEventDef.Change_Mode_Special);
        }

        private void OnClickShow()
        {
            dispatcher.Dispatch(GameEventDef.GameObject_Show);
        }

        private void OnClickHide()
        {
            dispatcher.Dispatch(GameEventDef.GameObject_Hide);
        }
    }
}