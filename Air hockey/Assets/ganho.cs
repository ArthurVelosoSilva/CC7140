using UnityEngine;

public class TeleportWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Teleporta qualquer objeto que tocar na parede
        collision.gameObject.transform.position = Vector3.zero;
        Debug.Log(collision.gameObject.name + " foi teleportado para (0,0,0)!");
    }
}
