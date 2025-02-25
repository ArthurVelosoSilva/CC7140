using UnityEngine;

public class DestroyObjectsOnKeyPress : MonoBehaviour
{
    public string tagToDestroy = "Brick"; // Defina a tag dos objetos a serem destruídos
    public KeyCode keyToPress = KeyCode.E; // Defina a tecla que ativa a destruição

    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) // Verifica se a tecla foi pressionada
        {
            DestroyObjectsWithTag(tagToDestroy);
        }
    }

    void DestroyObjectsWithTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }
}