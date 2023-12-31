using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pineapple : MonoBehaviour
{
    // Set the names of the scenes in the Inspector
    public string Nivel_1_SceneName = "Nivel_1";
    public string Nivel_2_SceneName = "Nivel_2";
    public string Nivel_3_SceneName = "Nivel_3";
    public string Felicidades_SceneName = "Felicidades";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Pineapple");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == Nivel_1_SceneName)
        {
            SceneManager.LoadScene(Nivel_2_SceneName);
        }
        else if (currentSceneName == Nivel_2_SceneName)
        {
            SceneManager.LoadScene(Nivel_3_SceneName);
        }
        else if (currentSceneName == Nivel_3_SceneName)
        {
            SceneManager.LoadScene(Felicidades_SceneName);
        }
    }
}
