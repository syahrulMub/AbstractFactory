namespace GameAF;

public class GameRunner
{
    public void Play(IMap map)
    {
        IEnemy enemy = map.CreateEnemy();
        IObstacle obstacle = map.CreateObstacle();


    }
    //example if abstract factory not implement
    public void PlayMountain(Mountain mountain)
    {
        Ogre enemyOgre = mountain.CreateEnemy();
        Rock rockObstacle = mountain.CreateObstacle();
    }

    //how if we have more map to play in the game?
    //should we make all method play on the game runner?
    //if you have 10 map on your game, you must crate 10 method also for each map

    //but if you set reference type for enemy and map as interface
    //you dont need make 10 method for your map
    //just give the user what they want
    //and if you create new map on your game, you did not need to update your game runner for your new map
}


