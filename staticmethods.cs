using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticmethods : MonoBehaviour
{
    // Statik metotlar

    public Transform mytarget;
    public Transform mytarget2;
    private float startingtime;
    void Start()
    {

        startingtime = Time.time;

        /*
            Time.time : ne kadar sürenin geçtiğini gösterir.
            time.deltatime : kareler arasındaki fps süresini gösterir.
            time.timeScale : ağır çekim veya durdurma işlemlerinde kullanılır - Pause / Continue
         */

        Vector3 firstpose = new Vector3(1f, 2f, 5f);
        Vector3 secondpose = new Vector3(2f, 3f, 5f);

        
        
        /*
        print(Vector3.Max(firstpose, secondpose));
        print(Vector3.Min(firstpose, secondpose));
        Vector3 final = Vector3.Scale(firstpose, secondpose);
        */

        print(firstpose - secondpose);
        print(firstpose + secondpose);
        print(firstpose / 3f);
        print(firstpose * 2f);

        //angle
        //distance iki vektör arasındaki mesafeyi gösterir.
        //Debug.Log("İ coming to start" + Time.time);

    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 0f;
        //Debug.Log(Time.time);

        /*
        Time.timeScale = .5f;
        transform.position = Vector3.Lerp(mytarget.position, mytarget2.position,(Time.time - startingtime) * .4f);
        */







        /*float fark = Vector3.Distance(mytarget.position, transform.position);
        Debug.Log("Fark Şöyle : " + fark);
        */

        /*
        Vector3 mydistance = mytarget.position - transform.position;
        float angle = Vector3.Angle(mydistance, transform.up);
        Debug.Log(angle);
        

        if (angle < 5f)
            Debug.Log("Açı Sağlandı");
        else
            Debug.Log("Açı Sağlanmadı");

        */
       
    }
}
