using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Hareket kodu için:
    // Oyuncu hangi tuþa basýyor ve bu tuþ istediðimiz tuþ mu
    // Bastýðý tuþa göre o yönde hareket vermek

    public Rigidbody2D rb; // variable (deðiþken örneði)

    public float hiz;
    public float ziplamaHizi;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start"); //Console a mesaj yazdýrýyoruz
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) // basýlý ttutuðumuz týþu kontrol ediyoruz
        {
            rb.velocity = new Vector2(hiz, rb.velocity.y); // karakterimize pozitif X yönünde hýz veriyoruz
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(hiz * -1, rb.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.A)) // tuþtan parmaðýmýzý çektiðimizde olacak durum
        {
            rb.velocity = Vector2.zero; // hýzýmýzý sýfýrlýyoruz
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // space tuþuna ilk bastýðýmýz aný kontrol ediyoruz
        {
            rb.velocity = Vector2.up * ziplamaHizi; // yukarýya doðu olan hýzýmýzý deðiþtiriyoruz
        }
    }
}
