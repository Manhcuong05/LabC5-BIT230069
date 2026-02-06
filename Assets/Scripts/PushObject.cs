using UnityEngine;

public class PushObject : MonoBehaviour
{
    public float forceAmount = 500f;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // Nhấn phím Cách (Space) để đẩy quả cầu về phía trước
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector3.forward * forceAmount);
        }
    }
}