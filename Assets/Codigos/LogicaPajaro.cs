using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 1;
    public float rotacion= 10;
    private Rigidbody2D rb;
    public ControladorEscena controladorEscena;
    private AudioSource Audio;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        Audio= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up* velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation= Quaternion.Euler(0,0, rb.velocity.y* rotacion);
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        Audio.Pause();
        Audio.PlayOneShot(Resources.Load<AudioClip>("Colision"));
       

        controladorEscena.Perdiste();
    }

        
}
