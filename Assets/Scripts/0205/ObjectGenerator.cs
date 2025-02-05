using TMPro;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject targetObjectPrefab;
    public int maxTargetAmount = 5;
    public GameObject shootObjectPrefab;
    public float power = 1000f;
    public int score = 0;
    GameObject scoreText;
    public int curTargetAmount = 0;

    public void AddScore(int value)
    {
        score += value;
        _SetScoreText();
    }

    void _SetScoreText()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = $"Á¡¼ö : {score}";
    }

    bool _IsUnderAmount()
    {
        if (curTargetAmount < maxTargetAmount)
            return true;
        else
            return false;
    }

    void MakeTarget()
    {
        if (_IsUnderAmount() )
        {
            int xPos = Random.Range(-50, 50);
            Instantiate(targetObjectPrefab, new Vector3(xPos, 0, 0), Quaternion.identity);
            curTargetAmount++;
        }
    }

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText");
        _SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        MakeTarget();
        if (Input.GetMouseButtonDown(0))
        {
            var thrown = Instantiate(shootObjectPrefab, Camera.main.transform.position + Camera.main.transform.forward * 5.0f, Quaternion.identity);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 direction = ray.direction;

            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);
        }
    }
}
