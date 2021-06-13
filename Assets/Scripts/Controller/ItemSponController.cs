using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSponController : MonoBehaviour
{
    public GameObject[] prefab;
    public Transform[] pos;
    public GameObject shieldprefab;
    public GameObject ItemFriendprefab;
    private void Start()
    {
        OnEanalbe();
       // StartCoroutine(item2());
        //StartCoroutine(shield());

    }
    IEnumerator item()
    {
        while(true)
        {
           
            if (Gamecontroller.instance.coinplayer <= 1000000)
            {
                brain();
                yield return new WaitForSeconds(1f);
            }
            //if (Gamecontroller.instance.scoreplayer <= 10000000)
            //{
            //    Debug.Log("hihi");
            //    shield();
            //    yield return new WaitForSeconds(1f);
            //}
            //if (Gamecontroller.instance.scoreplayer <= 10000000)
            //{
            //    Debug.Log("huhu");
            //    ItemFriend();
            //    yield return new WaitForSeconds(1f);
            //}
        }

    }
   
    void brain()
    {
        int pos1 = Random.Range(0, pos.Length);
        int itemrandom = Random.Range(0, prefab.Length);
        Instantiate(prefab[itemrandom], pos[pos1].position, Quaternion.identity);
    }

   

    void shield()
    {
        int pos1 = Random.Range(0, pos.Length);
        Instantiate(shieldprefab, pos[pos1].position, Quaternion.identity);
    }
    void ItemFriend()
    {
        int pos1 = Random.Range(0, pos.Length);
        Instantiate(ItemFriendprefab, pos[pos1].position, Quaternion.identity);
    }

    IEnumerator hp()
    {
        while (true)
        {
            Debug.Log("tru mau");
            PlayerController.instance.health -= 5;
            yield return new WaitForSeconds(4f);           
        }

    }
    public void OnEanalbe()
    {
        this.gameObject.SetActive(true);
        StartCoroutine(item());
        StartCoroutine(hp());

    }
    public void Ondisable()
    {
        StopAllCoroutines();
        this.gameObject.SetActive(false);
    }

}
