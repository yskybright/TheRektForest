using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject GoLobbyBtn;
    public GameObject GameIntroBtn;
    public GameObject SettingBtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickGoLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
