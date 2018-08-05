using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.Context;
using Assets.Scripts.Controller;
using Assets.Scripts.Model;
using Assets.Scripts.Services;
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

    protected List<ContextBase> contextList = new List<ContextBase>();
    public GameContext(MonoBehaviour view) : base(view)
    {
    }

    protected override void mapBindings()
    {
        base.mapBindings();
        mediationBinder.Bind<LoginView>().To<LoginMediator>();
        mediationBinder.Bind<MainView>().To<MainMediator>();

        //injectionBinder.Bind<IModel>().To<LoginModel>();
        //injectionBinder.Bind<IModel>().To<MainModel>();

        //injectionBinder.Bind<IServices>().To<LoginServices>().ToName(ConstantName.Login);
        //injectionBinder.Bind<IServices>().To<MainServices>().ToName(ConstantName.Main);

        

        commandBinder.Bind(ContextEvent.START).To<ImageGameController>();
    }

    protected override void addCoreComponents()
    {
        base.addCoreComponents();
        this.addModuleComponents();
        injectionBinder.Unbind<ICommandBinder>();
        injectionBinder.Bind<ICommandBinder>().To<EventCommandBinder>().ToSingleton();
    }

    protected void addModuleComponents()
    {
        injectionBinder.Bind<PetContext>().ToSingleton();
        injectionBinder.Bind<ImageContext>().ToSingleton();
    }

    protected void InstantiateModuleComponents()
    {
        contextList.Add(injectionBinder.GetInstance<PetContext>());
        contextList.Add(injectionBinder.GetInstance<ImageContext>());
        for (int i = 0; i < contextList.Count; i++)
        {
            contextList[i].Binder();
        }
    }

    protected override void instantiateCoreComponents()
    {
        base.instantiateCoreComponents();
        this.InstantiateModuleComponents();
    }

    public override void Launch()
    {
        base.Launch();
        for (int i = 0; i < contextList.Count; i++)
        {
            contextList[i].Launch();
        }
    }
}
