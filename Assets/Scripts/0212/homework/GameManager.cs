using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Monster monster;

    private void Start()
    {
        player.Initialize();

        for (int i=0; i < 10; i++)
        {
            Monster monsterObj = Instantiate(monster, new Vector3(i * 2f, 0, 60f), Quaternion.identity);
            monsterObj.Initialize();
        }
    }
}
