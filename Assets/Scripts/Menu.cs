using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
  //Загрузка игровой сцены из главного меню
  public void PlayGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
  }
  //Выход из игры
  public void ExitGame()
  {
    Debug.Log("Игра закрыта");
    Application.Quit();
  }
}
