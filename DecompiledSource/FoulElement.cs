using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002A1 RID: 673
[Serializable]
public class FoulElement : MonoBehaviour
{
	// Token: 0x06000F56 RID: 3926 RVA: 0x00182AB8 File Offset: 0x00180CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FoulElement()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00182AC8 File Offset: 0x00180CC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (229978 - 312562 != -82584)
		{
		}
		for (;;)
		{
			this.ewYJS1oQBb = this.transform;
			if (221231 - 311568 == -90337)
			{
				this.irwJBaTX7s = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (24979 - 554297 == -529318)
				{
					this.irwJBaTX7s.actionState = "standby";
					if (148781 - 556549 != -407767)
					{
						this.irwJBaTX7s.actionTime = Time.time;
						if (227595 - 42421 != 185175)
						{
							this.irwJBaTX7s.myCommand = "none";
							if (87977 - 114986 != -27008)
							{
								if (Game.mGameType == 99)
								{
									if (265455 - 112880 != 152575)
									{
										continue;
									}
									this.irwJBaTX7s.isMine = true;
									if (238435 - 12012 == 226424)
									{
										continue;
									}
								}
								this.irwJBaTX7s.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"poison",
									"acid"
								});
								if (105397 - 102982 != 2416)
								{
									this.irwJBaTX7s.hp = (this.irwJBaTX7s.mhp = 14400);
									if (222361 - 226448 != -4086)
									{
										this.irwJBaTX7s.ko = (this.irwJBaTX7s.mko = 770);
										if (283852 - 421098 == -137246)
										{
											if (this.foulBase)
											{
												if (286503 - 463482 != -176978)
												{
													this.hxoJ8k7EUf = (GameObject)UnityEngine.Object.Instantiate(this.foulBase, this.transform.position, this.transform.rotation);
													if (247724 - 586354 != -338629)
													{
														break;
													}
												}
											}
											else
											{
												Debug.LogError("Missing foulBase effect");
												if (258484 - 110062 != 148423)
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

	// Token: 0x06000F58 RID: 3928 RVA: 0x00182D70 File Offset: 0x00180F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (73144 - 82498 != -9353)
		{
		}
		for (;;)
		{
			if (this.irwJBaTX7s.isControlled)
			{
				if (209916 - 509996 == -300079)
				{
					continue;
				}
				if (!(this.irwJBaTX7s.actionState == "standby"))
				{
					if (20487 - 387410 == -366922)
					{
						continue;
					}
					if (!(this.irwJBaTX7s.actionState == "run"))
					{
						goto IL_1A;
					}
					if (211553 - 283756 != -72203)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (186536 - 74463 != 112073)
				{
					continue;
				}
			}
			IL_1A:
			if (this.irwJBaTX7s.hp > 0)
			{
				break;
			}
			if (287977 - 3594 == 284383)
			{
				if (!(this.irwJBaTX7s.actionState != "dead"))
				{
					break;
				}
				if (246386 - 473878 != -227491)
				{
					if (this.irwJBaTX7s.isMine)
					{
						if (160327 - 386158 == -225831)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (114442 - 244737 == -130295)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (238642 - 547690 == -309048)
								{
									this.irwJBaTX7s.DeadEvent();
									if (220977 - 200260 == 20717)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.irwJBaTX7s.hp = 1;
						if (232361 - 563252 == -330891)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00182FB0 File Offset: 0x001811B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (167326 - 481610 != -314284)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (146430 - 422048 == -275618)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (96686 - 329776 == -233090)
				{
					if (142057 - 78778 == 63279)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (81574 - 590498 == -508923)
							{
								continue;
							}
							v = 1;
							if (138391 - 495748 == -357356)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (246983 - 238031 != 8952)
							{
								continue;
							}
							v = -1;
							if (283561 - 113229 != 170332)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_acidDrop")
						{
							if (287172 - 458228 == -171055)
							{
								continue;
							}
							v = 2;
							if (166146 - 53446 != 112700)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_acidDrop_hit")
						{
							if (190040 - 51415 != 138625)
							{
								continue;
							}
							v = -2;
							if (97064 - 391520 == -294455)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_poisonGas")
						{
							if (22366 - 528306 != -505940)
							{
								continue;
							}
							v = 11;
							if (214390 - 50487 == 163904)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_massProvoke")
						{
							if (196603 - 304855 != -108252)
							{
								continue;
							}
							v = 21;
							if (131412 - 563259 != -431847)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (286321 - 370718 != -84397)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (176711 - 595010 == -418299)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (208804 - 292015 != -83210)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (95655 - 344053 != -248397)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (188402 - 570355 != -381952)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (134487 - 588893 != -454405)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (184111 - 578104 == -393993)
											{
												Hashtable hashtable = new Hashtable();
												if (49292 - 252413 != -203120)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (265329 - 173079 == 92250)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (270938 - 198091 == 72847)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (164283 - 566064 == -401781)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (259557 - 491200 == -231643)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (275972 - 520961 != -244988)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (162659 - 360530 == -197871)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (69849 - 512889 != -443039)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (136250 - 357741 == -221491)
																				{
																					PhotonClient.SendEvent(this.irwJBaTX7s.ActorNr, 74, hashtable, true, true);
																					if (164330 - 513187 == -348857)
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
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0018355C File Offset: 0x0018175C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (270680 - 442891 != -172211)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (219117 - 310100 != -90982)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (46015 - 176304 == -130289)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (291553 - 598748 == -307195)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (78069 - 555248 != -477178)
						{
							int num3 = num;
							if (48860 - 359481 == -310621)
							{
								if (num3 == 1)
								{
									if (102939 - 567343 != -464403)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (97215 - 447272 != -350056)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (292614 - 5696 == 286918)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (81522 - 96371 != -14848)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (254569 - 62665 != 191905)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (281725 - 575866 == -294141)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (178036 - 207956 != -29919)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (170547 - 232635 != -62087)
										{
											this.StartCoroutine_Auto(this.RPC_acidDrop(vector, vector2, num2));
											if (173416 - 165445 == 7971)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (212827 - 588715 != -375887)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (235771 - 364729 != -128957)
										{
											this.StartCoroutine_Auto(this.RPC_acidDrop_hit(vector, vector2, num2));
											if (8206 - 168690 != -160483)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (64204 - 123324 != -59119)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (237969 - 414951 == -176982)
										{
											this.StartCoroutine_Auto(this.RPC_poisonGas(vector, vector2, num2));
											if (95037 - 39596 != 55442)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (46847 - 447524 == -400677)
									{
										if (this.irwJBaTX7s.isMine)
										{
											break;
										}
										if (69786 - 493756 == -423970)
										{
											this.StartCoroutine_Auto(this.RPC_massProvoke(vector, vector2, num2));
											if (239899 - 374641 == -134742)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (76654 - 135974 != -59319)
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

	// Token: 0x06000F5B RID: 3931 RVA: 0x001839E0 File Offset: 0x00181BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		this.animation.CrossFade("root", 0.2f);
		this.animation.wrapMode = WrapMode.Loop;
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00183A04 File Offset: 0x00181C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (210608 - 485793 != -275184)
		{
		}
		for (;;)
		{
			if (!this.irwJBaTX7s.isMine)
			{
				if (281454 - 307766 != -26311)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (150778 - 54467 != 96312)
				{
					Vector3 vector = a - this.transform.position;
					if (299885 - 115221 != 184665)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (21556 - 512609 == -491053)
						{
							CharacterControl characterControl = null;
							if (206650 - 324687 == -118037)
							{
								int tID = 0;
								if (34140 - 53214 == -19074)
								{
									if (gameObject)
									{
										if (42739 - 94481 != -51742)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (15359 - 553257 != -537898)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (112205 - 320566 != -208361)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (81816 - 539556 == -457739)
										{
											continue;
										}
									}
									if (!(this.irwJBaTX7s.actionState == "standby"))
									{
										if (121813 - 401769 == -279955)
										{
											continue;
										}
										if (!(this.irwJBaTX7s.actionState == "run"))
										{
											break;
										}
										if (290161 - 7777 != 282384)
										{
											continue;
										}
									}
									if (this.irwJBaTX7s.isTimeOut("nAttack") != (float)0)
									{
										if (162902 - 402362 == -239460)
										{
											Camera.main.SendMessage("newGameMessage", "Normal Attack TimeOut!");
											if (268230 - 286334 != -18103)
											{
												break;
											}
										}
									}
									else if (vector.sqrMagnitude < (float)49)
									{
										if (199317 - 187935 == 11382)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.ewYJS1oQBb.position, vector, tID));
											if (69768 - 141617 != -71848)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (122543 - 59277 != 63267)
												{
													this.ActionEvent("RPC_nAttack", this.ewYJS1oQBb.position, vector, tID);
													if (188962 - 207058 != -18095)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_acidDrop(this.ewYJS1oQBb.position, vector, tID));
										if (2750 - 224343 != -221592)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (77094 - 309382 == -232288)
											{
												this.ActionEvent("RPC_acidDrop", this.ewYJS1oQBb.position, vector, tID);
												if (195518 - 398773 != -203254)
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

	// Token: 0x06000F5D RID: 3933 RVA: 0x00183DEC File Offset: 0x00181FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (77399 - 161306 != -83906)
		{
		}
		for (;;)
		{
			if (!this.irwJBaTX7s.isMine)
			{
				if (164803 - 411304 != -246500)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (62974 - 426875 != -363900)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (82930 - 348526 == -265596)
					{
						Vector3 normalized = vector.normalized;
						if (255307 - 442398 != -187090)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (220082 - 311648 == -91566)
							{
								CharacterControl characterControl = null;
								if (52511 - 588855 != -536343)
								{
									int tID = 0;
									if (30992 - 178295 == -147303)
									{
										if (gameObject)
										{
											if (133159 - 583234 == -450074)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (147965 - 18398 == 129568)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (65011 - 200299 == -135287)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (187349 - 243520 != -56171)
											{
												continue;
											}
										}
										if (!(this.irwJBaTX7s.actionState == "standby"))
										{
											if (105107 - 147959 != -42852)
											{
												continue;
											}
											if (!(this.irwJBaTX7s.actionState == "run"))
											{
												break;
											}
											if (124350 - 439873 == -315522)
											{
												continue;
											}
										}
										if (this.irwJBaTX7s.isTimeOut("cAttack") != (float)0)
										{
											if (123007 - 536299 == -413292)
											{
												Camera.main.SendMessage("newGameMessage", "Charge Attack TimeOut!");
												if (257764 - 21341 != 236424)
												{
													break;
												}
											}
										}
										else if (this.irwJBaTX7s.sp >= 30)
										{
											if (135892 - 12051 != 123842)
											{
												this.StartCoroutine_Auto(this.RPC_massProvoke(this.ewYJS1oQBb.position, normalized, tID));
												if (160337 - 176667 == -16330)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (201519 - 414140 != -212620)
													{
														this.ActionEvent("RPC_massProvoke", this.ewYJS1oQBb.position, normalized, tID);
														if (254155 - 464084 == -209929)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_poisonGas(this.ewYJS1oQBb.position, normalized, tID));
											if (157880 - 206223 == -48343)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (69469 - 264531 == -195062)
												{
													this.ActionEvent("RPC_poisonGas", this.ewYJS1oQBb.position, normalized, tID);
													if (79320 - 165648 == -86328)
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

	// Token: 0x06000F5E RID: 3934 RVA: 0x00184200 File Offset: 0x00182400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00184204 File Offset: 0x00182404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FoulElement.$RPC_nAttack$17833(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00184214 File Offset: 0x00182414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (248608 - 285420 != -36811)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (221190 - 159273 != 61917)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (262575 - 381998 == -119422)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (198442 - 475849 == -277406)
				{
					continue;
				}
			}
			if (Time.time <= this.oREJ0cSkBF)
			{
				break;
			}
			if (121835 - 291397 == -169562)
			{
				this.oREJ0cSkBF = Time.time + 0.1f;
				if (277625 - 114259 == 163366)
				{
					if (!this.nAttack_hit_fx)
					{
						break;
					}
					if (247522 - 293178 == -45656)
					{
						this.audio.PlayOneShot(this.nAttack_hit_fx);
						if (160008 - 362310 != -202301)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00184378 File Offset: 0x00182578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_acidDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FoulElement.$RPC_acidDrop$17848(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00184388 File Offset: 0x00182588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_acidDrop_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new FoulElement.$RPC_acidDrop_hit$17857(hitPos, this).GetEnumerator();
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00184398 File Offset: 0x00182598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_poisonGas(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FoulElement.$RPC_poisonGas$17867(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x001843A8 File Offset: 0x001825A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_massProvoke(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FoulElement.$RPC_massProvoke$17879(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x001843B8 File Offset: 0x001825B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FoulElement.$RPC_dead$17891(nArray, this).GetEnumerator();
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x001843C8 File Offset: 0x001825C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDestroy()
	{
		if (this.hxoJ8k7EUf)
		{
			UnityEngine.Object.Destroy(this.hxoJ8k7EUf);
		}
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x001843E8 File Offset: 0x001825E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x001843EC File Offset: 0x001825EC
	internal static bool T0djwNoRq27YLdfXx9U()
	{
		return true;
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x001843F0 File Offset: 0x001825F0
	internal static bool wy6AmrowoQW0eZpwITp()
	{
		return false;
	}

	// Token: 0x04000D21 RID: 3361
	private Transform ewYJS1oQBb;

	// Token: 0x04000D22 RID: 3362
	private CharacterControl irwJBaTX7s;

	// Token: 0x04000D23 RID: 3363
	public GameObject nAttack_ring;

	// Token: 0x04000D24 RID: 3364
	public GameObject nAttack_hit;

	// Token: 0x04000D25 RID: 3365
	public AudioClip nAttack_hit_fx;

	// Token: 0x04000D26 RID: 3366
	private float oREJ0cSkBF;

	// Token: 0x04000D27 RID: 3367
	public GameObject acidDrop_ring;

	// Token: 0x04000D28 RID: 3368
	public GameObject acidDrop_hit;

	// Token: 0x04000D29 RID: 3369
	public GameObject poisonGas_ring;

	// Token: 0x04000D2A RID: 3370
	public GameObject massProvoke_ring;

	// Token: 0x04000D2B RID: 3371
	public GameObject dead_ring;

	// Token: 0x04000D2C RID: 3372
	public GameObject foulBase;

	// Token: 0x04000D2D RID: 3373
	private GameObject hxoJ8k7EUf;

	// Token: 0x020002A2 RID: 674
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17833 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F6A RID: 3946 RVA: 0x001843F4 File Offset: 0x001825F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17833(Vector3 mPos, Vector3 tDir, FoulElement self_)
		{
			if (14362 - 592978 != -578616)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137 - 4239 != -4101)
				{
					base..ctor();
					if (59451 - 457152 == -397701)
					{
						this.$mPos$17845 = mPos;
						if (70462 - 501400 == -430938)
						{
							this.$tDir$17846 = tDir;
							if (43559 - 72769 != -29209)
							{
								this.$self_$17847 = self_;
								if (216356 - 451598 == -235242)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x001844D0 File Offset: 0x001826D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_nAttack$17833.$(this.$mPos$17845, this.$tDir$17846, this.$self_$17847);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x001844EC File Offset: 0x001826EC
		internal static bool NB6BUYoqYYxMudmusAe()
		{
			return true;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x001844F0 File Offset: 0x001826F0
		internal static bool f03uino7aoQ6pdB5Xgw()
		{
			return false;
		}

		// Token: 0x04000D2E RID: 3374
		internal Vector3 $mPos$17845;

		// Token: 0x04000D2F RID: 3375
		internal Vector3 $tDir$17846;

		// Token: 0x04000D30 RID: 3376
		internal FoulElement $self_$17847;

		// Token: 0x020002A3 RID: 675
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F6E RID: 3950 RVA: 0x001844F4 File Offset: 0x001826F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FoulElement self_)
			{
				if (125534 - 192062 != -66528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67935 - 396709 == -328774)
					{
						base..ctor();
						if (13519 - 578774 != -565254)
						{
							this.$mPos$17842 = mPos;
							if (55306 - 258395 != -203088)
							{
								this.$tDir$17843 = tDir;
								if (41662 - 307968 != -266305)
								{
									this.$self_$17844 = self_;
									if (61138 - 292226 != -231087)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F6F RID: 3951 RVA: 0x001845D0 File Offset: 0x001827D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159748 - 232538 != -72789)
				{
				}
				for (;;)
				{
					IL_D0B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E26;
					case 2:
						if (this.$self_$17844.irwJBaTX7s.actionState != "attack")
						{
							goto IL_AC7;
						}
						if (210959 - 341346 == -130386)
						{
							continue;
						}
						if (this.$self_$17844.irwJBaTX7s.myCommand != "nAttack")
						{
							if (280522 - 291523 != -11000)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17834 = 0;
							if (40728 - 477426 != -436698)
							{
								continue;
							}
							this.$hitList$17835 = null;
							if (50839 - 8964 != 41875)
							{
								continue;
							}
							this.$hitPoint$17836 = default(Vector3);
							if (12397 - 108172 == -95774)
							{
								continue;
							}
							this.$hitChar$17837 = null;
							if (250952 - 292175 != -41223)
							{
								continue;
							}
							if (!this.$self_$17844.irwJBaTX7s.isMine)
							{
								goto IL_986;
							}
							if (4105 - 599152 == -595046)
							{
								continue;
							}
							this.$hitLayer$17834 = 130816 - (1 << this.$self_$17844.gameObject.layer);
							if (295730 - 584999 != -289269)
							{
								continue;
							}
							this.$hitList$17835 = Damage.FindAreaTarget(this.$self_$17844.ewYJS1oQBb.position, (float)8, (float)4, this.$hitLayer$17834);
							if (2283 - 92755 == -90471)
							{
								continue;
							}
							this.$$iterator$10066$17839 = UnityRuntimeServices.GetEnumerator(this.$hitList$17835);
							if (182719 - 32316 == 150404)
							{
								continue;
							}
							while (this.$$iterator$10066$17839.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10066$17839.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17838 = (GameObject)obj2;
								if (206103 - 250240 != -44137)
								{
									goto IL_D0B;
								}
								if (this.$self_$17844.irwJBaTX7s.hit(1, this.$hitObject$17838, this.$self_$17844.irwJBaTX7s.atk, 2, 0, (float)2 * this.$self_$17844.ewYJS1oQBb.forward) != 0)
								{
									if (237525 - 361864 == -124338)
									{
										goto IL_D0B;
									}
									this.$hitPoint$17836 = this.$hitObject$17838.collider.ClosestPointOnBounds(this.$self_$17844.ewYJS1oQBb.position + Vector3.up);
									if (192619 - 561166 != -368547)
									{
										goto IL_D0B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10066$17839, this.$hitObject$17838);
									if (112347 - 22376 == 89972)
									{
										goto IL_D0B;
									}
									this.$self_$17844.RPC_nAttack_hit(this.$hitPoint$17836, this.$self_$17844.ewYJS1oQBb.forward, 0);
									if (220438 - 52760 != 167678)
									{
										goto IL_D0B;
									}
									this.$self_$17844.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17836, this.$self_$17844.ewYJS1oQBb.forward, 0);
									if (127773 - 32121 == 95653)
									{
										goto IL_D0B;
									}
									this.$hitChar$17837 = (CharacterControl)this.$hitObject$17838.GetComponent(typeof(CharacterControl));
									if (124699 - 158916 == -34216)
									{
										goto IL_D0B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10066$17839, this.$hitObject$17838);
									if (68860 - 58687 != 10173)
									{
										goto IL_D0B;
									}
									if (this.$hitChar$17837)
									{
										if (24259 - 132938 == -108678)
										{
											goto IL_D0B;
										}
										if (this.$hitChar$17837.lckAdjust(33) < UnityEngine.Random.Range(0, 100))
										{
											if (43432 - 402806 == -359373)
											{
												goto IL_D0B;
											}
											this.$hitChar$17837.RPC_AddStatus("poison", 5, Damage.getDebuff((float)15, this.$self_$17844.irwJBaTX7s.cha, this.$hitChar$17837.cha), 0, this.$self_$17844.irwJBaTX7s.ActorNr);
											if (177149 - 479347 == -302197)
											{
												goto IL_D0B;
											}
										}
									}
								}
							}
							if (30814 - 514038 != -483224)
							{
								continue;
							}
							goto IL_986;
						}
						break;
					case 3:
						if (this.$self_$17844.irwJBaTX7s.actionState != "attack")
						{
							goto IL_2C8;
						}
						if (153330 - 460749 == -307418)
						{
							continue;
						}
						if (this.$self_$17844.irwJBaTX7s.myCommand != "nAttack")
						{
							if (170862 - 412199 != -241337)
							{
								continue;
							}
							goto IL_2C8;
						}
						else
						{
							if (!this.$self_$17844.irwJBaTX7s.isMine)
							{
								goto IL_173;
							}
							if (29571 - 532982 != -503411)
							{
								continue;
							}
							this.$hitLayer$17834 = 130816 - (1 << this.$self_$17844.gameObject.layer);
							if (234897 - 115281 != 119616)
							{
								continue;
							}
							this.$hitList$17835 = Damage.FindAreaTarget(this.$self_$17844.ewYJS1oQBb.position, (float)8, (float)4, this.$hitLayer$17834);
							if (6627 - 219352 != -212725)
							{
								continue;
							}
							this.$$iterator$10067$17841 = UnityRuntimeServices.GetEnumerator(this.$hitList$17835);
							if (124956 - 191493 == -66536)
							{
								continue;
							}
							while (this.$$iterator$10067$17841.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10067$17841.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17840 = (GameObject)obj4;
								if (96355 - 115378 != -19023)
								{
									goto IL_D0B;
								}
								if (this.$self_$17844.irwJBaTX7s.hit(1, this.$hitObject$17840, this.$self_$17844.irwJBaTX7s.atk, 2, 0, (float)2 * this.$self_$17844.ewYJS1oQBb.forward) != 0)
								{
									if (180276 - 2864 != 177412)
									{
										goto IL_D0B;
									}
									this.$hitPoint$17836 = this.$hitObject$17840.collider.ClosestPointOnBounds(this.$self_$17844.ewYJS1oQBb.position + Vector3.up);
									if (87593 - 231185 != -143592)
									{
										goto IL_D0B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10067$17841, this.$hitObject$17840);
									if (290072 - 163718 != 126354)
									{
										goto IL_D0B;
									}
									this.$self_$17844.RPC_nAttack_hit(this.$hitPoint$17836, this.$self_$17844.ewYJS1oQBb.forward, 0);
									if (138502 - 439067 == -300564)
									{
										goto IL_D0B;
									}
									this.$self_$17844.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17836, this.$self_$17844.ewYJS1oQBb.forward, 0);
									if (167289 - 286863 == -119573)
									{
										goto IL_D0B;
									}
									this.$hitChar$17837 = (CharacterControl)this.$hitObject$17840.GetComponent(typeof(CharacterControl));
									if (136157 - 567721 == -431563)
									{
										goto IL_D0B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10067$17841, this.$hitObject$17840);
									if (40694 - 502612 != -461918)
									{
										goto IL_D0B;
									}
									if (this.$hitChar$17837)
									{
										if (147062 - 339451 != -192389)
										{
											goto IL_D0B;
										}
										if (this.$hitChar$17837.lckAdjust(33) < UnityEngine.Random.Range(0, 100))
										{
											if (280931 - 227935 != 52996)
											{
												goto IL_D0B;
											}
											this.$hitChar$17837.RPC_AddStatus("acid", 5, Damage.getDebuff((float)15, this.$self_$17844.irwJBaTX7s.cha, this.$hitChar$17837.cha), 0, this.$self_$17844.irwJBaTX7s.ActorNr);
											if (268033 - 522853 == -254819)
											{
												goto IL_D0B;
											}
										}
									}
								}
							}
							if (17503 - 103523 != -86020)
							{
								continue;
							}
							goto IL_173;
						}
						break;
					case 4:
						if (this.$self_$17844.irwJBaTX7s.actionState == "attack")
						{
							if (133687 - 3316 == 130372)
							{
								continue;
							}
							if (this.$self_$17844.irwJBaTX7s.myCommand == "nAttack")
							{
								if (86477 - 373423 == -286945)
								{
									continue;
								}
								this.$self_$17844.irwJBaTX7s.actionState = "standby";
								if (20471 - 2538 != 17933)
								{
									continue;
								}
								this.$self_$17844.irwJBaTX7s.actionTime = Time.time;
								if (284741 - 82108 == 202634)
								{
									continue;
								}
								this.$self_$17844.irwJBaTX7s.myCommand = "none";
								if (62492 - 43257 != 19235)
								{
									continue;
								}
								if (!this.$self_$17844.irwJBaTX7s.isMine)
								{
									if (274924 - 157362 == 117563)
									{
										continue;
									}
									this.$self_$17844.irwJBaTX7s.nPosition = this.$self_$17844.transform.position;
									if (17835 - 126510 != -108675)
									{
										continue;
									}
									this.$self_$17844.irwJBaTX7s.oPosition = this.$self_$17844.transform.position;
									if (234258 - 26215 == 208044)
									{
										continue;
									}
									this.$self_$17844.irwJBaTX7s.nDirection = this.$self_$17844.transform.forward;
									if (214069 - 160720 != 53349)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210175 - 236176 != -26000)
						{
							goto Block_15;
						}
						continue;
					default:
						if (129248 - 257784 != -128536)
						{
							continue;
						}
						break;
					}
					this.$self_$17844.irwJBaTX7s.actionState = "attack";
					if (182849 - 393146 == -210297)
					{
						this.$self_$17844.irwJBaTX7s.actionTime = Time.time;
						if (112696 - 443574 != -330877)
						{
							this.$self_$17844.irwJBaTX7s.myCommand = "nAttack";
							if (169690 - 392845 == -223155)
							{
								this.$self_$17844.irwJBaTX7s.addTimeOut("nAttack", (float)3);
								if (277327 - 41869 != 235459)
								{
									this.$self_$17844.transform.position = this.$mPos$17842;
									if (94182 - 309898 != -215715)
									{
										this.$self_$17844.transform.LookAt(this.$mPos$17842 + global::Math.vFlat(this.$tDir$17843));
										if (34296 - 448779 != -414482)
										{
											this.$self_$17844.animation.Play("nAttack");
											if (110725 - 230477 == -119752)
											{
												this.$self_$17844.animation.wrapMode = WrapMode.Once;
												if (10811 - 425796 != -414984)
												{
													this.$self_$17844.irwJBaTX7s.vMovement = this.$self_$17844.transform.forward;
													if (148101 - 433239 != -285137)
													{
														this.$self_$17844.irwJBaTX7s.moveSpeed = (float)0;
														if (30648 - 262469 != -231820)
														{
															if (this.$self_$17844.nAttack_ring)
															{
																if (248819 - 572678 != -323858)
																{
																	this.$self_$17844.irwJBaTX7s.createEffect(this.$self_$17844.nAttack_ring, this.$self_$17844.ewYJS1oQBb.position, this.$self_$17844.ewYJS1oQBb.rotation);
																	if (298181 - 426923 != -128741)
																	{
																		goto Block_27;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack effect");
																if (271840 - 333211 == -61371)
																{
																	goto IL_937;
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
				IL_173:
				return this.Yield(4, new WaitForSeconds(0.8f));
				Block_15:
				IL_2C8:
				goto IL_E26;
				Block_27:
				IL_937:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_986:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_AC7:
				Block_72:
				IL_E26:
				return false;
			}

			// Token: 0x06000F70 RID: 3952 RVA: 0x00185418 File Offset: 0x00183618
			internal static bool GkxpCcoPZCPBC2yn6W5()
			{
				return true;
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x0018541C File Offset: 0x0018361C
			internal static bool af0ZaZo0vwStkFBhkbX()
			{
				return false;
			}

			// Token: 0x04000D31 RID: 3377
			internal int $hitLayer$17834;

			// Token: 0x04000D32 RID: 3378
			internal UnityScript.Lang.Array $hitList$17835;

			// Token: 0x04000D33 RID: 3379
			internal Vector3 $hitPoint$17836;

			// Token: 0x04000D34 RID: 3380
			internal CharacterControl $hitChar$17837;

			// Token: 0x04000D35 RID: 3381
			internal GameObject $hitObject$17838;

			// Token: 0x04000D36 RID: 3382
			internal IEnumerator $$iterator$10066$17839;

			// Token: 0x04000D37 RID: 3383
			internal GameObject $hitObject$17840;

			// Token: 0x04000D38 RID: 3384
			internal IEnumerator $$iterator$10067$17841;

			// Token: 0x04000D39 RID: 3385
			internal Vector3 $mPos$17842;

			// Token: 0x04000D3A RID: 3386
			internal Vector3 $tDir$17843;

			// Token: 0x04000D3B RID: 3387
			internal FoulElement $self_$17844;
		}
	}

	// Token: 0x020002A4 RID: 676
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_acidDrop$17848 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F72 RID: 3954 RVA: 0x00185420 File Offset: 0x00183620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_acidDrop$17848(Vector3 mPos, Vector3 tDir, int tID, FoulElement self_)
		{
			if (8019 - 566237 != -558217)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75243 - 585501 == -510258)
				{
					base..ctor();
					if (1501 - 543852 == -542351)
					{
						this.$mPos$17853 = mPos;
						if (234862 - 319831 == -84969)
						{
							this.$tDir$17854 = tDir;
							if (14180 - 339032 != -324851)
							{
								this.$tID$17855 = tID;
								if (2561 - 453767 == -451206)
								{
									this.$self_$17856 = self_;
									if (108660 - 80341 != 28320)
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

		// Token: 0x06000F73 RID: 3955 RVA: 0x00185520 File Offset: 0x00183720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_acidDrop$17848.$(this.$mPos$17853, this.$tDir$17854, this.$tID$17855, this.$self_$17856);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00185540 File Offset: 0x00183740
		internal static bool kdlT9ZobtTBANxJUgc9()
		{
			return true;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00185544 File Offset: 0x00183744
		internal static bool NcfON0ourTWMSyc4W38()
		{
			return false;
		}

		// Token: 0x04000D3C RID: 3388
		internal Vector3 $mPos$17853;

		// Token: 0x04000D3D RID: 3389
		internal Vector3 $tDir$17854;

		// Token: 0x04000D3E RID: 3390
		internal int $tID$17855;

		// Token: 0x04000D3F RID: 3391
		internal FoulElement $self_$17856;

		// Token: 0x020002A5 RID: 677
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F76 RID: 3958 RVA: 0x00185548 File Offset: 0x00183748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, FoulElement self_)
			{
				if (74454 - 256854 != -182399)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16264 - 276294 == -260030)
					{
						base..ctor();
						if (298316 - 574001 == -275685)
						{
							this.$mPos$17849 = mPos;
							if (141488 - 17035 == 124453)
							{
								this.$tDir$17850 = tDir;
								if (244124 - 179092 == 65032)
								{
									this.$tID$17851 = tID;
									if (97499 - 28431 != 69069)
									{
										this.$self_$17852 = self_;
										if (85238 - 306480 != -221241)
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

			// Token: 0x06000F77 RID: 3959 RVA: 0x00185648 File Offset: 0x00183848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130348 - 437236 != -306887)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_665;
					case 2:
						if (this.$self_$17852.irwJBaTX7s.actionState != "attack")
						{
							goto IL_4A;
						}
						if (241009 - 201626 == 39384)
						{
							continue;
						}
						if (this.$self_$17852.irwJBaTX7s.myCommand != "acidDrop")
						{
							if (103706 - 523744 != -420038)
							{
								continue;
							}
							goto IL_4A;
						}
						else
						{
							if (!this.$self_$17852.irwJBaTX7s.isMine)
							{
								goto IL_7E;
							}
							if (83593 - 540987 != -457394)
							{
								continue;
							}
							this.$self_$17852.StartCoroutine_Auto(this.$self_$17852.RPC_acidDrop_hit(this.$mPos$17849 + this.$tDir$17850, this.$self_$17852.ewYJS1oQBb.forward, this.$tID$17851));
							if (34019 - 564103 != -530084)
							{
								continue;
							}
							this.$self_$17852.ActionEvent("RPC_acidDrop_hit", this.$mPos$17849 + this.$tDir$17850, this.$self_$17852.ewYJS1oQBb.forward, this.$tID$17851);
							if (158788 - 389475 != -230687)
							{
								continue;
							}
							goto IL_7E;
						}
						break;
					case 3:
						if (this.$self_$17852.irwJBaTX7s.actionState == "attack")
						{
							if (94574 - 95624 == -1049)
							{
								continue;
							}
							if (this.$self_$17852.irwJBaTX7s.myCommand == "acidDrop")
							{
								if (49247 - 512987 != -463740)
								{
									continue;
								}
								this.$self_$17852.irwJBaTX7s.actionState = "standby";
								if (241622 - 502077 != -260455)
								{
									continue;
								}
								this.$self_$17852.irwJBaTX7s.actionTime = Time.time;
								if (42498 - 341875 != -299377)
								{
									continue;
								}
								this.$self_$17852.irwJBaTX7s.myCommand = "none";
								if (284132 - 577476 != -293344)
								{
									continue;
								}
								if (!this.$self_$17852.irwJBaTX7s.isMine)
								{
									if (124175 - 127243 != -3068)
									{
										continue;
									}
									this.$self_$17852.irwJBaTX7s.nPosition = this.$self_$17852.transform.position;
									if (193448 - 285115 != -91667)
									{
										continue;
									}
									this.$self_$17852.irwJBaTX7s.oPosition = this.$self_$17852.transform.position;
									if (242822 - 566389 == -323566)
									{
										continue;
									}
									this.$self_$17852.irwJBaTX7s.nDirection = this.$self_$17852.transform.forward;
									if (43650 - 150991 != -107341)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (48596 - 565420 != -516824)
						{
							continue;
						}
						goto IL_665;
					default:
						if (162743 - 144378 != 18365)
						{
							continue;
						}
						break;
					}
					this.$self_$17852.irwJBaTX7s.actionState = "attack";
					if (123572 - 69276 == 54296)
					{
						this.$self_$17852.irwJBaTX7s.actionTime = Time.time;
						if (54620 - 496807 == -442187)
						{
							this.$self_$17852.irwJBaTX7s.myCommand = "acidDrop";
							if (204580 - 225120 == -20540)
							{
								this.$self_$17852.irwJBaTX7s.addTimeOut("nAttack", (float)3);
								if (215649 - 337163 != -121513)
								{
									this.$self_$17852.transform.position = this.$mPos$17849;
									if (189213 - 117845 == 71368)
									{
										this.$self_$17852.transform.LookAt(this.$mPos$17849 + global::Math.vFlat(this.$tDir$17850));
										if (237945 - 507378 != -269432)
										{
											this.$self_$17852.animation.Play("acidDrop");
											if (203475 - 17318 == 186157)
											{
												this.$self_$17852.animation.wrapMode = WrapMode.Once;
												if (56375 - 343238 != -286862)
												{
													this.$self_$17852.irwJBaTX7s.vMovement = this.$self_$17852.transform.forward;
													if (289588 - 65563 == 224025)
													{
														this.$self_$17852.irwJBaTX7s.moveSpeed = (float)0;
														if (173828 - 336043 != -162214)
														{
															if (this.$self_$17852.acidDrop_ring)
															{
																if (259788 - 530787 != -270998)
																{
																	this.$self_$17852.irwJBaTX7s.createEffect(this.$self_$17852.acidDrop_ring, this.$self_$17852.ewYJS1oQBb.position, this.$self_$17852.ewYJS1oQBb.rotation);
																	if (281841 - 189039 != 92803)
																	{
																		goto Block_27;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing acidDrop_ring effect");
																if (193835 - 218243 != -24407)
																{
																	goto Block_26;
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
				IL_4A:
				goto IL_665;
				IL_7E:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_26:
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_665:
				return false;
			}

			// Token: 0x06000F78 RID: 3960 RVA: 0x00185CCC File Offset: 0x00183ECC
			internal static bool KOdy83oIXjNavJMeV3Z()
			{
				return true;
			}

			// Token: 0x06000F79 RID: 3961 RVA: 0x00185CD0 File Offset: 0x00183ED0
			internal static bool wxWGXroB1Y8THTljqky()
			{
				return false;
			}

			// Token: 0x04000D40 RID: 3392
			internal Vector3 $mPos$17849;

			// Token: 0x04000D41 RID: 3393
			internal Vector3 $tDir$17850;

			// Token: 0x04000D42 RID: 3394
			internal int $tID$17851;

			// Token: 0x04000D43 RID: 3395
			internal FoulElement $self_$17852;
		}
	}

	// Token: 0x020002A6 RID: 678
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_acidDrop_hit$17857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x00185CD4 File Offset: 0x00183ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_acidDrop_hit$17857(Vector3 hitPos, FoulElement self_)
		{
			if (73170 - 256525 != -183354)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94528 - 554088 != -459559)
				{
					base..ctor();
					if (50566 - 102444 != -51877)
					{
						this.$hitPos$17865 = hitPos;
						if (54019 - 128574 == -74555)
						{
							this.$self_$17866 = self_;
							if (107478 - 419369 == -311891)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00185D90 File Offset: 0x00183F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_acidDrop_hit$17857.$(this.$hitPos$17865, this.$self_$17866);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00185DA4 File Offset: 0x00183FA4
		internal static bool aJb44ioeo6B2Bnq0J85()
		{
			return true;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00185DA8 File Offset: 0x00183FA8
		internal static bool hAmiu8orIdDlWM2jht3()
		{
			return false;
		}

		// Token: 0x04000D44 RID: 3396
		internal Vector3 $hitPos$17865;

		// Token: 0x04000D45 RID: 3397
		internal FoulElement $self_$17866;

		// Token: 0x020002A7 RID: 679
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F7E RID: 3966 RVA: 0x00185DAC File Offset: 0x00183FAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, FoulElement self_)
			{
				if (161958 - 203027 != -41069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189128 - 320344 == -131216)
					{
						base..ctor();
						if (96911 - 560604 != -463692)
						{
							this.$hitPos$17863 = hitPos;
							if (275302 - 104144 != 171159)
							{
								this.$self_$17864 = self_;
								if (34434 - 343601 != -309166)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x00185E68 File Offset: 0x00184068
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (137525 - 309738 != -172212)
				{
				}
				for (;;)
				{
					IL_343:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3D3;
					case 2:
						if (this.$self_$17864.irwJBaTX7s.hp <= 0)
						{
							if (102688 - 219076 != -116388)
							{
								continue;
							}
							goto IL_2C0;
						}
						else
						{
							if (this.$self_$17864.irwJBaTX7s.isMine)
							{
								if (262048 - 329739 == -67690)
								{
									continue;
								}
								this.$hitLayer$17858 = 130816 - (1 << this.$self_$17864.gameObject.layer);
								if (213263 - 300456 == -87192)
								{
									continue;
								}
								this.$hitList$17859 = Damage.FindAreaTarget(this.$hitPos$17863, (float)4, (float)3, this.$hitLayer$17858);
								if (133510 - 86343 != 47167)
								{
									continue;
								}
								this.$$iterator$10068$17862 = UnityRuntimeServices.GetEnumerator(this.$hitList$17859);
								if (54617 - 120824 == -66206)
								{
									continue;
								}
								while (this.$$iterator$10068$17862.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10068$17862.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17860 = (GameObject)obj2;
									if (254744 - 103536 != 151208)
									{
										goto IL_343;
									}
									if (this.$self_$17864.irwJBaTX7s.hit(1, this.$hitObject$17860, this.$self_$17864.irwJBaTX7s.atk, 2, 0, (float)2 * this.$self_$17864.ewYJS1oQBb.forward) != 0)
									{
										if (134548 - 388478 == -253929)
										{
											goto IL_343;
										}
										this.$hitChar$17861 = (CharacterControl)this.$hitObject$17860.GetComponent(typeof(CharacterControl));
										if (157822 - 277216 != -119394)
										{
											goto IL_343;
										}
										UnityRuntimeServices.Update(this.$$iterator$10068$17862, this.$hitObject$17860);
										if (238559 - 102938 != 135621)
										{
											goto IL_343;
										}
										if (this.$hitChar$17861)
										{
											if (212563 - 561323 == -348759)
											{
												goto IL_343;
											}
											this.$hitChar$17861.RPC_AddStatus("acid", 5, Damage.getDebuff((float)15, this.$self_$17864.irwJBaTX7s.cha, this.$hitChar$17861.cha), 0, this.$self_$17864.irwJBaTX7s.ActorNr);
											if (185128 - 120595 != 64533)
											{
												goto IL_343;
											}
										}
									}
								}
								if (207757 - 531942 == -324184)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (146614 - 312484 != -165869)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					default:
						if (299039 - 219542 != 79497)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17864.acidDrop_hit)
					{
						if (38273 - 409434 == -371161)
						{
							UnityEngine.Object.Instantiate(this.$self_$17864.acidDrop_hit, this.$hitPos$17863, Quaternion.identity);
							if (12337 - 229884 == -217547)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing acidDrop_hit effect");
						if (14066 - 147186 != -133119)
						{
							break;
						}
					}
				}
				IL_223:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_17:
				IL_2C0:
				goto IL_3D3;
				goto IL_223;
				IL_3D3:
				return false;
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x0018625C File Offset: 0x0018445C
			internal static bool WJBIk2ojjbWBvjXVmB3()
			{
				return true;
			}

			// Token: 0x06000F81 RID: 3969 RVA: 0x00186260 File Offset: 0x00184460
			internal static bool fD4rXeohRSIP3gjdB09()
			{
				return false;
			}

			// Token: 0x04000D46 RID: 3398
			internal int $hitLayer$17858;

			// Token: 0x04000D47 RID: 3399
			internal UnityScript.Lang.Array $hitList$17859;

			// Token: 0x04000D48 RID: 3400
			internal GameObject $hitObject$17860;

			// Token: 0x04000D49 RID: 3401
			internal CharacterControl $hitChar$17861;

			// Token: 0x04000D4A RID: 3402
			internal IEnumerator $$iterator$10068$17862;

			// Token: 0x04000D4B RID: 3403
			internal Vector3 $hitPos$17863;

			// Token: 0x04000D4C RID: 3404
			internal FoulElement $self_$17864;
		}
	}

	// Token: 0x020002A8 RID: 680
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_poisonGas$17867 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F82 RID: 3970 RVA: 0x00186264 File Offset: 0x00184464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_poisonGas$17867(Vector3 mPos, Vector3 tDir, FoulElement self_)
		{
			if (276048 - 1142 != 274906)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273898 - 294495 != -20596)
				{
					base..ctor();
					if (108954 - 234878 == -125924)
					{
						this.$mPos$17876 = mPos;
						if (188116 - 129009 != 59108)
						{
							this.$tDir$17877 = tDir;
							if (102006 - 452346 == -350340)
							{
								this.$self_$17878 = self_;
								if (66661 - 117944 == -51283)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00186340 File Offset: 0x00184540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_poisonGas$17867.$(this.$mPos$17876, this.$tDir$17877, this.$self_$17878);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0018635C File Offset: 0x0018455C
		internal static bool yS7kfPosoOil8Vv6Khk()
		{
			return true;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00186360 File Offset: 0x00184560
		internal static bool EP4Pnto9uaE33cPJO7p()
		{
			return false;
		}

		// Token: 0x04000D4D RID: 3405
		internal Vector3 $mPos$17876;

		// Token: 0x04000D4E RID: 3406
		internal Vector3 $tDir$17877;

		// Token: 0x04000D4F RID: 3407
		internal FoulElement $self_$17878;

		// Token: 0x020002A9 RID: 681
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F86 RID: 3974 RVA: 0x00186364 File Offset: 0x00184564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FoulElement self_)
			{
				if (198169 - 326469 != -128299)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284592 - 330686 == -46094)
					{
						base..ctor();
						if (131318 - 195806 != -64487)
						{
							this.$mPos$17873 = mPos;
							if (124060 - 227064 != -103003)
							{
								this.$tDir$17874 = tDir;
								if (254560 - 214882 != 39679)
								{
									this.$self_$17875 = self_;
									if (7086 - 45553 != -38466)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F87 RID: 3975 RVA: 0x00186440 File Offset: 0x00184640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38103 - 543954 != -505851)
				{
				}
				for (;;)
				{
					IL_7F1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B7;
					case 2:
						if (this.$self_$17875.irwJBaTX7s.actionState != "attack")
						{
							goto IL_5F7;
						}
						if (47 - 242803 != -242756)
						{
							continue;
						}
						if (this.$self_$17875.irwJBaTX7s.myCommand != "poisonGas")
						{
							if (79919 - 54079 != 25841)
							{
								goto Block_51;
							}
							continue;
						}
						else if (this.$self_$17875.poisonGas_ring)
						{
							if (211764 - 236514 != -24750)
							{
								continue;
							}
							this.$self_$17875.irwJBaTX7s.createEffect(this.$self_$17875.poisonGas_ring, this.$self_$17875.ewYJS1oQBb.position, this.$self_$17875.ewYJS1oQBb.rotation);
							if (294083 - 553023 != -258940)
							{
								continue;
							}
							goto IL_88E;
						}
						else
						{
							Debug.LogError("Missing poisonGas effect");
							if (127748 - 26552 != 101196)
							{
								continue;
							}
							goto IL_56F;
						}
						break;
					case 3:
						if (this.$self_$17875.irwJBaTX7s.actionState != "attack")
						{
							goto IL_1A;
						}
						if (1879 - 273200 == -271320)
						{
							continue;
						}
						if (this.$self_$17875.irwJBaTX7s.myCommand != "poisonGas")
						{
							if (218594 - 259442 != -40848)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$17875.irwJBaTX7s.isMine)
							{
								goto IL_220;
							}
							if (271707 - 56396 != 215311)
							{
								continue;
							}
							this.$hitLayer$17868 = 130816 - (1 << this.$self_$17875.gameObject.layer);
							if (63258 - 19293 != 43965)
							{
								continue;
							}
							this.$hitList$17869 = Damage.FindAreaTarget(this.$self_$17875.transform.position, (float)24, (float)6, this.$hitLayer$17868);
							if (40876 - 486892 == -446015)
							{
								continue;
							}
							this.$$iterator$10069$17872 = UnityRuntimeServices.GetEnumerator(this.$hitList$17869);
							if (22882 - 141149 == -118266)
							{
								continue;
							}
							while (this.$$iterator$10069$17872.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10069$17872.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17870 = (GameObject)obj2;
								if (81851 - 230207 == -148355)
								{
									goto IL_7F1;
								}
								if (this.$self_$17875.irwJBaTX7s.hit(1, this.$hitObject$17870, this.$self_$17875.irwJBaTX7s.atk, 2, 0, (float)2 * this.$self_$17875.ewYJS1oQBb.forward) != 0)
								{
									if (32415 - 363254 != -330839)
									{
										goto IL_7F1;
									}
									this.$hitChar$17871 = (CharacterControl)this.$hitObject$17870.GetComponent(typeof(CharacterControl));
									if (107315 - 21182 == 86134)
									{
										goto IL_7F1;
									}
									UnityRuntimeServices.Update(this.$$iterator$10069$17872, this.$hitObject$17870);
									if (192236 - 238129 == -45892)
									{
										goto IL_7F1;
									}
									if (this.$hitChar$17871)
									{
										if (272452 - 59076 == 213377)
										{
											goto IL_7F1;
										}
										this.$hitChar$17871.RPC_AddStatus("poison", 5, Damage.getDebuff((float)15, this.$self_$17875.irwJBaTX7s.cha, this.$hitChar$17871.cha), 0, this.$self_$17875.irwJBaTX7s.ActorNr);
										if (298797 - 540152 != -241355)
										{
											goto IL_7F1;
										}
									}
								}
							}
							if (274656 - 516340 != -241683)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17875.irwJBaTX7s.actionState == "attack")
						{
							if (114818 - 280193 != -165375)
							{
								continue;
							}
							if (this.$self_$17875.irwJBaTX7s.myCommand == "poisonGas")
							{
								if (151566 - 120314 != 31252)
								{
									continue;
								}
								this.$self_$17875.irwJBaTX7s.actionState = "standby";
								if (145346 - 182237 == -36890)
								{
									continue;
								}
								this.$self_$17875.irwJBaTX7s.actionTime = Time.time;
								if (124709 - 105367 != 19342)
								{
									continue;
								}
								this.$self_$17875.irwJBaTX7s.myCommand = "none";
								if (295993 - 481671 == -185677)
								{
									continue;
								}
								if (!this.$self_$17875.irwJBaTX7s.isMine)
								{
									if (32557 - 150929 == -118371)
									{
										continue;
									}
									this.$self_$17875.irwJBaTX7s.nPosition = this.$self_$17875.transform.position;
									if (264267 - 431814 != -167547)
									{
										continue;
									}
									this.$self_$17875.irwJBaTX7s.oPosition = this.$self_$17875.transform.position;
									if (215357 - 168115 != 47242)
									{
										continue;
									}
									this.$self_$17875.irwJBaTX7s.nDirection = this.$self_$17875.transform.forward;
									if (27225 - 327080 == -299854)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (106428 - 355991 != -249562)
						{
							goto Block_34;
						}
						continue;
					default:
						if (179530 - 392619 != -213089)
						{
							continue;
						}
						break;
					}
					this.$self_$17875.irwJBaTX7s.actionState = "attack";
					if (104617 - 205381 == -100764)
					{
						this.$self_$17875.irwJBaTX7s.actionTime = Time.time;
						if (80010 - 105433 == -25423)
						{
							this.$self_$17875.irwJBaTX7s.myCommand = "poisonGas";
							if (280332 - 373940 != -93607)
							{
								this.$self_$17875.irwJBaTX7s.addTimeOut("cAttack", (float)12);
								if (292343 - 401426 != -109082)
								{
									this.$self_$17875.transform.position = this.$mPos$17873;
									if (248750 - 351677 != -102926)
									{
										this.$self_$17875.transform.LookAt(this.$mPos$17873 + global::Math.vFlat(this.$tDir$17874));
										if (181460 - 253706 != -72245)
										{
											this.$self_$17875.animation.Play("poisonGas");
											if (28907 - 164346 == -135439)
											{
												this.$self_$17875.animation.wrapMode = WrapMode.Once;
												if (31563 - 201456 == -169893)
												{
													this.$self_$17875.irwJBaTX7s.vMovement = this.$self_$17875.transform.forward;
													if (104952 - 138317 == -33365)
													{
														this.$self_$17875.irwJBaTX7s.moveSpeed = (float)0;
														if (205925 - 336192 == -130267)
														{
															goto IL_175;
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
				IL_1A:
				goto IL_8B7;
				IL_175:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_220:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_28:
				goto IL_220;
				Block_34:
				goto IL_8B7;
				IL_56F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_5F7:
				goto IL_8B7;
				Block_51:
				goto IL_5F7;
				IL_88E:
				goto IL_56F;
				IL_8B7:
				return false;
			}

			// Token: 0x06000F88 RID: 3976 RVA: 0x00186D18 File Offset: 0x00184F18
			internal static bool oqR3Q1o1y0JVoQEmhJ1()
			{
				return true;
			}

			// Token: 0x06000F89 RID: 3977 RVA: 0x00186D1C File Offset: 0x00184F1C
			internal static bool oyc6Vno4rxttAY0Q5MH()
			{
				return false;
			}

			// Token: 0x04000D50 RID: 3408
			internal int $hitLayer$17868;

			// Token: 0x04000D51 RID: 3409
			internal UnityScript.Lang.Array $hitList$17869;

			// Token: 0x04000D52 RID: 3410
			internal GameObject $hitObject$17870;

			// Token: 0x04000D53 RID: 3411
			internal CharacterControl $hitChar$17871;

			// Token: 0x04000D54 RID: 3412
			internal IEnumerator $$iterator$10069$17872;

			// Token: 0x04000D55 RID: 3413
			internal Vector3 $mPos$17873;

			// Token: 0x04000D56 RID: 3414
			internal Vector3 $tDir$17874;

			// Token: 0x04000D57 RID: 3415
			internal FoulElement $self_$17875;
		}
	}

	// Token: 0x020002AA RID: 682
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_massProvoke$17879 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F8A RID: 3978 RVA: 0x00186D20 File Offset: 0x00184F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_massProvoke$17879(Vector3 mPos, Vector3 tDir, FoulElement self_)
		{
			if (285779 - 522657 != -236877)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266362 - 592480 == -326118)
				{
					base..ctor();
					if (112395 - 528528 != -416132)
					{
						this.$mPos$17888 = mPos;
						if (144786 - 255137 != -110350)
						{
							this.$tDir$17889 = tDir;
							if (169613 - 308472 == -138859)
							{
								this.$self_$17890 = self_;
								if (242759 - 438381 != -195621)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00186DFC File Offset: 0x00184FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_massProvoke$17879.$(this.$mPos$17888, this.$tDir$17889, this.$self_$17890);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00186E18 File Offset: 0x00185018
		internal static bool VvbaQ0ozdwhAaX3ug2k()
		{
			return true;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00186E1C File Offset: 0x0018501C
		internal static bool VehpGUEaJ1fb5ld3KlY()
		{
			return false;
		}

		// Token: 0x04000D58 RID: 3416
		internal Vector3 $mPos$17888;

		// Token: 0x04000D59 RID: 3417
		internal Vector3 $tDir$17889;

		// Token: 0x04000D5A RID: 3418
		internal FoulElement $self_$17890;

		// Token: 0x020002AB RID: 683
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F8E RID: 3982 RVA: 0x00186E20 File Offset: 0x00185020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FoulElement self_)
			{
				if (126981 - 213397 != -86415)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39592 - 339736 != -300143)
					{
						base..ctor();
						if (155796 - 555269 == -399473)
						{
							this.$mPos$17885 = mPos;
							if (225599 - 500639 == -275040)
							{
								this.$tDir$17886 = tDir;
								if (256735 - 7844 != 248892)
								{
									this.$self_$17887 = self_;
									if (4166 - 299998 != -295831)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F8F RID: 3983 RVA: 0x00186EFC File Offset: 0x001850FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125714 - 112541 != 13173)
				{
				}
				for (;;)
				{
					IL_392:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_858;
					case 2:
						if (this.$self_$17887.irwJBaTX7s.actionState != "attack")
						{
							goto IL_5ED;
						}
						if (53756 - 128019 != -74263)
						{
							continue;
						}
						if (this.$self_$17887.irwJBaTX7s.myCommand != "massProvoke")
						{
							if (173483 - 152318 != 21166)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17887.irwJBaTX7s.isMine)
							{
								goto IL_59E;
							}
							if (134974 - 430847 != -295873)
							{
								continue;
							}
							this.$hitLayer$17880 = 130816 - (1 << this.$self_$17887.gameObject.layer);
							if (246059 - 485715 == -239655)
							{
								continue;
							}
							this.$hitList$17881 = Damage.FindAreaTarget(this.$self_$17887.transform.position, (float)36, (float)6, this.$hitLayer$17880);
							if (293717 - 560687 != -266970)
							{
								continue;
							}
							this.$$iterator$10070$17884 = UnityRuntimeServices.GetEnumerator(this.$hitList$17881);
							if (27674 - 576916 != -549242)
							{
								continue;
							}
							while (this.$$iterator$10070$17884.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10070$17884.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17882 = (GameObject)obj2;
								if (10866 - 569905 != -559039)
								{
									goto IL_392;
								}
								if (this.$self_$17887.irwJBaTX7s.hit(1, this.$hitObject$17882, this.$self_$17887.irwJBaTX7s.atk, 2, 0, (float)2 * this.$self_$17887.ewYJS1oQBb.forward) != 0)
								{
									if (123176 - 181932 == -58755)
									{
										goto IL_392;
									}
									this.$hitChar$17883 = (CharacterControl)this.$hitObject$17882.GetComponent(typeof(CharacterControl));
									if (32043 - 341300 != -309257)
									{
										goto IL_392;
									}
									UnityRuntimeServices.Update(this.$$iterator$10070$17884, this.$hitObject$17882);
									if (137495 - 489327 == -351831)
									{
										goto IL_392;
									}
									if (this.$hitChar$17883)
									{
										if (117037 - 422537 != -305500)
										{
											goto IL_392;
										}
										this.$hitChar$17883.RPC_AddStatus("provoke", 2, Damage.getDebuff((float)15, this.$self_$17887.irwJBaTX7s.cha, this.$hitChar$17883.cha), 0, this.$self_$17887.irwJBaTX7s.ActorNr);
										if (206025 - 128678 == 77348)
										{
											goto IL_392;
										}
									}
								}
							}
							if (137065 - 383621 != -246556)
							{
								continue;
							}
							goto IL_59E;
						}
						break;
					case 3:
						if (this.$self_$17887.irwJBaTX7s.actionState == "attack")
						{
							if (146363 - 440583 != -294220)
							{
								continue;
							}
							if (this.$self_$17887.irwJBaTX7s.myCommand == "massProvoke")
							{
								if (152637 - 496943 == -344305)
								{
									continue;
								}
								this.$self_$17887.irwJBaTX7s.actionState = "standby";
								if (255923 - 210834 != 45089)
								{
									continue;
								}
								this.$self_$17887.irwJBaTX7s.actionTime = Time.time;
								if (191452 - 225274 != -33822)
								{
									continue;
								}
								this.$self_$17887.irwJBaTX7s.myCommand = "none";
								if (230282 - 362208 != -131926)
								{
									continue;
								}
								if (!this.$self_$17887.irwJBaTX7s.isMine)
								{
									if (124669 - 445696 == -321026)
									{
										continue;
									}
									this.$self_$17887.irwJBaTX7s.nPosition = this.$self_$17887.transform.position;
									if (187281 - 540728 == -353446)
									{
										continue;
									}
									this.$self_$17887.irwJBaTX7s.oPosition = this.$self_$17887.transform.position;
									if (138750 - 251515 == -112764)
									{
										continue;
									}
									this.$self_$17887.irwJBaTX7s.nDirection = this.$self_$17887.transform.forward;
									if (260841 - 362825 == -101983)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (239501 - 447730 != -208228)
						{
							goto Block_2;
						}
						continue;
					default:
						if (114829 - 146967 == -32137)
						{
							continue;
						}
						break;
					}
					this.$self_$17887.irwJBaTX7s.actionState = "attack";
					if (16641 - 318846 != -302204)
					{
						this.$self_$17887.irwJBaTX7s.actionTime = Time.time;
						if (39333 - 423056 != -383722)
						{
							this.$self_$17887.irwJBaTX7s.myCommand = "massProvoke";
							if (99002 - 563187 != -464184)
							{
								this.$self_$17887.irwJBaTX7s.addTimeOut("cAttack", (float)12);
								if (249103 - 211347 != 37757)
								{
									this.$self_$17887.irwJBaTX7s.addTimeOut("massProvoke", (float)24);
									if (261589 - 302722 == -41133)
									{
										this.$self_$17887.transform.position = this.$mPos$17885;
										if (226754 - 503207 == -276453)
										{
											this.$self_$17887.transform.LookAt(this.$mPos$17885 + global::Math.vFlat(this.$tDir$17886));
											if (253692 - 528273 != -274580)
											{
												this.$self_$17887.animation.Play("massProvoke");
												if (275147 - 494297 == -219150)
												{
													this.$self_$17887.animation.wrapMode = WrapMode.Once;
													if (121186 - 511644 != -390457)
													{
														this.$self_$17887.irwJBaTX7s.vMovement = this.$self_$17887.transform.forward;
														if (83291 - 253893 != -170601)
														{
															this.$self_$17887.irwJBaTX7s.moveSpeed = (float)0;
															if (33853 - 452776 == -418923)
															{
																if (this.$self_$17887.massProvoke_ring)
																{
																	if (134282 - 272832 != -138549)
																	{
																		this.$self_$17887.irwJBaTX7s.createEffect(this.$self_$17887.massProvoke_ring, this.$self_$17887.ewYJS1oQBb.position, this.$self_$17887.ewYJS1oQBb.rotation);
																		if (87744 - 323691 == -235947)
																		{
																			goto IL_2E5;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing massProvoke effect");
																	if (292513 - 417691 == -125178)
																	{
																		goto IL_651;
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
				Block_2:
				goto IL_858;
				IL_2E5:
				goto IL_651;
				Block_29:
				goto IL_5ED;
				IL_59E:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5ED:
				goto IL_858;
				IL_651:
				return this.Yield(2, new WaitForSeconds(2.3f));
				IL_858:
				return false;
			}

			// Token: 0x06000F90 RID: 3984 RVA: 0x00187774 File Offset: 0x00185974
			internal static bool h8kOI0E50prFoMyMtBC()
			{
				return true;
			}

			// Token: 0x06000F91 RID: 3985 RVA: 0x00187778 File Offset: 0x00185978
			internal static bool junYZPEp5Ttb2cI1P9H()
			{
				return false;
			}

			// Token: 0x04000D5B RID: 3419
			internal int $hitLayer$17880;

			// Token: 0x04000D5C RID: 3420
			internal UnityScript.Lang.Array $hitList$17881;

			// Token: 0x04000D5D RID: 3421
			internal GameObject $hitObject$17882;

			// Token: 0x04000D5E RID: 3422
			internal CharacterControl $hitChar$17883;

			// Token: 0x04000D5F RID: 3423
			internal IEnumerator $$iterator$10070$17884;

			// Token: 0x04000D60 RID: 3424
			internal Vector3 $mPos$17885;

			// Token: 0x04000D61 RID: 3425
			internal Vector3 $tDir$17886;

			// Token: 0x04000D62 RID: 3426
			internal FoulElement $self_$17887;
		}
	}

	// Token: 0x020002AC RID: 684
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17891 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x0018777C File Offset: 0x0018597C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17891(UnityScript.Lang.Array nArray, FoulElement self_)
		{
			if (147600 - 590609 != -443008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173992 - 280226 == -106234)
				{
					base..ctor();
					if (137823 - 100075 != 37749)
					{
						this.$nArray$17896 = nArray;
						if (259505 - 171649 == 87856)
						{
							this.$self_$17897 = self_;
							if (62933 - 239227 == -176294)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00187838 File Offset: 0x00185A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FoulElement.$RPC_dead$17891.$(this.$nArray$17896, this.$self_$17897);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0018784C File Offset: 0x00185A4C
		internal static bool GGRxuSEVAb8y6OhCP3v()
		{
			return true;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00187850 File Offset: 0x00185A50
		internal static bool g4pbRbEtpA9L9vy814p()
		{
			return false;
		}

		// Token: 0x04000D63 RID: 3427
		internal UnityScript.Lang.Array $nArray$17896;

		// Token: 0x04000D64 RID: 3428
		internal FoulElement $self_$17897;

		// Token: 0x020002AD RID: 685
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F96 RID: 3990 RVA: 0x00187854 File Offset: 0x00185A54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FoulElement self_)
			{
				if (29803 - 201420 != -171617)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157352 - 551699 == -394347)
					{
						base..ctor();
						if (158083 - 119571 != 38513)
						{
							this.$nArray$17894 = nArray;
							if (298906 - 206204 == 92702)
							{
								this.$self_$17895 = self_;
								if (227218 - 428320 != -201101)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F97 RID: 3991 RVA: 0x00187910 File Offset: 0x00185B10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227909 - 148469 != 79440)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4DD;
					case 2:
						if (this.$self_$17895.irwJBaTX7s.actionState != "dead")
						{
							if (63130 - 178271 != -115140)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17895.irwJBaTX7s.isPlayer)
							{
								if (245927 - 67933 != 177994)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17895.gameObject);
								if (134733 - 291072 == -156338)
								{
									continue;
								}
							}
							else if (this.$self_$17895.irwJBaTX7s.isMine)
							{
								if (46569 - 343370 != -296801)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17895.gameObject);
								if (51485 - 535349 == -483863)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (80996 - 56233 != 24764)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					default:
						if (288897 - 546986 == -258088)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17895.irwJBaTX7s.actionState == "dead")
					{
						if (230291 - 15969 != 214323)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17892 = (Vector3)this.$nArray$17894[0];
						if (287906 - 38928 == 248978)
						{
							this.$myDirection$17893 = (Vector3)this.$nArray$17894[1];
							if (241779 - 176481 == 65298)
							{
								this.$self_$17895.transform.position = this.$myPosition$17892;
								if (200004 - 545464 == -345460)
								{
									this.$self_$17895.transform.LookAt(this.$myPosition$17892 + this.$myDirection$17893);
									if (85457 - 448059 == -362602)
									{
										this.$self_$17895.irwJBaTX7s.hp = 0;
										if (141153 - 194980 == -53827)
										{
											this.$self_$17895.irwJBaTX7s.actionState = "dead";
											if (114410 - 309191 == -194781)
											{
												this.$self_$17895.irwJBaTX7s.actionTime = Time.time;
												if (258316 - 426652 != -168335)
												{
													this.$self_$17895.irwJBaTX7s.myCommand = "none";
													if (85994 - 538455 != -452460)
													{
														this.$self_$17895.irwJBaTX7s.vMovement = Vector3.zero;
														if (73246 - 289140 != -215893)
														{
															this.$self_$17895.irwJBaTX7s.moveSpeed = (float)0;
															if (90186 - 273442 != -183255)
															{
																this.$self_$17895.animation.Rewind();
																if (212883 - 197549 == 15334)
																{
																	this.$self_$17895.animation.Play("ko");
																	if (264022 - 69508 != 194515)
																	{
																		this.$self_$17895.animation.wrapMode = WrapMode.Once;
																		if (92249 - 473950 != -381700)
																		{
																			if (this.$self_$17895.dead_ring)
																			{
																				if (287301 - 290444 == -3143)
																				{
																					this.$self_$17895.irwJBaTX7s.createEffect(this.$self_$17895.dead_ring, this.$self_$17895.ewYJS1oQBb.position, this.$self_$17895.ewYJS1oQBb.rotation);
																					if (115339 - 506286 != -390946)
																					{
																						goto Block_8;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing dead ring effect");
																				if (272544 - 547600 == -275056)
																				{
																					goto IL_372;
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
						}
					}
				}
				goto IL_4DD;
				Block_8:
				goto IL_372;
				Block_20:
				goto IL_4DD;
				IL_372:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				IL_4DD:
				return false;
			}

			// Token: 0x06000F98 RID: 3992 RVA: 0x00187E0C File Offset: 0x0018600C
			internal static bool J40SfyENiC1HggT5OIY()
			{
				return true;
			}

			// Token: 0x06000F99 RID: 3993 RVA: 0x00187E10 File Offset: 0x00186010
			internal static bool Nwasn3EYo2eAJMsTWaW()
			{
				return false;
			}

			// Token: 0x04000D65 RID: 3429
			internal Vector3 $myPosition$17892;

			// Token: 0x04000D66 RID: 3430
			internal Vector3 $myDirection$17893;

			// Token: 0x04000D67 RID: 3431
			internal UnityScript.Lang.Array $nArray$17894;

			// Token: 0x04000D68 RID: 3432
			internal FoulElement $self_$17895;
		}
	}
}
