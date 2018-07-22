using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Controller;
using Assets.Scripts.Test;
using Assets.Scripts.View.Login;
using Assets.Scripts.View.Main;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class GameContext : MVCSContext {

    public GameContext() : base()
    {

    }

    public GameContext(MonoBehaviour view) : base(view)
    {
         
    }

    protected override void mapBindings()
    {
        base.mapBindings();
        mediationBinder.Bind<LoginView>().To<LoginMediator>();
        mediationBinder.Bind<MainView>().To<MainMediator>();
        commandBinder.Bind(ContextEvent.START).To<StartCommand>();
    }

    protected override void addCoreComponents()
    {
        base.addCoreComponents();
        injectionBinder.Unbind<ICommandBinder>();
        injectionBinder.Bind<ICommandBinder>().To<EventCommandBinder>().ToSingleton();
    }

    protected override void instantiateCoreComponents()
    {
        base.instantiateCoreComponents();
    }
}
