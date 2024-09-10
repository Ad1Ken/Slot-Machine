using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCardInfo : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI totalScore;
    public List<InningCard> totalInnings;
   
    public Transform inningsHolder;
    #endregion

    #region PRIVATE_PROPERTIES
    private int currentScore;
    #endregion

    #region UNITY_CALLBACKS
    #endregion

    #region PUBLIC_METHODS
    public void SetName(string name)
    {
        playerName.text = name;
    }

    public void SetTotalScore()
    {

    }

    public void SetInningScore(int currentInning, int score )
    {
        currentScore += score;
        totalInnings[currentInning].scoreText.text = currentScore.ToString();
    }
    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines
    #endregion
}
