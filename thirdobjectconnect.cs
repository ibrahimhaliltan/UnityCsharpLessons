using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdobjectconnect : MonoBehaviour

{
    CapsuleCollider MyCapsule;
    // Start is called before the first frame update
    void Start()
    {
        // bir kapsül oluşturdun ve bu kapsülün sadece Unity3D'nin  "CapsuleCollider" componentinin içindeki ayarlara değerler atadın.
        MyCapsule = GetComponent<CapsuleCollider>();
        MyCapsule.enabled = false;
        MyCapsule.isTrigger = true;
        MyCapsule.height = 7;

        //birden fazla aynı component için ayarlar uygulamanın bir şekli aşağıdaki gibidir.
        CapsuleCollider[] capsules = GetComponents<CapsuleCollider>();
        for (int i = 0; i < capsules.Length; i++)
        {
            capsules[i].isTrigger = true;
        }
        // bu uyguladığım yöntemde iki tane CapsuleCollider componentime for döngüsü ile aynı değerleri atamış oldum.
        
        /*
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<CapsuleCollider>().isTrigger = true;
        GetComponent<CapsuleCollider>().height = 7;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
