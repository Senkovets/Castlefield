using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    private bool _isSpawning;
    public GameObject UnitPrefab;
    public float SpawnTime;
    public int SpawnCount;
    private void Start()
    {
        On();
    }
    public void On()
    {
        _isSpawning = true;
        StartCoroutine(Spawn());
    }
    public void Off()
    {
        _isSpawning = false;
        StopCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (_isSpawning)
        {
            yield return new WaitForSeconds(SpawnTime);
            UnitStack _unitStack = Instantiate(UnitPrefab, _spawnPoint.position, UnitPrefab.transform.rotation).GetComponent<UnitStack>();
            _unitStack.AddAmount(SpawnCount);
        }
    }
}
