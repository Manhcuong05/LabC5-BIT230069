using UnityEngine;

public class PhysicsLogic3D : MonoBehaviour
{
    // Gọi khi chạm vào vật thể cứng (Collision)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION: Đã va chạm vật lý với " + collision.gameObject.name);
        // Có thể thêm hiệu ứng đổi màu khi va chạm để ảnh báo cáo đẹp hơn
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Gọi khi đi xuyên qua vùng cảm biến (Trigger)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER: Đã đi xuyên qua vùng " + other.gameObject.name);
        // Đổi màu khác khi đi qua vùng Trigger
        GetComponent<Renderer>().material.color = Color.green;
    }
}