//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using System.Collections;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

namespace Assets.Scripts.Services
{
    public class PetServices
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }


        [Inject]
         public IEventDispatcher dispatcher { get; set; }

        public void RecPetListData()
        {
            var mono = contextView.GetComponent<MonoBehaviour>();
            mono.StartCoroutine(waitASecond());
        }

        IEnumerator waitASecond()
        {
            yield return new WaitForSeconds(1f);

            dispatcher.Dispatch(NetEventDef.RES_LIST_PET_DATA,new object[]{1,2,3,4,5,6,7});
        }

    }
}