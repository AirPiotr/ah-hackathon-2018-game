using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    private bool hasCollided = false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && !hasCollided)
        {
            Interact(col.gameObject);

            hasCollided = true;
        }
    }

    protected abstract void Interact(GameObject gameObject);
}