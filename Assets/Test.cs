using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public void Magic(int usemp)
    {
        this.mp -= usemp;
        if (mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);


        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic(5);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}