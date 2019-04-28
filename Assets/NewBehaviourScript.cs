using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    int a=0;
    List<int> C = new List<int>();
   // int[] Arr=[3](1,2,3);
	void Start () 
	{
        for (int i = 0; i < 10; i++)
        {
            C.Add(i);
        }
        Debuger.EnableLog = true;
        string b = string.Format("<Color=cyan>雨松MOMO{0}</Color>",a);
		Debuger.Log(b);
        EGDebug.enable = true;
        EGDebug.LogBold("zgh");
        EGDebug.LogTitle("zz", 5, EGDebug.Color.blue);
        Debug.Log("1");
        Debug.LogError("2");
        Debug.LogWarning("2");
        Debug.LogErrorFormat("3", a);

        EGDebug.LogList(C);
        EGDebug.Log("hh",EGDebug.Color.black);
        ZDebug.Log("GG", ZDebug.Color.yellow);
        ZDebug.LogError("zh",ZDebug.Color.cyan);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
