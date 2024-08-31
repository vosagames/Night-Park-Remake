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

            }


        }
       
    }
}




