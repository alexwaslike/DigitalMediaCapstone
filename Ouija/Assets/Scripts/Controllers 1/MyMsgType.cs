﻿using UnityEngine;
using UnityEngine.Networking;

public class MyMsgType
{
    public static short Spawn = MsgType.Highest + 1;
    public static short Highlight = MsgType.Highest + 2;
}
