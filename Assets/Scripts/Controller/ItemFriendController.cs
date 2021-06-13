using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFriendController : Move
{
    public int speed;
    public GameObject Friend;
    void Update()
    {
        ItemMove();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamecontroller.instance.dellscore();
            //PlayerController.instance.health -= 10;           
            Destroy(gameObject);
            GameObject go = Instantiate(Friend, collision.transform.position, Quaternion.identity);
            Destroy(go, 10f);
        }
    }
}
