using UnityEngine;
using UnityEngine.SceneManagement;  // Importa a biblioteca para manipular cenas
using System.Collections;

public class VitoriaGeral : MonoBehaviour
{
    public float delay = 2f;

    void Update()
    {
        // Verifica se ainda existem objetos com a tag "Brick"
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            StartCoroutine(ChangeSceneAfterDelay("YouWin", delay));  // Carrega a próxima cena
        }
    }

    IEnumerator ChangeSceneAfterDelay(string sceneName, float waitTime)
    {
        yield return new WaitForSeconds(waitTime); // Espera o tempo definido
        SceneManager.LoadScene(sceneName); // Troca de cena
    }
}
