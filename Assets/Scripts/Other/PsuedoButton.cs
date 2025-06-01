using UnityEngine;

public class PsuedoButton : MonoBehaviour
{
    [SerializeField] private RectTransform clickArea;
    [SerializeField] private int type = 0;
    private IAnnouncer announcer;
    private ICommandInterface command;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && RectTransformUtility.RectangleContainsScreenPoint(clickArea, Input.mousePosition))
        {
            command?.Execute();
            announcer?.Announce("Hello World");
        }
    }

    private void Start()
    {
        switch (type)
        {
            case 0:
                command = new MoveUp(GameManager.Instance);
                break;
            case 1:
                command = new MoveRight(GameManager.Instance);
                break;
            case 2:
                command = new MoveDown(GameManager.Instance);
                break;
            case 3:
                command = new MoveLeft(GameManager.Instance);
                break;
            default:
                announcer = GetComponent<IAnnouncer>();
                break;
        }
    }
}
