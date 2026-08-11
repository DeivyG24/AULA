using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int vida = 4;
    public int vidaMaxima = 4;

    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }
    public void Dano()
    {
        vida--;
        if (vida == 0)
        {
            Derrota();
        }
    }

    public void Derrota()
    {
        Debug.Log("Derrota");
    }

    public void Cura()
    {
        if (vida < 8) vida++;
    }

    public void CaiuNoBuraco()
    {
        vida = 0;
        Derrota();
    }
}