using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class cameraman : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public GameObject camerascene;
    public GameObject Canvas;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;

    private Component JoJo;
    private bool wait;

    public int value;

    private bool InputSpace = false;

    private bool Close = false;

    // Start is called before the first frame update
    void Start()
    {
        JoJo = FindAnyObjectByType<JoJo>();
        anim = GetComponent<Animator>();
    }

    public void CloseOpenCam()
    {
        if(Close == false)
        {
            OpenCam();
            Close = true;
        }
        else
        {
            CloseCam();
            Close = false;
        }
    }
    void nazad()
    {
        player.SetActive(true); 
    }
    void cameraactiv()
    {
        GameObject _control = FindObjectOfType<control>().gameObject;
        _control.GetComponent<control>().CamMenu(value);
        Canvas.SetActive(true);
    }
    public void CloseCam()
    {
        Canvas.SetActive(false);
        camerascene.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);
        anim.SetBool("cameraon", false);
        Invoke("nazad", 1.001f);
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
    public void OpenCam()
    {
        anim.SetBool("cameraon", true);
        player.SetActive(false);
        Invoke("cameraactiv", 1.001f);
        if(JoJo.GetComponent<JoJo>().dver == false && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 4;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == true)
        {
            JoJo.GetComponent<JoJo>().wait = 2;
        }
        if (JoJo.GetComponent<JoJo>().dver == true && JoJo.GetComponent<JoJo>().vent == false)
        {
            JoJo.GetComponent<JoJo>().wait = 3;
        }
        if (JoJo.GetComponent<JoJo>().vent == true && JoJo.GetComponent<JoJo>().dver == false)
        {
            JoJo.GetComponent<JoJo>().wait = 3;
        }
    }

    private void Wait() => wait = false;
}
