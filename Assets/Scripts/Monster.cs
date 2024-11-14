using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //ABSTRACTION
    //This is more of my take then an example, as an example would include redudandant code
    //Anbstraction is a best practice to code efficiently (succint) and for future re-usability

    //ENCAPSULATION
    public float health { get; private set; }
    public float jumpHeight = 10.0f;

    public AudioClip soundClip;
    private AudioSource audioSource;

    private Rigidbody playerRb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 20.0f;
        audioSource = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jump()
    {
        JumpShort();
        Start();
        audioSource.Play();
        playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

    public virtual void JumpShort()
    {
        jumpHeight = 5.0f;
    }
}
