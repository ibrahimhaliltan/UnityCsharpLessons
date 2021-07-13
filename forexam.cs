using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fordersleri : MonoBehaviour
{
    int disaridansayim = 5;
    void Start()
    {
        for (int sayi = 0; sayi < disaridansayim; sayi++)
        {
            if (sayi == 2) continue;
            if (sayi == 3) break;
            
            Debug.Log("sayinin değeri :" + sayi);
        }
    }

   
}
