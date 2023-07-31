using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followpath : MonoBehaviour
{
private Animator anim;
public  PathMove MyPath;
public float speed = 1;
public float maxDistance = .1f;

//Следование построенному пути
private IEnumerator<Transform> pointInPath;
    private void  Start()
    {
      anim = GetComponent<Animator>();
        if (MyPath == null) {
        Debug.Log("Нет пути");
        return;
        }
        pointInPath = MyPath.GetNextPathPoint();
        pointInPath.MoveNext();
        if(pointInPath.Current == null)
        {
            Debug.Log("Нет точек");
            return;
        }

        transform.position = pointInPath.Current.position;
     
    }


    private void Update()
    {
      if (pointInPath == null || pointInPath.Current == null)
      {
        return;
      }
       transform.position = Vector3.MoveTowards(transform.position,pointInPath.Current.position, Time.deltaTime*speed);
       // Поворот нпс
              Vector3 newDir = Vector3.RotateTowards(transform.forward, (pointInPath.Current.position - transform.position), 1, 0.0F);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(newDir), Time.deltaTime * speed);
       var disstanceSqure = (transform.position- pointInPath.Current.position).sqrMagnitude;
       if(disstanceSqure<maxDistance*maxDistance)
       {
        anim.Play("Idle");
        pointInPath.MoveNext();
        
       }
       else 
       anim.Play("Walk");
       
    }
}
