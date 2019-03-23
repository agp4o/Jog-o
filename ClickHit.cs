using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHit : MonoBehaviour
{
    public static int HitBuy;
    public int VerHit;
    public GameObject HitTexto;
    public GameObject Log;

    public void BuyHit()
    {
        if(ClickBTC.BTCmine == 0)
        {
            Log.GetComponent<Text>().text = "BitCoins insufuciente";
        }
        else
        {
            ClickBTC.BTCmine -= 1;
            HitBuy += 1;
        }

    }

    void Start()
    {
        
    }
    void Update()
    {
        VerHit = HitBuy;
        HitTexto.GetComponent<Text>().text = "HitCoin:" + VerHit;
    }
}
