using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    private GameObject obj;
    //Удаление нпс при коллизии с триггером
    public void OnTriggerEnter(Collider obj)
    {
           if(obj.tag == "Queue")
           {
            Destroy(obj.gameObject);
           }
         
    }
}
