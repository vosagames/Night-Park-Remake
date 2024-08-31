using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killer : MonoBehaviour
{
    public GameObject kil1;
    public GameObject kil2;
    public GameObject kil3;
    public GameObject kil4;
    public GameObject kil5;
    public GameObject kil6;
    public GameObject kil7;
    public GameObject kil8;
    public GameObject kil9;
    public GameObject kil10;
    public GameObject samaipervi;
    public int randomspawn = 15;
    public int kilspawn;
    public bool dver;
    public bool vent;
    public GameObject player;
    public GameObject playerskrim;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cameraanim;
    public GameObject canvas;
    public AudioSource kapysta;
    private Component JoJo;



    public void Update()
    {
        dver = JoJo.GetComponent<JoJo>().dver;
        vent = JoJo.GetComponent<JoJo>().vent;
    }

    // Start is called before the first frame update
    void Start()
    {
        JoJo = FindAnyObjectByType<JoJo>();
        StartCoroutine(spawn());
        kapysta = GetComponent<AudioSource>();
    }
    void _3()
    {
        kapysta.Play();
    }
    void _4()
    {

        SceneManager.LoadScene(3);
    }
    void _1()
    {
        if (JoJo.GetComponent<JoJo>().dver == false)
        {
            playerskrim.SetActive(true);
            player.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            Debug.Log("напугал");
            cam8.SetActive(false);
            cameraanim.SetActive(false);
            Invoke("_3", 0.1f);
            Invoke("_4", 1.1f);

            

        }
    }
    void _2()
    {
        if (JoJo.GetComponent<JoJo>().vent == false)
        {
            playerskrim.SetActive(true);
            player.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            Debug.Log("напугал из вентиляции");
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cameraanim.SetActive(false);//123
            Invoke("_3", 0.1f);
            Invoke("_4", 1.1f);
        }
    }

    // Update is called once per fram

    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(randomspawn);
            kilspawn = Random.Range(0, 12);
            switch (SaveNight.numberNight)
            {
                case 1:
                    {
                        randomspawn = Random.Range(9, 30);
                    }
                    break;
                case 2:
                    {
                        randomspawn = Random.Range(9, 20);
                    }
                    break;
                case 3:
                    {
                        randomspawn = Random.Range(8, 15);
                    }
                    break;
            }
            if (kilspawn == 1)
            {
                kil1.SetActive(true);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 2)
            {
                kil1.SetActive(false);
                kil2.SetActive(true);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 3)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(true);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 4)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(true);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 5)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(true);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 6)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(true);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 7)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(true);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 8)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(true);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(false);

            }
            if (kilspawn == 9)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(true);
                kil10.SetActive(false);
                samaipervi.SetActive(false);
                if(JoJo.GetComponent<JoJo>().vent == false)
                {
                    Invoke("_2", 8f);
                }
                

            }
            if (kilspawn == 10)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(true);
                samaipervi.SetActive(false);
                if(JoJo.GetComponent<JoJo>().dver == false)
                {
                    Invoke("_1", 8f);
                }
                

            }
            if (kilspawn == 11)
            {
                kil1.SetActive(false);
                kil2.SetActive(false);
                kil3.SetActive(false);
                kil4.SetActive(false);
                kil5.SetActive(false);
                kil6.SetActive(false);
                kil7.SetActive(false);
                kil8.SetActive(false);
                kil9.SetActive(false);
                kil10.SetActive(false);
                samaipervi.SetActive(true);

            }
        }
        
        
            
        




    }
    

}
