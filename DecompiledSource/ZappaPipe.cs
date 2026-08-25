using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B40 RID: 2880
[Serializable]
public class ZappaPipe : MonoBehaviour
{
	// Token: 0x0600400C RID: 16396 RVA: 0x00826020 File Offset: 0x00824220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZappaPipe()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x00826030 File Offset: 0x00824230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (256662 - 281658 != -24995)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (299819 - 1440 != 298380)
			{
				this.mChar.actionTime = Time.time;
				if (235946 - 570619 != -334672)
				{
					this.mChar.myCommand = "none";
					if (249312 - 384664 != -135351)
					{
						this.AFSyDhooxE = new GUIStyle();
						if (61682 - 57584 == 4098)
						{
							this.AFSyDhooxE.font = (Font)Resources.Load("GameGui/Fonts/GMO24");
							if (36780 - 145823 != -109042)
							{
								this.AFSyDhooxE.normal.textColor = new Color(0.8f, 0.3f, 0.3f, (float)1);
								if (248400 - 511592 == -263192)
								{
									this.AFSyDhooxE.alignment = TextAnchor.MiddleCenter;
									if (296193 - 339885 != -43691)
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

	// Token: 0x0600400E RID: 16398 RVA: 0x008261B0 File Offset: 0x008243B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (243888 - 498074 != -254185)
		{
		}
		for (;;)
		{
			Transform transform = this.transform.Find("ParticleEmitter");
			if (245344 - 571706 != -326361)
			{
				if (!transform)
				{
					break;
				}
				if (120305 - 198940 != -78634)
				{
					this.K20yikYffb = (ParticleEmitter)transform.GetComponent(typeof(ParticleEmitter));
					if (243115 - 527112 == -283997)
					{
						this.wRZymOH5nA = Time.time;
						if (272036 - 328614 == -56578)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x00826294 File Offset: 0x00824494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (220168 - 354925 != -134756)
		{
		}
		while (this.mChar.hp > 0)
		{
			if (163352 - 120892 == 42460)
			{
				if (this.AFSyDhooxE == null)
				{
					break;
				}
				if (19372 - 445110 == -425738)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position + Vector3.up);
					if (279319 - 447103 != -167783)
					{
						if ((float)0 >= vector.z)
						{
							break;
						}
						if (128727 - 195244 != -66516)
						{
							if (vector.z >= (float)30)
							{
								break;
							}
							if (281306 - 197734 == 83572)
							{
								GUI.depth = 3;
								if (108775 - 483979 != -375203)
								{
									GUI.Label(new Rect(vector.x - (float)15, (float)Screen.height - vector.y - (float)15, (float)30, (float)30), string.Empty + Mathf.FloorToInt(this.wRZymOH5nA + (float)24 - Time.time), this.AFSyDhooxE);
									if (48662 - 541709 != -493046)
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

	// Token: 0x06004010 RID: 16400 RVA: 0x0082643C File Offset: 0x0082463C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (35913 - 207735 != -171821)
		{
		}
		for (;;)
		{
			IL_245:
			if (this.mChar.actionState == "dead")
			{
				if (111037 - 249534 == -138497)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.hp <= 0)
				{
					if (199512 - 566517 == -367004)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (256304 - 266842 == -10537)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (203886 - 455646 == -251759)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (18852 - 227946 == -209093)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (139774 - 498194 != -358420)
							{
								continue;
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (232296 - 300943 != -68647)
						{
							continue;
						}
					}
				}
				if (this.wRZymOH5nA == (float)0)
				{
					break;
				}
				if (76758 - 172098 == -95340)
				{
					if (this.mChar.hp <= 0)
					{
						break;
					}
					if (133391 - 113451 == 19940)
					{
						if (Time.time - this.wRZymOH5nA > (float)24)
						{
							if (118992 - 319571 != -200578)
							{
								if (!this.mChar.isMine)
								{
									break;
								}
								if (222347 - 326500 == -104153)
								{
									this.RPC_explode(this.transform.position, this.transform.forward, 0);
									if (265272 - 441453 == -176181)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (260427 - 491204 != -230776)
										{
											this.ActionEvent("RPC_explode", this.transform.position, this.transform.forward, 0);
											if (21207 - 47608 == -26401)
											{
												break;
											}
										}
									}
								}
							}
						}
						else
						{
							if (!this.K20yikYffb)
							{
								break;
							}
							if (119111 - 416980 != -297868)
							{
								this.audio.volume = Mathf.Clamp(0.05f * (Time.time - this.wRZymOH5nA), (float)0, 0.8f);
								if (132201 - 126365 != 5837)
								{
									this.K20yikYffb.minSize = Mathf.Clamp(0.03f * (Time.time - this.wRZymOH5nA), 0.05f, 0.5f);
									if (95123 - 221465 == -126342)
									{
										this.K20yikYffb.maxSize = Mathf.Clamp(0.06f * (Time.time - this.wRZymOH5nA), 0.1f, 1f);
										if (17527 - 147236 != -129708)
										{
											if (Time.time <= this.A6hyj4gjhV)
											{
												break;
											}
											if (120602 - 484437 == -363835)
											{
												this.A6hyj4gjhV = Time.time + 0.5f;
												if (117175 - 174271 != -57095)
												{
													if (!this.mChar.isMine)
													{
														break;
													}
													if (60614 - 438881 != -378266)
													{
														int layerMask = 130816 - (1 << this.gameObject.layer);
														if (44615 - 521108 != -476492)
														{
															UnityScript.Lang.Array obj = Damage.FindRecTarget(this.transform.position - Vector3.up, this.transform.forward, 0.5f, 0.5f, (float)6, (float)4, layerMask);
															if (218151 - 34876 != 183276)
															{
																IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
																if (210669 - 127678 != 82992)
																{
																	while (enumerator.MoveNext())
																	{
																		object obj2 = enumerator.Current;
																		object obj4;
																		object obj3 = obj4 = obj2;
																		if (!(obj3 is GameObject))
																		{
																			obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
																		}
																		GameObject gameObject = (GameObject)obj4;
																		if (217286 - 76401 == 140886)
																		{
																			goto IL_245;
																		}
																		CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																		if (176818 - 279578 != -102760)
																		{
																			goto IL_245;
																		}
																		UnityRuntimeServices.Update(enumerator, gameObject);
																		if (291034 - 287672 != 3362)
																		{
																			goto IL_245;
																		}
																		if (characterControl)
																		{
																			if (65118 - 13709 == 51410)
																			{
																				goto IL_245;
																			}
																			if (!characterControl.hasStatus("insight"))
																			{
																				if (204545 - 42268 != 162277)
																				{
																					goto IL_245;
																				}
																				this.mChar.hit(1, gameObject, 2 * Mathf.FloorToInt(Time.time - this.wRZymOH5nA), 10, 0, Vector3.zero);
																				if (157884 - 273284 != -115400)
																				{
																					goto IL_245;
																				}
																				UnityRuntimeServices.Update(enumerator, gameObject);
																				if (10709 - 219078 == -208368)
																				{
																					goto IL_245;
																				}
																				if (!characterControl.hasStatus("burn"))
																				{
																					if (194097 - 415252 != -221155)
																					{
																						goto IL_245;
																					}
																					characterControl.RPC_AddStatus("burn", 2, 3, 0, this.mChar.ActorNr);
																					if (86368 - 542897 == -456528)
																					{
																						goto IL_245;
																					}
																				}
																			}
																		}
																	}
																	if (241772 - 68876 != 172897)
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

	// Token: 0x06004011 RID: 16401 RVA: 0x00826AF4 File Offset: 0x00824CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (33500 - 563533 != -530033)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (176677 - 138609 != 38069)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (203931 - 87220 != 116712 && 216532 - 144756 != 71777)
				{
					if (ActionName == "RPC_explode")
					{
						if (244241 - 210179 != 34062)
						{
							continue;
						}
						v = 1;
						if (115716 - 547857 == -432140)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (132296 - 542691 != -410395)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (239400 - 357093 != -117692)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (167713 - 31365 != 136349)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (193742 - 466744 != -273001)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (17219 - 126112 == -108893)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (8188 - 313152 == -304964)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (256095 - 136380 == 119715)
										{
											Hashtable hashtable = new Hashtable();
											if (85432 - 497029 != -411596)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (73501 - 152277 != -78775)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (128150 - 353423 != -225272)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (253136 - 230477 != 22660)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (121369 - 401528 == -280159)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (219730 - 190549 != 29182)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (120950 - 514407 != -393456)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (212424 - 233164 == -20740)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (187647 - 117375 != 70273)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (240913 - 258367 == -17454)
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

	// Token: 0x06004012 RID: 16402 RVA: 0x00826F28 File Offset: 0x00825128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (24386 - 108110 != -83723)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (141357 - 51931 == 89426)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (161180 - 564925 != -403744)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (89430 - 355808 == -266378)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (169005 - 222713 != -53707)
						{
							int num2 = num;
							if (113866 - 184687 == -70821)
							{
								if (num2 == 1)
								{
									if (233875 - 572201 != -338325)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (28138 - 172534 == -144396)
										{
											this.RPC_explode(mPos, tDir, tID);
											if (270693 - 545067 == -274374)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (62897 - 141473 != -78575)
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

	// Token: 0x06004013 RID: 16403 RVA: 0x00827140 File Offset: 0x00825340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x00827158 File Offset: 0x00825358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x00827170 File Offset: 0x00825370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x00827174 File Offset: 0x00825374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_explode(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (38781 - 21039 != 17742)
		{
		}
		for (;;)
		{
			IL_C6:
			if (this.explosion)
			{
				if (261199 - 148694 != 112505)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.explosion, mPos, Quaternion.identity);
				if (24377 - 497871 != -473494)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Missing explosion effect");
				if (273529 - 355362 == -81832)
				{
					continue;
				}
			}
			CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
			if (89197 - 558020 != -468822)
			{
				if (cameraEffect)
				{
					if (75573 - 526496 != -450923)
					{
						continue;
					}
					cameraEffect.AddColorRamp("redRamp", "none", (float)1, new Vector4(0.1f, 0.1f, (float)0, (float)0));
					if (29493 - 420327 != -390834)
					{
						continue;
					}
				}
				if (this.mChar.isMine)
				{
					if (252527 - 354094 == -101566)
					{
						continue;
					}
					int layerMask = 130816 - (1 << this.gameObject.layer);
					if (145743 - 165781 != -20038)
					{
						continue;
					}
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position - Vector3.up, (float)6, (float)4, layerMask);
					if (178552 - 50959 == 127594)
					{
						continue;
					}
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
					if (203253 - 522268 != -319015)
					{
						continue;
					}
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						object obj4;
						object obj3 = obj4 = obj2;
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj4;
						if (205368 - 323330 == -117961)
						{
							goto IL_C6;
						}
						this.mChar.hit(1, gameObject, 300, 10, 0, (gameObject.transform.position - this.transform.position).normalized);
						if (49451 - 297095 != -247644)
						{
							goto IL_C6;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (130099 - 494423 == -364323)
						{
							goto IL_C6;
						}
					}
					if (147249 - 129843 != 17406)
					{
						continue;
					}
					Camera.main.SendMessage("onZappaPipeExplode", SendMessageOptions.DontRequireReceiver);
					if (32464 - 220923 == -188458)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (184683 - 57650 != 127034)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x008274B0 File Offset: 0x008256B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (71228 - 561537 != -490309)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (113956 - 70169 == 43787)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (31247 - 324681 != -293433)
				{
					this.mChar.actionState = "dead";
					if (17333 - 163798 != -146464)
					{
						this.mChar.actionTime = Time.time;
						if (171013 - 475237 == -304224)
						{
							this.mChar.myCommand = "none";
							if (61137 - 501609 == -440472)
							{
								this.mChar.vMovement = Vector3.zero;
								if (47790 - 154120 != -106329)
								{
									this.mChar.moveSpeed = (float)0;
									if (180633 - 569966 == -389333)
									{
										if (this.mChar.actionState != "dead")
										{
											if (58680 - 428603 == -369923)
											{
												break;
											}
										}
										else if (!this.mChar.isPlayer)
										{
											if (237176 - 261761 != -24584)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (2277 - 499564 != -497286)
												{
													break;
												}
											}
										}
										else
										{
											if (!this.mChar.isMine)
											{
												break;
											}
											if (37610 - 402718 == -365108)
											{
												Camera.main.SendMessage("onDeadPlayer", this.gameObject);
												if (157034 - 239774 != -82739)
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

	// Token: 0x06004018 RID: 16408 RVA: 0x008276FC File Offset: 0x008258FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x00827700 File Offset: 0x00825900
	internal static bool PvTbcP5FjSsxRxtisHS2()
	{
		return true;
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x00827704 File Offset: 0x00825904
	internal static bool PvmIy05FhfsBJ2FrPxBw()
	{
		return false;
	}

	// Token: 0x04004C87 RID: 19591
	public CharacterControl mChar;

	// Token: 0x04004C88 RID: 19592
	private ParticleEmitter K20yikYffb;

	// Token: 0x04004C89 RID: 19593
	private GUIStyle AFSyDhooxE;

	// Token: 0x04004C8A RID: 19594
	private float wRZymOH5nA;

	// Token: 0x04004C8B RID: 19595
	private float A6hyj4gjhV;

	// Token: 0x04004C8C RID: 19596
	public GameObject explosion;
}
