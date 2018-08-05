//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using UnityEngine;

namespace Assets.Scripts.View.Pet
{
    public class PetListIcon
    {
        private int index = -1;
        public PetListIcon()
        {

        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public void ShowIndex()
        {
            Debug.Log(this.index);
        }
    }
}