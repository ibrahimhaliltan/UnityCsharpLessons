using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,2f);
        //Destroy(this);
        Destroy(GetComponent<CapsuleCollider>());
    }

   
}
