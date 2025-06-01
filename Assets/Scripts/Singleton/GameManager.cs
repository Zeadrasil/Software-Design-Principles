using UnityEngine;

public class GameManager : MonoBehaviour, IMovable, IAnnouncer
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindFirstObjectByType<GameManager>();
                if(instance == null)
                {
                    instance = new GameObject().AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Print(string text)
    {
        Debug.Log(text);
    }
    public void ProcessUpButton()
    {
        Print("Pressed Up");
    }
    public void ProcessLeftButton()
    {
        Print("Pressed Left");
    }
    public void ProcessRightButton()
    {
        Print("Pressed Right");
    }
    public void ProcessDownButton()
    {
        Print("Pressed Down");
    }

    public void Announce(string statement)
    {
        Debug.Log(statement);
    }
}
