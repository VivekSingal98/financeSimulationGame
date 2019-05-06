using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{

    public string nameOfItem;
    public static int currentLevel=1;

    public void purchaseItem()
    {
        if (dataOfGame.netSavings >= dataOfGame.statsOfItems[nameOfItem]["cost"])
        {
            dataOfGame.netSavings -= dataOfGame.statsOfItems[nameOfItem]["cost"];
            dataOfGame.totCredits += dataOfGame.statsOfItems[nameOfItem]["credit"];
            dataOfGame.totSOL += dataOfGame.statsOfItems[nameOfItem]["sol"];
            dataOfGame.inventory.Add(nameOfItem);
        }

    }

}
