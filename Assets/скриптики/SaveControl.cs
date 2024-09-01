using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using YG;

public class SaveControl : MonoBehaviour
{
    [SerializeField] private GameObject ButtonNewGame, ButtonContinue;
    [SerializeField] private TMP_Text textNumberNight, textNumberNight2;
    [SerializeField] private GameObject youWIN1, youWIN2, youWIN3;
    [SerializeField] private GameObject NewLevel1;
    private void OnEnable() => YandexGame.GetDataEvent += Load;
    private void OnDisable() => YandexGame.GetDataEvent -= Load;

    private bool Level1, Level2, Level3;


    void Start()
    {
        Load();
    }
    public void _NextLevel()
    {
        YandexGame.ResetSaveProgress();
        SaveNight.numberNight++;
        YandexGame.SaveProgress();
    }
    public void _Continue()
    {
        SaveNight.numberNight++;
    }
    private void Load()
    {
        Level1 = YandexGame.savesData.Level1;
        Level2 = YandexGame.savesData.Level2;
        Level3 = YandexGame.savesData.Level3;
        SaveNight.numberNight = YandexGame.savesData.NumberNight;
        textNumberNight.text = textNumberNight2.text + $" {SaveNight.numberNight}";
        switch (SaveNight.numberNight)
        {
            case 1:
                {
                    if (Level1 == true)
                    {
                        youWIN1.SetActive(true);
                        NewLevel1.SetActive(true);
                    }  
                    else
                        ButtonContinue.SetActive(true);
                }
                break;
            case 2:
                {
                    if (Level2 == true)
                    {
                        youWIN2.SetActive(true);
                        NewLevel1.SetActive(true);
                    }
                    else
                        ButtonContinue.SetActive(true);
                }
                break;
            case 3:
                {
                    if (Level3 == true)
                        youWIN3.SetActive(true);
                    else
                        ButtonContinue.SetActive(true);
                }
                break;
        }
    }
}
public static class SaveNight
{
    public static int numberNight;
}
