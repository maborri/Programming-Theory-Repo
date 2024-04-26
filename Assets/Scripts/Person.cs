using UnityEngine;

public class Person : MonoBehaviour {
    private const int maxNameLength = 4;
    
    // ENCAPSULATION
    public string Name { 
        get { return m_name; } 
        set {
            if (value.Length > maxNameLength) {
                Debug.LogError("Name must be shorter");
            } else {
                m_name = value;
            }
        } 
    } 
    private string m_name;

    public int health = 10;
    public float speed = 10;

    protected Rigidbody rb;
    protected float jumpForce = 20.0f;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM
    protected virtual void Jump() {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
