using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondobjectconnect : MonoBehaviour
{
    public string[] cocuklar;
    public List<string> babalar;
    // Start is called before the first frame update
    void Start()
    {
        babalar.Add("Ejder");
        foreach (var item in cocuklar)
        {
            Debug.Log(item);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
