using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInteraction : MonoBehaviour
{
public  new GameObject camera;
public float interactionDistance = 10f;
public static bool canPickUp = false;

GameObject currentInteract;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
        if (Input.GetKeyDown(KeyCode.Q)) Drop();
    }

//Поднятие предмета 
void PickUp()
{
    RaycastHit hit; 
if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, interactionDistance))
    {
    
        if (hit.transform.tag == "Interactive")
        {
           if (canPickUp) Drop();
              currentInteract = hit.transform.gameObject;
              currentInteract.GetComponent<Rigidbody>().isKinematic = true;
              currentInteract.transform.parent = transform;
              currentInteract.transform.localPosition = Vector3.zero;
              currentInteract.transform.localEulerAngles = new Vector3(0f, -40f, 0f);
              canPickUp = true;
        
      
        }
    }
    
}

 public void Drop()
    {
        currentInteract.transform.parent = null;
        currentInteract.GetComponent<Rigidbody>().isKinematic = false;
        canPickUp = false;
        currentInteract= null;
    }
}

