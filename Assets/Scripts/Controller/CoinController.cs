using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : Move
{
    public int speed;
    public void Update()
    {
        ItemMove();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamecontroller.instance.addcoin();
            Destroy(gameObject);

        }
    }
}
