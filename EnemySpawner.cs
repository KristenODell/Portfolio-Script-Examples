using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    
   	private float invokingDelay;
   
    void Start()
    {
        invokingDelay = 1;
        InvokeRepeating("SpawningFunction", 0, invokingDelay);
    }
  
    void SpawningFunction()
    {
        int ind1 = 0;
        while (ind1 < enemyPrefabs.Length)
        {
            Vector3 Hello = transform.position;
            Hello.x += ind1 * 1;
            Instantiate(enemyPrefabs[ind1], Hello, Quaternion.identity);
            ind1++;
        }
    }
  
}
