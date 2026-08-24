using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Image[] coracoes;
    public Sprite cheio;
    public Sprite vazio;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    void Update()
    {
        AtualizarHUD();
    }
    public void AtualizarHUD()
    {
        for (int i = 0; i < 6; i++)
        {
            if (i < gameManager.vida)
                coracoes[i].sprite = cheio;
            else
                coracoes[i].sprite = vazio;
        }
    }
}
