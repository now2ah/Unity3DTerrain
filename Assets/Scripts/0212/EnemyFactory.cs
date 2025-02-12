using UnityEngine;

public class EnemyFactory
{
    public enum eEnemyType
    {
        GOBLIN,
        SLIME,
        WOLF
    }

    public Enemy Create(eEnemyType type)
    {
        Enemy enemy = null;
        switch (type)
        {
            case eEnemyType.GOBLIN:
                enemy = new Goblin();
                break;
            case eEnemyType.SLIME:
                enemy = new Slime();
                break;
            case eEnemyType.WOLF:
                enemy = new Wolf();
                break;
            default:
                break;

        }
        return enemy;
    }
}
