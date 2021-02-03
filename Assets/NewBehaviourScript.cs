using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public Rigidbody2D rb;
    public float movespeed;
    public int flag = 0;
    public float jump;
    public float horizontal;
    public float move;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movespeed = 1.5f;
        jump = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){   

            rb.AddForce(new Vector2(0,jump)); 
            horizontal = Input.GetAxis("Horizontal");  
            move = horizontal*movespeed; 
            rb.velocity = new Vector2(move,rb.velocity.y);  

        }
    	if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(flag == 0){
                transform.Rotate(new Vector3(0, 180, 0));
                flag = 1;
            }
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(flag == 1){
                transform.Rotate(new Vector3(0, 180, 0));
                flag = 0;
            }
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
 
        }
        
    }
}