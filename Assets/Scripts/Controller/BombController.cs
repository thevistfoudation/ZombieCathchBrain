using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public int speed;
    public GameObject exp;

    public void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamecontroller.instance.dellscore();
            //PlayerController.instance.health -= 10;
            collision.GetComponent<PlayerController>().health -= 10;
            Destroy(gameObject);
            GameObject go = Instantiate(exp, collision.transform.position, Quaternion.identity);
            Destroy(go, 0.5f);
            
        }
        if (collision.gameObject.tag == "shield")
        {
            PlayerController.instance.shield();
            Destroy(gameObject);
        }
    }
}
