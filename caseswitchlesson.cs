using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caseswitchlesson : MonoBehaviour
{
    
    void Start()
    {
        /*
        int sayim = 3;
        */

        string araba = "BMW";

        switch (araba)
        {
            case "audi":
            case "BMW":
            Debug.Log("Girmiş olduğunuz bir bilgi doğru.");
            break;

            case "mercedes":
                Debug.Log("Evet değer Mercedes");
                break;

            case "Seat":
                Debug.Log("Evet değer Seat");
                break;


            default:
                Debug.Log("Uyuşan kayıt bulunamadı.");
                break;


        }

    }

    
}
