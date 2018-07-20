// -----------------------------------------------------------------------
//  <copyright file="StudyCommand1.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using Assets.StrangeIoC.examples.Assets.scripts.view;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

namespace Assets.StrangeIoC.examples.Assets.scripts.controller
{
    public class StudyCommand1:EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {
            GameObject go = new GameObject("Study1View");
            go.AddComponent<StudyView1>();
            go.transform.parent = contextView.transform;
        }
    }
}