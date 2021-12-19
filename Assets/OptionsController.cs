using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;
    void Start()
    {
        volumeSlider.value = PLayerPrefsController.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        var MusicPlayer = FindObjectOfType<musicPlayer>();
        if(MusicPlayer)
        {
            MusicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No");
        }
    }

    public void SaveAndExit()
    {
        PLayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<StartScreen>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
    }
}
