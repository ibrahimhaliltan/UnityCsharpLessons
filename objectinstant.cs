using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectinstant : MonoBehaviour
{
    public GameObject objectexam;
    private float mytime;
    // Start is called before the first frame update
    void Start()
    {
        mytime = 0;
        //Instantiate(objectexam);
        //Instantiate(objectexam, transform);
        //Instantiate(objectexam, transform.position, transform.rotation);
        //Instantiate(objectexam, transform.position, Quaternion.identity);
        //Instantiate(objectexam, new Vector3(2f, 3f, 4f), Quaternion.identity);
        //Instantiate(objectexam, new Vector3(transform.position.x, 3f, 4f), Quaternion.identity);
        GameObject mynewobject = Instantiate(objectexam, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        mynewobject.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mytime >=2)
        {
            Instantiate(objectexam, new Vector3(transform.position.x, 3f, 4f), Quaternion.identity);
            mytime = 0;
        }

        else
        {
            mytime += Time.deltaTime;
        }
    }
}
