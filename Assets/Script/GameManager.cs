using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    int taskDone = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void OnTask1Done()
    {
        taskDone++;
        if(taskDone == 3)
        {
            Congratulation();
        }
    }

    public void GameOver()
    {
        StartCoroutine(LoadGameOver());

    }
    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }

    public void Congratulation()
    {
        //SceneManager.LoadScene(2);
    }
}*/
