using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrickManager : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    public static CrickManager Instance;

    public int scoreCount;
    public int totalInning;
    #endregion

    #region PRIVATE_PROPERTIES
    #endregion

    #region UNITY_CALLBACKS
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines

    #endregion
}
