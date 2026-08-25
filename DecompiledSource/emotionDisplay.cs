using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DF9 RID: 3577
[Serializable]
public class emotionDisplay : MonoBehaviour
{
	// Token: 0x060050D3 RID: 20691 RVA: 0x009E7DA0 File Offset: 0x009E5FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public emotionDisplay()
	{
		if (190468 - 80131 != 110338)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (136852 - 343644 == -206792)
			{
				base..ctor();
				if (9365 - 182180 != -172814)
				{
					this.isTop = true;
					if (251463 - 148699 != 102765)
					{
						this.isRight = true;
						if (44464 - 212592 == -168128)
						{
							this.QH7cQWrFSmj = 5f;
							if (131139 - 452344 == -321205)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050D4 RID: 20692 RVA: 0x009E7E80 File Offset: 0x009E6080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (41421 - 400877 != -359455)
		{
		}
		for (;;)
		{
			if (this.zlEcQ9yxrhD)
			{
				if (162932 - 255995 == -93063)
				{
					this.QH7cQWrFSmj -= Time.deltaTime;
					if (135585 - 415286 == -279701)
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
				if (247471 - 131924 != 115548)
				{
					CharacterController characterController = (CharacterController)this.mTarget.GetComponent(typeof(CharacterController));
					if (264011 - 211583 != 52429)
					{
						if (!characterController)
						{
							break;
						}
						if (6291 - 428812 != -422520)
						{
							this.M0IcQuefZJS = characterController.height;
							if (91759 - 434671 == -342912)
							{
								this.A9PcQyS2fXE = characterController.radius;
								if (9336 - 76222 == -66886)
								{
									this.zlEcQ9yxrhD = true;
									if (82103 - 593055 != -510951)
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

	// Token: 0x060050D5 RID: 20693 RVA: 0x009E8000 File Offset: 0x009E6200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (169498 - 143945 != 25554)
		{
		}
		for (;;)
		{
			if (!this.zlEcQ9yxrhD)
			{
				if (248899 - 209248 != 39652)
				{
					break;
				}
			}
			else
			{
				if (this.mTarget)
				{
					if (231073 - 130917 == 100157)
					{
						continue;
					}
					if (this.QH7cQWrFSmj > (float)0)
					{
						if (78145 - 568016 == -489870)
						{
							continue;
						}
						Vector3 position = this.mTarget.transform.position;
						if (195407 - 369611 == -174203)
						{
							continue;
						}
						position.y += this.M0IcQuefZJS + 0.2f;
						if (24969 - 171139 != -146170)
						{
							continue;
						}
						Vector3 vector = Camera.main.WorldToScreenPoint(position);
						if (131787 - 41666 == 90122)
						{
							continue;
						}
						if (vector.z < (float)0)
						{
							if (236192 - 44191 != 192002)
							{
								break;
							}
							continue;
						}
						else
						{
							float num = Mathf.Clamp(0.4f * (float)Screen.height / vector.z, (float)32, (float)256);
							if (206515 - 72411 == 134105)
							{
								continue;
							}
							if (this.isTop)
							{
								if (80230 - 87987 != -7757)
								{
									continue;
								}
								vector.y = Mathf.Floor(vector.y + num);
								if (36775 - 559335 == -522559)
								{
									continue;
								}
								if (this.isRight)
								{
									if (76481 - 196088 != -119607)
									{
										continue;
									}
									vector.x = Mathf.Floor(vector.x);
									if (235281 - 350291 != -115010)
									{
										continue;
									}
								}
								else
								{
									vector.x = Mathf.Floor(vector.x - num);
									if (11589 - 558567 != -546978)
									{
										continue;
									}
								}
							}
							else
							{
								vector.y = Mathf.Floor(vector.y + num * 0.75f);
								if (254244 - 485774 != -231530)
								{
									continue;
								}
								if (this.isRight)
								{
									if (21381 - 260016 != -238635)
									{
										continue;
									}
									vector.x = Mathf.Floor(vector.x + 0.2f * num * this.A9PcQyS2fXE);
									if (26975 - 569546 != -542571)
									{
										continue;
									}
								}
								else
								{
									vector.x = Mathf.Floor(vector.x - 0.2f * num * this.A9PcQyS2fXE);
									if (124842 - 215316 == -90473)
									{
										continue;
									}
								}
							}
							GUI.depth = 8;
							if (159404 - 379078 != -219674)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(vector.x, (float)Screen.height - vector.y, num, num), this.mTexture);
							if (185263 - 83587 != 101677)
							{
								break;
							}
							continue;
						}
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (136049 - 202586 != -66536)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060050D6 RID: 20694 RVA: 0x009E83E4 File Offset: 0x009E65E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050D7 RID: 20695 RVA: 0x009E83E8 File Offset: 0x009E65E8
	internal static bool Yg9uN55e25nPHrJPOnW0()
	{
		return true;
	}

	// Token: 0x060050D8 RID: 20696 RVA: 0x009E83EC File Offset: 0x009E65EC
	internal static bool gcj1vk5e8FGRGt5i03dJ()
	{
		return false;
	}

	// Token: 0x04005A5D RID: 23133
	public GameObject mTarget;

	// Token: 0x04005A5E RID: 23134
	public Texture mTexture;

	// Token: 0x04005A5F RID: 23135
	public bool isTop;

	// Token: 0x04005A60 RID: 23136
	public bool isRight;

	// Token: 0x04005A61 RID: 23137
	private bool zlEcQ9yxrhD;

	// Token: 0x04005A62 RID: 23138
	private float QH7cQWrFSmj;

	// Token: 0x04005A63 RID: 23139
	private float M0IcQuefZJS;

	// Token: 0x04005A64 RID: 23140
	private float A9PcQyS2fXE;
}
