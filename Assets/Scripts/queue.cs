using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queue : MonoBehaviour
{
   private GameObject mQueue;
   public static bool QueueOn = false;
//Проверка на наличе или отсутсвтия очереди
    public void OnTriggerStay(Collider mQueue)
    {
            if (mQueue.gameObject.tag == "Queue")
            {
            QueueOn = true;
            Debug.Log("В очереди есть люди");
            }
    }
    
    public void OnTriggerExit(Collider mQueue)
    {
            if (mQueue.gameObject.tag == "Queue")
            {
            QueueOn = false;
            Debug.Log("В очереди есть люди");
            }
    }

}
