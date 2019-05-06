using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userDetails : MonoBehaviour
{
    public UnityEngine.UI.Text moneyDisplay;


    // Update is called once per frame
    void Update()
    {
        moneyDisplay.text = "Savings: " + dataOfGame.netSavings+"\nCredits "+dataOfGame.totCredits
                            +"\nAssets "+(dataOfGame.netSavings+dataOfGame.totInvest)
                            +"\nSOL "+dataOfGame.totSOL;
       
    }
}
