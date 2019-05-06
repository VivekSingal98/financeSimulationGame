using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{

    public string nameOfItem;

    public void purchaseItem()
    {
        dataOfGame.savings -= dataOfGame.statsOfItems[nameOfItem+"_cost"];
        dataOfGame.inventory.Add(nameOfItem);
    }

}
