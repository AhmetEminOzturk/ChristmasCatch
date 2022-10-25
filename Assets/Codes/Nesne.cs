using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Nesne : MonoBehaviour
{
    public Transform nesne;
    public AudioSource kontrolcubukfail;



    private void OnCollisionEnter(Collision temas)
    {


        if (temas.gameObject.tag == "KontrolCubuk")
        {
            float xPozisyonu = Random.Range(-10f, 7f);
            Debug.Log(xPozisyonu);

            nesne.position = new Vector3(xPozisyonu, 6f, 0f);
            Basket.kalanHak--;
            kontrolcubukfail.Play();

        }


    }
}




