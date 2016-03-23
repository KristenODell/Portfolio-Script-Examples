using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    public float rotationSpeed;
    public float movementSpeed;
    private Rigidbody variable1;

     void Start()
    {
        variable1 = GetComponent<Rigidbody>();
    }
    
     void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            variable1.AddRelativeForce(0, 0, movementSpeed);
        }
    }
   
}
