using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket : MonoBehaviour
{
    float hareketYon;
    public float hareketHiz;
    public Transform gift1, gift2, alert1, alert2;
    public static int skor =0;
    public TextMeshProUGUI skorYazisi,kalanhakYazisi,bitisYazisi;
    public static int kalanHak = 4;
    public GameObject bitisPaneli;
    public AudioSource succesjingle,failjingle,gameover;

    void Update()
    {
        hareketYon = Input.GetAxis("Horizontal") * hareketHiz;
        transform.Translate(hareketYon * Time.deltaTime, 0f, 0f);
        hareketYon = Mathf.Clamp(transform.position.x, -10f, 10f);
        transform.position = new Vector3(hareketYon, transform.position.y, transform.position.z);
        skorYazisi.text = "Skor:" + skor.ToString();
        kalanhakYazisi.text = "Hak:" + kalanHak.ToString();
        bitisYazisi.text = "Skor :" + skor.ToString() +"\n" + "Tebrikler";
        if (kalanHak == 0)
        {
            
            bitisPaneli.SetActive(true);
            Time.timeScale = 0;
            
        }

        if (Time.timeScale == 0)
        {
            gameover.Play();
        }

    }

    private void OnCollisionEnter(Collision temas)
    {
       
        float xPozisyon1 = Random.Range(-10f, 7f);
        float xPozisyon2 = Random.Range(-10f, 7f);
        float xPozisyon3 = Random.Range(-10f, 7f);
        float xPozisyon4 = Random.Range(-10f, 7f);
        


        if (temas.gameObject.tag == "gift1")
        {
        gift1.position = new Vector3(xPozisyon1,6f, 0f);
            skor+=Random.Range(5,15);
            succesjingle.Play();
        }
        if (temas.gameObject.tag == "gift2")
        {
            gift2.position = new Vector3(xPozisyon2, 6f, 0f);
            skor += Random.Range(5, 15);
            succesjingle.Play();
        }
        if (temas.gameObject.tag == "alert1")
        {
            alert1.position = new Vector3(xPozisyon3, 6f, 0f);
            skor -= 20;
            kalanHak--;
            failjingle.Play();
        }
        if (temas.gameObject.tag == "alert2")
        {
            alert2.position = new Vector3(xPozisyon4, 6f, 0f);
            skor -= 10;
            kalanHak--;
            failjingle.Play();
        }
        



    }
}
