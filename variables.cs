using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    /*
     string  // metinsel verileri içerir.
     int     // sayısal değerleri içerir.
     float   // kayan sayılar 3.10 vb.
     double  // daha büyük kayan sayı 3.21234342324
     boolean // herhangi bir şeyi aktif veya pasif olmasını kontrol eder. true/false
    */

    /*
        //class içerisinde değer tanımlama
        string metnim = "Merhaba Ejder";
        int yas = 80;
        float kusurat = 3.10f;
        double kusurat2 = 3.2120;
        bool acikmi = false;
        //class içerisinde değer tanımlama 
    */

    // sadece değişkenlerin isimlerini ve türlerini belirliyorum.
    string metnim;
    int yas;
    float kusurat;
    double kusurat2;
    bool acikmi;
    

    void Start()
    {
        // işlemler yaptım, sorgular yaptım ve değişkenin değeri şu an oluştu.

        metnim = "iceriden";

        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }


}
