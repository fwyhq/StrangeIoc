// -----------------------------------------------------------------------
//  <copyright file="IEntity.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using UnityEngine;

namespace Assets.Scripts.View.Entity
{
    public interface IEntity
    {
        void Init(GameObject go);

        void Show();

        void Hide();
    }
}