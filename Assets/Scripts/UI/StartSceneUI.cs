using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public GameObject StartSceneButtons;
    public GameObject Status;
    public GameObject Inventory;

    void Start()
    {
        Status.SetActive(false);
        Inventory.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnClickStatus()
    {
        StartSceneButtons.SetActive(false);
        Status.SetActive(true);
    }

    public void OnClickInventory()
    {
        StartSceneButtons.SetActive(false);
        Inventory.SetActive(true);
    }

    public void OnClickQuit()
    {
        Status.SetActive(false);
        Inventory.SetActive(false);
        StartSceneButtons.SetActive(true);
    }

    public void OnClickDungeon()
    {
        SceneManager.LoadScene("GameScene");
    }

}