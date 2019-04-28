using SFB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class OpenFile : MonoBehaviour {

    public Button button;
    public Text Outtext;
    private void OnEnable()
    {
        button.onClick.AddListener(Open);
        //System.Diagnostics.Process.Start("notepad.exe", UnityEngine.Application.streamingAssetsPath + "/" +"Tool.txt" ); //用记事本
      //  System.Diagnostics.Process.Start(@"E:\CloudMusic\CloudMusic\cloudmusic.exe");

    }
    void Open () {
 
        var paths = StandaloneFileBrowser.OpenFilePanel("Title", "", "txt", false);
        for (int i = 0; i < paths.Length; i++)
        {
            Debug.Log(paths[i]);
        }
        if (paths.Length>0)
        {
            StartCoroutine(enumerator(new System.Uri(paths[0]).AbsoluteUri));
        }
    }
    //迭代
    IEnumerator enumerator(string url)
    {
        var www = new WWW(url);
         yield return www;
        Outtext.text = www.text;
    }
	IEnumerable enumerable()
    {
        yield return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
