using System.Collections;
using Photon.Pun;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourPunCallbacks
{
    #region Singleton

    public static GameManager instance;

    private void Awake()
    {
        // Verifica se a instância é nula
        if (instance == null)
        {
            instance = this; // Define a instância para este objeto
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destroi o objeto se já houver uma instância existente
        }
    }
    #endregion

    const string playerPrefabPath = "Prefabs/Player";

    int playerInGame;
    List<PlayerController> playerList = new List<PlayerController>();
    PlayerController playerLocal;

    private void Start()
    {
        photonView.RPC("AddPlayer", RpcTarget.AllBuffered);
    }

    // Update is called once per frame
    private void CreatePlayer()
    {
        PlayerController player = PhotonNetwork.Instantiate(playerPrefabPath, new Vector3(30, 1, 30), Quaternion.identity).GetComponent<PlayerController>();
    }
    
    [PunRPC]
    private void AddPlayer()
    {
        playerInGame++;
        if (playerInGame == PhotonNetwork.PlayerList.Length) 
        { 
            CreatePlayer(); 
        }
    }
}
