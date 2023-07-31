using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour, IInteractable
{


   public string GetDescription()
    {
        return "Нажмите [E] чтобы воспользоваться терминалом";
    }
    
    public void Interact()
    {
      if (Cursor.lockState == CursorLockMode.Locked)
        Cursor.lockState = CursorLockMode.Confined;
        else 
        Cursor.lockState = CursorLockMode.Locked;
      
    }
}
