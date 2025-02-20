using UnityEngine;

public class FollowMouseWithCollision : MonoBehaviour
{
    public LayerMask obstacleLayer;  // Define as camadas que o objeto 1 pode colidir
    private Rigidbody2D rb;

    void Start()
    {
        // Obtém o componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Verifica se há um obstáculo ou colisão no caminho do mouse
        Collider2D hit = Physics2D.OverlapPoint(mousePosition, obstacleLayer);

        // Se não houver obstáculo, move o objeto para a posição do mouse
        if (hit == null)
        {
            rb.MovePosition(mousePosition);
        }
    }
}
