using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class MFCworker : MonoBehaviour, IInteractable
{

public  GameObject interactionUI;
   public GameObject Doc;
 public TextMeshProUGUI interactionText;


//Получение информауции об интерактивном объекте
   public string GetDescription()
    {
        return "Нажмите [E] чтобы поговорить с сотрудником";
    }
    //Действия при использовании кнопки взаимодействия
    public void Interact()
    {
     Invoke("visibleUi",3);
      interactionUI.SetActive(true);
        if (PlayerInteraction.canPickUp == false && queue.QueueOn == false)
        {
       
        interactionText.text = "У вас нет талона";
        }
        else if (queue.QueueOn == true)
        {
          interactionText.text = "Сейчас не ваша очередь";
        }
        else if (queue.QueueOn == false &&  PlayerInteraction.canPickUp == true)
        {
        interactionText.text = "Держите ваши документы";
        SpawnDoc();
        }

    }
    public void SpawnDoc()
    {
      Instantiate(Doc, new Vector3(-513f,58.6f,-342f),  Quaternion.Euler(342f,86f,1.3f));
    }

    public void visibleUi()
    {
         interactionUI.SetActive(false);
      
    }
}