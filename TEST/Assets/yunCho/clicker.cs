using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    public void StartButton()
    {
        Invoke("startgame", .3f);
    }

    /* public clicker(int scene_number)
     {
         SceneManager.LoadScene(scene_number);
     }*/

    // Update is called once per frame


    void startgame()
    {
        Application.LoadLevel("Sinops");
        
    }
}
