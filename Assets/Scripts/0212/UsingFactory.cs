using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UsingFactory : MonoBehaviour
{
    EnemyFactory enemyFactory;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyFactory = new EnemyFactory();
        List<IActionable> enemies = new List<IActionable>();
        enemies.Add((IActionable)enemyFactory.Create(EnemyFactory.eEnemyType.GOBLIN));
        enemies.Add((IActionable)enemyFactory.Create(EnemyFactory.eEnemyType.SLIME));
        enemies.Add((IActionable)enemyFactory.Create(EnemyFactory.eEnemyType.WOLF));

        foreach (var enemy in enemies)
        {
            enemy.Action();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
