using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuildingStationBehaviour : MonoBehaviour, IStationStateSwithcer
{
    [SerializeField] private Text _statusText;

    private BaseBuildState _currentSate;
    private List<BaseBuildState> _allStates;

    private void Start()
    {
        _allStates = new List<BaseBuildState>()
        {
            new NoBuildingState(_statusText, this),
            new EconomicsBuildingState(_statusText, this),
            new BarrackBuildingState(_statusText, this)
        };
        _currentSate = _allStates[0];
    }

    public void Produce()
    {
        _currentSate.Produce();
    }

    public void Sell()
    {
        _currentSate.Sell();
    }

    public void Upgrade()
    {
        _currentSate.Upgrade();
    }
    
    
    public void SwitchSatte<T>() where T : BaseBuildState
    {
        var state = _allStates.FirstOrDefault(s => s is T);
        _currentSate.Stop();
        state.Start();
        _currentSate = state;
    }
}
