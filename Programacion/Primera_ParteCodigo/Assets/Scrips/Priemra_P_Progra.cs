using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priemra_P_Progra : MonoBehaviour
{
    //Inventario
    public bool Havekey = false;

    //Variables globales
    public float velocidad = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posiscion del player" + transform.position);
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
