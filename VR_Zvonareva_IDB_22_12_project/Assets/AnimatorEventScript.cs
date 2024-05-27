using UnityEngine;

public class AnimatorEventScript : MonoBehaviour
{
    /*void Awake()
    {
        Kub1 = GameObject.Find("Cube (2)").transform;
        Kub2 = GameObject.Find("Cube (3)").transform;
        Kub3 = GameObject.Find("Cube (4)").transform;
        Telega = GameObject.Find("hand-truck-007").transform;
        Stol = GameObject.Find("lod0").transform;
        Kruk = GameObject.Find("Robotic_hand.015_low").transform;
    }*/

    public Transform Kub1;
    public Transform Kub2;
    public Transform Kub3;       // Объект, который нужно переместить
    public Transform Telega;      // Первый родитель
    public Transform Stol;      // Второй родитель
    public Transform Kruk;

    public void MoveToKruk1()
    {
        Debug.Log('a');
        /*print(Kub1.name);
        print(Kruk.name);*/
        Kub1.SetParent(Kruk);
        // Сброс позиции локальных координат
        // Kub1.localPosition = Vector3(-1.005, 1.77400005, 0.0670000017);
        Kub1.localPosition = Vector3.zero;
    }

    public void MoveToStol1()
    {
        Debug.Log('b');
        Kub1.SetParent(Stol);
        // Сброс позиции локальных координат
        Kub1.localPosition = Vector3.zero;
        
        ///////////Kub1.localPosition = new Vector3(0f,0.167999998f,0.0890000015f);

    }

    public void MoveToTelega1()
    {
        Kub1.SetParent(Telega);
        // Сброс позиции локальных координат
        Kub1.localPosition = Vector3.zero;
    }

    public void MoveToKruk2()
    {
        Kub2.SetParent(Kruk);
        // Сброс позиции локальных координат
        Kub2.localPosition = Vector3.zero;
    }

    public void MoveToStol2()
    {
        Kub2.SetParent(Stol);
        // Сброс позиции локальных координат
        // Kub2.localPosition = Vector3.zero;
    }

    public void MoveToTelega2()
    {
        Kub2.SetParent(Telega);
        // Сброс позиции локальных координат
        Kub2.localPosition = Vector3.zero;
    }

    public void MoveToKruk3()
    {
        Kub3.SetParent(Kruk);
        // Сброс позиции локальных координат
        Kub3.localPosition = Vector3.zero;
    }

    public void MoveToStol3()
    {
        Kub3.SetParent(Stol);
        // Сброс позиции локальных координат
        Kub3.localPosition = new Vector3(-0.00116646243f, 0.0118682217f, 0.0320000015f);
        
    }

    public void MoveToTelega3()
    {
        Kub3.SetParent(Telega);
        // Сброс позиции локальных координат
        Kub3.localPosition = Vector3.zero;
    }

}
