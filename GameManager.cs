using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Singleton pattern used for the Game Manager

    // this field is used to store the reference for GameManager in the current scene
    private static GameManager instance;
    // public property for other scripts to find the Game Manager
    public static GameManager Instance 
    {
        get 
        {
            // if we don't have the GameManager reference stored yet, find it from the scene
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }

            // if we still don't have the reference, it means there is no GameManager present in the scene
            if (instance == null)
            {
                Debug.LogError("No Game Manager found!");
            }

            return instance;
        }
    }

    // this field is used to store the reference to the player script
    private Player player;
    // public property for other scripts to find the player script
    public Player Player 
    {
        get
        {
            // if we don't have the Player reference stored yet, find it from the scene
            if (player == null)
            {
                player = FindObjectOfType<Player>();
            }

            // if we still don't have the Player reference, it means there is no Player present in the Scene
            if (player == null)
            {
                Debug.LogError("No player found in the scene!");
            }

            return player;
        }
    }

    // initialization 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Debug.LogError("Multiple Game Managers found in the scene!");
                Destroy(this);
            }
        }
    }

    // a public method other scripts can call when something happens in the game
    // by calling GameManager.Instance.CoinCollected();
    public void CoinCollected()
    {
        Player.PlayCoinCollectedAnimation();
    }



}
