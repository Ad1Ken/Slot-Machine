using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrickUIManager : BaseView
{
    public static CrickUIManager Instance;
    #region PUBLIC_PROPERTIES
    public CrickGameView panelGameView;
    public CrickLobbyView panelLobbyView;
    public CrickMainMenuView panelMainMenuView;
    public CrickRoomView panelRoomView;
    #endregion

    #region PRIVATE_PROPERTIES
    private void Start()
    {
        Instance = this;
    }
    #endregion

    #region UNITY_CALLBACKS
    #endregion

    #region PUBLIC_METHODS
    public void HideAllView()
    {
        panelGameView.HideView();
        panelLobbyView.HideView();
        panelMainMenuView.HideView();
        panelRoomView.HideView();
    }
    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines

    #endregion
}
