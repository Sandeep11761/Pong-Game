using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public GameObject bullet;
    public GameObject gunpoint;
    public int bulletSpeed = 10;
    public Animator run;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
        {

            run.SetBool("Run", true);
            player.transform.Translate(Vector3.forward * Time.deltaTime);

        }
            
        if(Input.GetKey(KeyCode.S))
            player.transform.Translate(Vector3.back * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            player.transform.Rotate(0,1, 0);
        if (Input.GetKey(KeyCode.A))
            player.transform.Rotate(0,-1,0);


       /* var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        player.transform.Translate(Vector3.forward*vertical * Time.deltaTime);
        player.transform.Rotate(0, horizontal, 0);*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
                Shoot();            
        }


    }
    public void Shoot()
    {
        var _bullet=Instantiate(bullet, gunpoint.transform.position, transform.rotation);

        _bullet.GetComponent<Rigidbody>().AddForce(transform.forward*bulletSpeed);

    }
   

}
