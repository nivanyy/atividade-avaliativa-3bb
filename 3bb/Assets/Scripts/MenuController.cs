using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("jogo"); // aqui vai o nome da sua cena do jogo
    }
}