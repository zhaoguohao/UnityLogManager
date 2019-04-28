using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestDebug : MonoBehaviour {
    public Button button;
    // Use this for initialization

    private void Start()
    {
        button.onClick.AddListener(click);
    }
    void click()
    {
        Log.LogMsg("Aaa", LogColor.Orange, LogLevel.Important);
        Log.LogMsg("Aaa", LogColor.Green, LogLevel.Normal);
    }
    //void Start()
    //{
    //  //  Log.LogMsg("Aaa",LogColor.Red,LogLevel.Normal);
    //    //Profiler.BeginSample(">>>Log Test");
    //    //for (int i = 0; i < 100; i++)
    //    //{
    //    //    Debug.Log("Call:" + i);
    //    //    Profiler.EndSample();
    //    //}
    //}
        public enum LogLevel  //Log等级
    {
        Everything,
        Normal,
        Important,
        Emergy
    }

    public enum LogColor //Log颜色
    {
        White,
        Red,
        Yellow,
        Blue,
        Green,
        Purple,
        Orange
    }

    public static class Log
    {
        public static Dictionary<LogColor, string> colors = new Dictionary<LogColor, string>();
        public static LogLevel curMsgType = LogLevel.Emergy; //当前允许的打印等级

        public static void InitColor()
        {
            colors.Add(LogColor.White, "FFFFFF");
            colors.Add(LogColor.Green, "00FF00");
            colors.Add(LogColor.Blue, "99CCFF");
            colors.Add(LogColor.Red, "FF0000");
            colors.Add(LogColor.Yellow, "FFFF00");
            colors.Add(LogColor.Purple, "CC6699");
            colors.Add(LogColor.Orange, "FF9933");
        }

        public static void LogMsg(string msg, LogColor color = LogColor.White, LogLevel type = LogLevel.Normal)
        {
            if (type < curMsgType)  //只允许打印比curMsgType等级高的Log,方便Log等级管理
            {
                return;

            }
            Debug.Log(msg+ color);

            msg = string.Format("<color={0}>{1}</color>",color, msg);
            Debug.Log(msg);
        }

        public static void LogMsg(string msg, GameObject go, LogLevel type = LogLevel.Normal, LogColor color = LogColor.White)
        {
            if (type < curMsgType)
            {
                return;
            }
            msg = string.Format("<color=#{0}>{1}</color>", colors[color], msg);
            Debug.Log(msg, go);
        }
    }

}
