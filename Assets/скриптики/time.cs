using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using YG;


public class time : MonoBehaviour
{
    public TMP_Text time1;
    [SerializeField] private TMP_Text timeYG;

    private Component JoJo;
    void Start()
    {
        JoJo = FindAnyObjectByType<JoJo>();
        StartCoroutine(_1());
        time1.text = $"{timeYG.text}: {JoJo.GetComponent<JoJo>().times} PM";
    }
    IEnumerator _1()
    {
        while (true)
        {
            yield return new WaitForSeconds(60f);
            JoJo.GetComponent<JoJo>().times += 1;
            time1.text = $"{timeYG.text}: {JoJo.GetComponent<JoJo>().times} PM";
            if (JoJo.GetComponent<JoJo>().times == 6)
            {
                switch(SaveNight.numberNight)
                {
                    case 1:
                        {
                            YandexGame.savesData.Level1 = true;
                            YandexGame.SaveProgress();
                            Component killer = FindObjectOfType<killer>();
                            killer.GetComponent<killer>().enabled = false;
                            Invoke("LoadMenu", 5f);
                        }
                        break;
                    case 2:
                        {
                            YandexGame.savesData.Level2 = true;
                            YandexGame.SaveProgress();
                            Component killer = FindObjectOfType<killer>();
                            killer.GetComponent<killer>().enabled = false;
                            Invoke("LoadMenu", 5f);
                        }
                        break;
                    case 3:
                        {
                            YandexGame.savesData.Level3 = true;
                            YandexGame.SaveProgress();
                            Component killer = FindObjectOfType<killer>();
                            killer.GetComponent<killer>().enabled = false;
                            Invoke("Final", 5f);
                        }
                        break;
                }
            }

        }
    }

    private void LoadMenu() => SceneManager.LoadScene(0);

    private void Final() => SceneManager.LoadScene(3);

}