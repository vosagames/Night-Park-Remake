using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public GameObject newgame;
    public GameObject oldgame;
    public GameObject newwarrning;
    public GameObject Oldwarrning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(JoJo.newgame == true)
        {
            newgame.SetActive(false);
            oldgame.SetActive(true);
            newwarrning.SetActive(true);
            Oldwarrning.SetActive(false);
        }
        if (JoJo.newgame == false)
        {
            newgame.SetActive(true);
            oldgame.SetActive(false);
            newwarrning.SetActive(false);
            Oldwarrning.SetActive(true);
        }
    }
}
