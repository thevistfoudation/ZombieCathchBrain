using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Move : MonoBehaviour
{
    #region Var
   public float speed = 1.2f;
    public int direction;
    public float lefCons = Screen.width;
    public float rightCons = Screen.width;
    public float distanceZ;
    #endregion


    #region Unity Method

    private void Start()
    {

        distanceZ = Mathf.Abs(Camera.main.transform.position.z + transform.position.z);
        rightCons = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        lefCons = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
    }
    public void move(float speed)
    {
        distanceZ = Mathf.Abs(Camera.main.transform.position.z + transform.position.z);
        rightCons = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        lefCons = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        if (direction == 0)
        {
           // GetComponent<SpriteRenderer>().flipX = true;
            this.transform.position += Vector3.right * Time.deltaTime * speed;
        }
        else if (direction == 1)
        {
          //  GetComponent<SpriteRenderer>().flipX = false;
            this.transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (transform.position.x < lefCons + 0.5f) direction = 0;
        if (transform.position.x > rightCons - 0.5f) direction = 1;

    }

    public void ItemMove()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
    #endregion
}
