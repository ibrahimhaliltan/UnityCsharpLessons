using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyshicprocess : MonoBehaviour
{
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "2")
        {
            Debug.Log("Etkileşim var");
        }


      
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "2")
        {
            Debug.Log("Etkileşim sürüyor.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "2")
        {
            Debug.Log("Etkileşim bitti");
        }


       
    }

    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PyshicCatch")) // PyshicCatch etkiketine ait nesne ile iletişim kurarsam.
        {
            Destroy(other.gameObject); // etkileşimde olduğum gameObject nesnesini yok eder.
            Debug.Log("Etkileşim var"); // etkileşimde olduğum sırada çıktı alır.
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PyshicCatch")) //PyshicCatch etkiketine ait nesne ile iletişim kurarsam.
        {
            Debug.Log("Etkileşim sürüyor"); // etkileşim devam ettiğinde çıktı vermeye devam eder.
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PyshicCatch")) //  PyshicCatch etkiketine ait nesne ile iletişim kurarsam.
        {
            Debug.Log("Etkileşim bitti"); // etkileşimim bittiğinde çıktı verir.
        }
    }
}
