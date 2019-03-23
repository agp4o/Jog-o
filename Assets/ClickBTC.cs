using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBTC : MonoBehaviour
{
    public static int BTCmine;
    public int VerBTC;
    public GameObject BTCTexto;

    public void MineBTC()
    {
        BTCmine += 1;
    }

    public 


    void Start()
    {
        
    }
    void Update()
    {
        VerBTC = BTCmine;
        BTCTexto.GetComponent<Text>().text = "Bitcoin: " + VerBTC;
    }
}
