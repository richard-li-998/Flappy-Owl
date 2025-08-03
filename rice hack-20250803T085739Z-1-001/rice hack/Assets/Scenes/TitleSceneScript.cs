using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnSkinShopButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitButton()
    {
        Application.Quit();
    }
}
