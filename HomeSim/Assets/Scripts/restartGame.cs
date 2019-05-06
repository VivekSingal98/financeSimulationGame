using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{

    void Start()
    {

        dataOfGame.netSavings = dataOfGame.levelInfo[0].salary;
        dataOfGame.totInvest = 0;
        dataOfGame.inventory.Clear();
        dataOfGame.totSOL = 0;
        dataOfGame.totCredits = 0;
        StartCoroutine(WaitTime());

    }

    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("HomeScreen");
    }

}
