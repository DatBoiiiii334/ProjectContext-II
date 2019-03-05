using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //For the Settings Ui display
    public GameObject Settings;

    //For the background settings
    public Slider BackgroundSlider;
    public AudioSource BackgroundAudio;

    //For the Effects settings
    public Slider EffectsSlider;
    public AudioSource EffectsAudio;

    private bool Button;


    public void Start()
    {
        BackgroundSlider.minValue = 0;
        BackgroundSlider.maxValue = 1;
        BackgroundSlider.wholeNumbers = false;
        BackgroundSlider.value = 0.5f;

        EffectsSlider.minValue = 0;
        EffectsSlider.maxValue = 1;
        EffectsSlider.wholeNumbers = false;
        EffectsSlider.value = 0.5f;

    }


    public void Update()
    {
        ButtonControl();
        VolumeController();
    }

    public void ButtonControl()
    {
        if (Button == false) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                Settings.SetActive(true);
                Button = true;
            }
        }
        else if (Button == true) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                Settings.SetActive(false);
                Button = false;
            }
        }
        else { return; }
    }

    public void VolumeController()
    {
        BackgroundAudio.volume = BackgroundSlider.value;
        EffectsAudio.volume = EffectsSlider.value;

    }
}
