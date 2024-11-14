using UnityEngine;

public class MonsterB : Monster
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //INHERITANCE
    public void J()
    {
        Jump();
    }

    //POLYMORPHISM 
    public override void JumpShort()
    {
        jumpHeight = 2.0f;
    }
}
