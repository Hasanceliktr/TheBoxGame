using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

namespace ServerManage
{
    public class ServerManage : MonoBehaviourPunCallbacks
    {

        void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("Server is connected.");
            PhotonNetwork.JoinLobby();
        }

        public override void OnJoinedLobby()
        {
            Debug.Log("Lobby is connected.");

        }

        public void RandomJoined()
        {
            PhotonNetwork.JoinRandomRoom();
        }

        public void CreateRoomJoined()
        {
            string roomName = Random.Range(0, 99999).ToString();
            PhotonNetwork.JoinOrCreateRoom(roomName, new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        }

        public override void OnLeftRoom()
        {
            //Odadan çýkýldýðýnda yapýlmasý gerekenler.
        }

        public override void OnLeftLobby()
        {
            //Lobiden çýkýldýðýnda yapýlmasý gerekenler.
        }

        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            //Odadan oyuncu ayrýlýnca yapýlacak iþlemler.

        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            //Oda oluþturulurken olabilecek hatalar.
        }

        public override void OnJoinRoomFailed(short returnCode, string message)
        {
            //Random odaya katýlýnamazsa alýnacak hata.
        }

    }
}

