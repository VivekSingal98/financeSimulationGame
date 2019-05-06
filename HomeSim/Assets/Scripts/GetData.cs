using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour
{
    public UnityEngine.UI.Text display;
    public string prefixName;
    void Start()
    {
        Debug.Log("Start");
        int noOfItemsStartingWithname = 0;
        foreach (string itemName in dataOfGame.inventory)
        {
            if(string.Compare(itemName,0,prefixName,0,prefixName.Length)==0)
            {
                noOfItemsStartingWithname += 1;
            }
        }
        display.text = "Number of " + prefixName + " : " + noOfItemsStartingWithname;
    }
}
