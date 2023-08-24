using System.Collections.Generic;

public interface ICounter 
{
    void SetEnemiesList(List<Ball> enemiesList);
    void Update(float deltaTime);

    void OnEnemySpotted(Ball target);
}
