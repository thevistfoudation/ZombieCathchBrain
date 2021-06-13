using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainController : Move
{
  public  int speed;

    public void Update()
    {
        ItemMove();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Gamecontroller.instance.addscore();
            PlayerController.instance.health += 10;
            Gamecontroller.instance.addscoreshield();
            Gamecontroller.instance.ahihi();
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "Boss")
        {
            Gamecontroller.instance.scoreplus();
            Debug.Log("brainout");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Friend")
        {
            Gamecontroller.instance.addscore();
            PlayerController.instance.health += 10;
            Destroy(gameObject);
        }
    }
}
