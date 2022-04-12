using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().AdicionarBloco();
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Bola"))
        {
            FindObjectOfType<GameManager>().DescontarBloco();
            Destroy(this.gameObject);
        }
    }
}
