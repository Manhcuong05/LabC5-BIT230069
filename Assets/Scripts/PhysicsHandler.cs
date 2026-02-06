using UnityEngine;

public class PhysicsHandler : MonoBehaviour
{
    // Hàm này gọi khi có va chạm vật lý (va chạm cứng)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("==> COLLISION: Player đã chạm vào " + collision.gameObject.name);
    }

    // Hàm này gọi khi đi xuyên qua vật thể có tích Is Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("==> TRIGGER: Player đã đi xuyên qua " + other.gameObject.name);
    }
}