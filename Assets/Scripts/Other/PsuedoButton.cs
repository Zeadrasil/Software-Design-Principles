using UnityEngine;

public class PsuedoButton : MonoBehaviour
{
    [SerializeField] private RectTransform clickArea;
    [SerializeField] private int type = 0;
    private ICommandInterface command;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && RectTransformUtility.RectangleContainsScreenPoint(clickArea, Input.mousePosition))
        {
            command.Execute();
        }
    }

    private void Start()
    {
        switch (type)
        {
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
                command = new MoveUp(GameManager.Instance);
                break;
        }

    }
}
