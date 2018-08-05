//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using strange.extensions.dispatcher.eventdispatcher.impl;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.View.ImageGame
{
    public class ImageGameMediator:EventMediator
    {
        [Inject]
        public ImageGameView View { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            dispatcher.AddListener(GameEventDef.Image_Game_Item,this.InitImageGame);
            dispatcher.Dispatch(GameEventDef.Get_Image_Game_Item);
        }

        private void InitImageGame(object property)
        {
            
            View.SetGameImage((property as TmEvent).data as ImageProperty);
        }
    }
}