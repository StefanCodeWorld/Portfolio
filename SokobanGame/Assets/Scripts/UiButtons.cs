using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiButtons : MonoBehaviour
{
    public void OnResetPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnNextLevelPress()
    {
        string CurrentLevelName = SceneManager.GetActiveScene().name;

        CurrentLevelName = CurrentLevelName.Remove(0, 5);

        int levelIndex = int.Parse(CurrentLevelName);

        levelIndex++;
        
        string NextLevel = "Level" + levelIndex;

        if(levelIndex == 5)
        {
            SceneManager.LoadScene("Menu");
        }
        if(levelIndex < 5)
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
    public void OnMenuPress()
    {
        SceneManager.LoadScene("Menu");
    }
}
