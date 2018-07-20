// -----------------------------------------------------------------------
//  <copyright file="TestRun.cs" company="Tencent">
//  Copyright (C) Tencent. All Rights Reserved.
//  </copyright>
//  <author>leowfeng(冯伟)</author>
//  <summary></summary>
// -----------------------------------------------------------------------

namespace Assets.Scripts.Test
{
    public class TestRun:ITest
    {
        public void DoTest()
        {
            UnityEngine.Debug.Log("Run");
        }
    }
}