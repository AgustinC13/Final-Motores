using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientotuberia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /* Bloquea los FPS en 60*/
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 0.5f, transform.position.y), 0.1f);
    }
}
