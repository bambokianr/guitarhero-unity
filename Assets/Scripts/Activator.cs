using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
  private SpriteRenderer sr;
  public KeyCode key;
  private bool active = false;
  private GameObject note;
  private Color primaryColor;

  // diferença entre Start e Awake?
  private void Awake()
  {
    sr = GetComponent<SpriteRenderer>();
  }

  private void Start()
  {
    primaryColor = sr.color;
  }

  private void Update()
  {
    if (Input.GetKeyDown(key))
    {
      StartCoroutine(Pressed());

      if (active)
        Destroy(note);
    }
  }

  private IEnumerator Pressed()
  {
    sr.color = new Color(0, 0, 0); // alterar para uma cor no mesmo tom da cor original

    yield return new WaitForSeconds(0.05f);

    sr.color = primaryColor;
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    active = true;

    if (other.gameObject.tag == "Note")
      note = other.gameObject;
  }

  private void OnTriggerExit2D(Collider2D other)
  {
    active = false;
  }
}
