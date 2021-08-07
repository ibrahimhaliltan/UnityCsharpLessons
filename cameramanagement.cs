using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanagement : MonoBehaviour
{
    public Camera mymaincam;
    public Camera mysecondcam;
    public Camera mythirdcam;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            mymaincam.enabled = false;
            mythirdcam.enabled = false;
            mysecondcam.enabled = true;
            mysecondcam.fieldOfView = 141f;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            mymaincam.enabled = false;
            mythirdcam.enabled = true;
            mysecondcam.enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            mymaincam.enabled = true;
            mythirdcam.enabled = false;
            mysecondcam.enabled = false;
        }
    }
}
