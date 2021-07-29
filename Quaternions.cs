using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternions : MonoBehaviour
{
    public Transform hedef;
   
    // Start is called before the first frame update
    void Start()
    {
        /*
         Vector3 ourposition = new Vector3(140, 70, 90);
         Quaternion newpositioon = Quaternion.Euler(ourposition);

         transform.rotation = newpositioon;

         //transform.rotation = Quaternion.Euler(90, 0, 0);
         transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); // objeyi kendi ekseninde döndürür.
        */

        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 fark = hedef.position - transform.position;
        transform.rotation = Quaternion.LookRotation(fark, Vector3.up);

        float angle = Quaternion.Angle(transform.rotation, hedef.rotation);
        print(angle);

        transform.rotation = Quaternion.Inverse(hedef.rotation);
        */
    }
}
