using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalButton : MonoBehaviour
{
   public GameObject Ticket;
  
    //Создания талона
    public void SpawnTicket()
    {
      Instantiate(Ticket, new Vector3(-469f,37f,77f),  Quaternion.Euler(0.9f,356f,275f));
    }
}
