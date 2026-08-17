using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    public void IniciarJogo()
    {
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        if (gameManager != null ) Destroy( gameManager.gameObject);
        SceneManager.LoadScene("Menu");
    }
}
