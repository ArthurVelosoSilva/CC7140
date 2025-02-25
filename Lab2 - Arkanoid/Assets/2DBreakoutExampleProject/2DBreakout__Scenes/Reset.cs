using UnityEngine;
using UnityEngine.SceneManagement; // Importa o SceneManager

public class Reset : MonoBehaviour
{
    public string nomeDaCena = "Menu"; // Nome da cena para carregar

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Verifica se a tecla "Espaço" foi pressionada
        {
            SceneManager.LoadScene(nomeDaCena); // Carrega a cena especificada
        }
    }
}