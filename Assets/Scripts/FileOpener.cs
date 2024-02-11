using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileOpener : MonoBehaviour
{
    public string FilePath;

    public void OnGUI()
    {
        if(GUI.Button(new Rect(10,10,150,50) , "Open File"))
        {
            OpenFile();
        }
    }

    public void OpenFile()
    {
        string normalizePath = FilePath.Replace("\\","/");

        Application.OpenURL(normalizePath);
    }
}
