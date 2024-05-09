using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MartIncomItemUI : MonoBehaviour
{
	[SerializeField]
	private Text progressText;

	[SerializeField]
	private Image progressImage;

	[SerializeField]
	private Text rewardText;

	[SerializeField]
	private Timer collectTimer;

	[SerializeField]
	private GameObject hereGroup;

	[SerializeField]
	private GameObject countDownGroup;

	[SerializeField]
	private GameObject collectGroup;

	[SerializeField]
	private Button goButton;

	[SerializeField]
	private Button collectButton;

	[SerializeField]
	private Button collectExtraButton;

	[SerializeField]
	private GameObject LockedGroup;

	[SerializeField]
	private GameObject UnlockedGroup;

	public UnityAction<int> OnGoToMapEvent;

	private int reward;

	private int currentMapIndex;

	private void Awake()
	{
	}

	public void SetUp(int mapIndex)
	{
	}

	public void ResetInfor()
	{
	}

	private void SetUpTimer()
	{
	}

	private void StartCountDown(int timeCountDown)
	{
	}

	private void OnClickGoButton()
	{
	}

	private void OnClickCollectButton()
	{
	}

	private void OnClickCollectExtraButton()
	{
	}

	private void GetExtra()
	{
	}
}
