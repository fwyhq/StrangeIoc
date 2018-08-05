// -----------------------------------------------------------------------
//  <copyright file="PetContext.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

using Assets.Scripts.Controller;
using Assets.Scripts.Model;
using Assets.Scripts.Services;
using Assets.Scripts.View.Pet;

namespace Assets.Scripts.Context
{
    public class PetContext:ContextBase
    {
        public override void Binder()
        {
            mediationBinder.Bind<PetListView>().To<PetListMediator>();
            //commandBinder.Bind(GameEventDef.Open_Pet_List_View).To<PetController>();
            injectionBinder.Bind<PetModel>().ToSingleton(); //定义Model为单例
            injectionBinder.Bind<PetServices>().ToSingleton(); //定义Services为单例
            injectionBinder.Bind<PetListItem>().To<PetListItem>().ToName("Test");
            injectionBinder.Bind<PetListItem>().To<PetListItem>();
            injectionBinder.Bind<PetListIcon>().ToSingleton();

            injectionBinder.Bind<string>().To("Hello").ToName("Value");

            injectionBinder.Bind<string>().ToValue("NextHello").ToName("ToValue");

            injectionBinder.Unbind<PetListIcon>();
        }

        public override void Launch()
        {
            base.Launch();
            dispatcher.Dispatch(GameEventDef.Open_Pet_List_View);
        }
    }
}