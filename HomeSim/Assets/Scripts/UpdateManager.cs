using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{

    public string nameOfItem;

    public void purchaseItem()
    {
        if (dataOfGame.netSavings >= dataOfGame.statsOfItems[nameOfItem]["cost"])
        {
            dataOfGame.netSavings -= dataOfGame.statsOfItems[nameOfItem]["cost"];
            dataOfGame.totCredits -= dataOfGame.statsOfItems[nameOfItem]["credit"];
            dataOfGame.totSOF -= dataOfGame.statsOfItems[nameOfItem]["sol"];
            dataOfGame.inventory.Add(nameOfItem);
        }


    }

}
