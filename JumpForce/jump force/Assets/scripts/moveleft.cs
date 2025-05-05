using UnityEngine;

public class moveleft : MonoBehaviour
{
    private float speed = 20;
    private playercontroller Playercontrollerscript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playercontrollerscript = GameObject.Find("player").GetComponent<playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Playercontrollerscript.gameOver == false)
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
      

    }
}
