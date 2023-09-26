using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EatCandy : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] UnityEvent _onAte;
    [SerializeField] UnityEvent _onAteAfterDelay;

    [SerializeField] string _nextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag("Candy"))
        {
            _animator.SetTrigger("Ate");
            Destroy(collision.attachedRigidbody.gameObject);
            StartCoroutine(CloseDoorRoutine());
        }
    }

    IEnumerator CloseDoorRoutine()
    {
        _onAte.Invoke();

        yield return new WaitForSeconds(1f);

        _onAteAfterDelay.Invoke();

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(_nextSceneName);
    }



}