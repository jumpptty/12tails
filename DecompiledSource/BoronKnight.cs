using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200026A RID: 618
[Serializable]
public class BoronKnight : MonoBehaviour
{
	// Token: 0x06000E23 RID: 3619 RVA: 0x00168DB4 File Offset: 0x00166FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoronKnight()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00168DC4 File Offset: 0x00166FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (286331 - 331196 != -44865)
		{
		}
		for (;;)
		{
			this.pnRJQyeXf2 = this.transform;
			if (274133 - 405063 == -130930)
			{
				this.wUeJerBP1N = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (214925 - 122448 != 92478)
				{
					this.wUeJerBP1N.actionState = "standby";
					if (197949 - 84479 != 113471)
					{
						this.wUeJerBP1N.actionTime = Time.time;
						if (146458 - 303910 == -157452)
						{
							this.wUeJerBP1N.myCommand = "none";
							if (37747 - 336429 == -298682)
							{
								if (Game.mGameType == 99)
								{
									if (109539 - 482635 == -373095)
									{
										continue;
									}
									this.wUeJerBP1N.isMine = true;
									if (37507 - 429001 == -391493)
									{
										continue;
									}
								}
								this.wUeJerBP1N.hp = (this.wUeJerBP1N.mhp = 25000);
								if (183942 - 414619 != -230676)
								{
									this.wUeJerBP1N.ko = (this.wUeJerBP1N.mko = 999);
									if (23430 - 131930 != -108499)
									{
										this.wUeJerBP1N.atk = (this.wUeJerBP1N.def = 175);
										if (148613 - 373911 == -225298)
										{
											this.wUeJerBP1N.agi = 250;
											if (105689 - 403331 == -297642)
											{
												this.wUeJerBP1N.vit = 2500;
												if (235656 - 39225 != 196432)
												{
													this.wUeJerBP1N.mag = (this.wUeJerBP1N.cha = (this.wUeJerBP1N.tal = 50));
													if (262077 - 397640 != -135562)
													{
														this.wUeJerBP1N.lck = 100;
														if (91309 - 334192 != -242882)
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

	// Token: 0x06000E25 RID: 3621 RVA: 0x0016908C File Offset: 0x0016728C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_left);
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x001690A0 File Offset: 0x001672A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_right);
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x001690B4 File Offset: 0x001672B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (204776 - 318608 != -113832)
		{
		}
		for (;;)
		{
			if (this.wUeJerBP1N.isControlled)
			{
				if (291667 - 389841 != -98174)
				{
					continue;
				}
				if (!(this.wUeJerBP1N.actionState == "standby"))
				{
					if (52348 - 474722 != -422374)
					{
						continue;
					}
					if (!(this.wUeJerBP1N.actionState == "run"))
					{
						goto IL_4E;
					}
					if (214161 - 462814 != -248653)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (139000 - 459327 == -320326)
				{
					continue;
				}
			}
			IL_4E:
			if (this.wUeJerBP1N.hp > 0)
			{
				break;
			}
			if (29226 - 314504 == -285278)
			{
				if (!(this.wUeJerBP1N.actionState != "dead"))
				{
					break;
				}
				if (187231 - 7007 == 180224)
				{
					if (this.wUeJerBP1N.isMine)
					{
						if (176582 - 81729 != 94854)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (19134 - 597233 == -578099)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (231167 - 173492 != 57676)
								{
									this.wUeJerBP1N.DeadEvent();
									if (130017 - 418420 != -288402)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.wUeJerBP1N.hp = 1;
						if (165942 - 275747 == -109805)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x001692F4 File Offset: 0x001674F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (48163 - 283672 != -235509)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (241519 - 103012 == 138507)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (4783 - 34573 != -29789)
				{
					if (192230 - 17221 == 175009)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (266698 - 32093 == 234606)
							{
								continue;
							}
							v = 1;
							if (178228 - 492356 != -314128)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (89905 - 225784 == -135878)
							{
								continue;
							}
							v = 2;
							if (126590 - 526758 == -400167)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (57680 - 257677 == -199996)
							{
								continue;
							}
							v = -1;
							if (144350 - 335563 != -191213)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (185182 - 326835 == -141652)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (212899 - 12059 != 200841)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (70188 - 552444 != -482255)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (139245 - 251411 == -112166)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (76656 - 380273 != -303616)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (162704 - 310624 == -147920)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (150642 - 413334 == -262692)
											{
												Hashtable hashtable = new Hashtable();
												if (41659 - 450286 != -408626)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (72207 - 286751 == -214544)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (92626 - 307584 != -214957)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (125441 - 280980 != -155538)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (95289 - 232164 != -136874)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (211837 - 238938 != -27100)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (233103 - 205310 != 27794)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (213025 - 79722 == 133303)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (96774 - 390892 == -294118)
																				{
																					PhotonClient.SendEvent(this.wUeJerBP1N.ActorNr, 74, hashtable, true, true);
																					if (89166 - 437431 == -348265)
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

	// Token: 0x06000E29 RID: 3625 RVA: 0x001697BC File Offset: 0x001679BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (102201 - 118638 != -16436)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (280719 - 23182 == 257537)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (28422 - 354779 == -326357)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (10259 - 58670 == -48411)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (201788 - 409002 != -207213)
						{
							int num3 = num;
							if (225176 - 541187 == -316011)
							{
								if (num3 == 1)
								{
									if (102680 - 385880 != -283199)
									{
										if (this.wUeJerBP1N.isMine)
										{
											break;
										}
										if (190085 - 28173 != 161913)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (92533 - 171219 == -78686)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (57548 - 484629 != -427080)
									{
										if (this.wUeJerBP1N.isMine)
										{
											break;
										}
										if (68828 - 502956 == -434128)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (69718 - 519884 != -450165)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (225780 - 27673 == 198107)
									{
										if (this.wUeJerBP1N.isMine)
										{
											break;
										}
										if (18952 - 313128 != -294175)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (47458 - 211611 == -164153)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (262455 - 28360 != 234096)
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

	// Token: 0x06000E2A RID: 3626 RVA: 0x00169ACC File Offset: 0x00167CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (20357 - 471935 != -451578)
		{
		}
		for (;;)
		{
			float num = this.wUeJerBP1N.moveSpeed;
			if (192074 - 177619 == 14455)
			{
				float runSpeed = this.wUeJerBP1N.runSpeed;
				if (84586 - 489852 != -405265)
				{
					Vector3 a = default(Vector3);
					if (151329 - 436784 == -285455)
					{
						Vector3 vector = Vector3.zero;
						if (35926 - 330131 != -294204)
						{
							float num2 = (float)0;
							if (220713 - 525455 == -304742)
							{
								if (this.wUeJerBP1N.isMine)
								{
									if (237976 - 476015 != -238039)
									{
										continue;
									}
									if ((this.wUeJerBP1N.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (297724 - 381911 != -84187)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (63830 - 448993 != -385163)
										{
											continue;
										}
										a.y = (float)0;
										if (291900 - 35560 != 256340)
										{
											continue;
										}
										a = a.normalized;
										if (112839 - 104091 == 8749)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (18213 - 149154 == -130940)
										{
											continue;
										}
										vector = vector.normalized;
										if (299781 - 391017 == -91235)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (112507 - 66138 != 46369)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (137309 - 56343 == 80967)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (50583 - 5550 != 45033)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (713 - 287575 == -286861)
														{
															continue;
														}
														this.wUeJerBP1N.actionState = "run";
														if (52109 - 571231 != -519122)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (96680 - 457275 == -360594)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (259814 - 329028 != -69214)
														{
															continue;
														}
														this.animation.Play("run");
														if (97173 - 85365 != 11808)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (188417 - 405907 != -217490)
														{
															continue;
														}
														goto IL_22D;
													}
												}
											}
										}
										this.wUeJerBP1N.actionState = "standby";
										if (235727 - 101614 != 134113)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (171922 - 242186 != -70264)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (149730 - 159663 != -9933)
											{
												continue;
											}
											num = (float)0;
											if (106325 - 28294 != 78031)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (292925 - 289568 != 3357)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (127582 - 75838 != 51744)
										{
											continue;
										}
									}
									IL_22D:;
								}
								else
								{
									vector = global::Math.vFlat(this.wUeJerBP1N.nPosition - this.transform.position);
									if (53090 - 426606 == -373515)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (112879 - 83897 == 28983)
									{
										continue;
									}
									if (this.wUeJerBP1N.nSpeed != (float)0)
									{
										if (63633 - 484944 != -421311)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (222414 - 531643 != -309229)
											{
												continue;
											}
											this.transform.position = this.wUeJerBP1N.nPosition;
											if (50639 - 487106 == -436466)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (151313 - 58966 != 92347)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (96396 - 101292 == -4895)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (207105 - 569356 == -362250)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.wUeJerBP1N.nSpeed, (float)10 * Time.deltaTime);
												if (254359 - 447990 == -193630)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (208936 - 15865 == 193072)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (239912 - 95609 != 144303)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (4338 - 3108 == 1231)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (82858 - 507082 == -424223)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (215136 - 203898 == 11239)
											{
												continue;
											}
										}
										else if (Time.time > this.wUeJerBP1N.nSpeed + 0.3f)
										{
											if (253836 - 460227 == -206390)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (199999 - 398076 == -198076)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (17111 - 579987 != -562876)
												{
													continue;
												}
												num = (float)0;
												if (97145 - 343247 != -246102)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.wUeJerBP1N.nDirection);
											if (177779 - 544577 != -366798)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (131850 - 154765 != -22915)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (57948 - 209273 == -151324)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (88511 - 533002 == -444490)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (269190 - 346174 != -76984)
											{
												continue;
											}
											this.transform.position = this.wUeJerBP1N.nPosition;
											if (67105 - 279814 == -212708)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (120729 - 159377 == -38647)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (158823 - 479333 == -320509)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (147456 - 466192 != -318736)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (11820 - 500978 == -489157)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (126699 - 501333 == -374633)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (245808 - 196226 == 49583)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (128949 - 419062 != -290113)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.wUeJerBP1N.nDirection);
											if (112012 - 294943 == -182930)
											{
												continue;
											}
											num = (float)0;
											if (103161 - 400151 != -296990)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (20715 - 20423 == 293)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135714 - 22441 == 113274)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (37175 - 48940 != -11765)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (167191 - 210337 != -43146)
										{
											continue;
										}
									}
								}
								this.wUeJerBP1N.vMovement = vector;
								if (56521 - 530697 != -474175)
								{
									this.wUeJerBP1N.moveSpeed = num;
									if (81534 - 410807 != -329272)
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

	// Token: 0x06000E2B RID: 3627 RVA: 0x0016A630 File Offset: 0x00168830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (95244 - 503590 != -408346)
		{
		}
		for (;;)
		{
			if (!this.wUeJerBP1N.isMine)
			{
				if (290618 - 344289 != -53670)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (125156 - 259888 == -134732)
				{
					Vector3 vector = a - this.transform.position;
					if (75316 - 182326 == -107010)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (106298 - 121360 != -15061)
						{
							CharacterControl characterControl = null;
							if (178344 - 252560 != -74215 && 264157 - 15628 != 248530)
							{
								if (gameObject)
								{
									if (250684 - 236292 == 14393)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (207832 - 119041 == 88792)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (6962 - 283156 != -276194)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (179045 - 62565 == 116481)
									{
										continue;
									}
								}
								if (!(this.wUeJerBP1N.actionState == "standby"))
								{
									if (125054 - 439900 != -314846)
									{
										continue;
									}
									if (!(this.wUeJerBP1N.actionState == "run"))
									{
										break;
									}
									if (134414 - 405055 == -270640)
									{
										continue;
									}
								}
								if (this.wUeJerBP1N.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (286500 - 68355 == 218145)
								{
									if (UnityEngine.Random.Range(0, 2) == 0)
									{
										if (77128 - 230229 != -153100)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
											if (34183 - 500025 != -465841)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (262450 - 360914 != -98463)
												{
													this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
													if (180230 - 558430 == -378200)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
										if (207636 - 169084 == 38552)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (135530 - 422944 == -287414)
											{
												this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
												if (231235 - 300839 == -69604)
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

	// Token: 0x06000E2C RID: 3628 RVA: 0x0016A9E0 File Offset: 0x00168BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (281137 - 373686 != -92549)
		{
		}
		for (;;)
		{
			if (!this.wUeJerBP1N.isMine)
			{
				if (244063 - 11656 == 232407)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (275603 - 74685 != 200919)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (69680 - 382947 == -313267)
					{
						Vector3 normalized = vector.normalized;
						if (32126 - 339478 != -307351)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (157845 - 478156 != -320310)
							{
								CharacterControl characterControl = null;
								if (104171 - 190485 == -86314)
								{
									if (61359 - 169520 == -108161)
									{
										if (gameObject)
										{
											if (26649 - 455665 == -429015)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (237189 - 116079 == 121111)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (285755 - 36031 != 249724)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (158962 - 425171 == -266208)
											{
												continue;
											}
										}
										if (!(this.wUeJerBP1N.actionState == "standby"))
										{
											if (291413 - 189536 == 101878)
											{
												continue;
											}
											if (!(this.wUeJerBP1N.actionState == "run"))
											{
												break;
											}
											if (60552 - 396528 != -335976)
											{
												continue;
											}
										}
										if (this.wUeJerBP1N.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (163149 - 541261 != -378111)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (299555 - 426720 != -127164)
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

	// Token: 0x06000E2D RID: 3629 RVA: 0x0016ACAC File Offset: 0x00168EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x0016ACB0 File Offset: 0x00168EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BoronKnight.$RPC_nAttack1$17662(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x0016ACC0 File Offset: 0x00168EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BoronKnight.$RPC_nAttack2$17676(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x0016ACD0 File Offset: 0x00168ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (51386 - 450848 != -399462)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (31631 - 586169 == -554537)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (295686 - 52052 != 243634)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (184261 - 555909 == -371647)
				{
					continue;
				}
			}
			if (Time.time <= this.w3kJIHCQ0R)
			{
				break;
			}
			if (273906 - 340875 != -66968)
			{
				this.w3kJIHCQ0R = Time.time + 0.1f;
				if (282745 - 465127 == -182382)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (231714 - 2678 == 229036)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (78764 - 189527 != -110762)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x0016AE34 File Offset: 0x00169034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new BoronKnight.$RPC_ko$17688(nArray, this).GetEnumerator();
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0016AE44 File Offset: 0x00169044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new BoronKnight.$RPC_dead$17695(nArray, this).GetEnumerator();
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x0016AE54 File Offset: 0x00169054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x0016AE58 File Offset: 0x00169058
	internal static bool VpU8VCysYpfv8hmvMHB()
	{
		return true;
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x0016AE5C File Offset: 0x0016905C
	internal static bool nubTvGy92QvoBpT8P8D()
	{
		return false;
	}

	// Token: 0x04000C3B RID: 3131
	private Transform pnRJQyeXf2;

	// Token: 0x04000C3C RID: 3132
	private CharacterControl wUeJerBP1N;

	// Token: 0x04000C3D RID: 3133
	public AudioClip footStep_left;

	// Token: 0x04000C3E RID: 3134
	public AudioClip footStep_right;

	// Token: 0x04000C3F RID: 3135
	public GameObject nAttack1_ring;

	// Token: 0x04000C40 RID: 3136
	public GameObject nAttack2_ring;

	// Token: 0x04000C41 RID: 3137
	public GameObject nAttack_hit;

	// Token: 0x04000C42 RID: 3138
	public AudioClip nAttack_hitFX;

	// Token: 0x04000C43 RID: 3139
	private float w3kJIHCQ0R;

	// Token: 0x04000C44 RID: 3140
	public GameObject deadEffect;

	// Token: 0x0200026B RID: 619
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$17662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x0016AE60 File Offset: 0x00169060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$17662(Vector3 mPos, Vector3 tDir, BoronKnight self_)
		{
			if (269472 - 546208 != -276735)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239778 - 413594 != -173815)
				{
					base..ctor();
					if (260007 - 567774 != -307766)
					{
						this.$mPos$17673 = mPos;
						if (4211 - 80401 == -76190)
						{
							this.$tDir$17674 = tDir;
							if (17781 - 418752 == -400971)
							{
								this.$self_$17675 = self_;
								if (122304 - 12564 == 109740)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0016AF3C File Offset: 0x0016913C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BoronKnight.$RPC_nAttack1$17662.$(this.$mPos$17673, this.$tDir$17674, this.$self_$17675);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0016AF58 File Offset: 0x00169158
		internal static bool Fyk28ny15MOXDppHO3g()
		{
			return true;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0016AF5C File Offset: 0x0016915C
		internal static bool PCjkevy4WFOLnRLaH4P()
		{
			return false;
		}

		// Token: 0x04000C45 RID: 3141
		internal Vector3 $mPos$17673;

		// Token: 0x04000C46 RID: 3142
		internal Vector3 $tDir$17674;

		// Token: 0x04000C47 RID: 3143
		internal BoronKnight $self_$17675;

		// Token: 0x0200026C RID: 620
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E3A RID: 3642 RVA: 0x0016AF60 File Offset: 0x00169160
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BoronKnight self_)
			{
				if (208056 - 428926 != -220869)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67375 - 520276 != -452900)
					{
						base..ctor();
						if (193002 - 258912 != -65909)
						{
							this.$mPos$17670 = mPos;
							if (41686 - 53191 != -11504)
							{
								this.$tDir$17671 = tDir;
								if (283926 - 158254 == 125672)
								{
									this.$self_$17672 = self_;
									if (194031 - 40382 == 153649)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E3B RID: 3643 RVA: 0x0016B03C File Offset: 0x0016923C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214925 - 529620 != -314694)
				{
				}
				for (;;)
				{
					IL_5C3:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C95;
					case 2:
						if (this.$self_$17672.wUeJerBP1N.actionState != "attack")
						{
							goto IL_2B2;
						}
						if (27111 - 566768 != -539657)
						{
							continue;
						}
						if (this.$self_$17672.wUeJerBP1N.myCommand != "nAttack1")
						{
							if (44242 - 93273 != -49031)
							{
								continue;
							}
							goto IL_2B2;
						}
						else
						{
							this.$self_$17672.wUeJerBP1N.moveSpeed = (float)7;
							if (81648 - 243100 != -161451)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17672.wUeJerBP1N.actionState != "attack")
						{
							goto IL_740;
						}
						if (240584 - 552114 == -311529)
						{
							continue;
						}
						if (this.$self_$17672.wUeJerBP1N.myCommand != "nAttack1")
						{
							if (298266 - 188680 != 109587)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17663 = 130816 - (1 << this.$self_$17672.gameObject.layer);
							if (297273 - 98394 == 198880)
							{
								continue;
							}
							this.$hitList$17664 = null;
							if (180540 - 13659 == 166882)
							{
								continue;
							}
							this.$hitPoint$17665 = default(Vector3);
							if (259874 - 140221 != 119653)
							{
								continue;
							}
							if (!this.$self_$17672.wUeJerBP1N.isMine)
							{
								goto IL_BBE;
							}
							if (209996 - 293584 != -83588)
							{
								continue;
							}
							this.$hitList$17664 = Damage.FindRecTarget(this.$self_$17672.pnRJQyeXf2.position, this.$self_$17672.pnRJQyeXf2.forward, 1.5f, 1.5f, (float)3, (float)3, this.$hitLayer$17663);
							if (74430 - 71468 != 2962)
							{
								continue;
							}
							this.$$iterator$10052$17667 = UnityRuntimeServices.GetEnumerator(this.$hitList$17664);
							if (103074 - 272835 == -169760)
							{
								continue;
							}
							while (this.$$iterator$10052$17667.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10052$17667.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17666 = (GameObject)obj2;
								if (254961 - 97781 != 157180)
								{
									goto IL_5C3;
								}
								if (this.$self_$17672.wUeJerBP1N.hit(1, this.$hitObject$17666, this.$self_$17672.wUeJerBP1N.atk, 10, 0, 0.5f * this.$self_$17672.pnRJQyeXf2.forward) != 0)
								{
									if (146869 - 106149 == 40721)
									{
										goto IL_5C3;
									}
									this.$hitPoint$17665 = this.$hitObject$17666.collider.ClosestPointOnBounds(this.$self_$17672.pnRJQyeXf2.position + (float)2 * Vector3.up);
									if (105568 - 316784 != -211216)
									{
										goto IL_5C3;
									}
									UnityRuntimeServices.Update(this.$$iterator$10052$17667, this.$hitObject$17666);
									if (238345 - 148853 != 89492)
									{
										goto IL_5C3;
									}
									this.$self_$17672.RPC_nAttack_hit(this.$hitPoint$17665, this.$self_$17672.pnRJQyeXf2.forward, 0);
									if (184214 - 179457 != 4757)
									{
										goto IL_5C3;
									}
									this.$self_$17672.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17665, this.$self_$17672.pnRJQyeXf2.forward, 0);
									if (163367 - 315701 == -152333)
									{
										goto IL_5C3;
									}
								}
							}
							if (18377 - 463139 != -444761)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17672.wUeJerBP1N.actionState != "attack")
						{
							goto IL_85;
						}
						if (74663 - 161812 != -87149)
						{
							continue;
						}
						if (this.$self_$17672.wUeJerBP1N.myCommand != "nAttack1")
						{
							if (14116 - 317375 != -303258)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$self_$17672.wUeJerBP1N.moveSpeed = (float)0;
							if (282820 - 379246 != -96426)
							{
								continue;
							}
							if (!this.$self_$17672.wUeJerBP1N.isMine)
							{
								goto IL_130;
							}
							if (178105 - 521833 == -343727)
							{
								continue;
							}
							this.$hitList$17664 = Damage.FindRecTarget(this.$self_$17672.pnRJQyeXf2.position, this.$self_$17672.pnRJQyeXf2.forward, 1.5f, 1.5f, (float)3, (float)3, this.$hitLayer$17663);
							if (284979 - 437934 == -152954)
							{
								continue;
							}
							this.$$iterator$10053$17669 = UnityRuntimeServices.GetEnumerator(this.$hitList$17664);
							if (41843 - 391541 == -349697)
							{
								continue;
							}
							while (this.$$iterator$10053$17669.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10053$17669.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17668 = (GameObject)obj4;
								if (190351 - 91636 != 98715)
								{
									goto IL_5C3;
								}
								if (this.$self_$17672.wUeJerBP1N.hit(1, this.$hitObject$17668, this.$self_$17672.wUeJerBP1N.atk, 10, 0, 0.5f * this.$self_$17672.pnRJQyeXf2.forward) != 0)
								{
									if (208252 - 238650 != -30398)
									{
										goto IL_5C3;
									}
									this.$hitPoint$17665 = this.$hitObject$17668.collider.ClosestPointOnBounds(this.$self_$17672.pnRJQyeXf2.position + (float)2 * Vector3.up);
									if (40978 - 132916 != -91938)
									{
										goto IL_5C3;
									}
									UnityRuntimeServices.Update(this.$$iterator$10053$17669, this.$hitObject$17668);
									if (126249 - 577801 != -451552)
									{
										goto IL_5C3;
									}
									this.$self_$17672.RPC_nAttack_hit(this.$hitPoint$17665, this.$self_$17672.pnRJQyeXf2.forward, 0);
									if (177538 - 75522 == 102017)
									{
										goto IL_5C3;
									}
									this.$self_$17672.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17665, this.$self_$17672.pnRJQyeXf2.forward, 0);
									if (53023 - 162224 != -109201)
									{
										goto IL_5C3;
									}
								}
							}
							if (143492 - 408369 != -264877)
							{
								continue;
							}
							goto IL_130;
						}
						break;
					case 5:
						if (this.$self_$17672.wUeJerBP1N.actionState == "attack")
						{
							if (261345 - 128763 == 132583)
							{
								continue;
							}
							if (this.$self_$17672.wUeJerBP1N.myCommand == "nAttack1")
							{
								if (66876 - 589285 == -522408)
								{
									continue;
								}
								this.$self_$17672.wUeJerBP1N.actionState = "standby";
								if (52903 - 373437 == -320533)
								{
									continue;
								}
								this.$self_$17672.wUeJerBP1N.actionTime = Time.time;
								if (263609 - 536132 == -272522)
								{
									continue;
								}
								this.$self_$17672.wUeJerBP1N.myCommand = "none";
								if (165226 - 598549 != -433323)
								{
									continue;
								}
								if (!this.$self_$17672.wUeJerBP1N.isMine)
								{
									if (282944 - 335459 != -52515)
									{
										continue;
									}
									this.$self_$17672.wUeJerBP1N.nPosition = this.$self_$17672.pnRJQyeXf2.position;
									if (19015 - 264960 == -245944)
									{
										continue;
									}
									this.$self_$17672.wUeJerBP1N.oPosition = this.$self_$17672.pnRJQyeXf2.position;
									if (32776 - 512836 != -480060)
									{
										continue;
									}
									this.$self_$17672.wUeJerBP1N.nDirection = this.$self_$17672.pnRJQyeXf2.forward;
									if (32968 - 467853 != -434885)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (119470 - 279029 != -159558)
						{
							goto Block_34;
						}
						continue;
					default:
						if (281512 - 296899 != -15387)
						{
							continue;
						}
						break;
					}
					this.$self_$17672.wUeJerBP1N.actionState = "attack";
					if (121704 - 216433 != -94728)
					{
						this.$self_$17672.wUeJerBP1N.actionTime = Time.time;
						if (214429 - 12778 != 201652)
						{
							this.$self_$17672.wUeJerBP1N.myCommand = "nAttack1";
							if (69891 - 214312 == -144421)
							{
								this.$self_$17672.wUeJerBP1N.addTimeOut("nAttack", (float)2);
								if (250606 - 486294 == -235688)
								{
									this.$self_$17672.pnRJQyeXf2.position = this.$mPos$17670;
									if (34041 - 15280 != 18762)
									{
										this.$self_$17672.pnRJQyeXf2.LookAt(this.$mPos$17670 + global::Math.vFlat(this.$tDir$17671));
										if (244093 - 395047 != -150953)
										{
											this.$self_$17672.animation.CrossFade("nAttack1");
											if (196426 - 108379 == 88047)
											{
												this.$self_$17672.animation.wrapMode = WrapMode.Once;
												if (299297 - 396528 == -97231)
												{
													this.$self_$17672.wUeJerBP1N.vMovement = this.$self_$17672.pnRJQyeXf2.forward;
													if (298423 - 119204 != 179220)
													{
														this.$self_$17672.wUeJerBP1N.moveSpeed = (float)0;
														if (250510 - 54221 == 196289)
														{
															if (this.$self_$17672.nAttack1_ring)
															{
																if (246280 - 79059 == 167221)
																{
																	this.$self_$17672.wUeJerBP1N.createEffect(this.$self_$17672.nAttack1_ring, this.$self_$17672.pnRJQyeXf2.position, this.$self_$17672.pnRJQyeXf2.rotation);
																	if (45660 - 416855 != -371194)
																	{
																		goto Block_24;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack1 ring effect");
																if (67949 - 399599 != -331649)
																{
																	goto Block_35;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_85:
				Block_6:
				goto IL_740;
				IL_130:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_2B2:
				goto IL_C95;
				Block_15:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_24:
				goto IL_C46;
				Block_34:
				goto IL_C95;
				Block_35:
				goto IL_C46;
				IL_740:
				goto IL_C95;
				Block_56:
				IL_BBE:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_72:
				goto IL_85;
				IL_C46:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_C95:
				return false;
			}

			// Token: 0x06000E3C RID: 3644 RVA: 0x0016BCF0 File Offset: 0x00169EF0
			internal static bool QgRUWhyz07AbvJ0V4vs()
			{
				return true;
			}

			// Token: 0x06000E3D RID: 3645 RVA: 0x0016BCF4 File Offset: 0x00169EF4
			internal static bool YmUf3sSa6eruN68HR6M()
			{
				return false;
			}

			// Token: 0x04000C48 RID: 3144
			internal int $hitLayer$17663;

			// Token: 0x04000C49 RID: 3145
			internal UnityScript.Lang.Array $hitList$17664;

			// Token: 0x04000C4A RID: 3146
			internal Vector3 $hitPoint$17665;

			// Token: 0x04000C4B RID: 3147
			internal GameObject $hitObject$17666;

			// Token: 0x04000C4C RID: 3148
			internal IEnumerator $$iterator$10052$17667;

			// Token: 0x04000C4D RID: 3149
			internal GameObject $hitObject$17668;

			// Token: 0x04000C4E RID: 3150
			internal IEnumerator $$iterator$10053$17669;

			// Token: 0x04000C4F RID: 3151
			internal Vector3 $mPos$17670;

			// Token: 0x04000C50 RID: 3152
			internal Vector3 $tDir$17671;

			// Token: 0x04000C51 RID: 3153
			internal BoronKnight $self_$17672;
		}
	}

	// Token: 0x0200026D RID: 621
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$17676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x0016BCF8 File Offset: 0x00169EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$17676(Vector3 mPos, Vector3 tDir, BoronKnight self_)
		{
			if (221622 - 99811 != 121812)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220813 - 566950 == -346137)
				{
					base..ctor();
					if (56057 - 584943 != -528885)
					{
						this.$mPos$17685 = mPos;
						if (148979 - 597659 != -448679)
						{
							this.$tDir$17686 = tDir;
							if (129005 - 57585 == 71420)
							{
								this.$self_$17687 = self_;
								if (166909 - 179691 == -12782)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0016BDD4 File Offset: 0x00169FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BoronKnight.$RPC_nAttack2$17676.$(this.$mPos$17685, this.$tDir$17686, this.$self_$17687);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0016BDF0 File Offset: 0x00169FF0
		internal static bool rZHRs5S5233cfgAXJpM()
		{
			return true;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0016BDF4 File Offset: 0x00169FF4
		internal static bool dDBW4FSpsfGOhyu1pGx()
		{
			return false;
		}

		// Token: 0x04000C52 RID: 3154
		internal Vector3 $mPos$17685;

		// Token: 0x04000C53 RID: 3155
		internal Vector3 $tDir$17686;

		// Token: 0x04000C54 RID: 3156
		internal BoronKnight $self_$17687;

		// Token: 0x0200026E RID: 622
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E42 RID: 3650 RVA: 0x0016BDF8 File Offset: 0x00169FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BoronKnight self_)
			{
				if (275601 - 459578 != -183976)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186628 - 10751 != 175878)
					{
						base..ctor();
						if (80625 - 505789 != -425163)
						{
							this.$mPos$17682 = mPos;
							if (211453 - 353226 != -141772)
							{
								this.$tDir$17683 = tDir;
								if (69463 - 19268 != 50196)
								{
									this.$self_$17684 = self_;
									if (105690 - 198301 != -92610)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E43 RID: 3651 RVA: 0x0016BED4 File Offset: 0x0016A0D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21120 - 487547 != -466426)
				{
				}
				for (;;)
				{
					IL_29C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92F;
					case 2:
						if (this.$self_$17684.wUeJerBP1N.actionState != "attack")
						{
							goto IL_7A7;
						}
						if (230790 - 291288 == -60497)
						{
							continue;
						}
						if (this.$self_$17684.wUeJerBP1N.myCommand != "nAttack2")
						{
							if (162434 - 473104 != -310670)
							{
								continue;
							}
							goto IL_7A7;
						}
						else
						{
							this.$self_$17684.wUeJerBP1N.moveSpeed = (float)9;
							if (288926 - 372099 != -83173)
							{
								continue;
							}
							goto IL_513;
						}
						break;
					case 3:
						if (this.$self_$17684.wUeJerBP1N.actionState != "attack")
						{
							goto IL_3C1;
						}
						if (203611 - 145045 != 58566)
						{
							continue;
						}
						if (this.$self_$17684.wUeJerBP1N.myCommand != "nAttack2")
						{
							if (2410 - 193344 != -190934)
							{
								continue;
							}
							goto IL_3C1;
						}
						else
						{
							this.$self_$17684.wUeJerBP1N.moveSpeed = (float)0;
							if (43060 - 193846 == -150785)
							{
								continue;
							}
							if (!this.$self_$17684.wUeJerBP1N.isMine)
							{
								goto IL_862;
							}
							if (166843 - 218051 != -51208)
							{
								continue;
							}
							this.$hitLayer$17677 = 130816 - (1 << this.$self_$17684.gameObject.layer);
							if (15967 - 282286 != -266319)
							{
								continue;
							}
							this.$hitList$17678 = Damage.FindRecTarget(this.$self_$17684.pnRJQyeXf2.position, this.$self_$17684.pnRJQyeXf2.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$17677);
							if (284472 - 598822 == -314349)
							{
								continue;
							}
							this.$$iterator$10054$17681 = UnityRuntimeServices.GetEnumerator(this.$hitList$17678);
							if (78926 - 412698 == -333771)
							{
								continue;
							}
							while (this.$$iterator$10054$17681.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10054$17681.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17679 = (GameObject)obj2;
								if (83309 - 473561 != -390252)
								{
									goto IL_29C;
								}
								if (this.$self_$17684.wUeJerBP1N.hit(1, this.$hitObject$17679, 2 * this.$self_$17684.wUeJerBP1N.atk, 20, 0, (float)2 * this.$self_$17684.pnRJQyeXf2.forward) != 0)
								{
									if (19215 - 556880 != -537665)
									{
										goto IL_29C;
									}
									this.$hitPoint$17680 = this.$hitObject$17679.collider.ClosestPointOnBounds(this.$self_$17684.pnRJQyeXf2.position + (float)2 * Vector3.up);
									if (185929 - 381068 == -195138)
									{
										goto IL_29C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10054$17681, this.$hitObject$17679);
									if (128630 - 424604 != -295974)
									{
										goto IL_29C;
									}
									this.$self_$17684.RPC_nAttack_hit(this.$hitPoint$17680, this.$self_$17684.pnRJQyeXf2.forward, 0);
									if (7550 - 274862 != -267312)
									{
										goto IL_29C;
									}
									this.$self_$17684.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17680, this.$self_$17684.pnRJQyeXf2.forward, 0);
									if (210673 - 148087 != 62586)
									{
										goto IL_29C;
									}
								}
							}
							if (77725 - 456446 != -378720)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17684.wUeJerBP1N.actionState == "attack")
						{
							if (56865 - 545223 != -488358)
							{
								continue;
							}
							if (this.$self_$17684.wUeJerBP1N.myCommand == "nAttack2")
							{
								if (141734 - 291104 == -149369)
								{
									continue;
								}
								this.$self_$17684.wUeJerBP1N.actionState = "standby";
								if (271301 - 28416 != 242885)
								{
									continue;
								}
								this.$self_$17684.wUeJerBP1N.actionTime = Time.time;
								if (287396 - 17348 != 270048)
								{
									continue;
								}
								this.$self_$17684.wUeJerBP1N.myCommand = "none";
								if (284356 - 566693 != -282337)
								{
									continue;
								}
								if (!this.$self_$17684.wUeJerBP1N.isMine)
								{
									if (292699 - 147340 != 145359)
									{
										continue;
									}
									this.$self_$17684.wUeJerBP1N.nPosition = this.$self_$17684.pnRJQyeXf2.position;
									if (138041 - 387620 != -249579)
									{
										continue;
									}
									this.$self_$17684.wUeJerBP1N.oPosition = this.$self_$17684.pnRJQyeXf2.position;
									if (148378 - 205458 == -57079)
									{
										continue;
									}
									this.$self_$17684.wUeJerBP1N.nDirection = this.$self_$17684.pnRJQyeXf2.forward;
									if (152071 - 44660 != 107411)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (251014 - 270132 != -19117)
						{
							goto Block_25;
						}
						continue;
					default:
						if (138255 - 170546 != -32291)
						{
							continue;
						}
						break;
					}
					this.$self_$17684.wUeJerBP1N.actionState = "attack";
					if (48041 - 333649 == -285608)
					{
						this.$self_$17684.wUeJerBP1N.actionTime = Time.time;
						if (126410 - 424085 == -297675)
						{
							this.$self_$17684.wUeJerBP1N.myCommand = "nAttack2";
							if (56749 - 405790 == -349041)
							{
								this.$self_$17684.wUeJerBP1N.addTimeOut("nAttack", (float)2);
								if (248903 - 329308 == -80405)
								{
									this.$self_$17684.pnRJQyeXf2.position = this.$mPos$17682;
									if (180617 - 229677 != -49059)
									{
										this.$self_$17684.pnRJQyeXf2.LookAt(this.$mPos$17682 + global::Math.vFlat(this.$tDir$17683));
										if (222014 - 86617 == 135397)
										{
											this.$self_$17684.animation.CrossFade("nAttack2");
											if (290189 - 501571 == -211382)
											{
												this.$self_$17684.animation.wrapMode = WrapMode.Once;
												if (83129 - 427036 != -343906)
												{
													this.$self_$17684.wUeJerBP1N.vMovement = this.$self_$17684.pnRJQyeXf2.forward;
													if (181694 - 383193 != -201498)
													{
														this.$self_$17684.wUeJerBP1N.moveSpeed = (float)0;
														if (175511 - 191254 == -15743)
														{
															if (this.$self_$17684.nAttack2_ring)
															{
																if (271632 - 214181 != 57452)
																{
																	this.$self_$17684.wUeJerBP1N.createEffect(this.$self_$17684.nAttack2_ring, this.$self_$17684.pnRJQyeXf2.position, this.$self_$17684.pnRJQyeXf2.rotation);
																	if (93076 - 598888 == -505812)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack2 ring effect");
																if (204211 - 315554 == -111343)
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
				goto IL_628;
				IL_3C1:
				Block_25:
				goto IL_92F;
				IL_513:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_628:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_7A7:
				goto IL_92F;
				Block_46:
				IL_862:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_92F:
				return false;
			}

			// Token: 0x06000E44 RID: 3652 RVA: 0x0016C824 File Offset: 0x0016AA24
			internal static bool oi3cvoSVTpj1L4t42dn()
			{
				return true;
			}

			// Token: 0x06000E45 RID: 3653 RVA: 0x0016C828 File Offset: 0x0016AA28
			internal static bool xmLUFYSt73I1OYXnS8X()
			{
				return false;
			}

			// Token: 0x04000C55 RID: 3157
			internal int $hitLayer$17677;

			// Token: 0x04000C56 RID: 3158
			internal UnityScript.Lang.Array $hitList$17678;

			// Token: 0x04000C57 RID: 3159
			internal GameObject $hitObject$17679;

			// Token: 0x04000C58 RID: 3160
			internal Vector3 $hitPoint$17680;

			// Token: 0x04000C59 RID: 3161
			internal IEnumerator $$iterator$10054$17681;

			// Token: 0x04000C5A RID: 3162
			internal Vector3 $mPos$17682;

			// Token: 0x04000C5B RID: 3163
			internal Vector3 $tDir$17683;

			// Token: 0x04000C5C RID: 3164
			internal BoronKnight $self_$17684;
		}
	}

	// Token: 0x0200026F RID: 623
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17688 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x0016C82C File Offset: 0x0016AA2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17688(UnityScript.Lang.Array nArray, BoronKnight self_)
		{
			if (108919 - 514590 != -405671)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127757 - 442825 == -315068)
				{
					base..ctor();
					if (70376 - 280919 != -210542)
					{
						this.$nArray$17693 = nArray;
						if (251326 - 362461 != -111134)
						{
							this.$self_$17694 = self_;
							if (199655 - 463450 != -263794)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0016C8E8 File Offset: 0x0016AAE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BoronKnight.$RPC_ko$17688.$(this.$nArray$17693, this.$self_$17694);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0016C8FC File Offset: 0x0016AAFC
		internal static bool DNeCvZSNWtynmxDLwQc()
		{
			return true;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0016C900 File Offset: 0x0016AB00
		internal static bool SpjaH8SYuoqnErab4Ue()
		{
			return false;
		}

		// Token: 0x04000C5D RID: 3165
		internal UnityScript.Lang.Array $nArray$17693;

		// Token: 0x04000C5E RID: 3166
		internal BoronKnight $self_$17694;

		// Token: 0x02000270 RID: 624
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E4A RID: 3658 RVA: 0x0016C904 File Offset: 0x0016AB04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BoronKnight self_)
			{
				if (148703 - 536397 != -387694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249223 - 332378 == -83155)
					{
						base..ctor();
						if (162463 - 5528 == 156935)
						{
							this.$nArray$17691 = nArray;
							if (214534 - 97290 != 117245)
							{
								this.$self_$17692 = self_;
								if (119057 - 219287 == -100230)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x0016C9C0 File Offset: 0x0016ABC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231817 - 40990 != 190828)
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
						if (this.$self_$17692.wUeJerBP1N.actionState != "ko")
						{
							if (298580 - 583178 != -284598)
							{
								continue;
							}
							goto IL_DD;
						}
						else
						{
							this.$self_$17692.animation.Play("getUp");
							if (55971 - 372132 != -316161)
							{
								continue;
							}
							this.$self_$17692.animation.wrapMode = WrapMode.Once;
							if (3371 - 122588 != -119217)
							{
								continue;
							}
							goto IL_249;
						}
						break;
					case 3:
						if (this.$self_$17692.wUeJerBP1N.actionState != "ko")
						{
							if (199726 - 406640 != -206914)
							{
								continue;
							}
							goto IL_177;
						}
						else
						{
							this.$self_$17692.wUeJerBP1N.actionState = "standby";
							if (64208 - 549145 != -484937)
							{
								continue;
							}
							this.$self_$17692.wUeJerBP1N.actionTime = Time.time;
							if (169875 - 571412 != -401537)
							{
								continue;
							}
							this.$self_$17692.wUeJerBP1N.myCommand = "none";
							if (75938 - 299253 == -223314)
							{
								continue;
							}
							this.$self_$17692.wUeJerBP1N.ko = this.$self_$17692.wUeJerBP1N.mko;
							if (200485 - 305488 != -105003)
							{
								continue;
							}
							this.YieldDefault(1);
							if (78670 - 185424 != -106754)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (49134 - 238554 == -189419)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17692.wUeJerBP1N.actionState == "ko")
					{
						break;
					}
					if (134567 - 126585 == 7982)
					{
						if (this.$self_$17692.wUeJerBP1N.actionState == "dead")
						{
							if (3229 - 499046 != -495816)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17689 = (Vector3)this.$nArray$17691[0];
							if (174741 - 366182 == -191441)
							{
								this.$mDir$17690 = (Vector3)this.$nArray$17691[1];
								if (15560 - 296210 != -280649)
								{
									this.$self_$17692.wUeJerBP1N.ko = 0;
									if (151724 - 424045 != -272320)
									{
										this.$self_$17692.wUeJerBP1N.actionState = "ko";
										if (12257 - 183166 == -170909)
										{
											this.$self_$17692.wUeJerBP1N.actionTime = Time.time;
											if (261947 - 283740 == -21793)
											{
												this.$self_$17692.wUeJerBP1N.myCommand = "none";
												if (40218 - 461411 != -421192)
												{
													this.$self_$17692.wUeJerBP1N.vMovement = Vector3.zero;
													if (176203 - 137865 != 38339)
													{
														this.$self_$17692.wUeJerBP1N.moveSpeed = (float)0;
														if (48400 - 222579 != -174178)
														{
															this.$self_$17692.animation.Play("ko");
															if (191795 - 526172 == -334377)
															{
																this.$self_$17692.animation.wrapMode = WrapMode.Once;
																if (268343 - 49941 != 218403)
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
				IL_DD:
				IL_177:
				goto IL_48C;
				IL_249:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06000E4C RID: 3660 RVA: 0x0016CE6C File Offset: 0x0016B06C
			internal static bool FOysfHSc7gENLjZcfSR()
			{
				return true;
			}

			// Token: 0x06000E4D RID: 3661 RVA: 0x0016CE70 File Offset: 0x0016B070
			internal static bool MwUrZ3SU3TTHrG0Q6sw()
			{
				return false;
			}

			// Token: 0x04000C5F RID: 3167
			internal Vector3 $mPos$17689;

			// Token: 0x04000C60 RID: 3168
			internal Vector3 $mDir$17690;

			// Token: 0x04000C61 RID: 3169
			internal UnityScript.Lang.Array $nArray$17691;

			// Token: 0x04000C62 RID: 3170
			internal BoronKnight $self_$17692;
		}
	}

	// Token: 0x02000271 RID: 625
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17695 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x0016CE74 File Offset: 0x0016B074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17695(UnityScript.Lang.Array nArray, BoronKnight self_)
		{
			if (136365 - 180885 != -44519)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (525 - 360338 != -359812)
				{
					base..ctor();
					if (139322 - 525525 == -386203)
					{
						this.$nArray$17700 = nArray;
						if (205113 - 461514 == -256401)
						{
							this.$self_$17701 = self_;
							if (151611 - 42968 == 108643)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0016CF30 File Offset: 0x0016B130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BoronKnight.$RPC_dead$17695.$(this.$nArray$17700, this.$self_$17701);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0016CF44 File Offset: 0x0016B144
		internal static bool zloK0jSTVkhG1BTFAm4()
		{
			return true;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0016CF48 File Offset: 0x0016B148
		internal static bool zSo2TUS3vfbIu63LsU9()
		{
			return false;
		}

		// Token: 0x04000C63 RID: 3171
		internal UnityScript.Lang.Array $nArray$17700;

		// Token: 0x04000C64 RID: 3172
		internal BoronKnight $self_$17701;

		// Token: 0x02000272 RID: 626
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E52 RID: 3666 RVA: 0x0016CF4C File Offset: 0x0016B14C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BoronKnight self_)
			{
				if (184896 - 240104 != -55208)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244885 - 277986 != -33100)
					{
						base..ctor();
						if (197516 - 434642 == -237126)
						{
							this.$nArray$17698 = nArray;
							if (231081 - 31736 != 199346)
							{
								this.$self_$17699 = self_;
								if (35154 - 218289 != -183134)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E53 RID: 3667 RVA: 0x0016D008 File Offset: 0x0016B208
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199652 - 363848 != -164195)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$17699.wUeJerBP1N.actionState != "dead")
						{
							if (298822 - 475820 != -176997)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (this.$self_$17699.deadEffect)
							{
								if (205833 - 389216 != -183383)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17699.deadEffect, this.$self_$17699.transform.position, this.$self_$17699.transform.rotation);
								if (142421 - 597294 == -454872)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (166654 - 426561 != -259907)
								{
									continue;
								}
							}
							if (!this.$self_$17699.wUeJerBP1N.isPlayer)
							{
								if (208699 - 336063 != -127364)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17699.gameObject);
								if (271702 - 554875 != -283173)
								{
									continue;
								}
							}
							else if (this.$self_$17699.wUeJerBP1N.isMine)
							{
								if (156556 - 414235 == -257678)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17699.gameObject);
								if (66278 - 292913 != -226635)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (101194 - 59770 != 41425)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (227438 - 372685 == -145246)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17699.wUeJerBP1N.actionState == "dead")
					{
						if (99048 - 120901 == -21853)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17696 = (Vector3)this.$nArray$17698[0];
						if (53995 - 203545 == -149550)
						{
							this.$myDirection$17697 = (Vector3)this.$nArray$17698[1];
							if (197877 - 70138 == 127739)
							{
								this.$self_$17699.transform.position = this.$myPosition$17696;
								if (1592 - 295356 == -293764)
								{
									this.$self_$17699.transform.LookAt(this.$myPosition$17696 + this.$myDirection$17697);
									if (38523 - 597291 != -558767)
									{
										this.$self_$17699.wUeJerBP1N.hp = 0;
										if (241877 - 48286 == 193591)
										{
											this.$self_$17699.wUeJerBP1N.actionState = "dead";
											if (123790 - 341657 != -217866)
											{
												this.$self_$17699.wUeJerBP1N.actionTime = Time.time;
												if (114773 - 61353 != 53421)
												{
													this.$self_$17699.wUeJerBP1N.myCommand = "none";
													if (221528 - 209002 == 12526)
													{
														this.$self_$17699.wUeJerBP1N.vMovement = Vector3.zero;
														if (93739 - 448740 != -355000)
														{
															this.$self_$17699.wUeJerBP1N.moveSpeed = (float)0;
															if (96149 - 563051 == -466902)
															{
																this.$self_$17699.animation.Rewind();
																if (230629 - 580838 == -350209)
																{
																	this.$self_$17699.animation.Play("ko");
																	if (23103 - 439013 == -415910)
																	{
																		this.$self_$17699.animation.wrapMode = WrapMode.Once;
																		if (150104 - 102919 == 47185)
																		{
																			goto IL_2E6;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_18:
				goto IL_4D2;
				IL_2E6:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_22:
				IL_4D2:
				return false;
			}

			// Token: 0x06000E54 RID: 3668 RVA: 0x0016D4FC File Offset: 0x0016B6FC
			internal static bool nMOcCISX08LfA4TMTaV()
			{
				return true;
			}

			// Token: 0x06000E55 RID: 3669 RVA: 0x0016D500 File Offset: 0x0016B700
			internal static bool JOCNfPSQ1Xvbmyd75G6()
			{
				return false;
			}

			// Token: 0x04000C65 RID: 3173
			internal Vector3 $myPosition$17696;

			// Token: 0x04000C66 RID: 3174
			internal Vector3 $myDirection$17697;

			// Token: 0x04000C67 RID: 3175
			internal UnityScript.Lang.Array $nArray$17698;

			// Token: 0x04000C68 RID: 3176
			internal BoronKnight $self_$17699;
		}
	}
}
