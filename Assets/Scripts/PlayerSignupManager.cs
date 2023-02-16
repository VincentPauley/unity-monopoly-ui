using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerSignupManager : MonoBehaviour
{
    private void OnEnable() {
        VisualElement uiRoot = GetComponent<UIDocument>().rootVisualElement;

        Button homeButton = uiRoot.Q<Button>("HomeButton");

        homeButton.clicked += () => clicked();
    }

    private void clicked() {
        Debug.Log("I called something!");


        SceneManager.enterHomeScene();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleHomeRequest() {
        Debug.Log("I want to go home!");
    }
}
