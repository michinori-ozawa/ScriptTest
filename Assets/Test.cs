using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔法
    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    // 魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp < 5)
        {
            // mpが4以下だった場合の処理
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else if (this.mp >= 5)
        {
            this.mp -= 5;
            // mpが5以上だった場合の処理
            Debug.Log("魔法攻撃をした。残りMPは〇〇。" + this.mp);
        }
    }
}

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];
        // 配列の各要素に値を代入する
        array[0] = 00;
        array[1] = 11;
        array[2] = 22;
        array[3] = 33;
        array[4] = 44;
        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        // 配列の要素をすべて表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
 
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す
        lastboss.Magic();
        // 10回処理を繰り返す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
