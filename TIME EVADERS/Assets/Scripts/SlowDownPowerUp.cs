using UnityEngine;

public class SlowDownPowerUp : MonoBehaviour {
    public float slowDownFactor = 0.5f;
    private bool powerUpActivated = false;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Hit");
        if (other.CompareTag("MovingObject")) {
            Debug.Log("IN function");
            powerUpActivated = true;
            gameObject.SetActive(false);
        }
    }

    void Update() {
        if (powerUpActivated) {
            GameObject[] movingObjects = GameObject.FindGameObjectsWithTag("MovingObject");
            foreach (GameObject obj in movingObjects) {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                if (rb != null) {
                    rb.velocity *= slowDownFactor;
                }
            }
        }
    }
}
