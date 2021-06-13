using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : Move
{
    public int speed;
    public GameObject shield;
    public GameObject shielddef;

    public void Update()
    {
        ItemMove();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamecontroller.instance.addscore();
            PlayerController.instance.health += 5;
            Destroy(gameObject);
            PlayerController.instance.shield();
         
            //Time.timeScale = 0;pausethoigian

        }
        if (collision.gameObject.tag == "bomb")
        {
            // Gamecontroller.instance.addscore();
            // PlayerController.instance.health += 5;
           // PlayerController.instance.shield();

        }

    }

    
}
