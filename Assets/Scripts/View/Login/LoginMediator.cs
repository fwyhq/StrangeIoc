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
            
        }

        private void OnClickLogin()
        {
            dispatcher.Dispatch(GameEventDef.Open_Main_View);
        }
    }
}