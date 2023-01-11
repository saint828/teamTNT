using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
  [SerializeField] private GameObject TargetSprite;

  [SerializeField] private Sprite NextSprite;

  public void OnClick()
  {
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

    // 変更対象のオブジェクトが持つ SpriteRenderer を取得
    var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
    if (spriteRenderer == null)
    {
      Debug.Log($"{nameof(TargetSprite)} に {nameof(SpriteRenderer)} コンポーネントがありません。");
      return;
    }

    // SpriteRenderer の sprite に変更後のスプライトをセット
    spriteRenderer.sprite = NextSprite;
  }
}