using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public Text healthText;
    private int health;
    private int damageAmount;

     void Start()
     {
        health = 100;
        damageAmount = 10;
     }

   
    void OnCollisionEnter(Collision colVar3)
    {
        if (colVar3.transform.tag == "Enemy")
        {
            health = Damage(health);
            healthText.text = health.ToString();

        }
        else if (colVar3.transform.tag == "Killzone")
        {
            Application.LoadLevel("Midterm");
        }
    }

   
    int Damage(int num1)
    {
        int newHealthValue;
        newHealthValue = num1 - damageAmount;
        if(newHealthValue == 0)
        {
            Application.LoadLevel("Midterm");
        }
        return newHealthValue;
    }


 
}