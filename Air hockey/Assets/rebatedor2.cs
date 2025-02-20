using UnityEngine;

public class Pursuer : MonoBehaviour
{
    public Transform target; // Referência ao alvo
    public float speed = 5f; // Velocidade do perseguidor
    public Vector3 finalDestination = new Vector3(0, 0, 0); // Destino final para onde o alvo será movido após a colisão

    void Update()
    {
        if (target != null)
        {
            // Move o perseguidor em direção ao alvo
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    // Método que é chamado quando o perseguidor colide com o alvo
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == target.gameObject) // Verifica se o alvo foi atingido
        {
            // Aqui o alvo vai ser movido para o ponto (0,0,0) de forma gradual
            StartCoroutine(MoveToDestination(collision.gameObject)); 
        }
    }

    // Coroutine para mover o alvo até o ponto final com um movimento suave
    private System.Collections.IEnumerator MoveToDestination(GameObject targetObject)
    {
        float journeyLength = Vector3.Distance(targetObject.transform.position, finalDestination);
        float startTime = Time.time;

        while (Vector3.Distance(targetObject.transform.position, finalDestination) > 0.1f)
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distanceCovered / journeyLength;

            // Move o alvo em direção ao ponto final de forma suave
            targetObject.transform.position = Vector3.Lerp(targetObject.transform.position, finalDestination, fractionOfJourney);
            yield return null;
        }

        // Garante que o alvo atinja exatamente o destino (0,0,0)
        targetObject.transform.position = finalDestination;
    }
}
