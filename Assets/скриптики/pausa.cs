using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{
    public GameObject dospi;
    public bool hospi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && hospi == false)
        {
            dospi.SetActive(true);
            hospi = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && hospi == true)
        {
            dospi.SetActive(false);
            hospi = false;
        }


    }
}
