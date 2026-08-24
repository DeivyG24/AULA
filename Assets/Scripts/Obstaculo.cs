using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip somDano;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetTrigger("dano");
            AudioSource.PlayClipAtPoint(somDano, transform.position);
            gameManager.Dano();
        }
    }
}
