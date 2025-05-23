using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator PlayerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpsound;
    public AudioClip crashsound;
    private AudioSource playerAudio;
    public float jumppower = 10;
    public float gravitymodifier;
    public bool isonGround = true;
    public bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is create
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;
        PlayerAnim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround && !gameOver)
        {
            PlayerAnim.SetTrigger("Jump_trig");
            playerRB.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
            isonGround = false;
            playerAudio.PlayOneShot(jumpsound, 1.0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {


         if (collision.gameObject.CompareTag("ground"))
        {
            isonGround = true;
        }
        else if (collision.gameObject.CompareTag("Obastacle"))
        { 
            Debug.Log("game over");
            gameOver = true;
            PlayerAnim.SetBool("Death_b", true);
            PlayerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashsound, 1.0f);
        }
   
    }

}
