using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMove : MonoBehaviour
{

public int moveingTo=0;
    public int movemntDirection = 1;
    private float waitTime;
    public float startWaitTime;
    public Transform[] PathElements;
//Построение пути
    public void OnDrawGizmos()
    {
        if  (PathElements == null || PathElements.Length<2)
        {
            return;
          
        }
        for (int i = 1; i < PathElements.Length; i++)
        {
              Gizmos.DrawLine(PathElements[i-1].position, PathElements[i].position);
        }

       
    }
    //Переход к следующей точке
    public IEnumerator<Transform> GetNextPathPoint()
    {
   
        if (PathElements == null || PathElements.Length<1)
        {
            yield break;
        }
        while (true)
        {
            yield return PathElements[moveingTo];
            if (PathElements.Length == 1)
            {
                continue;
            }
          if (waitTime <=0)
          {
          
          
            if (moveingTo<=0)
           {
            movemntDirection = 1;
           
           }
            else if (moveingTo >= PathElements.Length-1)
            {
                movemntDirection= -1;
            }
           moveingTo = moveingTo + movemntDirection;
             waitTime = startWaitTime;
      
          }
          else {
            waitTime -= Time.deltaTime;
          }
        }
    }

     
}

