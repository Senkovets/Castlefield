using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuildingStationBehaviour : MonoBehaviour, IStationStateSwithcer
{
    [SerializeField] public int _level;

    private BuildingVisualBehaviour _visualBehaviuor; 

    private BaseBuildState _currentSate;
    private List<BaseBuildState> _allStates;

    private void Start()
    {
        _visualBehaviuor = GetComponent<BuildingVisualBehaviour>();

       

        _allStates = new List<BaseBuildState>()
        {
            new NoBuildingState(_level, _visualBehaviuor, this),
            new EconomicsBuildingState(_level, _visualBehaviuor, this),
            new BarrackBuildingState(_level, _visualBehaviuor, this)
        };

        _currentSate = _allStates[0];


        StartCoroutine(ProduceTimer());
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

    private IEnumerator ProduceTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Debug.Log("Timer");
            Produce();
        }
    }
    
    
    public void SwitchSatte<T>() where T : BaseBuildState
    {
        var state = _allStates.FirstOrDefault(s => s is T);
        _currentSate.Stop();
        state.StartState();
        _currentSate = state;
    }

}
