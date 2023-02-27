using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void SwitchScene(int _sceneIndex)
    {
        //SceneManager.LoadScene(_sceneIndex);

        SceneManager.LoadScene(_sceneIndex);
    }


    public void SideLoadScene(string _sceneIndex)
    {
        SceneManager.LoadSceneAsync(_sceneIndex, LoadSceneMode.Additive);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game quitted");
    }

}
