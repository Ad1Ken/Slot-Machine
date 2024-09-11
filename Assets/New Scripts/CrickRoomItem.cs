using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CrickRoomItem : MonoBehaviour
{
    #region PUBLIC_PROPERTIES
    public TextMeshProUGUI roomName;

    private ConnectToServer connectToServer;
    #endregion

    #region PRIVATE_PROPERTIES
    #endregion

    #region UNITY_CALLBACKS
    private void Start()
    {
        connectToServer = FindObjectOfType<ConnectToServer>();         
    }
    #endregion

    #region PUBLIC_METHODS
    public void SetRoomName(string _roomName)
    {
        roomName.text = _roomName;
    }

    public void OnClickItem()
    {
        connectToServer.JoinRoom(roomName.text);
    }
    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines

    #endregion
}
