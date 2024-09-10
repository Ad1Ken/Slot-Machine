using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class SlotGameView : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    public List<TextMeshProUGUI> slotTexts = new List<TextMeshProUGUI>();
    public List<PlayerCardInfo> playerCards;
    #endregion

    #region PRIVATE_PROPERTIES
    [SerializeField]private PlayerCardInfo playerCardInfoPrefab;
    [SerializeField] private InningCard inningCardPrefab;
    [SerializeField]private Transform playerCardHolder;
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
        StopCoroutine(StartMachine());
        //scoreCount = 
    }
    #endregion

    #region PRIVATE_METHODS
    private void InstantiatePlayerCards()
    {
        PlayerCardInfo player = Instantiate(playerCardInfoPrefab, playerCardHolder);
        playerCards.Add(player);

    }

    private void InstantiateInningCards()
    {

    }
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines
    private IEnumerator StartMachine()
    {
        while (true)
        {
            for (int i = 0; i < slotTexts.Count; i++)
            {
                int randNum = UnityEngine.Random.Range(0, 10);
                Debug.Log(randNum);
                slotTexts[i].text = randNum.ToString();

            }
        }
    }
    #endregion

}
