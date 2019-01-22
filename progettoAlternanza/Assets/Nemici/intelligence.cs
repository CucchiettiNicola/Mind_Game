using UnityEngine;

public class intelligence : MonoBehaviour {

    public Rigidbody rb;

    public float walk = -200f;

    void FixedUpdate() {
        rb.AddForce(0, 0, walk * Time.deltaTime);
    }
}
