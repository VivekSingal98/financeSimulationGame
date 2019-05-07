using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelAnalysis : MonoBehaviour
{
    public UnityEngine.UI.Image creditStar;
    public UnityEngine.UI.Image assetStar;
    public UnityEngine.UI.Image solStar;
    public UnityEngine.UI.Text creditMessage;
    public UnityEngine.UI.Text assetMessage;
    public UnityEngine.UI.Text solMessage;

    private void Start()
    {
        Sprite Star_1 = Resources.Load<Sprite>("pictures/Star_1");
        Sprite Star_0 = Resources.Load<Sprite>("pictures/Star_0");
        Sprite Star_05 = Resources.Load<Sprite>("pictures/Star_0.5");
        Sprite Star_075 = Resources.Load<Sprite>("pictures/Star_0.75");
        
        float targetCredits = dataOfGame.levelInfo[dataOfGame.currLevel - 1].credits;
        float creditsEarned = dataOfGame.totCredits;
        //creditsEarned = 1190;
        if (creditsEarned<targetCredits)
        {
            creditStar.sprite = Star_0;
            creditMessage.text = "earn more credits using eco-friendly alternatives. Like high star rating appliances";
        }
        else if(creditsEarned<1.1*targetCredits)
        {
            creditStar.sprite = Star_05;
            creditMessage.text = "more credits can be earned using eco-friendly alternatives. Like high star rating appliances";
        }
        else
        {
            creditStar.sprite = Star_1;
            creditMessage.text = "great work in earning credits";
        }

        float targetAssets = dataOfGame.levelInfo[dataOfGame.currLevel - 1].assets;
        float assetsEarned = dataOfGame.netSavings+dataOfGame.totInvest;
        //creditsEarned = 1190;
        if ( assetsEarned<targetAssets)
        {
            assetStar.sprite = Star_0;
            assetMessage.text = " spend judiciously by choosing less expensive alternatives. Increase assets by investing among diverse options and sell at right time to earn more";
        }
        else if (assetsEarned < 1.1 * targetAssets)
        {
            assetStar.sprite = Star_05;
            assetMessage.text = "spend judiciously by choosing less expensive alternatives. Increase assets by investing among diverse options and sell at right time to earn more";
        }
        else if(dataOfGame.totInvest<0.4*targetAssets) {
            assetStar.sprite=Star_075;
            assetMessage.text="Increase assets by investing among diverse options and sell at right time to earn more";       
        }
        else
        {
            assetStar.sprite = Star_1;
            assetMessage.text = "great work in earning credits";
        }

        float targetsol = dataOfGame.levelInfo[dataOfGame.currLevel - 1].sol;
        float solEarned = dataOfGame.totSOL;

        //solEarned = 1190;
        if (solEarned < targetsol)
        {
            solStar.sprite = Star_0;
            solMessage.text = "buy commodities considering minimum requirement";
        }
        else if (solEarned < 1.1 * targetsol)
        {
            solStar.sprite = Star_05;
            solMessage.text = "after buying necessary commodities try to invest the money left in various options available";
        }
        else
        {
            solStar.sprite = Star_1;
            solMessage.text = "great work in sustaining good standards of living";
        }

        dataOfGame.currLevel++;
    }

}
