using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumppower = 10;
    public float gravitymodifier;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
        }

    }
}
