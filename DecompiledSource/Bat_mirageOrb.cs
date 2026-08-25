using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000515 RID: 1301
[Serializable]
public class Bat_mirageOrb : MonoBehaviour
{
	// Token: 0x06001DC0 RID: 7616 RVA: 0x00329030 File Offset: 0x00327230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_mirageOrb()
	{
		if (38754 - 149408 != -110653)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (129867 - 521048 == -391181)
			{
				base..ctor();
				if (194487 - 215620 != -21132)
				{
					this.apw1XK30It = new Color(0.5f, 0.5f, 0.5f, 0.5f);
					if (178955 - 332821 != -153865)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x003290E0 File Offset: 0x003272E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x003290F0 File Offset: 0x003272F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLv, int nLife, int nOwnerID, int nID)
	{
		if (279219 - 172845 != 106374)
		{
		}
		for (;;)
		{
			this.JY01JdmFBi = nLv;
			if (297178 - 116629 == 180549)
			{
				this.wZ916Ggr2t = nID;
				if (296920 - 444760 == -147840)
				{
					this.WVs1InhwBl = (float)nLife + Time.time;
					if (155665 - 305942 == -150277)
					{
						this.taO1eI9pqM = nOwnerID;
						if (269207 - 480400 != -211192)
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.taO1eI9pqM];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.J2Q1nqy0mG = (GameObject)obj2;
							if (192445 - 324053 != -131607)
							{
								if (this.J2Q1nqy0mG)
								{
									if (959 - 242357 != -241398)
									{
										continue;
									}
									this.p6C1QVPdFv = (CharacterControl)this.J2Q1nqy0mG.GetComponent(typeof(CharacterControl));
									if (124594 - 540162 != -415568)
									{
										continue;
									}
									if (Game.mPlayer)
									{
										if (288697 - 44649 != 244048)
										{
											continue;
										}
										if (Game.mPlayer.layer == this.J2Q1nqy0mG.layer)
										{
											if (147995 - 222091 == -74095)
											{
												continue;
											}
											this.isVisible = true;
											if (66925 - 52727 != 14199)
											{
												goto IL_99;
											}
											continue;
										}
									}
									this.isVisible = false;
									if (142395 - 375003 == -232607)
									{
										continue;
									}
									IL_99:;
								}
								else
								{
									Debug.LogError("Cannot find mirageOrb owner");
									if (210008 - 519180 == -309171)
									{
										continue;
									}
								}
								this.Ybu1Oo6hOK = true;
								if (130922 - 273195 != -142272)
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

	// Token: 0x06001DC3 RID: 7619 RVA: 0x00329360 File Offset: 0x00327560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (265275 - 385559 != -120284)
		{
		}
		for (;;)
		{
			if (!this.Ybu1Oo6hOK)
			{
				if (125571 - 289372 == -163801)
				{
					break;
				}
			}
			else if (!this.J2Q1nqy0mG)
			{
				if (268683 - 417260 == -148577)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (61 - 493333 != -493271)
					{
						break;
					}
				}
			}
			else if (!this.p6C1QVPdFv)
			{
				if (198837 - 455740 != -256902)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (21441 - 518863 == -497422)
					{
						break;
					}
				}
			}
			else
			{
				if (this.WVs1InhwBl > Time.time)
				{
					if (225617 - 331375 != -105758)
					{
						continue;
					}
					if (this.p6C1QVPdFv.hp <= 0)
					{
						if (10683 - 598831 == -588147)
						{
							continue;
						}
					}
					else if (this.a4H1tAf9Ec > this.JY01JdmFBi * 60 - 10)
					{
						if (264325 - 415365 == -151039)
						{
							continue;
						}
						if (this.p6C1QVPdFv.isMine)
						{
							if (24287 - 307065 != -282778)
							{
								continue;
							}
							Bat bat = (Bat)this.J2Q1nqy0mG.GetComponent(typeof(Bat));
							if (53245 - 573323 != -520078)
							{
								continue;
							}
							if (bat)
							{
								if (59853 - 232800 == -172946)
								{
									continue;
								}
								bat.ActionEvent("RPC_mirageOrb_destroy", Vector3.zero, Vector3.zero, this.wZ916Ggr2t);
								if (121624 - 479918 == -358293)
								{
									continue;
								}
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (21780 - 149360 != -127579)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.isVisible)
						{
							if (78196 - 525180 != -446984)
							{
								continue;
							}
							this.apw1XK30It.a = Mathf.Lerp(this.apw1XK30It.a, 0.05f, (float)5 * Time.deltaTime);
							if (97800 - 457112 == -359311)
							{
								continue;
							}
						}
						else
						{
							this.apw1XK30It.a = Mathf.Lerp(this.apw1XK30It.a, (float)0, (float)5 * Time.deltaTime);
							if (297241 - 23231 != 274010)
							{
								continue;
							}
						}
						this.renderer.material.SetColor("_TintColor", this.apw1XK30It);
						if (221295 - 251793 != -30498)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (4588 - 536106 != -531517)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x003296E0 File Offset: 0x003278E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (269697 - 30111 != 239586)
		{
		}
		for (;;)
		{
			if (!this.Ybu1Oo6hOK)
			{
				if (97200 - 355771 != -258570)
				{
					break;
				}
			}
			else if (!this.p6C1QVPdFv)
			{
				if (212693 - 246892 != -34198)
				{
					break;
				}
			}
			else
			{
				if (this.WDO12Mxc2d >= Time.time)
				{
					break;
				}
				if (119246 - 103748 == 15498)
				{
					GameObject gameObject = mCollider.gameObject;
					if (43010 - 183498 == -140488)
					{
						if (gameObject.layer == this.J2Q1nqy0mG.layer)
						{
							break;
						}
						if (265098 - 209746 != 55353)
						{
							if (!(gameObject.tag == "Player"))
							{
								if (145401 - 81191 == 64211)
								{
									continue;
								}
								if (!(gameObject.tag == "Enemy"))
								{
									break;
								}
								if (202725 - 181229 != 21496)
								{
									continue;
								}
							}
							this.WDO12Mxc2d = Time.time + 0.5f;
							if (137919 - 127886 != 10034)
							{
								this.apw1XK30It.a = 0.4f;
								if (204480 - 218187 == -13707)
								{
									if (!this.p6C1QVPdFv.isMine)
									{
										break;
									}
									if (114682 - 87019 == 27663)
									{
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (105409 - 524529 == -419120)
										{
											if (!characterControl)
											{
												break;
											}
											if (155178 - 174785 == -19607)
											{
												if (characterControl.hp <= 0)
												{
													break;
												}
												if (19907 - 479792 == -459885)
												{
													this.a4H1tAf9Ec += this.JY01JdmFBi * 6 - 1;
													if (137581 - 306515 != -168933)
													{
														characterControl.RPC_AddEffectDamage(300 + this.JY01JdmFBi, this.JY01JdmFBi * 6 - 1, 0, 0, Vector3.zero, this.taO1eI9pqM);
														if (73958 - 271734 == -197776)
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
					}
				}
			}
		}
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x003299B8 File Offset: 0x00327BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x003299BC File Offset: 0x00327BBC
	internal static bool JopmfYD1FRL9hiUiAla()
	{
		return true;
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x003299C0 File Offset: 0x00327BC0
	internal static bool oItWefD4RLfqcGk9grG()
	{
		return false;
	}

	// Token: 0x04001BB8 RID: 7096
	private GameObject J2Q1nqy0mG;

	// Token: 0x04001BB9 RID: 7097
	private CharacterControl p6C1QVPdFv;

	// Token: 0x04001BBA RID: 7098
	private int taO1eI9pqM;

	// Token: 0x04001BBB RID: 7099
	private float WVs1InhwBl;

	// Token: 0x04001BBC RID: 7100
	private int JY01JdmFBi;

	// Token: 0x04001BBD RID: 7101
	private int wZ916Ggr2t;

	// Token: 0x04001BBE RID: 7102
	private int a4H1tAf9Ec;

	// Token: 0x04001BBF RID: 7103
	private Color apw1XK30It;

	// Token: 0x04001BC0 RID: 7104
	public bool isVisible;

	// Token: 0x04001BC1 RID: 7105
	private bool Ybu1Oo6hOK;

	// Token: 0x04001BC2 RID: 7106
	private float WDO12Mxc2d;
}
