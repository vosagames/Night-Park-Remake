using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagment : MonoBehaviour
{
    // Start is called before the first frame update12
    void Start()
    {
        
    }

    // Update is calledtrtrgfffgfg
    void Update()
    {
        
    }
    public void Perehod()
    {
        SceneManager.LoadScene(5);
    }
    public void Loading()
    {
        Invoke("Perehod", 5f);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void end1()
    {
        SceneManager.LoadScene(2);
    }
    public void end2()
    {
        SceneManager.LoadScene(3);
    }
    public void setting()
    {
        Invoke("level", 4f);
    }
    public void level()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void skimer()
    {
        Invoke("Menu", 1.1f);
    }
    
}
