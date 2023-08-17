namespace GameAF;

public interface IMap
{
    IEnemy CreateEnemy();
    IObstacle CreateObstacle();
}
public interface IEnemy
{
    void Attact();
}

public interface IObstacle
{
    void interact();
}
