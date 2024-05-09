using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmojiUI : TransformFollowerUI
{
	[SerializeField]
	private Image emojiImage;

	[SerializeField]
	private List<Sprite> emojiSprites;

	public void SetEmoji(EmojiType type)
	{
	}
}
