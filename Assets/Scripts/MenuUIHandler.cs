using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public void SetNameText(string text)
    {
        MainManager.Instance.HighName = text;
    }

    public void StartNew()
    {
        Debug.Log("StartNew");
        SceneManager.LoadScene(0);
    }
}
