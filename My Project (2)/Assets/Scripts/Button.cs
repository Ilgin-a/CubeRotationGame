using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    public bool isHit;

    public Counter counter;

    [SerializeField] private AudioSource successSoundEffect;
    [SerializeField] private AudioSource missedSoundEffect;
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        if ((Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x % 90) <= 10) && isHit)
        {
            successSoundEffect.Play();
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();

        }
        else
        {
            missedSoundEffect.Play();
        }

    }

    public IEnumerator ResetHit()
    {
        
        isHit = false;
        yield return new WaitForSeconds(0.5f);
        isHit = true;
    }
}

