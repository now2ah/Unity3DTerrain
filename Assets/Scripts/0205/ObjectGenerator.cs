using System.Collections;
using TMPro;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject targetObjectPrefab;
    public int maxTargetAmount = 3;
    public GameObject shootObjectPrefab;
    public float maxPower = 100f;
    public float chargeSpeed = 0.5f;
    public int score = 0;
    public int curTargetAmount = 0;
    public float targetRange = 50.0f;
    public TextMeshProUGUI chargeText;
    public Material newSkyBox;
    public TextMeshProUGUI clearText;
    GameObject _scoreText;
    float power = 0f;

    public void AddScore(int value)
    {
        score += value;
        _SetScoreText();
    }

    void _SetScoreText()
    {
        _scoreText.GetComponent<TextMeshProUGUI>().text = $"Á¡¼ö : {score}";
    }

    IEnumerator MakeTargetCoroutine(int count)
    {
        for (int i=0; i<count; i++)
        {
            int xPos = Random.Range((int)(targetRange * -1.0f), (int)targetRange);
            Instantiate(targetObjectPrefab, new Vector3(xPos, 0, 0), Quaternion.identity);
            curTargetAmount++;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void _Charge()
    {
        if (Input.GetMouseButton(0))
        {
            power += chargeSpeed;
            if (power >= maxPower)
                power = maxPower;

            ApplyTextUI();
        }
    }

    void ApplyTextUI()
    {
        if (null != chargeText)
        {
            float ratio = power / maxPower * 100;
            chargeText.text = ratio.ToString("N2") + " %";
        }
    }

    void _ShootProjectile()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var thrown = Instantiate(shootObjectPrefab, Camera.main.transform.position + Camera.main.transform.forward * 5.0f, Quaternion.identity);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 direction = ray.direction;

            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);

            power = 0f;
        }
    }

    void _CheckAllTargetGone()
    {
        if (curTargetAmount == 0 && null != newSkyBox && null != clearText)
        {
            RenderSettings.skybox = newSkyBox;
            clearText.gameObject.SetActive(true);
        }
    }

    private void Start()
    {
        _scoreText = GameObject.Find("ScoreText");
        _SetScoreText(); 
        StartCoroutine(MakeTargetCoroutine(maxTargetAmount));
    }

    // Update is called once per frame
    void Update()
    {
        _ShootProjectile();
        _Charge();
        _CheckAllTargetGone();
    }
}
