using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Obtener la entrada del teclado (eje horizontal y vertical)
        float moveInputVertical = Input.GetAxis("Vertical");
        float moveInputHorizontal = Input.GetAxis("Horizontal");

        // Calcular el vector de movimiento basado en la entrada
        Vector3 moveDirection = new Vector3(moveInputHorizontal, 0f, 0f);

        // Normalizar el vector para mantener la misma velocidad de movimiento en todas las direcciones
        moveDirection.Normalize();

        // Mover el Rigidbody en la dirección calculada
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
