using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Hareket kodu i�in:
    // Oyuncu hangi tu�a bas�yor ve bu tu� istedi�imiz tu� mu
    // Bast��� tu�a g�re o y�nde hareket vermek

    public Rigidbody2D rb; // variable (de�i�ken �rne�i)

    public float hiz;
    public float ziplamaHizi;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start"); //Console a mesaj yazd�r�yoruz
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) // bas�l� ttutu�umuz t��u kontrol ediyoruz
        {
            rb.velocity = new Vector2(hiz, rb.velocity.y); // karakterimize pozitif X y�n�nde h�z veriyoruz
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(hiz * -1, rb.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.A)) // tu�tan parma��m�z� �ekti�imizde olacak durum
        {
            rb.velocity = Vector2.zero; // h�z�m�z� s�f�rl�yoruz
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // space tu�una ilk bast���m�z an� kontrol ediyoruz
        {
            rb.velocity = Vector2.up * ziplamaHizi; // yukar�ya do�u olan h�z�m�z� de�i�tiriyoruz
        }
    }
}
