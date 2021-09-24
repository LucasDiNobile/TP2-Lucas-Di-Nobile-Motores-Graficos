using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour
{
    float xInicial, yInicial;
    public float speed = 0;
    public Text Victoria;
    public Text PorAhiNoEs;
    private Rigidbody rb;
    private float movementX;
    private float movementY;


    // Start is called before the first frame update
    void Start()
    {
        xInicial = transform.position.x;
        yInicial = transform.position.y;

        rb = GetComponent<Rigidbody>();

        Victoria.text = "";
        PorAhiNoEs.text = "";
    }

    // Update is called once per frame
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Victoria.text = "You Win!!";
        }

        if (other.gameObject.CompareTag("TriggerPorAhiNoEs"))
        {
            PorAhiNoEs.text = "Por ahi no es!!";

        }

    }

    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);

        PorAhiNoEs.text = "";
    }
    
}
