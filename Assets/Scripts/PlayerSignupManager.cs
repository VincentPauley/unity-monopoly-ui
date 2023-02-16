using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerSignupManager : MonoBehaviour
{
    private void OnEnable() {
        VisualElement uiRoot = GetComponent<UIDocument>().rootVisualElement;

        Button homeButton = uiRoot.Q<Button>("HomeButton");

        homeButton.clicked += () => HandleHomeRequest();

        TextField playerEntry = uiRoot.Q<TextField>("PlayerEntry");

        playerEntry.style.opacity = 100; // dis makes it show up!!!!
    }

    private void HandleHomeRequest() {
        SceneManager.enterHomeScene();
    }
}
