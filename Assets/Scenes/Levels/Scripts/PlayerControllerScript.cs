using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    CharacterController controller;
    float moveSpeed = 10f;
     void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        controller.Move(move * Time.deltaTime * moveSpeed);
    }

}   
