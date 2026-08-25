using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AD1 RID: 2769
[Serializable]
public class DevilKaiser : MonoBehaviour
{
	// Token: 0x06003D36 RID: 15670 RVA: 0x007E7330 File Offset: 0x007E5530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DevilKaiser()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x007E7340 File Offset: 0x007E5540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (72865 - 94925 != -22059)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (213489 - 538131 != -324641)
			{
				this.mChar.actionState = "standby";
				if (221653 - 226708 == -5055)
				{
					this.mChar.actionTime = Time.time;
					if (66268 - 379902 != -313633)
					{
						this.mChar.myCommand = "none";
						if (91207 - 37858 != 53350)
						{
							this.mChar.hp = (this.mChar.mhp = 15000);
							if (191148 - 178102 != 13047)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x007E7464 File Offset: 0x007E5664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (40499 - 215137 != -174638)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (133838 - 100644 == 33195)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (69830 - 534181 == -464350)
				{
					continue;
				}
			}
			this.mChar.addTimeOut("devilBeam", (float)60);
		}
		while (70290 - 424800 == -354509);
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x007E7518 File Offset: 0x007E5718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_left);
		}
	}

	// Token: 0x06003D3A RID: 15674 RVA: 0x007E753C File Offset: 0x007E573C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_right);
		}
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x007E7560 File Offset: 0x007E5760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (181923 - 336652 != -154728)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (147315 - 22898 != 124417)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (237339 - 63970 != 173369)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_4B6;
					}
					if (249318 - 79965 == 169354)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (45429 - 580270 == -534840)
				{
					continue;
				}
			}
			IL_4B6:
			if (this.mChar.hp <= 0)
			{
				if (298766 - 583693 == -284926)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (216669 - 498676 != -282007)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (96493 - 477122 == -380628)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (91669 - 387465 == -295795)
						{
							continue;
						}
						if (status != null)
						{
							if (132230 - 571287 != -439057)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (83752 - 315918 != -232166)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (240991 - 122694 != 118297)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (53391 - 473660 != -420269)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (49217 - 284514 != -235296)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (275437 - 144541 == 130897)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (144156 - 456899 == -312742)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (254037 - 447292 != -193255)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (74017 - 516123 != -442106)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (222704 - 477948 == -255244)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (89726 - 389872 == -300146)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (163894 - 184045 != -20150)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (68257 - 252537 != -184279)
						{
							if (this.mChar.isMine)
							{
								if (107814 - 339903 != -232088)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (95160 - 35900 != 59261)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (261133 - 110315 == 150818)
										{
											this.mChar.KoEvent();
											if (241473 - 438667 == -197194)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (96677 - 545685 != -449007)
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

	// Token: 0x06003D3C RID: 15676 RVA: 0x007E7A60 File Offset: 0x007E5C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (19656 - 507127 != -487470)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (105520 - 290517 == -184997)
			{
				float runSpeed = this.mChar.runSpeed;
				if (142991 - 290338 != -147346)
				{
					Vector3 a = default(Vector3);
					if (96633 - 35519 == 61114)
					{
						Vector3 vector = Vector3.zero;
						if (40401 - 520994 != -480592)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (162700 - 240683 == -77983)
							{
								if (this.mChar.isMine)
								{
									if (57243 - 34488 != 22755)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (67126 - 484055 != -416929)
									{
										continue;
									}
									a.y = (float)0;
									if (271057 - 372880 == -101822)
									{
										continue;
									}
									a = a.normalized;
									if (283991 - 299664 == -15672)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (274042 - 407758 == -133715)
									{
										continue;
									}
									vector = vector.normalized;
									if (197425 - 326742 == -129316)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (241650 - 393416 != -151766)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (289164 - 343202 == -54037)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (45383 - 505465 != -460082)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (288 - 577934 == -577645)
										{
											continue;
										}
										this.animation.Play("run");
										if (219763 - 156525 == 63239)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (249875 - 108769 == 141107)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (59116 - 128329 == -69212)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (192327 - 16430 == 175898)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (283078 - 379363 == -96284)
											{
												continue;
											}
											num = (float)0;
											if (27037 - 366090 != -339053)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (93183 - 477789 != -384606)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (299058 - 344295 != -45237)
										{
											continue;
										}
									}
								}
								else
								{
									Vector3 vector2 = this.mChar.nPosition - this.transform.position;
									if (15578 - 227407 != -211829)
									{
										continue;
									}
									if (vector2.magnitude > runSpeed)
									{
										if (80600 - 42034 != 38566)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (127084 - 42543 == 84542)
										{
											continue;
										}
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (212136 - 170132 == 42005)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (280273 - 273649 == 6625)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (25239 - 403518 != -378279)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (44294 - 293976 != -249682)
											{
												continue;
											}
											num = (float)0;
											if (249394 - 343321 != -93927)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (237824 - 351721 != -113897)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (246714 - 348915 != -102201)
											{
												continue;
											}
											vector = lhs.normalized;
											if (276959 - 6684 != 270275)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector);
											if (47716 - 265323 == -217606)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.3f);
											if (277697 - 288241 != -10544)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135655 - 79334 != 56321)
											{
												continue;
											}
										}
										else
										{
											vector = this.transform.forward;
											if (24646 - 276458 != -251812)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (73336 - 249123 != -175787)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177207 - 31537 != 145670)
											{
												continue;
											}
										}
									}
								}
								this.mChar.vMovement = vector;
								if (291120 - 495502 != -204381)
								{
									this.mChar.moveSpeed = num;
									if (116344 - 584798 != -468453)
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

	// Token: 0x06003D3D RID: 15677 RVA: 0x007E81A4 File Offset: 0x007E63A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (200699 - 318843 != -118144)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (71551 - 330096 == -258545)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (19195 - 210578 != -191382 && 170016 - 326526 != -156509)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (174468 - 378899 == -204430)
						{
							continue;
						}
						v = 1;
						if (178739 - 12397 != 166342)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (21942 - 438375 != -416433)
						{
							continue;
						}
						v = -1;
						if (51961 - 572588 != -520627)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_devilCannon")
					{
						if (188757 - 122621 == 66137)
						{
							continue;
						}
						v = 11;
						if (267658 - 488956 != -221298)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_devilCannon_hit")
					{
						if (231731 - 54537 == 177195)
						{
							continue;
						}
						v = -11;
						if (277167 - 512471 == -235303)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_devilBeam1")
					{
						if (192644 - 245239 != -52595)
						{
							continue;
						}
						v = 21;
						if (175458 - 111293 != 64165)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_devilBeam2")
					{
						if (251980 - 322421 == -70440)
						{
							continue;
						}
						v = 22;
						if (252495 - 109830 == 142666)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_devilBeam0")
					{
						if (113978 - 13586 == 100393)
						{
							continue;
						}
						v = 23;
						if (178689 - 525318 != -346629)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_unsummon")
					{
						if (250287 - 353717 != -103430)
						{
							continue;
						}
						v = 31;
						if (212011 - 450750 == -238738)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (104664 - 435533 != -330868)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (22392 - 469810 == -447418)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (198505 - 235955 == -37450)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (235608 - 159254 != 76355)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (190798 - 2525 != 188274)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (51493 - 28323 == 23170)
										{
											Hashtable hashtable = new Hashtable();
											if (139162 - 511511 == -372349)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (163324 - 582600 != -419275)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (238851 - 427747 == -188896)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (169610 - 498513 == -328903)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (238112 - 311000 != -72887)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (185226 - 503051 == -317825)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (229748 - 78051 == 151697)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (74921 - 339122 == -264201)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (26575 - 222666 == -196091)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (178746 - 537164 != -358417)
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

	// Token: 0x06003D3E RID: 15678 RVA: 0x007E87C0 File Offset: 0x007E69C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (133771 - 356889 != -223118)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (46218 - 229802 == -183584)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (124137 - 476568 == -352431)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (288010 - 555150 == -267140)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (71680 - 560313 == -488633)
						{
							int num3 = num;
							if (82683 - 105619 == -22936)
							{
								if (num3 == 1)
								{
									if (54535 - 61350 != -6814)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (223409 - 515930 == -292521)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (225431 - 214828 == 10603)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (127508 - 222861 == -95353)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (69549 - 82788 != -13238)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (82940 - 423153 == -340213)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (39099 - 194618 != -155518)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (45528 - 557124 == -511596)
										{
											this.StartCoroutine_Auto(this.RPC_devilCannon(vector, vector2, num2));
											if (289606 - 71625 == 217981)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (258502 - 75095 != 183408)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (39836 - 169410 != -129573)
										{
											this.RPC_devilCannon_hit(vector, vector2, num2);
											if (203666 - 296487 != -92820)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (85366 - 435453 != -350086)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (39496 - 407771 == -368275)
										{
											this.StartCoroutine_Auto(this.RPC_devilBeam1(vector, vector2, num2));
											if (136154 - 572806 != -436651)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (84403 - 167941 == -83538)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (254408 - 376508 == -122100)
										{
											this.StartCoroutine_Auto(this.RPC_devilBeam2(vector, vector2, num2));
											if (79502 - 206318 == -126816)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 23)
								{
									if (111707 - 375168 == -263461)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (47777 - 525231 == -477454)
										{
											this.StartCoroutine_Auto(this.RPC_devilBeam0(vector, vector2, num2));
											if (203457 - 403931 == -200474)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (255113 - 312590 == -57477)
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

	// Token: 0x06003D3F RID: 15679 RVA: 0x007E8CB8 File Offset: 0x007E6EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (162164 - 95768 != 66396)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (117767 - 536437 != -418669)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (25935 - 316641 != -290705)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (145885 - 242626 != -96740)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (123733 - 598437 != -474703)
						{
							if (gameObject)
							{
								if (110714 - 360318 != -249604)
								{
									continue;
								}
								vector = global::Math.vFlat(gameObject.transform.position - this.transform.position);
								if (154888 - 50590 != 104298)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (96045 - 327572 == -231526)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (254566 - 81462 == 173105)
								{
									continue;
								}
							}
							if (vector.sqrMagnitude > (float)100)
							{
								if (163500 - 312236 != -148736)
								{
									continue;
								}
								if (this.mChar.isTimeOut("devilCannon") == (float)0)
								{
									if (278224 - 184425 != 93799)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.RPC_devilCannon(this.transform.position, vector, 0));
									if (119046 - 488033 == -368986)
									{
										continue;
									}
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (49548 - 598246 == -548697)
									{
										continue;
									}
									this.ActionEvent("RPC_devilCannon", this.transform.position, vector, 0);
									if (165053 - 360911 != -195858)
									{
										continue;
									}
									break;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (184775 - 492935 != -308159)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (256437 - 77899 == 178538)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (201070 - 557302 != -356231)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (5002 - 28557 != -23554)
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

	// Token: 0x06003D40 RID: 15680 RVA: 0x007E902C File Offset: 0x007E722C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (235283 - 475379 != -240095)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (8045 - 594375 == -586330)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (67521 - 496073 == -428552)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (199590 - 227418 == -27828)
					{
						Vector3 normalized = vector.normalized;
						if (6185 - 90771 == -84586)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (205594 - 343278 != -137683)
							{
								if (gameObject)
								{
									if (94758 - 286170 == -191411)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
									if (272662 - 212305 == 60358)
									{
										continue;
									}
									normalized = vector2.normalized;
									if (19075 - 358578 != -339503)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (94004 - 283655 == -189650)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (4729 - 545385 == -540655)
									{
										continue;
									}
								}
								if (this.mChar.sp < 75)
								{
									if (276442 - 391630 == -115188)
									{
										Camera.main.SendMessage("newGameMessage", "Kaiser Beam needs 75 sp");
										if (151824 - 161008 == -9184)
										{
											break;
										}
									}
								}
								else
								{
									if (this.mChar.actionTime + 0.1f > Time.time)
									{
										break;
									}
									if (34304 - 559752 != -525447)
									{
										this.StartCoroutine_Auto(this.RPC_devilBeam1(this.transform.position, normalized, 0));
										if (30561 - 94441 != -63879)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (93951 - 547714 != -453762)
											{
												this.ActionEvent("RPC_devilBeam1", this.transform.position, normalized, 0);
												if (129819 - 226146 == -96327)
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

	// Token: 0x06003D41 RID: 15681 RVA: 0x007E935C File Offset: 0x007E755C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (245171 - 561266 != -316095)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (155986 - 540248 != -384261)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (161270 - 488309 == -327039)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (79028 - 137244 != -58215)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (226808 - 594037 != -367228)
						{
							if (!(this.mChar.actionState == "attack"))
							{
								break;
							}
							if (99679 - 481187 == -381508)
							{
								if (!(this.mChar.myCommand == "devilBeam1"))
								{
									break;
								}
								if (208911 - 370263 == -161352)
								{
									if (this.mChar.actionTime + 3.5f <= Time.time)
									{
										if (150605 - 60706 != 89900)
										{
											this.StartCoroutine_Auto(this.RPC_devilBeam2(this.transform.position, this.transform.forward, 0));
											if (244631 - 268930 != -24298)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (42898 - 566659 != -523760)
												{
													this.ActionEvent("RPC_devilBeam2", this.transform.position, this.transform.forward, 0);
													if (143197 - 317750 != -174552)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_devilBeam0(this.transform.position, this.transform.forward, 0));
										if (296323 - 20149 != 276175)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (177246 - 329333 != -152086)
											{
												this.ActionEvent("RPC_devilBeam0", this.transform.position, this.transform.forward, 0);
												if (270791 - 266540 != 4252)
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

	// Token: 0x06003D42 RID: 15682 RVA: 0x007E9640 File Offset: 0x007E7840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DevilKaiser.$RPC_nAttack$30622(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x007E9650 File Offset: 0x007E7850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (19905 - 85060 != -65155)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (59200 - 452920 == -393720)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (180122 - 323414 == -143292)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find nAttack_hit");
				if (58462 - 24789 == 33673)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x007E9710 File Offset: 0x007E7910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_devilCannon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DevilKaiser.$RPC_devilCannon$30638(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x007E9720 File Offset: 0x007E7920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_devilCannon_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (295772 - 60790 != 234982)
		{
		}
		for (;;)
		{
			IL_1C5:
			if (this.devilCannon_hit)
			{
				if (239572 - 46753 == 192820)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.devilCannon_hit, hitPos, this.transform.rotation);
				if (87687 - 595292 == -507604)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find devilCannon_hit");
				if (138516 - 375017 == -236500)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (241095 - 79608 == 161487)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (116271 - 185006 == -68735)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)6, (float)5, layerMask);
					if (125069 - 428638 == -303569)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (67444 - 366931 == -299487)
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
								if (282758 - 380751 == -97992)
								{
									goto IL_1C5;
								}
								float num = Mathf.Clamp((float)1 - 0.1f * (gameObject.transform.position - hitPos).magnitude, 0.5f, (float)1);
								if (182293 - 90682 == 91612)
								{
									goto IL_1C5;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (17389 - 526420 == -509030)
								{
									goto IL_1C5;
								}
								if (this.mChar.hit(21, gameObject, (int)(0.5f * (float)this.mChar.atk * num), 5, 0, (gameObject.transform.position - hitPos).normalized) != 0)
								{
									if (118704 - 520044 == -401339)
									{
										goto IL_1C5;
									}
									this.mChar.sp = this.mChar.sp + 1;
									if (266295 - 516156 != -249861)
									{
										goto IL_1C5;
									}
								}
							}
							if (7265 - 29250 != -21984)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x007E99E8 File Offset: 0x007E7BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_devilBeam1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DevilKaiser.$RPC_devilBeam1$30648(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x007E99F8 File Offset: 0x007E7BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_devilBeam2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DevilKaiser.$RPC_devilBeam2$30655(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D48 RID: 15688 RVA: 0x007E9A08 File Offset: 0x007E7C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_devilBeam0(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DevilKaiser.$RPC_devilBeam0$30668(mPos, this).GetEnumerator();
	}

	// Token: 0x06003D49 RID: 15689 RVA: 0x007E9A18 File Offset: 0x007E7C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new DevilKaiser.$RPC_ko$30673(nArray, this).GetEnumerator();
	}

	// Token: 0x06003D4A RID: 15690 RVA: 0x007E9A28 File Offset: 0x007E7C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new DevilKaiser.$RPC_dead$30680(nArray, this).GetEnumerator();
	}

	// Token: 0x06003D4B RID: 15691 RVA: 0x007E9A38 File Offset: 0x007E7C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003D4C RID: 15692 RVA: 0x007E9A3C File Offset: 0x007E7C3C
	internal static bool LaUtix5Ly5kmDXV9gqNe()
	{
		return true;
	}

	// Token: 0x06003D4D RID: 15693 RVA: 0x007E9A40 File Offset: 0x007E7C40
	internal static bool GSccFw5LSWSGESJMoMvC()
	{
		return false;
	}

	// Token: 0x04004A86 RID: 19078
	public CharacterControl mChar;

	// Token: 0x04004A87 RID: 19079
	public AudioClip footStep_left;

	// Token: 0x04004A88 RID: 19080
	public AudioClip footStep_right;

	// Token: 0x04004A89 RID: 19081
	public AudioClip nAttack_vc;

	// Token: 0x04004A8A RID: 19082
	public GameObject nAttack_hit;

	// Token: 0x04004A8B RID: 19083
	public GameObject devilCannon;

	// Token: 0x04004A8C RID: 19084
	public AudioClip devilCannon_vc;

	// Token: 0x04004A8D RID: 19085
	public GameObject devilCannon_hit;

	// Token: 0x04004A8E RID: 19086
	public GameObject devilBeam_charge;

	// Token: 0x04004A8F RID: 19087
	public AudioClip kaiser_openFx;

	// Token: 0x04004A90 RID: 19088
	public AudioClip devilBeam1_vc;

	// Token: 0x04004A91 RID: 19089
	public GameObject devilBeam;

	// Token: 0x04004A92 RID: 19090
	public AudioClip devilBeam2_vc;

	// Token: 0x04004A93 RID: 19091
	public AudioClip kaiser_cryFx;

	// Token: 0x04004A94 RID: 19092
	public AudioClip ko_vc;

	// Token: 0x02000AD2 RID: 2770
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30622 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D4E RID: 15694 RVA: 0x007E9A44 File Offset: 0x007E7C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30622(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
		{
			if (295835 - 506397 != -210561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91963 - 75570 != 16394)
				{
					base..ctor();
					if (24066 - 349158 != -325091)
					{
						this.$mPos$30635 = mPos;
						if (137747 - 103087 != 34661)
						{
							this.$tDir$30636 = tDir;
							if (31967 - 125941 != -93973)
							{
								this.$self_$30637 = self_;
								if (211604 - 350399 == -138795)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x007E9B20 File Offset: 0x007E7D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_nAttack$30622.$(this.$mPos$30635, this.$tDir$30636, this.$self_$30637);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x007E9B3C File Offset: 0x007E7D3C
		internal static bool Xxus685Lo4d7EIBMTLb8()
		{
			return true;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x007E9B40 File Offset: 0x007E7D40
		internal static bool cAf7ox5LEP2XZsnUcYEO()
		{
			return false;
		}

		// Token: 0x04004A95 RID: 19093
		internal Vector3 $mPos$30635;

		// Token: 0x04004A96 RID: 19094
		internal Vector3 $tDir$30636;

		// Token: 0x04004A97 RID: 19095
		internal DevilKaiser $self_$30637;

		// Token: 0x02000AD3 RID: 2771
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D52 RID: 15698 RVA: 0x007E9B44 File Offset: 0x007E7D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
			{
				if (52130 - 65924 != -13794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160118 - 162825 != -2706)
					{
						base..ctor();
						if (7652 - 364587 != -356934)
						{
							this.$mPos$30632 = mPos;
							if (66363 - 8178 != 58186)
							{
								this.$tDir$30633 = tDir;
								if (114861 - 190720 == -75859)
								{
									this.$self_$30634 = self_;
									if (102138 - 99462 == 2676)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D53 RID: 15699 RVA: 0x007E9C20 File Offset: 0x007E7E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188735 - 546623 != -357887)
				{
				}
				for (;;)
				{
					IL_6E0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_166A;
					case 2:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_5DC;
						}
						if (232374 - 97599 != 134775)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (299191 - 261000 != 38191)
							{
								continue;
							}
							goto IL_5DC;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)2;
							if (215349 - 120756 != 94594)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_59F;
						}
						if (163588 - 84165 != 79423)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (96614 - 61921 != 34694)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$hitLayer$30623 = 130816 - (1 << this.$self_$30634.gameObject.layer);
							if (66968 - 543420 == -476451)
							{
								continue;
							}
							this.$hitList$30624 = null;
							if (120083 - 270326 != -150243)
							{
								continue;
							}
							this.$hitPos$30625 = default(Vector3);
							if (218949 - 56507 == 162443)
							{
								continue;
							}
							if (!this.$self_$30634.mChar.isMine)
							{
								goto IL_461;
							}
							if (270776 - 561510 != -290734)
							{
								continue;
							}
							this.$hitList$30624 = Damage.FindRecTarget(this.$self_$30634.transform.position + this.$self_$30634.transform.right, this.$self_$30634.transform.forward, (float)3, (float)3, (float)6, (float)4, this.$hitLayer$30623);
							if (50334 - 419702 == -369367)
							{
								continue;
							}
							this.$$iterator$10632$30627 = UnityRuntimeServices.GetEnumerator(this.$hitList$30624);
							if (124387 - 523368 != -398981)
							{
								continue;
							}
							while (this.$$iterator$10632$30627.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10632$30627.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30626 = (GameObject)obj2;
								if (5176 - 171303 != -166127)
								{
									goto IL_6E0;
								}
								if (this.$self_$30634.mChar.hit(1, this.$hitObject$30626, (int)(0.5f * (float)this.$self_$30634.mChar.atk), 1, 0, (float)2 * this.$self_$30634.transform.forward) != 0)
								{
									if (35058 - 184690 != -149632)
									{
										goto IL_6E0;
									}
									this.$hitPos$30625 = this.$hitObject$30626.collider.ClosestPointOnBounds(this.$self_$30634.transform.position + this.$self_$30634.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (273938 - 375498 != -101560)
									{
										goto IL_6E0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10632$30627, this.$hitObject$30626);
									if (112619 - 366829 != -254210)
									{
										goto IL_6E0;
									}
									this.$self_$30634.RPC_nAttack_hit(this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
									if (60203 - 307684 != -247481)
									{
										goto IL_6E0;
									}
									if (PhotonClient.IsInitialized())
									{
										if (118296 - 399265 == -280968)
										{
											goto IL_6E0;
										}
										this.$self_$30634.ActionEvent("RPC_nAttack_hit", this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
										if (278157 - 64945 == 213213)
										{
											goto IL_6E0;
										}
									}
									this.$self_$30634.mChar.sp = this.$self_$30634.mChar.sp + 1;
									if (241486 - 452084 == -210597)
									{
										goto IL_6E0;
									}
								}
							}
							if (218472 - 597426 != -378953)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_C67;
						}
						if (190708 - 280242 == -89533)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (245366 - 349515 != -104149)
							{
								continue;
							}
							goto IL_C67;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)0;
							if (29876 - 451791 != -421914)
							{
								goto Block_82;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_1FD;
						}
						if (72093 - 489277 == -417183)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (232699 - 519637 != -286937)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)3;
							if (266936 - 400412 != -133475)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_1639;
						}
						if (116908 - 469930 != -353022)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (227209 - 439972 != -212763)
							{
								continue;
							}
							goto IL_1639;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)5;
							if (144273 - 408788 != -264514)
							{
								goto Block_138;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_C36;
						}
						if (106841 - 470365 != -363524)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (255252 - 515722 != -260469)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)2;
							if (31637 - 159723 != -128086)
							{
								continue;
							}
							goto IL_13BB;
						}
						break;
					case 8:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_14A4;
						}
						if (123728 - 320632 != -196904)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (41943 - 556107 != -514164)
							{
								continue;
							}
							goto IL_14A4;
						}
						else
						{
							if (!this.$self_$30634.mChar.isMine)
							{
								goto IL_FB2;
							}
							if (263448 - 352723 == -89274)
							{
								continue;
							}
							this.$hitList$30624 = Damage.FindRecTarget(this.$self_$30634.transform.position, this.$self_$30634.transform.forward, (float)2, (float)2, (float)5, (float)4, this.$hitLayer$30623);
							if (261262 - 163861 == 97402)
							{
								continue;
							}
							this.$$iterator$10633$30629 = UnityRuntimeServices.GetEnumerator(this.$hitList$30624);
							if (130354 - 144437 == -14082)
							{
								continue;
							}
							while (this.$$iterator$10633$30629.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10633$30629.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30628 = (GameObject)obj4;
								if (129608 - 532134 == -402525)
								{
									goto IL_6E0;
								}
								if (this.$self_$30634.mChar.hit(2, this.$hitObject$30628, (int)(0.6f * (float)this.$self_$30634.mChar.atk), 1, 0, (float)2 * this.$self_$30634.transform.forward) != 0)
								{
									if (57946 - 349007 != -291061)
									{
										goto IL_6E0;
									}
									this.$hitPos$30625 = this.$hitObject$30628.collider.ClosestPointOnBounds(this.$self_$30634.transform.position + this.$self_$30634.transform.TransformDirection(0.2f, (float)2, 2.4f));
									if (70748 - 357534 == -286785)
									{
										goto IL_6E0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10633$30629, this.$hitObject$30628);
									if (43777 - 528329 == -484551)
									{
										goto IL_6E0;
									}
									this.$self_$30634.RPC_nAttack_hit(this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
									if (191631 - 222090 == -30458)
									{
										goto IL_6E0;
									}
									if (PhotonClient.IsInitialized())
									{
										if (18156 - 360607 != -342451)
										{
											goto IL_6E0;
										}
										this.$self_$30634.ActionEvent("RPC_nAttack_hit", this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
										if (198093 - 201163 != -3070)
										{
											goto IL_6E0;
										}
									}
								}
							}
							if (261867 - 89746 != 172122)
							{
								goto Block_106;
							}
							continue;
						}
						break;
					case 9:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_1283;
						}
						if (33333 - 256267 != -222934)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (179988 - 24345 != 155644)
							{
								goto Block_132;
							}
							continue;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)0;
							if (176201 - 429181 != -252980)
							{
								continue;
							}
							goto IL_1169;
						}
						break;
					case 10:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_2A3;
						}
						if (172236 - 509183 != -336947)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (62757 - 252144 != -189387)
							{
								continue;
							}
							goto IL_2A3;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)2;
							if (211421 - 556565 != -345144)
							{
								continue;
							}
							goto IL_A2B;
						}
						break;
					case 11:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_156;
						}
						if (79739 - 444600 == -364860)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (134920 - 257654 != -122734)
							{
								continue;
							}
							goto IL_156;
						}
						else
						{
							if (!this.$self_$30634.mChar.isMine)
							{
								goto IL_E43;
							}
							if (119681 - 60965 == 58717)
							{
								continue;
							}
							this.$hitList$30624 = Damage.FindRecTarget(this.$self_$30634.transform.position + this.$self_$30634.transform.TransformDirection((float)-1, 0.5f, (float)-2), this.$self_$30634.transform.forward, 3.5f * this.$self_$30634.mChar.rangeMod, 3.5f * this.$self_$30634.mChar.rangeMod, (float)7 * this.$self_$30634.mChar.rangeMod, (float)4 * this.$self_$30634.mChar.rangeMod, this.$hitLayer$30623);
							if (137386 - 53118 == 84269)
							{
								continue;
							}
							this.$$iterator$10634$30631 = UnityRuntimeServices.GetEnumerator(this.$hitList$30624);
							if (130215 - 597419 == -467203)
							{
								continue;
							}
							while (this.$$iterator$10634$30631.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10634$30631.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$30630 = (GameObject)obj6;
								if (138749 - 578315 != -439566)
								{
									goto IL_6E0;
								}
								if (this.$self_$30634.mChar.hit(3, this.$hitObject$30630, (int)(0.65f * (float)this.$self_$30634.mChar.atk), 1, 0, (float)2 * this.$self_$30634.transform.forward) != 0)
								{
									if (47624 - 257905 == -210280)
									{
										goto IL_6E0;
									}
									this.$hitPos$30625 = this.$hitObject$30630.collider.ClosestPointOnBounds(this.$self_$30634.transform.position + this.$self_$30634.transform.TransformDirection(0.5f, (float)2, (float)3));
									if (199684 - 372995 == -173310)
									{
										goto IL_6E0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10634$30631, this.$hitObject$30630);
									if (171805 - 51655 != 120150)
									{
										goto IL_6E0;
									}
									this.$self_$30634.RPC_nAttack_hit(this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
									if (191486 - 549169 != -357683)
									{
										goto IL_6E0;
									}
									if (PhotonClient.IsInitialized())
									{
										if (235256 - 219425 != 15831)
										{
											goto IL_6E0;
										}
										this.$self_$30634.ActionEvent("RPC_nAttack_hit", this.$hitPos$30625, this.$self_$30634.transform.forward, 0);
										if (278059 - 90266 != 187793)
										{
											goto IL_6E0;
										}
									}
									this.$self_$30634.mChar.sp = this.$self_$30634.mChar.sp + 1;
									if (262175 - 26040 != 236135)
									{
										goto IL_6E0;
									}
								}
							}
							if (165872 - 362373 != -196500)
							{
								goto Block_76;
							}
							continue;
						}
						break;
					case 12:
						if (this.$self_$30634.mChar.actionState != "attack")
						{
							goto IL_AB4;
						}
						if (54487 - 584943 == -530455)
						{
							continue;
						}
						if (this.$self_$30634.mChar.myCommand != "nAttack")
						{
							if (62529 - 553509 != -490980)
							{
								continue;
							}
							goto IL_AB4;
						}
						else
						{
							this.$self_$30634.mChar.moveSpeed = (float)0;
							if (184779 - 275280 != -90501)
							{
								continue;
							}
							goto IL_3B1;
						}
						break;
					case 13:
						if (this.$self_$30634.mChar.actionState == "attack")
						{
							if (128437 - 372113 != -243676)
							{
								continue;
							}
							if (this.$self_$30634.mChar.myCommand == "nAttack")
							{
								if (295345 - 215251 == 80095)
								{
									continue;
								}
								this.$self_$30634.mChar.actionState = "standby";
								if (122382 - 403825 != -281443)
								{
									continue;
								}
								this.$self_$30634.mChar.actionTime = Time.time;
								if (134833 - 253195 == -118361)
								{
									continue;
								}
								this.$self_$30634.mChar.myCommand = "none";
								if (38563 - 89537 != -50974)
								{
									continue;
								}
								if (!this.$self_$30634.mChar.isMine)
								{
									if (272838 - 320404 == -47565)
									{
										continue;
									}
									this.$self_$30634.mChar.nPosition = this.$self_$30634.transform.position;
									if (55217 - 193447 == -138229)
									{
										continue;
									}
									this.$self_$30634.mChar.oPosition = this.$self_$30634.transform.position;
									if (35127 - 450733 == -415605)
									{
										continue;
									}
									this.$self_$30634.mChar.nDirection = this.$self_$30634.transform.forward;
									if (21398 - 450806 != -429408)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (80773 - 158294 != -77521)
						{
							continue;
						}
						goto IL_166A;
					default:
						if (203027 - 230220 == -27192)
						{
							continue;
						}
						break;
					}
					this.$self_$30634.mChar.actionState = "attack";
					if (148727 - 106271 != 42457)
					{
						this.$self_$30634.mChar.actionTime = Time.time;
						if (64673 - 60111 == 4562)
						{
							this.$self_$30634.mChar.myCommand = "nAttack";
							if (290812 - 186440 == 104372)
							{
								this.$self_$30634.mChar.addTimeOut("nAttack", (float)4);
								if (229414 - 291065 != -61650)
								{
									this.$self_$30634.transform.position = this.$mPos$30632;
									if (47327 - 469888 != -422560)
									{
										this.$self_$30634.transform.LookAt(this.$mPos$30632 + global::Math.vFlat(this.$tDir$30633));
										if (150446 - 447421 != -296974)
										{
											this.$self_$30634.animation.CrossFade("punch");
											if (73194 - 424617 == -351423)
											{
												this.$self_$30634.animation.wrapMode = WrapMode.Once;
												if (289684 - 238691 != 50994)
												{
													this.$self_$30634.mChar.vMovement = this.$self_$30634.transform.forward;
													if (204396 - 481544 == -277148)
													{
														this.$self_$30634.mChar.moveSpeed = (float)0;
														if (5210 - 590759 != -585548)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_A4;
															}
															if (25609 - 303100 == -277491)
															{
																if (UnityEngine.Random.Range(0, 2) != 0)
																{
																	goto IL_A4;
																}
																if (68350 - 587897 != -519546)
																{
																	if (this.$self_$30634.nAttack_vc)
																	{
																		if (47561 - 322124 == -274563)
																		{
																			this.$self_$30634.audio.PlayOneShot(this.$self_$30634.nAttack_vc);
																			if (237871 - 178993 == 58878)
																			{
																				goto IL_F5A;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find nAttack voice");
																		if (137491 - 226397 != -88905)
																		{
																			goto Block_93;
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
				Block_6:
				goto IL_59F;
				IL_A4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_10:
				goto IL_461;
				IL_156:
				Block_16:
				IL_1FD:
				goto IL_166A;
				Block_18:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_2A3:
				Block_26:
				goto IL_1FD;
				IL_3B1:
				return this.Yield(13, new WaitForSeconds(0.3f));
				IL_461:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_59F:
				IL_5DC:
				goto IL_166A;
				Block_44:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A2B:
				return this.Yield(11, new WaitForSeconds(0.2f));
				IL_AB4:
				goto IL_166A;
				Block_76:
				goto IL_E43;
				IL_C36:
				IL_C67:
				goto IL_166A;
				Block_82:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_E43:
				return this.Yield(12, new WaitForSeconds(0.1f));
				IL_F5A:
				Block_93:
				goto IL_A4;
				IL_FB2:
				return this.Yield(9, new WaitForSeconds(0.1f));
				Block_106:
				goto IL_FB2;
				IL_1169:
				return this.Yield(10, new WaitForSeconds(0.4f));
				IL_1283:
				goto IL_166A;
				IL_13BB:
				return this.Yield(8, new WaitForSeconds(0.1f));
				IL_14A4:
				Block_132:
				IL_1639:
				goto IL_166A;
				Block_138:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_166A:
				return false;
			}

			// Token: 0x06003D54 RID: 15700 RVA: 0x007EB2AC File Offset: 0x007E94AC
			internal static bool cr4ghJ5L2J3nnBHvL1Mx()
			{
				return true;
			}

			// Token: 0x06003D55 RID: 15701 RVA: 0x007EB2B0 File Offset: 0x007E94B0
			internal static bool m0U0ny5L8bt9ciL4emWy()
			{
				return false;
			}

			// Token: 0x04004A98 RID: 19096
			internal int $hitLayer$30623;

			// Token: 0x04004A99 RID: 19097
			internal UnityScript.Lang.Array $hitList$30624;

			// Token: 0x04004A9A RID: 19098
			internal Vector3 $hitPos$30625;

			// Token: 0x04004A9B RID: 19099
			internal GameObject $hitObject$30626;

			// Token: 0x04004A9C RID: 19100
			internal IEnumerator $$iterator$10632$30627;

			// Token: 0x04004A9D RID: 19101
			internal GameObject $hitObject$30628;

			// Token: 0x04004A9E RID: 19102
			internal IEnumerator $$iterator$10633$30629;

			// Token: 0x04004A9F RID: 19103
			internal GameObject $hitObject$30630;

			// Token: 0x04004AA0 RID: 19104
			internal IEnumerator $$iterator$10634$30631;

			// Token: 0x04004AA1 RID: 19105
			internal Vector3 $mPos$30632;

			// Token: 0x04004AA2 RID: 19106
			internal Vector3 $tDir$30633;

			// Token: 0x04004AA3 RID: 19107
			internal DevilKaiser $self_$30634;
		}
	}

	// Token: 0x02000AD4 RID: 2772
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_devilCannon$30638 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D56 RID: 15702 RVA: 0x007EB2B4 File Offset: 0x007E94B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_devilCannon$30638(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
		{
			if (133679 - 593370 != -459690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111726 - 435109 == -323383)
				{
					base..ctor();
					if (288540 - 70775 != 217766)
					{
						this.$mPos$30645 = mPos;
						if (224061 - 332794 == -108733)
						{
							this.$tDir$30646 = tDir;
							if (279385 - 465465 != -186079)
							{
								this.$self_$30647 = self_;
								if (3451 - 394781 == -391330)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x007EB390 File Offset: 0x007E9590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_devilCannon$30638.$(this.$mPos$30645, this.$tDir$30646, this.$self_$30647);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x007EB3AC File Offset: 0x007E95AC
		internal static bool anLdYb5LZxOssIZ9Xe8O()
		{
			return true;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x007EB3B0 File Offset: 0x007E95B0
		internal static bool vHHg3y5LCCPYCtHGyuup()
		{
			return false;
		}

		// Token: 0x04004AA4 RID: 19108
		internal Vector3 $mPos$30645;

		// Token: 0x04004AA5 RID: 19109
		internal Vector3 $tDir$30646;

		// Token: 0x04004AA6 RID: 19110
		internal DevilKaiser $self_$30647;

		// Token: 0x02000AD5 RID: 2773
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D5A RID: 15706 RVA: 0x007EB3B4 File Offset: 0x007E95B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
			{
				if (95425 - 215656 != -120231)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174010 - 426232 != -252221)
					{
						base..ctor();
						if (83061 - 133185 == -50124)
						{
							this.$mPos$30642 = mPos;
							if (211367 - 589376 != -378008)
							{
								this.$tDir$30643 = tDir;
								if (221212 - 542265 != -321052)
								{
									this.$self_$30644 = self_;
									if (103635 - 451175 == -347540)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D5B RID: 15707 RVA: 0x007EB490 File Offset: 0x007E9690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234144 - 469817 != -235672)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A20;
					case 2:
						if (this.$self_$30644.mChar.actionState != "attack")
						{
							goto IL_958;
						}
						if (23574 - 401192 == -377617)
						{
							continue;
						}
						if (this.$self_$30644.mChar.myCommand != "devilCannon")
						{
							if (15789 - 578224 != -562434)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$i$30639 = 0;
							if (286378 - 121323 != 165056)
							{
								goto IL_75B;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30644.mChar.actionState != "attack")
						{
							goto IL_3D0;
						}
						if (36298 - 326300 != -290002)
						{
							continue;
						}
						if (this.$self_$30644.mChar.myCommand != "devilCannon")
						{
							if (216538 - 250554 != -34015)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$i$30639++;
							if (283382 - 272588 != 10795)
							{
								goto IL_75B;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30644.mChar.actionState == "attack")
						{
							if (97550 - 52906 == 44645)
							{
								continue;
							}
							if (this.$self_$30644.mChar.myCommand == "devilCannon")
							{
								if (95326 - 570292 != -474966)
								{
									continue;
								}
								this.$self_$30644.mChar.actionState = "standby";
								if (35739 - 329977 == -294237)
								{
									continue;
								}
								this.$self_$30644.mChar.actionTime = Time.time;
								if (173067 - 280373 != -107306)
								{
									continue;
								}
								this.$self_$30644.mChar.myCommand = "none";
								if (115004 - 321031 != -206027)
								{
									continue;
								}
								if (!this.$self_$30644.mChar.isMine)
								{
									if (181294 - 528752 != -347458)
									{
										continue;
									}
									this.$self_$30644.mChar.nPosition = this.$self_$30644.transform.position;
									if (18767 - 93818 != -75051)
									{
										continue;
									}
									this.$self_$30644.mChar.oPosition = this.$self_$30644.transform.position;
									if (278415 - 532413 == -253997)
									{
										continue;
									}
									this.$self_$30644.mChar.nDirection = this.$self_$30644.transform.forward;
									if (288789 - 441831 != -153042)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (38636 - 409795 != -371158)
						{
							goto Block_5;
						}
						continue;
					default:
						if (281816 - 213459 != 68357)
						{
							continue;
						}
						break;
					}
					this.$self_$30644.mChar.actionState = "attack";
					if (11807 - 88757 == -76949)
					{
						continue;
					}
					this.$self_$30644.mChar.actionTime = Time.time;
					if (117289 - 574097 != -456808)
					{
						continue;
					}
					this.$self_$30644.mChar.myCommand = "devilCannon";
					if (18492 - 509511 == -491018)
					{
						continue;
					}
					this.$self_$30644.mChar.addTimeOut("devilCannon", (float)6);
					if (23194 - 78993 != -55799)
					{
						continue;
					}
					this.$self_$30644.transform.position = this.$mPos$30642;
					if (298881 - 439578 != -140697)
					{
						continue;
					}
					this.$self_$30644.transform.LookAt(this.$mPos$30642 + global::Math.vFlat(this.$tDir$30643));
					if (264901 - 152577 == 112325)
					{
						continue;
					}
					this.$self_$30644.animation.CrossFade("devilMissile");
					if (225663 - 166443 != 59220)
					{
						continue;
					}
					this.$self_$30644.animation.wrapMode = WrapMode.Once;
					if (203314 - 549610 != -346296)
					{
						continue;
					}
					this.$self_$30644.mChar.vMovement = this.$self_$30644.transform.forward;
					if (52187 - 273804 != -221617)
					{
						continue;
					}
					this.$self_$30644.mChar.moveSpeed = (float)0;
					if (75598 - 96987 != -21389)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_52F;
					}
					if (33143 - 169874 != -136731)
					{
						continue;
					}
					if (UnityEngine.Random.Range(0, 2) != 0)
					{
						goto IL_52F;
					}
					if (46967 - 277024 == -230056)
					{
						continue;
					}
					if (this.$self_$30644.devilCannon_vc)
					{
						if (193021 - 105323 != 87698)
						{
							continue;
						}
						this.$self_$30644.audio.PlayOneShot(this.$self_$30644.devilCannon_vc);
						if (52791 - 134492 != -81701)
						{
							continue;
						}
						goto IL_8EE;
					}
					else
					{
						Debug.LogError("Cannot find devilCannon voice");
						if (69509 - 274747 != -205238)
						{
							continue;
						}
						goto IL_52F;
					}
					IL_75B:
					if (this.$i$30639 >= 4)
					{
						if (40927 - 217252 != -176324)
						{
							goto Block_48;
						}
					}
					else
					{
						if (this.$self_$30644.devilCannon)
						{
							if (106037 - 404831 == -298793)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30644.devilCannon, this.$self_$30644.transform.position + this.$self_$30644.transform.TransformDirection(-2.5f, (float)4, (float)4), this.$self_$30644.transform.rotation);
							if (202646 - 48026 != 154620)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30644.devilCannon, this.$self_$30644.transform.position + this.$self_$30644.transform.TransformDirection(2.5f, (float)4, (float)4), this.$self_$30644.transform.rotation);
							if (208578 - 286330 == -77751)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Cannot find devilCannon");
							if (261893 - 326032 != -64139)
							{
								continue;
							}
						}
						if (!this.$self_$30644.mChar.isMine)
						{
							goto IL_450;
						}
						if (93537 - 180324 == -86787)
						{
							this.$hitPos1$30640 = global::Math.getSpawnPos(this.$self_$30644.transform.position + this.$tDir$30643 + this.$self_$30644.transform.TransformDirection((float)-3, (float)0, (float)(this.$i$30639 - 1)));
							if (4373 - 451935 != -447561)
							{
								this.$hitPos2$30641 = global::Math.getSpawnPos(this.$self_$30644.transform.position + this.$tDir$30643 + this.$self_$30644.transform.TransformDirection((float)3, (float)0, (float)(this.$i$30639 - 1)));
								if (237332 - 44671 != 192662)
								{
									this.$self_$30644.RPC_devilCannon_hit(this.$hitPos1$30640, this.$self_$30644.transform.forward, 0);
									if (298054 - 9709 != 288346)
									{
										this.$self_$30644.RPC_devilCannon_hit(this.$hitPos2$30641, this.$self_$30644.transform.forward, 0);
										if (38342 - 245020 != -206677)
										{
											if (PhotonClient.IsInitialized())
											{
												if (2108 - 525821 == -523712)
												{
													continue;
												}
												this.$self_$30644.ActionEvent("RPC_devilCannon_hit", this.$hitPos1$30640, this.$self_$30644.transform.forward, 0);
												if (72735 - 212333 != -139598)
												{
													continue;
												}
											}
											if (!PhotonClient.IsInitialized())
											{
												goto IL_450;
											}
											if (46886 - 367727 != -320840)
											{
												this.$self_$30644.ActionEvent("RPC_devilCannon_hit", this.$hitPos2$30641, this.$self_$30644.transform.forward, 0);
												if (45805 - 61426 != -15620)
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
				}
				Block_5:
				Block_19:
				IL_3D0:
				goto IL_A20;
				IL_450:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_52F:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_48:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8EE:
				goto IL_52F;
				Block_57:
				goto IL_450;
				IL_958:
				Block_62:
				IL_A20:
				return false;
			}

			// Token: 0x06003D5C RID: 15708 RVA: 0x007EBED0 File Offset: 0x007EA0D0
			internal static bool CFBiUu5LL18MyyiY2Nse()
			{
				return true;
			}

			// Token: 0x06003D5D RID: 15709 RVA: 0x007EBED4 File Offset: 0x007EA0D4
			internal static bool K4vRiy5LOpI6yKRo9W66()
			{
				return false;
			}

			// Token: 0x04004AA7 RID: 19111
			internal int $i$30639;

			// Token: 0x04004AA8 RID: 19112
			internal Vector3 $hitPos1$30640;

			// Token: 0x04004AA9 RID: 19113
			internal Vector3 $hitPos2$30641;

			// Token: 0x04004AAA RID: 19114
			internal Vector3 $mPos$30642;

			// Token: 0x04004AAB RID: 19115
			internal Vector3 $tDir$30643;

			// Token: 0x04004AAC RID: 19116
			internal DevilKaiser $self_$30644;
		}
	}

	// Token: 0x02000AD6 RID: 2774
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_devilBeam1$30648 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x007EBED8 File Offset: 0x007EA0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_devilBeam1$30648(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
		{
			if (13297 - 505692 != -492395)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80511 - 320317 == -239806)
				{
					base..ctor();
					if (115928 - 433309 != -317380)
					{
						this.$mPos$30652 = mPos;
						if (241785 - 461257 != -219471)
						{
							this.$tDir$30653 = tDir;
							if (266945 - 437773 != -170827)
							{
								this.$self_$30654 = self_;
								if (157126 - 143130 != 13997)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x007EBFB4 File Offset: 0x007EA1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_devilBeam1$30648.$(this.$mPos$30652, this.$tDir$30653, this.$self_$30654);
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x007EBFD0 File Offset: 0x007EA1D0
		internal static bool SI5FGt5LmW4F7wHvAGFd()
		{
			return true;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x007EBFD4 File Offset: 0x007EA1D4
		internal static bool cKmWcN5LF9B2VliP8oSv()
		{
			return false;
		}

		// Token: 0x04004AAD RID: 19117
		internal Vector3 $mPos$30652;

		// Token: 0x04004AAE RID: 19118
		internal Vector3 $tDir$30653;

		// Token: 0x04004AAF RID: 19119
		internal DevilKaiser $self_$30654;

		// Token: 0x02000AD7 RID: 2775
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D62 RID: 15714 RVA: 0x007EBFD8 File Offset: 0x007EA1D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
			{
				if (114934 - 503749 != -388814)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119150 - 356816 != -237665)
					{
						base..ctor();
						if (183831 - 372246 != -188414)
						{
							this.$mPos$30649 = mPos;
							if (216380 - 488518 == -272138)
							{
								this.$tDir$30650 = tDir;
								if (127714 - 592803 == -465089)
								{
									this.$self_$30651 = self_;
									if (279236 - 223909 != 55328)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D63 RID: 15715 RVA: 0x007EC0B4 File Offset: 0x007EA2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81743 - 392346 != -310602)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_52A;
					case 1:
						goto IL_7D6;
					case 2:
						if (this.$self_$30651.mChar.actionState != "attack")
						{
							goto IL_73A;
						}
						if (39805 - 47795 != -7990)
						{
							continue;
						}
						if (this.$self_$30651.mChar.myCommand != "devilBeam1")
						{
							if (148064 - 530078 != -382013)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30651.kaiser_openFx)
							{
								goto IL_481;
							}
							if (259054 - 250856 != 8198)
							{
								continue;
							}
							this.$self_$30651.audio.PlayOneShot(this.$self_$30651.kaiser_openFx);
							if (70369 - 357269 != -286900)
							{
								continue;
							}
							goto IL_481;
						}
						break;
					case 3:
						if (this.$self_$30651.mChar.actionState != "attack")
						{
							goto IL_6AE;
						}
						if (119045 - 141940 != -22895)
						{
							continue;
						}
						if (this.$self_$30651.mChar.myCommand != "devilBeam1")
						{
							if (157368 - 181459 != -24091)
							{
								continue;
							}
							goto IL_6AE;
						}
						else
						{
							this.$self_$30651.animation.CrossFade("beam2");
							if (253877 - 45199 == 208679)
							{
								continue;
							}
							this.$self_$30651.animation.wrapMode = WrapMode.Loop;
							if (46313 - 516293 == -469979)
							{
								continue;
							}
							if (this.$self_$30651.devilBeam_charge)
							{
								if (217782 - 422674 != -204892)
								{
									continue;
								}
								this.$self_$30651.mChar.createEffect(this.$self_$30651.devilBeam_charge, this.$self_$30651.transform.position, this.$self_$30651.transform.rotation);
								if (238356 - 473192 == -234835)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find devilBeam_charge");
								if (151456 - 236765 != -85309)
								{
									continue;
								}
							}
							if (!this.$self_$30651.mChar.isControlled)
							{
								goto IL_402;
							}
							if (194974 - 503412 != -308438)
							{
								continue;
							}
						}
						break;
					case 4:
						break;
					case 5:
						if (this.$self_$30651.mChar.actionState != "attack")
						{
							goto IL_26D;
						}
						if (207557 - 107061 != 100496)
						{
							continue;
						}
						if (this.$self_$30651.mChar.myCommand != "devilBeam1")
						{
							if (266494 - 446850 != -180356)
							{
								continue;
							}
							goto IL_26D;
						}
						else
						{
							if (!this.$self_$30651.mChar.isMine)
							{
								goto IL_227;
							}
							if (216536 - 72119 != 144417)
							{
								continue;
							}
							this.$self_$30651.StartCoroutine_Auto(this.$self_$30651.RPC_devilBeam2(this.$self_$30651.transform.position, this.$self_$30651.transform.forward, 0));
							if (92898 - 485352 != -392454)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_227;
							}
							if (214843 - 502035 != -287192)
							{
								continue;
							}
							this.$self_$30651.ActionEvent("RPC_devilBeam2", this.$self_$30651.transform.position, this.$self_$30651.transform.forward, 0);
							if (15332 - 43579 != -28247)
							{
								continue;
							}
							goto IL_227;
						}
						break;
					default:
						if (277363 - 378652 != -101288)
						{
							goto IL_52A;
						}
						continue;
					}
					if (this.$self_$30651.mChar.actionState == "attack")
					{
						if (198968 - 21136 != 177832)
						{
							continue;
						}
						if (this.$self_$30651.mChar.myCommand == "devilBeam1")
						{
							goto IL_30A;
						}
						if (76444 - 377166 != -300722)
						{
							continue;
						}
					}
					IL_227:
					this.YieldDefault(1);
					if (134161 - 499321 != -365159)
					{
						break;
					}
					continue;
					IL_52A:
					this.$self_$30651.mChar.actionState = "attack";
					if (126923 - 578938 != -452014)
					{
						this.$self_$30651.mChar.actionTime = Time.time;
						if (299206 - 538855 != -239648)
						{
							this.$self_$30651.mChar.myCommand = "devilBeam1";
							if (116196 - 22102 != 94095)
							{
								this.$self_$30651.mChar.vMovement = Vector3.zero;
								if (256434 - 307374 == -50940)
								{
									this.$self_$30651.transform.position = this.$mPos$30649;
									if (89923 - 34511 == 55412)
									{
										this.$self_$30651.transform.LookAt(this.$mPos$30649 + global::Math.vFlat(this.$tDir$30650));
										if (167076 - 80943 == 86133)
										{
											this.$self_$30651.animation.CrossFade("beam1");
											if (126388 - 277670 == -151282)
											{
												this.$self_$30651.animation.wrapMode = WrapMode.Once;
												if (4615 - 431710 != -427094)
												{
													this.$self_$30651.mChar.vMovement = this.$self_$30651.transform.forward;
													if (69216 - 437378 != -368161)
													{
														this.$self_$30651.mChar.moveSpeed = (float)0;
														if (212325 - 26950 == 185375)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_12D;
															}
															if (97429 - 372012 != -274582)
															{
																if (this.$self_$30651.devilBeam1_vc)
																{
																	if (112068 - 44528 != 67541)
																	{
																		this.$self_$30651.audio.PlayOneShot(this.$self_$30651.devilBeam1_vc);
																		if (272677 - 433704 != -161026)
																		{
																			goto Block_12;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find devilBeam1 voice");
																	if (273320 - 288963 != -15642)
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
				}
				Block_7:
				goto IL_73A;
				IL_12D:
				return this.Yield(2, new WaitForSeconds(1.2f));
				Block_12:
				goto IL_12D;
				IL_26D:
				goto IL_7D6;
				IL_30A:
				return this.YieldDefault(4);
				Block_26:
				goto IL_12D;
				IL_402:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_481:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_6AE:
				IL_73A:
				IL_7D6:
				return false;
			}

			// Token: 0x06003D64 RID: 15716 RVA: 0x007EC8AC File Offset: 0x007EAAAC
			internal static bool wKLdZt5LMvFf2NXG496u()
			{
				return true;
			}

			// Token: 0x06003D65 RID: 15717 RVA: 0x007EC8B0 File Offset: 0x007EAAB0
			internal static bool DAVWJN5LxCXJgUJsVaWF()
			{
				return false;
			}

			// Token: 0x04004AB0 RID: 19120
			internal Vector3 $mPos$30649;

			// Token: 0x04004AB1 RID: 19121
			internal Vector3 $tDir$30650;

			// Token: 0x04004AB2 RID: 19122
			internal DevilKaiser $self_$30651;
		}
	}

	// Token: 0x02000AD8 RID: 2776
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_devilBeam2$30655 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D66 RID: 15718 RVA: 0x007EC8B4 File Offset: 0x007EAAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_devilBeam2$30655(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
		{
			if (35333 - 268469 != -233135)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199000 - 307573 == -108573)
				{
					base..ctor();
					if (85571 - 234290 == -148719)
					{
						this.$mPos$30665 = mPos;
						if (148725 - 68941 != 79785)
						{
							this.$tDir$30666 = tDir;
							if (111786 - 256817 == -145031)
							{
								this.$self_$30667 = self_;
								if (245259 - 409546 != -164286)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x007EC990 File Offset: 0x007EAB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_devilBeam2$30655.$(this.$mPos$30665, this.$tDir$30666, this.$self_$30667);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x007EC9AC File Offset: 0x007EABAC
		internal static bool Vn6sFx5Lg9XoG2L2MuUY()
		{
			return true;
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x007EC9B0 File Offset: 0x007EABB0
		internal static bool JLag6P5LfoTt7MaUKBwo()
		{
			return false;
		}

		// Token: 0x04004AB3 RID: 19123
		internal Vector3 $mPos$30665;

		// Token: 0x04004AB4 RID: 19124
		internal Vector3 $tDir$30666;

		// Token: 0x04004AB5 RID: 19125
		internal DevilKaiser $self_$30667;

		// Token: 0x02000AD9 RID: 2777
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D6A RID: 15722 RVA: 0x007EC9B4 File Offset: 0x007EABB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DevilKaiser self_)
			{
				if (152378 - 354885 != -202506)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231912 - 287929 != -56016)
					{
						base..ctor();
						if (45719 - 492975 == -447256)
						{
							this.$mPos$30662 = mPos;
							if (57731 - 24593 != 33139)
							{
								this.$tDir$30663 = tDir;
								if (197800 - 311421 != -113620)
								{
									this.$self_$30664 = self_;
									if (52823 - 499122 != -446298)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D6B RID: 15723 RVA: 0x007ECA90 File Offset: 0x007EAC90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269643 - 196501 != 73143)
				{
				}
				for (;;)
				{
					IL_3DA:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B79;
					case 2:
						if (this.$self_$30664.mChar.actionState != "attack")
						{
							goto IL_B48;
						}
						if (172690 - 561177 != -388487)
						{
							continue;
						}
						if (this.$self_$30664.mChar.myCommand != "devilBeam2")
						{
							if (161420 - 591619 != -430199)
							{
								continue;
							}
							goto IL_B48;
						}
						else
						{
							this.$self_$30664.mChar.moveSpeed = (float)0;
							if (211341 - 477439 == -266097)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (122155 - 67857 == 54299)
								{
									continue;
								}
								if (this.$self_$30664.devilBeam2_vc)
								{
									if (38167 - 378071 == -339903)
									{
										continue;
									}
									this.$self_$30664.audio.PlayOneShot(this.$self_$30664.devilBeam2_vc);
									if (12821 - 385911 == -373089)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find devilBeam2 voice");
									if (69041 - 428333 == -359291)
									{
										continue;
									}
								}
							}
							this.$hitLayer$30657 = 130816 - (1 << this.$self_$30664.gameObject.layer);
							if (127459 - 13806 == 113654)
							{
								continue;
							}
							this.$hitList$30658 = null;
							if (202916 - 520633 != -317717)
							{
								continue;
							}
							this.$i$30659 = 0;
							if (37553 - 420580 != -383027)
							{
								continue;
							}
							goto IL_3B4;
						}
						break;
					case 3:
						if (this.$self_$30664.mChar.actionState != "attack")
						{
							goto IL_4E0;
						}
						if (107337 - 408961 != -301624)
						{
							continue;
						}
						if (this.$self_$30664.mChar.myCommand != "devilBeam2")
						{
							if (9844 - 342651 != -332806)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$i$30659++;
							if (125213 - 201682 != -76469)
							{
								continue;
							}
							goto IL_3B4;
						}
						break;
					case 4:
						if (this.$self_$30664.mChar.actionState != "attack")
						{
							goto IL_6C7;
						}
						if (98138 - 395900 != -297762)
						{
							continue;
						}
						if (this.$self_$30664.mChar.myCommand != "devilBeam2")
						{
							if (88881 - 556287 != -467405)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$self_$30664.animation.Play("beam0");
							if (240396 - 162652 == 77745)
							{
								continue;
							}
							this.$self_$30664.animation.wrapMode = WrapMode.Once;
							if (19478 - 465449 != -445970)
							{
								goto Block_65;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30664.mChar.actionState == "attack")
						{
							if (283282 - 56536 != 226746)
							{
								continue;
							}
							if (this.$self_$30664.mChar.myCommand == "devilBeam2")
							{
								if (192663 - 324829 == -132165)
								{
									continue;
								}
								this.$self_$30664.mChar.moveSpeed = (float)0;
								if (284473 - 54730 == 229744)
								{
									continue;
								}
								this.$self_$30664.mChar.actionState = "standby";
								if (22093 - 528900 == -506806)
								{
									continue;
								}
								this.$self_$30664.mChar.actionTime = Time.time;
								if (63234 - 573115 == -509880)
								{
									continue;
								}
								this.$self_$30664.mChar.myCommand = "none";
								if (131271 - 549905 == -418633)
								{
									continue;
								}
								if (!this.$self_$30664.mChar.isMine)
								{
									if (215587 - 531811 == -316223)
									{
										continue;
									}
									this.$self_$30664.mChar.nPosition = this.$self_$30664.transform.position;
									if (99599 - 217203 == -117603)
									{
										continue;
									}
									this.$self_$30664.mChar.oPosition = this.$self_$30664.transform.position;
									if (194107 - 73698 != 120409)
									{
										continue;
									}
									this.$self_$30664.mChar.nDirection = this.$self_$30664.transform.forward;
									if (298040 - 164717 == 133324)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (194593 - 466135 != -271542)
						{
							continue;
						}
						goto IL_B79;
					default:
						if (48672 - 24431 == 24242)
						{
							continue;
						}
						break;
					}
					this.$self_$30664.mChar.actionState = "attack";
					if (8482 - 249097 != -240615)
					{
						continue;
					}
					this.$self_$30664.mChar.myCommand = "devilBeam2";
					if (169637 - 299907 == -130269)
					{
						continue;
					}
					this.$self_$30664.mChar.actionTime = Time.time;
					if (159997 - 54000 == 105998)
					{
						continue;
					}
					this.$self_$30664.mChar.vMovement = Vector3.zero;
					if (202635 - 63141 != 139494)
					{
						continue;
					}
					this.$self_$30664.mChar.addTimeOut("devilBeam", (float)60);
					if (63403 - 473231 == -409827)
					{
						continue;
					}
					this.$self_$30664.transform.position = this.$mPos$30662;
					if (174966 - 278503 == -103536)
					{
						continue;
					}
					this.$self_$30664.transform.LookAt(this.$mPos$30662 + global::Math.vFlat(this.$tDir$30663));
					if (225638 - 85294 != 140344)
					{
						continue;
					}
					this.$self_$30664.animation.Play("beam3");
					if (101761 - 476913 != -375152)
					{
						continue;
					}
					this.$self_$30664.animation.wrapMode = WrapMode.Once;
					if (236423 - 110833 != 125590)
					{
						continue;
					}
					this.$self_$30664.mChar.moveSpeed = (float)-2;
					if (134589 - 152297 == -17707)
					{
						continue;
					}
					this.$self_$30664.mChar.vMovement = this.$self_$30664.transform.forward;
					if (25331 - 401757 == -376425)
					{
						continue;
					}
					if (this.$self_$30664.devilBeam)
					{
						if (222778 - 163312 == 59467)
						{
							continue;
						}
						this.$self_$30664.mChar.createEffect(this.$self_$30664.devilBeam, this.$self_$30664.transform.position, this.$self_$30664.transform.rotation);
						if (154428 - 550682 != -396254)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Cannot find devilBeam");
						if (81633 - 590646 != -509013)
						{
							continue;
						}
					}
					this.$mCameraEffect$30656 = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
					if (183314 - 341790 != -158476)
					{
						continue;
					}
					this.$mCameraEffect$30656.AddColorRamp("kaiserRamp", "none", (float)0, new Vector4((float)0, 0.3f, 0.2f, 0.3f));
					if (95826 - 376681 != -280854)
					{
						break;
					}
					continue;
					IL_3B4:
					if (this.$i$30659 >= 5)
					{
						if (126499 - 472008 != -345508)
						{
							goto Block_26;
						}
					}
					else
					{
						if (!this.$self_$30664.mChar.isMine)
						{
							goto IL_893;
						}
						if (186796 - 533643 != -346846)
						{
							this.$hitList$30658 = Damage.FindRecTarget(this.$self_$30664.transform.position, this.$self_$30664.transform.forward, (float)4, (float)12, (float)24, (float)6, this.$hitLayer$30657);
							if (84463 - 538426 == -453963)
							{
								this.$$iterator$10635$30661 = UnityRuntimeServices.GetEnumerator(this.$hitList$30658);
								if (216302 - 248933 == -32631)
								{
									while (this.$$iterator$10635$30661.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10635$30661.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$30660 = (GameObject)obj2;
										if (164609 - 347654 == -183044)
										{
											goto IL_3DA;
										}
										this.$self_$30664.mChar.hit(21, this.$hitObject$30660, 450, 1, 1, this.$self_$30664.transform.forward);
										if (151219 - 416724 == -265504)
										{
											goto IL_3DA;
										}
										UnityRuntimeServices.Update(this.$$iterator$10635$30661, this.$hitObject$30660);
										if (224071 - 254882 != -30811)
										{
											goto IL_3DA;
										}
									}
									if (197161 - 440883 == -243722)
									{
										this.$self_$30664.mChar.sp = Mathf.Clamp(this.$self_$30664.mChar.sp - 15, 0, 100);
										if (213759 - 549630 != -335870)
										{
											goto Block_30;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_26:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_30:
				goto IL_893;
				IL_4E0:
				IL_6C7:
				goto IL_B79;
				IL_893:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_57:
				goto IL_4E0;
				Block_65:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_69:
				IL_B48:
				IL_B79:
				return false;
			}

			// Token: 0x06003D6C RID: 15724 RVA: 0x007ED628 File Offset: 0x007EB828
			internal static bool nl6PD15LnyiDJNdLuGA0()
			{
				return true;
			}

			// Token: 0x06003D6D RID: 15725 RVA: 0x007ED62C File Offset: 0x007EB82C
			internal static bool Bv9RE35L6iaGPTNHKmg7()
			{
				return false;
			}

			// Token: 0x04004AB6 RID: 19126
			internal CameraEffect $mCameraEffect$30656;

			// Token: 0x04004AB7 RID: 19127
			internal int $hitLayer$30657;

			// Token: 0x04004AB8 RID: 19128
			internal UnityScript.Lang.Array $hitList$30658;

			// Token: 0x04004AB9 RID: 19129
			internal int $i$30659;

			// Token: 0x04004ABA RID: 19130
			internal GameObject $hitObject$30660;

			// Token: 0x04004ABB RID: 19131
			internal IEnumerator $$iterator$10635$30661;

			// Token: 0x04004ABC RID: 19132
			internal Vector3 $mPos$30662;

			// Token: 0x04004ABD RID: 19133
			internal Vector3 $tDir$30663;

			// Token: 0x04004ABE RID: 19134
			internal DevilKaiser $self_$30664;
		}
	}

	// Token: 0x02000ADA RID: 2778
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_devilBeam0$30668 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D6E RID: 15726 RVA: 0x007ED630 File Offset: 0x007EB830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_devilBeam0$30668(Vector3 mPos, DevilKaiser self_)
		{
			if (158037 - 567788 != -409751)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36610 - 165370 != -128759)
				{
					base..ctor();
					if (248923 - 90084 == 158839)
					{
						this.$mPos$30671 = mPos;
						if (146568 - 587849 != -441280)
						{
							this.$self_$30672 = self_;
							if (284719 - 68521 == 216198)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x007ED6EC File Offset: 0x007EB8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_devilBeam0$30668.$(this.$mPos$30671, this.$self_$30672);
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x007ED700 File Offset: 0x007EB900
		internal static bool GIrDjM5LinFbxQl2Q6mB()
		{
			return true;
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x007ED704 File Offset: 0x007EB904
		internal static bool j25dbQ5LKnlNALb9o5Kb()
		{
			return false;
		}

		// Token: 0x04004ABF RID: 19135
		internal Vector3 $mPos$30671;

		// Token: 0x04004AC0 RID: 19136
		internal DevilKaiser $self_$30672;

		// Token: 0x02000ADB RID: 2779
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D72 RID: 15730 RVA: 0x007ED708 File Offset: 0x007EB908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, DevilKaiser self_)
			{
				if (70547 - 561741 != -491194)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265215 - 164247 == 100968)
					{
						base..ctor();
						if (8923 - 259891 == -250968)
						{
							this.$mPos$30669 = mPos;
							if (184848 - 266854 == -82006)
							{
								this.$self_$30670 = self_;
								if (174169 - 553666 != -379496)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D73 RID: 15731 RVA: 0x007ED7C4 File Offset: 0x007EB9C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39624 - 562714 != -523089)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26E;
					case 2:
						if (this.$self_$30670.mChar.actionState == "attack")
						{
							if (173515 - 58618 == 114898)
							{
								continue;
							}
							if (this.$self_$30670.mChar.myCommand == "devilBeam0")
							{
								if (270621 - 590469 == -319847)
								{
									continue;
								}
								this.$self_$30670.mChar.actionState = "standby";
								if (161035 - 71916 != 89119)
								{
									continue;
								}
								this.$self_$30670.mChar.actionTime = Time.time;
								if (181880 - 159644 != 22236)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (19400 - 94114 != -74713)
						{
							goto Block_2;
						}
						continue;
					default:
						if (133073 - 490878 != -357805)
						{
							continue;
						}
						break;
					}
					this.$self_$30670.mChar.actionState = "attack";
					if (48431 - 101245 == -52814)
					{
						this.$self_$30670.mChar.actionTime = Time.time;
						if (263272 - 204364 != 58909)
						{
							this.$self_$30670.mChar.myCommand = "devilBeam0";
							if (37340 - 435186 == -397846)
							{
								this.$self_$30670.mChar.vMovement = Vector3.zero;
								if (57708 - 467504 != -409795)
								{
									this.$self_$30670.transform.position = this.$mPos$30669;
									if (162032 - 183228 != -21195)
									{
										this.$self_$30670.animation.CrossFade("beam0");
										if (230315 - 251758 != -21442)
										{
											goto Block_6;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_26E;
				Block_6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_26E:
				return false;
			}

			// Token: 0x06003D74 RID: 15732 RVA: 0x007EDA54 File Offset: 0x007EBC54
			internal static bool scgAha5LdjdeV6tQ2G0G()
			{
				return true;
			}

			// Token: 0x06003D75 RID: 15733 RVA: 0x007EDA58 File Offset: 0x007EBC58
			internal static bool CkiAXf5LJftSsJvrwoil()
			{
				return false;
			}

			// Token: 0x04004AC1 RID: 19137
			internal Vector3 $mPos$30669;

			// Token: 0x04004AC2 RID: 19138
			internal DevilKaiser $self_$30670;
		}
	}

	// Token: 0x02000ADC RID: 2780
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30673 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D76 RID: 15734 RVA: 0x007EDA5C File Offset: 0x007EBC5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30673(UnityScript.Lang.Array nArray, DevilKaiser self_)
		{
			if (259768 - 368055 != -108286)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261876 - 208505 == 53371)
				{
					base..ctor();
					if (236268 - 398316 == -162048)
					{
						this.$nArray$30678 = nArray;
						if (83887 - 230553 != -146665)
						{
							this.$self_$30679 = self_;
							if (169716 - 293468 != -123751)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x007EDB18 File Offset: 0x007EBD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_ko$30673.$(this.$nArray$30678, this.$self_$30679);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x007EDB2C File Offset: 0x007EBD2C
		internal static bool eqGKUQ5LD2wtQ13PtMdR()
		{
			return true;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x007EDB30 File Offset: 0x007EBD30
		internal static bool hB2qwY5Lvcx8VOUGkYQI()
		{
			return false;
		}

		// Token: 0x04004AC3 RID: 19139
		internal UnityScript.Lang.Array $nArray$30678;

		// Token: 0x04004AC4 RID: 19140
		internal DevilKaiser $self_$30679;

		// Token: 0x02000ADD RID: 2781
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D7A RID: 15738 RVA: 0x007EDB34 File Offset: 0x007EBD34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, DevilKaiser self_)
			{
				if (228945 - 160053 != 68893)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275077 - 464548 == -189471)
					{
						base..ctor();
						if (267538 - 492513 == -224975)
						{
							this.$nArray$30676 = nArray;
							if (110208 - 523310 == -413102)
							{
								this.$self_$30677 = self_;
								if (98832 - 188441 != -89608)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D7B RID: 15739 RVA: 0x007EDBF0 File Offset: 0x007EBDF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69119 - 479197 != -410078)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$30677.mChar.actionState != "ko")
						{
							if (22024 - 8482 != 13542)
							{
								continue;
							}
							goto IL_3D7;
						}
						else
						{
							this.$self_$30677.animation.Play("getUp");
							if (107839 - 48285 != 59554)
							{
								continue;
							}
							this.$self_$30677.animation.wrapMode = WrapMode.Once;
							if (93006 - 144138 != -51132)
							{
								continue;
							}
							goto IL_163;
						}
						break;
					case 3:
						if (this.$self_$30677.mChar.actionState != "ko")
						{
							if (18495 - 400509 != -382014)
							{
								continue;
							}
							goto IL_3A3;
						}
						else
						{
							this.$self_$30677.mChar.actionState = "standby";
							if (211377 - 584051 == -372673)
							{
								continue;
							}
							this.$self_$30677.mChar.actionTime = Time.time;
							if (276556 - 220589 == 55968)
							{
								continue;
							}
							this.$self_$30677.mChar.myCommand = "none";
							if (239949 - 495419 == -255469)
							{
								continue;
							}
							this.$self_$30677.mChar.ko = this.$self_$30677.mChar.mko;
							if (33132 - 518215 == -485082)
							{
								continue;
							}
							this.YieldDefault(1);
							if (62945 - 14140 != 48806)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (120296 - 315087 == -194790)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30677.mChar.actionState == "ko")
					{
						break;
					}
					if (123002 - 128981 == -5979)
					{
						if (this.$self_$30677.mChar.actionState == "dead")
						{
							if (73617 - 537336 != -463718)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30674 = (Vector3)this.$nArray$30676[0];
							if (297909 - 187374 == 110535)
							{
								this.$mDir$30675 = (Vector3)this.$nArray$30676[1];
								if (68738 - 296933 == -228195)
								{
									this.$self_$30677.mChar.ko = 0;
									if (131584 - 23537 == 108047)
									{
										this.$self_$30677.mChar.actionState = "ko";
										if (73720 - 17445 == 56275)
										{
											this.$self_$30677.mChar.actionTime = Time.time;
											if (248996 - 409046 != -160049)
											{
												this.$self_$30677.mChar.myCommand = "none";
												if (141066 - 293056 != -151989)
												{
													this.$self_$30677.mChar.vMovement = Vector3.zero;
													if (151397 - 589647 == -438250)
													{
														this.$self_$30677.mChar.moveSpeed = (float)0;
														if (130274 - 234582 == -104308)
														{
															this.$self_$30677.animation.Play("ko");
															if (145810 - 163985 != -18174)
															{
																this.$self_$30677.animation.wrapMode = WrapMode.Once;
																if (82710 - 217070 == -134360)
																{
																	if (!this.$self_$30677.kaiser_cryFx)
																	{
																		goto IL_4A1;
																	}
																	if (116329 - 317856 == -201527)
																	{
																		this.$self_$30677.audio.PlayOneShot(this.$self_$30677.kaiser_cryFx);
																		if (269524 - 385077 != -115552)
																		{
																			goto Block_27;
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
				Block_3:
				goto IL_4F0;
				IL_163:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3A3:
				IL_3D7:
				goto IL_4F0;
				Block_27:
				IL_4A1:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4F0:
				return false;
			}

			// Token: 0x06003D7C RID: 15740 RVA: 0x007EE100 File Offset: 0x007EC300
			internal static bool xuAcRm5LR5Mque0IlIpv()
			{
				return true;
			}

			// Token: 0x06003D7D RID: 15741 RVA: 0x007EE104 File Offset: 0x007EC304
			internal static bool UlpgYg5LwpTKlZ4G2Imw()
			{
				return false;
			}

			// Token: 0x04004AC5 RID: 19141
			internal Vector3 $mPos$30674;

			// Token: 0x04004AC6 RID: 19142
			internal Vector3 $mDir$30675;

			// Token: 0x04004AC7 RID: 19143
			internal UnityScript.Lang.Array $nArray$30676;

			// Token: 0x04004AC8 RID: 19144
			internal DevilKaiser $self_$30677;
		}
	}

	// Token: 0x02000ADE RID: 2782
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30680 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D7E RID: 15742 RVA: 0x007EE108 File Offset: 0x007EC308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30680(UnityScript.Lang.Array nArray, DevilKaiser self_)
		{
			if (206631 - 487064 != -280432)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19802 - 140244 == -120442)
				{
					base..ctor();
					if (133612 - 181223 != -47610)
					{
						this.$nArray$30685 = nArray;
						if (58447 - 234240 == -175793)
						{
							this.$self_$30686 = self_;
							if (162495 - 161823 == 672)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x007EE1C4 File Offset: 0x007EC3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DevilKaiser.$RPC_dead$30680.$(this.$nArray$30685, this.$self_$30686);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x007EE1D8 File Offset: 0x007EC3D8
		internal static bool E1C6MN5LqilGqWuhasGW()
		{
			return true;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x007EE1DC File Offset: 0x007EC3DC
		internal static bool WmHXPl5L73mAUyyDrJcv()
		{
			return false;
		}

		// Token: 0x04004AC9 RID: 19145
		internal UnityScript.Lang.Array $nArray$30685;

		// Token: 0x04004ACA RID: 19146
		internal DevilKaiser $self_$30686;

		// Token: 0x02000ADF RID: 2783
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D82 RID: 15746 RVA: 0x007EE1E0 File Offset: 0x007EC3E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, DevilKaiser self_)
			{
				if (31772 - 78642 != -46869)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198836 - 206077 != -7240)
					{
						base..ctor();
						if (148463 - 426532 != -278068)
						{
							this.$nArray$30683 = nArray;
							if (135778 - 337098 == -201320)
							{
								this.$self_$30684 = self_;
								if (248386 - 177641 == 70745)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D83 RID: 15747 RVA: 0x007EE29C File Offset: 0x007EC49C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81787 - 198226 != -116439)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$30684.mChar.actionState != "dead")
						{
							if (54696 - 93752 != -39055)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30684.mChar.isPlayer)
							{
								if (191190 - 546304 != -355114)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30684.gameObject);
								if (201809 - 142511 != 59298)
								{
									continue;
								}
							}
							else if (this.$self_$30684.mChar.isMine)
							{
								if (168696 - 328433 == -159736)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30684.gameObject);
								if (189241 - 332095 != -142854)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (130186 - 106624 != 23563)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					default:
						if (90415 - 221692 != -131277)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30684.mChar.actionState == "dead")
					{
						if (225540 - 417136 == -191596)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30681 = (Vector3)this.$nArray$30683[0];
						if (125352 - 62281 != 63072)
						{
							this.$myDirection$30682 = (Vector3)this.$nArray$30683[1];
							if (93086 - 357977 != -264890)
							{
								this.$self_$30684.transform.position = this.$myPosition$30681;
								if (175535 - 381706 != -206170)
								{
									this.$self_$30684.transform.LookAt(this.$myPosition$30681 + this.$myDirection$30682);
									if (20148 - 503374 == -483226)
									{
										this.$self_$30684.mChar.hp = 0;
										if (27758 - 326145 == -298387)
										{
											this.$self_$30684.mChar.actionState = "dead";
											if (136645 - 531330 != -394684)
											{
												this.$self_$30684.mChar.actionTime = Time.time;
												if (211764 - 47895 != 163870)
												{
													this.$self_$30684.mChar.myCommand = "none";
													if (170516 - 301995 != -131478)
													{
														this.$self_$30684.mChar.vMovement = Vector3.zero;
														if (266841 - 292933 == -26092)
														{
															this.$self_$30684.mChar.moveSpeed = (float)0;
															if (220800 - 591434 != -370633)
															{
																this.$self_$30684.animation.Rewind();
																if (241426 - 89306 != 152121)
																{
																	this.$self_$30684.animation.Play("ko");
																	if (161089 - 237997 != -76907)
																	{
																		this.$self_$30684.animation.wrapMode = WrapMode.Once;
																		if (288924 - 481618 == -192694)
																		{
																			if (!this.$self_$30684.kaiser_cryFx)
																			{
																				goto IL_310;
																			}
																			if (161243 - 62028 == 99215)
																			{
																				this.$self_$30684.audio.PlayOneShot(this.$self_$30684.kaiser_cryFx);
																				if (164581 - 462337 != -297755)
																				{
																					goto Block_17;
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
				Block_12:
				goto IL_493;
				Block_17:
				goto IL_310;
				goto IL_493;
				IL_310:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_493:
				return false;
			}

			// Token: 0x06003D84 RID: 15748 RVA: 0x007EE750 File Offset: 0x007EC950
			internal static bool jtv3OC5LP7IpmjwlmMc4()
			{
				return true;
			}

			// Token: 0x06003D85 RID: 15749 RVA: 0x007EE754 File Offset: 0x007EC954
			internal static bool nZONTb5L0k7ohgMBnAGV()
			{
				return false;
			}

			// Token: 0x04004ACB RID: 19147
			internal Vector3 $myPosition$30681;

			// Token: 0x04004ACC RID: 19148
			internal Vector3 $myDirection$30682;

			// Token: 0x04004ACD RID: 19149
			internal UnityScript.Lang.Array $nArray$30683;

			// Token: 0x04004ACE RID: 19150
			internal DevilKaiser $self_$30684;
		}
	}
}
