using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathfprocess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Mathf.Abs(-2.5f)); // negatif sayıların mutlak değerini gösterir
        print(Mathf.Ceil(5.2f)); // daha büyük ve eşit sayıya yuvarlar.
        print(Mathf.Ceil(5.7f)); // daha büyük ve eşit sayıya yuvarlar.
        print(Mathf.Ceil(-5.0f));
        print(Mathf.Ceil(-5.2f)); // küçüldükçe büyüyen sayı olduğu için -5.0 a sabitler. 

        print(Mathf.Floor(5.0f));
        print(Mathf.Floor(5.2f)); // en yakın sayıya yuvarlar.
        print(Mathf.Floor(5.7f)); // 5 e yuvarlar.
        print(Mathf.Floor(-5.0f));
        print(Mathf.Floor(-5.2f));

        // YUVARLANACAK SAYININ KESİRLİ SAYISINA VE SAYININ TEK Mİ ÇİFT Mİ OLDUĞUNA BAKAR.
        print(Mathf.Round(5.0f));
        print(Mathf.Round(5.2f)); // kesirli sayısı 5 ten küçükse alt sayıya yuvarlar.
        print(Mathf.Round(5.7f)); // kesirli sayısı 5 ten büyükse üst sayıya yuvarlar
        print(Mathf.Round(-5.0f));
        print(Mathf.Round(-5.2f));


        float health = -60;
        print(Mathf.Clamp(health,1,100));
        print(Mathf.Clamp01(health));



        float[] myvalues = { 1.5f, 3f, 8f, 8.9f };
        print(Mathf.Max(2.4f, 1.8f)); // HANGİ DEĞER YÜKSEKSE
        print(Mathf.Min(2.4f, 1.8f)); HANGİ DEGER MİNSE



    }



    // Update is called once per frame
    void Update()
    {

    }
}
