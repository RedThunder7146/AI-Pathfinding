using UnityEngine;

public class GhostIdleState : GhostState
{
    public GhostIdleState(GhostScript ghost, GhostStateMachine sm) : base(ghost, sm)
    {
    }

    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    public override void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > ghost.ghostSO.cooldown)
        {
            sm.ChangeState(sm.GhostChaseState);
        }
    }
}
