//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using strange.extensions.mediation.impl;

namespace Assets.Scripts.View.Pet
{
    public class PetListMediator:EventMediator
    {
        [Inject]
        public  PetListView view { get; set; }
        public override void OnRegister()
        {
            base.OnRegister();
            dispatcher.Dispatch(GameEventDef.Get_List_Pet_Data);

        }

        public void InitPetList()
        {
            
        }
    }
}