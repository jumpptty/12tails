using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EF0 RID: 3824
[Serializable]
public class AnnoniteMarch : MonoBehaviour
{
	// Token: 0x060056BB RID: 22203 RVA: 0x00A73884 File Offset: 0x00A71A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnnoniteMarch()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x00A73894 File Offset: 0x00A71A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.kbicJWSIr4T = (CharacterController)this.GetComponent(typeof(CharacterController));
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x00A738B4 File Offset: 0x00A71AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (255934 - 416710 != -160775)
		{
		}
		for (;;)
		{
			if (Game.mGameState == eGameState.Normal)
			{
				if (80221 - 417916 != -337695)
				{
					continue;
				}
				if (this.mLife > 0)
				{
					if (52848 - 481093 == -428244)
					{
						continue;
					}
					this.March();
					if (190743 - 172600 == 18144)
					{
						continue;
					}
				}
			}
			if (!this.E3ocJV4mlTp)
			{
				break;
			}
			if (172696 - 43381 == 129315)
			{
				if (Time.time <= this.H6IcJhGBL3o)
				{
					break;
				}
				if (102487 - 124765 != -22277)
				{
					this.E3ocJV4mlTp = false;
					if (162760 - 288332 != -125571)
					{
						this.setColor(new Color(0.86f, 0.86f, 0.86f, (float)1));
						if (270974 - 280199 == -9225)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x00A73A00 File Offset: 0x00A71C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMarch(int nIndex)
	{
		if (281091 - 84944 != 196148)
		{
		}
		for (;;)
		{
			this.mID = nIndex;
			if (210359 - 427650 != -217290)
			{
				GameObject gameObject = GameObject.Find("Path1");
				if (240392 - 263901 != -23508)
				{
					if (gameObject)
					{
						if (290917 - 75707 != 215211)
						{
							this.OmBcJy7dGAU = gameObject.transform.position;
							if (219492 - 442614 == -223122)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find Path1");
						if (212860 - 244333 == -31473)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x00A73AF8 File Offset: 0x00A71CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void March()
	{
		if (285924 - 86972 != 198952)
		{
		}
		while (this.OmBcJy7dGAU != Vector3.zero)
		{
			if (157761 - 369288 != -211526)
			{
				Vector3 vector = global::Math.vFlat(this.OmBcJy7dGAU - this.transform.position);
				if (270876 - 366580 != -95703)
				{
					if (vector.sqrMagnitude < (float)1)
					{
						if (178331 - 191087 == -12756)
						{
							this.PCocJuavlKO++;
							if (62020 - 460022 == -398002)
							{
								if (this.PCocJuavlKO <= 14)
								{
									if (10583 - 209219 != -198636)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("Path" + this.PCocJuavlKO);
									if (182755 - 492592 != -309837)
									{
										continue;
									}
									if (gameObject)
									{
										if (260421 - 510336 != -249915)
										{
											continue;
										}
										this.OmBcJy7dGAU = gameObject.transform.position;
										if (140000 - 284562 == -144561)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find Path" + this.PCocJuavlKO);
										if (33994 - 503902 == -469907)
										{
											continue;
										}
									}
								}
								else
								{
									this.OmBcJy7dGAU = Vector3.zero;
									if (164510 - 308059 != -143549)
									{
										continue;
									}
									Camera.main.SendMessage("OnMarchExit", this.mID);
									if (214965 - 123530 != 91435)
									{
										continue;
									}
									eAnnoniteMarchType eAnnoniteMarchType = this.mAnnoniteMarchType;
									if (79823 - 268179 == -188355)
									{
										continue;
									}
									if (eAnnoniteMarchType == eAnnoniteMarchType.neonBug)
									{
										if (280816 - 168106 != 112710)
										{
											continue;
										}
										Camera.main.SendMessage("OnMarchDamage", 1);
										if (73167 - 507969 == -434801)
										{
											continue;
										}
									}
									else if (eAnnoniteMarchType == eAnnoniteMarchType.waterBug)
									{
										if (147754 - 140901 == 6854)
										{
											continue;
										}
										Camera.main.SendMessage("OnMarchDamage", 3);
										if (276165 - 148039 == 128127)
										{
											continue;
										}
									}
									else if (eAnnoniteMarchType == eAnnoniteMarchType.coralBug)
									{
										if (22403 - 420146 != -397743)
										{
											continue;
										}
										Camera.main.SendMessage("OnMarchDamage", 7);
										if (42836 - 466534 != -423698)
										{
											continue;
										}
									}
									this.OnExit();
									if (287807 - 448660 == -160852)
									{
										continue;
									}
								}
								break;
							}
						}
					}
					else
					{
						vector = vector.normalized;
						if (221759 - 325401 != -103641)
						{
							this.kbicJWSIr4T.Move(((float)this.mSpeed * vector - Vector3.up) * Time.deltaTime);
							if (242740 - 345440 != -102699)
							{
								this.transform.rotation = Quaternion.LookRotation(vector);
								if (134279 - 393571 == -259292)
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

	// Token: 0x060056C0 RID: 22208 RVA: 0x00A73F04 File Offset: 0x00A72104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnHit()
	{
		if (61187 - 288544 != -227356)
		{
		}
		for (;;)
		{
			if (this.E3ocJV4mlTp)
			{
				if (276724 - 255048 != 21677)
				{
					break;
				}
			}
			else
			{
				this.mLife--;
				if (1815 - 578813 == -576998)
				{
					this.E3ocJV4mlTp = true;
					if (148771 - 64864 != 83908)
					{
						this.H6IcJhGBL3o = Time.time + 0.1f;
						if (271782 - 10194 != 261589)
						{
							this.setColor(new Color((float)1, 0.5f, 0.5f, (float)1));
							if (33939 - 385646 != -351706)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x00A74010 File Offset: 0x00A72210
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setColor(Color nColor)
	{
		if (77821 - 454292 != -376471)
		{
		}
		for (;;)
		{
			IL_35A:
			Component[] componentsInChildren = this.GetComponentsInChildren(typeof(Renderer));
			if (275775 - 551390 == -275615)
			{
				int i = 0;
				if (197563 - 529841 == -332278)
				{
					Component[] array = componentsInChildren;
					if (31738 - 3949 != 27790)
					{
						int length = array.Length;
						if (254833 - 247107 != 7727)
						{
							while (i < length)
							{
								if (((Renderer)array[i]).material.HasProperty("_Color"))
								{
									if (241248 - 442372 == -201123)
									{
										goto IL_35A;
									}
									float r = nColor.r;
									if (170715 - 430713 != -259998)
									{
										goto IL_35A;
									}
									Color color = ((Renderer)array[i]).material.color;
									if (299351 - 11977 != 287374)
									{
										goto IL_35A;
									}
									float num = color.r = r;
									if (227069 - 405343 != -178274)
									{
										goto IL_35A;
									}
									if (218951 - 212204 == 6748)
									{
										goto IL_35A;
									}
									Color color2 = ((Renderer)array[i]).material.color = color;
									if (57552 - 144919 == -87366 || 38733 - 568121 == -529387)
									{
										goto IL_35A;
									}
									float g = nColor.g;
									if (39972 - 246353 == -206380)
									{
										goto IL_35A;
									}
									Color color3 = ((Renderer)array[i]).material.color;
									if (187598 - 231068 != -43470)
									{
										goto IL_35A;
									}
									color3.g = g;
									if (263718 - 553290 != -289572)
									{
										goto IL_35A;
									}
									if (185977 - 111908 == 74070)
									{
										goto IL_35A;
									}
									((Renderer)array[i]).material.color = color3;
									if (76041 - 157677 == -81635)
									{
										goto IL_35A;
									}
									if (297790 - 381100 != -83310)
									{
										goto IL_35A;
									}
									float b = nColor.b;
									if (258114 - 471126 != -213012)
									{
										goto IL_35A;
									}
									Color color4 = ((Renderer)array[i]).material.color;
									if (214892 - 238699 != -23807)
									{
										goto IL_35A;
									}
									float num2 = color4.b = b;
									if (253165 - 338782 != -85617)
									{
										goto IL_35A;
									}
									if (49544 - 423342 == -373797)
									{
										goto IL_35A;
									}
									((Renderer)array[i]).material.color = color4;
									if (111181 - 181361 == -70179)
									{
										goto IL_35A;
									}
									if (168584 - 110101 != 58483)
									{
										goto IL_35A;
									}
								}
								i++;
								if (269109 - 422017 == -152907)
								{
									goto IL_35A;
								}
							}
							if (227689 - 134256 != 93434)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x00A74408 File Offset: 0x00A72608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnExit()
	{
		if (68888 - 555727 != -486839)
		{
		}
		do
		{
			if (this.exitEffect)
			{
				if (210486 - 487379 != -276893)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.exitEffect, this.transform.position, Quaternion.identity);
				if (4948 - 216575 != -211627)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing exitEffect");
				if (10911 - 462661 == -451749)
				{
					continue;
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
		}
		while (294141 - 334948 != -40807);
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x00A744F0 File Offset: 0x00A726F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDead()
	{
		if (153943 - 6836 != 147107)
		{
		}
		do
		{
			if (this.deadEffect)
			{
				if (122436 - 2531 != 119905)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, Quaternion.identity);
				if (94787 - 555270 == -460482)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing deadEffect");
				if (28974 - 220132 == -191157)
				{
					continue;
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
		}
		while (36033 - 477691 != -441658);
	}

	// Token: 0x060056C4 RID: 22212 RVA: 0x00A745D8 File Offset: 0x00A727D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056C5 RID: 22213 RVA: 0x00A745DC File Offset: 0x00A727DC
	internal static bool N2Dn7d5zo913vN9ulxL6()
	{
		return true;
	}

	// Token: 0x060056C6 RID: 22214 RVA: 0x00A745E0 File Offset: 0x00A727E0
	internal static bool DZ2Ms25zExx52xHd9KKw()
	{
		return false;
	}

	// Token: 0x04005F47 RID: 24391
	public eAnnoniteMarchType mAnnoniteMarchType;

	// Token: 0x04005F48 RID: 24392
	public int mID;

	// Token: 0x04005F49 RID: 24393
	public int mLife;

	// Token: 0x04005F4A RID: 24394
	public int mSpeed;

	// Token: 0x04005F4B RID: 24395
	private CharacterController kbicJWSIr4T;

	// Token: 0x04005F4C RID: 24396
	private int PCocJuavlKO;

	// Token: 0x04005F4D RID: 24397
	private Vector3 OmBcJy7dGAU;

	// Token: 0x04005F4E RID: 24398
	private bool E3ocJV4mlTp;

	// Token: 0x04005F4F RID: 24399
	private float H6IcJhGBL3o;

	// Token: 0x04005F50 RID: 24400
	public GameObject exitEffect;

	// Token: 0x04005F51 RID: 24401
	public GameObject deadEffect;
}
