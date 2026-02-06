using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5.0f;
    public float gravity = -9.81f;
    private Vector3 velocity;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        // Lấy đầu vào từ bàn phím (WASD / Mũi tên)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        // Sử dụng Move() để di chuyển
        controller.Move(move * speed * Time.deltaTime);

        // Xử lý trọng lực cơ bản để nhân vật luôn bám đất
        if (controller.isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}