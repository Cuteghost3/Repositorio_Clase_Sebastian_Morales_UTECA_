using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool HaveKey = false;
    public float velocidad = 4.5f;
    public float galletitascomidas = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        //> MAYOR
        //< MENOR
        //== IGUAL
        //!= DIFERENTES
        // >= MAYOR IGUAL QUE
        // <= MENOR IGUAL QUE

        if (galletitascomidas >= 10.0f)
        {
            Debug.Log("Para mi pana ya son demasiada galletas");
        }
        else
        {
            Debug.Log("Eeeee Pana quieres otra galleta");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public Vector3 GetPlayerPosition()
    {
        return transform.position;
    }
}
