using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformpositions : MonoBehaviour
{
    // Start is called before the first frame update

    /*public Transform mytarget;
    public Transform mytarget2;
    */

    public Transform parent;
    public GameObject child;
    void Start()
    {
        /*
        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(transform.GetChild(i).name);
            if (transform.GetChild(i).name == "Ejder")
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;

            if (i == 1)
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;
         }
         */

        child.transform.SetParent(parent,false);
    }


    /*
    GameObject findresult = transform.Find("GameObject").gameObject; // Unity içinde GameObject isimli objemi aradım.
    findresult.name = "İm different object"; // Bulduğum objenin ismini değiştirdim.
    Debug.Log(transform.childCount); // kaç tane alt eleman olduğunu gösterir.
    Debug.Log(transform.hierarchyCount); // sahnemdeki toplam obje sayısını gösterir.
    GameObject findresult2 = transform.Find("GameObject/Cube").gameObject; // objemin alt elemanını buluyorum.
    findresult2.name = "İm different object"; // objemin alt elemanı için işlem gerçekleştiriyorum.
    */
    //-----------------------------------------------------------------------------------------------------------------------
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
