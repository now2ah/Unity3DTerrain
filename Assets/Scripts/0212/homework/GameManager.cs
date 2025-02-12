using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Monster monster;

    private void Start()
    {
        player.Initialize();
        monster.Initialize();
    }
}
