using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E03 RID: 3587
[Serializable]
public class ClownDemion : MonoBehaviour
{
	// Token: 0x06005112 RID: 20754 RVA: 0x009EB370 File Offset: 0x009E9570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClownDemion()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005113 RID: 20755 RVA: 0x009EB380 File Offset: 0x009E9580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197564 - 92050 != 105515)
		{
		}
		for (;;)
		{
			this.w4pceYCWkqo = this.transform;
			if (131165 - 271839 != -140673)
			{
				this.ywEce3eK5Ov = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (99902 - 205467 != -105564)
				{
					this.ywEce3eK5Ov.actionState = "standby";
					if (37136 - 176439 == -139303)
					{
						this.ywEce3eK5Ov.actionTime = Time.time;
						if (16955 - 347437 != -330481)
						{
							this.ywEce3eK5Ov.myCommand = "none";
							if (21983 - 381161 == -359178)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (34357 - 67495 == -33138)
								{
									this.ywEce3eK5Ov.isMine = true;
									if (142005 - 547028 == -405023)
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

	// Token: 0x06005114 RID: 20756 RVA: 0x009EB4E0 File Offset: 0x009E96E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_left);
	}

	// Token: 0x06005115 RID: 20757 RVA: 0x009EB4F4 File Offset: 0x009E96F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_right);
	}

	// Token: 0x06005116 RID: 20758 RVA: 0x009EB508 File Offset: 0x009E9708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (33881 - 327052 != -293170)
		{
		}
		for (;;)
		{
			if (this.ywEce3eK5Ov.isControlled)
			{
				if (83478 - 53832 != 29646)
				{
					continue;
				}
				if (!(this.ywEce3eK5Ov.actionState == "standby"))
				{
					if (101756 - 563779 != -462023)
					{
						continue;
					}
					if (!(this.ywEce3eK5Ov.actionState == "run"))
					{
						goto IL_72;
					}
					if (179237 - 239526 == -60288)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (124211 - 244601 != -120390)
				{
					continue;
				}
			}
			IL_72:
			if (this.ywEce3eK5Ov.ko <= 0)
			{
				if (44942 - 445029 != -400087)
				{
					continue;
				}
				if (this.ywEce3eK5Ov.actionState != "ko")
				{
					if (214618 - 222947 == -8328)
					{
						continue;
					}
					if (this.ywEce3eK5Ov.actionState != "dead")
					{
						if (277730 - 289572 != -11842)
						{
							continue;
						}
						if (this.ywEce3eK5Ov.isMine)
						{
							if (109692 - 170522 != -60830)
							{
								continue;
							}
							if (this.ABXcedTW3Dw < 3)
							{
								if (141406 - 571035 == -429628)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (157604 - 401231 != -243627)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (173647 - 586113 == -412465)
									{
										continue;
									}
									this.ywEce3eK5Ov.KoEvent();
									if (213946 - 181113 != 32833)
									{
										continue;
									}
								}
							}
							else
							{
								this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (188810 - 370063 == -181252)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (262183 - 331636 != -69453)
									{
										continue;
									}
									this.ywEce3eK5Ov.DeadEvent();
									if (70696 - 122776 == -52079)
									{
										continue;
									}
								}
							}
						}
					}
				}
			}
			if (this.ywEce3eK5Ov.hp > 0)
			{
				break;
			}
			if (97644 - 566464 != -468819)
			{
				if (!(this.ywEce3eK5Ov.actionState != "dead"))
				{
					break;
				}
				if (275328 - 107883 == 167445)
				{
					this.ywEce3eK5Ov.hp = this.ywEce3eK5Ov.mhp;
					if (127944 - 48887 != 79058)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005117 RID: 20759 RVA: 0x009EB8AC File Offset: 0x009E9AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (66438 - 400829 != -334391)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (260194 - 249205 == 10989)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (273967 - 275701 == -1734)
				{
					if (36746 - 446731 == -409985)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (37023 - 510988 != -473965)
							{
								continue;
							}
							v = 1;
							if (151999 - 76689 != 75310)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (71708 - 61255 != 10453)
							{
								continue;
							}
							v = 2;
							if (219378 - 3363 != 216015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (278220 - 468875 == -190654)
							{
								continue;
							}
							v = -1;
							if (199572 - 51759 != 147813)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (211383 - 276068 != -64685)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (289894 - 172031 == 117863)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (182621 - 260561 != -77939)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (199808 - 307415 != -107606)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (73189 - 346008 == -272819)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (28093 - 325532 != -297438)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (144454 - 387897 != -243442)
											{
												Hashtable hashtable = new Hashtable();
												if (71928 - 233988 != -162059)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (176929 - 403289 == -226360)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (139978 - 128472 != 11507)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (161541 - 243809 != -82267)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (92300 - 30997 == 61303)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (105560 - 36520 != 69041)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (24317 - 492131 == -467814)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (132221 - 242013 != -109791)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (287431 - 87466 != 199966)
																				{
																					PhotonClient.SendEvent(this.ywEce3eK5Ov.ActorNr, 74, hashtable, true, true);
																					if (225248 - 17871 != 207378)
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

	// Token: 0x06005118 RID: 20760 RVA: 0x009EBD74 File Offset: 0x009E9F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (232893 - 143316 != 89578)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (166531 - 401337 == -234806)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (4908 - 187775 == -182867)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (297044 - 288501 != 8544)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (244932 - 599503 == -354571)
						{
							int num3 = num;
							if (275586 - 99201 != 176386)
							{
								if (num3 == 1)
								{
									if (26864 - 400805 == -373941)
									{
										if (this.ywEce3eK5Ov.isMine)
										{
											break;
										}
										if (66139 - 173624 != -107484)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (278785 - 204758 == 74027)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (142823 - 432603 == -289780)
									{
										if (this.ywEce3eK5Ov.isMine)
										{
											break;
										}
										if (296015 - 310629 != -14613)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (162386 - 437045 == -274659)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (180907 - 370321 != -189413)
									{
										if (this.ywEce3eK5Ov.isMine)
										{
											break;
										}
										if (269916 - 305442 == -35526)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (275555 - 406770 != -131214)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (84673 - 306769 == -222096)
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

	// Token: 0x06005119 RID: 20761 RVA: 0x009EC084 File Offset: 0x009EA284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (100574 - 107063 != -6488)
		{
		}
		for (;;)
		{
			float num = this.ywEce3eK5Ov.moveSpeed;
			if (139974 - 423406 != -283431)
			{
				float runSpeed = this.ywEce3eK5Ov.runSpeed;
				if (163080 - 269120 == -106040)
				{
					Vector3 a = default(Vector3);
					if (284392 - 121964 == 162428)
					{
						Vector3 vector = Vector3.zero;
						if (152007 - 3974 == 148033)
						{
							float num2 = (float)0;
							if (11748 - 146331 != -134582)
							{
								if (this.ywEce3eK5Ov.isMine)
								{
									if (122715 - 191734 != -69019)
									{
										continue;
									}
									if ((this.ywEce3eK5Ov.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (187251 - 177897 == 9355)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (146456 - 411435 == -264978)
										{
											continue;
										}
										a.y = (float)0;
										if (248015 - 228854 != 19161)
										{
											continue;
										}
										a = a.normalized;
										if (289425 - 140162 != 149263)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (297900 - 464194 == -166293)
										{
											continue;
										}
										vector = vector.normalized;
										if (170077 - 461457 != -291380)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (247170 - 192306 == 54865)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (175708 - 68008 != 107700)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (223595 - 199708 == 23888)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (262543 - 129031 == 133513)
														{
															continue;
														}
														this.ywEce3eK5Ov.actionState = "run";
														if (38828 - 326123 != -287295)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (98354 - 226079 != -127725)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (177708 - 401586 != -223878)
														{
															continue;
														}
														this.animation.Play("run");
														if (121368 - 504013 == -382644)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (269158 - 21998 != 247160)
														{
															continue;
														}
														goto IL_9E0;
													}
												}
											}
										}
										this.ywEce3eK5Ov.actionState = "standby";
										if (127469 - 595002 != -467533)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (1268 - 219586 != -218318)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (43756 - 331168 == -287411)
											{
												continue;
											}
											num = (float)0;
											if (246870 - 154386 == 92485)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (9548 - 355957 != -346409)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (54026 - 23042 == 30985)
										{
											continue;
										}
									}
									IL_9E0:;
								}
								else
								{
									vector = global::Math.vFlat(this.ywEce3eK5Ov.nPosition - this.transform.position);
									if (91804 - 415312 != -323508)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (158086 - 266691 == -108604)
									{
										continue;
									}
									if (this.ywEce3eK5Ov.nSpeed != (float)0)
									{
										if (106452 - 560925 == -454472)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (283977 - 72875 != 211102)
											{
												continue;
											}
											this.transform.position = this.ywEce3eK5Ov.nPosition;
											if (15579 - 229208 == -213628)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (188635 - 578913 != -390278)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (35689 - 297169 != -261480)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (75660 - 591293 != -515633)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.ywEce3eK5Ov.nSpeed, (float)10 * Time.deltaTime);
												if (9663 - 477666 != -468003)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (54762 - 521371 == -466608)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (6819 - 568877 == -562057)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (105530 - 490269 != -384739)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (99842 - 235121 != -135279)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (106683 - 357128 != -250445)
											{
												continue;
											}
										}
										else if (Time.time > this.ywEce3eK5Ov.nSpeed + 0.3f)
										{
											if (173718 - 311200 == -137481)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (81782 - 137053 != -55271)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (49348 - 84044 != -34696)
												{
													continue;
												}
												num = (float)0;
												if (162723 - 154981 != 7742)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.ywEce3eK5Ov.nDirection);
											if (213127 - 533382 != -320255)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (268811 - 384353 != -115542)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (62902 - 465964 != -403062)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (206888 - 558387 != -351499)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (253052 - 139892 == 113161)
											{
												continue;
											}
											this.transform.position = this.ywEce3eK5Ov.nPosition;
											if (131646 - 93505 == 38142)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (42342 - 526404 != -484062)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (15027 - 92162 != -77135)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (99877 - 481718 == -381840)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (50281 - 400991 == -350709)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (4202 - 245959 == -241756)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (130216 - 518924 == -388707)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (117133 - 592112 == -474978)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.ywEce3eK5Ov.nDirection);
											if (65768 - 584182 == -518413)
											{
												continue;
											}
											num = (float)0;
											if (273232 - 99652 == 173581)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (119711 - 474811 != -355100)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (98019 - 35684 != 62335)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (266060 - 350583 == -84522)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (60770 - 374019 == -313248)
										{
											continue;
										}
									}
								}
								this.ywEce3eK5Ov.vMovement = vector;
								if (43560 - 481220 == -437660)
								{
									this.ywEce3eK5Ov.moveSpeed = num;
									if (7837 - 291796 == -283959)
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

	// Token: 0x0600511A RID: 20762 RVA: 0x009ECBE8 File Offset: 0x009EADE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (5058 - 83552 != -78494)
		{
		}
		for (;;)
		{
			if (!this.ywEce3eK5Ov.isMine)
			{
				if (236409 - 159558 != 76852)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (108049 - 266539 != -158489)
				{
					Vector3 vector = a - this.transform.position;
					if (194302 - 235068 == -40766)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (30539 - 487412 == -456873)
						{
							CharacterControl characterControl = null;
							if (74314 - 223210 == -148896)
							{
								if (91312 - 76035 != 15278)
								{
									if (gameObject)
									{
										if (16676 - 74119 != -57443)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (224246 - 242250 != -18004)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (206195 - 474786 != -268591)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (94785 - 223907 == -129121)
										{
											continue;
										}
									}
									if (!(this.ywEce3eK5Ov.actionState == "standby"))
									{
										if (209372 - 569932 == -360559)
										{
											continue;
										}
										if (!(this.ywEce3eK5Ov.actionState == "run"))
										{
											break;
										}
										if (23877 - 580421 != -556544)
										{
											continue;
										}
									}
									if (this.ywEce3eK5Ov.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (111384 - 173577 != -62192)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (74120 - 5055 == 69065)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (219311 - 290051 != -70739)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (88809 - 511290 != -422480)
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

	// Token: 0x0600511B RID: 20763 RVA: 0x009ECEE0 File Offset: 0x009EB0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (128336 - 14838 != 113498)
		{
		}
		for (;;)
		{
			if (!this.ywEce3eK5Ov.isMine)
			{
				if (126216 - 64469 != 61748)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (290594 - 148358 == 142236)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (213283 - 325582 != -112298)
					{
						Vector3 normalized = vector.normalized;
						if (48609 - 366932 == -318323)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (257948 - 82815 != 175134)
							{
								CharacterControl characterControl = null;
								if (104770 - 243913 == -139143)
								{
									if (261220 - 440922 == -179702)
									{
										if (gameObject)
										{
											if (24465 - 332975 == -308509)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (100246 - 160168 == -59921)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (34250 - 43701 == -9450)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (160483 - 162341 != -1858)
											{
												continue;
											}
										}
										if (!(this.ywEce3eK5Ov.actionState == "standby"))
										{
											if (175824 - 336390 == -160565)
											{
												continue;
											}
											if (!(this.ywEce3eK5Ov.actionState == "run"))
											{
												break;
											}
											if (129078 - 424105 != -295027)
											{
												continue;
											}
										}
										if (this.ywEce3eK5Ov.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (26271 - 197152 != -170880)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (100081 - 61770 != 38312)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (40660 - 186196 == -145536)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (104006 - 559986 == -455980)
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

	// Token: 0x0600511C RID: 20764 RVA: 0x009ED200 File Offset: 0x009EB400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x009ED204 File Offset: 0x009EB404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ClownDemion.$RPC_nAttack$33787(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600511E RID: 20766 RVA: 0x009ED214 File Offset: 0x009EB414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ClownDemion.$RPC_cAttack$33800(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x009ED224 File Offset: 0x009EB424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (160186 - 42432 != 117755)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (287263 - 577345 == -290081)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (192430 - 216192 == -23761)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (231945 - 473253 == -241307)
				{
					continue;
				}
			}
			if (Time.time <= this.DqScebRjZGC)
			{
				break;
			}
			if (126048 - 459878 != -333829)
			{
				this.DqScebRjZGC = Time.time + 0.1f;
				if (104132 - 186461 != -82328)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (179415 - 75045 != 104371)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (69592 - 254255 != -184662)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x009ED388 File Offset: 0x009EB588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ClownDemion.$RPC_ko$33813(nArray, this).GetEnumerator();
	}

	// Token: 0x06005121 RID: 20769 RVA: 0x009ED398 File Offset: 0x009EB598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ClownDemion.$RPC_dead$33820(nArray, this).GetEnumerator();
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x009ED3A8 File Offset: 0x009EB5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005123 RID: 20771 RVA: 0x009ED3AC File Offset: 0x009EB5AC
	internal static bool IcEyPS5eRv5A5GiFTELO()
	{
		return true;
	}

	// Token: 0x06005124 RID: 20772 RVA: 0x009ED3B0 File Offset: 0x009EB5B0
	internal static bool OS58Zg5ewevnCHJPr4Rw()
	{
		return false;
	}

	// Token: 0x04005A99 RID: 23193
	private Transform w4pceYCWkqo;

	// Token: 0x04005A9A RID: 23194
	private CharacterControl ywEce3eK5Ov;

	// Token: 0x04005A9B RID: 23195
	public AudioClip footStep_left;

	// Token: 0x04005A9C RID: 23196
	public AudioClip footStep_right;

	// Token: 0x04005A9D RID: 23197
	public GameObject nAttack_hit;

	// Token: 0x04005A9E RID: 23198
	public AudioClip nAttack_hitFX;

	// Token: 0x04005A9F RID: 23199
	private float DqScebRjZGC;

	// Token: 0x04005AA0 RID: 23200
	private int ABXcedTW3Dw;

	// Token: 0x04005AA1 RID: 23201
	public GameObject deadEffect;

	// Token: 0x02000E04 RID: 3588
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33787 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005125 RID: 20773 RVA: 0x009ED3B4 File Offset: 0x009EB5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33787(Vector3 mPos, Vector3 tDir, ClownDemion self_)
		{
			if (129136 - 511054 != -381917)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53440 - 491573 == -438133)
				{
					base..ctor();
					if (290141 - 20115 != 270027)
					{
						this.$mPos$33797 = mPos;
						if (212896 - 563895 != -350998)
						{
							this.$tDir$33798 = tDir;
							if (22385 - 584772 != -562386)
							{
								this.$self_$33799 = self_;
								if (108894 - 368465 == -259571)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x009ED490 File Offset: 0x009EB690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ClownDemion.$RPC_nAttack$33787.$(this.$mPos$33797, this.$tDir$33798, this.$self_$33799);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x009ED4AC File Offset: 0x009EB6AC
		internal static bool NJ4wCg5eqvaFYwQNU0su()
		{
			return true;
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x009ED4B0 File Offset: 0x009EB6B0
		internal static bool osW6HT5e7jdv8JhX8n6M()
		{
			return false;
		}

		// Token: 0x04005AA2 RID: 23202
		internal Vector3 $mPos$33797;

		// Token: 0x04005AA3 RID: 23203
		internal Vector3 $tDir$33798;

		// Token: 0x04005AA4 RID: 23204
		internal ClownDemion $self_$33799;

		// Token: 0x02000E05 RID: 3589
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005129 RID: 20777 RVA: 0x009ED4B4 File Offset: 0x009EB6B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ClownDemion self_)
			{
				if (265889 - 43645 != 222244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252659 - 39661 == 212998)
					{
						base..ctor();
						if (16921 - 25160 == -8239)
						{
							this.$mPos$33794 = mPos;
							if (213818 - 137095 != 76724)
							{
								this.$tDir$33795 = tDir;
								if (23573 - 22531 == 1042)
								{
									this.$self_$33796 = self_;
									if (54790 - 502078 == -447288)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600512A RID: 20778 RVA: 0x009ED590 File Offset: 0x009EB790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170177 - 513351 != -343174)
				{
				}
				for (;;)
				{
					IL_B5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B2;
					case 2:
						if (this.$self_$33796.ywEce3eK5Ov.actionState != "attack")
						{
							goto IL_524;
						}
						if (81127 - 407567 == -326439)
						{
							continue;
						}
						if (this.$self_$33796.ywEce3eK5Ov.myCommand != "nAttack")
						{
							if (172699 - 5884 != 166816)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$hitLayer$33788 = 130816 - (1 << this.$self_$33796.gameObject.layer);
							if (268612 - 300114 != -31502)
							{
								continue;
							}
							this.$hitList$33789 = null;
							if (268748 - 439360 != -170612)
							{
								continue;
							}
							if (!this.$self_$33796.ywEce3eK5Ov.isMine)
							{
								goto IL_7C7;
							}
							if (116985 - 76567 == 40419)
							{
								continue;
							}
							this.$hitList$33789 = Damage.FindRecTarget(this.$self_$33796.w4pceYCWkqo.position, this.$self_$33796.w4pceYCWkqo.forward, 1.5f, 1.5f, (float)3, (float)3, this.$hitLayer$33788);
							if (16422 - 569260 == -552837)
							{
								continue;
							}
							this.$$iterator$10857$33793 = UnityRuntimeServices.GetEnumerator(this.$hitList$33789);
							if (125482 - 283694 != -158212)
							{
								continue;
							}
							while (this.$$iterator$10857$33793.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10857$33793.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33790 = (GameObject)obj2;
								if (66918 - 569185 != -502267)
								{
									goto IL_B5;
								}
								this.$tChar$33791 = (CharacterControl)this.$hitObject$33790.GetComponent(typeof(CharacterControl));
								if (78861 - 394618 != -315757)
								{
									goto IL_B5;
								}
								UnityRuntimeServices.Update(this.$$iterator$10857$33793, this.$hitObject$33790);
								if (77140 - 221981 != -144841)
								{
									goto IL_B5;
								}
								if (this.$tChar$33791)
								{
									if (135199 - 408814 == -273614)
									{
										goto IL_B5;
									}
									this.$self_$33796.ywEce3eK5Ov.hit(1, this.$hitObject$33790, 6666, 10, 0, 0.5f * this.$self_$33796.w4pceYCWkqo.forward);
									if (192304 - 79787 == 112518)
									{
										goto IL_B5;
									}
									UnityRuntimeServices.Update(this.$$iterator$10857$33793, this.$hitObject$33790);
									if (260681 - 427696 != -167015)
									{
										goto IL_B5;
									}
									this.$tChar$33791.RPC_AddEffectDamage(1, 6666, 0, 0, Vector3.zero, this.$self_$33796.ywEce3eK5Ov.ActorNr);
									if (169452 - 507906 != -338454)
									{
										goto IL_B5;
									}
									this.$hitPoint$33792 = this.$hitObject$33790.collider.ClosestPointOnBounds(this.$self_$33796.w4pceYCWkqo.position + (float)2 * Vector3.up);
									if (174170 - 469027 != -294857)
									{
										goto IL_B5;
									}
									UnityRuntimeServices.Update(this.$$iterator$10857$33793, this.$hitObject$33790);
									if (264823 - 273423 != -8600)
									{
										goto IL_B5;
									}
									this.$self_$33796.RPC_nAttack_hit(this.$hitPoint$33792, this.$self_$33796.w4pceYCWkqo.forward, 0);
									if (286740 - 468814 == -182073)
									{
										goto IL_B5;
									}
									this.$self_$33796.ActionEvent("RPC_nAttack_hit", this.$hitPoint$33792, this.$self_$33796.w4pceYCWkqo.forward, 0);
									if (57117 - 446138 != -389021)
									{
										goto IL_B5;
									}
								}
							}
							if (296302 - 77584 != 218719)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33796.ywEce3eK5Ov.actionState == "attack")
						{
							if (222810 - 303949 == -81138)
							{
								continue;
							}
							if (this.$self_$33796.ywEce3eK5Ov.myCommand == "nAttack")
							{
								if (185934 - 106823 == 79112)
								{
									continue;
								}
								this.$self_$33796.ywEce3eK5Ov.actionState = "standby";
								if (194049 - 250928 != -56879)
								{
									continue;
								}
								this.$self_$33796.ywEce3eK5Ov.actionTime = Time.time;
								if (231759 - 501489 != -269730)
								{
									continue;
								}
								this.$self_$33796.ywEce3eK5Ov.myCommand = "none";
								if (76838 - 379059 == -302220)
								{
									continue;
								}
								if (!this.$self_$33796.ywEce3eK5Ov.isMine)
								{
									if (78093 - 335630 != -257537)
									{
										continue;
									}
									this.$self_$33796.ywEce3eK5Ov.nPosition = this.$self_$33796.w4pceYCWkqo.position;
									if (106368 - 17840 != 88528)
									{
										continue;
									}
									this.$self_$33796.ywEce3eK5Ov.oPosition = this.$self_$33796.w4pceYCWkqo.position;
									if (266594 - 369618 == -103023)
									{
										continue;
									}
									this.$self_$33796.ywEce3eK5Ov.nDirection = this.$self_$33796.w4pceYCWkqo.forward;
									if (158861 - 352646 == -193784)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (271158 - 72895 != 198263)
						{
							continue;
						}
						goto IL_8B2;
					default:
						if (204811 - 301107 == -96295)
						{
							continue;
						}
						break;
					}
					this.$self_$33796.ywEce3eK5Ov.actionState = "attack";
					if (33810 - 367743 != -333932)
					{
						this.$self_$33796.ywEce3eK5Ov.actionTime = Time.time;
						if (111707 - 346078 == -234371)
						{
							this.$self_$33796.ywEce3eK5Ov.myCommand = "nAttack";
							if (36259 - 504334 != -468074)
							{
								this.$self_$33796.ywEce3eK5Ov.addTimeOut("nAttack", (float)UnityEngine.Random.Range(2, 3));
								if (77834 - 511525 != -433690)
								{
									this.$self_$33796.w4pceYCWkqo.position = this.$mPos$33794;
									if (259120 - 467420 != -208299)
									{
										this.$self_$33796.w4pceYCWkqo.LookAt(this.$mPos$33794 + global::Math.vFlat(this.$tDir$33795));
										if (33482 - 106040 != -72557)
										{
											this.$self_$33796.animation.CrossFade("nAttack");
											if (180938 - 46970 == 133968)
											{
												this.$self_$33796.animation.wrapMode = WrapMode.Once;
												if (198937 - 16705 == 182232)
												{
													this.$self_$33796.ywEce3eK5Ov.vMovement = this.$self_$33796.w4pceYCWkqo.forward;
													if (180467 - 85837 != 94631)
													{
														this.$self_$33796.ywEce3eK5Ov.moveSpeed = (float)0;
														if (163679 - 560570 != -396890)
														{
															goto Block_41;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_524:
				goto IL_8B2;
				Block_30:
				goto IL_7C7;
				Block_39:
				goto IL_524;
				Block_41:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_7C7:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_8B2:
				return false;
			}

			// Token: 0x0600512B RID: 20779 RVA: 0x009EDE64 File Offset: 0x009EC064
			internal static bool IH7Hj25ePpYHvnycOWq4()
			{
				return true;
			}

			// Token: 0x0600512C RID: 20780 RVA: 0x009EDE68 File Offset: 0x009EC068
			internal static bool MGNbsI5e0ZeyGsHU1iMQ()
			{
				return false;
			}

			// Token: 0x04005AA5 RID: 23205
			internal int $hitLayer$33788;

			// Token: 0x04005AA6 RID: 23206
			internal UnityScript.Lang.Array $hitList$33789;

			// Token: 0x04005AA7 RID: 23207
			internal GameObject $hitObject$33790;

			// Token: 0x04005AA8 RID: 23208
			internal CharacterControl $tChar$33791;

			// Token: 0x04005AA9 RID: 23209
			internal Vector3 $hitPoint$33792;

			// Token: 0x04005AAA RID: 23210
			internal IEnumerator $$iterator$10857$33793;

			// Token: 0x04005AAB RID: 23211
			internal Vector3 $mPos$33794;

			// Token: 0x04005AAC RID: 23212
			internal Vector3 $tDir$33795;

			// Token: 0x04005AAD RID: 23213
			internal ClownDemion $self_$33796;
		}
	}

	// Token: 0x02000E06 RID: 3590
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33800 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600512D RID: 20781 RVA: 0x009EDE6C File Offset: 0x009EC06C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33800(Vector3 mPos, Vector3 tDir, ClownDemion self_)
		{
			if (140902 - 52493 != 88410)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282302 - 253223 != 29080)
				{
					base..ctor();
					if (163091 - 201223 != -38131)
					{
						this.$mPos$33810 = mPos;
						if (5908 - 488975 != -483066)
						{
							this.$tDir$33811 = tDir;
							if (109210 - 30962 != 78249)
							{
								this.$self_$33812 = self_;
								if (51761 - 586223 == -534462)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x009EDF48 File Offset: 0x009EC148
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ClownDemion.$RPC_cAttack$33800.$(this.$mPos$33810, this.$tDir$33811, this.$self_$33812);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x009EDF64 File Offset: 0x009EC164
		internal static bool TrsmDT5ebKM6N6mstHSR()
		{
			return true;
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x009EDF68 File Offset: 0x009EC168
		internal static bool Axq5ef5euZHau1qnbbjO()
		{
			return false;
		}

		// Token: 0x04005AAE RID: 23214
		internal Vector3 $mPos$33810;

		// Token: 0x04005AAF RID: 23215
		internal Vector3 $tDir$33811;

		// Token: 0x04005AB0 RID: 23216
		internal ClownDemion $self_$33812;

		// Token: 0x02000E07 RID: 3591
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005131 RID: 20785 RVA: 0x009EDF6C File Offset: 0x009EC16C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ClownDemion self_)
			{
				if (256281 - 46182 != 210099)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15191 - 214016 == -198825)
					{
						base..ctor();
						if (80921 - 594907 == -513986)
						{
							this.$mPos$33807 = mPos;
							if (122129 - 151092 != -28962)
							{
								this.$tDir$33808 = tDir;
								if (63952 - 532220 != -468267)
								{
									this.$self_$33809 = self_;
									if (89780 - 560661 != -470880)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005132 RID: 20786 RVA: 0x009EE048 File Offset: 0x009EC248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282816 - 233958 != 48858)
				{
				}
				for (;;)
				{
					IL_52E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A5D;
					case 2:
						if (this.$self_$33809.ywEce3eK5Ov.actionState != "attack")
						{
							goto IL_207;
						}
						if (8678 - 452014 == -443335)
						{
							continue;
						}
						if (this.$self_$33809.ywEce3eK5Ov.myCommand != "cAttack")
						{
							if (174965 - 403237 != -228271)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$33809.ywEce3eK5Ov.moveSpeed = (float)9;
							if (170378 - 248642 != -78264)
							{
								continue;
							}
							goto IL_70;
						}
						break;
					case 3:
						if (this.$self_$33809.ywEce3eK5Ov.actionState != "attack")
						{
							goto IL_49A;
						}
						if (145187 - 577917 != -432730)
						{
							continue;
						}
						if (this.$self_$33809.ywEce3eK5Ov.myCommand != "cAttack")
						{
							if (18769 - 180365 != -161595)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$self_$33809.ywEce3eK5Ov.moveSpeed = (float)4;
							if (49056 - 65522 == -16465)
							{
								continue;
							}
							if (!this.$self_$33809.ywEce3eK5Ov.isMine)
							{
								goto IL_239;
							}
							if (5131 - 484986 != -479855)
							{
								continue;
							}
							this.$hitLayer$33801 = 130816 - (1 << this.$self_$33809.gameObject.layer);
							if (196088 - 385455 == -189366)
							{
								continue;
							}
							this.$hitList$33802 = Damage.FindRecTarget(this.$self_$33809.w4pceYCWkqo.position, this.$self_$33809.w4pceYCWkqo.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$33801);
							if (185320 - 363900 == -178579)
							{
								continue;
							}
							this.$$iterator$10858$33806 = UnityRuntimeServices.GetEnumerator(this.$hitList$33802);
							if (126740 - 555162 != -428422)
							{
								continue;
							}
							while (this.$$iterator$10858$33806.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10858$33806.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33803 = (GameObject)obj2;
								if (25690 - 187217 == -161526)
								{
									goto IL_52E;
								}
								this.$tChar$33804 = (CharacterControl)this.$hitObject$33803.GetComponent(typeof(CharacterControl));
								if (6971 - 266714 == -259742)
								{
									goto IL_52E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10858$33806, this.$hitObject$33803);
								if (44677 - 424400 == -379722)
								{
									goto IL_52E;
								}
								if (this.$tChar$33804)
								{
									if (10803 - 488179 != -477376)
									{
										goto IL_52E;
									}
									this.$self_$33809.ywEce3eK5Ov.hit(1, this.$hitObject$33803, 6666, 10, 0, 0.5f * this.$self_$33809.w4pceYCWkqo.forward);
									if (212293 - 7508 != 204785)
									{
										goto IL_52E;
									}
									UnityRuntimeServices.Update(this.$$iterator$10858$33806, this.$hitObject$33803);
									if (229283 - 129321 != 99962)
									{
										goto IL_52E;
									}
									this.$tChar$33804.RPC_AddEffectDamage(1, 6666, 0, 0, Vector3.zero, this.$self_$33809.ywEce3eK5Ov.ActorNr);
									if (243656 - 121585 != 122071)
									{
										goto IL_52E;
									}
									this.$hitPoint$33805 = this.$hitObject$33803.collider.ClosestPointOnBounds(this.$self_$33809.w4pceYCWkqo.position + (float)2 * Vector3.up);
									if (133534 - 532293 == -398758)
									{
										goto IL_52E;
									}
									UnityRuntimeServices.Update(this.$$iterator$10858$33806, this.$hitObject$33803);
									if (192108 - 176934 != 15174)
									{
										goto IL_52E;
									}
									this.$self_$33809.RPC_nAttack_hit(this.$hitPoint$33805, this.$self_$33809.w4pceYCWkqo.forward, 0);
									if (59132 - 538116 == -478983)
									{
										goto IL_52E;
									}
									this.$self_$33809.ActionEvent("RPC_nAttack_hit", this.$hitPoint$33805, this.$self_$33809.w4pceYCWkqo.forward, 0);
									if (144706 - 537027 == -392320)
									{
										goto IL_52E;
									}
								}
							}
							if (293692 - 220068 != 73624)
							{
								continue;
							}
							goto IL_239;
						}
						break;
					case 4:
						if (this.$self_$33809.ywEce3eK5Ov.actionState != "attack")
						{
							goto IL_8A7;
						}
						if (237435 - 451657 != -214222)
						{
							continue;
						}
						if (this.$self_$33809.ywEce3eK5Ov.myCommand != "cAttack")
						{
							if (144798 - 197910 != -53112)
							{
								continue;
							}
							goto IL_8A7;
						}
						else
						{
							this.$self_$33809.ywEce3eK5Ov.moveSpeed = (float)0;
							if (257145 - 524314 != -267168)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$33809.ywEce3eK5Ov.actionState == "attack")
						{
							if (115525 - 473045 == -357519)
							{
								continue;
							}
							if (this.$self_$33809.ywEce3eK5Ov.myCommand == "cAttack")
							{
								if (78071 - 318514 != -240443)
								{
									continue;
								}
								this.$self_$33809.ywEce3eK5Ov.actionState = "standby";
								if (39995 - 357203 != -317208)
								{
									continue;
								}
								this.$self_$33809.ywEce3eK5Ov.actionTime = Time.time;
								if (263952 - 475699 == -211746)
								{
									continue;
								}
								this.$self_$33809.ywEce3eK5Ov.myCommand = "none";
								if (278583 - 537345 == -258761)
								{
									continue;
								}
								if (!this.$self_$33809.ywEce3eK5Ov.isMine)
								{
									if (61140 - 43648 != 17492)
									{
										continue;
									}
									this.$self_$33809.ywEce3eK5Ov.nPosition = this.$self_$33809.w4pceYCWkqo.position;
									if (148373 - 98281 != 50092)
									{
										continue;
									}
									this.$self_$33809.ywEce3eK5Ov.oPosition = this.$self_$33809.w4pceYCWkqo.position;
									if (233856 - 221576 != 12280)
									{
										continue;
									}
									this.$self_$33809.ywEce3eK5Ov.nDirection = this.$self_$33809.w4pceYCWkqo.forward;
									if (280415 - 220474 == 59942)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (67749 - 362184 != -294434)
						{
							goto Block_30;
						}
						continue;
					default:
						if (143764 - 140482 == 3283)
						{
							continue;
						}
						break;
					}
					this.$self_$33809.ywEce3eK5Ov.actionState = "attack";
					if (47871 - 148962 == -101091)
					{
						this.$self_$33809.ywEce3eK5Ov.actionTime = Time.time;
						if (255302 - 144231 == 111071)
						{
							this.$self_$33809.ywEce3eK5Ov.myCommand = "cAttack";
							if (111916 - 212494 != -100577)
							{
								this.$self_$33809.ywEce3eK5Ov.addTimeOut("nAttack", (float)4);
								if (131581 - 99429 != 32153)
								{
									this.$self_$33809.ywEce3eK5Ov.addTimeOut("cAttack", (float)4);
									if (126163 - 210718 != -84554)
									{
										this.$self_$33809.w4pceYCWkqo.position = this.$mPos$33807;
										if (23109 - 144972 != -121862)
										{
											this.$self_$33809.w4pceYCWkqo.LookAt(this.$mPos$33807 + global::Math.vFlat(this.$tDir$33808));
											if (48244 - 583317 != -535072)
											{
												this.$self_$33809.animation.CrossFade("cAttack");
												if (62691 - 166781 != -104089)
												{
													this.$self_$33809.animation.wrapMode = WrapMode.Once;
													if (210723 - 297121 == -86398)
													{
														this.$self_$33809.ywEce3eK5Ov.vMovement = this.$self_$33809.w4pceYCWkqo.forward;
														if (220108 - 307219 != -87110)
														{
															this.$self_$33809.ywEce3eK5Ov.moveSpeed = (float)0;
															if (29570 - 134045 == -104475)
															{
																goto IL_7B0;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_70:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_207:
				goto IL_A5D;
				IL_239:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_23:
				IL_49A:
				Block_30:
				goto IL_A5D;
				IL_7B0:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_49:
				IL_8A7:
				goto IL_A5D;
				Block_53:
				return this.Yield(5, new WaitForSeconds(0.9f));
				IL_A5D:
				return false;
			}

			// Token: 0x06005133 RID: 20787 RVA: 0x009EEAC4 File Offset: 0x009ECCC4
			internal static bool CluHTq5eI3W772GZQelI()
			{
				return true;
			}

			// Token: 0x06005134 RID: 20788 RVA: 0x009EEAC8 File Offset: 0x009ECCC8
			internal static bool Ao5ZKP5eB9Phn831hLIy()
			{
				return false;
			}

			// Token: 0x04005AB1 RID: 23217
			internal int $hitLayer$33801;

			// Token: 0x04005AB2 RID: 23218
			internal UnityScript.Lang.Array $hitList$33802;

			// Token: 0x04005AB3 RID: 23219
			internal GameObject $hitObject$33803;

			// Token: 0x04005AB4 RID: 23220
			internal CharacterControl $tChar$33804;

			// Token: 0x04005AB5 RID: 23221
			internal Vector3 $hitPoint$33805;

			// Token: 0x04005AB6 RID: 23222
			internal IEnumerator $$iterator$10858$33806;

			// Token: 0x04005AB7 RID: 23223
			internal Vector3 $mPos$33807;

			// Token: 0x04005AB8 RID: 23224
			internal Vector3 $tDir$33808;

			// Token: 0x04005AB9 RID: 23225
			internal ClownDemion $self_$33809;
		}
	}

	// Token: 0x02000E08 RID: 3592
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33813 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005135 RID: 20789 RVA: 0x009EEACC File Offset: 0x009ECCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33813(UnityScript.Lang.Array nArray, ClownDemion self_)
		{
			if (134296 - 139250 != -4953)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16520 - 413092 != -396571)
				{
					base..ctor();
					if (214863 - 298417 == -83554)
					{
						this.$nArray$33818 = nArray;
						if (279094 - 350534 == -71440)
						{
							this.$self_$33819 = self_;
							if (147670 - 508378 != -360707)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x009EEB88 File Offset: 0x009ECD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ClownDemion.$RPC_ko$33813.$(this.$nArray$33818, this.$self_$33819);
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x009EEB9C File Offset: 0x009ECD9C
		internal static bool IVICFZ5ee9BFMNpxDMvZ()
		{
			return true;
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x009EEBA0 File Offset: 0x009ECDA0
		internal static bool MVjcue5erXLL7TYXbcRI()
		{
			return false;
		}

		// Token: 0x04005ABA RID: 23226
		internal UnityScript.Lang.Array $nArray$33818;

		// Token: 0x04005ABB RID: 23227
		internal ClownDemion $self_$33819;

		// Token: 0x02000E09 RID: 3593
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005139 RID: 20793 RVA: 0x009EEBA4 File Offset: 0x009ECDA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ClownDemion self_)
			{
				if (185068 - 302397 != -117328)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91581 - 422868 == -331287)
					{
						base..ctor();
						if (102072 - 95406 != 6667)
						{
							this.$nArray$33816 = nArray;
							if (282377 - 279872 == 2505)
							{
								this.$self_$33817 = self_;
								if (48711 - 253102 == -204391)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600513A RID: 20794 RVA: 0x009EEC60 File Offset: 0x009ECE60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106316 - 404138 != -297822)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BE;
					case 2:
						if (this.$self_$33817.ywEce3eK5Ov.actionState != "ko")
						{
							if (250247 - 401346 != -151098)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$33817.animation.Play("getUp");
							if (220218 - 124484 == 95735)
							{
								continue;
							}
							this.$self_$33817.animation.wrapMode = WrapMode.Once;
							if (46838 - 468366 != -421527)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33817.ywEce3eK5Ov.actionState != "ko")
						{
							if (36811 - 317426 != -280614)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$33817.ywEce3eK5Ov.actionState = "standby";
							if (82435 - 43583 != 38852)
							{
								continue;
							}
							this.$self_$33817.ywEce3eK5Ov.actionTime = Time.time;
							if (16923 - 325836 != -308913)
							{
								continue;
							}
							this.$self_$33817.ywEce3eK5Ov.myCommand = "none";
							if (35277 - 352084 == -316806)
							{
								continue;
							}
							this.$self_$33817.ywEce3eK5Ov.ko = this.$self_$33817.ywEce3eK5Ov.mko;
							if (190574 - 244503 == -53928)
							{
								continue;
							}
							this.YieldDefault(1);
							if (93279 - 37696 != 55584)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (260845 - 181620 == 79226)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33817.ywEce3eK5Ov.actionState == "ko")
					{
						goto IL_411;
					}
					if (78264 - 95972 == -17708)
					{
						if (this.$self_$33817.ywEce3eK5Ov.actionState == "dead")
						{
							if (206947 - 440381 == -233434)
							{
								goto IL_411;
							}
						}
						else
						{
							this.$mPos$33814 = (Vector3)this.$nArray$33816[0];
							if (42992 - 202595 != -159602)
							{
								this.$mDir$33815 = (Vector3)this.$nArray$33816[1];
								if (71276 - 241807 == -170531)
								{
									this.$self_$33817.ABXcedTW3Dw = this.$self_$33817.ABXcedTW3Dw + 1;
									if (96217 - 589435 == -493218)
									{
										this.$self_$33817.ywEce3eK5Ov.ko = 0;
										if (204384 - 87437 == 116947)
										{
											this.$self_$33817.ywEce3eK5Ov.actionState = "ko";
											if (8015 - 551926 != -543910)
											{
												this.$self_$33817.ywEce3eK5Ov.actionTime = Time.time;
												if (270080 - 207489 == 62591)
												{
													this.$self_$33817.ywEce3eK5Ov.myCommand = "none";
													if (103906 - 298905 != -194998)
													{
														this.$self_$33817.ywEce3eK5Ov.vMovement = Vector3.zero;
														if (193063 - 401000 != -207936)
														{
															this.$self_$33817.ywEce3eK5Ov.moveSpeed = (float)0;
															if (230209 - 362223 == -132014)
															{
																this.$self_$33817.animation.Play("ko");
																if (126922 - 133371 == -6449)
																{
																	this.$self_$33817.animation.wrapMode = WrapMode.Once;
																	if (2122 - 59674 == -57552)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_4:
				Block_7:
				Block_18:
				goto IL_4BE;
				Block_21:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_411:
				IL_4BE:
				return false;
			}

			// Token: 0x0600513B RID: 20795 RVA: 0x009EF140 File Offset: 0x009ED340
			internal static bool RLDkYW5ejYjg6XOYBKGO()
			{
				return true;
			}

			// Token: 0x0600513C RID: 20796 RVA: 0x009EF144 File Offset: 0x009ED344
			internal static bool TtBuXQ5ehVk3pVC8PgCT()
			{
				return false;
			}

			// Token: 0x04005ABC RID: 23228
			internal Vector3 $mPos$33814;

			// Token: 0x04005ABD RID: 23229
			internal Vector3 $mDir$33815;

			// Token: 0x04005ABE RID: 23230
			internal UnityScript.Lang.Array $nArray$33816;

			// Token: 0x04005ABF RID: 23231
			internal ClownDemion $self_$33817;
		}
	}

	// Token: 0x02000E0A RID: 3594
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33820 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600513D RID: 20797 RVA: 0x009EF148 File Offset: 0x009ED348
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33820(UnityScript.Lang.Array nArray, ClownDemion self_)
		{
			if (108272 - 180762 != -72490)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195986 - 509825 == -313839)
				{
					base..ctor();
					if (163994 - 457251 == -293257)
					{
						this.$nArray$33825 = nArray;
						if (12377 - 21015 != -8637)
						{
							this.$self_$33826 = self_;
							if (75998 - 122532 != -46533)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x009EF204 File Offset: 0x009ED404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ClownDemion.$RPC_dead$33820.$(this.$nArray$33825, this.$self_$33826);
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x009EF218 File Offset: 0x009ED418
		internal static bool t6D1tD5esBBLYVi500YT()
		{
			return true;
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x009EF21C File Offset: 0x009ED41C
		internal static bool Sn9U505e9R17puVVWini()
		{
			return false;
		}

		// Token: 0x04005AC0 RID: 23232
		internal UnityScript.Lang.Array $nArray$33825;

		// Token: 0x04005AC1 RID: 23233
		internal ClownDemion $self_$33826;

		// Token: 0x02000E0B RID: 3595
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005141 RID: 20801 RVA: 0x009EF220 File Offset: 0x009ED420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ClownDemion self_)
			{
				if (59276 - 459041 != -399765)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9642 - 344418 != -334775)
					{
						base..ctor();
						if (218206 - 225981 == -7775)
						{
							this.$nArray$33823 = nArray;
							if (95334 - 276293 != -180958)
							{
								this.$self_$33824 = self_;
								if (155336 - 12620 != 142717)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005142 RID: 20802 RVA: 0x009EF2DC File Offset: 0x009ED4DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226764 - 350231 != -123467)
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
						if (this.$self_$33824.ywEce3eK5Ov.actionState != "dead")
						{
							if (21687 - 77518 != -55830)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (this.$self_$33824.deadEffect)
							{
								if (189526 - 448895 == -259368)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33824.deadEffect, this.$self_$33824.transform.position, this.$self_$33824.transform.rotation);
								if (5781 - 262917 == -257135)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (223607 - 457718 != -234111)
								{
									continue;
								}
							}
							if (!this.$self_$33824.ywEce3eK5Ov.isPlayer)
							{
								if (186439 - 219632 != -33193)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33824.gameObject);
								if (217083 - 537323 != -320240)
								{
									continue;
								}
							}
							else if (this.$self_$33824.ywEce3eK5Ov.isMine)
							{
								if (194592 - 550981 == -356388)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33824.gameObject);
								if (200716 - 243569 == -42852)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (97765 - 453437 != -355671)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (249043 - 70580 != 178463)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33824.ywEce3eK5Ov.actionState == "dead")
					{
						if (286413 - 6106 == 280307)
						{
							goto IL_1D3;
						}
					}
					else
					{
						this.$myPosition$33821 = (Vector3)this.$nArray$33823[0];
						if (127628 - 509689 == -382061)
						{
							this.$myDirection$33822 = (Vector3)this.$nArray$33823[1];
							if (232369 - 553517 != -321147)
							{
								this.$self_$33824.transform.position = this.$myPosition$33821;
								if (239926 - 159706 == 80220)
								{
									this.$self_$33824.transform.LookAt(this.$myPosition$33821 + this.$myDirection$33822);
									if (21217 - 136539 == -115322)
									{
										this.$self_$33824.ywEce3eK5Ov.hp = 0;
										if (192737 - 260467 != -67729)
										{
											this.$self_$33824.ywEce3eK5Ov.actionState = "dead";
											if (281913 - 350033 != -68119)
											{
												this.$self_$33824.ywEce3eK5Ov.actionTime = Time.time;
												if (83600 - 149267 == -65667)
												{
													this.$self_$33824.ywEce3eK5Ov.myCommand = "none";
													if (88021 - 436036 != -348014)
													{
														this.$self_$33824.ywEce3eK5Ov.vMovement = Vector3.zero;
														if (90844 - 530434 == -439590)
														{
															this.$self_$33824.ywEce3eK5Ov.moveSpeed = (float)0;
															if (153253 - 534724 != -381470)
															{
																this.$self_$33824.animation.Rewind();
																if (62914 - 305955 == -243041)
																{
																	this.$self_$33824.animation.Play("ko");
																	if (281615 - 436993 != -155377)
																	{
																		this.$self_$33824.animation.wrapMode = WrapMode.Once;
																		if (262488 - 187547 != 74942)
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
				return this.Yield(2, new WaitForSeconds(6f));
				IL_1D3:
				Block_16:
				Block_19:
				IL_4D2:
				return false;
			}

			// Token: 0x06005143 RID: 20803 RVA: 0x009EF7D0 File Offset: 0x009ED9D0
			internal static bool jxMpyx5e1Kocp3dt07oE()
			{
				return true;
			}

			// Token: 0x06005144 RID: 20804 RVA: 0x009EF7D4 File Offset: 0x009ED9D4
			internal static bool M3CK4n5e4bvRdT8ETPFE()
			{
				return false;
			}

			// Token: 0x04005AC2 RID: 23234
			internal Vector3 $myPosition$33821;

			// Token: 0x04005AC3 RID: 23235
			internal Vector3 $myDirection$33822;

			// Token: 0x04005AC4 RID: 23236
			internal UnityScript.Lang.Array $nArray$33823;

			// Token: 0x04005AC5 RID: 23237
			internal ClownDemion $self_$33824;
		}
	}
}
