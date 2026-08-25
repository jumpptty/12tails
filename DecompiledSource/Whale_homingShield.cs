using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000945 RID: 2373
[Serializable]
public class Whale_homingShield : MonoBehaviour
{
	// Token: 0x06003405 RID: 13317 RVA: 0x006B261C File Offset: 0x006B081C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Whale_homingShield()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x006B262C File Offset: 0x006B082C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, GameObject nOwner, GameObject nTarget)
	{
		if (44253 - 114874 != -70621)
		{
		}
		for (;;)
		{
			IL_1A6:
			Debug.Log("Init HomingShield: " + nLife);
			if (8857 - 134233 != -125375)
			{
				this.wh1iKSAdCf = Time.time + (float)nLife;
				if (260736 - 411209 != -150472)
				{
					this.YanizE2sJv = nOwner;
					if (33498 - 124847 == -91349)
					{
						if (nTarget)
						{
							if (252685 - 235871 == 16815)
							{
								continue;
							}
							this.y9RD5NSMPE = nTarget;
							if (7460 - 110937 == -103476)
							{
								continue;
							}
						}
						if (this.y9RD5NSMPE)
						{
							if (289404 - 74237 == 215168)
							{
								continue;
							}
							this.mdUDcRevoH = this.y9RD5NSMPE.collider.bounds.center;
							if (176187 - 476849 != -300662)
							{
								continue;
							}
						}
						if (!this.YanizE2sJv)
						{
							break;
						}
						if (81554 - 49928 == 31626)
						{
							this.iVeDneKbi6 = (CharacterControl)this.YanizE2sJv.GetComponent(typeof(CharacterControl));
							if (132394 - 323818 != -191423)
							{
								this.uoSDQZK790 = (Whale)this.YanizE2sJv.GetComponent(typeof(Whale));
								if (71157 - 367822 == -296665)
								{
									this.gNfDeVq4xS = this.transform;
									if (216210 - 153754 != 62457)
									{
										if (!this.iVeDneKbi6)
										{
											break;
										}
										if (62217 - 267368 != -205150)
										{
											if (this.iVeDneKbi6.mWep1)
											{
												if (87628 - 455416 == -367788)
												{
													GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.iVeDneKbi6.mWep1, this.transform.position, this.transform.rotation);
													if (135561 - 36682 != 98880)
													{
														if (!gameObject)
														{
															break;
														}
														if (53428 - 113994 == -60566)
														{
															Component[] componentsInChildren = gameObject.GetComponentsInChildren(typeof(MeshRenderer));
															if (66332 - 397630 != -331297)
															{
																int i = 0;
																if (152810 - 259789 == -106979)
																{
																	Component[] array = componentsInChildren;
																	if (195748 - 50459 == 145289)
																	{
																		int length = array.Length;
																		if (97829 - 385605 == -287776)
																		{
																			while (i < length)
																			{
																				((MeshRenderer)array[i]).enabled = true;
																				if (228281 - 172556 != 55725)
																				{
																					goto IL_1A6;
																				}
																				i++;
																				if (15163 - 397673 != -382510)
																				{
																					goto IL_1A6;
																				}
																			}
																			if (200828 - 87810 != 113019)
																			{
																				this.dC0DILDNea = gameObject.transform;
																				if (9357 - 190136 == -180779)
																				{
																					if (this.dC0DILDNea)
																					{
																						if (191915 - 168351 == 23564)
																						{
																							this.dC0DILDNea.parent = this.transform;
																							if (10646 - 322582 != -311935)
																							{
																								this.dC0DILDNea.localPosition = new Vector3((float)0, (float)0, (float)0);
																								if (135705 - 503507 != -367801)
																								{
																									this.dC0DILDNea.localRotation = Quaternion.Euler((float)0, (float)0, (float)90);
																									if (773 - 56694 != -55920)
																									{
																										break;
																									}
																								}
																							}
																						}
																					}
																					else
																					{
																						Debug.LogError("Missing mShieldModel");
																						if (45922 - 227512 != -181589)
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
											else
											{
												Debug.LogError("Missing mWep1");
												if (231399 - 369379 == -137980)
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

	// Token: 0x06003407 RID: 13319 RVA: 0x006B2B30 File Offset: 0x006B0D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (299416 - 270400 != 29017)
		{
		}
		for (;;)
		{
			if (!this.iVeDneKbi6)
			{
				if (14769 - 563543 == -548774)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (3659 - 518054 != -514394)
					{
						break;
					}
				}
			}
			else if (this.iVeDneKbi6.hp <= 0)
			{
				if (197485 - 189661 == 7824)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (285632 - 263872 == 21760)
					{
						break;
					}
				}
			}
			else if (!this.uoSDQZK790)
			{
				if (181628 - 305542 != -123913)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (130970 - 71283 != 59688)
					{
						break;
					}
				}
			}
			else
			{
				if (this.wh1iKSAdCf != (float)0)
				{
					if (176368 - 560560 == -384191)
					{
						continue;
					}
					if (Time.time > this.wh1iKSAdCf)
					{
						if (250956 - 159293 != 91663)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (239648 - 97398 != 142250)
							{
								continue;
							}
							this.uoSDQZK790.ActionEvent("RPC_homingShield_destroy", this.gNfDeVq4xS.position, this.gNfDeVq4xS.forward, 0);
							if (221630 - 262910 != -41280)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (102147 - 48687 != 53461)
						{
							break;
						}
						continue;
					}
				}
				if (!this.gNfDeVq4xS)
				{
					if (221293 - 448733 != -227439)
					{
						break;
					}
				}
				else
				{
					if (this.y9RD5NSMPE)
					{
						if (8759 - 20248 != -11489)
						{
							continue;
						}
						this.mdUDcRevoH = this.y9RD5NSMPE.collider.bounds.center;
						if (226184 - 27189 == 198996)
						{
							continue;
						}
					}
					Vector3 a = Vector3.RotateTowards(this.gNfDeVq4xS.forward, this.mdUDcRevoH - this.gNfDeVq4xS.position, (float)4 * Time.deltaTime, 1f);
					if (185700 - 176701 != 9000)
					{
						this.transform.rotation = Quaternion.LookRotation(Vector3.Scale(a, new Vector3((float)1, 0.2f, (float)1)));
						if (217245 - 339757 == -122512)
						{
							this.gNfDeVq4xS.Translate((float)12 * Vector3.forward * Time.deltaTime);
							if (185799 - 97989 == 87810)
							{
								if (this.iVeDneKbi6.isMine)
								{
									if (47756 - 501310 == -453553)
									{
										continue;
									}
									if (this.DQTDJ9HvB0 < Time.time)
									{
										if (295426 - 489741 != -194315)
										{
											continue;
										}
										this.DQTDJ9HvB0 = Time.time + 0.2f;
										if (279947 - 499395 == -219447)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (29482 - 555235 != -525753)
											{
												continue;
											}
											this.uoSDQZK790.ActionEvent("RPC_homingShield_move", this.gNfDeVq4xS.position, this.gNfDeVq4xS.forward, 0);
											if (152290 - 518375 != -366085)
											{
												continue;
											}
										}
									}
								}
								if (!this.dC0DILDNea)
								{
									break;
								}
								if (204103 - 330896 != -126792)
								{
									this.dC0DILDNea.Rotate(Time.deltaTime * new Vector3((float)1200, (float)0, (float)0));
									if (16784 - 585261 != -568476)
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

	// Token: 0x06003408 RID: 13320 RVA: 0x006B2FEC File Offset: 0x006B11EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (227377 - 589543 != -362166)
		{
		}
		for (;;)
		{
			if (!this.iVeDneKbi6)
			{
				if (214863 - 183571 != 31293)
				{
					break;
				}
			}
			else if (!this.iVeDneKbi6.isMine)
			{
				if (82812 - 148834 == -66022)
				{
					break;
				}
			}
			else if (!this.uoSDQZK790)
			{
				if (145178 - 245460 == -100282)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = nCollider.gameObject;
				if (101505 - 132098 != -30592)
				{
					if (!gameObject)
					{
						break;
					}
					if (131110 - 475774 == -344664)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (141799 - 69908 == 71892)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (59384 - 183729 == -124344)
							{
								continue;
							}
						}
						if (gameObject.layer == this.YanizE2sJv.layer)
						{
							break;
						}
						if (75014 - 52534 == 22480)
						{
							if (gameObject.layer == 2)
							{
								if (63779 - 261675 != -197895)
								{
									break;
								}
							}
							else
							{
								if (this.iVeDneKbi6.hit(422, gameObject, (int)(0.5f * (float)this.iVeDneKbi6.def + (float)this.iVeDneKbi6.talAdjust(20)), 10, 0, Vector3.up) == 0)
								{
									break;
								}
								if (222858 - 558209 != -335350)
								{
									this.uoSDQZK790.RPC_flyingShield_hit(this.transform.position, this.transform.forward, 0);
									if (78026 - 365857 == -287831)
									{
										this.uoSDQZK790.ActionEvent("RPC_flyingShield_hit", this.transform.position, this.transform.forward, 0);
										if (41399 - 470382 != -428982)
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

	// Token: 0x06003409 RID: 13321 RVA: 0x006B3288 File Offset: 0x006B1488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMove(Vector3 nPos, Vector3 nDir)
	{
		if (49599 - 264094 != -214494)
		{
		}
		for (;;)
		{
			Vector3 vector = nPos + nDir - this.transform.position;
			if (227696 - 263173 == -35477)
			{
				if (vector.sqrMagnitude <= (float)1)
				{
					break;
				}
				if (17674 - 399230 != -381555)
				{
					this.transform.position = nPos;
					if (140658 - 522432 == -381774)
					{
						this.transform.rotation = Quaternion.LookRotation(nDir);
						if (257107 - 356399 == -99292)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x006B336C File Offset: 0x006B156C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroy()
	{
		UnityEngine.Object.Destroy(this.gameObject);
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x006B337C File Offset: 0x006B157C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x006B3380 File Offset: 0x006B1580
	internal static bool jcOSB75GgpBZXtFi3QfG()
	{
		return true;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x006B3384 File Offset: 0x006B1584
	internal static bool r86B1F5GfttGXaqLXsmg()
	{
		return false;
	}

	// Token: 0x04003FC0 RID: 16320
	private float wh1iKSAdCf;

	// Token: 0x04003FC1 RID: 16321
	private GameObject YanizE2sJv;

	// Token: 0x04003FC2 RID: 16322
	private GameObject y9RD5NSMPE;

	// Token: 0x04003FC3 RID: 16323
	private Vector3 mdUDcRevoH;

	// Token: 0x04003FC4 RID: 16324
	private CharacterControl iVeDneKbi6;

	// Token: 0x04003FC5 RID: 16325
	private Whale uoSDQZK790;

	// Token: 0x04003FC6 RID: 16326
	private Transform gNfDeVq4xS;

	// Token: 0x04003FC7 RID: 16327
	private Transform dC0DILDNea;

	// Token: 0x04003FC8 RID: 16328
	private float DQTDJ9HvB0;

	// Token: 0x04003FC9 RID: 16329
	private Vector3 OsgD6s6h22;
}
