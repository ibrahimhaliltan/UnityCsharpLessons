using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectcontrol : MonoBehaviour
{
    LineRenderer myline;
    public Transform target;
    //public int speed;
    //TrailRenderer traileffect;
   
    void Start()
    {
        /*
        traileffect = GetComponentInChildren<TrailRenderer>();
        speed = 2;
        */
        myline = GetComponentInChildren<LineRenderer>();
    }

    
    void Update()
    {
        myline.SetPosition(0, transform.position);
        myline.SetPosition(1, target.position);



        /*
        if (speed < 5)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            traileffect.time = 2f;
        }

        else
        {
            transform.Translate(Vector3.right * speed * 2 * Time.deltaTime);
            traileffect.time = .1f;
            traileffect.startColor = new Color(.93f, 1f, .47f);
            traileffect.endColor = new Color(.35f, 1f, .75f);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.down * 10f * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.up * 10f * Time.deltaTime);
        }
        */

    }
}
