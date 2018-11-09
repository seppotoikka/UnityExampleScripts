using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// RequireComponent attribute can be used to make sure that all necessary
// components are added to the GameObject
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour {

    // This method is called by Unity when something enters the trigger collider
    // of the GameObject this script is attached to
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.CoinCollected();
        Destroy(gameObject);
    }
}
