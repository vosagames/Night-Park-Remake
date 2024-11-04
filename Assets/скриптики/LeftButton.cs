using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool Right = false;

   public void OnPointerDown(PointerEventData eventData) 
    {
        if(Right == true)
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().RightMoveButtonPress = true;
        }
        else
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().LeftMoveButtonPress = true;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (Right == true)
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().RightMoveButtonPress = false;
        }
        else
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().LeftMoveButtonPress = false;
        }
    }

    private void OnDisable()
    {
        if (Right == true)
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().RightMoveButtonPress = false;
        }
        else
        {
            GameObject Player = FindObjectOfType<player>().gameObject;
            Player.GetComponent<player>().LeftMoveButtonPress = false;
        }
    }
}
