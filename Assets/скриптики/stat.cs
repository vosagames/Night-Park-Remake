using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class stat : MonoBehaviour
{
    public GameObject procent1;
    public GameObject procent2;
    public GameObject procent3;
    public GameObject procent4;
    public GameObject procent5;
    public int minus;
    public TMP_Text cifri;
    private Component JoJo;
    [SerializeField] private TMP_Text energyYG;
    [SerializeField] private GameObject Light;
    [SerializeField] private AudioSource SoundPowerOff;
    [SerializeField] private GameObject BlackDisplay;

 

    // Start is called before the first frame upda
    void Start()
    {
        JoJo = FindAnyObjectByType<JoJo>();
        StartCoroutine(_1());
        cifri.text = $"{energyYG.text}: {JoJo.GetComponent<JoJo>().zarad}%";

    }
 
    IEnumerator _1()
    {
        while(true)
        {
            yield return new WaitForSeconds(JoJo.GetComponent<JoJo>().wait);
            JoJo.GetComponent<JoJo>().zarad -= minus;
            cifri.text = $"{energyYG.text}: {JoJo.GetComponent<JoJo>().zarad}%";
            if (JoJo.GetComponent<JoJo>().zarad == 80)
            {
                procent5.SetActive(false);
            }
            if (JoJo.GetComponent<JoJo>().zarad == 60)
            {
                procent4.SetActive(false);
            }
            if (JoJo.GetComponent<JoJo>().zarad == 40)
            {
                procent3.SetActive(false);
            }
            if (JoJo.GetComponent<JoJo>().zarad == 20)
            {
                procent2.SetActive(false);
            }
            if (JoJo.GetComponent<JoJo>().zarad == 0)
            {
                procent1.SetActive(false);
                minus = 0;
                LightOff();
                Component Camera = FindObjectOfType<cameraman>();
                Camera.GetComponent<cameraman>().CloseCam();
                Component Player = FindObjectOfType<player>();
                if(Player == null)
                {
                    Invoke("PlayerPowerFalse", 1.001f);
                }
                else
                {
                    Player.GetComponent<player>().power = false;
                }
                Invoke("PlayerPowerFalse", 1.001f);
                Component Door = FindObjectOfType<dver>();
                Door.GetComponent<dver>().CloseDoor();
                Component Vent = FindObjectOfType<vent>();
                Vent.GetComponent<vent>().CloseVent();
                StopAllCoroutines();
            }


        }
       
    }

    private void PlayerPowerFalse()
    {
        Component Player = FindObjectOfType<player>();
        Player.GetComponent<player>().power = false;
    }
    private void LightOff()
    {
        Destroy(Light);
        SoundPowerOff.Play();
        BlackDisplay.SetActive(true);
    }

}




