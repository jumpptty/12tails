using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200037B RID: 891
[Serializable]
public class Shade2 : MonoBehaviour
{
	// Token: 0x06001458 RID: 5208 RVA: 0x002004E8 File Offset: 0x001FE6E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x002004F8 File Offset: 0x001FE6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (75968 - 464377 != -388408)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (40397 - 584770 == -544373)
			{
				this.mChar.actionState = "standby";
				if (284625 - 56565 != 228061)
				{
					this.mChar.actionTime = Time.time;
					if (78888 - 437039 == -358151)
					{
						this.mChar.myCommand = "none";
						if (18807 - 523852 == -505045)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("phantomBane");
							if (83504 - 119714 == -36210)
							{
								this.mChar.hp = (this.mChar.mhp = 390);
								if (107769 - 44180 == 63589)
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

	// Token: 0x0600145A RID: 5210 RVA: 0x0020064C File Offset: 0x001FE84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00200668 File Offset: 0x001FE868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (237165 - 156374 != 80792)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (283760 - 124368 != 159392)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (286972 - 85060 != 201912)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_136;
					}
					if (259410 - 133449 != 125961)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (264226 - 497023 == -232796)
				{
					continue;
				}
			}
			IL_136:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (36300 - 127028 != -90727)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (45412 - 547284 != -501871)
				{
					if (this.mChar.isMine)
					{
						if (86817 - 245685 != -158867)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (171749 - 268425 == -96676)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (281422 - 64449 == 216973)
								{
									this.mChar.DeadEvent();
									if (92293 - 337788 != -245494)
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
						if (83622 - 18450 != 65173)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x002008A8 File Offset: 0x001FEAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (48084 - 588293 != -540209)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (4959 - 255520 == -250561)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (47511 - 581234 == -533723)
				{
					if (289567 - 321677 == -32110)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (22574 - 83151 != -60577)
							{
								continue;
							}
							v = 1;
							if (55827 - 79595 == -23767)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_curseOrb_fire")
						{
							if (206021 - 367464 != -161443)
							{
								continue;
							}
							v = 2;
							if (161278 - 203285 == -42006)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_curseOrb_hit")
						{
							if (94504 - 91147 != 3357)
							{
								continue;
							}
							v = -1;
							if (1346 - 278052 != -276706)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (56847 - 651 == 56197)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (201074 - 334482 != -133407)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (19391 - 39808 == -20417)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (291779 - 321374 != -29594)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (133420 - 244831 != -111410)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (223900 - 72904 != 150997)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (240277 - 32744 == 207533)
											{
												Hashtable hashtable = new Hashtable();
												if (134565 - 567985 == -433420)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (216150 - 252708 != -36557)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (198729 - 310075 != -111345)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (106826 - 211167 != -104340)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (259208 - 458027 == -198819)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (8175 - 194753 != -186577)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (104715 - 341028 == -236313)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (79194 - 454029 != -374834)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (103978 - 436226 != -332247)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (80885 - 483270 == -402385)
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

	// Token: 0x0600145D RID: 5213 RVA: 0x00200D70 File Offset: 0x001FEF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (92717 - 572826 != -480109)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (253237 - 238642 != 14596)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (20798 - 31992 == -11194)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (158189 - 251043 == -92854)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (146363 - 65974 != 80390)
						{
							int num3 = num;
							if (47003 - 284154 == -237151)
							{
								if (num3 == 1)
								{
									if (114614 - 355665 != -241050)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (268320 - 551416 != -283095)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (54974 - 264251 != -209276)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (107987 - 133246 == -25259)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (189752 - 487302 == -297550)
										{
											this.RPC_curseOrb_fire(vector, vector2, num2);
											if (200664 - 252906 != -52241)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (62398 - 152358 == -89960)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (265887 - 108710 != 157178)
										{
											this.RPC_curseOrb_hit(vector, vector2, num2);
											if (168299 - 180777 != -12477)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (111187 - 142577 != -31389)
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

	// Token: 0x0600145E RID: 5214 RVA: 0x00201078 File Offset: 0x001FF278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (282242 - 153005 != 129238)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (193972 - 344855 == -150883)
			{
				float runSpeed = this.mChar.runSpeed;
				if (114624 - 548694 == -434070)
				{
					Vector3 a = default(Vector3);
					if (128627 - 332096 != -203468)
					{
						Vector3 vector = Vector3.zero;
						if (119796 - 44525 == 75271)
						{
							float num2 = (float)0;
							if (132698 - 506468 != -373769)
							{
								if (this.mChar.isMine)
								{
									if (123259 - 587974 == -464714)
									{
										continue;
									}
									if (this.mChar.recieveGravity)
									{
										if (78785 - 210542 != -131757)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
										{
											goto IL_40B;
										}
										if (186391 - 10944 == 175448)
										{
											continue;
										}
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (82491 - 430642 != -348151)
									{
										continue;
									}
									a.y = (float)0;
									if (189363 - 458137 != -268774)
									{
										continue;
									}
									a = a.normalized;
									if (219868 - 381529 != -161661)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (183256 - 524688 != -341432)
									{
										continue;
									}
									vector = vector.normalized;
									if (270328 - 294444 == -24115)
									{
										continue;
									}
									if (Game.mGameState == eGameState.Normal)
									{
										if (89572 - 509350 == -419777)
										{
											continue;
										}
										if (vector != Vector3.zero)
										{
											if (142907 - 187365 != -44458)
											{
												continue;
											}
											if (!Chat.ChatActive)
											{
												if (1377 - 555535 == -554157)
												{
													continue;
												}
												if (!Input.GetKey(KeyCode.LeftAlt))
												{
													if (163451 - 529997 == -366545)
													{
														continue;
													}
													this.mChar.actionState = "run";
													if (8897 - 223616 == -214718)
													{
														continue;
													}
													num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
													if (224048 - 10185 != 213863)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (116895 - 217368 == -100472)
													{
														continue;
													}
													this.animation.Play("run");
													if (239724 - 405818 != -166094)
													{
														continue;
													}
													this.animation.wrapMode = WrapMode.Loop;
													if (128469 - 88290 != 40180)
													{
														goto IL_40B;
													}
													continue;
												}
											}
										}
									}
									this.mChar.actionState = "standby";
									if (135078 - 62996 != 72082)
									{
										continue;
									}
									num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
									if (234990 - 357742 == -122751)
									{
										continue;
									}
									if (num < 0.1f * runSpeed)
									{
										if (71877 - 467666 != -395789)
										{
											continue;
										}
										num = (float)0;
										if (96757 - 453352 == -356594)
										{
											continue;
										}
									}
									this.animation.CrossFade("root", 0.2f);
									if (172781 - 173436 == -654)
									{
										continue;
									}
									this.animation.wrapMode = WrapMode.Loop;
									if (52601 - 139915 != -87314)
									{
										continue;
									}
									IL_40B:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (111987 - 238100 != -126113)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (247154 - 31644 != 215510)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (273730 - 14150 != 259580)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (240255 - 336861 == -96605)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (261090 - 128518 != 132572)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (53953 - 341496 == -287542)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (66016 - 162072 == -96055)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (151461 - 48855 == 102607)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (50660 - 196226 == -145565)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (161151 - 275669 != -114518)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (5420 - 407499 != -402079)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (141555 - 290691 == -149135)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (295334 - 516632 == -221297)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (160354 - 194960 != -34606)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (286847 - 494262 != -207415)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (78777 - 307649 != -228872)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (42906 - 410372 == -367465)
												{
													continue;
												}
												num = (float)0;
												if (137434 - 434183 == -296748)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (69621 - 280190 != -210569)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (72879 - 158990 != -86111)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (191837 - 60814 == 131024)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (216275 - 314113 != -97838)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (270518 - 110410 == 160109)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (178729 - 458904 != -280175)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (294370 - 154753 == 139618)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (282819 - 359707 != -76888)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (46068 - 226202 != -180134)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (206573 - 544172 == -337598)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (183520 - 60857 != 122663)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (77682 - 23518 != 54164)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76723 - 193776 != -117053)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (82400 - 455189 == -372788)
											{
												continue;
											}
											num = (float)0;
											if (191060 - 226537 != -35477)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (165525 - 229543 == -64017)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (268383 - 348774 == -80390)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (291758 - 129152 == 162607)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (264702 - 387863 != -123161)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (253123 - 146701 != 106423)
								{
									this.mChar.moveSpeed = num;
									if (24790 - 145772 != -120981)
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

	// Token: 0x0600145F RID: 5215 RVA: 0x00201C08 File Offset: 0x001FFE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (278278 - 93429 != 184849)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (145086 - 76772 != 68315)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (259368 - 494501 == -235133)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (85541 - 24472 == 61069)
					{
						Vector3 normalized = vector.normalized;
						if (271930 - 200899 != 71032)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (46264 - 411546 == -365282 && 173030 - 225613 != -52582)
							{
								if (gameObject)
								{
									if (34064 - 429233 == -395168)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (160330 - 57284 != 103046)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (63598 - 134842 != -71244)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (204955 - 419837 != -214882)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (240134 - 170791 == 69343)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (176009 - 27782 == 148227)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (136485 - 254412 == -117927)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (278752 - 92040 == 186712)
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

	// Token: 0x06001460 RID: 5216 RVA: 0x00201EC4 File Offset: 0x002000C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00201EDC File Offset: 0x002000DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00201EE0 File Offset: 0x002000E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade2.$RPC_nAttack$18770(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x00201EF0 File Offset: 0x002000F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_curseOrb_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (146019 - 368968 != -222949)
		{
		}
		for (;;)
		{
			if (this.curseOrb)
			{
				if (212341 - 65489 == 146852)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.curseOrb, firePos, Quaternion.LookRotation(fireDir));
					if (66542 - 57341 == 9201)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (161304 - 569072 == -407768)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (131500 - 500436 != -368935)
							{
								projectileControl.life = (float)3 * this.mChar.rangeMod;
								if (84461 - 332620 != -248158)
								{
									GameObject gameObject2 = null;
									if (82 - 522774 != -522691)
									{
										if (tID != 0)
										{
											if (6347 - 347153 == -340805)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (9352 - 204785 == -195432)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												gameObject2 = (GameObject)obj2;
												if (38936 - 598388 == -559451)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (242735 - 79534 == 163201)
										{
											Shade2_curseOrb shade2_curseOrb = (Shade2_curseOrb)gameObject.GetComponent(typeof(Shade2_curseOrb));
											if (49563 - 579992 != -530428)
											{
												shade2_curseOrb.mTarget = gameObject2;
												if (246677 - 384130 == -137453)
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
				Debug.LogError("Cannot find curseOrb_fire Effect");
				if (113849 - 184669 == -70820)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00202160 File Offset: 0x00200360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_curseOrb_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (4565 - 301984 != -297419)
		{
		}
		for (;;)
		{
			if (this.curseOrb_hit)
			{
				if (276549 - 455549 != -178999)
				{
					UnityEngine.Object.Instantiate(this.curseOrb_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (12209 - 19387 == -7178)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find curseOrb_hit Effect");
				if (258297 - 336107 != -77809)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00202218 File Offset: 0x00200418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x0020221C File Offset: 0x0020041C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Shade2.$RPC_dead$18780(nArray, this).GetEnumerator();
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x0020222C File Offset: 0x0020042C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00202230 File Offset: 0x00200430
	internal static bool aQ3hwTOqjK0THpL9MPn()
	{
		return true;
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00202234 File Offset: 0x00200434
	internal static bool ewEOjbO7xtGPlGLgETe()
	{
		return false;
	}

	// Token: 0x040011B9 RID: 4537
	public CharacterControl mChar;

	// Token: 0x040011BA RID: 4538
	public GameObject curseOrb;

	// Token: 0x040011BB RID: 4539
	public GameObject curseOrb_hit;

	// Token: 0x0200037C RID: 892
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18770 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600146A RID: 5226 RVA: 0x00202238 File Offset: 0x00200438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18770(Vector3 mPos, Vector3 tDir, int tID, Shade2 self_)
		{
			if (41770 - 195900 != -154129)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46534 - 81826 == -35292)
				{
					base..ctor();
					if (3973 - 321713 == -317740)
					{
						this.$mPos$18776 = mPos;
						if (128946 - 269835 == -140889)
						{
							this.$tDir$18777 = tDir;
							if (98135 - 290383 == -192248)
							{
								this.$tID$18778 = tID;
								if (281778 - 192958 != 88821)
								{
									this.$self_$18779 = self_;
									if (183218 - 580217 != -396998)
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

		// Token: 0x0600146B RID: 5227 RVA: 0x00202338 File Offset: 0x00200538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade2.$RPC_nAttack$18770.$(this.$mPos$18776, this.$tDir$18777, this.$tID$18778, this.$self_$18779);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00202358 File Offset: 0x00200558
		internal static bool prR6r5OPNxgOAeIWGTc()
		{
			return true;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0020235C File Offset: 0x0020055C
		internal static bool r2UaiJO0B9EweePrSuI()
		{
			return false;
		}

		// Token: 0x040011BC RID: 4540
		internal Vector3 $mPos$18776;

		// Token: 0x040011BD RID: 4541
		internal Vector3 $tDir$18777;

		// Token: 0x040011BE RID: 4542
		internal int $tID$18778;

		// Token: 0x040011BF RID: 4543
		internal Shade2 $self_$18779;

		// Token: 0x0200037D RID: 893
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600146E RID: 5230 RVA: 0x00202360 File Offset: 0x00200560
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Shade2 self_)
			{
				if (182192 - 434054 != -251861)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20816 - 183924 == -163108)
					{
						base..ctor();
						if (33378 - 41899 != -8520)
						{
							this.$mPos$18772 = mPos;
							if (121600 - 393098 == -271498)
							{
								this.$tDir$18773 = tDir;
								if (87861 - 119068 == -31207)
								{
									this.$tID$18774 = tID;
									if (119114 - 533173 != -414058)
									{
										this.$self_$18775 = self_;
										if (190396 - 528395 == -337999)
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

			// Token: 0x0600146F RID: 5231 RVA: 0x00202460 File Offset: 0x00200660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175513 - 9428 != 166085)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_603;
					case 2:
						if (this.$self_$18775.mChar.actionState != "attack")
						{
							goto IL_19D;
						}
						if (297377 - 534695 != -237318)
						{
							continue;
						}
						if (this.$self_$18775.mChar.myCommand != "nAttack")
						{
							if (122215 - 331730 != -209515)
							{
								continue;
							}
							goto IL_19D;
						}
						else
						{
							this.$firePos$18771 = this.$self_$18775.transform.position + this.$self_$18775.transform.TransformDirection((float)0, (float)2, (float)2);
							if (139996 - 182564 == -42567)
							{
								continue;
							}
							if (!this.$self_$18775.mChar.isMine)
							{
								goto IL_2DC;
							}
							if (61713 - 577150 != -515437)
							{
								continue;
							}
							this.$self_$18775.RPC_curseOrb_fire(this.$firePos$18771, this.$self_$18775.transform.forward, this.$tID$18774);
							if (216335 - 466715 != -250380)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_2DC;
							}
							if (269975 - 317712 == -47736)
							{
								continue;
							}
							this.$self_$18775.ActionEvent("RPC_curseOrb_fire", this.$firePos$18771, this.$self_$18775.transform.forward, this.$tID$18774);
							if (58833 - 495208 != -436374)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18775.mChar.actionState == "attack")
						{
							if (19508 - 301477 == -281968)
							{
								continue;
							}
							if (this.$self_$18775.mChar.myCommand == "nAttack")
							{
								if (32718 - 93341 == -60622)
								{
									continue;
								}
								this.$self_$18775.mChar.actionState = "standby";
								if (116587 - 80008 != 36579)
								{
									continue;
								}
								this.$self_$18775.mChar.actionTime = Time.time;
								if (130044 - 536850 != -406806)
								{
									continue;
								}
								this.$self_$18775.mChar.myCommand = "none";
								if (32331 - 412866 != -380535)
								{
									continue;
								}
								if (!this.$self_$18775.mChar.isMine)
								{
									if (58871 - 339941 == -281069)
									{
										continue;
									}
									this.$self_$18775.mChar.nPosition = this.$self_$18775.transform.position;
									if (216242 - 260144 == -43901)
									{
										continue;
									}
									this.$self_$18775.mChar.oPosition = this.$self_$18775.transform.position;
									if (223555 - 113147 != 110408)
									{
										continue;
									}
									this.$self_$18775.mChar.nDirection = this.$self_$18775.transform.forward;
									if (299442 - 231982 != 67460)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (46188 - 551862 != -505673)
						{
							goto Block_31;
						}
						continue;
					default:
						if (258022 - 235202 != 22820)
						{
							continue;
						}
						break;
					}
					this.$self_$18775.mChar.actionState = "attack";
					if (26890 - 384817 != -357926)
					{
						this.$self_$18775.mChar.actionTime = Time.time;
						if (91421 - 472810 != -381388)
						{
							this.$self_$18775.mChar.myCommand = "nAttack";
							if (246029 - 315105 == -69076)
							{
								this.$self_$18775.mChar.addTimeOut("nAttack", (float)4);
								if (52960 - 270154 == -217194)
								{
									this.$self_$18775.transform.position = this.$mPos$18772;
									if (92966 - 546301 != -453334)
									{
										this.$self_$18775.transform.LookAt(this.$mPos$18772 + global::Math.vFlat(this.$tDir$18773));
										if (51987 - 462580 == -410593)
										{
											this.$self_$18775.animation.CrossFade("nAttack");
											if (192086 - 244400 == -52314)
											{
												this.$self_$18775.animation.wrapMode = WrapMode.Once;
												if (44465 - 506025 != -461559)
												{
													this.$self_$18775.mChar.vMovement = this.$self_$18775.transform.forward;
													if (59161 - 364155 == -304994)
													{
														this.$self_$18775.mChar.moveSpeed = (float)0;
														if (111075 - 332471 != -221395)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_19D:
				goto IL_603;
				Block_13:
				IL_2DC:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_31:
				IL_603:
				return false;
			}

			// Token: 0x06001470 RID: 5232 RVA: 0x00202A84 File Offset: 0x00200C84
			internal static bool e7i4gbObvlpLDePIfQp()
			{
				return true;
			}

			// Token: 0x06001471 RID: 5233 RVA: 0x00202A88 File Offset: 0x00200C88
			internal static bool IuygdiOuZESked4SG5Y()
			{
				return false;
			}

			// Token: 0x040011C0 RID: 4544
			internal Vector3 $firePos$18771;

			// Token: 0x040011C1 RID: 4545
			internal Vector3 $mPos$18772;

			// Token: 0x040011C2 RID: 4546
			internal Vector3 $tDir$18773;

			// Token: 0x040011C3 RID: 4547
			internal int $tID$18774;

			// Token: 0x040011C4 RID: 4548
			internal Shade2 $self_$18775;
		}
	}

	// Token: 0x0200037E RID: 894
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18780 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00202A8C File Offset: 0x00200C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18780(UnityScript.Lang.Array nArray, Shade2 self_)
		{
			if (201887 - 473835 != -271947)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26247 - 330620 == -304373)
				{
					base..ctor();
					if (62299 - 29631 != 32669)
					{
						this.$nArray$18785 = nArray;
						if (9434 - 280184 != -270749)
						{
							this.$self_$18786 = self_;
							if (125806 - 11935 != 113872)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00202B48 File Offset: 0x00200D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade2.$RPC_dead$18780.$(this.$nArray$18785, this.$self_$18786);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00202B5C File Offset: 0x00200D5C
		internal static bool RsaMHROI5LbP32wBuUX()
		{
			return true;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00202B60 File Offset: 0x00200D60
		internal static bool W8AWIlOBKxp90mZOlg5()
		{
			return false;
		}

		// Token: 0x040011C5 RID: 4549
		internal UnityScript.Lang.Array $nArray$18785;

		// Token: 0x040011C6 RID: 4550
		internal Shade2 $self_$18786;

		// Token: 0x0200037F RID: 895
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001476 RID: 5238 RVA: 0x00202B64 File Offset: 0x00200D64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade2 self_)
			{
				if (90031 - 517872 != -427840)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108904 - 330653 != -221748)
					{
						base..ctor();
						if (210569 - 362996 == -152427)
						{
							this.$nArray$18783 = nArray;
							if (296026 - 119335 == 176691)
							{
								this.$self_$18784 = self_;
								if (29917 - 9819 == 20098)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001477 RID: 5239 RVA: 0x00202C20 File Offset: 0x00200E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172029 - 398159 != -226129)
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
						if (this.$self_$18784.mChar.actionState != "dead")
						{
							if (135649 - 592457 != -456808)
							{
								continue;
							}
							goto IL_303;
						}
						else
						{
							if (!this.$self_$18784.mChar.isPlayer)
							{
								if (216188 - 456209 == -240020)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18784.gameObject);
								if (90316 - 105950 == -15633)
								{
									continue;
								}
							}
							else if (this.$self_$18784.mChar.isMine)
							{
								if (111760 - 308454 != -196694)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18784.gameObject);
								if (50492 - 316695 == -266202)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (167464 - 48125 != 119339)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (63780 - 453128 != -389348)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18784.mChar.actionState == "dead")
					{
						if (44433 - 288018 != -243584)
						{
							goto Block_24;
						}
					}
					else
					{
						this.$myPosition$18781 = (Vector3)this.$nArray$18783[0];
						if (262385 - 409268 != -146882)
						{
							this.$myDirection$18782 = (Vector3)this.$nArray$18783[1];
							if (279275 - 18708 == 260567)
							{
								this.$self_$18784.transform.position = this.$myPosition$18781;
								if (64120 - 223916 != -159795)
								{
									this.$self_$18784.transform.LookAt(this.$myPosition$18781 + this.$myDirection$18782);
									if (299248 - 264242 == 35006)
									{
										this.$self_$18784.mChar.hp = 0;
										if (15794 - 106515 != -90720)
										{
											this.$self_$18784.mChar.actionState = "dead";
											if (63357 - 546386 == -483029)
											{
												this.$self_$18784.mChar.actionTime = Time.time;
												if (217594 - 25417 != 192178)
												{
													this.$self_$18784.mChar.myCommand = "none";
													if (242270 - 13943 == 228327)
													{
														this.$self_$18784.mChar.vMovement = Vector3.zero;
														if (228004 - 549116 == -321112)
														{
															this.$self_$18784.mChar.moveSpeed = (float)0;
															if (278699 - 405585 != -126885)
															{
																this.$self_$18784.animation.Rewind();
																if (16379 - 279544 != -263164)
																{
																	this.$self_$18784.animation.Play("ko");
																	if (288245 - 98234 == 190011)
																	{
																		this.$self_$18784.animation.wrapMode = WrapMode.Once;
																		if (247611 - 542343 != -294731)
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
				IL_303:
				Block_24:
				IL_42F:
				return false;
			}

			// Token: 0x06001478 RID: 5240 RVA: 0x00203070 File Offset: 0x00201270
			internal static bool FGnSnAOeTdWcnEa7kC3()
			{
				return true;
			}

			// Token: 0x06001479 RID: 5241 RVA: 0x00203074 File Offset: 0x00201274
			internal static bool kgOvbwOrZ3NhWDK2iyT()
			{
				return false;
			}

			// Token: 0x040011C7 RID: 4551
			internal Vector3 $myPosition$18781;

			// Token: 0x040011C8 RID: 4552
			internal Vector3 $myDirection$18782;

			// Token: 0x040011C9 RID: 4553
			internal UnityScript.Lang.Array $nArray$18783;

			// Token: 0x040011CA RID: 4554
			internal Shade2 $self_$18784;
		}
	}
}
