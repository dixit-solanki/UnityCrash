using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamPlayer : MonoBehaviour
{

    public WebCamTexture webCam;
    public Material greenScreenMaterial;

    // Start is called before the first frame update
    void Start()
    {
        webCam = new WebCamTexture();
        GetComponent<Renderer>().material = greenScreenMaterial;
        greenScreenMaterial.mainTexture = webCam;
        webCam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
