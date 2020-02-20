public class StateDesignPattern : StateMachine
{
    public string BattleLog="BattleLog";

    private void Start() {
        SetState(new Start(this));
    }

    
}