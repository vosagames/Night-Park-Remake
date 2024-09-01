using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vent : MonoBehaviour
{
    public Animator anim;
    private bool Close = false;

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
        
        if(JoJo.GetComponent<JoJo>().vent == true)
        {
            anim.SetBool("opening", true);
        }
        if(JoJo.GetComponent<JoJo>().vent == false)
        {
            anim.SetBool("opening", false);
        }

        
    }

    public void CloseOpenVent()
    {
        if (Close == false)
        {
            OpenVent();
            Close = true;
        }
        else
        {
            CloseVent();
            Close = false;
        }
 
    }

    public void OpenVent()
    {

        JoJo.GetComponent<JoJo>().vent = true;
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
    public void CloseVent()
    {


        JoJo.GetComponent<JoJo>().vent = false;
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
