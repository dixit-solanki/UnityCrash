using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BllBounce : MonoBehaviour
{

    public Collider sphare;
    public new Rigidbody rigidbody;
    public Vector3 axis;

    void Awake()
    {
        sphare = GetComponent<Collider>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == null) return;

        Debug.Log($"Enter {collision}");
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log($"Enter {collision}");
    }

    void OnTriggerStay(Collider collision)
    {
        Debug.Log($"Inside {collision}");
    }

    void OnTriggerExit(Collider collision)
    {
        Debug.Log($"Exit {collision}");
    }
}
