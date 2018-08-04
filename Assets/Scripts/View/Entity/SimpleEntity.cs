// -----------------------------------------------------------------------
//  <copyright file="SimpleEntity.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using UnityEngine;

namespace Assets.Scripts.View.Entity
{
    public class SimpleEntity: IEntity
    {
        private GameObject go;

        public void Init(GameObject go)
        {
            this.go = go;
        }

        public void Show()
        {
            this.go.SetActive(true);
            Debug.Log("Simple Show");
        }

        public void Hide()
        {
            this.go.SetActive(false);
            Debug.Log("Simple Hide");
        }
    }
}