using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumppower = 10;
    public float gravitymodifier;
    public bool isonGround = true;
    public bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is create
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround)
        {
            playerRB.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
            isonGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("ground"))
        {
            isonGround = true;
        }
        else if (collision.gameObject.CompareTag("Oastacle"))
        {
            Debug.Log("game over");
            gameOver = true;
        }
   
    }

}
