using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : Move
{
    public static PlayerController instance;
    public int health;
    public Slider slider_hp;
    float time = 0;
    [SerializeField]
    GameObject Shield;
    
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        health = 100;
        slider_hp.maxValue = health;
    }
    public void Update()
    {
        move(speed);
        if (Input.GetMouseButtonDown(0))
        {
            if(direction == 0)
            {
                direction = 1;
            }
            else if (direction == 1)
            {               
                direction = 0;
            }
        }
        slider_hp.value = health;
        //if(time <= 0)
        //{
        //    Shield.SetActive(false);
        //}else
        //{
        //    Shield.SetActive(true);
        //    time -= Time.deltaTime *1.5f;
        //}
    }




    public void shield()
    {
       // time = 3;
       //StartCoroutine(aha());
       if(this.gameObject.transform.GetChild(0).gameObject.activeInHierarchy == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
       else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
   
    IEnumerator aha()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
