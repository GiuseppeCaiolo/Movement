using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allMovement : MonoBehaviour
{
	public CharacterController player;
	private float speed = 20f;
	private float moveX,moveZ;
	private Vector3 move;
	
    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        move = transform.right * moveX + transform.forward * moveZ;
        player.Move(move);
    }
}
