using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Scene0");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
