using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dver : MonoBehaviour
{
    public Animator anim;

    private bool Close;
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
       
        if (JoJo.GetComponent<JoJo>().dver == false)
            anim.SetBool("openin", false);
       
        if (JoJo.GetComponent<JoJo>().dver == true)
            anim.SetBool("openin", true);
    
    }


    public void OpenCloseDoor()
    {
        if(Close == false)
        {
            OpenDoor();
            Close = true;
        }
        else
        {
            CloseDoor();
            Close = false;
        }
    }

    public void OpenDoor()
    {

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
