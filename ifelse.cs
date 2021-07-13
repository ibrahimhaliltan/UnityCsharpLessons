using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelsedersleri : MonoBehaviour
{
    /* karşılaştırma operatörleri
      
      <  küçükse
      >  büyükse
      >= büyükse ve eşitse
      <= küçükse ve eşitse
      == eşitse
      != eşit değilse
    */

   
     
     
    int sayi1 = 5;
    int sayi2 = 10;
    int sayi3 = 3;
    int sayi4 = 1;
    string ad1 = "Ejder";
    string ad2 = "Ejder";
    bool kapiacikmi = false;

     /* mantıksal operatörler
    not işareti => !
    and işareti => &&
    or işareti  => ||

    */

    void Start()
    {
        if (sayi1 < sayi2)
            Debug.Log("koşul sağlandı.");
        else if (sayi2 < sayi3)
            Debug.Log("koşul sağlandı.");
        else
            Debug.Log("koşul sağlanmadı.");
        /*
        if(!kapiacikmi)
        {
            Debug.Log("degisken not ile değiştirildi.");
        }

        else
        {
            Debug.Log("degisken false");
        }
        

        if(sayi1 < sayi2 && sayi1 < sayi3 )
        {
            Debug.Log("Evet, küçük.");
        }

        else if(sayi1 == sayi3 || ad1 == ad2)
        {
            Debug.Log("2.Koşul");
        }

        else if(sayi1 == sayi4)
        {
            Debug.Log("Evet, eşit.");
        }

        else if(ad1 != ad2)
        {
            Debug.Log("Üyelik bilgileri eşleşmiyor !");
        }

        else
        {
            Debug.Log("Hayır, değil.");
        }


        /*
        if(kosul)
        {
            //bu kosul sağlanırsa burası çalışır.
        }

        else if(kosul2)
        {
            // yukarıdaki koşul sağlanmazsa burası çalışır.
            // İstediğiniz kadar else if kullanabilirsiniz.
        }

        else
        {
            // else if koşulu sağlanmazsa en son burası çalışır.
        }
        */

    }

  
}
