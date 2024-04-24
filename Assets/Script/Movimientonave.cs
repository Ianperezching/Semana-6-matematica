using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class AirplaneController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationAngle = 35f;
    private Vector2 moveInput;
    public TextMeshProUGUI textopuntos;
    public int vida= 3;

    private void Awake()
    {
        int vida = 3;
    textopuntos.text = "Vida: " + vida;
    }
    void Update()
    {
        Vector3 moveDirection = new Vector3(moveInput.x, moveInput.y, 0f).normalized;
        transform.Translate(moveDirection * speed * Time.deltaTime);

        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationAngle * Time.deltaTime);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    private void OnTriggerEnter(Collider other)
    {
        vida--; 
        Debug.Log("Colisión con " + other.gameObject.name + ". Vida restante: " + vida);
        textopuntos.text = "Vida: " + vida;

        if (vida <= 0)
        {
            SceneManager.LoadScene("Perder");
        }
    }
}
