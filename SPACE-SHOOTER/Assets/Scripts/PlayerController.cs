using System;
using System.Collections;
using System.Collections.Generic;

using UnityEditor.Experimental.GraphView;

using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] float speed = 10.0f;
    private float leftBoundX = -2.89f;
    private float rightBoundX = 2.89f;

    // Start is called before the first frame update
    void Start() {
        playerRb = GetComponent<Rigidbody2D>();

        }

    // Update is called once per frame
    void Update() {
      
        PlayerMovment();
         }


    // method for ship movment
    public void PlayerMovment() {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            //gets playerRb pos  then adds the vector2(-1,0) to the playerRb position
            playerRb.MovePosition(playerRb.position + Vector2.left * speed * Time.deltaTime);

            // stops play leving the left of game area setting the playerRb to leftBound.X
            if(playerRb.position.x < leftBoundX) {
                playerRb.position = playerRb.position;
                }
            }

        else if(Input.GetKey(KeyCode.RightArrow)) {
            playerRb.MovePosition(playerRb.position + Vector2.right * speed * Time.deltaTime);

            if(playerRb.position.x > rightBoundX) {
                playerRb.position = playerRb.position;
                }
            }
        }

      


    }



