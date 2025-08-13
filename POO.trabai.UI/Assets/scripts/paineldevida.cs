using UnityEngine;
using UnityEngine.UI;
public class paineldevida : MonoBehaviour
{
    
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergia;
    
    
    void Start()
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem. getVidas();
        
        
        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem. getEnergia();
    }

    void Update()
    {
        
        sliderVidas.value = personagem. getVidas();
        sliderEnergia.value = personagem. getEnergia();
        
        
    }
}