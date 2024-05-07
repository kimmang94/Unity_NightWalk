using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public partial class DataBase_Manager : DB_Manager
{
    public static DataBase_Manager Instance;

    public override void Init_Func()
    {
        Instance = this;

        base.Init_Func();
    }
}
