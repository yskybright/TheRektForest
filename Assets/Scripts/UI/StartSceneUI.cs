using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject GameDescription;
    public GameObject StartSceneButtons;


    public void OnClickGameDesc()
    {
        StartSceneButtons.SetActive(false);
        GameDescription.SetActive(true);
    }

    public void OnClickGoLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void OnClickQuit()
    {
        GameDescription.SetActive(false);
        StartSceneButtons.SetActive(true);
    }

}
