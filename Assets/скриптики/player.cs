using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Loading;
using UnityEngine;
using YG;

public class player : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Transform minAngle, maxAngle;
    [SerializeField]
    private TMP_Text night;

    private bool RightMove = true;
    private bool LeftMove = true;

    private void Start()
    {
        night.text = $"{night.text} {SaveNight.numberNight}";
        Save();
    }
    private void Save()
    {
        YandexGame.savesData.NumberNight = SaveNight.numberNight;
        YandexGame.SaveProgress();
    }

    // Update is called once per fram
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) //  ну тут всё понятно
        {
            HeadMoveLeft();
        }
        if(Input.GetKey(KeyCode.D)) // точно такой же метод как и прошлые но немного отличается
        {
            HeadMoveRight();
        }
        Debug.Log(gameObject.transform.rotation.y);
        if (transform.rotation.y <= minAngle.rotation.y)
        {
            LeftMove = false;
        }
        else
        {
            LeftMove = true;
        }

        if (transform.rotation.y >= maxAngle.rotation.y)
        {
            RightMove = false;
        }
        else
        {
            RightMove = true;
        }
    }
    public void HeadMoveRight()
    {
        if(RightMove == true)
        {
            gameObject.transform.Rotate(0, speed * Time.deltaTime, 0);
        }
    }
    public void HeadMoveLeft() 
    {
        if (LeftMove == true)
        {
            gameObject.transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
    }
}
