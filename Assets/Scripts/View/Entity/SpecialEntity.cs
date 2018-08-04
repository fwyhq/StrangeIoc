// -----------------------------------------------------------------------
//  <copyright file="SpecialEntity.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using UnityEngine;

namespace Assets.Scripts.View.Entity
{
    public  class SpecialEntity:IEntity
    {
        public GameObject go;
        private int activeState = 0;
        public void Init(GameObject go)
        {
            this.go = go;
        }

        public void Show()
        {
            activeState = 1;
            Debug.Log("Special Show");
        }

        public void Hide()
        {
            activeState = 2;
            Debug.Log("Special Hide");
        }

        private void Update()
        {
            if (activeState == 1)
            {
                go.SetActive(true);
                activeState = 0;
            }
            else if (activeState == 2)
            {
                go.SetActive(false);
                activeState = 0;
            }
        }
    }
}