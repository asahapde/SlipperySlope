using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int level_select=0;
    public int play_index = 3;
    public void play_game()
    {
        //main menu scene index
        int current_index = SceneManager.GetActiveScene().buildIndex;

        //loads next scene, first level
        SceneManager.LoadScene(current_index + 1);

    }
    public void go_back()
    {
        int current_index = SceneManager.GetActiveScene().buildIndex;

        //loads previous scene
        SceneManager.LoadScene(current_index - 1);
    }
    public void quit_game()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void select_easy()
    {
        level_select = 1;
        SceneManager.LoadScene(play_index);
    }
    public void select_medium()
    {
        level_select = 2;
        SceneManager.LoadScene(play_index);
    }
    public void select_hard()
    {
        level_select = 3;
        SceneManager.LoadScene(play_index);
    }


}
