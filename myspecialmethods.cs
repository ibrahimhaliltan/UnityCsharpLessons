using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myspecialmethods : MonoBehaviour
{

    private string name = "Ejder";
    private string surname = "Kınalıyürek";
    private int mynumber = 50;
    
    void Start()
    {
        string mytext = "Car prices is very expensive !";
        string[] explode = mytext.Split(' '); // boşluk aralıklarına göre mytext değişkenini ayırır.

        foreach (var item in explode)
        {
            print(item);
        }



        /*
        print(mytext.ToLower()); // küçük harflerle yazdırma.
        print(mytext.ToUpper()); // büyük harflerle yazdırma
        print(mynumber.ToString()); // sayıyı metinsel olarak yazdırma.
        print(mytext.Replace(" ", "/")); // arama metni ve yerine yerleştireceği metin.
        print(mytext.Trim()); // Başındaki ve sonundaki boşlukları siler.
        print(mytext.TrimStart()); // Başındaki boşlukları siler
        print(mytext.TrimEnd()); // sonundaki boşlukları silerim
        print(mytext.Substring(2, 10)); // mytext değişkeninin ikinciden onuncuya kadar yazdırır.
        */

        /*
        if (name.StartsWith("E")) // başlangıç değeri E ise
        {
            print("yes, its true !");
        }

        else
        {
            print("no, cant be real !");
        }
        */

        
        /*
        if (name.EndsWith("r")) // name değişkeninde sonu r ile biten elemanımız varsa işlem yapar.
        {
            print("yes its true");
        }

        else
        {
            print("no, its not.");
        }
        */
      
        

        /*
        if (name.Equals("Ejder")) // name değişkeninde Ejder diye biri var mı
        {
            print("yes he is Ejder");
        }

        else
        {
            print(" he is not Ejder!");
        }
        */
        
        
        
       /* 
        print(name);
        string copied = (string)name.Clone();
        print(name.GetType());
        print(copied);

        */
    }

    
    void Update()
    {
        
    }
}
