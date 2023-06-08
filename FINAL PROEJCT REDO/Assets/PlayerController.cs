using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 110;
    private Rigidbody playerRb;
    public bool hasPowerup;
    private float powerupStrength = 5000.0f;
    private GameManager gameManager;
    public Button button;


    void Start()
    {
    playerRb = GetComponent<Rigidbody>();
    button = GetComponent<Button>();
    }

    
    void Update()
    {
    float horizonatalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    playerRb.AddForce(Vector3.forward * speed * verticalInput);
    playerRb.AddForce(Vector3.right * speed * horizonatalInput);
}




    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Powerup")) { 
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine()); 
        }
     }

    IEnumerator PowerupCountdownRoutine() {
        yield return new WaitForSeconds(7); 
        hasPowerup = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup) {

            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Collide with " + collision.gameObject.name 
            + " with power set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

}
