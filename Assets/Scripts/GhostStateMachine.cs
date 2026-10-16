using UnityEngine;

public class GhostStateMachine
{
    public GhostState currentState, lastState;

    //declare all states here
    public GhostIdleState GhostIdleState;
    public GhostChaseState GhostChaseState;
    public GhostScatterState GhostScatterState;



    //constructor
    public GhostStateMachine(GhostScript ghost)
    {
        //initialise all states here
        GhostIdleState = new GhostIdleState(ghost, this);
        GhostChaseState = new GhostChaseState(ghost, this);
        GhostScatterState = new GhostScatterState(ghost, this);


    }

    public void Init(GhostState startingState)
    {
        currentState = startingState;
        lastState = null;
        startingState.Enter();
    }

    public void ChangeState(GhostState newState)
    {
        currentState.Exit();

        lastState = currentState;
        currentState = newState;
        newState.Enter();
    }

    

    public void Update()
    {
        currentState.Update();
    }

    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

    
}
