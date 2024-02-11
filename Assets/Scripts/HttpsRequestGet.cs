using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HttpsRequestGet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetRequest());
    }

    IEnumerator GetRequest()
    {
        string url = "https://music.kartadharta.xyz/api/commands";

        UnityWebRequest webRequest = UnityWebRequest.Get(url);

        yield return webRequest.SendWebRequest();

        if (webRequest.result != UnityWebRequest.Result.Success) {
            Debug.LogError($"Error {webRequest.error}");
        }else
        {
            string responseData = webRequest.downloadHandler.text;

            Debug.Log($"Response: {responseData}");
        }
    }
}
