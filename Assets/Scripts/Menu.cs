using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Função para o botão iniciar
    
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Fase1");
    }

    // Função para o botão sair

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
}
