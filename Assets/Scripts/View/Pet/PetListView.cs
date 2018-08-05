//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.View.Pet
{
    public class PetListView:strange.extensions.mediation.impl.View
    {
        public GameObject listItem;
        public Button CloseBtn;
        protected override void Start()
        {
            base.Start();
            CloseBtn.onClick.AddListener(() =>
            {
                Destroy(gameObject);
            });
        }
    }
}