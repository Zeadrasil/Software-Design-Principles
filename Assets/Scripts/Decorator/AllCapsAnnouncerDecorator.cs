using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AllCapsAnnouncerDecorator : MonoBehaviour, IAnnouncer
{
    [SerializeField] private IAnnouncer wrappee;
    [SerializeField] private GameObject target;

    public void Announce(string statement)
    {
        wrappee.Announce(statement.ToUpper());
    }

    private void Start()
    {
        if (wrappee == null)
        {
            if (target != null)
            {
                wrappee = target.GetComponent<IAnnouncer>();
            }
            else
            {
                wrappee = GameManager.Instance;
            }
        }
    }
}
