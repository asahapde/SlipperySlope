using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int level_select=0; //easy, medium, hard => 1,2,3
    public int play_index = 3;
    public int settings_index = 2;
    public int pause_index = 4;
    public Slider volumeslider;
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
    public void go_main()
    {
        SceneManager.LoadScene(0);
       
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
        SceneManager.LoadScene("MainScene1");
    }
    public void select_hard()
    {
        level_select = 3;
        SceneManager.LoadScene("MainScene2");
    }

   public void select_settings()
    {
        SceneManager.LoadScene(settings_index);
    }

    public void PAUSE()
    {
        SceneManager.LoadScene(pause_index);
    }
}
