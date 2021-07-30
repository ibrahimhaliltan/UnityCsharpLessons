using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("KinaliyurekLibrary/EjderTools")] // component olarak kendi scriptini ekleyebilirsin.
[RequireComponent(typeof(Rigidbody))] // bu scripti objeme eklediğimde bu componenti de ekleyeceksin demektir.

public class hideflags : MonoBehaviour
{

    [ContextMenu("Benüm Menüm",false,1)]




    void MyMenu()
    {
        print("i coming to settings");
    }


    /*
    [Header("Burası Ana Karakterin Ayarları")]
    public string health;
    public string money;
    public string level;

    [Header("Burası Düşmanların Ayarları")]
    public string enemy_health;
    public string enemy_money;
    public string enemy_level;
    */


    /*
    [Tooltip("Bu benim notum.")] // hangi özellik hangi işe yarıyor not bırakabiliriz.
    public bool mystatus;
    
    [Multiline(7)] // 7 Satırlık text bölgesi
    public string myname;

     */











    /*
    [Range(1, 6)] // 1 ile 6 arasında bir değer girebilmeni sağlar.
    public int myvalues;

    [Min(5)] // bir değerim 5 ten aşağı hiç bir şekilde düşmesin.
    public int myvalues2;
    
    
    
    
    
    public Color mytext2;
    public Texture mytext3;
    public AudioClip mytext4;
    
    [HideInInspector] // altında kalan değişkenler inspectorda görünmez !
    public string mytext;

    */
    
    void Start()
    {
        /*
        gameObject.hideFlags = HideFlags.HideInHierarchy; // Hiyerarşi kısmında gizle. Mermileri gizlemek gibi olabilir.
        gameObject.hideFlags = HideFlags.HideInInspector; // İnspector kısmını gizle. Bir birine benzeyen objelerin ayarlarında değişiklik yapmamak için kullanılır.
        gameObject.hideFlags = HideFlags.NotEditable // İnspectorda hiç bir değişiklik yapılmaması için kullanılır.
        gameObject.hideFlags = HideFlags.DontSave // Nesnede hiç bir değişiklik yapılmaması için kullanılır.
        gameObject.hideFlags = HideFlags.DontSave // Nesnede hiç bir değişiklik yapılmaması için kullanılır.
        */







    }


    
}
