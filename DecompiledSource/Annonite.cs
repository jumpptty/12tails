using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B59 RID: 2905
[Serializable]
public class Annonite : MonoBehaviour
{
	// Token: 0x060040AC RID: 16556 RVA: 0x00836018 File Offset: 0x00834218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Annonite()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x00836028 File Offset: 0x00834228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (259405 - 447183 != -187777)
		{
		}
		for (;;)
		{
			this.YUPyzZaOk7 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (50691 - 55144 != -4452)
			{
				this.YUPyzZaOk7.actionState = "standby";
				if (148109 - 210186 == -62077)
				{
					this.YUPyzZaOk7.actionTime = Time.time;
					if (120240 - 36075 != 84166)
					{
						this.YUPyzZaOk7.myCommand = "none";
						if (184320 - 107129 != 77192)
						{
							this.FmmV58m6Wm = (CharacterController)this.GetComponent(typeof(CharacterController));
							if (197629 - 296234 != -98604)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x00836148 File Offset: 0x00834348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197748 - 168230 != 29519)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (292840 - 389105 == -96264)
				{
					continue;
				}
				this.YUPyzZaOk7.isMine = true;
				if (213516 - 259262 != -45746)
				{
					continue;
				}
			}
			this.DjKVc0lbTZ = this.transform.position + this.transform.forward;
			if (12961 - 92586 == -79625)
			{
				this.LerVnkBM9o = this.transform.forward;
				if (37461 - 261683 == -224222)
				{
					AnimationEvent animationEvent = new AnimationEvent();
					if (84905 - 552524 != -467618)
					{
						animationEvent.functionName = "playSwimFxEvent";
						if (266402 - 121951 == 144451)
						{
							animationEvent.time = 0.3f;
							if (157093 - 467357 != -310263)
							{
								this.animation["swim"].clip.AddEvent(animationEvent);
								if (34770 - 580568 == -545798)
								{
									AnimationEvent animationEvent2 = new AnimationEvent();
									if (287470 - 426238 != -138767)
									{
										animationEvent2.functionName = "playSwimFxEvent";
										if (50447 - 396030 == -345583)
										{
											animationEvent2.time = 0.3f;
											if (96262 - 63115 == 33147)
											{
												this.animation["swimLeft"].clip.AddEvent(animationEvent2);
												if (54582 - 215559 != -160976)
												{
													AnimationEvent animationEvent3 = new AnimationEvent();
													if (230390 - 277873 != -47482)
													{
														animationEvent3.functionName = "playSwimFxEvent";
														if (228613 - 477209 == -248596)
														{
															animationEvent3.time = 0.3f;
															if (213261 - 516764 == -303503)
															{
																this.animation["swimRight"].clip.AddEvent(animationEvent3);
																if (227652 - 401012 == -173360)
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

	// Token: 0x060040AF RID: 16559 RVA: 0x00836410 File Offset: 0x00834610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playSwimFxEvent(AnimationEvent animEvent)
	{
		if (this.swim_fx)
		{
			this.audio.PlayOneShot(this.swim_fx);
		}
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x00836434 File Offset: 0x00834634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (288845 - 254281 != 34565)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (110728 - 264362 == -153634)
				{
					break;
				}
			}
			else
			{
				if (this.YUPyzZaOk7.isMine)
				{
					if (161612 - 113088 != 48524)
					{
						continue;
					}
					if (this.YUPyzZaOk7.actionState == "standby")
					{
						if (274477 - 89055 == 185423)
						{
							continue;
						}
						this.LerVnkBM9o = (this.transform.forward + 0.5f * Input.GetAxisRaw("Vertical") * Vector3.up + 0.5f * Input.GetAxisRaw("Horizontal") * this.transform.right).normalized;
						if (156865 - 401279 == -244413)
						{
							continue;
						}
						this.LerVnkBM9o.y = Mathf.Clamp(this.LerVnkBM9o.y, -0.6f, 0.6f);
						if (77076 - 62380 == 14697)
						{
							continue;
						}
						this.DjKVc0lbTZ = this.transform.position + this.LerVnkBM9o;
						if (139066 - 62832 == 76235)
						{
							continue;
						}
						if (Time.time >= this.iykVQLuq94)
						{
							if (183575 - 429895 != -246320)
							{
								continue;
							}
							if (Input.GetKeyDown(KeyCode.Space))
							{
								if (136931 - 519394 != -382463)
								{
									continue;
								}
								this.iykVQLuq94 = Time.time + 0.3f;
								if (133543 - 480475 == -346931)
								{
									continue;
								}
								this.animation.Rewind();
								if (12354 - 516303 != -503949)
								{
									continue;
								}
								this.animation.CrossFade("swimBoost", 0.1f);
								if (182364 - 464103 == -281738)
								{
									continue;
								}
								if (this.swimBoost)
								{
									if (29309 - 271377 == -242067)
									{
										continue;
									}
									this.YUPyzZaOk7.createEffect(this.swimBoost, this.transform.position, this.transform.rotation);
									if (109731 - 191967 != -82236)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing swimBoost effect");
									if (20207 - 197858 == -177650)
									{
										continue;
									}
								}
							}
						}
					}
					else
					{
						this.LerVnkBM9o = this.transform.forward;
						if (260770 - 145106 == 115665)
						{
							continue;
						}
						this.DjKVc0lbTZ = this.transform.position + this.LerVnkBM9o;
						if (21877 - 595289 == -573411)
						{
							continue;
						}
					}
					this.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.transform.forward, this.LerVnkBM9o, Time.deltaTime, 1f));
					if (29669 - 195480 != -165811)
					{
						continue;
					}
					if (this.iykVQLuq94 > Time.time)
					{
						if (138266 - 542705 == -404438)
						{
							continue;
						}
						this.FmmV58m6Wm.Move(((float)7 + (float)10 * (this.iykVQLuq94 - Time.time)) * this.LerVnkBM9o * Time.deltaTime);
						if (13558 - 364462 != -350904)
						{
							continue;
						}
					}
					else
					{
						this.FmmV58m6Wm.Move((float)7 * this.LerVnkBM9o * Time.deltaTime);
						if (67927 - 440719 == -372791)
						{
							continue;
						}
						float axisRaw = Input.GetAxisRaw("Horizontal");
						if (39076 - 378090 == -339013)
						{
							continue;
						}
						if (axisRaw == (float)-1)
						{
							if (81373 - 392918 == -311544)
							{
								continue;
							}
							this.animation.CrossFade("swimLeft");
							if (34553 - 511420 != -476867)
							{
								continue;
							}
						}
						else if (axisRaw == (float)1)
						{
							if (151388 - 296762 == -145373)
							{
								continue;
							}
							this.animation.CrossFade("swimRight");
							if (259672 - 91741 == 167932)
							{
								continue;
							}
						}
						else
						{
							this.animation.CrossFade("swim");
							if (101432 - 133885 != -32453)
							{
								continue;
							}
						}
					}
					this.NetworkUpdate();
					if (30225 - 146714 == -116488)
					{
						continue;
					}
				}
				else
				{
					this.DjKVc0lbTZ = this.YUPyzZaOk7.nPosition;
					if (298358 - 414378 != -116020)
					{
						continue;
					}
					this.LerVnkBM9o = (this.DjKVc0lbTZ - this.transform.position).normalized;
					if (20877 - 88712 == -67834)
					{
						continue;
					}
					float num = Vector3.Angle(global::Math.vFlat(this.transform.forward), global::Math.vFlat(this.LerVnkBM9o));
					if (32574 - 329509 != -296935)
					{
						continue;
					}
					if (num > (float)0)
					{
						if (136188 - 35356 == 100833)
						{
							continue;
						}
						this.animation.CrossFade("swimLeft");
						if (138410 - 423471 == -285060)
						{
							continue;
						}
					}
					else if (num > (float)0)
					{
						if (63392 - 378044 == -314651)
						{
							continue;
						}
						this.animation.CrossFade("swimRight");
						if (164517 - 284787 == -120269)
						{
							continue;
						}
					}
					else
					{
						this.animation.CrossFade("swim");
						if (157846 - 37948 != 119898)
						{
							continue;
						}
					}
					this.transform.position = Vector3.Lerp(this.transform.position, this.DjKVc0lbTZ, (float)3 * Time.deltaTime);
					if (142592 - 260517 == -117924)
					{
						continue;
					}
					this.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.transform.forward, this.LerVnkBM9o, Time.deltaTime, 1f));
					if (296936 - 550529 != -253593)
					{
						continue;
					}
				}
				this.YUPyzZaOk7.vMovement = this.LerVnkBM9o;
				if (154123 - 246784 == -92661)
				{
					this.YUPyzZaOk7.moveSpeed = (float)0;
					if (214610 - 45221 == 169389)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x00836C18 File Offset: 0x00834E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void NetworkUpdate()
	{
		if (87923 - 230504 != -142580)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (265718 - 338574 != -72855)
				{
					break;
				}
			}
			else
			{
				if (Time.time <= this.KmkVetVv8T)
				{
					break;
				}
				if (262733 - 587395 != -324661)
				{
					this.KmkVetVv8T = Time.time + 0.15f;
					if (179402 - 529514 == -350112)
					{
						Vector3 vector = this.transform.position + 0.3f * this.LerVnkBM9o;
						if (139697 - 210502 == -70805)
						{
							Hashtable hashtable = new Hashtable();
							if (174214 - 172901 == 1313)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(vector.x * (float)50)));
								if (187173 - 162522 == 24651)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(vector.y * (float)50)));
									if (79247 - 58245 != 21003)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(vector.z * (float)50)));
										if (46831 - 364378 == -317547)
										{
											hashtable.Add(125, PhotonClient.cInt16(0));
											if (117662 - 563421 != -445758)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (62241 - 260885 == -198644)
												{
													PhotonClient.SendEvent(this.YUPyzZaOk7.ActorNr, 73, hashtable, false, false);
													if (172751 - 151574 == 21177)
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

	// Token: 0x060040B2 RID: 16562 RVA: 0x00836E74 File Offset: 0x00835074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (106740 - 69973 != 36767)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (159806 - 294247 == -134441)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (292645 - 307888 == -15243)
				{
					if (12498 - 132991 == -120493)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (245786 - 322121 == -76334)
							{
								continue;
							}
							v = 1;
							if (256536 - 555460 == -298923)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (27671 - 311863 != -284192)
							{
								continue;
							}
							v = -1;
							if (238288 - 122180 != 116108)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (11670 - 273349 == -261679)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (13203 - 395825 != -382621)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (119297 - 178184 == -58887)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (223740 - 419935 == -196195)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (121215 - 448807 == -327592)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (213328 - 412391 != -199062)
											{
												Hashtable hashtable = new Hashtable();
												if (8743 - 534240 == -525497)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (112745 - 471636 == -358891)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (28512 - 498800 == -470288)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (223415 - 7142 == 216273)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (193231 - 122779 != 70453)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (82043 - 456204 != -374160)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (150011 - 492632 == -342621)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (158331 - 42462 != 115870)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (143662 - 67739 != 75924)
																				{
																					PhotonClient.SendEvent(this.YUPyzZaOk7.ActorNr, 74, hashtable, true, true);
																					if (169291 - 191153 == -21862)
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

	// Token: 0x060040B3 RID: 16563 RVA: 0x008372C8 File Offset: 0x008354C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (44069 - 126959 != -82889)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (175515 - 246739 != -71223)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (184883 - 135195 != 49689)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (264890 - 214061 != 50830)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (149715 - 478893 != -329177)
						{
							int num3 = num;
							if (262286 - 409707 != -147420)
							{
								if (num3 == 1)
								{
									if (153844 - 503837 == -349993)
									{
										if (this.YUPyzZaOk7.isMine)
										{
											break;
										}
										if (29414 - 389050 != -359635)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (45909 - 570455 == -524546)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (144808 - 124886 == 19922)
									{
										if (this.YUPyzZaOk7.isMine)
										{
											break;
										}
										if (243482 - 136000 == 107482)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (284139 - 38500 != 245640)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (39309 - 252199 != -212889)
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

	// Token: 0x060040B4 RID: 16564 RVA: 0x0083755C File Offset: 0x0083575C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (122856 - 110362 != 12494)
		{
		}
		for (;;)
		{
			if (!this.YUPyzZaOk7.isMine)
			{
				if (189227 - 289597 != -100369)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (49245 - 150438 == -101193)
				{
					Vector3 vector = a - this.transform.position;
					if (53430 - 95537 != -42106)
					{
						Vector3 normalized = vector.normalized;
						if (5442 - 545615 != -540172)
						{
							if (!(this.YUPyzZaOk7.actionState == "standby"))
							{
								if (89316 - 257914 != -168598)
								{
									continue;
								}
								if (!(this.YUPyzZaOk7.actionState == "run"))
								{
									break;
								}
								if (57091 - 451625 != -394534)
								{
									continue;
								}
							}
							if (this.YUPyzZaOk7.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (103871 - 497986 == -394115)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
								if (28149 - 207144 == -178995)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (230151 - 577320 != -347168)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
										if (268402 - 27362 == 241040)
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

	// Token: 0x060040B5 RID: 16565 RVA: 0x00837760 File Offset: 0x00835960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060040B6 RID: 16566 RVA: 0x00837764 File Offset: 0x00835964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060040B7 RID: 16567 RVA: 0x00837768 File Offset: 0x00835968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Annonite.$RPC_nAttack$31092(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x00837778 File Offset: 0x00835978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (10569 - 432488 != -421918)
		{
		}
		for (;;)
		{
			IL_1C5:
			if (this.nAttack_hit)
			{
				if (57611 - 71728 == -14116)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (228098 - 431559 != -203461)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (210587 - 203192 == 7396)
				{
					continue;
				}
			}
			int num = 130816 - (1 << this.gameObject.layer);
			if (221254 - 350668 == -129414)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
				if (230116 - 50542 != 179575)
				{
					int i = 0;
					if (165848 - 386662 != -220813)
					{
						GameObject[] array2 = array;
						if (231795 - 285885 != -54089)
						{
							int length = array2.Length;
							if (37212 - 433590 != -396377)
							{
								while (i < length)
								{
									Vector3 vector = hitPos - array2[i].transform.position;
									if (209333 - 391618 == -182284)
									{
										goto IL_1C5;
									}
									if (vector.sqrMagnitude < (float)16)
									{
										if (239690 - 267300 != -27610)
										{
											goto IL_1C5;
										}
										AnnoniteMarch annoniteMarch = (AnnoniteMarch)array2[i].GetComponent(typeof(AnnoniteMarch));
										if (213233 - 116421 == 96813)
										{
											goto IL_1C5;
										}
										if (annoniteMarch)
										{
											if (299099 - 540311 == -241211)
											{
												goto IL_1C5;
											}
											if (annoniteMarch.mLife > 0)
											{
												if (249838 - 571019 != -321181)
												{
													goto IL_1C5;
												}
												if (annoniteMarch.mLife > 1)
												{
													if (200919 - 560517 == -359597)
													{
														goto IL_1C5;
													}
													annoniteMarch.OnHit();
													if (298235 - 486769 == -188533)
													{
														goto IL_1C5;
													}
												}
												else
												{
													annoniteMarch.OnDead();
													if (98744 - 223960 == -125215)
													{
														goto IL_1C5;
													}
													Camera.main.SendMessage("OnMarchDead", annoniteMarch.mID);
													if (142373 - 137619 == 4755)
													{
														goto IL_1C5;
													}
													eAnnoniteMarchType mAnnoniteMarchType = annoniteMarch.mAnnoniteMarchType;
													if (85149 - 450167 == -365017)
													{
														goto IL_1C5;
													}
													if (mAnnoniteMarchType == eAnnoniteMarchType.neonBug)
													{
														if (91733 - 184308 == -92574)
														{
															goto IL_1C5;
														}
														Camera.main.SendMessage("OnMarchScore", 1);
														if (55591 - 213687 == -158095)
														{
															goto IL_1C5;
														}
													}
													else if (mAnnoniteMarchType == eAnnoniteMarchType.waterBug)
													{
														if (261785 - 266286 == -4500)
														{
															goto IL_1C5;
														}
														Camera.main.SendMessage("OnMarchScore", 3);
														if (157378 - 167763 == -10384)
														{
															goto IL_1C5;
														}
													}
													else if (mAnnoniteMarchType == eAnnoniteMarchType.coralBug)
													{
														if (155886 - 217261 != -61375)
														{
															goto IL_1C5;
														}
														Camera.main.SendMessage("OnMarchScore", 7);
														if (253769 - 270467 != -16698)
														{
															goto IL_1C5;
														}
													}
												}
											}
										}
									}
									i++;
									if (92004 - 566448 != -474444)
									{
										goto IL_1C5;
									}
								}
								if (1437 - 208437 == -207000)
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

	// Token: 0x060040B9 RID: 16569 RVA: 0x00837BC4 File Offset: 0x00835DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Annonite.$RPC_ko$31101(nArray, this).GetEnumerator();
	}

	// Token: 0x060040BA RID: 16570 RVA: 0x00837BD4 File Offset: 0x00835DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Annonite.$RPC_dead$31108(nArray, this).GetEnumerator();
	}

	// Token: 0x060040BB RID: 16571 RVA: 0x00837BE4 File Offset: 0x00835DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x00837BE8 File Offset: 0x00835DE8
	internal static bool CxGMKK5MRvRj8PHyPrlO()
	{
		return true;
	}

	// Token: 0x060040BD RID: 16573 RVA: 0x00837BEC File Offset: 0x00835DEC
	internal static bool P2PjG05MwdMxuJ6hj1y6()
	{
		return false;
	}

	// Token: 0x04004CF1 RID: 19697
	private CharacterControl YUPyzZaOk7;

	// Token: 0x04004CF2 RID: 19698
	private CharacterController FmmV58m6Wm;

	// Token: 0x04004CF3 RID: 19699
	public AudioClip swim_fx;

	// Token: 0x04004CF4 RID: 19700
	private Vector3 DjKVc0lbTZ;

	// Token: 0x04004CF5 RID: 19701
	private Vector3 LerVnkBM9o;

	// Token: 0x04004CF6 RID: 19702
	private float iykVQLuq94;

	// Token: 0x04004CF7 RID: 19703
	public GameObject swimBoost;

	// Token: 0x04004CF8 RID: 19704
	private float KmkVetVv8T;

	// Token: 0x04004CF9 RID: 19705
	public GameObject nAttack_fire;

	// Token: 0x04004CFA RID: 19706
	public GameObject nAttack_hit;

	// Token: 0x02000B5A RID: 2906
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31092 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060040BE RID: 16574 RVA: 0x00837BF0 File Offset: 0x00835DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31092(Vector3 mPos, Vector3 tDir, Annonite self_)
		{
			if (32942 - 133395 != -100453)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261376 - 77783 != 183594)
				{
					base..ctor();
					if (39416 - 400837 != -361420)
					{
						this.$mPos$31098 = mPos;
						if (295982 - 469768 != -173785)
						{
							this.$tDir$31099 = tDir;
							if (281239 - 304137 != -22897)
							{
								this.$self_$31100 = self_;
								if (117592 - 238259 != -120666)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00837CCC File Offset: 0x00835ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Annonite.$RPC_nAttack$31092.$(this.$mPos$31098, this.$tDir$31099, this.$self_$31100);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00837CE8 File Offset: 0x00835EE8
		internal static bool JDPt3k5MqpdnU001PlqV()
		{
			return true;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00837CEC File Offset: 0x00835EEC
		internal static bool xs9DOr5M76OCHrrckC5I()
		{
			return false;
		}

		// Token: 0x04004CFB RID: 19707
		internal Vector3 $mPos$31098;

		// Token: 0x04004CFC RID: 19708
		internal Vector3 $tDir$31099;

		// Token: 0x04004CFD RID: 19709
		internal Annonite $self_$31100;

		// Token: 0x02000B5B RID: 2907
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060040C2 RID: 16578 RVA: 0x00837CF0 File Offset: 0x00835EF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Annonite self_)
			{
				if (260234 - 215032 != 45202)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16280 - 214974 != -198693)
					{
						base..ctor();
						if (265190 - 474795 == -209605)
						{
							this.$mPos$31095 = mPos;
							if (46839 - 364730 != -317890)
							{
								this.$tDir$31096 = tDir;
								if (183467 - 290203 == -106736)
								{
									this.$self_$31097 = self_;
									if (117306 - 301010 != -183703)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060040C3 RID: 16579 RVA: 0x00837DCC File Offset: 0x00835FCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (186780 - 375924 != -189144)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A4;
					case 2:
						if (this.$self_$31097.YUPyzZaOk7.actionState != "attack")
						{
							goto IL_164;
						}
						if (227042 - 246237 != -19195)
						{
							continue;
						}
						if (this.$self_$31097.YUPyzZaOk7.myCommand != "nAttack")
						{
							if (152933 - 413216 != -260282)
							{
								goto Block_5;
							}
							continue;
						}
						else if (this.$self_$31097.nAttack_fire)
						{
							if (178959 - 67180 != 111779)
							{
								continue;
							}
							this.$mFire$31093 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$31097.nAttack_fire, this.$mPos$31095 + this.$tDir$31096, Quaternion.LookRotation(this.$tDir$31096));
							if (279738 - 461063 != -181325)
							{
								continue;
							}
							this.$mProjectileControl$31094 = (ProjectileControl)this.$mFire$31093.GetComponent(typeof(ProjectileControl));
							if (281220 - 412211 != -130991)
							{
								continue;
							}
							this.$mProjectileControl$31094.Init(this.$self_$31097.YUPyzZaOk7.ActorNr);
							if (147213 - 220846 != -73633)
							{
								continue;
							}
							this.$mProjectileControl$31094.life = (float)6;
							if (243827 - 205733 != 38094)
							{
								continue;
							}
							goto IL_492;
						}
						else
						{
							Debug.LogError("Cannot find nAttack_fire Effect");
							if (35922 - 171452 != -135530)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$31097.YUPyzZaOk7.actionState == "attack")
						{
							if (221674 - 359589 == -137914)
							{
								continue;
							}
							if (this.$self_$31097.YUPyzZaOk7.myCommand == "nAttack")
							{
								if (108673 - 402591 != -293918)
								{
									continue;
								}
								this.$self_$31097.YUPyzZaOk7.actionState = "standby";
								if (141792 - 588542 == -446749)
								{
									continue;
								}
								this.$self_$31097.YUPyzZaOk7.actionTime = Time.time;
								if (70017 - 439485 == -369467)
								{
									continue;
								}
								this.$self_$31097.YUPyzZaOk7.myCommand = "none";
								if (46936 - 547586 != -500650)
								{
									continue;
								}
								if (!this.$self_$31097.YUPyzZaOk7.isMine)
								{
									if (260735 - 366187 == -105451)
									{
										continue;
									}
									this.$self_$31097.YUPyzZaOk7.nPosition = this.$self_$31097.transform.position;
									if (83685 - 252568 == -168882)
									{
										continue;
									}
									this.$self_$31097.YUPyzZaOk7.oPosition = this.$self_$31097.transform.position;
									if (44464 - 94575 == -50110)
									{
										continue;
									}
									this.$self_$31097.YUPyzZaOk7.nDirection = this.$self_$31097.transform.forward;
									if (105107 - 576754 == -471646)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (145805 - 406504 != -260698)
						{
							goto Block_30;
						}
						continue;
					default:
						if (142781 - 565276 != -422495)
						{
							continue;
						}
						break;
					}
					this.$self_$31097.YUPyzZaOk7.actionState = "attack";
					if (256136 - 64934 != 191203)
					{
						this.$self_$31097.YUPyzZaOk7.actionTime = Time.time;
						if (284876 - 389884 == -105008)
						{
							this.$self_$31097.YUPyzZaOk7.myCommand = "nAttack";
							if (158397 - 426992 != -268594)
							{
								this.$self_$31097.YUPyzZaOk7.addTimeOut("nAttack", 0.3f);
								if (106364 - 337039 == -230675)
								{
									this.$self_$31097.transform.position = this.$mPos$31095;
									if (177538 - 490197 != -312658)
									{
										this.$self_$31097.animation.Rewind();
										if (247325 - 440129 != -192803)
										{
											this.$self_$31097.animation.CrossFade("nAttack");
											if (51883 - 355126 != -303242)
											{
												this.$self_$31097.animation.wrapMode = WrapMode.Once;
												if (144993 - 242097 != -97103)
												{
													goto Block_13;
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
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_5:
				IL_164:
				goto IL_5A4;
				Block_13:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_492:
				goto IL_1A;
				Block_30:
				IL_5A4:
				return false;
			}

			// Token: 0x060040C4 RID: 16580 RVA: 0x00838390 File Offset: 0x00836590
			internal static bool xPekoR5MPrOVKtPbS3Og()
			{
				return true;
			}

			// Token: 0x060040C5 RID: 16581 RVA: 0x00838394 File Offset: 0x00836594
			internal static bool Qr33NS5M0k6voSkdgYU8()
			{
				return false;
			}

			// Token: 0x04004CFE RID: 19710
			internal GameObject $mFire$31093;

			// Token: 0x04004CFF RID: 19711
			internal ProjectileControl $mProjectileControl$31094;

			// Token: 0x04004D00 RID: 19712
			internal Vector3 $mPos$31095;

			// Token: 0x04004D01 RID: 19713
			internal Vector3 $tDir$31096;

			// Token: 0x04004D02 RID: 19714
			internal Annonite $self_$31097;
		}
	}

	// Token: 0x02000B5C RID: 2908
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31101 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060040C6 RID: 16582 RVA: 0x00838398 File Offset: 0x00836598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31101(UnityScript.Lang.Array nArray, Annonite self_)
		{
			if (223546 - 102142 != 121405)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (158068 - 99179 == 58889)
				{
					base..ctor();
					if (185539 - 29442 == 156097)
					{
						this.$nArray$31106 = nArray;
						if (57162 - 114999 == -57837)
						{
							this.$self_$31107 = self_;
							if (19755 - 62011 != -42255)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00838454 File Offset: 0x00836654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Annonite.$RPC_ko$31101.$(this.$nArray$31106, this.$self_$31107);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00838468 File Offset: 0x00836668
		internal static bool YiAEJR5MbIP7VOWJI3q6()
		{
			return true;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0083846C File Offset: 0x0083666C
		internal static bool wD67Pl5Mu4AFuErt9Kgc()
		{
			return false;
		}

		// Token: 0x04004D03 RID: 19715
		internal UnityScript.Lang.Array $nArray$31106;

		// Token: 0x04004D04 RID: 19716
		internal Annonite $self_$31107;

		// Token: 0x02000B5D RID: 2909
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060040CA RID: 16586 RVA: 0x00838470 File Offset: 0x00836670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Annonite self_)
			{
				if (76393 - 350919 != -274526)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (255786 - 74141 != 181646)
					{
						base..ctor();
						if (118929 - 349969 != -231039)
						{
							this.$nArray$31104 = nArray;
							if (239841 - 181203 == 58638)
							{
								this.$self_$31105 = self_;
								if (65133 - 402866 != -337732)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060040CB RID: 16587 RVA: 0x0083852C File Offset: 0x0083672C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48112 - 251184 != -203072)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$31105.YUPyzZaOk7.actionState != "ko")
						{
							if (212240 - 534249 != -322009)
							{
								continue;
							}
							goto IL_201;
						}
						else
						{
							this.$self_$31105.animation.Play("getUp");
							if (299462 - 411594 != -112132)
							{
								continue;
							}
							this.$self_$31105.animation.wrapMode = WrapMode.Once;
							if (292910 - 193734 != 99176)
							{
								continue;
							}
							goto IL_FB;
						}
						break;
					case 3:
						if (this.$self_$31105.YUPyzZaOk7.actionState != "ko")
						{
							if (202707 - 483809 != -281101)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$31105.YUPyzZaOk7.actionState = "standby";
							if (110273 - 82405 != 27868)
							{
								continue;
							}
							this.$self_$31105.YUPyzZaOk7.actionTime = Time.time;
							if (199342 - 133057 != 66285)
							{
								continue;
							}
							this.$self_$31105.YUPyzZaOk7.myCommand = "none";
							if (108693 - 111472 == -2778)
							{
								continue;
							}
							this.$self_$31105.YUPyzZaOk7.ko = this.$self_$31105.YUPyzZaOk7.mko;
							if (153741 - 513005 == -359263)
							{
								continue;
							}
							this.YieldDefault(1);
							if (211623 - 445253 != -233630)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (22614 - 172138 != -149524)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31105.YUPyzZaOk7.actionState == "ko")
					{
						goto IL_265;
					}
					if (246341 - 380810 != -134468)
					{
						if (this.$self_$31105.YUPyzZaOk7.actionState == "dead")
						{
							if (57735 - 193270 != -135534)
							{
								goto Block_25;
							}
						}
						else
						{
							this.$mPos$31102 = (Vector3)this.$nArray$31104[0];
							if (260036 - 483978 != -223941)
							{
								this.$mDir$31103 = (Vector3)this.$nArray$31104[1];
								if (170989 - 232940 != -61950)
								{
									this.$self_$31105.YUPyzZaOk7.ko = 0;
									if (210778 - 252839 != -42060)
									{
										this.$self_$31105.YUPyzZaOk7.actionState = "ko";
										if (126952 - 125899 != 1054)
										{
											this.$self_$31105.YUPyzZaOk7.actionTime = Time.time;
											if (260116 - 56933 != 203184)
											{
												this.$self_$31105.YUPyzZaOk7.myCommand = "none";
												if (164585 - 552539 == -387954)
												{
													this.$self_$31105.YUPyzZaOk7.vMovement = Vector3.zero;
													if (124955 - 279805 == -154850)
													{
														this.$self_$31105.YUPyzZaOk7.moveSpeed = (float)0;
														if (218761 - 508887 == -290126)
														{
															this.$self_$31105.animation.Play("ko");
															if (10901 - 514857 == -503956)
															{
																this.$self_$31105.animation.wrapMode = WrapMode.Once;
																if (117362 - 354 != 117009)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_FB:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				IL_201:
				IL_265:
				Block_25:
				IL_48C:
				return false;
			}

			// Token: 0x060040CC RID: 16588 RVA: 0x008389D8 File Offset: 0x00836BD8
			internal static bool NFQi4o5MIQGDgWWY1Hk3()
			{
				return true;
			}

			// Token: 0x060040CD RID: 16589 RVA: 0x008389DC File Offset: 0x00836BDC
			internal static bool MVts975MBEo2T0i8Sy4I()
			{
				return false;
			}

			// Token: 0x04004D05 RID: 19717
			internal Vector3 $mPos$31102;

			// Token: 0x04004D06 RID: 19718
			internal Vector3 $mDir$31103;

			// Token: 0x04004D07 RID: 19719
			internal UnityScript.Lang.Array $nArray$31104;

			// Token: 0x04004D08 RID: 19720
			internal Annonite $self_$31105;
		}
	}

	// Token: 0x02000B5E RID: 2910
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31108 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060040CE RID: 16590 RVA: 0x008389E0 File Offset: 0x00836BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31108(UnityScript.Lang.Array nArray, Annonite self_)
		{
			if (6648 - 586342 != -579693)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187986 - 466454 != -278467)
				{
					base..ctor();
					if (7092 - 579101 != -572008)
					{
						this.$nArray$31113 = nArray;
						if (129070 - 9308 != 119763)
						{
							this.$self_$31114 = self_;
							if (236708 - 435483 != -198774)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x00838A9C File Offset: 0x00836C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Annonite.$RPC_dead$31108.$(this.$nArray$31113, this.$self_$31114);
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00838AB0 File Offset: 0x00836CB0
		internal static bool io1Yed5MebQxPRkdAa2u()
		{
			return true;
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00838AB4 File Offset: 0x00836CB4
		internal static bool ya81QH5MrVqXgUg3Jlhm()
		{
			return false;
		}

		// Token: 0x04004D09 RID: 19721
		internal UnityScript.Lang.Array $nArray$31113;

		// Token: 0x04004D0A RID: 19722
		internal Annonite $self_$31114;

		// Token: 0x02000B5F RID: 2911
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060040D2 RID: 16594 RVA: 0x00838AB8 File Offset: 0x00836CB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Annonite self_)
			{
				if (232321 - 69024 != 163297)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134684 - 186816 == -52132)
					{
						base..ctor();
						if (146843 - 296367 == -149524)
						{
							this.$nArray$31111 = nArray;
							if (28074 - 72487 == -44413)
							{
								this.$self_$31112 = self_;
								if (46939 - 359562 == -312623)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060040D3 RID: 16595 RVA: 0x00838B74 File Offset: 0x00836D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52250 - 421427 != -369177)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_458;
					case 2:
						if (this.$self_$31112.YUPyzZaOk7.actionState != "dead")
						{
							if (185624 - 582389 != -396764)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31112.YUPyzZaOk7.isPlayer)
							{
								if (287980 - 215392 == 72589)
								{
									continue;
								}
								if (Game.mGameCode != 406)
								{
									if (223180 - 433367 == -210186)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$31112.gameObject);
									if (48188 - 7304 != 40884)
									{
										continue;
									}
								}
							}
							else if (this.$self_$31112.YUPyzZaOk7.isMine)
							{
								if (188946 - 296707 != -107761)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31112.gameObject);
								if (90125 - 117624 != -27499)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (184163 - 338496 != -154333)
							{
								continue;
							}
							goto IL_458;
						}
						break;
					default:
						if (144801 - 538720 != -393919)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31112.YUPyzZaOk7.actionState == "dead")
					{
						if (261044 - 92789 != 168256)
						{
							goto Block_13;
						}
					}
					else
					{
						this.$mPos$31109 = (Vector3)this.$nArray$31111[0];
						if (28017 - 508456 != -480438)
						{
							this.$myDirection$31110 = (Vector3)this.$nArray$31111[1];
							if (184617 - 473341 != -288723)
							{
								this.$self_$31112.transform.position = this.$mPos$31109;
								if (164370 - 154523 == 9847)
								{
									this.$self_$31112.transform.LookAt(this.$mPos$31109 + this.$myDirection$31110);
									if (215253 - 83763 != 131491)
									{
										this.$self_$31112.YUPyzZaOk7.hp = 0;
										if (156617 - 161339 != -4721)
										{
											this.$self_$31112.YUPyzZaOk7.actionState = "dead";
											if (229180 - 250330 == -21150)
											{
												this.$self_$31112.YUPyzZaOk7.actionTime = Time.time;
												if (287556 - 445489 == -157933)
												{
													this.$self_$31112.YUPyzZaOk7.myCommand = "none";
													if (241014 - 126157 == 114857)
													{
														this.$self_$31112.YUPyzZaOk7.vMovement = Vector3.zero;
														if (208308 - 98434 != 109875)
														{
															this.$self_$31112.YUPyzZaOk7.moveSpeed = (float)0;
															if (127727 - 488632 == -360905)
															{
																this.$self_$31112.animation.Rewind();
																if (234684 - 204776 != 29909)
																{
																	this.$self_$31112.animation.Play("ko");
																	if (27346 - 457686 != -430339)
																	{
																		this.$self_$31112.animation.wrapMode = WrapMode.Once;
																		if (75608 - 582427 != -506818)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_13:
				Block_25:
				IL_458:
				return false;
			}

			// Token: 0x060040D4 RID: 16596 RVA: 0x00838FEC File Offset: 0x008371EC
			internal static bool Ioc5875MjbNLXMamSjxt()
			{
				return true;
			}

			// Token: 0x060040D5 RID: 16597 RVA: 0x00838FF0 File Offset: 0x008371F0
			internal static bool ttIrKc5MhBoylJUUHRTb()
			{
				return false;
			}

			// Token: 0x04004D0B RID: 19723
			internal Vector3 $mPos$31109;

			// Token: 0x04004D0C RID: 19724
			internal Vector3 $myDirection$31110;

			// Token: 0x04004D0D RID: 19725
			internal UnityScript.Lang.Array $nArray$31111;

			// Token: 0x04004D0E RID: 19726
			internal Annonite $self_$31112;
		}
	}
}
