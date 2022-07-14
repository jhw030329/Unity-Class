using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    // ����
    // �⺻ ���� �����ڴ� private �Դϴ�.
    public int price;
    public string name;
    public Sprite sprite;

    // �⺻ ������ 
    // �����ڸ� �������� ������ �ڵ����� �⺻ �����ڸ� ���������ݴϴ�.

}

public class LifeCycle : MonoBehaviour
{
    // ����Ƽ������ �Ҹ��ڰ� �������� �ʽ��ϴ�.
    public Data [] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake() // <- 1��°
    {
        for(int i = 0; i < data.Length; i++)
        {
            priceUI[i].text = data[i].price.ToString();
            nameUI[i].text = data[i].name;
            spriteUI[i].sprite = data[i].sprite;
        }
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnble");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        
    }
}
