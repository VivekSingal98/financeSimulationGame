using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class displayGrid : MonoBehaviour
{
    public string prefixName;
    public UnityEngine.UI.Text title;
    public UnityEngine.UI.GridLayoutGroup grid;

    // Start is called before the first frame update
    void Start()
    {
        title.text = prefixName.ToUpper() + "s";
        //dataOfGame.inventory.Add("car1");

        foreach (string itemName in dataOfGame.inventory)
        {
            if (string.Compare(itemName, 0, prefixName, 0, prefixName.Length) == 0)
            {
                Sprite sp = Resources.Load<Sprite>("images/" + itemName);
                GameObject NewObj = new GameObject(); //Create the GameObject Assets/images/car4.gif
                Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
                NewImage.sprite = sp; //Set the Sprite of the Image Component on the new GameObject
                //NewImage = (Image.Type.Simple);
                NewObj.GetComponent<RectTransform>().SetParent(grid.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.
               
                /*GameObject NewObj1 = new GameObject();
                Button sellButton = NewObj1.AddComponent<Button>();
                NewObj1.transform.SetParent(grid.transform);
                NewObj1.SetActive(true);

                GameObject button = new GameObject();
                button.AddComponent<RectTransform>();
                Button button1 = button.AddComponent<Button>();
                button1.GetComponent<RectTransform>().SetParent(grid.transform);
                button.SetActive(true);*/
                NewObj.SetActive(true); //Activate the GameObject

            }
        }

    }

   
}
