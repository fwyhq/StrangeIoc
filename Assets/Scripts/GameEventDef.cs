//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

namespace Assets.Scripts
{
    public enum GameEventDef
    {
        Open_Main_View = 0,
        Change_Mode_Simple,
        Change_Mode_Special,
        GameObject_Show,
        GameObject_Hide,

        Open_Pet_List_View,
        Get_List_Pet_Data,
        Image_Game_Item,
        Get_Image_Game_Item,
    }

    public enum UIEventDef
    {
        Click_Login_Button = 0,
        Click_Change_Mode_Simple,
        Click_Change_Mode_Special,
        Click_GameObject_Show,
        Click_GameObject_Hide,

    }

    public enum NetEventDef
    {
        RES_LIST_PET_DATA,
    }

    public class ConstantName
    {
        public const string Login = "Login";
        public const string Main = "Main";

    }
}