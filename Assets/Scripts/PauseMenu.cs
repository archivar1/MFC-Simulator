using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
   public bool PauseGame;
   public GameObject pauseGameMenu;

  void Update()
   {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        Cursor.lockState = CursorLockMode.Confined;
        if (PauseGame)
        {
         Resume();
        }
        else
        { 
          Pause();
        }
    }
   }
//Функции для внутрииргового меню
public void Resume()
{
    pauseGameMenu.SetActive(false);
    Time.timeScale = 1f;
    PauseGame = false;
  Cursor.lockState = CursorLockMode.Locked;
} 
 public void Pause()
    {
    pauseGameMenu.SetActive(true);
    Time.timeScale = 0f;
    PauseGame = true;
    }

 public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}

