using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraTransform; // Asigna la Transform de la c�mara en el Inspector
    public float rotationSpeed = 5f; // Velocidad de rotaci�n (ajusta seg�n tus necesidades)

    void Update()
    {
        // Calcula la direcci�n hacia la que quieres que el personaje mire
        Vector3 lookDirection = cameraTransform.position - transform.position; // Direcci�n hacia la c�mara
        lookDirection.y = 0; // Asegura que la rotaci�n solo sea en el plano horizontal

        // Interpolaci�n suave para rotar el personaje en direcci�n opuesta
        if (lookDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(-lookDirection); // Ajustado para dar la espalda a la c�mara
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
