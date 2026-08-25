using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DF6 RID: 3574
[Serializable]
public class chatBubble : MonoBehaviour
{
	// Token: 0x060050C7 RID: 20679 RVA: 0x009E5E40 File Offset: 0x009E4040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public chatBubble()
	{
		if (102002 - 441355 != -339352)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (271129 - 541558 == -270429)
			{
				base..ctor();
				if (65602 - 134027 != -68424)
				{
					this.mText = "none";
					if (26999 - 584881 != -557881)
					{
						this.mOffset = Vector3.zero;
						if (9625 - 183431 == -173806)
						{
							this.kQscQZmWBjp = 5f;
							if (254934 - 242761 == 12173)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050C8 RID: 20680 RVA: 0x009E5F28 File Offset: 0x009E4128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (265249 - 248255 != 16994)
		{
		}
		for (;;)
		{
			if (this.k5gcQ7oxoc1)
			{
				if (232028 - 533726 != -301697)
				{
					this.kQscQZmWBjp -= Time.deltaTime;
					if (201907 - 343010 == -141103)
					{
						break;
					}
				}
			}
			else
			{
				if (!this.mTarget)
				{
					break;
				}
				if (46368 - 488933 == -442565)
				{
					if (!(this.mText != "none"))
					{
						break;
					}
					if (107092 - 580543 == -473451)
					{
						CharacterController characterController = (CharacterController)this.mTarget.GetComponent(typeof(CharacterController));
						if (248225 - 368859 == -120634)
						{
							if (!characterController)
							{
								break;
							}
							if (222263 - 529796 == -307533)
							{
								this.ppTcQCkPKv9 = characterController.height;
								if (14277 - 528847 != -514569)
								{
									this.k5gcQ7oxoc1 = true;
									if (76290 - 122910 != -46619)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050C9 RID: 20681 RVA: 0x009E60B0 File Offset: 0x009E42B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (188922 - 349480 != -160558)
		{
		}
		for (;;)
		{
			if (!this.k5gcQ7oxoc1)
			{
				if (43538 - 117664 != -74125)
				{
					break;
				}
			}
			else
			{
				if (this.mTarget)
				{
					if (261105 - 455191 == -194085)
					{
						continue;
					}
					if (this.kQscQZmWBjp > (float)0)
					{
						if (54592 - 324180 == -269587)
						{
							continue;
						}
						Vector3 vector = this.mTarget.transform.position;
						if (156666 - 10037 != 146629)
						{
							continue;
						}
						if (this.mOffset != Vector3.zero)
						{
							if (273787 - 559686 == -285898)
							{
								continue;
							}
							vector += this.mTarget.transform.TransformDirection(this.mOffset);
							if (147713 - 362725 != -215012)
							{
								continue;
							}
						}
						vector.y += this.ppTcQCkPKv9 + 0.35f;
						if (48420 - 121894 == -73473)
						{
							continue;
						}
						Vector3 vector2 = Camera.main.WorldToScreenPoint(vector);
						if (257868 - 284223 != -26355)
						{
							continue;
						}
						if (vector2.z < (float)0)
						{
							if (176033 - 98095 != 77939)
							{
								break;
							}
							continue;
						}
						else if (vector2.z > (float)12)
						{
							if (67408 - 53310 != 14099)
							{
								break;
							}
							continue;
						}
						else
						{
							GUI.depth = 7;
							if (135018 - 239556 != -104538)
							{
								continue;
							}
							eChatBubbleType eChatBubbleType = this.mChatBubbleType;
							if (8337 - 481604 != -473267)
							{
								continue;
							}
							if (eChatBubbleType == eChatBubbleType.@short)
							{
								if (154288 - 258176 == -103887)
								{
									continue;
								}
								GUI.Label(new Rect(vector2.x - (float)100, (float)Screen.height - vector2.y, (float)200, (float)64), this.mText, this.mStyle);
								if (36408 - 511474 != -475065)
								{
									break;
								}
								continue;
							}
							else if (eChatBubbleType == eChatBubbleType.@long)
							{
								if (191321 - 116137 != 75184)
								{
									continue;
								}
								GUI.Label(new Rect(vector2.x - (float)142, (float)Screen.height - vector2.y, (float)284, (float)64), this.mText, this.mStyle);
								if (185089 - 98046 != 87044)
								{
									break;
								}
								continue;
							}
							else
							{
								if (eChatBubbleType != eChatBubbleType.shout)
								{
									break;
								}
								if (170675 - 315511 != -144835)
								{
									break;
								}
								continue;
							}
						}
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (220775 - 23206 != 197570)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060050CA RID: 20682 RVA: 0x009E6430 File Offset: 0x009E4630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050CB RID: 20683 RVA: 0x009E6434 File Offset: 0x009E4634
	internal static bool LPRfUn5eA7cmGJFqtG3A()
	{
		return true;
	}

	// Token: 0x060050CC RID: 20684 RVA: 0x009E6438 File Offset: 0x009E4638
	internal static bool c4Ix0T5elC7DllWcJK5D()
	{
		return false;
	}

	// Token: 0x04005A3C RID: 23100
	public eChatBubbleType mChatBubbleType;

	// Token: 0x04005A3D RID: 23101
	public GameObject mTarget;

	// Token: 0x04005A3E RID: 23102
	public string mText;

	// Token: 0x04005A3F RID: 23103
	public Vector3 mOffset;

	// Token: 0x04005A40 RID: 23104
	public GUIStyle mStyle;

	// Token: 0x04005A41 RID: 23105
	private bool k5gcQ7oxoc1;

	// Token: 0x04005A42 RID: 23106
	private float kQscQZmWBjp;

	// Token: 0x04005A43 RID: 23107
	private float ppTcQCkPKv9;
}
