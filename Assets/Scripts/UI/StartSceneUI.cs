using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject GameDescription;
    public GameObject StartSceneButtons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
