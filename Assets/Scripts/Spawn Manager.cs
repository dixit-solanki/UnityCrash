using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obj,transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
