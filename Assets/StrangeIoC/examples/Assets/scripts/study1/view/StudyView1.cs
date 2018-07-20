// -----------------------------------------------------------------------
//  <copyright file="StudyView1.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.StrangeIoC.examples.Assets.scripts.view
{
    public class StudyView1:View
    {
        internal void SetViewText(string text)
        {
            gameObject.AddComponent<Text>().text = text;
        }
    }
}