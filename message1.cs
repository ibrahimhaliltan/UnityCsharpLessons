using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SendMessage("pressscreen","Ejder",SendMessageOptions.DontRequireReceiver);
        gameObject.BroadcastMessage("presscreen2");
    }

    void presscreen2()
    {
        Debug.Log("i coming to main object");
    }
    void pressscreen(string name)
    {
        Debug.Log("Hello World xd" + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
