using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class GhostScript : MonoBehaviour
{

    GhostStateMachine sm;

    public GhostSO ghostSO;
    public NavMeshAgent nav;
    public Transform pacman;


    //define the actions
    public InputAction moveAction;



    public enum AnimationActions
    {
        Idle,
        Move,
        Powered,
        Dead
    }
    public AnimationActions myAction;

    private void Start()
    {
        sm = new GhostStateMachine(this); //"this" means - pass a reference of this script (player script) to the statemachine

       sm.Init(sm.GhostIdleState); //this will be the first state to run 

        //initialise the actions
        moveAction = InputSystem.actions.FindAction("Move");



    }

    private void Update()
    {
        //do not put any of your own methods here - they go in the individual state files
        sm.Update();

        UIscript.ui.DrawText("Current state= " + sm.currentState + "  Last state= " + sm.lastState);

    }

    private void FixedUpdate()
    {
        //do not put any of your own methods here - they go in the state files
        sm.FixedUpdate();
    }

    //add your additional collision handling here
    void OnCollisionEnter2D(Collision2D collision)
    {
        sm.currentState.OnCollisionEnter2D(collision);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        sm.currentState.OnTriggerEnter2D(collision);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        sm.currentState.OnTriggerExit2D(collision);
    }
    public void OnAnimationEvent(AnimationActions _myAction)
    {
        myAction = _myAction;
    }




}
