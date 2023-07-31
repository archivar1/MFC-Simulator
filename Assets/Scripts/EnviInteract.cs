using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnviInteract : MonoBehaviour
{

    public Camera mainCam;
    public float interactionDistance = 15f;
    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;
   

    void Update()
    {
        
        InteractionRay();
    }
// Поиск интерактивных объектов
    void InteractionRay()
    {
       
        Ray ray = mainCam.ViewportPointToRay(Vector3.one/2f);
        RaycastHit hit;
        bool hitsometing = false;
        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable!= null)
            {
                hitsometing = true;
                interactionText.text = interactable.GetDescription();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                    hitsometing = false;
                    
                }
              
            }
             
        }
       
      interactionUI.SetActive(hitsometing);
    }
}
