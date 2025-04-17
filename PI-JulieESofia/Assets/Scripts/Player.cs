using UnityEngine;

public class Player : MonoBehaviour
{
    public UI_DOINVENTARIO inventory;
    private void Awake()
    {
        inventory = new UI_DOINVENTARIO(21);

    }
}
