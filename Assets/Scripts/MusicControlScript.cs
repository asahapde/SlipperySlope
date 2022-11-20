using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicControlScript : MonoBehaviour
{
    public static MusicControlScript instance; // Creates a static varible for a MusicControlScript instance
    public AudioSource menuMusic;
    public AudioSource LevelMusic;
    private void Awake() // Runs before void Start()
    {
        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
        DontDestroyOnLoad(this.gameObject); // Don't destroy this gameObject when loading different scenes

        if (instance == null) // If the MusicControlScript instance variable is null
        {
            instance = this; // Set this object as the instance
        }
        else // If there is already a MusicControlScript instance active
        {
            Destroy(gameObject); // Destroy this gameObject
        }
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            MenuMusic();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            GameMusic();
        }
    }

    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            MenuMusic();
        }
        else if (SceneManager.GetActiveScene().name == "MainScene")
        {
            GameMusic();
        }

    }

    public void MenuMusic()
    {
        menuMusic.Play();
        LevelMusic.Stop();
    }

    public void GameMusic()
    {
        LevelMusic.Play();
        menuMusic.Stop();
    }
}