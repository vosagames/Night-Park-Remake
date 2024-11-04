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
    [SerializeField]
    private AudioSource ClickSound, CamSound;

    private bool RightMove = true;
    private bool LeftMove = true;
    private Vector3 mousePos;

    public bool LeftMoveButtonPress = false;
    public bool RightMoveButtonPress = false;

    public bool power = true;

    private bool isTouch;
    private Touch touch;

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
        if (YandexGame.EnvironmentData.isMobile)
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                mousePos = touch.position;

                // ѕровер€ем, произошло ли касание
                if (touch.phase == TouchPhase.Began)
                {
                    Ray ray = Camera.main.ScreenPointToRay(mousePos);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit, 100f))
                    {
                        Tap(hit);
                        Debug.Log(" асание на мобильном устройстве");
                    }
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    isTouch = false;
                    Debug.Log($"{isTouch} палец оторван");
                }
            }
        }
        else if (YandexGame.EnvironmentData.isDesktop)
        {
            mousePos = Input.mousePosition;

            // ѕровер€ем, произошло ли нажатие мыши
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(mousePos);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f))
                {
                    Tap(hit);
                    Debug.Log(" лик на десктопе");
                }
            }
        }



        if (LeftMoveButtonPress == true)
        {
            HeadMoveLeft();
        }

        if (RightMoveButtonPress == true)
        {
            HeadMoveRight();
        }



        if (Input.GetKey(KeyCode.A)) //  ну тут всЄ пон€тно
        {
            HeadMoveLeft();
        }
        if (Input.GetKey(KeyCode.D)) // точно такой же метод как и прошлые но немного отличаетс€
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
        if (RightMove == true)
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
    private void Tap(RaycastHit hit)
    {
        if (hit.collider.gameObject.CompareTag("ButtonDoor"))
        {
            ClickSound.Play();
            if (power == true)
            {
                Component door = FindObjectOfType<dver>();
                door.GetComponent<dver>().OpenCloseDoor();
                Debug.Log("Door");
            }
        }
        if (hit.collider.gameObject.CompareTag("ButtonVent"))
        {
            ClickSound.Play();
            if (power == true)
            {
                Component _vent = FindObjectOfType<vent>();
                _vent.GetComponent<vent>().CloseOpenVent();
                Debug.Log("Vent");
            }

        }
        if (hit.collider.gameObject.CompareTag("ButtonCam"))
        {
            CamSound.Play();
            if (power == true)
            {
                Component _cam = FindObjectOfType<cameraman>();
                _cam.GetComponent<cameraman>().CloseOpenCam();
                Debug.Log("Cam");
            }

        }
    }
}
    
