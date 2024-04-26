using UnityEngine;

// INHERITANCE
public class Player : Person {
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        HandleInput();
        Name = "Bob";
        print(Name);
    }

    // ABSTRACTION
    private void HandleInput() {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        
        Move(horizontalInput, verticalInput);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    // ABSTRACTION
    private void Move(float horizontalInput, float verticalInput) {
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }

    // POLYMORPHISM
    protected override void Jump() {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }


}
