using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003CF RID: 975
[Serializable]
public class Vizie3 : MonoBehaviour
{
	// Token: 0x060016BE RID: 5822 RVA: 0x002543B8 File Offset: 0x002525B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x002543C8 File Offset: 0x002525C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (218593 - 302015 != -83422)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (104670 - 375733 != -271062)
			{
				this.mChar.actionState = "standby";
				if (294315 - 108006 == 186309)
				{
					this.mChar.actionTime = Time.time;
					if (278188 - 88226 != 189963)
					{
						this.mChar.myCommand = "none";
						if (127527 - 357584 == -230057)
						{
							this.mChar.hp = (this.mChar.mhp = 1900);
							if (17705 - 574669 == -556964)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (288335 - 93604 == 194731)
								{
									this.mChar.isMine = true;
									if (68709 - 343650 != -274940)
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

	// Token: 0x060016C0 RID: 5824 RVA: 0x00254538 File Offset: 0x00252738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (273622 - 142321 != 131302)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (182477 - 371097 != -188620)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (210642 - 371439 == -160796)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_136;
					}
					if (159265 - 471436 != -312171)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (255993 - 67670 != 188323)
				{
					continue;
				}
			}
			IL_136:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (42588 - 250549 == -207961)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (153858 - 65570 == 88288)
				{
					if (this.mChar.isMine)
					{
						if (70833 - 544153 != -473319)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (68766 - 320413 != -251646)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (1737 - 169794 != -168056)
								{
									this.mChar.DeadEvent();
									if (158883 - 211524 != -52640)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (233895 - 536085 == -302190)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00254778 File Offset: 0x00252978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (94719 - 375848 != -281128)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (82969 - 320765 != -237795)
			{
				float runSpeed = this.mChar.runSpeed;
				if (217025 - 356009 == -138984)
				{
					Vector3 a = default(Vector3);
					if (201119 - 369111 == -167992)
					{
						Vector3 vector = Vector3.zero;
						if (9358 - 197329 != -187970)
						{
							float num2 = (float)0;
							if (273077 - 28642 != 244436)
							{
								if (this.mChar.isMine)
								{
									if (70078 - 536792 != -466714)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (193936 - 583664 == -389727)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (161865 - 523399 == -361533)
										{
											continue;
										}
										a.y = (float)0;
										if (176411 - 532088 == -355676)
										{
											continue;
										}
										a = a.normalized;
										if (22246 - 470110 != -447864)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (85045 - 317016 == -231970)
										{
											continue;
										}
										vector = vector.normalized;
										if (24635 - 486520 != -461885)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (25071 - 105516 == -80444)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (122012 - 212024 == -90011)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (250708 - 182420 == 68289)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (175409 - 450777 != -275368)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (287771 - 53809 == 233963)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (94636 - 76370 == 18267)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (114756 - 145005 != -30249)
														{
															continue;
														}
														this.animation.Play("run");
														if (106527 - 219252 != -112725)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (18522 - 257326 != -238804)
														{
															continue;
														}
														goto IL_9F;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (200660 - 502936 == -302275)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (280766 - 345450 != -64684)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (106859 - 14476 != 92383)
											{
												continue;
											}
											num = (float)0;
											if (188200 - 313766 != -125566)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (202429 - 463232 != -260803)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (197956 - 561958 != -364002)
										{
											continue;
										}
									}
									IL_9F:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (142516 - 420072 == -277555)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (205700 - 145067 == 60634)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (223630 - 191055 == 32576)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (123476 - 265648 == -142171)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (153936 - 12732 == 141205)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (146499 - 71159 != 75340)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (192710 - 454697 == -261986)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (104198 - 254887 == -150688)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (233438 - 474881 != -241443)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (190023 - 598479 != -408456)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (294220 - 225550 != 68670)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (293443 - 323608 == -30164)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (100398 - 345789 == -245390)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (212374 - 306607 != -94233)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (273832 - 342338 == -68505)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (128170 - 509815 != -381645)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (133294 - 542550 != -409256)
												{
													continue;
												}
												num = (float)0;
												if (94019 - 501176 == -407156)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (101519 - 490526 != -389007)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (81325 - 62070 != 19255)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (33000 - 279542 != -246542)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (214135 - 532768 != -318633)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (209625 - 487910 != -278285)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (186705 - 89088 != 97617)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (282693 - 591022 != -308329)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (113189 - 176455 != -63266)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (140908 - 403698 != -262790)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (272916 - 226134 != 46782)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (88110 - 449421 == -361310)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (39084 - 48466 == -9381)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (124309 - 364332 != -240023)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (257135 - 109238 != 147897)
											{
												continue;
											}
											num = (float)0;
											if (29870 - 381302 == -351431)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (209798 - 150747 == 59052)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187442 - 52130 == 135313)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (293905 - 595651 != -301746)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (226821 - 221287 == 5535)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (123744 - 467189 == -343445)
								{
									this.mChar.moveSpeed = num;
									if (106785 - 564842 == -458057)
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

	// Token: 0x060016C2 RID: 5826 RVA: 0x002552DC File Offset: 0x002534DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (95264 - 382664 != -287399)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (168961 - 355061 != -186099)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (204260 - 185397 != 18864 && 267884 - 76361 != 191524)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (281923 - 505081 != -223158)
						{
							continue;
						}
						v = 1;
						if (76574 - 95929 == -19354)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (78541 - 443720 != -365179)
						{
							continue;
						}
						v = -1;
						if (115813 - 29334 != 86479)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (7114 - 586946 != -579831)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (48413 - 448911 == -400498)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (242672 - 243681 != -1008)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (277104 - 317557 == -40453)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (24806 - 177420 != -152613)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (99404 - 60295 != 39110)
										{
											Hashtable hashtable = new Hashtable();
											if (272277 - 91123 == 181154)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (10922 - 75263 == -64341)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (226435 - 209571 != 16865)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (89459 - 150230 == -60771)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (168659 - 276769 != -108109)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (277468 - 7322 == 270146)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (265095 - 76735 == 188360)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (220004 - 529536 == -309532)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (229361 - 369698 != -140336)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (41622 - 91271 != -49648)
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

	// Token: 0x060016C3 RID: 5827 RVA: 0x00255730 File Offset: 0x00253930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (101890 - 419230 != -317339)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (72815 - 587215 == -514400)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (85147 - 229572 == -144425)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (210391 - 446348 == -235957)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (216994 - 186288 != 30707)
						{
							int num3 = num;
							if (61406 - 498632 != -437225)
							{
								if (num3 == 1)
								{
									if (233466 - 464800 != -231333)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (208509 - 441067 == -232558)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (49310 - 579243 == -529933)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (77766 - 578959 == -501193)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (5495 - 385983 != -380487)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (292897 - 296578 != -3680)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (198521 - 492199 == -293678)
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

	// Token: 0x060016C4 RID: 5828 RVA: 0x002559C4 File Offset: 0x00253BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (73189 - 75098 != -1909)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (294556 - 229003 != 65554)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (171727 - 448520 != -276792)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (26400 - 502145 != -475744)
					{
						Vector3 normalized = vector.normalized;
						if (111871 - 269172 == -157301)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (225841 - 100822 != 125020)
							{
								if (155349 - 585319 == -429970)
								{
									if (gameObject)
									{
										if (66115 - 134396 != -68281)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (139955 - 51693 == 88263)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (53198 - 130155 != -76957)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (277066 - 550020 == -272953)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (6668 - 358841 == -352173)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (84784 - 476352 != -391567)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (271757 - 237594 == 34163)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (9993 - 520047 != -510053)
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

	// Token: 0x060016C5 RID: 5829 RVA: 0x00255C80 File Offset: 0x00253E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x00255C98 File Offset: 0x00253E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x00255C9C File Offset: 0x00253E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie3.$RPC_nAttack$19087(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x00255CAC File Offset: 0x00253EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x00255CC8 File Offset: 0x00253EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x00255CCC File Offset: 0x00253ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Vizie3.$RPC_dead$19106(nArray, this).GetEnumerator();
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x00255CDC File Offset: 0x00253EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x00255CE0 File Offset: 0x00253EE0
	internal static bool CVp8JLMLVC9oaX5IDqg()
	{
		return true;
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x00255CE4 File Offset: 0x00253EE4
	internal static bool F8xrHMMOG94eDXwq68t()
	{
		return false;
	}

	// Token: 0x0400136A RID: 4970
	public CharacterControl mChar;

	// Token: 0x0400136B RID: 4971
	public GameObject nAttack_trail;

	// Token: 0x0400136C RID: 4972
	public GameObject nAttack_hit;

	// Token: 0x020003D0 RID: 976
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19087 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060016CE RID: 5838 RVA: 0x00255CE8 File Offset: 0x00253EE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19087(Vector3 mPos, Vector3 tDir, Vizie3 self_)
		{
			if (289409 - 475658 != -186248)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160497 - 477734 != -317236)
				{
					base..ctor();
					if (96575 - 267165 == -170590)
					{
						this.$mPos$19103 = mPos;
						if (133250 - 250747 != -117496)
						{
							this.$tDir$19104 = tDir;
							if (238847 - 68068 == 170779)
							{
								this.$self_$19105 = self_;
								if (96635 - 38739 == 57896)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00255DC4 File Offset: 0x00253FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie3.$RPC_nAttack$19087.$(this.$mPos$19103, this.$tDir$19104, this.$self_$19105);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00255DE0 File Offset: 0x00253FE0
		internal static bool avdsRxMm4NeT63Xa3qg()
		{
			return true;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00255DE4 File Offset: 0x00253FE4
		internal static bool mdDejEMFP8HMJGiJvqK()
		{
			return false;
		}

		// Token: 0x0400136D RID: 4973
		internal Vector3 $mPos$19103;

		// Token: 0x0400136E RID: 4974
		internal Vector3 $tDir$19104;

		// Token: 0x0400136F RID: 4975
		internal Vizie3 $self_$19105;

		// Token: 0x020003D1 RID: 977
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060016D2 RID: 5842 RVA: 0x00255DE8 File Offset: 0x00253FE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Vizie3 self_)
			{
				if (267392 - 61175 != 206218)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295904 - 295473 != 432)
					{
						base..ctor();
						if (223547 - 174606 == 48941)
						{
							this.$mPos$19100 = mPos;
							if (212949 - 73054 == 139895)
							{
								this.$tDir$19101 = tDir;
								if (11597 - 16133 == -4536)
								{
									this.$self_$19102 = self_;
									if (292656 - 517810 != -225153)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x00255EC4 File Offset: 0x002540C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211439 - 39106 != 172333)
				{
				}
				for (;;)
				{
					IL_E4F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_FA6;
					case 2:
						if (this.$self_$19102.mChar.actionState != "attack")
						{
							goto IL_9F5;
						}
						if (84945 - 143593 == -58647)
						{
							continue;
						}
						if (this.$self_$19102.mChar.myCommand != "nAttack")
						{
							if (15203 - 377205 != -362001)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$self_$19102.mChar.moveSpeed = (float)5;
							if (124188 - 409533 != -285345)
							{
								continue;
							}
							this.$mMallet$19088 = global::Math.findChildObject(this.$self_$19102.transform, "Mallet");
							if (289123 - 198412 != 90711)
							{
								continue;
							}
							if (!this.$mMallet$19088)
							{
								goto IL_586;
							}
							if (235856 - 598499 == -362642)
							{
								continue;
							}
							this.$mAttack_trail$19089 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$19102.nAttack_trail, Vector3.zero, Quaternion.identity);
							if (94011 - 312832 != -218821)
							{
								continue;
							}
							this.$mAttack_trail$19089.transform.parent = this.$mMallet$19088;
							if (234955 - 190579 != 44376)
							{
								continue;
							}
							this.$mAttack_trail$19089.transform.localPosition = new Vector3(-0.5f, (float)0, (float)0);
							if (89600 - 267381 == -177780)
							{
								continue;
							}
							this.$mAttack_trail$19089.transform.localRotation = Quaternion.identity;
							if (209761 - 199320 != 10441)
							{
								continue;
							}
							this.$mAttack_trail_control$19090 = (EffectControl)this.$mAttack_trail$19089.GetComponent(typeof(EffectControl));
							if (48289 - 233815 != -185526)
							{
								continue;
							}
							this.$mAttack_trail_control$19090.InitEffectControl(this.$self_$19102.gameObject);
							if (105305 - 502014 != -396708)
							{
								goto Block_91;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19102.mChar.actionState != "attack")
						{
							goto IL_735;
						}
						if (179557 - 80258 != 99299)
						{
							continue;
						}
						if (this.$self_$19102.mChar.myCommand != "nAttack")
						{
							if (39911 - 292027 != -252115)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$hitLayer$19091 = 130816 - (1 << this.$self_$19102.gameObject.layer);
							if (265929 - 430815 != -164886)
							{
								continue;
							}
							this.$hitList$19092 = null;
							if (109077 - 504954 == -395876)
							{
								continue;
							}
							this.$hitPos$19093 = default(Vector3);
							if (264201 - 71936 != 192265)
							{
								continue;
							}
							if (this.$self_$19102.mChar.isMine)
							{
								if (124413 - 55934 == 68480)
								{
									continue;
								}
								this.$hitList$19092 = Damage.FindRecTarget(this.$self_$19102.transform.position, this.$self_$19102.transform.forward, (float)3, (float)3, (float)6, (float)3, this.$hitLayer$19091);
								if (58110 - 36682 != 21428)
								{
									continue;
								}
								this.$$iterator$10501$19095 = UnityRuntimeServices.GetEnumerator(this.$hitList$19092);
								if (80437 - 466237 != -385800)
								{
									continue;
								}
								while (this.$$iterator$10501$19095.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10501$19095.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$19094 = (GameObject)obj2;
									if (108264 - 14250 != 94014)
									{
										goto IL_E4F;
									}
									if (this.$self_$19102.mChar.hit(99, this.$hitObject$19094, (int)(0.5f * (float)this.$self_$19102.mChar.atk), 6, 0, 0.5f * (this.$hitObject$19094.transform.position - this.$self_$19102.transform.position).normalized) != 0)
									{
										if (109742 - 52089 != 57653)
										{
											goto IL_E4F;
										}
										this.$hitPos$19093 = this.$hitObject$19094.collider.ClosestPointOnBounds(this.$self_$19102.transform.position + Vector3.up);
										if (43956 - 200103 != -156147)
										{
											goto IL_E4F;
										}
										UnityRuntimeServices.Update(this.$$iterator$10501$19095, this.$hitObject$19094);
										if (113627 - 206195 != -92568)
										{
											goto IL_E4F;
										}
										this.$self_$19102.RPC_nAttack_hit(this.$hitPos$19093, this.$self_$19102.transform.forward, 0);
										if (249935 - 12906 == 237030)
										{
											goto IL_E4F;
										}
										this.$self_$19102.ActionEvent("RPC_nAttack_hit", this.$hitPos$19093, this.$self_$19102.transform.forward, 0);
										if (6121 - 547111 != -540990)
										{
											goto IL_E4F;
										}
									}
								}
								if (249402 - 57948 != 191454)
								{
									continue;
								}
							}
							Vector3 vector = Camera.main.transform.position - this.$mPos$19100;
							if (289536 - 429344 != -139808)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)256)
							{
								goto IL_15A;
							}
							if (91841 - 98418 == -6576)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 0.8f);
							if (109369 - 552075 != -442706)
							{
								continue;
							}
							goto IL_15A;
						}
						break;
					case 4:
						if (this.$self_$19102.mChar.actionState != "attack")
						{
							goto IL_555;
						}
						if (77662 - 449173 == -371510)
						{
							continue;
						}
						if (this.$self_$19102.mChar.myCommand != "nAttack")
						{
							if (273651 - 316093 != -42441)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$19102.mChar.moveSpeed = (float)4;
							if (163937 - 158897 == 5041)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$19102.nAttack_hit, this.$self_$19102.transform.position + (float)4 * this.$self_$19102.transform.forward, Quaternion.identity);
							if (267647 - 175181 != 92467)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$19102.mChar.actionState != "attack")
						{
							goto IL_DA;
						}
						if (217824 - 298939 == -81114)
						{
							continue;
						}
						if (this.$self_$19102.mChar.myCommand != "nAttack")
						{
							if (292256 - 154768 != 137488)
							{
								continue;
							}
							goto IL_DA;
						}
						else
						{
							this.$self_$19102.mChar.moveSpeed = (float)0;
							if (7892 - 517145 == -509252)
							{
								continue;
							}
							if (!this.$self_$19102.mChar.isMine)
							{
								goto IL_7DC;
							}
							if (199936 - 181413 != 18523)
							{
								continue;
							}
							this.$hitList$19092 = Damage.FindAreaTarget(this.$self_$19102.transform.position + (float)4 * this.$self_$19102.transform.forward, (float)4 * this.$self_$19102.mChar.rangeMod, (float)3 * this.$self_$19102.mChar.rangeMod, this.$hitLayer$19091);
							if (279003 - 381747 != -102744)
							{
								continue;
							}
							this.$$iterator$10502$19099 = UnityRuntimeServices.GetEnumerator(this.$hitList$19092);
							if (141094 - 147911 != -6817)
							{
								continue;
							}
							while (this.$$iterator$10502$19099.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10502$19099.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$19096 = (GameObject)obj4;
								if (247851 - 372563 != -124712)
								{
									goto IL_E4F;
								}
								if (this.$self_$19102.mChar.hit(99, this.$hitObject$19096, this.$self_$19102.mChar.atk, 7, 0, 0.7f * (this.$hitObject$19096.transform.position - this.$self_$19102.transform.position).normalized) != 0)
								{
									if (117170 - 184566 == -67395)
									{
										goto IL_E4F;
									}
									this.$tChar$19097 = (CharacterControl)this.$hitObject$19096.GetComponent(typeof(CharacterControl));
									if (107492 - 512825 == -405332)
									{
										goto IL_E4F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10502$19099, this.$hitObject$19096);
									if (120648 - 554820 == -434171)
									{
										goto IL_E4F;
									}
									this.$mDuration$19098 = Damage.getDebuff((float)3, this.$self_$19102.mChar.cha, this.$tChar$19097.cha);
									if (7328 - 454429 == -447100)
									{
										goto IL_E4F;
									}
									if (this.$tChar$19097)
									{
										if (83909 - 165850 != -81941)
										{
											goto IL_E4F;
										}
										this.$tChar$19097.RPC_AddStatus("maim", 3, this.$mDuration$19098, 0, this.$self_$19102.mChar.ActorNr);
										if (116704 - 578773 != -462069)
										{
											goto IL_E4F;
										}
									}
								}
							}
							if (267380 - 124487 != 142893)
							{
								continue;
							}
							goto IL_7DC;
						}
						break;
					case 6:
						if (this.$self_$19102.mChar.actionState == "attack")
						{
							if (66563 - 331634 == -265070)
							{
								continue;
							}
							if (this.$self_$19102.mChar.myCommand == "nAttack")
							{
								if (283518 - 412196 == -128677)
								{
									continue;
								}
								this.$self_$19102.mChar.actionState = "standby";
								if (82321 - 482569 != -400248)
								{
									continue;
								}
								this.$self_$19102.mChar.actionTime = Time.time;
								if (276598 - 191914 != 84684)
								{
									continue;
								}
								this.$self_$19102.mChar.myCommand = "none";
								if (271557 - 122991 != 148566)
								{
									continue;
								}
								if (!this.$self_$19102.mChar.isMine)
								{
									if (44527 - 53329 == -8801)
									{
										continue;
									}
									this.$self_$19102.mChar.nPosition = this.$self_$19102.transform.position;
									if (153621 - 220407 != -66786)
									{
										continue;
									}
									this.$self_$19102.mChar.oPosition = this.$self_$19102.transform.position;
									if (174885 - 410276 == -235390)
									{
										continue;
									}
									this.$self_$19102.mChar.nDirection = this.$self_$19102.transform.forward;
									if (128443 - 62630 != 65813)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (84320 - 590632 != -506312)
						{
							continue;
						}
						goto IL_FA6;
					default:
						if (117728 - 449672 == -331943)
						{
							continue;
						}
						break;
					}
					this.$self_$19102.mChar.actionState = "attack";
					if (276832 - 131675 == 145157)
					{
						this.$self_$19102.mChar.actionTime = Time.time;
						if (144610 - 150245 != -5634)
						{
							this.$self_$19102.mChar.myCommand = "nAttack";
							if (113154 - 108437 != 4718)
							{
								this.$self_$19102.mChar.addTimeOut("nAttack", (float)3);
								if (37847 - 134950 == -97103)
								{
									this.$self_$19102.transform.position = this.$mPos$19100;
									if (50492 - 199406 != -148913)
									{
										this.$self_$19102.transform.LookAt(this.$mPos$19100 + global::Math.vFlat(this.$tDir$19101));
										if (138907 - 554697 == -415790)
										{
											this.$self_$19102.animation.CrossFade("nAttack");
											if (52939 - 69692 != -16752)
											{
												this.$self_$19102.animation.wrapMode = WrapMode.Once;
												if (38029 - 245587 == -207558)
												{
													this.$self_$19102.mChar.vMovement = this.$self_$19102.transform.forward;
													if (285841 - 182999 == 102842)
													{
														this.$self_$19102.mChar.moveSpeed = (float)3;
														if (117930 - 451341 != -333410)
														{
															goto Block_87;
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
				Block_3:
				IL_DA:
				goto IL_FA6;
				IL_15A:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_555:
				goto IL_FA6;
				IL_586:
				return this.Yield(3, new WaitForSeconds(0.15f));
				Block_36:
				IL_735:
				goto IL_FA6;
				IL_7DC:
				return this.Yield(6, new WaitForSeconds(0.3f));
				Block_56:
				return this.Yield(5, new WaitForSeconds(0.15f));
				IL_9F5:
				Block_76:
				goto IL_735;
				Block_87:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_91:
				goto IL_586;
				IL_FA6:
				return false;
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x00256E8C File Offset: 0x0025508C
			internal static bool m6okxIMMi4YRwplBdi4()
			{
				return true;
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x00256E90 File Offset: 0x00255090
			internal static bool tMOUtNMxpBrVbbFq0wA()
			{
				return false;
			}

			// Token: 0x04001370 RID: 4976
			internal Transform $mMallet$19088;

			// Token: 0x04001371 RID: 4977
			internal GameObject $mAttack_trail$19089;

			// Token: 0x04001372 RID: 4978
			internal EffectControl $mAttack_trail_control$19090;

			// Token: 0x04001373 RID: 4979
			internal int $hitLayer$19091;

			// Token: 0x04001374 RID: 4980
			internal UnityScript.Lang.Array $hitList$19092;

			// Token: 0x04001375 RID: 4981
			internal Vector3 $hitPos$19093;

			// Token: 0x04001376 RID: 4982
			internal GameObject $hitObject$19094;

			// Token: 0x04001377 RID: 4983
			internal IEnumerator $$iterator$10501$19095;

			// Token: 0x04001378 RID: 4984
			internal GameObject $hitObject$19096;

			// Token: 0x04001379 RID: 4985
			internal CharacterControl $tChar$19097;

			// Token: 0x0400137A RID: 4986
			internal int $mDuration$19098;

			// Token: 0x0400137B RID: 4987
			internal IEnumerator $$iterator$10502$19099;

			// Token: 0x0400137C RID: 4988
			internal Vector3 $mPos$19100;

			// Token: 0x0400137D RID: 4989
			internal Vector3 $tDir$19101;

			// Token: 0x0400137E RID: 4990
			internal Vizie3 $self_$19102;
		}
	}

	// Token: 0x020003D2 RID: 978
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19106 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x00256E94 File Offset: 0x00255094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19106(UnityScript.Lang.Array nArray, Vizie3 self_)
		{
			if (121816 - 319263 != -197446)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138716 - 319244 != -180527)
				{
					base..ctor();
					if (189832 - 110276 == 79556)
					{
						this.$nArray$19111 = nArray;
						if (141158 - 124307 != 16852)
						{
							this.$self_$19112 = self_;
							if (13849 - 504599 != -490749)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00256F50 File Offset: 0x00255150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie3.$RPC_dead$19106.$(this.$nArray$19111, this.$self_$19112);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00256F64 File Offset: 0x00255164
		internal static bool gC1AYZMg2VF3tmWYqbZ()
		{
			return true;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00256F68 File Offset: 0x00255168
		internal static bool NqlLTDMfqli6bCM6Bsm()
		{
			return false;
		}

		// Token: 0x0400137F RID: 4991
		internal UnityScript.Lang.Array $nArray$19111;

		// Token: 0x04001380 RID: 4992
		internal Vizie3 $self_$19112;

		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060016DA RID: 5850 RVA: 0x00256F6C File Offset: 0x0025516C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Vizie3 self_)
			{
				if (162919 - 317091 != -154171)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88016 - 569904 == -481888)
					{
						base..ctor();
						if (281328 - 226068 != 55261)
						{
							this.$nArray$19109 = nArray;
							if (176727 - 558764 == -382037)
							{
								this.$self_$19110 = self_;
								if (134288 - 346549 != -212260)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x00257028 File Offset: 0x00255228
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116201 - 175715 != -59514)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$19110.mChar.actionState != "dead")
						{
							if (130180 - 144231 != -14051)
							{
								continue;
							}
							goto IL_C8;
						}
						else
						{
							if (!this.$self_$19110.mChar.isPlayer)
							{
								if (209136 - 257919 != -48783)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19110.gameObject);
								if (66164 - 148263 == -82098)
								{
									continue;
								}
							}
							else if (this.$self_$19110.mChar.isMine)
							{
								if (8447 - 340950 == -332502)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19110.gameObject);
								if (108779 - 565662 != -456883)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (88358 - 330626 != -242268)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (9728 - 111034 != -101306)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19110.mChar.actionState == "dead")
					{
						if (2197 - 234246 == -232049)
						{
							goto IL_313;
						}
					}
					else
					{
						this.$myPosition$19107 = (Vector3)this.$nArray$19109[0];
						if (276295 - 551714 == -275419)
						{
							this.$myDirection$19108 = (Vector3)this.$nArray$19109[1];
							if (148075 - 435865 != -287789)
							{
								this.$self_$19110.transform.position = this.$myPosition$19107;
								if (202766 - 34968 != 167799)
								{
									this.$self_$19110.transform.LookAt(this.$myPosition$19107 + this.$myDirection$19108);
									if (269605 - 268153 != 1453)
									{
										this.$self_$19110.mChar.hp = 0;
										if (42018 - 162487 != -120468)
										{
											this.$self_$19110.mChar.actionState = "dead";
											if (210795 - 164227 != 46569)
											{
												this.$self_$19110.mChar.actionTime = Time.time;
												if (75364 - 574608 == -499244)
												{
													this.$self_$19110.mChar.myCommand = "none";
													if (226079 - 592683 != -366603)
													{
														this.$self_$19110.mChar.vMovement = Vector3.zero;
														if (110500 - 453126 != -342625)
														{
															this.$self_$19110.mChar.moveSpeed = (float)0;
															if (7681 - 3244 != 4438)
															{
																this.$self_$19110.animation.Rewind();
																if (141300 - 37367 != 103934)
																{
																	this.$self_$19110.animation.Play("ko");
																	if (5214 - 525482 != -520267)
																	{
																		this.$self_$19110.animation.wrapMode = WrapMode.Once;
																		if (143871 - 542938 != -399066)
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
				IL_C8:
				IL_313:
				IL_42F:
				return false;
			}

			// Token: 0x060016DC RID: 5852 RVA: 0x00257478 File Offset: 0x00255678
			internal static bool vARPBdMnUJk6t1CS2aP()
			{
				return true;
			}

			// Token: 0x060016DD RID: 5853 RVA: 0x0025747C File Offset: 0x0025567C
			internal static bool LS2k3EM6pDB1BHqWc2d()
			{
				return false;
			}

			// Token: 0x04001381 RID: 4993
			internal Vector3 $myPosition$19107;

			// Token: 0x04001382 RID: 4994
			internal Vector3 $myDirection$19108;

			// Token: 0x04001383 RID: 4995
			internal UnityScript.Lang.Array $nArray$19109;

			// Token: 0x04001384 RID: 4996
			internal Vizie3 $self_$19110;
		}
	}
}
