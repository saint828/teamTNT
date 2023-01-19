using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
  [SerializeField] private GameObject TargetSprite;

  public void OnClick(Sprite NextSprite)
  {
    TargetSprite =  GameObject.FindGameObjectWithTag("BreakObject");
    if (TargetSprite == null)
    {
      Debug.Log($"{nameof(TargetSprite)} が null です。");
      return;
    }
    if (NextSprite == null)
    {
      Debug.Log($"{nameof(NextSprite)} が null です。");
      return;
    }
    var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
    if (spriteRenderer == null)
    {
      Debug.Log($"{nameof(TargetSprite)} に {nameof(SpriteRenderer)} コンポーネントがありません。");
      return;
    }
    spriteRenderer.sprite = NextSprite;
  }
}