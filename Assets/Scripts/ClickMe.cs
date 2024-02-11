using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickMe : MonoBehaviour
{
    public Button yourButton;
    public GameObject obj;
    public UnityEvent myEvent;

    // Start is called before the first frame update
    void Start()
    {
        if (myEvent == null)
            myEvent = new UnityEvent();

        myEvent.AddListener(ClickMePlease);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && myEvent != null)
        {
            myEvent.Invoke();
        }
    }

    public void ClickMePlease()
    {
        Debug.Log("clicked");
        obj.SetActive(false);
    }
}
