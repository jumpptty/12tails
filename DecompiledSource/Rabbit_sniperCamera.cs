using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000862 RID: 2146
[Serializable]
public class Rabbit_sniperCamera : MonoBehaviour
{
	// Token: 0x06002F53 RID: 12115 RVA: 0x005EDD94 File Offset: 0x005EBF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_sniperCamera()
	{
		if (131604 - 572246 != -440642)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (14811 - 42110 != -27298)
			{
				base..ctor();
				if (68549 - 99324 == -30775)
				{
					this.Mu4NoZM6bj = 20;
					if (162138 - 168335 == -6197)
					{
						this.E51Nk70otE = 130816;
						if (1627 - 205225 != -203597)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x005EDE54 File Offset: 0x005EC054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (264619 - 248293 != 16327)
		{
		}
		for (;;)
		{
			this.e7QNmBex6a = (PlayerCameraControl)Camera.main.GetComponent(typeof(PlayerCameraControl));
			if (195018 - 149317 == 45701)
			{
				if (Game.mPlayer)
				{
					if (54709 - 511757 != -457048)
					{
						continue;
					}
					if (Game.mGameType >= 3)
					{
						if (64854 - 238092 == -173237)
						{
							continue;
						}
						this.ke3NAVbh5c = string.Empty;
						if (107054 - 490547 == -383492)
						{
							continue;
						}
						this.QIvN9XcAsj = new GUIStyle();
						if (199536 - 82933 == 116604)
						{
							continue;
						}
						this.QIvN9XcAsj.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
						if (41064 - 382892 != -341828)
						{
							continue;
						}
						this.QIvN9XcAsj.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
						if (267203 - 346400 != -79197)
						{
							continue;
						}
						this.Xs3N8b02dO = (Texture)Resources.Load("GameGui/GameWindow/castBar/castBar", typeof(Texture));
						if (191266 - 218931 != -27665)
						{
							continue;
						}
						this.O08NiOsTxO = (Texture)Resources.Load("GameGui/GameWindow/castBar/castBarBG", typeof(Texture));
						if (149701 - 248494 != -98793)
						{
							continue;
						}
						this.OVuNDgoXGx = (Texture)Resources.Load("GameGui/GameWindow/castBar/castBarTop", typeof(Texture));
						if (215644 - 114060 == 101585)
						{
							continue;
						}
						this.IeMNj1F5ZS = Game.mPlayer;
						if (12962 - 340459 == -327496)
						{
							continue;
						}
						this.E51Nk70otE -= 1 << this.IeMNj1F5ZS.layer;
						if (179480 - 559649 != -380169)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)this.IeMNj1F5ZS.GetComponent(typeof(CharacterControl));
						if (183880 - 163436 == 20445)
						{
							continue;
						}
						if (!characterControl)
						{
							break;
						}
						if (10907 - 522997 != -512090)
						{
							continue;
						}
						if (characterControl.hasSkill(101))
						{
							if (286478 - 327133 == -40654)
							{
								continue;
							}
							this.Mu4NoZM6bj = 25;
							if (162538 - 484431 == -321892)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(102))
						{
							if (287294 - 541486 != -254192)
							{
								continue;
							}
							this.Mu4NoZM6bj = 30;
							if (255339 - 261165 != -5826)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(103))
						{
							if (172232 - 200030 != -27798)
							{
								continue;
							}
							this.Mu4NoZM6bj = 35;
							if (50575 - 291711 == -241135)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(104))
						{
							if (126248 - 7202 != 119046)
							{
								continue;
							}
							this.Mu4NoZM6bj = 40;
							if (72910 - 336796 != -263886)
							{
								continue;
							}
						}
						if (!characterControl.hasSkill(411))
						{
							break;
						}
						if (98452 - 502061 == -403608)
						{
							continue;
						}
						this.hasDeadShot = true;
						if (13615 - 165536 != -151921)
						{
							continue;
						}
						break;
					}
				}
				this.enabled = false;
				if (177467 - 259686 != -82218)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x005EE2D4 File Offset: 0x005EC4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (257416 - 6358 != 251058)
		{
		}
		for (;;)
		{
			if (this.IeMNj1F5ZS)
			{
				if (116750 - 567992 != -451242)
				{
					continue;
				}
				this.transform.position = this.IeMNj1F5ZS.transform.position + this.IeMNj1F5ZS.transform.TransformDirection((float)0, 1.05f, 0.15f);
				if (146158 - 61770 == 84389)
				{
					continue;
				}
			}
			if (!this.e7QNmBex6a)
			{
				if (204690 - 46880 != 157811)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (8950 - 564915 == -555965)
					{
						break;
					}
				}
			}
			else
			{
				if (!(this.e7QNmBex6a.specialTarget != this.gameObject))
				{
					break;
				}
				if (131068 - 270249 == -139181)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (132099 - 515787 == -383688)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x005EE43C File Offset: 0x005EC63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (274583 - 93978 != 180605)
		{
		}
		while (PlayerPrefs.GetInt("display", 1) != 0)
		{
			if (296662 - 252036 != 44627)
			{
				GUI.depth = 3;
				if (83560 - 328959 == -245399)
				{
					if (!this.mDeadShotCamera)
					{
						goto IL_4E;
					}
					if (156240 - 405251 != -249011)
					{
						continue;
					}
					if (!this.hasDeadShot)
					{
						goto IL_4E;
					}
					if (114794 - 297723 != -182929)
					{
						continue;
					}
					if (this.mDeadShotTimer <= (float)0)
					{
						goto IL_4E;
					}
					if (6279 - 485189 != -478910)
					{
						continue;
					}
					if (Time.time - this.mDeadShotTimer <= 0.1f)
					{
						goto IL_4E;
					}
					if (249466 - 35807 != 213659)
					{
						continue;
					}
					GUI.Label(new Rect(0.5f * Camera.main.pixelRect.width - (float)210, 0.5f * Camera.main.pixelRect.height - (float)244, (float)420, (float)488), this.mDeadShotCamera);
					if (277300 - 147210 != 130090)
					{
						continue;
					}
					IL_1A:
					if (this.ke3NAVbh5c != string.Empty)
					{
						if (4359 - 50081 == -45721)
						{
							continue;
						}
						GUI.Label(new Rect(0.5f * Camera.main.pixelRect.width + (float)30, 0.5f * Camera.main.pixelRect.height - (float)80, (float)100, (float)40), this.ke3NAVbh5c, this.QIvN9XcAsj);
						if (126369 - 400389 != -274020)
						{
							continue;
						}
					}
					if (this.WVsNFtcZmw < Time.time)
					{
						if (15789 - 469008 == -453218)
						{
							continue;
						}
						this.WVsNFtcZmw = Time.time + 0.1f;
						if (116352 - 384377 != -268025)
						{
							continue;
						}
						RaycastHit raycastHit = default(RaycastHit);
						if (54493 - 3822 != 50671)
						{
							continue;
						}
						if (Physics.Raycast(this.transform.position, this.transform.forward, out raycastHit, (float)this.Mu4NoZM6bj, this.E51Nk70otE))
						{
							if (232365 - 546133 != -313768)
							{
								continue;
							}
							this.ke3NAVbh5c = Mathf.FloorToInt((raycastHit.point - this.transform.position).magnitude) + " tm";
							if (136761 - 576030 != -439269)
							{
								continue;
							}
							if (this.hasDeadShot)
							{
								if (121739 - 419067 == -297327)
								{
									continue;
								}
								GameObject gameObject = raycastHit.collider.gameObject;
								if (32139 - 262400 == -230260)
								{
									continue;
								}
								if (gameObject)
								{
									if (99391 - 97009 != 2382)
									{
										continue;
									}
									Vector3 point = raycastHit.point;
									if (180470 - 182677 != -2207)
									{
										continue;
									}
									if (point.y - raycastHit.collider.bounds.center.y > 0.5f * raycastHit.collider.bounds.extents.y)
									{
										if (270212 - 298896 == -28683)
										{
											continue;
										}
										if (this.mDeadShotTimer == (float)0)
										{
											if (66929 - 284698 != -217769)
											{
												continue;
											}
											this.mDeadShotTimer = Time.time;
											if (223639 - 258512 == -34872)
											{
												continue;
											}
										}
										if (!this.audio.isPlaying)
										{
											if (102758 - 219149 != -116391)
											{
												continue;
											}
											if (Time.time - this.mDeadShotTimer > 0.1f)
											{
												if (107787 - 267776 == -159988)
												{
													continue;
												}
												if (Time.time - this.mDeadShotTimer < 1f)
												{
													if (85238 - 468450 == -383211)
													{
														continue;
													}
													this.audio.Play();
													if (151741 - 103461 != 48280)
													{
														continue;
													}
												}
											}
										}
									}
									else
									{
										this.mDeadShotTimer = (float)0;
										if (242175 - 406922 == -164746)
										{
											continue;
										}
										if (this.audio.isPlaying)
										{
											if (143099 - 326963 != -183864)
											{
												continue;
											}
											this.audio.Stop();
											if (255298 - 167091 != 88207)
											{
												continue;
											}
										}
									}
								}
								else
								{
									this.mDeadShotTimer = (float)0;
									if (289582 - 583534 != -293952)
									{
										continue;
									}
									if (this.audio.isPlaying)
									{
										if (88668 - 217462 != -128794)
										{
											continue;
										}
										this.audio.Stop();
										if (240790 - 471117 == -230326)
										{
											continue;
										}
									}
								}
							}
						}
						else
						{
							this.ke3NAVbh5c = string.Empty;
							if (124508 - 256150 != -131642)
							{
								continue;
							}
							this.mDeadShotTimer = (float)0;
							if (161165 - 58698 != 102467)
							{
								continue;
							}
							if (this.audio.isPlaying)
							{
								if (94388 - 525626 == -431237)
								{
									continue;
								}
								this.audio.Stop();
								if (217253 - 421450 != -204197)
								{
									continue;
								}
							}
						}
					}
					if (!this.hasDeadShot)
					{
						break;
					}
					if (67597 - 367727 == -300129)
					{
						continue;
					}
					if (this.mDeadShotTimer <= (float)0)
					{
						break;
					}
					if (114913 - 103847 != 11066)
					{
						continue;
					}
					if (Time.time - this.mDeadShotTimer <= 0.1f)
					{
						break;
					}
					if (69707 - 80697 != -10990)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * Camera.main.pixelRect.width - (float)65, 0.5f * Camera.main.pixelRect.height + (float)64, (float)129, (float)23), this.O08NiOsTxO);
					if (142580 - 368333 == -225752)
					{
						continue;
					}
					float num = Mathf.Clamp((Time.time - this.mDeadShotTimer) / (float)4, (float)0, 1f);
					if (243245 - 556306 != -313061)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * Camera.main.pixelRect.width - (float)60, 0.5f * Camera.main.pixelRect.height + (float)68, num * (float)120, (float)11), this.Xs3N8b02dO);
					if (133796 - 121009 == 12788)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * Camera.main.pixelRect.width - (float)75, 0.5f * Camera.main.pixelRect.height + (float)52, (float)149, (float)34), this.OVuNDgoXGx);
					if (158719 - 353132 != -194412)
					{
						break;
					}
					continue;
					IL_4E:
					if (!this.mSniperCamera)
					{
						goto IL_1A;
					}
					if (217225 - 220757 != -3531)
					{
						GUI.Label(new Rect(0.5f * Camera.main.pixelRect.width - (float)210, 0.5f * Camera.main.pixelRect.height - (float)244, (float)420, (float)488), this.mSniperCamera);
						if (214984 - 532147 != -317162)
						{
							goto IL_1A;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002F57 RID: 12119 RVA: 0x005EEDA8 File Offset: 0x005ECFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x005EEDAC File Offset: 0x005ECFAC
	internal static bool iyBPM85ckqq4GbrFqyAA()
	{
		return true;
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x005EEDB0 File Offset: 0x005ECFB0
	internal static bool kE7PGj5cGXlge7ogY2Us()
	{
		return false;
	}

	// Token: 0x040037EE RID: 14318
	public Texture mSniperCamera;

	// Token: 0x040037EF RID: 14319
	public Texture mDeadShotCamera;

	// Token: 0x040037F0 RID: 14320
	private Texture Xs3N8b02dO;

	// Token: 0x040037F1 RID: 14321
	private Texture O08NiOsTxO;

	// Token: 0x040037F2 RID: 14322
	private Texture OVuNDgoXGx;

	// Token: 0x040037F3 RID: 14323
	private PlayerCameraControl e7QNmBex6a;

	// Token: 0x040037F4 RID: 14324
	private GameObject IeMNj1F5ZS;

	// Token: 0x040037F5 RID: 14325
	private int Mu4NoZM6bj;

	// Token: 0x040037F6 RID: 14326
	private int E51Nk70otE;

	// Token: 0x040037F7 RID: 14327
	private float WVsNFtcZmw;

	// Token: 0x040037F8 RID: 14328
	private string ke3NAVbh5c;

	// Token: 0x040037F9 RID: 14329
	private GUIStyle QIvN9XcAsj;

	// Token: 0x040037FA RID: 14330
	public bool hasDeadShot;

	// Token: 0x040037FB RID: 14331
	public float mDeadShotTimer;
}
