public class BattleBehaviour : StateMachine
{

    public string BattleLog="BattleLog";

    private void Start() {
        SetState(new Start(this));
    }

    public void OnAttack(){
        BattleLog = "OnAttack";
    }

    public void OnHeal(){
        BattleLog = "OnHeal";
    }
}