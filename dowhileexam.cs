using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dowhileexam : MonoBehaviour
{
   
    void Start()
    {
        int sayi = 0;

        do
        {
            Debug.Log("Ben do'dan geliyorum.");
            sayi++;

        } while (sayi <= 1);

        /*
         * 
        // break
        // continue
        while (sayi < 1)
        {
            Debug.Log("Dönüyorum");
            sayi++;
        }
        */
    }

}
