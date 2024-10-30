using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraTransform; // Asigna la Transform de la cámara en el Inspector
    public float rotationSpeed = 5f; // Velocidad de rotación (ajusta según tus necesidades)

    void Update()
    {
        // Calcula la dirección hacia la que quieres que el personaje mire
        Vector3 lookDirection = cameraTransform.position - transform.position; // Dirección hacia la cámara
        lookDirection.y = 0; // Asegura que la rotación solo sea en el plano horizontal

        // Interpolación suave para rotar el personaje en dirección opuesta
        if (lookDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(-lookDirection); // Ajustado para dar la espalda a la cámara
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
