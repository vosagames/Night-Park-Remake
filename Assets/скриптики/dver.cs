using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dver : MonoBehaviour
{
    public Animator anim;

    private bool InputQ = false;
    private bool wait = false;
    private Component JoJo;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        JoJo = FindAnyObjectByType<JoJo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && InputQ == false && wait == false)
        {
            OpenDoor();
        }
        if (Input.GetKeyDown(KeyCode.Q) && InputQ == true && wait == false)
        {
            CloseDoor();    
        }

        if (JoJo.GetComponent<JoJo>().dver == false)
            anim.SetBool("openin", false);
       

        if (JoJo.GetComponent<JoJo>().dver == true)
            anim.SetBool("openin", true);

        
    }

    private void Wait() => wait = false;

    public void OpenDoor()
    {
        wait = true;
        InputQ = true;
        Invoke("Wait", 0.1f);
        JoJo.GetComponent<JoJo>().dver = true;
        if (JoJo.GetComponent<JoJo>().dver == false && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 5;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == true)
        {
            JoJo.GetComponent<JoJo>().wait = 3;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 4;
        }
        if (JoJo.GetComponent<JoJo>().vent == true && JoJo.GetComponent<JoJo>().dver == false)
        {
            JoJo.GetComponent<JoJo>().wait = 4;
        }
    }
    public void CloseDoor()
    {
        wait = true;
        InputQ = false;
        Invoke("Wait", 0.1f);
        JoJo.GetComponent<JoJo>().dver = false;
        if (JoJo.GetComponent<JoJo>().dver == false && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 5;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == true)
        {
            JoJo.GetComponent<JoJo>().wait = 3;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 4;
        }
        if (JoJo.GetComponent<JoJo>().vent == true && JoJo.GetComponent<JoJo>().dver == false)
        {
            JoJo.GetComponent<JoJo>().wait = 4;
        }
    }
   
    
}
