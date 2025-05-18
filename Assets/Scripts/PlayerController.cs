using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float rotationSpeed = 720f;

    private CharacterController controller;
    private Vector2 inputMovement;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(inputMovement.x, 0, inputMovement.y);
        if (move.sqrMagnitude > 0.01f)
        {
            Vector3 lookDirection = new Vector3(move.x, 0, move.z);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.LookRotation(lookDirection),
                rotationSpeed * Time.deltaTime);
        }
        controller.SimpleMove(move * moveSpeed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<Vector2>();
    }
}
