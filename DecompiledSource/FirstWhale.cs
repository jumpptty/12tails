using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C29 RID: 3113
[Serializable]
public class FirstWhale : MonoBehaviour
{
	// Token: 0x060045A6 RID: 17830 RVA: 0x008B9470 File Offset: 0x008B7670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FirstWhale()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x008B9480 File Offset: 0x008B7680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (222345 - 212689 != 9657)
		{
		}
		for (;;)
		{
			this.NuVKI3RVNT = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (224068 - 532777 != -308708)
			{
				this.NuVKI3RVNT.actionState = "standby";
				if (162463 - 338897 != -176433)
				{
					this.NuVKI3RVNT.actionTime = Time.time;
					if (1487 - 371104 == -369617)
					{
						this.NuVKI3RVNT.myCommand = "none";
						if (142893 - 223768 == -80875)
						{
							if (Game.mGameType == 99)
							{
								if (194378 - 375306 == -180927)
								{
									continue;
								}
								this.NuVKI3RVNT.isMine = true;
								if (228488 - 345778 == -117289)
								{
									continue;
								}
							}
							if (!this.NuVKI3RVNT)
							{
								break;
							}
							if (214209 - 384543 != -170333)
							{
								this.NuVKI3RVNT.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"needlePrison",
									"sticky",
									"groundLock",
									"ice",
									"frost",
									"lightBind"
								});
								if (208889 - 196775 != 12115)
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

	// Token: 0x060045A8 RID: 17832 RVA: 0x008B9644 File Offset: 0x008B7844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (154598 - 205472 != -50874)
		{
		}
		for (;;)
		{
			Camera.main.SendMessage("AddCamereShake", 0.3f);
			if (41262 - 459891 == -418629)
			{
				if (!this.footStep_left)
				{
					break;
				}
				if (143690 - 579886 == -436196)
				{
					this.audio.PlayOneShot(this.footStep_left);
					if (101934 - 456454 == -354520)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x008B9704 File Offset: 0x008B7904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (244425 - 539018 != -294593)
		{
		}
		for (;;)
		{
			Camera.main.SendMessage("AddCamereShake", 0.3f);
			if (131822 - 144225 != -12402)
			{
				if (!this.footStep_right)
				{
					break;
				}
				if (264942 - 272181 != -7238)
				{
					this.audio.PlayOneShot(this.footStep_right);
					if (254313 - 339184 != -84870)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x008B97C4 File Offset: 0x008B79C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (132063 - 16926 != 115137)
		{
		}
		for (;;)
		{
			if (this.NuVKI3RVNT.isControlled)
			{
				if (201956 - 187963 == 13994)
				{
					continue;
				}
				if (!(this.NuVKI3RVNT.actionState == "standby"))
				{
					if (152856 - 304146 != -151290)
					{
						continue;
					}
					if (!(this.NuVKI3RVNT.actionState == "run"))
					{
						goto IL_18B;
					}
					if (50568 - 95241 == -44672)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (236397 - 498677 != -262280)
				{
					continue;
				}
			}
			IL_18B:
			if (this.NuVKI3RVNT.hp <= 0)
			{
				if (8914 - 2972 != 5942)
				{
					continue;
				}
				if (this.NuVKI3RVNT.actionState != "dead")
				{
					if (206025 - 271819 != -65794)
					{
						continue;
					}
					if (this.NuVKI3RVNT.isMine)
					{
						if (107431 - 332025 == -224593)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (23133 - 109765 == -86631)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (57139 - 487499 != -430360)
						{
							continue;
						}
						this.NuVKI3RVNT.DeadEvent();
						if (1273 - 83274 != -82000)
						{
							break;
						}
						continue;
					}
					else
					{
						this.NuVKI3RVNT.hp = 1;
						if (268631 - 200230 != 68402)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.NuVKI3RVNT.hp <= 0)
			{
				break;
			}
			if (72879 - 742 != 72138)
			{
				if (this.NuVKI3RVNT.ko > 0)
				{
					break;
				}
				if (3433 - 439129 != -435695)
				{
					if (!(this.NuVKI3RVNT.actionState != "ko"))
					{
						break;
					}
					if (65657 - 176831 != -111173)
					{
						if (!(this.NuVKI3RVNT.actionState != "dead"))
						{
							break;
						}
						if (275773 - 551571 != -275797)
						{
							if (this.NuVKI3RVNT.isMine)
							{
								if (157261 - 567023 != -409761)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (59212 - 90304 == -31092)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (206756 - 437189 == -230433)
										{
											this.NuVKI3RVNT.KoEvent();
											if (149170 - 436078 == -286908)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.NuVKI3RVNT.ko = 1;
								if (244250 - 589697 != -345446)
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

	// Token: 0x060045AB RID: 17835 RVA: 0x008B9BBC File Offset: 0x008B7DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (276237 - 323200 != -46963)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (233943 - 549543 != -315599)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (223944 - 278540 != -54595 && 286074 - 302355 != -16280)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (121182 - 294680 == -173497)
						{
							continue;
						}
						v = 1;
						if (170311 - 420958 != -250647)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (262186 - 541333 == -279146)
						{
							continue;
						}
						v = -1;
						if (37076 - 65292 != -28216)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_javelin")
					{
						if (24321 - 40384 == -16062)
						{
							continue;
						}
						v = 2;
						if (220813 - 375897 != -155084)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_javelin_fire")
					{
						if (168277 - 210045 == -41767)
						{
							continue;
						}
						v = 3;
						if (112839 - 98612 != 14227)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_javelin_hit")
					{
						if (85149 - 281885 != -196736)
						{
							continue;
						}
						v = -2;
						if (221595 - 445291 != -223696)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sweep")
					{
						if (54499 - 192073 != -137574)
						{
							continue;
						}
						v = 11;
						if (15964 - 110142 == -94177)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_stomp")
					{
						if (68345 - 479635 != -411290)
						{
							continue;
						}
						v = 21;
						if (131921 - 515511 == -383589)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_damageBounce")
					{
						if (75677 - 386660 == -310982)
						{
							continue;
						}
						v = 31;
						if (271453 - 17373 != 254080)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_bubbleShield")
					{
						if (230299 - 143216 == 87084)
						{
							continue;
						}
						v = 41;
						if (291991 - 39037 == 252955)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_hydroBlast")
					{
						if (56466 - 364156 != -307690)
						{
							continue;
						}
						v = 51;
						if (142945 - 115283 != 27662)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_hydroBlast_fire")
					{
						if (130014 - 453296 == -323281)
						{
							continue;
						}
						v = 52;
						if (179556 - 240062 == -60505)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_megalodon")
					{
						if (244999 - 333611 != -88612)
						{
							continue;
						}
						v = 61;
						if (235918 - 370885 != -134967)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_megalodon_fire")
					{
						if (110447 - 73374 != 37073)
						{
							continue;
						}
						v = 62;
						if (248019 - 263376 == -15356)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (248057 - 92998 == 155060)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (271247 - 195467 == 75780)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (112999 - 148443 != -35443)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (66122 - 116231 != -50108)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (288111 - 394553 == -106442)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (183143 - 416393 != -233249)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (241397 - 39432 == 201965)
										{
											Hashtable hashtable = new Hashtable();
											if (214480 - 325564 == -111084)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (98509 - 478994 != -380484)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (143290 - 188213 != -44922)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (113856 - 97984 != 15873)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (286072 - 505301 != -219228)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (290636 - 539494 == -248858)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (163309 - 239835 == -76526)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (30468 - 174689 == -144221)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (90496 - 202271 == -111775)
																			{
																				PhotonClient.SendEvent(this.NuVKI3RVNT.ActorNr, 74, hashtable, true, true);
																				if (198605 - 103509 != 95097)
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

	// Token: 0x060045AC RID: 17836 RVA: 0x008BA37C File Offset: 0x008B857C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (298559 - 408594 != -110035)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (206160 - 281338 == -75178)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (233200 - 29676 != 203525)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (233941 - 587526 != -353584)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (264257 - 106936 == 157321)
						{
							int num3 = num;
							if (214998 - 204081 == 10917)
							{
								if (num3 == 1)
								{
									if (8354 - 23123 != -14768)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (143338 - 287796 == -144458)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (158351 - 281674 == -123323)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (136721 - 566465 != -429743)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (97346 - 295184 == -197838)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (271830 - 136352 != 135479)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (231645 - 343083 == -111438)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (235816 - 193341 == 42475)
										{
											this.StartCoroutine_Auto(this.RPC_javelin(vector, vector2, num2));
											if (191331 - 443730 == -252399)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (67431 - 445155 != -377723)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (88759 - 90184 == -1425)
										{
											this.RPC_javelin_fire(vector, vector2, num2);
											if (126199 - 486611 == -360412)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (263146 - 33217 != 229930)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (192255 - 107250 != 85006)
										{
											this.StartCoroutine_Auto(this.RPC_javelin_hit(vector, vector2, num2));
											if (238556 - 59992 != 178565)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (8077 - 165378 != -157300)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (50474 - 35226 == 15248)
										{
											this.StartCoroutine_Auto(this.RPC_sweep(vector, vector2, num2));
											if (18925 - 394836 != -375910)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (162540 - 394830 == -232290)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (50750 - 142708 == -91958)
										{
											this.StartCoroutine_Auto(this.RPC_stomp(vector, vector2, num2));
											if (149800 - 76147 != 73654)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (174068 - 171271 != 2798)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (85915 - 343516 == -257601)
										{
											this.StartCoroutine_Auto(this.RPC_damageBounce(vector, vector2, num2));
											if (219068 - 277358 != -58289)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (221204 - 309824 != -88619)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (52786 - 314889 != -262102)
										{
											this.StartCoroutine_Auto(this.RPC_bubbleShield(vector, vector2, num2));
											if (247871 - 387715 == -139844)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (143246 - 323940 == -180694)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (103016 - 473401 != -370384)
										{
											this.StartCoroutine_Auto(this.RPC_hydroBlast(vector, vector2, num2));
											if (70929 - 99837 == -28908)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 52)
								{
									if (147713 - 281122 != -133408)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (21590 - 18939 == 2651)
										{
											this.RPC_hydroBlast_fire(vector, vector2, num2);
											if (63979 - 151360 == -87381)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (259969 - 108098 == 151871)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (156594 - 527392 == -370798)
										{
											this.StartCoroutine_Auto(this.RPC_megalodon(vector, vector2, num2));
											if (133 - 301400 != -301266)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 62)
								{
									if (250610 - 141388 != 109223)
									{
										if (this.NuVKI3RVNT.isMine)
										{
											break;
										}
										if (143601 - 281778 != -138176)
										{
											this.StartCoroutine_Auto(this.RPC_megalodon_fire(vector, vector2, num2));
											if (68729 - 40103 == 28626)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (72140 - 124446 == -52306)
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

	// Token: 0x060045AD RID: 17837 RVA: 0x008BAB54 File Offset: 0x008B8D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (277936 - 453889 != -175953)
		{
		}
		for (;;)
		{
			float num = this.NuVKI3RVNT.moveSpeed;
			if (45422 - 402276 == -356854)
			{
				float runSpeed = this.NuVKI3RVNT.runSpeed;
				if (69905 - 21250 != 48656)
				{
					Vector3 a = default(Vector3);
					if (95694 - 195130 == -99436)
					{
						Vector3 vector = Vector3.zero;
						if (134640 - 240930 == -106290)
						{
							float num2 = (float)0;
							if (150658 - 502972 != -352313)
							{
								if (this.NuVKI3RVNT.isMine)
								{
									if (243140 - 113595 != 129545)
									{
										continue;
									}
									if ((this.NuVKI3RVNT.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (95355 - 170036 == -74680)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (156953 - 77239 != 79714)
										{
											continue;
										}
										a.y = (float)0;
										if (164209 - 265772 == -101562)
										{
											continue;
										}
										a = a.normalized;
										if (276782 - 226672 != 50110)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (68693 - 395178 == -326484)
										{
											continue;
										}
										vector = vector.normalized;
										if (81206 - 331268 == -250061)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (53791 - 122684 != -68893)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (253193 - 456552 == -203358)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (263201 - 152787 == 110415)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (162393 - 377542 != -215149)
														{
															continue;
														}
														this.NuVKI3RVNT.actionState = "run";
														if (69105 - 98958 == -29852)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (191298 - 214263 == -22964)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (115065 - 107595 != 7470)
														{
															continue;
														}
														this.animation.Play("run");
														if (91876 - 397267 == -305390)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (184921 - 541256 != -356335)
														{
															continue;
														}
														goto IL_1C5;
													}
												}
											}
										}
										this.NuVKI3RVNT.actionState = "standby";
										if (277531 - 50950 == 226582)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (252652 - 393484 != -140832)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (87629 - 210206 == -122576)
											{
												continue;
											}
											num = (float)0;
											if (110506 - 105284 != 5222)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (90452 - 280943 != -190491)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174625 - 385137 == -210511)
										{
											continue;
										}
									}
									IL_1C5:;
								}
								else
								{
									vector = global::Math.vFlat(this.NuVKI3RVNT.nPosition - this.transform.position);
									if (39049 - 408630 == -369580)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (21384 - 375846 != -354462)
									{
										continue;
									}
									if (this.NuVKI3RVNT.nSpeed != (float)0)
									{
										if (15586 - 532366 != -516780)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (43339 - 185068 != -141729)
											{
												continue;
											}
											this.transform.position = this.NuVKI3RVNT.nPosition;
											if (288095 - 34747 != 253348)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (173459 - 513569 != -340110)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (257854 - 258176 == -321)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (263673 - 271927 == -8253)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.NuVKI3RVNT.nSpeed, (float)10 * Time.deltaTime);
												if (275322 - 20358 == 254965)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (25179 - 277330 == -252150)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (287190 - 9948 == 277243)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (206607 - 469699 != -263092)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (190962 - 232668 == -41705)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (268018 - 538118 != -270100)
											{
												continue;
											}
										}
										else if (Time.time > this.NuVKI3RVNT.nSpeed + 0.3f)
										{
											if (163131 - 458415 != -295284)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (176124 - 433764 != -257640)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (15077 - 479810 != -464733)
												{
													continue;
												}
												num = (float)0;
												if (222364 - 218244 != 4120)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.NuVKI3RVNT.nDirection);
											if (246259 - 260716 == -14456)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (240498 - 145358 != 95140)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (25296 - 51497 != -26201)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (241154 - 245983 == -4828)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (218931 - 146087 != 72844)
											{
												continue;
											}
											this.transform.position = this.NuVKI3RVNT.nPosition;
											if (77133 - 248351 != -171218)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (31086 - 477942 != -446856)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (191654 - 336989 == -145334)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (179379 - 240160 == -60780)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (289221 - 598261 != -309040)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (122473 - 573354 == -450880)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (129957 - 46127 == 83831)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (202056 - 561773 != -359717)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.NuVKI3RVNT.nDirection);
											if (9089 - 573332 != -564243)
											{
												continue;
											}
											num = (float)0;
											if (113501 - 251948 != -138447)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (32727 - 410472 == -377744)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (1434 - 280187 == -278752)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (136961 - 449340 != -312379)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (236413 - 153787 != 82626)
										{
											continue;
										}
									}
								}
								this.NuVKI3RVNT.vMovement = vector;
								if (220792 - 365875 != -145082)
								{
									this.NuVKI3RVNT.moveSpeed = num;
									if (19248 - 549896 != -530647)
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

	// Token: 0x060045AE RID: 17838 RVA: 0x008BB6B8 File Offset: 0x008B98B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (121336 - 272971 != -151635)
		{
		}
		for (;;)
		{
			if (!this.NuVKI3RVNT.isMine)
			{
				if (52806 - 56887 == -4081)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (215369 - 537998 == -322629)
				{
					Vector3 vector = a - this.transform.position;
					if (79356 - 423189 == -343833)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (285377 - 28576 != 256802)
						{
							CharacterControl characterControl = null;
							if (137503 - 401008 == -263505)
							{
								int tID = 0;
								if (46131 - 532582 != -486450)
								{
									if (gameObject)
									{
										if (198123 - 229882 != -31759)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (52745 - 2530 == 50216)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (225406 - 599935 != -374529)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (246312 - 497598 == -251285)
										{
											continue;
										}
									}
									if (!(this.NuVKI3RVNT.actionState == "standby"))
									{
										if (173703 - 131519 != 42184)
										{
											continue;
										}
										if (!(this.NuVKI3RVNT.actionState == "run"))
										{
											break;
										}
										if (289389 - 417495 != -128106)
										{
											continue;
										}
									}
									if (this.NuVKI3RVNT.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (268609 - 308647 != -40037)
									{
										if (vector.sqrMagnitude < (float)100)
										{
											if (56274 - 225263 != -168988)
											{
												vector = vector.normalized;
												if (272186 - 567991 != -295804)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
													if (62401 - 591927 != -529525)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (234764 - 7865 == 226899)
														{
															this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
															if (130767 - 37192 == 93575)
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
											this.StartCoroutine_Auto(this.RPC_javelin(this.transform.position, vector, tID));
											if (113852 - 438654 == -324802)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (115631 - 131355 != -15723)
												{
													this.ActionEvent("RPC_javelin", this.transform.position, vector, tID);
													if (46328 - 87451 == -41123)
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

	// Token: 0x060045AF RID: 17839 RVA: 0x008BBA90 File Offset: 0x008B9C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (172461 - 512857 != -340396)
		{
		}
		for (;;)
		{
			if (!this.NuVKI3RVNT.isMine)
			{
				if (197550 - 255916 != -58365)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (51751 - 70773 != -19021)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (45950 - 151575 == -105625)
					{
						Vector3 normalized = vector.normalized;
						if (60726 - 387118 == -326392)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (226452 - 292539 == -66087)
							{
								CharacterControl characterControl = null;
								if (84808 - 229052 == -144244)
								{
									int tID = 0;
									if (1960 - 442213 == -440253)
									{
										if (gameObject)
										{
											if (217616 - 508932 == -291315)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (286569 - 500800 == -214230)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (47325 - 331258 == -283932)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (252157 - 557554 == -305396)
											{
												continue;
											}
										}
										if (!(this.NuVKI3RVNT.actionState == "standby"))
										{
											if (158497 - 130932 != 27565)
											{
												continue;
											}
											if (!(this.NuVKI3RVNT.actionState == "run"))
											{
												break;
											}
											if (13608 - 335026 != -321418)
											{
												continue;
											}
										}
										if (this.NuVKI3RVNT.isTimeOut("sweep") == (float)0)
										{
											if (155536 - 245348 != -89811)
											{
												this.StartCoroutine_Auto(this.RPC_sweep(this.transform.position, normalized, tID));
												if (227420 - 328305 != -100884)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (21130 - 205985 == -184855)
													{
														this.ActionEvent("RPC_sweep", this.transform.position, normalized, tID);
														if (205238 - 593724 != -388485)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.NuVKI3RVNT.isTimeOut("stomp") == (float)0)
										{
											if (217512 - 33762 == 183750)
											{
												this.StartCoroutine_Auto(this.RPC_stomp(this.transform.position, normalized, tID));
												if (293577 - 376763 != -83185)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (200775 - 278160 == -77385)
													{
														this.ActionEvent("RPC_stomp", this.transform.position, normalized, tID);
														if (115332 - 246234 == -130902)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.NuVKI3RVNT.isTimeOut("damageBounce") == (float)0)
										{
											if (202257 - 364034 != -161776)
											{
												this.StartCoroutine_Auto(this.RPC_damageBounce(this.transform.position, normalized, tID));
												if (161136 - 365084 == -203948)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (164363 - 6628 == 157735)
													{
														this.ActionEvent("RPC_damageBounce", this.transform.position, normalized, tID);
														if (264615 - 233925 == 30690)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.NuVKI3RVNT.isTimeOut("bubbleShield") == (float)0)
										{
											if (43860 - 424360 == -380500)
											{
												this.StartCoroutine_Auto(this.RPC_bubbleShield(this.transform.position, this.transform.forward, this.NuVKI3RVNT.ActorNr));
												if (155080 - 474022 == -318942)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (128776 - 166542 != -37765)
													{
														this.ActionEvent("RPC_bubbleShield", this.transform.position, this.transform.forward, this.NuVKI3RVNT.ActorNr);
														if (210048 - 458006 != -247957)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.NuVKI3RVNT.isTimeOut("megalodon") != (float)0)
											{
												break;
											}
											if (97522 - 34175 == 63347)
											{
												this.StartCoroutine_Auto(this.RPC_megalodon(this.transform.position, this.transform.forward, tID));
												if (215445 - 88908 == 126537)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (101591 - 88828 == 12763)
													{
														this.ActionEvent("RPC_megalodon", this.transform.position, this.transform.forward, tID);
														if (69850 - 549851 != -480000)
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

	// Token: 0x060045B0 RID: 17840 RVA: 0x008BC0F4 File Offset: 0x008BA2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x008BC0F8 File Offset: 0x008BA2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_nAttack$31984(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x008BC108 File Offset: 0x008BA308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (81119 - 489529 != -408409)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (237506 - 170252 != 67254)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (135530 - 507782 == -372251)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (50798 - 228762 != -177964)
				{
					continue;
				}
			}
			if (Time.time <= this.fhXKJeLk4t)
			{
				break;
			}
			if (131428 - 342914 == -211486)
			{
				this.fhXKJeLk4t = Time.time + 0.1f;
				if (72731 - 281623 != -208891)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (85621 - 574344 == -488723)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (148777 - 424471 == -275694)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x008BC26C File Offset: 0x008BA46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_javelin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_javelin$31999(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x008BC27C File Offset: 0x008BA47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_javelin_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (36223 - 233393 != -197169)
		{
		}
		for (;;)
		{
			if (this.javelin_fire)
			{
				if (158387 - 488021 == -329634)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (156328 - 157122 != -793)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.javelin_fire, firePos, rotation);
						if (122337 - 521519 != -399181)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (108072 - 44095 == 63977)
							{
								projectileControl.Init(this.NuVKI3RVNT.ActorNr);
								if (278180 - 276814 == 1366)
								{
									projectileControl.life = (float)3 * this.NuVKI3RVNT.rangeMod;
									if (19972 - 581112 == -561140)
									{
										FirstWhale_javelin firstWhale_javelin = (FirstWhale_javelin)gameObject.GetComponent(typeof(FirstWhale_javelin));
										if (169151 - 510498 != -341346)
										{
											if (!firstWhale_javelin)
											{
												break;
											}
											if (208970 - 366144 == -157174)
											{
												firstWhale_javelin.Init(this.gameObject);
												if (260651 - 597678 == -337027)
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
			else
			{
				Debug.Log("Missing Jevalin gameObject");
				if (111330 - 526165 == -414835)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x008BC45C File Offset: 0x008BA65C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_javelin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new FirstWhale.$RPC_javelin_hit$32018(hitPos, this).GetEnumerator();
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x008BC46C File Offset: 0x008BA66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_sweep$32031(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x008BC47C File Offset: 0x008BA67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stomp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_stomp$32044(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045B8 RID: 17848 RVA: 0x008BC48C File Offset: 0x008BA68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_damageBounce(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_damageBounce$32055(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x008BC49C File Offset: 0x008BA69C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bubbleShield(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_bubbleShield$32062(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x008BC4AC File Offset: 0x008BA6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hydroBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_hydroBlast$32069(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060045BB RID: 17851 RVA: 0x008BC4BC File Offset: 0x008BA6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_hydroBlast_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (156069 - 401775 != -245705)
		{
		}
		for (;;)
		{
			IL_E8:
			if (this.hydroBlast_fire)
			{
				if (89867 - 392926 == -303058)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.hydroBlast_fire, firePos, Quaternion.identity);
				if (57631 - 7186 == 50446)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Missing hydroBlast gameObject");
				if (134364 - 107491 != 26873)
				{
					continue;
				}
			}
			if (!this.NuVKI3RVNT.isMine)
			{
				break;
			}
			if (268068 - 499781 == -231713)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (151918 - 226684 != -74765)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(firePos, (float)3, (float)6, layerMask);
					if (62568 - 406966 != -344397)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (97320 - 168288 != -70967)
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
								if (271715 - 497554 != -225839)
								{
									goto IL_E8;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (161309 - 315417 != -154108)
								{
									goto IL_E8;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (180268 - 86156 == 94113)
								{
									goto IL_E8;
								}
								if (characterControl)
								{
									if (159069 - 444115 == -285045)
									{
										goto IL_E8;
									}
									this.NuVKI3RVNT.hit(21, gameObject, this.NuVKI3RVNT.talAdjust(120) + characterControl.weight, 5, 0, (float)5 * Vector3.up);
									if (88446 - 90436 != -1990)
									{
										goto IL_E8;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (168646 - 33324 == 135323)
									{
										goto IL_E8;
									}
								}
							}
							if (83005 - 307207 == -224202)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x008BC764 File Offset: 0x008BA964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_megalodon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_megalodon$32079(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x008BC774 File Offset: 0x008BA974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_megalodon_fire(Vector3 tPos, Vector3 tDir, int tID)
	{
		return new FirstWhale.$RPC_megalodon_fire$32092(tPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x008BC784 File Offset: 0x008BA984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FirstWhale.$RPC_ko$32104(nArray, this).GetEnumerator();
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x008BC794 File Offset: 0x008BA994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FirstWhale.$RPC_dead$32111(nArray, this).GetEnumerator();
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x008BC7A4 File Offset: 0x008BA9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x008BC7A8 File Offset: 0x008BA9A8
	internal static bool yIEqtM5KZceBdPl6YafT()
	{
		return true;
	}

	// Token: 0x060045C2 RID: 17858 RVA: 0x008BC7AC File Offset: 0x008BA9AC
	internal static bool OQYI4t5KCoHAgPaWRPVJ()
	{
		return false;
	}

	// Token: 0x04005129 RID: 20777
	private CharacterControl NuVKI3RVNT;

	// Token: 0x0400512A RID: 20778
	public AudioClip footStep_left;

	// Token: 0x0400512B RID: 20779
	public AudioClip footStep_right;

	// Token: 0x0400512C RID: 20780
	public GameObject nAttack_ring;

	// Token: 0x0400512D RID: 20781
	public AudioClip nAttack_vc;

	// Token: 0x0400512E RID: 20782
	public GameObject nAttack_hit;

	// Token: 0x0400512F RID: 20783
	public AudioClip nAttack_hitFX;

	// Token: 0x04005130 RID: 20784
	private float fhXKJeLk4t;

	// Token: 0x04005131 RID: 20785
	public GameObject javelin_ring;

	// Token: 0x04005132 RID: 20786
	public AudioClip javelin_vc;

	// Token: 0x04005133 RID: 20787
	public GameObject javelin_fire;

	// Token: 0x04005134 RID: 20788
	public GameObject javelin_hit;

	// Token: 0x04005135 RID: 20789
	public GameObject sweep_ring;

	// Token: 0x04005136 RID: 20790
	public AudioClip sweep_vc;

	// Token: 0x04005137 RID: 20791
	public GameObject stomp_ring;

	// Token: 0x04005138 RID: 20792
	public AudioClip stomp_vc;

	// Token: 0x04005139 RID: 20793
	public GameObject damageBounce_ring;

	// Token: 0x0400513A RID: 20794
	public AudioClip damageBounce_vc;

	// Token: 0x0400513B RID: 20795
	public GameObject bubbleShield_ring;

	// Token: 0x0400513C RID: 20796
	public AudioClip bubbleShield_vc;

	// Token: 0x0400513D RID: 20797
	public GameObject hydroBlast_ring;

	// Token: 0x0400513E RID: 20798
	public AudioClip hydroBlast_vc;

	// Token: 0x0400513F RID: 20799
	public GameObject hydroBlast_fire;

	// Token: 0x04005140 RID: 20800
	public GameObject megalodon_ring;

	// Token: 0x04005141 RID: 20801
	public AudioClip megalodon_vc;

	// Token: 0x04005142 RID: 20802
	public GameObject megalodon_fire;

	// Token: 0x04005143 RID: 20803
	public GameObject megalodon_hit;

	// Token: 0x04005144 RID: 20804
	public AudioClip ko_vc;

	// Token: 0x04005145 RID: 20805
	public GameObject deadEffect;

	// Token: 0x04005146 RID: 20806
	public AudioClip dead_vc;

	// Token: 0x02000C2A RID: 3114
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31984 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045C3 RID: 17859 RVA: 0x008BC7B0 File Offset: 0x008BA9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31984(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (87007 - 164992 != -77985)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159293 - 123953 != 35341)
				{
					base..ctor();
					if (33779 - 546009 != -512229)
					{
						this.$mPos$31996 = mPos;
						if (226158 - 168401 == 57757)
						{
							this.$tDir$31997 = tDir;
							if (45958 - 318 != 45641)
							{
								this.$self_$31998 = self_;
								if (169793 - 19955 == 149838)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x008BC88C File Offset: 0x008BAA8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_nAttack$31984.$(this.$mPos$31996, this.$tDir$31997, this.$self_$31998);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x008BC8A8 File Offset: 0x008BAAA8
		internal static bool oO5FIH5KLrwSxne1QgCR()
		{
			return true;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x008BC8AC File Offset: 0x008BAAAC
		internal static bool F97eRs5KO0DQMpy30UGI()
		{
			return false;
		}

		// Token: 0x04005147 RID: 20807
		internal Vector3 $mPos$31996;

		// Token: 0x04005148 RID: 20808
		internal Vector3 $tDir$31997;

		// Token: 0x04005149 RID: 20809
		internal FirstWhale $self_$31998;

		// Token: 0x02000C2B RID: 3115
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045C7 RID: 17863 RVA: 0x008BC8B0 File Offset: 0x008BAAB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (159069 - 560710 != -401640)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163445 - 534904 != -371458)
					{
						base..ctor();
						if (24494 - 204370 == -179876)
						{
							this.$mPos$31993 = mPos;
							if (280326 - 478228 != -197901)
							{
								this.$tDir$31994 = tDir;
								if (143779 - 87056 != 56724)
								{
									this.$self_$31995 = self_;
									if (156784 - 279338 == -122554)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045C8 RID: 17864 RVA: 0x008BC98C File Offset: 0x008BAB8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281774 - 147600 != 134174)
				{
				}
				for (;;)
				{
					IL_633:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C38;
					case 2:
						if (this.$self_$31995.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_453;
						}
						if (120915 - 533574 != -412659)
						{
							continue;
						}
						if (this.$self_$31995.NuVKI3RVNT.myCommand != "nAttack")
						{
							if (299260 - 551727 != -252466)
							{
								goto Block_65;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (202306 - 376317 == -174010)
								{
									continue;
								}
								if (this.$self_$31995.nAttack_vc)
								{
									if (294674 - 158215 == 136460)
									{
										continue;
									}
									this.$self_$31995.audio.PlayOneShot(this.$self_$31995.nAttack_vc);
									if (145654 - 83710 != 61944)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing find nAttack voice");
									if (226791 - 547464 == -320672)
									{
										continue;
									}
								}
							}
							this.$fCount$31985 = 9;
							if (170445 - 248767 != -78321)
							{
								goto IL_6B9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31995.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_7A;
						}
						if (38998 - 110166 == -71167)
						{
							continue;
						}
						if (this.$self_$31995.NuVKI3RVNT.myCommand != "nAttack")
						{
							if (232112 - 519117 != -287005)
							{
								continue;
							}
							goto IL_7A;
						}
						else
						{
							this.$fCount$31985 += 3;
							if (149431 - 122406 != 27025)
							{
								continue;
							}
							goto IL_6B9;
						}
						break;
					case 4:
						if (this.$self_$31995.NuVKI3RVNT.actionState == "attack")
						{
							if (112372 - 549254 != -436882)
							{
								continue;
							}
							if (this.$self_$31995.NuVKI3RVNT.myCommand == "nAttack")
							{
								if (26035 - 245919 != -219884)
								{
									continue;
								}
								this.$self_$31995.NuVKI3RVNT.actionState = "standby";
								if (33303 - 415981 == -382677)
								{
									continue;
								}
								this.$self_$31995.NuVKI3RVNT.actionTime = Time.time;
								if (106417 - 70231 != 36186)
								{
									continue;
								}
								this.$self_$31995.NuVKI3RVNT.myCommand = "none";
								if (180866 - 433634 == -252767)
								{
									continue;
								}
								if (!this.$self_$31995.NuVKI3RVNT.isMine)
								{
									if (31497 - 129577 == -98079)
									{
										continue;
									}
									this.$self_$31995.NuVKI3RVNT.nPosition = this.$self_$31995.transform.position;
									if (34157 - 5893 != 28264)
									{
										continue;
									}
									this.$self_$31995.NuVKI3RVNT.oPosition = this.$self_$31995.transform.position;
									if (202599 - 372557 == -169957)
									{
										continue;
									}
									this.$self_$31995.NuVKI3RVNT.nDirection = this.$self_$31995.transform.forward;
									if (173241 - 102391 != 70850)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159774 - 417842 != -258067)
						{
							goto Block_54;
						}
						continue;
					default:
						if (214211 - 499731 != -285520)
						{
							continue;
						}
						break;
					}
					this.$self_$31995.NuVKI3RVNT.actionState = "attack";
					if (271633 - 21255 == 250379)
					{
						continue;
					}
					this.$self_$31995.NuVKI3RVNT.actionTime = Time.time;
					if (31274 - 388316 == -357041)
					{
						continue;
					}
					this.$self_$31995.NuVKI3RVNT.myCommand = "nAttack";
					if (262242 - 163317 == 98926)
					{
						continue;
					}
					this.$self_$31995.NuVKI3RVNT.addTimeOut("nAttack", (float)4);
					if (245771 - 118754 != 127017)
					{
						continue;
					}
					this.$self_$31995.transform.position = this.$mPos$31993;
					if (165749 - 339574 == -173824)
					{
						continue;
					}
					this.$self_$31995.transform.LookAt(this.$mPos$31993 + global::Math.vFlat(this.$tDir$31994));
					if (295858 - 574029 != -278171)
					{
						continue;
					}
					this.$self_$31995.animation.CrossFade("nAttack", 0.1f);
					if (12957 - 180298 == -167340)
					{
						continue;
					}
					this.$self_$31995.animation.wrapMode = WrapMode.Once;
					if (188489 - 521672 != -333183)
					{
						continue;
					}
					this.$self_$31995.NuVKI3RVNT.vMovement = this.$self_$31995.transform.forward;
					if (116324 - 5301 != 111023)
					{
						continue;
					}
					this.$self_$31995.NuVKI3RVNT.moveSpeed = (float)0;
					if (10259 - 281113 == -270853)
					{
						continue;
					}
					if (this.$self_$31995.nAttack_ring)
					{
						if (217638 - 433790 == -216151)
						{
							continue;
						}
						this.$self_$31995.NuVKI3RVNT.createEffect(this.$self_$31995.nAttack_ring, this.$self_$31995.transform.position, this.$self_$31995.transform.rotation);
						if (188031 - 393376 != -205344)
						{
							goto Block_10;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing nAttack ring effect");
						if (243060 - 486431 != -243371)
						{
							continue;
						}
						goto IL_278;
					}
					IL_6B9:
					if (this.$fCount$31985 > 90)
					{
						if (19723 - 264030 != -244306)
						{
							goto Block_47;
						}
					}
					else
					{
						if (!this.$self_$31995.NuVKI3RVNT.isMine)
						{
							goto IL_B3B;
						}
						if (162566 - 320211 != -157644)
						{
							this.$$switch$3594$31986 = this.$fCount$31985;
							if (119840 - 85604 == 34236)
							{
								if (this.$$switch$3594$31986 != 12)
								{
									if (3511 - 283568 == -280056)
									{
										continue;
									}
									if (this.$$switch$3594$31986 != 21)
									{
										if (38548 - 514595 == -476046)
										{
											continue;
										}
										if (this.$$switch$3594$31986 != 33)
										{
											if (241735 - 471811 == -230075)
											{
												continue;
											}
											if (this.$$switch$3594$31986 != 45)
											{
												if (185022 - 256925 == -71902)
												{
													continue;
												}
												if (this.$$switch$3594$31986 != 54)
												{
													if (172145 - 60898 != 111247)
													{
														continue;
													}
													if (this.$$switch$3594$31986 != 66)
													{
														if (258468 - 227439 != 31029)
														{
															continue;
														}
														if (this.$$switch$3594$31986 != 75)
														{
															if (299595 - 214019 != 85576)
															{
																continue;
															}
															if (this.$$switch$3594$31986 != 84)
															{
																goto IL_B3B;
															}
															if (245987 - 43892 == 202096)
															{
																continue;
															}
														}
													}
												}
											}
										}
									}
								}
								this.$hitLayer$31987 = 130816 - (1 << this.$self_$31995.gameObject.layer);
								if (111911 - 471655 == -359744)
								{
									this.$hitList$31988 = Damage.FindRecTarget(this.$self_$31995.transform.position + this.$self_$31995.transform.right, this.$self_$31995.transform.forward, (float)3, (float)2, (float)9, (float)6, this.$hitLayer$31987);
									if (97893 - 562985 != -465091)
									{
										this.$$iterator$10732$31992 = UnityRuntimeServices.GetEnumerator(this.$hitList$31988);
										if (134016 - 247153 == -113137)
										{
											while (this.$$iterator$10732$31992.MoveNext())
											{
												object obj2;
												object obj = obj2 = this.$$iterator$10732$31992.Current;
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												this.$hitObject$31989 = (GameObject)obj2;
												if (267936 - 274549 == -6612)
												{
													goto IL_633;
												}
												if (this.$self_$31995.NuVKI3RVNT.hit(1, this.$hitObject$31989, this.$self_$31995.NuVKI3RVNT.atk, 3, 0, Vector3.zero) != 0)
												{
													if (285037 - 23672 != 261365)
													{
														goto IL_633;
													}
													this.$hitChar$31990 = (CharacterControl)this.$hitObject$31989.GetComponent(typeof(CharacterControl));
													if (251037 - 598761 == -347723)
													{
														goto IL_633;
													}
													UnityRuntimeServices.Update(this.$$iterator$10732$31992, this.$hitObject$31989);
													if (72024 - 98925 == -26900)
													{
														goto IL_633;
													}
													if (this.$hitChar$31990)
													{
														if (105976 - 469369 == -363392)
														{
															goto IL_633;
														}
														this.$hitChar$31990.RPC_AddStatus("puncture", 4, 1, 0, this.$self_$31995.NuVKI3RVNT.ActorNr);
														if (227082 - 531304 == -304221)
														{
															goto IL_633;
														}
													}
													this.$hitPoint$31991 = this.$hitObject$31989.collider.ClosestPointOnBounds(this.$self_$31995.transform.position + (float)2 * Vector3.up);
													if (217731 - 186720 == 31012)
													{
														goto IL_633;
													}
													UnityRuntimeServices.Update(this.$$iterator$10732$31992, this.$hitObject$31989);
													if (296054 - 85321 == 210734)
													{
														goto IL_633;
													}
													this.$self_$31995.RPC_nAttack_hit(this.$hitPoint$31991, this.$self_$31995.transform.forward, 0);
													if (178296 - 274484 == -96187)
													{
														goto IL_633;
													}
													this.$self_$31995.ActionEvent("RPC_nAttack_hit", this.$hitPoint$31991, this.$self_$31995.transform.forward, 0);
													if (28537 - 407152 == -378614)
													{
														goto IL_633;
													}
												}
											}
											if (287546 - 143249 != 144298)
											{
												goto Block_57;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_7A:
				goto IL_C38;
				Block_10:
				IL_278:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_453:
				goto IL_C38;
				Block_47:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_54:
				goto IL_C38;
				Block_57:
				goto IL_B3B;
				Block_65:
				goto IL_453;
				IL_B3B:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_C38:
				return false;
			}

			// Token: 0x060045C9 RID: 17865 RVA: 0x008BD5E4 File Offset: 0x008BB7E4
			internal static bool f3TNN05KmhfYynN4OiU5()
			{
				return true;
			}

			// Token: 0x060045CA RID: 17866 RVA: 0x008BD5E8 File Offset: 0x008BB7E8
			internal static bool Dvebre5KF7fDLpqrpxIW()
			{
				return false;
			}

			// Token: 0x0400514A RID: 20810
			internal int $fCount$31985;

			// Token: 0x0400514B RID: 20811
			internal int $$switch$3594$31986;

			// Token: 0x0400514C RID: 20812
			internal int $hitLayer$31987;

			// Token: 0x0400514D RID: 20813
			internal UnityScript.Lang.Array $hitList$31988;

			// Token: 0x0400514E RID: 20814
			internal GameObject $hitObject$31989;

			// Token: 0x0400514F RID: 20815
			internal CharacterControl $hitChar$31990;

			// Token: 0x04005150 RID: 20816
			internal Vector3 $hitPoint$31991;

			// Token: 0x04005151 RID: 20817
			internal IEnumerator $$iterator$10732$31992;

			// Token: 0x04005152 RID: 20818
			internal Vector3 $mPos$31993;

			// Token: 0x04005153 RID: 20819
			internal Vector3 $tDir$31994;

			// Token: 0x04005154 RID: 20820
			internal FirstWhale $self_$31995;
		}
	}

	// Token: 0x02000C2C RID: 3116
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_javelin$31999 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045CB RID: 17867 RVA: 0x008BD5EC File Offset: 0x008BB7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_javelin$31999(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (78266 - 507132 != -428865)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77405 - 173817 != -96411)
				{
					base..ctor();
					if (130016 - 151555 == -21539)
					{
						this.$mPos$32015 = mPos;
						if (220147 - 150142 != 70006)
						{
							this.$tDir$32016 = tDir;
							if (152247 - 538460 != -386212)
							{
								this.$self_$32017 = self_;
								if (239231 - 65551 == 173680)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x008BD6C8 File Offset: 0x008BB8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_javelin$31999.$(this.$mPos$32015, this.$tDir$32016, this.$self_$32017);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x008BD6E4 File Offset: 0x008BB8E4
		internal static bool pb7Q4S5KMdx3sqwRDkpu()
		{
			return true;
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x008BD6E8 File Offset: 0x008BB8E8
		internal static bool rBMoeH5KxkSUqHAn5TNn()
		{
			return false;
		}

		// Token: 0x04005155 RID: 20821
		internal Vector3 $mPos$32015;

		// Token: 0x04005156 RID: 20822
		internal Vector3 $tDir$32016;

		// Token: 0x04005157 RID: 20823
		internal FirstWhale $self_$32017;

		// Token: 0x02000C2D RID: 3117
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045CF RID: 17871 RVA: 0x008BD6EC File Offset: 0x008BB8EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (219249 - 157797 != 61453)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31698 - 70776 == -39078)
					{
						base..ctor();
						if (92911 - 115432 == -22521)
						{
							this.$mPos$32012 = mPos;
							if (260133 - 498906 == -238773)
							{
								this.$tDir$32013 = tDir;
								if (59782 - 132307 == -72525)
								{
									this.$self_$32014 = self_;
									if (217960 - 353877 != -135916)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045D0 RID: 17872 RVA: 0x008BD7C8 File Offset: 0x008BB9C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115968 - 451768 != -335800)
				{
				}
				for (;;)
				{
					IL_885:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A85;
					case 2:
						if (this.$self_$32014.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_B6;
						}
						if (172255 - 232551 != -60296)
						{
							continue;
						}
						if (this.$self_$32014.NuVKI3RVNT.myCommand != "javelin")
						{
							if (1911 - 296897 != -294985)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mLanceTransform$32000 = global::Math.findChildObject(this.$self_$32014.gameObject.transform, "lance");
							if (208125 - 444739 != -236614)
							{
								continue;
							}
							this.$mLanceRendererList$32001 = null;
							if (286730 - 322452 != -35722)
							{
								continue;
							}
							if (this.$mLanceTransform$32000)
							{
								if (120366 - 588278 == -467911)
								{
									continue;
								}
								this.$mLanceRendererList$32001 = this.$mLanceTransform$32000.GetComponentsInChildren(typeof(MeshRenderer));
								if (111354 - 324219 != -212865)
								{
									continue;
								}
							}
							if (this.$mLanceRendererList$32001 != null)
							{
								if (246533 - 381729 != -135196)
								{
									continue;
								}
								this.$$11472$32006 = 0;
								if (17074 - 517677 != -500603)
								{
									continue;
								}
								this.$$11473$32007 = this.$mLanceRendererList$32001;
								if (39957 - 382061 != -342104)
								{
									continue;
								}
								this.$$11474$32008 = this.$$11473$32007.Length;
								if (221299 - 207188 == 14112)
								{
									continue;
								}
								while (this.$$11472$32006 < this.$$11474$32008)
								{
									((MeshRenderer)this.$$11473$32007[this.$$11472$32006]).enabled = false;
									if (152678 - 307671 != -154993)
									{
										goto IL_885;
									}
									this.$$11472$32006++;
									if (91803 - 310135 != -218332)
									{
										goto IL_885;
									}
								}
								if (207811 - 173522 == 34290)
								{
									continue;
								}
							}
							if (!this.$self_$32014.NuVKI3RVNT.isMine)
							{
								goto IL_4AE;
							}
							if (115622 - 286231 == -170608)
							{
								continue;
							}
							this.$firePos$32003 = this.$mPos$32012 + this.$self_$32014.transform.TransformDirection(new Vector3((float)3, (float)4, (float)3));
							if (75995 - 270418 == -194422)
							{
								continue;
							}
							this.$fireDir$32004 = global::Math.getTrajectoryVector(this.$firePos$32003, this.$mPos$32012 + this.$tDir$32013, (float)24);
							if (298916 - 267285 == 31632)
							{
								continue;
							}
							this.$self_$32014.RPC_javelin_fire(this.$firePos$32003, this.$fireDir$32004, 0);
							if (29938 - 292513 == -262574)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_4AE;
							}
							if (141724 - 2507 == 139218)
							{
								continue;
							}
							this.$self_$32014.ActionEvent("RPC_javelin_fire", this.$firePos$32003, this.$fireDir$32004, 0);
							if (46119 - 519008 != -472888)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 3:
						if (this.$mLanceRendererList$32001 != null)
						{
							if (154435 - 271710 == -117274)
							{
								continue;
							}
							this.$$11476$32009 = 0;
							if (46080 - 533849 == -487768)
							{
								continue;
							}
							this.$$11477$32010 = this.$mLanceRendererList$32001;
							if (166746 - 139278 != 27468)
							{
								continue;
							}
							this.$$11478$32011 = this.$$11477$32010.Length;
							if (114251 - 443837 != -329586)
							{
								continue;
							}
							while (this.$$11476$32009 < this.$$11478$32011)
							{
								((MeshRenderer)this.$$11477$32010[this.$$11476$32009]).enabled = true;
								if (56370 - 388017 != -331647)
								{
									goto IL_885;
								}
								this.$$11476$32009++;
								if (149693 - 371987 != -222294)
								{
									goto IL_885;
								}
							}
							if (1304 - 360247 == -358942)
							{
								continue;
							}
						}
						if (this.$self_$32014.NuVKI3RVNT.actionState == "attack")
						{
							if (59764 - 497728 != -437964)
							{
								continue;
							}
							if (this.$self_$32014.NuVKI3RVNT.myCommand == "javelin")
							{
								if (269227 - 100640 != 168587)
								{
									continue;
								}
								this.$self_$32014.NuVKI3RVNT.actionState = "standby";
								if (268338 - 555134 == -286795)
								{
									continue;
								}
								this.$self_$32014.NuVKI3RVNT.actionTime = Time.time;
								if (102845 - 258036 == -155190)
								{
									continue;
								}
								this.$self_$32014.NuVKI3RVNT.myCommand = "none";
								if (292360 - 430254 == -137893)
								{
									continue;
								}
								if (!this.$self_$32014.NuVKI3RVNT.isMine)
								{
									if (180621 - 438086 == -257464)
									{
										continue;
									}
									this.$self_$32014.NuVKI3RVNT.nPosition = this.$self_$32014.transform.position;
									if (18352 - 371841 != -353489)
									{
										continue;
									}
									this.$self_$32014.NuVKI3RVNT.oPosition = this.$self_$32014.transform.position;
									if (254294 - 372918 == -118623)
									{
										continue;
									}
									this.$self_$32014.NuVKI3RVNT.nDirection = this.$self_$32014.transform.forward;
									if (140705 - 216903 == -76197)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (292933 - 28871 != 264063)
						{
							goto Block_13;
						}
						continue;
					default:
						if (265188 - 104669 == 160520)
						{
							continue;
						}
						break;
					}
					this.$self_$32014.NuVKI3RVNT.actionState = "attack";
					if (197158 - 39839 == 157319)
					{
						this.$self_$32014.NuVKI3RVNT.actionTime = Time.time;
						if (25605 - 182111 != -156505)
						{
							this.$self_$32014.NuVKI3RVNT.myCommand = "javelin";
							if (30784 - 455550 == -424766)
							{
								this.$self_$32014.NuVKI3RVNT.addTimeOut("javelin", (float)6);
								if (135596 - 154008 != -18411)
								{
									this.$self_$32014.transform.position = this.$mPos$32012;
									if (37430 - 466140 != -428709)
									{
										this.$self_$32014.transform.LookAt(this.$mPos$32012 + global::Math.vFlat(this.$tDir$32013));
										if (254738 - 154466 != 100273)
										{
											this.$self_$32014.animation.CrossFade("javelin", 0.1f);
											if (5777 - 508760 == -502983)
											{
												this.$self_$32014.animation.wrapMode = WrapMode.Once;
												if (107484 - 108793 == -1309)
												{
													this.$self_$32014.NuVKI3RVNT.vMovement = this.$self_$32014.transform.forward;
													if (219302 - 79555 != 139748)
													{
														this.$self_$32014.NuVKI3RVNT.moveSpeed = (float)0;
														if (187011 - 145660 != 41352)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (106462 - 259902 != -153440)
																{
																	continue;
																}
																if (this.$self_$32014.javelin_vc)
																{
																	if (256348 - 172363 == 83986)
																	{
																		continue;
																	}
																	this.$self_$32014.audio.PlayOneShot(this.$self_$32014.javelin_vc);
																	if (9023 - 516496 == -507472)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing find javelin voice");
																	if (281936 - 260921 != 21015)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32014.javelin_ring)
															{
																if (292835 - 392327 != -99491)
																{
																	this.$self_$32014.NuVKI3RVNT.createEffect(this.$self_$32014.javelin_ring, this.$self_$32014.transform.position, this.$self_$32014.transform.rotation);
																	if (82614 - 394084 != -311469)
																	{
																		goto Block_38;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing javelin ring effect");
																if (263388 - 219564 != 43825)
																{
																	goto Block_64;
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
				IL_B6:
				Block_13:
				goto IL_A85;
				IL_350:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_27:
				goto IL_B6;
				IL_4AE:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_38:
				goto IL_350;
				Block_56:
				goto IL_4AE;
				Block_64:
				goto IL_350;
				IL_A85:
				return false;
			}

			// Token: 0x060045D1 RID: 17873 RVA: 0x008BE26C File Offset: 0x008BC46C
			internal static bool asg1ZQ5Kg8DJ3oqgCeqc()
			{
				return true;
			}

			// Token: 0x060045D2 RID: 17874 RVA: 0x008BE270 File Offset: 0x008BC470
			internal static bool eVC1pj5KfvwYOOsOWpCO()
			{
				return false;
			}

			// Token: 0x04005158 RID: 20824
			internal Transform $mLanceTransform$32000;

			// Token: 0x04005159 RID: 20825
			internal Component[] $mLanceRendererList$32001;

			// Token: 0x0400515A RID: 20826
			internal MeshRenderer $mLanceRendererer$32002;

			// Token: 0x0400515B RID: 20827
			internal Vector3 $firePos$32003;

			// Token: 0x0400515C RID: 20828
			internal Vector3 $fireDir$32004;

			// Token: 0x0400515D RID: 20829
			internal MeshRenderer $mLanceRendererer$32005;

			// Token: 0x0400515E RID: 20830
			internal int $$11472$32006;

			// Token: 0x0400515F RID: 20831
			internal Component[] $$11473$32007;

			// Token: 0x04005160 RID: 20832
			internal int $$11474$32008;

			// Token: 0x04005161 RID: 20833
			internal int $$11476$32009;

			// Token: 0x04005162 RID: 20834
			internal Component[] $$11477$32010;

			// Token: 0x04005163 RID: 20835
			internal int $$11478$32011;

			// Token: 0x04005164 RID: 20836
			internal Vector3 $mPos$32012;

			// Token: 0x04005165 RID: 20837
			internal Vector3 $tDir$32013;

			// Token: 0x04005166 RID: 20838
			internal FirstWhale $self_$32014;
		}
	}

	// Token: 0x02000C2E RID: 3118
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_javelin_hit$32018 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045D3 RID: 17875 RVA: 0x008BE274 File Offset: 0x008BC474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_javelin_hit$32018(Vector3 hitPos, FirstWhale self_)
		{
			if (41453 - 496806 != -455352)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279277 - 112989 == 166288)
				{
					base..ctor();
					if (63931 - 220909 != -156977)
					{
						this.$hitPos$32029 = hitPos;
						if (44180 - 233184 == -189004)
						{
							this.$self_$32030 = self_;
							if (205619 - 39178 != 166442)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x008BE330 File Offset: 0x008BC530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_javelin_hit$32018.$(this.$hitPos$32029, this.$self_$32030);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x008BE344 File Offset: 0x008BC544
		internal static bool s9SFhH5Knf4LYl0eQE7U()
		{
			return true;
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x008BE348 File Offset: 0x008BC548
		internal static bool MT82445K6nvafnwaOvv6()
		{
			return false;
		}

		// Token: 0x04005167 RID: 20839
		internal Vector3 $hitPos$32029;

		// Token: 0x04005168 RID: 20840
		internal FirstWhale $self_$32030;

		// Token: 0x02000C2F RID: 3119
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045D7 RID: 17879 RVA: 0x008BE34C File Offset: 0x008BC54C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, FirstWhale self_)
			{
				if (92971 - 135196 != -42224)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20768 - 564641 != -543872)
					{
						base..ctor();
						if (44818 - 564051 == -519233)
						{
							this.$hitPos$32027 = hitPos;
							if (140621 - 392014 != -251392)
							{
								this.$self_$32028 = self_;
								if (190008 - 106386 != 83623)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060045D8 RID: 17880 RVA: 0x008BE408 File Offset: 0x008BC608
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193785 - 30451 != 163334)
				{
				}
				for (;;)
				{
					IL_11E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4A8;
					case 2:
						this.$i$32019++;
						if (210648 - 268024 != -57375)
						{
							goto IL_367;
						}
						continue;
					default:
						if (281718 - 442903 == -161184)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32028.javelin_hit)
					{
						if (263065 - 82236 == 180830)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$32028.javelin_hit, this.$hitPos$32027, Quaternion.identity);
						if (133253 - 182614 == -49360)
						{
							continue;
						}
					}
					if (this.$self_$32028.NuVKI3RVNT.isMine)
					{
						if (3433 - 523199 != -519766)
						{
							continue;
						}
						this.$i$32019 = 0;
						if (49671 - 209932 != -160261)
						{
							continue;
						}
						goto IL_367;
					}
					IL_345:
					this.YieldDefault(1);
					if (98018 - 473155 != -375137)
					{
						continue;
					}
					goto IL_4A8;
					IL_367:
					if (this.$i$32019 >= 2)
					{
						if (153090 - 127798 == 25292)
						{
							goto IL_345;
						}
					}
					else
					{
						this.$hitLayer$32020 = 130816 - (1 << this.$self_$32028.gameObject.layer);
						if (195550 - 363342 != -167791)
						{
							this.$hitList$32021 = Damage.FindAreaTarget(this.$hitPos$32027, (float)(7 + 2 * this.$i$32019), (float)3, this.$hitLayer$32020);
							if (205394 - 590701 != -385306)
							{
								this.$hitDmg$32022 = 2 * this.$self_$32028.NuVKI3RVNT.atk + this.$self_$32028.NuVKI3RVNT.talAdjust(30);
								if (136244 - 568076 != -431831)
								{
									this.$$iterator$10733$32026 = UnityRuntimeServices.GetEnumerator(this.$hitList$32021);
									if (125888 - 17047 != 108842)
									{
										while (this.$$iterator$10733$32026.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10733$32026.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$32023 = (GameObject)obj2;
											if (280439 - 529589 != -249150)
											{
												goto IL_11E;
											}
											this.$hitMagnitude$32024 = (float)1 - 0.5f * (global::Math.vFlat(this.$hitObject$32023.transform.position - this.$hitPos$32027).magnitude / (float)(7 + 2 * this.$i$32019));
											if (51288 - 417802 != -366514)
											{
												goto IL_11E;
											}
											UnityRuntimeServices.Update(this.$$iterator$10733$32026, this.$hitObject$32023);
											if (88326 - 154481 != -66155)
											{
												goto IL_11E;
											}
											if (this.$self_$32028.NuVKI3RVNT.hit(2, this.$hitObject$32023, (int)(this.$hitMagnitude$32024 * (float)this.$hitDmg$32022), 3, 0, (this.$hitObject$32023.transform.position - this.$hitPos$32027).normalized) != 0)
											{
												if (168107 - 149017 != 19090)
												{
													goto IL_11E;
												}
												this.$hitChar$32025 = (CharacterControl)this.$hitObject$32023.GetComponent(typeof(CharacterControl));
												if (10910 - 64108 == -53197)
												{
													goto IL_11E;
												}
												UnityRuntimeServices.Update(this.$$iterator$10733$32026, this.$hitObject$32023);
												if (216067 - 473496 != -257429)
												{
													goto IL_11E;
												}
												if (this.$hitChar$32025)
												{
													if (53172 - 341903 == -288730)
													{
														goto IL_11E;
													}
													this.$hitChar$32025.RPC_AddStatus("puncture", 4, 1, 0, this.$self_$32028.NuVKI3RVNT.ActorNr);
													if (65911 - 545782 == -479870)
													{
														goto IL_11E;
													}
												}
											}
										}
										if (245518 - 69095 != 176424)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_4A8:
				return false;
			}

			// Token: 0x060045D9 RID: 17881 RVA: 0x008BE8D0 File Offset: 0x008BCAD0
			internal static bool q1if075KioBkUs0os97I()
			{
				return true;
			}

			// Token: 0x060045DA RID: 17882 RVA: 0x008BE8D4 File Offset: 0x008BCAD4
			internal static bool F4Xgbs5KKqHK1di4VMjy()
			{
				return false;
			}

			// Token: 0x04005169 RID: 20841
			internal int $i$32019;

			// Token: 0x0400516A RID: 20842
			internal int $hitLayer$32020;

			// Token: 0x0400516B RID: 20843
			internal UnityScript.Lang.Array $hitList$32021;

			// Token: 0x0400516C RID: 20844
			internal int $hitDmg$32022;

			// Token: 0x0400516D RID: 20845
			internal GameObject $hitObject$32023;

			// Token: 0x0400516E RID: 20846
			internal float $hitMagnitude$32024;

			// Token: 0x0400516F RID: 20847
			internal CharacterControl $hitChar$32025;

			// Token: 0x04005170 RID: 20848
			internal IEnumerator $$iterator$10733$32026;

			// Token: 0x04005171 RID: 20849
			internal Vector3 $hitPos$32027;

			// Token: 0x04005172 RID: 20850
			internal FirstWhale $self_$32028;
		}
	}

	// Token: 0x02000C30 RID: 3120
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sweep$32031 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045DB RID: 17883 RVA: 0x008BE8D8 File Offset: 0x008BCAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sweep$32031(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (78641 - 66076 != 12565)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129545 - 579367 != -449821)
				{
					base..ctor();
					if (102283 - 237821 != -135537)
					{
						this.$mPos$32041 = mPos;
						if (1222 - 53035 != -51812)
						{
							this.$tDir$32042 = tDir;
							if (94156 - 23189 == 70967)
							{
								this.$self_$32043 = self_;
								if (258658 - 176793 != 81866)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x008BE9B4 File Offset: 0x008BCBB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_sweep$32031.$(this.$mPos$32041, this.$tDir$32042, this.$self_$32043);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x008BE9D0 File Offset: 0x008BCBD0
		internal static bool T9btKl5KdG9EPoiEi0hX()
		{
			return true;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x008BE9D4 File Offset: 0x008BCBD4
		internal static bool IKcwpC5KJVyFsBACXP8T()
		{
			return false;
		}

		// Token: 0x04005173 RID: 20851
		internal Vector3 $mPos$32041;

		// Token: 0x04005174 RID: 20852
		internal Vector3 $tDir$32042;

		// Token: 0x04005175 RID: 20853
		internal FirstWhale $self_$32043;

		// Token: 0x02000C31 RID: 3121
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045DF RID: 17887 RVA: 0x008BE9D8 File Offset: 0x008BCBD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (199374 - 584148 != -384774)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83424 - 595138 != -511713)
					{
						base..ctor();
						if (260431 - 61904 == 198527)
						{
							this.$mPos$32038 = mPos;
							if (146217 - 156144 == -9927)
							{
								this.$tDir$32039 = tDir;
								if (228789 - 344912 != -116122)
								{
									this.$self_$32040 = self_;
									if (8444 - 61305 != -52860)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045E0 RID: 17888 RVA: 0x008BEAB4 File Offset: 0x008BCCB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39675 - 204616 != -164940)
				{
				}
				for (;;)
				{
					IL_1B9:
					switch (this._state)
					{
					case 0:
						goto IL_4E6;
					case 1:
						goto IL_9F0;
					case 2:
						if (this.$self_$32040.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_439;
						}
						if (173138 - 276718 == -103579)
						{
							continue;
						}
						if (this.$self_$32040.NuVKI3RVNT.myCommand != "sweep")
						{
							if (131820 - 52172 != 79649)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$i$32032 = 0;
							if (89513 - 509726 != -420213)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32040.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_F7;
						}
						if (159675 - 434093 == -274417)
						{
							continue;
						}
						if (this.$self_$32040.NuVKI3RVNT.myCommand != "sweep")
						{
							if (42721 - 379273 != -336552)
							{
								continue;
							}
							goto IL_F7;
						}
						else
						{
							this.$i$32032++;
							if (42934 - 389041 != -346107)
							{
								continue;
							}
						}
						break;
					default:
						if (69555 - 456544 != -386988)
						{
							goto IL_4E6;
						}
						continue;
					}
					if (this.$i$32032 >= 2)
					{
						if (65632 - 11812 != 53820)
						{
							continue;
						}
						if (this.$self_$32040.NuVKI3RVNT.actionState == "attack")
						{
							if (196714 - 344581 == -147866)
							{
								continue;
							}
							if (this.$self_$32040.NuVKI3RVNT.myCommand == "sweep")
							{
								if (62373 - 273874 != -211501)
								{
									continue;
								}
								this.$self_$32040.NuVKI3RVNT.actionState = "standby";
								if (138745 - 332182 != -193437)
								{
									continue;
								}
								this.$self_$32040.NuVKI3RVNT.actionTime = Time.time;
								if (115649 - 146509 == -30859)
								{
									continue;
								}
								this.$self_$32040.NuVKI3RVNT.myCommand = "none";
								if (17476 - 555377 == -537900)
								{
									continue;
								}
								if (!this.$self_$32040.NuVKI3RVNT.isMine)
								{
									if (184960 - 519834 != -334874)
									{
										continue;
									}
									this.$self_$32040.NuVKI3RVNT.nPosition = this.$self_$32040.transform.position;
									if (127728 - 211650 != -83922)
									{
										continue;
									}
									this.$self_$32040.NuVKI3RVNT.oPosition = this.$self_$32040.transform.position;
									if (212113 - 107653 != 104460)
									{
										continue;
									}
									this.$self_$32040.NuVKI3RVNT.nDirection = this.$self_$32040.transform.forward;
									if (165681 - 148334 == 17348)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (110160 - 517565 != -407404)
						{
							goto IL_9F0;
						}
						continue;
					}
					else
					{
						if (!this.$self_$32040.NuVKI3RVNT.isMine)
						{
							break;
						}
						if (250232 - 325198 != -74966)
						{
							continue;
						}
						this.$hitLayer$32033 = 130816 - (1 << this.$self_$32040.gameObject.layer);
						if (195997 - 119966 != 76031)
						{
							continue;
						}
						this.$hitList$32034 = Damage.FindAreaTarget(this.$mPos$32038, (float)9, (float)3, this.$hitLayer$32033);
						if (251333 - 271553 != -20220)
						{
							continue;
						}
						this.$$iterator$10734$32037 = UnityRuntimeServices.GetEnumerator(this.$hitList$32034);
						if (284666 - 525581 == -240914)
						{
							continue;
						}
						while (this.$$iterator$10734$32037.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10734$32037.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$32035 = (GameObject)obj2;
							if (150111 - 75149 == 74963)
							{
								goto IL_1B9;
							}
							if (this.$self_$32040.NuVKI3RVNT.hit(11, this.$hitObject$32035, 2 * this.$self_$32040.NuVKI3RVNT.atk + this.$self_$32040.NuVKI3RVNT.talAdjust(30), 10, 0, (this.$hitObject$32035.transform.position - this.$mPos$32038).normalized) != 0)
							{
								if (280105 - 406937 == -126831)
								{
									goto IL_1B9;
								}
								this.$hitPoint$32036 = this.$hitObject$32035.collider.ClosestPointOnBounds(this.$self_$32040.transform.position + (float)2 * Vector3.up);
								if (107675 - 309718 == -202042)
								{
									goto IL_1B9;
								}
								UnityRuntimeServices.Update(this.$$iterator$10734$32037, this.$hitObject$32035);
								if (44010 - 261649 == -217638)
								{
									goto IL_1B9;
								}
								this.$self_$32040.RPC_nAttack_hit(this.$hitPoint$32036, this.$self_$32040.transform.forward, 0);
								if (293491 - 404497 != -111006)
								{
									goto IL_1B9;
								}
								this.$self_$32040.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32036, this.$self_$32040.transform.forward, 0);
								if (77486 - 97867 != -20381)
								{
									goto IL_1B9;
								}
							}
						}
						if (157575 - 143894 != 13682)
						{
							break;
						}
						continue;
					}
					IL_4E6:
					this.$self_$32040.NuVKI3RVNT.actionState = "attack";
					if (277863 - 4731 == 273132)
					{
						this.$self_$32040.NuVKI3RVNT.actionTime = Time.time;
						if (163870 - 314465 == -150595)
						{
							this.$self_$32040.NuVKI3RVNT.myCommand = "sweep";
							if (238207 - 563005 == -324798)
							{
								this.$self_$32040.NuVKI3RVNT.addTimeOut("sweep", (float)12);
								if (6521 - 543573 != -537051)
								{
									this.$self_$32040.transform.position = this.$mPos$32038;
									if (36930 - 370967 == -334037)
									{
										this.$self_$32040.transform.LookAt(this.$mPos$32038 + global::Math.vFlat(this.$tDir$32039));
										if (11538 - 27609 != -16070)
										{
											this.$self_$32040.animation.CrossFade("sweep", 0.1f);
											if (4256 - 485622 == -481366)
											{
												this.$self_$32040.animation.wrapMode = WrapMode.Once;
												if (298033 - 569873 == -271840)
												{
													this.$self_$32040.NuVKI3RVNT.vMovement = this.$self_$32040.transform.forward;
													if (226888 - 404275 == -177387)
													{
														this.$self_$32040.NuVKI3RVNT.moveSpeed = (float)0;
														if (165203 - 394707 != -229503)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (249227 - 343000 != -93773)
																{
																	continue;
																}
																if (this.$self_$32040.sweep_vc)
																{
																	if (276589 - 217289 == 59301)
																	{
																		continue;
																	}
																	this.$self_$32040.audio.PlayOneShot(this.$self_$32040.sweep_vc);
																	if (208204 - 269402 == -61197)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing find sweep voice");
																	if (122274 - 300498 != -178224)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32040.sweep_ring)
															{
																if (192076 - 266314 != -74237)
																{
																	this.$self_$32040.NuVKI3RVNT.createEffect(this.$self_$32040.sweep_ring, this.$self_$32040.transform.position, this.$self_$32040.transform.rotation);
																	if (229360 - 215630 != 13731)
																	{
																		goto Block_50;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing sweep ring effect");
																if (41421 - 86484 != -45062)
																{
																	goto Block_40;
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
				goto IL_3EA;
				IL_F7:
				Block_28:
				goto IL_439;
				IL_3EA:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_439:
				goto IL_9F0;
				Block_40:
				IL_682:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_50:
				goto IL_682;
				IL_9F0:
				return false;
			}

			// Token: 0x060045E1 RID: 17889 RVA: 0x008BF4C4 File Offset: 0x008BD6C4
			internal static bool Y7cwmR5KDiIgEYqSt800()
			{
				return true;
			}

			// Token: 0x060045E2 RID: 17890 RVA: 0x008BF4C8 File Offset: 0x008BD6C8
			internal static bool XydOWx5Kvwml3Ugjhukt()
			{
				return false;
			}

			// Token: 0x04005176 RID: 20854
			internal int $i$32032;

			// Token: 0x04005177 RID: 20855
			internal int $hitLayer$32033;

			// Token: 0x04005178 RID: 20856
			internal UnityScript.Lang.Array $hitList$32034;

			// Token: 0x04005179 RID: 20857
			internal GameObject $hitObject$32035;

			// Token: 0x0400517A RID: 20858
			internal Vector3 $hitPoint$32036;

			// Token: 0x0400517B RID: 20859
			internal IEnumerator $$iterator$10734$32037;

			// Token: 0x0400517C RID: 20860
			internal Vector3 $mPos$32038;

			// Token: 0x0400517D RID: 20861
			internal Vector3 $tDir$32039;

			// Token: 0x0400517E RID: 20862
			internal FirstWhale $self_$32040;
		}
	}

	// Token: 0x02000C32 RID: 3122
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stomp$32044 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045E3 RID: 17891 RVA: 0x008BF4CC File Offset: 0x008BD6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stomp$32044(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (58416 - 15823 != 42593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212173 - 184129 != 28045)
				{
					base..ctor();
					if (94751 - 323923 != -229171)
					{
						this.$mPos$32052 = mPos;
						if (296025 - 289085 == 6940)
						{
							this.$tDir$32053 = tDir;
							if (163261 - 394274 != -231012)
							{
								this.$self_$32054 = self_;
								if (153370 - 333692 != -180321)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x008BF5A8 File Offset: 0x008BD7A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_stomp$32044.$(this.$mPos$32052, this.$tDir$32053, this.$self_$32054);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x008BF5C4 File Offset: 0x008BD7C4
		internal static bool aJ95UO5KR4uKZsl4AQUj()
		{
			return true;
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x008BF5C8 File Offset: 0x008BD7C8
		internal static bool IMUv3H5KwWywPuS5Lotl()
		{
			return false;
		}

		// Token: 0x0400517F RID: 20863
		internal Vector3 $mPos$32052;

		// Token: 0x04005180 RID: 20864
		internal Vector3 $tDir$32053;

		// Token: 0x04005181 RID: 20865
		internal FirstWhale $self_$32054;

		// Token: 0x02000C33 RID: 3123
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045E7 RID: 17895 RVA: 0x008BF5CC File Offset: 0x008BD7CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (195787 - 335668 != -139880)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154401 - 430152 == -275751)
					{
						base..ctor();
						if (167252 - 15639 == 151613)
						{
							this.$mPos$32049 = mPos;
							if (22478 - 212391 == -189913)
							{
								this.$tDir$32050 = tDir;
								if (184158 - 594528 != -410369)
								{
									this.$self_$32051 = self_;
									if (83088 - 553019 != -469930)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045E8 RID: 17896 RVA: 0x008BF6A8 File Offset: 0x008BD8A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179412 - 212224 != -32811)
				{
				}
				for (;;)
				{
					IL_2B4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DE;
					case 2:
						if (this.$self_$32051.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_880;
						}
						if (284232 - 370562 != -86330)
						{
							continue;
						}
						if (this.$self_$32051.NuVKI3RVNT.myCommand != "stomp")
						{
							if (272456 - 153553 != 118904)
							{
								goto Block_48;
							}
							continue;
						}
						else if (this.$self_$32051.stomp_ring)
						{
							if (217419 - 396605 == -179185)
							{
								continue;
							}
							this.$self_$32051.NuVKI3RVNT.createEffect(this.$self_$32051.stomp_ring, this.$self_$32051.transform.position, this.$self_$32051.transform.rotation);
							if (175531 - 43025 != 132506)
							{
								continue;
							}
							goto IL_7FB;
						}
						else
						{
							Debug.LogError("Missing stomp ring effect");
							if (211512 - 249426 != -37913)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32051.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_78A;
						}
						if (294115 - 384334 != -90219)
						{
							continue;
						}
						if (this.$self_$32051.NuVKI3RVNT.myCommand != "stomp")
						{
							if (296173 - 496074 != -199901)
							{
								continue;
							}
							goto IL_78A;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 1f);
							if (159631 - 348411 != -188780)
							{
								continue;
							}
							if (this.$self_$32051.NuVKI3RVNT.isMine)
							{
								if (130032 - 209063 == -79030)
								{
									continue;
								}
								this.$hitLayer$32045 = 130816 - (1 << this.$self_$32051.gameObject.layer);
								if (289108 - 94209 != 194899)
								{
									continue;
								}
								this.$hitList$32046 = Damage.FindAreaTarget(this.$mPos$32049, (float)50, (float)10, this.$hitLayer$32045);
								if (45835 - 280747 != -234912)
								{
									continue;
								}
								this.$$iterator$10735$32048 = UnityRuntimeServices.GetEnumerator(this.$hitList$32046);
								if (221844 - 292437 != -70593)
								{
									continue;
								}
								while (this.$$iterator$10735$32048.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10735$32048.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$32047 = (GameObject)obj2;
									if (281610 - 132018 == 149593)
									{
										goto IL_2B4;
									}
									this.$self_$32051.NuVKI3RVNT.hit(21, this.$hitObject$32047, 2 * this.$self_$32051.NuVKI3RVNT.atk + this.$self_$32051.NuVKI3RVNT.talAdjust(80), 40, 0, (this.$hitObject$32047.transform.position - this.$mPos$32049).normalized);
									if (289010 - 263240 == 25771)
									{
										goto IL_2B4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10735$32048, this.$hitObject$32047);
									if (225331 - 480071 != -254740)
									{
										goto IL_2B4;
									}
								}
								if (248778 - 202149 == 46630)
								{
									continue;
								}
							}
							if (this.$self_$32051.NuVKI3RVNT.actionState == "attack")
							{
								if (33884 - 362981 == -329096)
								{
									continue;
								}
								if (this.$self_$32051.NuVKI3RVNT.myCommand == "stomp")
								{
									if (69284 - 276670 != -207386)
									{
										continue;
									}
									this.$self_$32051.NuVKI3RVNT.actionState = "standby";
									if (159845 - 169817 == -9971)
									{
										continue;
									}
									this.$self_$32051.NuVKI3RVNT.actionTime = Time.time;
									if (248164 - 253783 == -5618)
									{
										continue;
									}
									this.$self_$32051.NuVKI3RVNT.myCommand = "none";
									if (4412 - 567999 != -563587)
									{
										continue;
									}
									if (!this.$self_$32051.NuVKI3RVNT.isMine)
									{
										if (231620 - 542031 != -310411)
										{
											continue;
										}
										this.$self_$32051.NuVKI3RVNT.nPosition = this.$self_$32051.transform.position;
										if (146965 - 325049 != -178084)
										{
											continue;
										}
										this.$self_$32051.NuVKI3RVNT.oPosition = this.$self_$32051.transform.position;
										if (229920 - 565485 == -335564)
										{
											continue;
										}
										this.$self_$32051.NuVKI3RVNT.nDirection = this.$self_$32051.transform.forward;
										if (8375 - 198470 != -190095)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (271575 - 482329 != -210754)
							{
								continue;
							}
							goto IL_8DE;
						}
						break;
					default:
						if (133192 - 80360 != 52832)
						{
							continue;
						}
						break;
					}
					this.$self_$32051.NuVKI3RVNT.actionState = "attack";
					if (2313 - 119295 != -116981)
					{
						this.$self_$32051.NuVKI3RVNT.actionTime = Time.time;
						if (149702 - 426111 != -276408)
						{
							this.$self_$32051.NuVKI3RVNT.myCommand = "stomp";
							if (168133 - 23136 == 144997)
							{
								this.$self_$32051.NuVKI3RVNT.addTimeOut("stomp", (float)15);
								if (78567 - 14734 == 63833)
								{
									this.$self_$32051.transform.position = this.$mPos$32049;
									if (123117 - 262654 == -139537)
									{
										this.$self_$32051.transform.LookAt(this.$mPos$32049 + global::Math.vFlat(this.$tDir$32050));
										if (257527 - 471622 != -214094)
										{
											this.$self_$32051.animation.CrossFade("stomp", 0.1f);
											if (265919 - 126385 != 139535)
											{
												this.$self_$32051.animation.wrapMode = WrapMode.Once;
												if (30469 - 408771 != -378301)
												{
													this.$self_$32051.NuVKI3RVNT.vMovement = this.$self_$32051.transform.forward;
													if (160856 - 343573 == -182717)
													{
														this.$self_$32051.NuVKI3RVNT.moveSpeed = (float)0;
														if (40232 - 428782 != -388549)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_51F;
															}
															if (5613 - 333158 == -327545)
															{
																if (this.$self_$32051.stomp_vc)
																{
																	if (48972 - 296137 == -247165)
																	{
																		this.$self_$32051.audio.PlayOneShot(this.$self_$32051.stomp_vc);
																		if (123100 - 39753 == 83347)
																		{
																			goto IL_3A8;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing find stomp voice");
																	if (49406 - 66111 == -16705)
																	{
																		goto IL_51F;
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
				IL_15F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_3A8:
				IL_51F:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_78A:
				Block_48:
				goto IL_880;
				IL_7FB:
				Block_49:
				goto IL_15F;
				IL_880:
				IL_8DE:
				return false;
			}

			// Token: 0x060045E9 RID: 17897 RVA: 0x008BFFA8 File Offset: 0x008BE1A8
			internal static bool iLUvNg5Kq2GPd99C6uIL()
			{
				return true;
			}

			// Token: 0x060045EA RID: 17898 RVA: 0x008BFFAC File Offset: 0x008BE1AC
			internal static bool lMW5Rl5K7kVEcAnKRuuF()
			{
				return false;
			}

			// Token: 0x04005182 RID: 20866
			internal int $hitLayer$32045;

			// Token: 0x04005183 RID: 20867
			internal UnityScript.Lang.Array $hitList$32046;

			// Token: 0x04005184 RID: 20868
			internal GameObject $hitObject$32047;

			// Token: 0x04005185 RID: 20869
			internal IEnumerator $$iterator$10735$32048;

			// Token: 0x04005186 RID: 20870
			internal Vector3 $mPos$32049;

			// Token: 0x04005187 RID: 20871
			internal Vector3 $tDir$32050;

			// Token: 0x04005188 RID: 20872
			internal FirstWhale $self_$32051;
		}
	}

	// Token: 0x02000C34 RID: 3124
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_damageBounce$32055 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045EB RID: 17899 RVA: 0x008BFFB0 File Offset: 0x008BE1B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_damageBounce$32055(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (295203 - 431953 != -136750)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97468 - 548062 == -450594)
				{
					base..ctor();
					if (221647 - 330901 != -109253)
					{
						this.$mPos$32059 = mPos;
						if (181637 - 137823 == 43814)
						{
							this.$tDir$32060 = tDir;
							if (90120 - 105154 == -15034)
							{
								this.$self_$32061 = self_;
								if (167514 - 589139 != -421624)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x008C008C File Offset: 0x008BE28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_damageBounce$32055.$(this.$mPos$32059, this.$tDir$32060, this.$self_$32061);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x008C00A8 File Offset: 0x008BE2A8
		internal static bool wZkdYT5KPXdsi6bgWgMy()
		{
			return true;
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x008C00AC File Offset: 0x008BE2AC
		internal static bool DWhKor5K0n4pxZWpRFc8()
		{
			return false;
		}

		// Token: 0x04005189 RID: 20873
		internal Vector3 $mPos$32059;

		// Token: 0x0400518A RID: 20874
		internal Vector3 $tDir$32060;

		// Token: 0x0400518B RID: 20875
		internal FirstWhale $self_$32061;

		// Token: 0x02000C35 RID: 3125
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045EF RID: 17903 RVA: 0x008C00B0 File Offset: 0x008BE2B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (214786 - 264724 != -49937)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45255 - 501914 == -456659)
					{
						base..ctor();
						if (70278 - 554568 != -484289)
						{
							this.$mPos$32056 = mPos;
							if (156449 - 291591 != -135141)
							{
								this.$tDir$32057 = tDir;
								if (178181 - 63679 != 114503)
								{
									this.$self_$32058 = self_;
									if (175530 - 261254 != -85723)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045F0 RID: 17904 RVA: 0x008C018C File Offset: 0x008BE38C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52242 - 206328 != -154086)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6A1;
					case 2:
						if (this.$self_$32058.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_45;
						}
						if (856 - 368054 == -367197)
						{
							continue;
						}
						if (this.$self_$32058.NuVKI3RVNT.myCommand != "damageBounce")
						{
							if (170491 - 171514 != -1022)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$32058.NuVKI3RVNT.StartCoroutine_Auto(this.$self_$32058.NuVKI3RVNT.addStatus("reflect", 1, (int)4.5f, 0, this.$self_$32058.NuVKI3RVNT.ActorNr));
							if (201314 - 524970 != -323656)
							{
								continue;
							}
							if (this.$self_$32058.damageBounce_ring)
							{
								if (273689 - 29501 != 244188)
								{
									continue;
								}
								this.$self_$32058.NuVKI3RVNT.createEffect(this.$self_$32058.damageBounce_ring, this.$self_$32058.transform.position, this.$self_$32058.transform.rotation);
								if (282817 - 289101 != -6283)
								{
									goto Block_31;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing damageBounce ring effect");
								if (149300 - 142792 != 6508)
								{
									continue;
								}
								goto IL_572;
							}
						}
						break;
					case 3:
						if (this.$self_$32058.NuVKI3RVNT.actionState == "attack")
						{
							if (236707 - 335511 != -98804)
							{
								continue;
							}
							if (this.$self_$32058.NuVKI3RVNT.myCommand == "damageBounce")
							{
								if (52733 - 22372 != 30361)
								{
									continue;
								}
								this.$self_$32058.NuVKI3RVNT.actionState = "standby";
								if (60626 - 530135 != -469509)
								{
									continue;
								}
								this.$self_$32058.NuVKI3RVNT.actionTime = Time.time;
								if (131057 - 440980 != -309923)
								{
									continue;
								}
								this.$self_$32058.NuVKI3RVNT.myCommand = "none";
								if (104218 - 359798 != -255580)
								{
									continue;
								}
								if (!this.$self_$32058.NuVKI3RVNT.isMine)
								{
									if (109149 - 271150 == -162000)
									{
										continue;
									}
									this.$self_$32058.NuVKI3RVNT.nPosition = this.$self_$32058.transform.position;
									if (234791 - 426148 != -191357)
									{
										continue;
									}
									this.$self_$32058.NuVKI3RVNT.oPosition = this.$self_$32058.transform.position;
									if (244956 - 484508 == -239551)
									{
										continue;
									}
									this.$self_$32058.NuVKI3RVNT.nDirection = this.$self_$32058.transform.forward;
									if (78029 - 408734 != -330705)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (114223 - 335057 != -220834)
						{
							continue;
						}
						goto IL_6A1;
					default:
						if (133394 - 598545 == -465150)
						{
							continue;
						}
						break;
					}
					this.$self_$32058.NuVKI3RVNT.actionState = "attack";
					if (231625 - 54698 == 176927)
					{
						this.$self_$32058.NuVKI3RVNT.actionTime = Time.time;
						if (74741 - 453853 == -379112)
						{
							this.$self_$32058.NuVKI3RVNT.myCommand = "damageBounce";
							if (108322 - 207276 != -98953)
							{
								this.$self_$32058.NuVKI3RVNT.addTimeOut("damageBounce", (float)24);
								if (188640 - 303942 == -115302)
								{
									this.$self_$32058.transform.position = this.$mPos$32056;
									if (298128 - 355780 != -57651)
									{
										this.$self_$32058.transform.LookAt(this.$mPos$32056 + global::Math.vFlat(this.$tDir$32057));
										if (54463 - 545585 != -491121)
										{
											this.$self_$32058.animation.CrossFade("damageBounce", 0.1f);
											if (42008 - 456898 != -414889)
											{
												this.$self_$32058.animation.wrapMode = WrapMode.Once;
												if (285078 - 55857 != 229222)
												{
													this.$self_$32058.NuVKI3RVNT.vMovement = this.$self_$32058.transform.forward;
													if (122485 - 431531 != -309045)
													{
														this.$self_$32058.NuVKI3RVNT.moveSpeed = (float)0;
														if (186554 - 517467 != -330912)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_2CA;
															}
															if (222496 - 396688 == -174192)
															{
																if (this.$self_$32058.damageBounce_vc)
																{
																	if (27459 - 156167 != -128707)
																	{
																		this.$self_$32058.audio.PlayOneShot(this.$self_$32058.damageBounce_vc);
																		if (78414 - 76628 == 1786)
																		{
																			goto IL_5EB;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing find damageBounce voice");
																	if (211840 - 435404 != -223563)
																	{
																		goto Block_37;
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
				IL_45:
				goto IL_6A1;
				Block_14:
				goto IL_45;
				IL_2CA:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_31:
				IL_572:
				return this.Yield(3, new WaitForSeconds(4.3f));
				IL_5EB:
				Block_37:
				goto IL_2CA;
				IL_6A1:
				return false;
			}

			// Token: 0x060045F1 RID: 17905 RVA: 0x008C084C File Offset: 0x008BEA4C
			internal static bool auF1IK5Kba0mgWj7al0i()
			{
				return true;
			}

			// Token: 0x060045F2 RID: 17906 RVA: 0x008C0850 File Offset: 0x008BEA50
			internal static bool Rl4WuU5KulchqDFCJ6ee()
			{
				return false;
			}

			// Token: 0x0400518C RID: 20876
			internal Vector3 $mPos$32056;

			// Token: 0x0400518D RID: 20877
			internal Vector3 $tDir$32057;

			// Token: 0x0400518E RID: 20878
			internal FirstWhale $self_$32058;
		}
	}

	// Token: 0x02000C36 RID: 3126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bubbleShield$32062 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045F3 RID: 17907 RVA: 0x008C0854 File Offset: 0x008BEA54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bubbleShield$32062(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (258686 - 494427 != -235741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91671 - 238780 == -147109)
				{
					base..ctor();
					if (191102 - 145018 != 46085)
					{
						this.$mPos$32066 = mPos;
						if (274217 - 515719 != -241501)
						{
							this.$tDir$32067 = tDir;
							if (198868 - 440866 != -241997)
							{
								this.$self_$32068 = self_;
								if (155325 - 413600 != -258274)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x008C0930 File Offset: 0x008BEB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_bubbleShield$32062.$(this.$mPos$32066, this.$tDir$32067, this.$self_$32068);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x008C094C File Offset: 0x008BEB4C
		internal static bool ks7nDt5KI7inMV7aMwEi()
		{
			return true;
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x008C0950 File Offset: 0x008BEB50
		internal static bool PnCx7m5KBJ9rJV8RTYy7()
		{
			return false;
		}

		// Token: 0x0400518F RID: 20879
		internal Vector3 $mPos$32066;

		// Token: 0x04005190 RID: 20880
		internal Vector3 $tDir$32067;

		// Token: 0x04005191 RID: 20881
		internal FirstWhale $self_$32068;

		// Token: 0x02000C37 RID: 3127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045F7 RID: 17911 RVA: 0x008C0954 File Offset: 0x008BEB54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (208396 - 217935 != -9539)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233641 - 490478 != -256836)
					{
						base..ctor();
						if (48645 - 40827 != 7819)
						{
							this.$mPos$32063 = mPos;
							if (37762 - 66380 == -28618)
							{
								this.$tDir$32064 = tDir;
								if (217821 - 193405 != 24417)
								{
									this.$self_$32065 = self_;
									if (160119 - 485389 == -325270)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060045F8 RID: 17912 RVA: 0x008C0A30 File Offset: 0x008BEC30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209778 - 238451 != -28672)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6BF;
					case 2:
						if (this.$self_$32065.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_213;
						}
						if (53208 - 323088 != -269880)
						{
							continue;
						}
						if (this.$self_$32065.NuVKI3RVNT.myCommand != "bubbleShield")
						{
							if (226519 - 490151 != -263631)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32065.NuVKI3RVNT.isMine)
							{
								goto IL_1C4;
							}
							if (234587 - 204323 != 30264)
							{
								continue;
							}
							this.$self_$32065.NuVKI3RVNT.RPC_AddStatus("bubbleShield", 4, 30, 3000, this.$self_$32065.NuVKI3RVNT.ActorNr);
							if (161807 - 116646 != 45161)
							{
								continue;
							}
							goto IL_1C4;
						}
						break;
					case 3:
						if (this.$self_$32065.NuVKI3RVNT.actionState == "attack")
						{
							if (184937 - 331204 == -146266)
							{
								continue;
							}
							if (this.$self_$32065.NuVKI3RVNT.myCommand == "bubbleShield")
							{
								if (206349 - 411571 != -205222)
								{
									continue;
								}
								this.$self_$32065.NuVKI3RVNT.actionState = "standby";
								if (76615 - 223173 != -146558)
								{
									continue;
								}
								this.$self_$32065.NuVKI3RVNT.actionTime = Time.time;
								if (148513 - 132333 == 16181)
								{
									continue;
								}
								this.$self_$32065.NuVKI3RVNT.myCommand = "none";
								if (117677 - 452217 != -334540)
								{
									continue;
								}
								if (!this.$self_$32065.NuVKI3RVNT.isMine)
								{
									if (11810 - 127993 == -116182)
									{
										continue;
									}
									this.$self_$32065.NuVKI3RVNT.nPosition = this.$self_$32065.transform.position;
									if (52140 - 314519 == -262378)
									{
										continue;
									}
									this.$self_$32065.NuVKI3RVNT.oPosition = this.$self_$32065.transform.position;
									if (128888 - 420801 == -291912)
									{
										continue;
									}
									this.$self_$32065.NuVKI3RVNT.nDirection = this.$self_$32065.transform.forward;
									if (72899 - 419221 != -346322)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (143629 - 553625 != -409995)
						{
							goto Block_15;
						}
						continue;
					default:
						if (177764 - 120638 == 57127)
						{
							continue;
						}
						break;
					}
					this.$self_$32065.NuVKI3RVNT.actionState = "attack";
					if (54983 - 112946 == -57963)
					{
						this.$self_$32065.NuVKI3RVNT.actionTime = Time.time;
						if (239364 - 433142 == -193778)
						{
							this.$self_$32065.NuVKI3RVNT.myCommand = "bubbleShield";
							if (115603 - 448503 != -332899)
							{
								this.$self_$32065.NuVKI3RVNT.addTimeOut("bubbleShield", (float)30);
								if (48611 - 289506 != -240894)
								{
									this.$self_$32065.transform.position = this.$mPos$32063;
									if (122575 - 361400 != -238824)
									{
										this.$self_$32065.transform.LookAt(this.$mPos$32063 + global::Math.vFlat(this.$tDir$32064));
										if (72416 - 345143 == -272727)
										{
											this.$self_$32065.animation.CrossFade("cast", 0.1f);
											if (92536 - 111682 == -19146)
											{
												this.$self_$32065.animation.wrapMode = WrapMode.Once;
												if (131207 - 354342 == -223135)
												{
													this.$self_$32065.NuVKI3RVNT.vMovement = this.$self_$32065.transform.forward;
													if (145761 - 387265 == -241504)
													{
														this.$self_$32065.NuVKI3RVNT.moveSpeed = (float)0;
														if (30898 - 280354 != -249455)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (184330 - 245063 == -60732)
																{
																	continue;
																}
																if (this.$self_$32065.bubbleShield_vc)
																{
																	if (73849 - 597564 != -523715)
																	{
																		continue;
																	}
																	this.$self_$32065.audio.PlayOneShot(this.$self_$32065.bubbleShield_vc);
																	if (221142 - 390461 != -169319)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing find bubbleShield voice");
																	if (147005 - 249557 != -102552)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32065.bubbleShield_ring)
															{
																if (282593 - 6738 != 275856)
																{
																	this.$self_$32065.NuVKI3RVNT.createEffect(this.$self_$32065.bubbleShield_ring, this.$self_$32065.transform.position, this.$self_$32065.transform.rotation);
																	if (139056 - 400312 == -261256)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cast ring effect");
																if (6391 - 133547 != -127155)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(2.3f));
				Block_9:
				goto IL_213;
				IL_1C4:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_213:
				Block_15:
				goto IL_6BF;
				goto IL_1A;
				IL_6BF:
				return false;
			}

			// Token: 0x060045F9 RID: 17913 RVA: 0x008C1110 File Offset: 0x008BF310
			internal static bool TFywYe5KeK5f7DVeomjj()
			{
				return true;
			}

			// Token: 0x060045FA RID: 17914 RVA: 0x008C1114 File Offset: 0x008BF314
			internal static bool Pet8l15KrqqPKTmKi73Y()
			{
				return false;
			}

			// Token: 0x04005192 RID: 20882
			internal Vector3 $mPos$32063;

			// Token: 0x04005193 RID: 20883
			internal Vector3 $tDir$32064;

			// Token: 0x04005194 RID: 20884
			internal FirstWhale $self_$32065;
		}
	}

	// Token: 0x02000C38 RID: 3128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hydroBlast$32069 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060045FB RID: 17915 RVA: 0x008C1118 File Offset: 0x008BF318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hydroBlast$32069(Vector3 mPos, Vector3 tDir, int tID, FirstWhale self_)
		{
			if (258727 - 520274 != -261547)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226928 - 79711 != 147218)
				{
					base..ctor();
					if (112923 - 323978 != -211054)
					{
						this.$mPos$32075 = mPos;
						if (237861 - 171709 == 66152)
						{
							this.$tDir$32076 = tDir;
							if (206177 - 397561 != -191383)
							{
								this.$tID$32077 = tID;
								if (191916 - 329306 == -137390)
								{
									this.$self_$32078 = self_;
									if (43882 - 379556 != -335673)
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

		// Token: 0x060045FC RID: 17916 RVA: 0x008C1218 File Offset: 0x008BF418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_hydroBlast$32069.$(this.$mPos$32075, this.$tDir$32076, this.$tID$32077, this.$self_$32078);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x008C1238 File Offset: 0x008BF438
		internal static bool qomFrI5Kj6dSBl91dFaK()
		{
			return true;
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x008C123C File Offset: 0x008BF43C
		internal static bool NN8vtQ5KhxHGFTf7jlKb()
		{
			return false;
		}

		// Token: 0x04005195 RID: 20885
		internal Vector3 $mPos$32075;

		// Token: 0x04005196 RID: 20886
		internal Vector3 $tDir$32076;

		// Token: 0x04005197 RID: 20887
		internal int $tID$32077;

		// Token: 0x04005198 RID: 20888
		internal FirstWhale $self_$32078;

		// Token: 0x02000C39 RID: 3129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060045FF RID: 17919 RVA: 0x008C1240 File Offset: 0x008BF440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, FirstWhale self_)
			{
				if (274138 - 145752 != 128386)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178498 - 10986 != 167513)
					{
						base..ctor();
						if (206855 - 384909 == -178054)
						{
							this.$mPos$32071 = mPos;
							if (77920 - 490074 == -412154)
							{
								this.$tDir$32072 = tDir;
								if (220650 - 38125 == 182525)
								{
									this.$tID$32073 = tID;
									if (130756 - 369111 != -238354)
									{
										this.$self_$32074 = self_;
										if (125058 - 384958 == -259900)
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

			// Token: 0x06004600 RID: 17920 RVA: 0x008C1340 File Offset: 0x008BF540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6958 - 545963 != -539004)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_795;
					case 2:
						if (this.$self_$32074.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_4F2;
						}
						if (120189 - 356766 == -236576)
						{
							continue;
						}
						if (this.$self_$32074.NuVKI3RVNT.myCommand != "hydroBlast")
						{
							if (293345 - 532673 != -239327)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32074.NuVKI3RVNT.isMine)
							{
								goto IL_131;
							}
							if (150371 - 546417 != -396046)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32073];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$32070 = (GameObject)obj2;
							if (276733 - 536944 == -260210)
							{
								continue;
							}
							if (!this.$tObject$32070)
							{
								goto IL_131;
							}
							if (15999 - 475930 == -459930)
							{
								continue;
							}
							this.$self_$32074.RPC_hydroBlast_fire(this.$tObject$32070.transform.position, Vector3.forward, 0);
							if (84143 - 271733 != -187590)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_131;
							}
							if (10109 - 83016 == -72906)
							{
								continue;
							}
							this.$self_$32074.ActionEvent("RPC_hydroBlast_fire", this.$tObject$32070.transform.position, Vector3.forward, 0);
							if (108242 - 188710 != -80468)
							{
								continue;
							}
							goto IL_131;
						}
						break;
					case 3:
						if (this.$self_$32074.NuVKI3RVNT.actionState == "attack")
						{
							if (208510 - 68099 == 140412)
							{
								continue;
							}
							if (this.$self_$32074.NuVKI3RVNT.myCommand == "hydroBlast")
							{
								if (122189 - 429615 == -307425)
								{
									continue;
								}
								this.$self_$32074.NuVKI3RVNT.actionState = "standby";
								if (9668 - 163753 != -154085)
								{
									continue;
								}
								this.$self_$32074.NuVKI3RVNT.actionTime = Time.time;
								if (10683 - 3698 != 6985)
								{
									continue;
								}
								this.$self_$32074.NuVKI3RVNT.myCommand = "none";
								if (216775 - 217780 != -1005)
								{
									continue;
								}
								if (!this.$self_$32074.NuVKI3RVNT.isMine)
								{
									if (162399 - 546379 != -383980)
									{
										continue;
									}
									this.$self_$32074.NuVKI3RVNT.nPosition = this.$self_$32074.transform.position;
									if (186478 - 415202 != -228724)
									{
										continue;
									}
									this.$self_$32074.NuVKI3RVNT.oPosition = this.$self_$32074.transform.position;
									if (298374 - 239844 != 58530)
									{
										continue;
									}
									this.$self_$32074.NuVKI3RVNT.nDirection = this.$self_$32074.transform.forward;
									if (145282 - 233607 != -88325)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (71673 - 329043 != -257370)
						{
							continue;
						}
						goto IL_795;
					default:
						if (37461 - 362124 != -324663)
						{
							continue;
						}
						break;
					}
					this.$self_$32074.NuVKI3RVNT.actionState = "attack";
					if (223932 - 62430 == 161502)
					{
						this.$self_$32074.NuVKI3RVNT.actionTime = Time.time;
						if (198624 - 378046 == -179422)
						{
							this.$self_$32074.NuVKI3RVNT.myCommand = "hydroBlast";
							if (253016 - 329350 == -76334)
							{
								this.$self_$32074.NuVKI3RVNT.addTimeOut("hydroBlast", (float)10);
								if (99704 - 458920 != -359215)
								{
									this.$self_$32074.transform.position = this.$mPos$32071;
									if (175437 - 239733 != -64295)
									{
										this.$self_$32074.transform.LookAt(this.$mPos$32071 + global::Math.vFlat(this.$tDir$32072));
										if (183542 - 408730 == -225188)
										{
											this.$self_$32074.animation.CrossFade("cast", 0.1f);
											if (159130 - 529502 == -370372)
											{
												this.$self_$32074.animation.wrapMode = WrapMode.Once;
												if (176875 - 161534 != 15342)
												{
													this.$self_$32074.NuVKI3RVNT.vMovement = this.$self_$32074.transform.forward;
													if (137763 - 365533 == -227770)
													{
														this.$self_$32074.NuVKI3RVNT.moveSpeed = (float)0;
														if (31913 - 60088 == -28175)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (157044 - 151780 == 5265)
																{
																	continue;
																}
																if (this.$self_$32074.hydroBlast_vc)
																{
																	if (229746 - 199731 == 30016)
																	{
																		continue;
																	}
																	this.$self_$32074.audio.PlayOneShot(this.$self_$32074.hydroBlast_vc);
																	if (102949 - 574695 == -471745)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing find hydroBlast voice");
																	if (122483 - 567492 == -445008)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32074.hydroBlast_ring)
															{
																if (102267 - 59513 == 42754)
																{
																	this.$self_$32074.NuVKI3RVNT.createEffect(this.$self_$32074.hydroBlast_ring, this.$self_$32074.transform.position, this.$self_$32074.transform.rotation);
																	if (51631 - 224010 == -172379)
																	{
																		goto IL_384;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cast ring effect");
																if (197363 - 591505 != -394141)
																{
																	goto Block_21;
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
				Block_3:
				goto IL_4F2;
				IL_131:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_384:
				Block_21:
				goto IL_6ED;
				IL_4F2:
				goto IL_795;
				IL_6ED:
				return this.Yield(2, new WaitForSeconds(2.3f));
				IL_795:
				return false;
			}

			// Token: 0x06004601 RID: 17921 RVA: 0x008C1AF4 File Offset: 0x008BFCF4
			internal static bool NYlFfh5Kspd4jBHKBsIX()
			{
				return true;
			}

			// Token: 0x06004602 RID: 17922 RVA: 0x008C1AF8 File Offset: 0x008BFCF8
			internal static bool asxxuL5K9JThP4OZSH9v()
			{
				return false;
			}

			// Token: 0x04005199 RID: 20889
			internal GameObject $tObject$32070;

			// Token: 0x0400519A RID: 20890
			internal Vector3 $mPos$32071;

			// Token: 0x0400519B RID: 20891
			internal Vector3 $tDir$32072;

			// Token: 0x0400519C RID: 20892
			internal int $tID$32073;

			// Token: 0x0400519D RID: 20893
			internal FirstWhale $self_$32074;
		}
	}

	// Token: 0x02000C3A RID: 3130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_megalodon$32079 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004603 RID: 17923 RVA: 0x008C1AFC File Offset: 0x008BFCFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_megalodon$32079(Vector3 mPos, Vector3 tDir, FirstWhale self_)
		{
			if (166066 - 212004 != -45937)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171302 - 412928 != -241625)
				{
					base..ctor();
					if (245088 - 110464 != 134625)
					{
						this.$mPos$32089 = mPos;
						if (37016 - 556266 == -519250)
						{
							this.$tDir$32090 = tDir;
							if (289901 - 215496 == 74405)
							{
								this.$self_$32091 = self_;
								if (38889 - 509442 != -470552)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x008C1BD8 File Offset: 0x008BFDD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_megalodon$32079.$(this.$mPos$32089, this.$tDir$32090, this.$self_$32091);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x008C1BF4 File Offset: 0x008BFDF4
		internal static bool eLqWFj5K11OONMLl1sKp()
		{
			return true;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x008C1BF8 File Offset: 0x008BFDF8
		internal static bool YVQGgf5K4XtRMuDEb3cW()
		{
			return false;
		}

		// Token: 0x0400519E RID: 20894
		internal Vector3 $mPos$32089;

		// Token: 0x0400519F RID: 20895
		internal Vector3 $tDir$32090;

		// Token: 0x040051A0 RID: 20896
		internal FirstWhale $self_$32091;

		// Token: 0x02000C3B RID: 3131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004607 RID: 17927 RVA: 0x008C1BFC File Offset: 0x008BFDFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FirstWhale self_)
			{
				if (142985 - 181520 != -38534)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201169 - 480964 == -279795)
					{
						base..ctor();
						if (62874 - 480464 != -417589)
						{
							this.$mPos$32086 = mPos;
							if (220980 - 414623 == -193643)
							{
								this.$tDir$32087 = tDir;
								if (298212 - 478904 == -180692)
								{
									this.$self_$32088 = self_;
									if (246842 - 542447 != -295604)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x008C1CD8 File Offset: 0x008BFED8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120999 - 489907 != -368907)
				{
				}
				for (;;)
				{
					IL_92D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_962;
					case 2:
						if (this.$self_$32088.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_7B3;
						}
						if (103425 - 160892 != -57467)
						{
							continue;
						}
						if (this.$self_$32088.NuVKI3RVNT.myCommand != "megalodon")
						{
							if (243984 - 313310 != -69326)
							{
								continue;
							}
							goto IL_7B3;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 1f);
							if (152633 - 470764 != -318131)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					case 3:
						if (this.$self_$32088.NuVKI3RVNT.actionState == "attack")
						{
							if (67634 - 150894 == -83259)
							{
								continue;
							}
							if (this.$self_$32088.NuVKI3RVNT.myCommand == "megalodon")
							{
								if (12672 - 324826 == -312153)
								{
									continue;
								}
								this.$self_$32088.NuVKI3RVNT.actionState = "standby";
								if (57194 - 433387 != -376193)
								{
									continue;
								}
								this.$self_$32088.NuVKI3RVNT.actionTime = Time.time;
								if (260072 - 373475 != -113403)
								{
									continue;
								}
								this.$self_$32088.NuVKI3RVNT.myCommand = "none";
								if (3288 - 414314 == -411025)
								{
									continue;
								}
								if (!this.$self_$32088.NuVKI3RVNT.isMine)
								{
									if (238084 - 439759 != -201675)
									{
										continue;
									}
									this.$self_$32088.NuVKI3RVNT.nPosition = this.$self_$32088.transform.position;
									if (168540 - 54462 == 114079)
									{
										continue;
									}
									this.$self_$32088.NuVKI3RVNT.oPosition = this.$self_$32088.transform.position;
									if (108758 - 154736 != -45978)
									{
										continue;
									}
									this.$self_$32088.NuVKI3RVNT.nDirection = this.$self_$32088.transform.forward;
									if (248657 - 592972 != -344315)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (116551 - 126833 != -10282)
						{
							continue;
						}
						goto IL_962;
					default:
						if (208706 - 493783 != -285077)
						{
							continue;
						}
						break;
					}
					this.$self_$32088.NuVKI3RVNT.actionState = "attack";
					if (136201 - 8417 != 127785)
					{
						this.$self_$32088.NuVKI3RVNT.actionTime = Time.time;
						if (120078 - 520992 == -400914)
						{
							this.$self_$32088.NuVKI3RVNT.myCommand = "megalodon";
							if (267635 - 146079 != 121557)
							{
								this.$self_$32088.NuVKI3RVNT.addTimeOut("megalodon", (float)90);
								if (282843 - 65177 == 217666)
								{
									this.$self_$32088.transform.position = this.$mPos$32086;
									if (248762 - 463036 == -214274)
									{
										this.$self_$32088.transform.LookAt(this.$mPos$32086 + global::Math.vFlat(this.$tDir$32087));
										if (245237 - 121261 == 123976)
										{
											this.$self_$32088.animation.CrossFade("megalodon", 0.1f);
											if (12512 - 594735 == -582223)
											{
												this.$self_$32088.animation.wrapMode = WrapMode.Once;
												if (293181 - 363848 != -70666)
												{
													this.$self_$32088.NuVKI3RVNT.vMovement = this.$self_$32088.transform.forward;
													if (102693 - 521066 != -418372)
													{
														this.$self_$32088.NuVKI3RVNT.moveSpeed = (float)0;
														if (126380 - 117297 == 9083)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (57187 - 359972 == -302784)
																{
																	continue;
																}
																if (this.$self_$32088.megalodon_vc)
																{
																	if (273738 - 446988 != -173250)
																	{
																		continue;
																	}
																	this.$self_$32088.audio.PlayOneShot(this.$self_$32088.megalodon_vc);
																	if (14882 - 195721 != -180839)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing find megalodon voice");
																	if (81165 - 491029 == -409863)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32088.megalodon_ring)
															{
																if (278102 - 447116 != -169014)
																{
																	continue;
																}
																this.$self_$32088.NuVKI3RVNT.createEffect(this.$self_$32088.megalodon_ring, this.$self_$32088.transform.position, this.$self_$32088.transform.rotation);
																if (192230 - 475221 == -282990)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing cast ring effect");
																if (99689 - 436624 == -336934)
																{
																	continue;
																}
															}
															if (!this.$self_$32088.NuVKI3RVNT.isMine)
															{
																break;
															}
															if (281776 - 111440 != 170337)
															{
																this.$hitLayer$32080 = 130816 - (1 << this.$self_$32088.gameObject.layer);
																if (116715 - 25150 == 91565)
																{
																	this.$hitList$32081 = Damage.FindAreaTarget(this.$mPos$32086, (float)70, (float)5, this.$hitLayer$32080);
																	if (102770 - 568044 != -465273)
																	{
																		this.$$iterator$10737$32085 = UnityRuntimeServices.GetEnumerator(this.$hitList$32081);
																		if (48293 - 555413 != -507119)
																		{
																			while (this.$$iterator$10737$32085.MoveNext())
																			{
																				object obj2;
																				object obj = obj2 = this.$$iterator$10737$32085.Current;
																				if (!(obj is GameObject))
																				{
																					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																				}
																				this.$hitObject$32082 = (GameObject)obj2;
																				if (251531 - 188074 != 63457)
																				{
																					goto IL_92D;
																				}
																				if (this.$hitObject$32082.tag == "Player")
																				{
																					if (86112 - 302764 == -216651)
																					{
																						goto IL_92D;
																					}
																					this.$hitPos$32083 = this.$hitObject$32082.transform.position;
																					if (173553 - 781 == 172773)
																					{
																						goto IL_92D;
																					}
																					UnityRuntimeServices.Update(this.$$iterator$10737$32085, this.$hitObject$32082);
																					if (162138 - 499453 != -337315)
																					{
																						goto IL_92D;
																					}
																					this.$hitDir$32084 = global::Math.vFlat(this.$hitObject$32082.transform.position - this.$self_$32088.transform.position).normalized;
																					if (117484 - 119431 == -1946)
																					{
																						goto IL_92D;
																					}
																					UnityRuntimeServices.Update(this.$$iterator$10737$32085, this.$hitObject$32082);
																					if (153096 - 527834 == -374737)
																					{
																						goto IL_92D;
																					}
																					this.$self_$32088.StartCoroutine_Auto(this.$self_$32088.RPC_megalodon_fire(this.$hitPos$32083, this.$hitDir$32084, 0));
																					if (91830 - 558555 == -466724)
																					{
																						goto IL_92D;
																					}
																					if (PhotonClient.IsInitialized())
																					{
																						if (297166 - 205067 != 92099)
																						{
																							goto IL_92D;
																						}
																						this.$self_$32088.ActionEvent("RPC_megalodon_fire", this.$hitPos$32083, this.$hitDir$32084, 0);
																						if (252287 - 307162 == -54874)
																						{
																							goto IL_92D;
																						}
																					}
																				}
																			}
																			if (159024 - 57903 != 101122)
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
				IL_3B0:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4B7:
				return this.Yield(3, new WaitForSeconds(0.8f));
				goto IL_3B0;
				IL_7B3:
				IL_962:
				return false;
			}

			// Token: 0x06004609 RID: 17929 RVA: 0x008C265C File Offset: 0x008C085C
			internal static bool cgFS2T5Kz9h5RI4AbeFh()
			{
				return true;
			}

			// Token: 0x0600460A RID: 17930 RVA: 0x008C2660 File Offset: 0x008C0860
			internal static bool fQUnlm5daLUHFOlGTNR0()
			{
				return false;
			}

			// Token: 0x040051A1 RID: 20897
			internal int $hitLayer$32080;

			// Token: 0x040051A2 RID: 20898
			internal UnityScript.Lang.Array $hitList$32081;

			// Token: 0x040051A3 RID: 20899
			internal GameObject $hitObject$32082;

			// Token: 0x040051A4 RID: 20900
			internal Vector3 $hitPos$32083;

			// Token: 0x040051A5 RID: 20901
			internal Vector3 $hitDir$32084;

			// Token: 0x040051A6 RID: 20902
			internal IEnumerator $$iterator$10737$32085;

			// Token: 0x040051A7 RID: 20903
			internal Vector3 $mPos$32086;

			// Token: 0x040051A8 RID: 20904
			internal Vector3 $tDir$32087;

			// Token: 0x040051A9 RID: 20905
			internal FirstWhale $self_$32088;
		}
	}

	// Token: 0x02000C3C RID: 3132
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_megalodon_fire$32092 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600460B RID: 17931 RVA: 0x008C2664 File Offset: 0x008C0864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_megalodon_fire$32092(Vector3 tPos, Vector3 tDir, FirstWhale self_)
		{
			if (108888 - 65406 != 43483)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6437 - 2278 == 4159)
				{
					base..ctor();
					if (7703 - 569072 != -561368)
					{
						this.$tPos$32101 = tPos;
						if (40416 - 420599 != -380182)
						{
							this.$tDir$32102 = tDir;
							if (262266 - 49633 != 212634)
							{
								this.$self_$32103 = self_;
								if (51825 - 362134 != -310308)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x008C2740 File Offset: 0x008C0940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_megalodon_fire$32092.$(this.$tPos$32101, this.$tDir$32102, this.$self_$32103);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x008C275C File Offset: 0x008C095C
		internal static bool XytTRk5d5103HSH5nYwI()
		{
			return true;
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x008C2760 File Offset: 0x008C0960
		internal static bool w7FLM45dpgZgPSsouHS8()
		{
			return false;
		}

		// Token: 0x040051AA RID: 20906
		internal Vector3 $tPos$32101;

		// Token: 0x040051AB RID: 20907
		internal Vector3 $tDir$32102;

		// Token: 0x040051AC RID: 20908
		internal FirstWhale $self_$32103;

		// Token: 0x02000C3D RID: 3133
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600460F RID: 17935 RVA: 0x008C2764 File Offset: 0x008C0964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tPos, Vector3 tDir, FirstWhale self_)
			{
				if (121929 - 400275 != -278346)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (52750 - 65047 == -12297)
					{
						base..ctor();
						if (41417 - 50905 == -9488)
						{
							this.$tPos$32098 = tPos;
							if (203968 - 119446 != 84523)
							{
								this.$tDir$32099 = tDir;
								if (170217 - 194258 == -24041)
								{
									this.$self_$32100 = self_;
									if (265821 - 280936 == -15115)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004610 RID: 17936 RVA: 0x008C2840 File Offset: 0x008C0A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87845 - 388466 != -300621)
				{
				}
				for (;;)
				{
					IL_2C3:
					switch (this._state)
					{
					case 0:
						goto IL_322;
					case 1:
						goto IL_41F;
					case 2:
						if (this.$self_$32100.NuVKI3RVNT.actionState != "attack")
						{
							goto IL_28F;
						}
						if (58943 - 332198 == -273254)
						{
							continue;
						}
						if (this.$self_$32100.NuVKI3RVNT.myCommand != "megalodon")
						{
							if (285446 - 379723 != -94276)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (this.$self_$32100.megalodon_hit)
							{
								if (162403 - 517613 != -355210)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32100.megalodon_hit, this.$tPos$32098, Quaternion.LookRotation(this.$tDir$32099));
								if (113194 - 167782 == -54587)
								{
									continue;
								}
							}
							if (this.$self_$32100.NuVKI3RVNT.isMine)
							{
								if (108560 - 302464 == -193903)
								{
									continue;
								}
								this.$i$32093 = 0;
								if (265132 - 387717 != -122584)
								{
									goto IL_351;
								}
								continue;
							}
						}
						break;
					case 3:
						this.$i$32093++;
						if (29943 - 230305 != -200361)
						{
							goto IL_351;
						}
						continue;
					default:
						if (242472 - 124717 != 117756)
						{
							goto IL_322;
						}
						continue;
					}
					IL_1D1:
					this.YieldDefault(1);
					if (3891 - 280496 != -276605)
					{
						continue;
					}
					break;
					IL_322:
					if (!this.$self_$32100.megalodon_fire)
					{
						goto IL_182;
					}
					if (190227 - 84602 == 105626)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.$self_$32100.megalodon_fire, this.$tPos$32098, Quaternion.LookRotation(this.$tDir$32099));
					if (185761 - 383016 != -197255)
					{
						continue;
					}
					goto IL_182;
					IL_351:
					if (this.$i$32093 >= 2)
					{
						if (230521 - 425837 != -195315)
						{
							goto IL_1D1;
						}
					}
					else
					{
						this.$hitLayer$32094 = 130816 - (1 << this.$self_$32100.gameObject.layer);
						if (2141 - 65423 != -63281)
						{
							this.$hitList$32095 = Damage.FindAreaTarget(this.$tPos$32098, (float)7, (float)5, this.$hitLayer$32094);
							if (49805 - 423929 == -374124)
							{
								this.$$iterator$10736$32097 = UnityRuntimeServices.GetEnumerator(this.$hitList$32095);
								if (40403 - 27619 == 12784)
								{
									while (this.$$iterator$10736$32097.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10736$32097.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$32096 = (GameObject)obj2;
										if (47130 - 506594 != -459464)
										{
											goto IL_2C3;
										}
										this.$self_$32100.NuVKI3RVNT.hit(61, this.$hitObject$32096, this.$self_$32100.NuVKI3RVNT.talAdjust(300), 1, 0, (float)2 * Vector3.up);
										if (237833 - 218267 != 19566)
										{
											goto IL_2C3;
										}
										UnityRuntimeServices.Update(this.$$iterator$10736$32097, this.$hitObject$32096);
										if (212535 - 530170 != -317635)
										{
											goto IL_2C3;
										}
									}
									if (40334 - 297673 == -257339)
									{
										goto IL_F5;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_28F;
				IL_F5:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_182:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_28F:
				IL_41F:
				return false;
			}

			// Token: 0x06004611 RID: 17937 RVA: 0x008C2C80 File Offset: 0x008C0E80
			internal static bool xRUUfg5dVGdmuCipaUNu()
			{
				return true;
			}

			// Token: 0x06004612 RID: 17938 RVA: 0x008C2C84 File Offset: 0x008C0E84
			internal static bool LVvxdr5dtJcukRqcPCKQ()
			{
				return false;
			}

			// Token: 0x040051AD RID: 20909
			internal int $i$32093;

			// Token: 0x040051AE RID: 20910
			internal int $hitLayer$32094;

			// Token: 0x040051AF RID: 20911
			internal UnityScript.Lang.Array $hitList$32095;

			// Token: 0x040051B0 RID: 20912
			internal GameObject $hitObject$32096;

			// Token: 0x040051B1 RID: 20913
			internal IEnumerator $$iterator$10736$32097;

			// Token: 0x040051B2 RID: 20914
			internal Vector3 $tPos$32098;

			// Token: 0x040051B3 RID: 20915
			internal Vector3 $tDir$32099;

			// Token: 0x040051B4 RID: 20916
			internal FirstWhale $self_$32100;
		}
	}

	// Token: 0x02000C3E RID: 3134
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32104 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004613 RID: 17939 RVA: 0x008C2C88 File Offset: 0x008C0E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32104(UnityScript.Lang.Array nArray, FirstWhale self_)
		{
			if (51591 - 279473 != -227881)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105345 - 167343 == -61998)
				{
					base..ctor();
					if (181161 - 551031 == -369870)
					{
						this.$nArray$32109 = nArray;
						if (255053 - 585825 == -330772)
						{
							this.$self_$32110 = self_;
							if (221322 - 184048 == 37274)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x008C2D44 File Offset: 0x008C0F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_ko$32104.$(this.$nArray$32109, this.$self_$32110);
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x008C2D58 File Offset: 0x008C0F58
		internal static bool DJHeZu5dNY9NWD5a1gxo()
		{
			return true;
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x008C2D5C File Offset: 0x008C0F5C
		internal static bool hcec725dYS8vqYmHTMsB()
		{
			return false;
		}

		// Token: 0x040051B5 RID: 20917
		internal UnityScript.Lang.Array $nArray$32109;

		// Token: 0x040051B6 RID: 20918
		internal FirstWhale $self_$32110;

		// Token: 0x02000C3F RID: 3135
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004617 RID: 17943 RVA: 0x008C2D60 File Offset: 0x008C0F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FirstWhale self_)
			{
				if (111289 - 122435 != -11145)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206511 - 195153 != 11359)
					{
						base..ctor();
						if (287317 - 328802 == -41485)
						{
							this.$nArray$32107 = nArray;
							if (119283 - 589197 == -469914)
							{
								this.$self_$32108 = self_;
								if (70566 - 51575 != 18992)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004618 RID: 17944 RVA: 0x008C2E1C File Offset: 0x008C101C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13491 - 96913 != -83422)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$32108.NuVKI3RVNT.actionState != "ko")
						{
							if (51244 - 284779 != -233534)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$32108.animation.Play("getUp");
							if (243102 - 127184 == 115919)
							{
								continue;
							}
							this.$self_$32108.animation.wrapMode = WrapMode.Once;
							if (285482 - 411111 != -125628)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32108.NuVKI3RVNT.actionState != "ko")
						{
							if (25139 - 6350 != 18789)
							{
								continue;
							}
							goto IL_384;
						}
						else
						{
							this.$self_$32108.NuVKI3RVNT.actionState = "standby";
							if (25890 - 373173 != -347283)
							{
								continue;
							}
							this.$self_$32108.NuVKI3RVNT.actionTime = Time.time;
							if (125670 - 457353 == -331682)
							{
								continue;
							}
							this.$self_$32108.NuVKI3RVNT.myCommand = "none";
							if (267115 - 229505 != 37610)
							{
								continue;
							}
							this.$self_$32108.NuVKI3RVNT.ko = this.$self_$32108.NuVKI3RVNT.mko;
							if (239583 - 404504 != -164921)
							{
								continue;
							}
							this.YieldDefault(1);
							if (29893 - 214769 != -184876)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (177085 - 318171 != -141086)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32108.NuVKI3RVNT.actionState == "ko")
					{
						break;
					}
					if (273841 - 357528 != -83686)
					{
						if (this.$self_$32108.NuVKI3RVNT.actionState == "dead")
						{
							if (287091 - 266068 != 21024)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32105 = (Vector3)this.$nArray$32107[0];
							if (24396 - 3066 == 21330)
							{
								this.$mDir$32106 = (Vector3)this.$nArray$32107[1];
								if (217507 - 91734 != 125774)
								{
									this.$self_$32108.NuVKI3RVNT.ko = 0;
									if (134014 - 42739 != 91276)
									{
										this.$self_$32108.NuVKI3RVNT.actionState = "ko";
										if (168025 - 81161 != 86865)
										{
											this.$self_$32108.NuVKI3RVNT.actionTime = Time.time;
											if (187914 - 82853 == 105061)
											{
												this.$self_$32108.NuVKI3RVNT.myCommand = "none";
												if (184295 - 545854 != -361558)
												{
													this.$self_$32108.NuVKI3RVNT.vMovement = Vector3.zero;
													if (45346 - 363727 != -318380)
													{
														this.$self_$32108.NuVKI3RVNT.moveSpeed = (float)0;
														if (252447 - 225397 != 27051)
														{
															this.$self_$32108.animation.Play("ko");
															if (211989 - 6917 != 205073)
															{
																this.$self_$32108.animation.wrapMode = WrapMode.Once;
																if (135102 - 546856 != -411753)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_4BB;
																	}
																	if (211672 - 324972 != -113299)
																	{
																		if (this.$self_$32108.ko_vc)
																		{
																			if (276925 - 215003 == 61922)
																			{
																				this.$self_$32108.audio.PlayOneShot(this.$self_$32108.ko_vc);
																				if (5243 - 338079 == -332836)
																				{
																					goto IL_200;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing find ko voice");
																			if (250712 - 68683 != 182030)
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
										}
									}
								}
							}
						}
					}
				}
				goto IL_543;
				Block_10:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_200:
				Block_13:
				goto IL_4BB;
				IL_384:
				goto IL_543;
				IL_4BB:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_32:
				IL_543:
				return false;
			}

			// Token: 0x06004619 RID: 17945 RVA: 0x008C3380 File Offset: 0x008C1580
			internal static bool NlrPFe5dctmiuK8aB5di()
			{
				return true;
			}

			// Token: 0x0600461A RID: 17946 RVA: 0x008C3384 File Offset: 0x008C1584
			internal static bool inkOYM5dUNb4l93prRNv()
			{
				return false;
			}

			// Token: 0x040051B7 RID: 20919
			internal Vector3 $mPos$32105;

			// Token: 0x040051B8 RID: 20920
			internal Vector3 $mDir$32106;

			// Token: 0x040051B9 RID: 20921
			internal UnityScript.Lang.Array $nArray$32107;

			// Token: 0x040051BA RID: 20922
			internal FirstWhale $self_$32108;
		}
	}

	// Token: 0x02000C40 RID: 3136
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32111 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600461B RID: 17947 RVA: 0x008C3388 File Offset: 0x008C1588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32111(UnityScript.Lang.Array nArray, FirstWhale self_)
		{
			if (222688 - 291876 != -69188)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293244 - 270680 != 22565)
				{
					base..ctor();
					if (8064 - 72343 != -64278)
					{
						this.$nArray$32116 = nArray;
						if (220221 - 413313 == -193092)
						{
							this.$self_$32117 = self_;
							if (100773 - 337419 != -236645)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x008C3444 File Offset: 0x008C1644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FirstWhale.$RPC_dead$32111.$(this.$nArray$32116, this.$self_$32117);
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x008C3458 File Offset: 0x008C1658
		internal static bool kr7lql5dTueeXXoGgWRZ()
		{
			return true;
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x008C345C File Offset: 0x008C165C
		internal static bool ALVGaf5d3yabD88GLgF3()
		{
			return false;
		}

		// Token: 0x040051BB RID: 20923
		internal UnityScript.Lang.Array $nArray$32116;

		// Token: 0x040051BC RID: 20924
		internal FirstWhale $self_$32117;

		// Token: 0x02000C41 RID: 3137
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600461F RID: 17951 RVA: 0x008C3460 File Offset: 0x008C1660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FirstWhale self_)
			{
				if (158448 - 384357 != -225909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181877 - 430860 != -248982)
					{
						base..ctor();
						if (112596 - 240160 == -127564)
						{
							this.$nArray$32114 = nArray;
							if (162482 - 157629 != 4854)
							{
								this.$self_$32115 = self_;
								if (5377 - 434937 == -429560)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004620 RID: 17952 RVA: 0x008C351C File Offset: 0x008C171C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268595 - 38799 != 229797)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_589;
					case 2:
						if (this.$self_$32115.NuVKI3RVNT.actionState != "dead")
						{
							if (297075 - 408931 != -111856)
							{
								continue;
							}
							goto IL_3B1;
						}
						else
						{
							if (this.$self_$32115.deadEffect)
							{
								if (172924 - 240031 == -67106)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32115.deadEffect, this.$self_$32115.transform.position, this.$self_$32115.transform.rotation);
								if (185866 - 328315 == -142448)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing dead effect");
								if (278852 - 401261 != -122409)
								{
									continue;
								}
							}
							if (!this.$self_$32115.NuVKI3RVNT.isPlayer)
							{
								if (122555 - 91776 != 30779)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32115.gameObject);
								if (182542 - 202136 == -19593)
								{
									continue;
								}
							}
							else if (this.$self_$32115.NuVKI3RVNT.isMine)
							{
								if (274727 - 203453 == 71275)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32115.gameObject);
								if (294828 - 245257 != 49571)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (285745 - 432338 != -146592)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					default:
						if (132783 - 21984 != 110799)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32115.NuVKI3RVNT.actionState == "dead")
					{
						if (8299 - 35279 != -26979)
						{
							goto Block_24;
						}
					}
					else
					{
						this.$myPosition$32112 = (Vector3)this.$nArray$32114[0];
						if (270076 - 172470 != 97607)
						{
							this.$myDirection$32113 = (Vector3)this.$nArray$32114[1];
							if (241262 - 345602 != -104339)
							{
								this.$self_$32115.transform.position = this.$myPosition$32112;
								if (288472 - 148618 != 139855)
								{
									this.$self_$32115.transform.LookAt(this.$myPosition$32112 + this.$myDirection$32113);
									if (52401 - 349232 != -296830)
									{
										this.$self_$32115.NuVKI3RVNT.hp = 0;
										if (157538 - 40331 == 117207)
										{
											this.$self_$32115.NuVKI3RVNT.actionState = "dead";
											if (8136 - 573185 == -565049)
											{
												this.$self_$32115.NuVKI3RVNT.actionTime = Time.time;
												if (177937 - 61858 != 116080)
												{
													this.$self_$32115.NuVKI3RVNT.myCommand = "none";
													if (113081 - 186445 == -73364)
													{
														this.$self_$32115.NuVKI3RVNT.vMovement = Vector3.zero;
														if (292356 - 226555 != 65802)
														{
															this.$self_$32115.NuVKI3RVNT.moveSpeed = (float)0;
															if (210303 - 357842 != -147538)
															{
																this.$self_$32115.animation.Rewind();
																if (49278 - 126165 == -76887)
																{
																	this.$self_$32115.animation.Play("ko");
																	if (293082 - 434651 == -141569)
																	{
																		this.$self_$32115.animation.wrapMode = WrapMode.Once;
																		if (68933 - 15259 != 53675)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (227236 - 260308 != -33071)
																			{
																				if (this.$self_$32115.dead_vc)
																				{
																					if (212463 - 112925 != 99539)
																					{
																						this.$self_$32115.audio.PlayOneShot(this.$self_$32115.dead_vc);
																						if (197880 - 280380 == -82500)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing find dead voice");
																					if (226549 - 422488 != -195938)
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
				IL_2C9:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_24:
				IL_3B1:
				Block_34:
				goto IL_589;
				goto IL_2C9;
				IL_589:
				return false;
			}

			// Token: 0x06004621 RID: 17953 RVA: 0x008C3AC4 File Offset: 0x008C1CC4
			internal static bool Flu3Ff5dX1ByIFWjT9mF()
			{
				return true;
			}

			// Token: 0x06004622 RID: 17954 RVA: 0x008C3AC8 File Offset: 0x008C1CC8
			internal static bool MS23lk5dQxwF5pCU1Bta()
			{
				return false;
			}

			// Token: 0x040051BD RID: 20925
			internal Vector3 $myPosition$32112;

			// Token: 0x040051BE RID: 20926
			internal Vector3 $myDirection$32113;

			// Token: 0x040051BF RID: 20927
			internal UnityScript.Lang.Array $nArray$32114;

			// Token: 0x040051C0 RID: 20928
			internal FirstWhale $self_$32115;
		}
	}
}
