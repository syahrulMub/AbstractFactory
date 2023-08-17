namespace GameAF;

public class Jungle : IMap
{
    public IEnemy CreateEnemy()
    {
        return new Ogre();
    }

    public IObstacle CreateObstacle()
    {
        return new Rock();
    }
}

//if we depending one map with an enemy and Obstacle

public class Mountain
{
    public Ogre CreateEnemy()
    {
        return new Ogre();
    }
    public Rock CreateObstacle()
    {
        return new Rock();
    }
}
//in this mauntain map, how if i want to add eagle anamy to the game?
//i must create new method create anamy for eagle
// but actually it same with how agre attacking 

//in jungle map, if i want to add enemy eagle, i just change the return type as list and adding eagle to the map
