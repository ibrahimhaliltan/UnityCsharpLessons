using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectcapture : MonoBehaviour
{

    GameObject myObject;
    GameObject[] multipleobject;

    public GameObject Outsider;
    void Start()
    {
        CapsuleCollider mycapsule = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
         
        mycapsule.isTrigger = true;

        Outsider.GetComponent<objectcontrol>().yas = 60;
       multipleobject = GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in multipleobject)
        {
            item.GetComponent<objectcontrol>().yas = 3;
        }



        myObject = transform.Find("Child").GetComponent<AudioSource>.mute = true;
        
        myObject = GameObject.FindWithTag("Monster");
        myObject.GetComponent<objectcontrol>().yas = 20;
        
        
        myObject = GameObject.Find("Main");
        myObject.("Main").GetComponent<objectcontrol>().yas = 15;
        myObject.GetComponent<objectcontrol>().yas = 19;


    }
