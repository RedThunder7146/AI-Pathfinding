using UnityEngine;

public class GhostScatterState : GhostState

{

    public GhostScatterState(GhostScript ghost, GhostStateMachine sm) : base(ghost, sm)
    {
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        ghost.nav.destination = new Vector3(ghost.ghostSO.retreatXPos, ghost.ghostSO.retreatYPos, ghost.ghostSO.retreatZPos);
    }
}
