//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using System.Runtime.CompilerServices;
using Assets.Scripts.View.ImageGame;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class ImageGameController:EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {
            GameObject goView = GameObject.Instantiate(Resources.Load("View/ImageGameView")) as GameObject;
            goView.transform.parent = contextView.transform;

            dispatcher.AddListener(GameEventDef.Get_Image_Game_Item,this.GetImageItemData);

            
        }

        private void GetImageItemData()
        {
            GameObject item = GameObject.Instantiate(Resources.Load("ImageGameSource/Image1")) as GameObject;
            dispatcher.Dispatch(GameEventDef.Image_Game_Item, item.GetComponent<ImageProperty>());
        }
    }
}