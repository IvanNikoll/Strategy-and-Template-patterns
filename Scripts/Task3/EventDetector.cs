using System.Collections.Generic;
using UnityEngine;

public class EventDetector: MonoBehaviour
{
    private List<Ball> _enemiesList;
    private ICounter _counter;
    private bool _isPlayModeSelected;

    public void Update() => _counter?.Update(Time.deltaTime);

    public void CreateEnemiesList()
    {
        _enemiesList = new List<Ball>();
        Ball[] listedEnemies = FindObjectsOfType<Ball>();
        _enemiesList.AddRange(listedEnemies);
        _counter.SetEnemiesList(_enemiesList);
    }
    
    public void OnClick()
    {
        Ray pointRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(pointRay, out RaycastHit rayCastHit) && _counter != null)
        {
            OnRayEnter(rayCastHit);
        }

    }

    public void SetCounter(ICounter counter)
    {

        if (_isPlayModeSelected != true)
        {
            _isPlayModeSelected = true;
            _counter = counter;
            CreateEnemiesList();
        }

    }

    private void OnRayEnter(RaycastHit rayCastHit)
    {
        Collider hitcollider = rayCastHit.collider;

        if (hitcollider.gameObject.TryGetComponent<Ball>(out Ball target))
        {
            if (target != null)
            {
                _counter.OnEnemySpotted(target);
                Destroy(target.gameObject);
            }

        }

    }
}
