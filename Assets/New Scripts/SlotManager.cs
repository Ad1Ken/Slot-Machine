using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    public static SlotManager Instance;

    public int scoreCount;
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
