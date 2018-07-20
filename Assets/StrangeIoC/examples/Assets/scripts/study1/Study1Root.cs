using System.Collections;
using System.Collections.Generic;
using Assets.StrangeIoC.examples.Assets.scripts;
using Assets.StrangeIoC.examples.Assets.scripts.view;
using strange.extensions.context.impl;
using UnityEngine;

public class Study1Root : ContextView
{

    private void Awake()
    {
        var context = new Study1Context(this);

        
    }
}
