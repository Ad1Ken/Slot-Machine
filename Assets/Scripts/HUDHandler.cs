using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDHandler : MonoBehaviour
{
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject GameOverPanel;

    private void Start()
    {
        ActiveGameState(HUDstate.Menu);
    }

    private void ActiveGameState(HUDstate state)
    {
        if (state == HUDstate.Menu)
        {
            MenuPanel.SetActive(true);
            MainPanel.SetActive(false);
            GameOverPanel.SetActive(false);

        }
        else if (state == HUDstate.Game)
        {
            MainPanel.SetActive(true);
            MenuPanel.SetActive(false);
        }
        else
            GameOverPanel.SetActive(true);
    }


    public void OnClickPlay()
    {
        ActiveGameState(HUDstate.Game);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickReturn()
    {
        ActiveGameState(HUDstate.Menu);
        Clean();
    }

    
    public void Clean()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Game");
        
    }

}
