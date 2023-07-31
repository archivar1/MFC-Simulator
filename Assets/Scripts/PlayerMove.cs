using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float speed= 10f;
public CharacterController controller;
  

    //Перемещение
    private void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
      Vector3 move  = transform.right * x + transform.forward * z;
      controller.Move(move*speed*Time.deltaTime);

    }
}
