using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemment : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2D;

    private float movimientoHorizontal = 0f;

    [SerializeField] private float velocidadM;

    [SerializeField] private float suave;

    private Vector3 velocidad = Vector3.zero;

    private bool miraD = true;

    [SerializeField] private float Fuerzadesalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionCaja;
    [SerializeField] private bool enSuelo;
    private bool salto = false;



    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadM;

        if(Input.GetButtonDown("Jumpp"))
        {
            salto = true;
        }
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionCaja, 0f, queEsSuelo);
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);

        salto = false;
    }

    private void Mover(float mover, bool saltar )
    {
        Vector3 velocidadobjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadobjetivo, ref velocidad, suave);

        if (mover > 0 && !miraD)
        {
            Girar();
        }
        else if (mover < 0 && miraD)
        {
            Girar();
        }
        if(enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, Fuerzadesalto));
        }
    }

    private void Girar ()
    {
        miraD = !miraD;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionCaja);
    }
}
