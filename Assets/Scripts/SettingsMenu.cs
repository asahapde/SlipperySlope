using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else
        {
            LOAD();
        }
    }

    //volume stuff

    public void changevolume()
    {
        AudioListener.volume = VolumeSlider.value;
        SAVE();
    }

    private void LOAD()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SAVE()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
    }
   
}
