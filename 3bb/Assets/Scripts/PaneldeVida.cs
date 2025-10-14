using UnityEngine;
using UnityEngine.UI;

public class PaneldeVida : MonoBehaviour
{

    public Personagem Personagem;

    public Slider sliderVidas;
    public Slider sliderEnergia;
    
    
    
    
    void Start()
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = Personagem.getVidas();
        
        
        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = Personagem.getEnergia();
    }

    
    void Update()
    {
        sliderVidas.value = Personagem.getVidas();
        sliderEnergia.value = Personagem.getEnergia();
        
    }
}
