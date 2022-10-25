using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneNegatif : MonoBehaviour
{
    public Transform nesnenegatif;
    public AudioSource negatifkontrolcubukfail;


    private void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "KontrolCubuk")
        {
            float xPozisyonu = Random.Range(-1.35f, 15.30f);
            nesnenegatif.position = new Vector3(xPozisyonu, 6f, 0f);
            negatifkontrolcubukfail.Play();
            

        }
    }

}
