using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
   
    private Rigidbody var1;
    public float speed1;
    public float direction1;
   
     void Start()
    {
        var1 = GetComponent<Rigidbody>();
        Vector3 direction1 = new Vector3(0, Random.Range(0,360), 0);
        transform.eulerAngles = direction1;
    }

   
     void Update ()
    {
        var1.AddRelativeForce(transform.forward * speed1);
    }


}