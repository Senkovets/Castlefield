using UnityEngine;
using UnityEngine.UI;

public class EconomicsBuildingState : BaseBuildState
{
    public EconomicsBuildingState(int level, BuildingVisualBehaviour visualBehaviuor, IStationStateSwithcer stateSwithcer) : base(level, visualBehaviuor, stateSwithcer)
    {
    }

    public override void StartState()
    {

    }

    public override void Stop()
    {

    }

    public override void Sell()
    {
        Debug.Log("Sell");
        _stateSwither.SwitchSatte<NoBuildingState>();
    }

    public override void Produce()
    {
        Debug.Log("Coin++");
        _visualBehaviuor.EconomicsProduce();
        
    }

    public override void Upgrade()
    {
        Debug.Log("UpgradeEconom");
        _stateSwither.SwitchSatte<BarrackBuildingState>();
    }


}
