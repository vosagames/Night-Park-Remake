using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vent : MonoBehaviour
{
    public Animator anim;

    private bool wait = false;
    private bool InputE = false;
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
        if(Input.GetKeyDown(KeyCode.E) && InputE == false && wait == false)
        {
            OpenVent();
            
        }
        if(Input.GetKeyDown(KeyCode.E) && InputE == true && wait == false)
        {
            CloseVent();
        }
        if(JoJo.GetComponent<JoJo>().vent == true)
        {
            anim.SetBool("opening", true);
        }
        if(JoJo.GetComponent<JoJo>().vent == false)
        {
            anim.SetBool("opening", false);
        }

        
    }
    private void Wait() => wait = false;

    public void OpenVent()
    {
        wait = true;
        InputE = true;
        Invoke("Wait", 0.1f);
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
        wait = true;
        InputE = false;
        Invoke("Wait", 0.1f);
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
