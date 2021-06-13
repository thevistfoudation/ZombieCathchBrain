using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSponController : MonoBehaviour
{
    public GameObject coin;
    public Transform[] pos;
    public GameObject itembrain;
    private void Start()
    {
        OnEanalbe();

    }
    IEnumerator item()
    {
        while (true)
        {

            if (Gamecontroller.instance.coinplayer <= 1000000)
            {
                Coin();
                yield return new WaitForSeconds(1f);
            }
           
        }

    }

    void Coin()
    {
        int pos1 = Random.Range(0, pos.Length);
        Instantiate(coin, pos[pos1].position, Quaternion.identity);
    }



    
    public void OnEanalbe()
    {
        this.gameObject.SetActive(true);
        StartCoroutine(item());
        StartCoroutine(_disable());

    }
    public void Ondisable()
    {
        StopAllCoroutines();
        itembrain.GetComponent<ItemSponController>().OnEanalbe();
        this.gameObject.SetActive(false);

    }
    IEnumerator _disable()
    {
        yield return new WaitForSeconds(5);
        Ondisable();
    }
}

