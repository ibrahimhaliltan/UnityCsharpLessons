using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectconnect : MonoBehaviour
{
    public string ad;
    public int yas;
    public float maas;
    private string memleket;
    public bool arabavarmi;
    public bool krediyeuygunmu;
    // Start is called before the first frame update
    void Start()
    {
        memleket = ad;
        Debug.Log(memleket);
        Debug.Log(ad);
        Debug.Log(yas);
        Debug.Log(maas);
        Debug.Log(arabavarmi);

        if (yas > 18)
            arabavarmi = true;
        else
            arabavarmi = false;

        if (maas < 3000)
        {
            Debug.Log("Kredi almaya uygun değil");
            krediyeuygunmu = false;
        }

        else
        {
             
            Debug.Log("Kredi almaya uygun.");
            krediyeuygunmu = true;
        }
        

        if (arabavarmi)
            Debug.Log("Evet, ehliyet hakkı var.");
        else
            Debug.Log("Hayır, ehliyet hakkı bulunmuyor.");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
