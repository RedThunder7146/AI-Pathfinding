using UnityEngine;

public class GhostState : MonoBehaviour
{
    protected GhostScript ghost;
    protected GhostStateMachine sm;

    public float verticalInput;
    public float horizontalInput;


    // base constructor
    public GhostState(GhostScript ghost, GhostStateMachine sm)
    {
        this.ghost = ghost;
        this.sm = sm;
    }

    //methods that can be overriden by each state
    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
    public virtual void Exit() { }
    public virtual void OnCollisionEnter2D(Collision2D collision) { }
    public virtual void OnTriggerEnter2D(Collider2D collision) { }
    public virtual void OnTriggerExit2D(Collider2D collision) { }



    //Common Shared Methods
    //Put methods that you wish to share between other states here
    //Set them to be public
    public void TestMethod(string text)
    {
        Debug.Log(text);
    }
    public void ReadInput()
    {
    }
}
