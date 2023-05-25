using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public TMP_InputField inputPlayer;

    public void StartGame()
    {
        PlayerPrefs.SetString("Name", inputPlayer.text);
        SceneManager.LoadScene("main");
    }
}
