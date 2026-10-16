using UnityEngine;

public class GhostChaseState : GhostState
{

    public GhostChaseState(GhostScript ghost, GhostStateMachine sm) : base(ghost, sm)
    {
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    float timer = 0;
    // Update is called once per frame
    public override void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > 20)
        {
            sm.ChangeState(sm.GhostScatterState);
        }


        if (ghost.ghostSO.name == "Blinky" || ghost.ghostSO.name == "Pinky")
        {
            GoToPacman();
        }
    }

    void GoToPacman()
    {
        ghost.nav.destination = ghost.pacman.position;
    }
}
