using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Test;
using strange.extensions.context.impl;
using UnityEngine;

public class GameContext : MVCSContext {

    [Inject]
    public ITest testRun { get; set; }

    public GameContext() : base()
    {

    }

    public GameContext(MonoBehaviour view) : base(view)
    {

    }

    protected override void mapBindings()
    {
        base.mapBindings();
        //injectionBinder.Bind<ITest>().To<TestWalk>();
        injectionBinder.Bind<ITest>().To<TestRun>().ToSingleton();

        
        var tt = injectionBinder.GetInstance<ITest>();
        tt.DoTest();
    }
}
