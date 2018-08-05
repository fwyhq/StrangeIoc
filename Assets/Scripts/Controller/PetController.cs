//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Assets.Scripts.Model;
using Assets.Scripts.Services;
using Assets.Scripts.View.Pet;
using JetBrains.Annotations;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts.Controller
{
    public class PetController:EventCommand
    {
        [Inject]
        public PetModel Model { get; set; }

        [Inject]
        public PetServices Services { get; set; }

        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        [Inject("Test")] public PetListItem ListItem { get; set; }
        [Inject("Value")]
        public string Value { get; set; }

        [Inject("ToValue")]
        public string ToValue { get; set; }

        public override void Execute()  
        {
           Debug.Log("launch PetController");
            
            this.RegisterGameEvent();
            this.RegisterNetEvent();
            this.OpenForm();
            Debug.Log("Value:"+Value+ ",ToValue:"+ ToValue);
        }

        private void RegisterNetEvent()
        {
            Services.dispatcher.AddListener(NetEventDef.RES_LIST_PET_DATA, this.ResListPetData);
        }

        private void RegisterGameEvent()
        {
            dispatcher.AddListener(GameEventDef.Get_List_Pet_Data,this.GetPetListData);
        }

        private void OpenForm()
        {
            GameObject goView = GameObject.Instantiate(Resources.Load("View/FanYuWu")) as GameObject;
            goView.transform.parent = contextView.transform;
        }

        private void GetPetListData()
        {
            Services.RecPetListData();
        }

        private void ResListPetData(object data)
        {
            Debug.Log("data:"+data);
            List<PetListItem> items = new List<PetListItem>();
            for (int i = 0; i < 2; i++)
            {
                PetListItem item = injectionBinder.GetInstance<PetListItem>();
                item.SetIndex(i);
                items.Add(item);
            }

            for (int i = 0; i < items.Count; i++)
            {
                items[i].ShowIndex();
            }
            ListItem.ShowIndex();
        }
    }
}