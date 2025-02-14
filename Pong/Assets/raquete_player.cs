using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raquete_player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        pos.x = mousePos.x;
        pos.y = mousePos.y;
        transform.position = pos;

    }
}
