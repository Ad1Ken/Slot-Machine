using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlotHandler : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    [SerializeField] private List<Text> txtFields;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreMsg;
    public GameObject endDisplay;
    public GameObject gameDisplay;
    public Button start;
    private int get;

    private bool startClicked;

    private int scoreCount = 0;
    #endregion

    #region PRIVATE_PROPERTIES
    #endregion

    #region UNITY_CALLBACKS
    #endregion

    #region PUBLIC_METHODS
    public void OnClickStart()
    {
        StartCoroutine(StartMachine());
    }

    public void OnClickStop()
    {
        if()
    }
    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines
    private IEnumerator StartMachine()
    {
        while (true)
        {
            for (int i = 0; i < txtFields.Count; i++)
            {
                int randNum = Random.Range(0, 10);
                Debug.Log(randNum);
                txtFields[i].text = randNum.ToString();

            }
        }
    }
    #endregion



    public void Update()
    {
        if (startClicked)
        {
            for (int i = 0; i < txtFields.Count; i++)
            {
                int randNum = Random.Range(0, 10);
                Debug.Log(randNum);
                txtFields[i].text = randNum.ToString();
                
            }
        }
    }

    public void OnClickStart()
    {
        
    }

    public void StopOnClick()
    {
        startClicked = false;
        if (get == 0 || get == 1)
        {
            StartCoroutine(ShowMessage("Bad Luck!!!!", 2));
            start.interactable = false;
            Invoke("EndDisplay", 1);
        }
        if (get == 6)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Woahhh Its a Six!!!!", 2));
            AddScore(get);
        }
        if (get == 4)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Woahhh Its a Four!!!!", 2));
            AddScore(get);
        }
        if (get == 2 || get == 3)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Not Bad!!!!", 2));
            AddScore(get);
        }
        if (get == 5)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Awesome!!!!", 2));
            AddScore(get);
        }
        if (get == 7)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Crusher!!!!", 2));
            AddScore(get);
        }
        if (get == 8)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("Monster!!!!", 2));
            AddScore(get);
        }
        if (get == 9)
        {
            StartCoroutine(TimeoutEndTurnButton());
            StartCoroutine(ShowMessage("GodLike!!!!", 2));
            AddScore(get);
        }
    }

    private void AddScore(int val)
    {
        scoreCount += val;
        scoreText.text = "Score : " + scoreCount.ToString();
    }

    public void EndDisplay()
    {
        gameDisplay.SetActive(false);
        endDisplay.SetActive(true);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        scoreMsg.text = message;
        scoreMsg.enabled = true;
        yield return new WaitForSeconds(delay);
        scoreMsg.enabled = false;
    }

    IEnumerator TimeoutEndTurnButton()
    {
        start.interactable = false;
        yield return new WaitForSeconds(1.5f);
        start.interactable = true;
    }
}

