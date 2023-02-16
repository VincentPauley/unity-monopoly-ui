using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void enterPlayScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlayerSignup");
    }

    public static void enterHomeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }
}
