//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using Assets.Scripts.Model;
using Assets.Scripts.Services;
using Assets.Scripts.View.Entity;
using Assets.Scripts.View.Login;
using Assets.Scripts.View.Main;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.injector.api;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class StartCommand:EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }
        //[Inject(ConstantName.Login)]
        //public IModel loginModel { get; set; }

        [Inject]
        public IInjectionBinder injectionBinder { get; set; }

        private IEntity entity;

        private GameObject Obj;

        public override void Execute()
        {
            
            GameObject go = GameObject.Instantiate (Resources.Load("View/LoginView")) as GameObject;
            go.transform.parent = contextView.transform;

            this.Obj = GameObject.Instantiate(Resources.Load("Object/Cube")) as GameObject;
            dispatcher.AddListener(GameEventDef.Open_Main_View,this.OpenMainView);
            dispatcher.AddListener(GameEventDef.Change_Mode_Simple, this.InitSimpleClick);
            dispatcher.AddListener(GameEventDef.Change_Mode_Special, this.InitSpecialClick);
            dispatcher.AddListener(GameEventDef.GameObject_Show, this.ShowObject);
            dispatcher.AddListener(GameEventDef.GameObject_Hide, this.HideObject);
        }

        private void OpenMainView()
        {
            GameObject go = GameObject.Instantiate(Resources.Load("View/MainView")) as GameObject;
            go.transform.parent = contextView.transform;
        }

        private void InitSimpleClick()
        {
            injectionBinder.Bind<IEntity>().To<SimpleEntity>();
            this.InitEntity();
        }

        private void InitSpecialClick()
        {
            injectionBinder.Bind<IEntity>().To<SpecialEntity>();
            this.InitEntity();
        }

        private void InitEntity()
        {
            this.entity = injectionBinder.GetInstance<IEntity>();
            this.entity.Init(this.Obj);
            injectionBinder.Unbind<IEntity>();
        }


        private void ShowObject()
        {
            this.entity.Show();
        }

        private void HideObject()
        {
            this.entity.Hide();
        }
    }
}