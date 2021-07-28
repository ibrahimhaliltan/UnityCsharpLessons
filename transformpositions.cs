using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformpositions : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform mytarget;
    public Transform mytarget2;
    void Start()
    {
         //mytarget.transform.Rotate(90f,0f,0f, Space.Self);
         //mytarget2.transform.Rotate(90f,0f,0f, Space.World);
        //transform.position = new Vector3(2f, 3f, 5f); : objemi belirttiğim koordinatlara gönderdim.
        //transform.position = new Vector3(transform.position.x, 6f, transform.position.z); // x ve z değerlerini sabit değerde tut fakat y değerine 6 yı ver.
    }

    // Update is called once per frame
    void Update()
    {


        //mytarget2.transform.LookAt(mytarget); //oluşturduğum obje hareket ettiğim objeye doğru yön alıyor. Oyunda güvenlik kamerası gibi düşün.
        
        /*
        mytarget.transform.Rotate(90f,0f,0f, Space.Self);
        mytarget2.transform.Rotate(90f,0f,0f, Space.World);
        */

        //transform.Rotate(new Vector3(1f, 0f, 0f) * Time.deltaTime * 50f); //Obhjeyi bulunduğu eksende döndürür.
        //transform.Translate(transform.forward * Time.deltaTime * 1f);
    }
}
