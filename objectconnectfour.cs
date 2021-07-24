using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectconnectfour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Oluşturduğun objelerin soyağacının en aşağısından en yukarısına müdahale ettiğin yöntem. Parent ingilizce olarak ebeveyn demektir. Anlam olarak aynılardır.
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 3f;

        // parent yani üst objelere ait yapılması istenilen toplu işlemlerde "GetComponentsInParent" komutunu kullanıyorum.
        GetComponentsInParent

        // oluşturduğum objelerin hiyerarşinin en üstünden en aşağısına müdahale ettiğin yöntem. Children İngilizce olarak çocuk demektir. Hiyerarşi olarak aynı anlamı taşıyor.
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = true;

        // children objelere ait yapılması istenilen toplu işlemlerle "GetComponentsInChildren" kullanılıyor.
        GetComponentsInChildren

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
