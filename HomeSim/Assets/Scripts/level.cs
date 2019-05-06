using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class level : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public UnityEngine.UI.Button levelButton;
    public UnityEngine.UI.Text levelText;
    public UnityEngine.UI.Text textTarget;
   

    void Start()
    {

        levelText.text="Level "+dataOfGame.currLevel ;
        StartCoroutine(BlinkText());
        textTarget.gameObject.SetActive(false);
    }
   
    public void reportCard(string sceneName)
    {
        if (FinishedLevel())
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            StartCoroutine(tryAgain());
        }

    }
    public IEnumerator tryAgain()
    {

        levelText.text = "Not Valid";
        yield return new WaitForSeconds(.5f);
        levelText.text = "Level " + dataOfGame.currLevel;

    }

    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (FinishedLevel()==true)
        {

            //set the Text's text to blank
            levelText.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display “I AM FLASHING TEXT” for the next 0.5 seconds
            levelText.text = "Upgrade to Level " + (dataOfGame.currLevel + 1);
            yield return new WaitForSeconds(.5f);
        }
    }
    bool FinishedLevel()
    {
        if (dataOfGame.levelInfo[dataOfGame.currLevel - 1].credits <= dataOfGame.totCredits
        && dataOfGame.levelInfo[dataOfGame.currLevel - 1].assets <= (dataOfGame.netSavings + dataOfGame.totInvest)
        && dataOfGame.levelInfo[dataOfGame.currLevel - 1].sol <= dataOfGame.totSOL)
        {
            return true;
        }
        return false;
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        textTarget.gameObject.SetActive(true);
        textTarget.text = "Level "+dataOfGame.currLevel+ " Target \nCredits " + dataOfGame.levelInfo[dataOfGame.currLevel - 1].credits +
                        "\nAssets " + dataOfGame.levelInfo[dataOfGame.currLevel - 1].assets +
                        "\nSOL " + dataOfGame.levelInfo[dataOfGame.currLevel - 1].sol;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        textTarget.gameObject.SetActive(false);
    }

}
