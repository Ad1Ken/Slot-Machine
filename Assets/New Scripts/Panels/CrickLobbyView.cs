using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class CrickLobbyView : MonoBehaviourPunCallbacks
{
    #region PUBLIC_PROPERTIES
    public TMP_InputField inputRoomName;
    public Transform content;

    public CrickRoomItem roomItemPrefab;
    public List<CrickRoomItem> roomItemsList = new List<CrickRoomItem>();
    #endregion

    #region PRIVATE_PROPERTIES
    #endregion

    #region UNITY_CALLBACKS
    public void Start()
    {
        //ConnectToServer.instance.JoinPlayerLobby();
        PhotonNetwork.JoinLobby();
    }
    #endregion

    #region PUBLIC_METHODS
    public void UpdateRoomList(List<RoomInfo> list)
    {
        foreach(CrickRoomItem item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();
        foreach(RoomInfo room in list)
        {
            CrickRoomItem newRoom = Instantiate(roomItemPrefab, content);
            newRoom.SetRoomName(room.Name);
            roomItemsList.Add(newRoom); 
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public  void ShowView()
    {
        gameObject.SetActive(true);
    }

    public  void HideView()
    {
        gameObject.SetActive(false);
    }
    
    #endregion

    #region PRIVATE_METHODS
    #endregion

    #region DELEGTE_CALLBACKS
    #endregion

    #region Coroutines

    #endregion
}
