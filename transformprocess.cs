using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformprocess : MonoBehaviour
{
    /*
    Vector2 a; //2 boyutlu işlemlerde kullanılır
    Vector3 b; //3 boyutlu işlemlerde kullanılır
    Vector4 c; // gölgelendirme işlemlerinde kullanılır
    Quaternion d;
    */
    Vector3 myposition1;
    Vector3 myposition2;

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);
        */
        Debug.Log(myposition1.ToString());
        if (Equals(myposition1, myposition2)) //iki objenin pozisyon eşitliğini hesaplar.
            Debug.Log("Evet eşit");

        else
            Debug.Log("Eşit değil");

        myposition1 = new Vector3(1f, 2f, 1f);
        myposition2 = new Vector3(1f, 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       

        //Debug.Log(transform.position.normalized);
        //Debug.Log(Vector3.SqrMagnitude(transform.position)); // toplam uzunluğun karesini döndürür.
        //Debug.Log(Vector3.Magnitude(transform.position)); objenin pozsiyon bilgisini konsola yazdırır.
        //transform.Translate(Vector3.one * 5f * Time.deltaTime); vektörün her pozisyonuna 1 değeri verir.
        //transform.Translate(Vector3.zero * 5f * Time.deltaTime); vektörün her pozisyonuna 0 değeri verir.
        //transform.Translate(Vector3.back * 20f * Time.deltaTime); varsayılan olarak verilen değerlerle geriye giden back komutu.
        //transform.Translate(Vector3.up * 20f * Time.deltaTime); varsayılan y eksen değeri
        //transform.Translate(Vector3.down * 20f * Time.deltaTime); varsayılan -y eksen değeri
        //transform.Translate(Vector3.left * 20f * Time.deltaTime); varsayılan -x eksen değeri
        //transform.Translate(Vector3.right * 20f * Time.deltaTime); varsayılan x eksen değeri
        //transform.Translate(new Vector3(0f,0f,20f) * 5f * Time.deltaTime); // manuel değerle istediğin pozisyon üzerinde değer verebiliriz.

    }
}
