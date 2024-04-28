using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //bonton mu menu "New Game"
    public void NewGame(){
        SceneManager.LoadScene("Level 1");
    }
    //bouton du menu "Quit"
    public void Quit(){
        Application.Quit();
    }
}
