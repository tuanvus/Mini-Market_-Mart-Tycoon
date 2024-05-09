using UCExtension.Common;
using UnityEngine;

public class Character : RecylableObject
{
	[SerializeField]
	protected CharacterAnimationController animationController;

	[SerializeField]
	protected StackCollector stackCollector;

	[SerializeField]
	private EmojiUI emojiPrefab;

	[SerializeField]
	private Transform emojiFollowTarget;

	private EmojiUI currentEmoji;

	public StackCollector Collector => null;

	public CharacterAnimationController AnimationController => null;

	protected virtual void Awake()
	{
	}

	public override void Recyle()
	{
	}

	protected virtual void RegisterEvents()
	{
	}

	public virtual void OnCollectObject()
	{
	}

	public virtual void OnEmptyObject()
	{
	}

	public void ChangeEmoji(EmojiType emojiType)
	{
	}

	public void HideEmoji()
	{
	}
}
