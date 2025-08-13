using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;

    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;
    void Start()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSFXSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSFXSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;    
        
        if(musica == true)
        {
            textoMusica.text = "ligado";
            textoMusica.color = Color.green;
        }

        else
        {
            textoMusica.text = "desligado";
            textoMusica.color = Color. red;
        }
    }
}
