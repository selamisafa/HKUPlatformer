using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Hareket kodu i�in:
    // Oyuncu hangi tu�a bas�yor ve bu tu� istedi�imiz tu� mu
    // Bast��� tu�a g�re o y�nde hareket vermek

    public Rigidbody2D rb;

    public float hiz;
    public float ziplamaHizi;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(hiz, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(hiz * -1, rb.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * ziplamaHizi;
        }
    }
}
