using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        // Brings in rigidbody, animator, and audio source from Unity Editor
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Executes code when player jumps
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && !gameOver){
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            //Plays sound on jump
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Executes code when player is on ground   
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
            dirtParticle.Play();
        }
        // Executes code when player collides with obstacle
        else if(collision.gameObject.CompareTag("Obstacle")){
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            // Plays sound on obstacle collision
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
