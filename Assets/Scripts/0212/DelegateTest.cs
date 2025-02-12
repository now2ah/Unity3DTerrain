using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DelegateTest : MonoBehaviour
{
    delegate void EntityDelegate();

    public GameObject entity;
    public Button addRotateBtn;
    public Button removeRotateBtn;
    public Button addMoveBtn;
    public Button removeMoveBtn;
    public Button actionBtn;


    List<GameObject> entityList;

    public void Initialize()
    {
        entityList = new List<GameObject>();
        for (int i=0; i<5; i++)
        {
            entityList.Add(Instantiate(entity, new Vector3(i * 5, 0, 0), Quaternion.identity));
        }

    }

    public void AddRotate()
    {
        
    }

    private void Start()
    {

    }
}
