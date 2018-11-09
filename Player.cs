using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attribute RequireComponent to make sure that the GameObject has a Rigidbody2D,
// because the script is using it in FixedUpdate()
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    // this method is called by Unity every time just before physics are updated
    // if a GameObject has a rigidbody and a collider, write movement logic in
    // FixedUpdate
    private void FixedUpdate()
    {
        // movement left and right
        GetComponent<Rigidbody2D>().position += Input.GetAxis("Horizontal") * Vector2.right;
    }


    // a public method that other scripts (for example, GameManager) can call
    public void PlayCoinCollectedAnimation()
    {

    }

}
