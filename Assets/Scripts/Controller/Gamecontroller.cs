using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instance;
    public GameObject ItemCoin, itembrain;
    public int scoreplayer;
    public int scoreboss;
    public GameObject panelover;
    public Text coin;
    public Text score;
    public Text bossPower;
    public int coinplayer;
    public int scoreshield;
    public Text coin1;
    public Text score1;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        Time.timeScale = 1;
        scoreplayer = 0;
        scoreboss = 0;
    }
    private void Update()
    {
        endgame();
        score.text = "score : " + scoreplayer.ToString();
        coin.text = "coin : " + coinplayer.ToString();
        bossPower.text = "boss power :" + scoreboss.ToString();
        score1.text = "score : " + scoreplayer.ToString();
        coin1.text = "coin : " + coinplayer.ToString();

        if (scoreplayer <= 0)
        {
            scoreplayer = 0;
        }
        if (scoreboss >= 15)
        {
            scoreplayer -= 5;
            scoreboss += -15;
        }
        if (scoreplayer == 10)
        {
            PlayerController.instance.speed = 1f;
        }
        if (scoreplayer == 200)
        {
            PlayerController.instance.speed = 0.8f;
        }
        if (scoreplayer == 1000)
        {
            PlayerController.instance.speed = 0.6f;
        }
        if (scoreplayer == 2000)
        {
            PlayerController.instance.speed = 0.5f;
        }
        if (scoreshield == 25)
        {
            PlayerController.instance.shield();
            scoreshield = 0;
        }
    }
    public void addcoin()
    {
        coinplayer += 10;
    }
    public void addscore()
    {
        scoreplayer += 10;
    }
    public void dellscore()
    {
        scoreplayer += -10;
    }
    public void scoreplus()
    {
        scoreboss += 5;
    }
    public void addscoreshield()
    {
        scoreshield += 5;
    }
    public void endgame()
    {
        if (PlayerController.instance.health <= 0)
        {
            panelover.SetActive(true);
            score.gameObject.SetActive(false);
            coin.gameObject.SetActive(false);
            bossPower.gameObject.SetActive(false);
            coin1.gameObject.SetActive(true);
            score1.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Playagain()
    {
        SceneManager.LoadScene("play");
    }
    public void ahihi()
    {
        if (scoreplayer == 10)
        {
            itembrain.GetComponent<ItemSponController>().Ondisable();
            ItemCoin.GetComponent<CoinSponController>().OnEanalbe();
        }
        if (scoreplayer == 200)
        {
            itembrain.GetComponent<ItemSponController>().Ondisable();
            ItemCoin.GetComponent<CoinSponController>().OnEanalbe();
        }
        if (scoreplayer == 500)
        {
            itembrain.GetComponent<ItemSponController>().Ondisable();
            ItemCoin.GetComponent<CoinSponController>().OnEanalbe();
        }
        if (scoreplayer == 1000)
        {
            itembrain.GetComponent<ItemSponController>().Ondisable();
            ItemCoin.GetComponent<CoinSponController>().OnEanalbe();
        }
        if (scoreplayer == 2000)
        {
            itembrain.GetComponent<ItemSponController>().Ondisable();
            ItemCoin.GetComponent<CoinSponController>().OnEanalbe();
        }
    }
}
