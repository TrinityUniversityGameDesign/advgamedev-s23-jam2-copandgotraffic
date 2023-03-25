using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    // Update is called once per frame
    void Update() {
    // Check if the player presses the 'p' key
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Load the specified scene
            SceneManager.LoadScene("WinEvent");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Load the specified scene
            SceneManager.LoadScene("LoseEvent");
        }
    }
}
