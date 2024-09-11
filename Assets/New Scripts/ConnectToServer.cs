using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Newtonsoft.Json;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    //public static ConnectToServer instance;
    #region PUBLIC_PROPERTIES
    #endregion

    #region PRIVATE_PROPERTIES
    #endregion

    #region UNITY_CALLBACKS
    #endregion

    #region PUBLIC_METHODS

    //Panel - MainMenuView
    public void OnClickConnect()
    {
        string playerName = CrickUIManager.Instance.panelMainMenuView.playerUsername.text;
        if (playerName.Length >= 1)
        {
            PhotonNetwork.NickName = playerName;
            PhotonNetwork.ConnectUsingSettings();
        }
    }
    public override void OnConnectedToMaster()
    {
        CrickUIManager.Instance.HideAllView();
        CrickUIManager.Instance.panelLobbyView.ShowView();
    }

    //Panel - LobbyView
    public void OnClickCreate()
    {
        string roomName = CrickUIManager.Instance.panelLobbyView.inputRoomName.text;
        if (roomName.Length >= 1)
        {
            PhotonNetwork.CreateRoom(roomName, new RoomOptions() { MaxPlayers = 6 });
        }
    }
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        CrickUIManager.Instance.panelLobbyView.UpdateRoomList(roomList);
    }
    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    public void JoinPlayerLobby()
    {
        PhotonNetwork.JoinLobby();
    }

    //Panel-RoomView
    public void OnClickLeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
    public override void OnJoinedRoom()
    {
        CrickUIManager.Instance.HideAllView();
        CrickUIManager.Instance.panelRoomView.ShowView();
    }

    public override void OnLeftRoom()
    {
        CrickUIManager.Instance.HideAllView();
        CrickUIManager.Instance.panelLobbyView.ShowView();
    }
    
    #endregion

    #region PRIVATE_METHODS

    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines

    #endregion
}
