using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    public float slowness = 10f;
    private float fixedDeltaTime;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator RestartLevel()
    {
        Debug.Log("Time: " + Time.time);
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        Debug.Log("timeScale: " + Time.timeScale);

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f / slowness;
        //Time.timeScale = 0.8f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        //Time.fixedDeltaTime = this.fixedDeltaTime * Time.fixedDeltaTime;
        Debug.Log("Time2: " + Time.fixedDeltaTime);

        Debug.Log("Collision detected.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
