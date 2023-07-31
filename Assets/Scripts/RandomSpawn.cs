using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] Queue;
    public List<Transform> spawnPoints;
   
    void Start()
    {
        spawnPoints = new List <Transform> (spawnPoints);
        SpawnQueue();
    }
// Случайная генерация очереди
  void SpawnQueue()
  {
    for (int i =0; i<Queue.Length; i++)
    {
        var spawn = Random.Range(0, spawnPoints.Count);
        Instantiate(Queue[i], spawnPoints[spawn].transform.position, spawnPoints[spawn].transform.rotation);
        spawnPoints.RemoveAt(spawn);
    }
  }
}
