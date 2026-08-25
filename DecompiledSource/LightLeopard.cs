using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000349 RID: 841
[Serializable]
public class LightLeopard : MonoBehaviour
{
	// Token: 0x06001317 RID: 4887 RVA: 0x001DEC24 File Offset: 0x001DCE24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightLeopard()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x001DEC34 File Offset: 0x001DCE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (224050 - 570504 != -346453)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (14700 - 113328 == -98628)
			{
				this.mChar.actionState = "standby";
				if (152133 - 503511 == -351378)
				{
					this.mChar.actionTime = Time.time;
					if (39263 - 113386 != -74122)
					{
						this.mChar.myCommand = "none";
						if (56766 - 59070 != -2303)
						{
							this.UsntO4rflF = Time.time + (float)300;
							if (189686 - 48718 != 140969)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x001DED4C File Offset: 0x001DCF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (182039 - 27137 != 154902)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (143027 - 210250 == -67222)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (16073 - 39485 != -23412)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (215349 - 4265 == 211084)
			{
				if (this.gameObject.layer == 9)
				{
					if (86691 - 525113 != -438422)
					{
						continue;
					}
					this.mChar.mTargetAvartar = this.LightLeopardIcon2;
					if (282887 - 281090 == 1798)
					{
						continue;
					}
				}
				if (QualitySettings.GetQualityLevel() > 1)
				{
					if (207024 - 259201 == -52177)
					{
						this.SetTransparentSkin();
						if (224375 - 164192 != 60184)
						{
							break;
						}
					}
				}
				else
				{
					this.SetSolidSkin();
					if (136630 - 277860 == -141230)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x001DEEBC File Offset: 0x001DD0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetTransparentSkin()
	{
		if (211772 - 212412 != -640)
		{
		}
		while (this.gameObject.layer == 9)
		{
			if (278743 - 548665 != -269921)
			{
				Transform transform = this.transform.Find("Leopard_tri");
				if (36008 - 54434 == -18426)
				{
					if (transform)
					{
						if (233056 - 20276 != 212781)
						{
							SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
							if (105826 - 365876 == -260050)
							{
								if (skinnedMeshRenderer)
								{
									if (3515 - 96185 != -92670)
									{
										continue;
									}
									skinnedMeshRenderer.material.SetColor("_Emission", Color.red);
									if (224735 - 155142 == 69594)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Leopard SkinnedMeshRenderer");
									if (260758 - 189343 == 71416)
									{
										continue;
									}
								}
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find Leopard_tri model");
						if (16171 - 484612 == -468441)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x001DF048 File Offset: 0x001DD248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSolidSkin()
	{
		if (193604 - 514830 != -321226)
		{
		}
		for (;;)
		{
			Transform transform = this.transform.Find("Leopard_tri");
			if (247582 - 515188 == -267606)
			{
				if (transform)
				{
					if (297832 - 10133 != 287700)
					{
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (207654 - 291947 != -84292)
						{
							if (skinnedMeshRenderer)
							{
								if (260211 - 584712 == -324501)
								{
									if (this.gameObject.layer == 8)
									{
										if (15011 - 419691 != -404679)
										{
											skinnedMeshRenderer.material = this.LightLeopard1;
											if (35760 - 246268 == -210508)
											{
												break;
											}
										}
									}
									else
									{
										skinnedMeshRenderer.material = this.LightLeopard2;
										if (80415 - 162220 != -81804)
										{
											break;
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find LightLeopard SkinnedMeshRenderer");
								if (113127 - 494777 == -381650)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find LightLeopard model");
					if (111624 - 280507 != -168882)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x001DF1F4 File Offset: 0x001DD3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (184327 - 363750 != -179422)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (231372 - 33813 == 197560)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (277218 - 396425 == -119206)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1A;
					}
					if (260812 - 176092 != 84720)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (222377 - 59559 != 162818)
				{
					continue;
				}
			}
			IL_1A:
			if (this.mChar.hp > 0)
			{
				if (115281 - 464685 == -349403)
				{
					continue;
				}
				if (Time.time <= this.UsntO4rflF)
				{
					break;
				}
				if (10722 - 355600 != -344878)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (159652 - 417972 != -258319)
			{
				if (this.mChar.isMine)
				{
					if (154933 - 545886 == -390953)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (156001 - 409651 == -253650)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (296578 - 302649 != -6070)
							{
								this.mChar.DeadEvent();
								if (69121 - 233788 != -164666)
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
					if (28960 - 592492 == -563532)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x001DF460 File Offset: 0x001DD660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (118934 - 380258 != -261324)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (26291 - 372443 != -346151)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (9565 - 232782 == -223217)
				{
					if (130026 - 99964 == 30062)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (74312 - 575936 != -501624)
							{
								continue;
							}
							v = 1;
							if (54337 - 221319 != -166982)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (271133 - 139145 == 131989)
							{
								continue;
							}
							v = -1;
							if (83788 - 184866 == -101077)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leoSmash")
						{
							if (96415 - 549392 != -452977)
							{
								continue;
							}
							v = 11;
							if (48285 - 171444 != -123159)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (166754 - 15590 != 151164)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (70026 - 498440 != -428413)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (183181 - 398735 == -215554)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (87132 - 192945 != -105812)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (85293 - 490311 == -405018)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (815 - 28298 != -27482)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (155526 - 51329 != 104198)
											{
												Hashtable hashtable = new Hashtable();
												if (254393 - 539652 == -285259)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (170626 - 528436 == -357810)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (206214 - 565816 != -359601)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (168029 - 527412 == -359383)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (119962 - 594515 != -474552)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (141392 - 562096 != -420703)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (220027 - 599412 != -379384)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (100398 - 530085 == -429687)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (199254 - 367338 == -168084)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (11639 - 366462 != -354822)
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

	// Token: 0x0600131E RID: 4894 RVA: 0x001DF92C File Offset: 0x001DDB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (206999 - 336681 != -129681)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (277773 - 152552 == 125221)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (235742 - 229210 == 6532)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (62062 - 401257 == -339195)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (91983 - 503516 == -411533)
						{
							int num3 = num;
							if (216516 - 14910 == 201606)
							{
								if (num3 == 1)
								{
									if (137570 - 509141 != -371570)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (235551 - 359185 != -123633)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (148027 - 448300 == -300273)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (132831 - 318037 != -185205)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (239217 - 265447 != -26229)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (40872 - 526105 != -485232)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (74472 - 57313 == 17159)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (146053 - 93084 != 52970)
										{
											this.StartCoroutine_Auto(this.RPC_leoSmash(vector, vector2, num2));
											if (15114 - 296432 == -281318)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (138144 - 204766 == -66622)
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

	// Token: 0x0600131F RID: 4895 RVA: 0x001DFC3C File Offset: 0x001DDE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (42626 - 522373 != -479747)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (278716 - 127377 == 151339)
			{
				float runSpeed = this.mChar.runSpeed;
				if (33133 - 161995 == -128862)
				{
					Vector3 a = default(Vector3);
					if (56793 - 67727 == -10934)
					{
						Vector3 vector = Vector3.zero;
						if (117844 - 531644 == -413800)
						{
							float num2 = (float)0;
							if (255979 - 462688 == -206709)
							{
								if (this.mChar.isMine)
								{
									if (214899 - 41379 != 173520)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (92928 - 574687 != -481759)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (45230 - 30038 != 15192)
										{
											continue;
										}
										a.y = (float)0;
										if (238933 - 98502 == 140432)
										{
											continue;
										}
										a = a.normalized;
										if (151589 - 199891 != -48302)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (64553 - 259554 == -195000)
										{
											continue;
										}
										vector = vector.normalized;
										if (132988 - 547880 == -414891)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (153149 - 105724 == 47426)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (37689 - 518147 != -480458)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (206224 - 460062 == -253837)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (268485 - 356743 != -88258)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (97170 - 252951 == -155780)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (75989 - 173939 == -97949)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (204285 - 105879 == 98407)
														{
															continue;
														}
														this.animation.Play("run");
														if (109084 - 236233 != -127149)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (240466 - 146756 != 93711)
														{
															goto IL_777;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (165262 - 497784 == -332521)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (259501 - 225698 == 33804)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (160103 - 519441 != -359338)
											{
												continue;
											}
											num = (float)0;
											if (6253 - 276544 != -270291)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (66185 - 331656 != -265471)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (158258 - 256337 == -98078)
										{
											continue;
										}
									}
									IL_777:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (244933 - 130653 != 114280)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (16197 - 484639 != -468442)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (298824 - 228185 == 70640)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (57583 - 127178 != -69595)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (53848 - 15964 != 37884)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (94713 - 539759 == -445045)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (156365 - 150044 != 6321)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (74365 - 484318 != -409953)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (154241 - 51599 != 102642)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (123628 - 74543 != 49085)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (262102 - 183904 == 78199)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (134935 - 537843 == -402907)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (138341 - 104473 == 33869)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (60498 - 105824 == -45325)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (161053 - 437874 != -276821)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (107064 - 393253 != -286189)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (17024 - 412985 != -395961)
												{
													continue;
												}
												num = (float)0;
												if (179246 - 407874 == -228627)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (122105 - 208421 != -86316)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (241155 - 130032 != 111123)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (109550 - 514932 == -405381)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (188542 - 76366 == 112177)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (251717 - 247300 == 4418)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (255264 - 251796 != 3468)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (62432 - 278723 == -216290)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (284458 - 571926 == -287467)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (180401 - 332792 != -152391)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (244733 - 454755 == -210021)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (141526 - 71299 != 70227)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (256389 - 313896 != -57507)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (290324 - 235598 != 54726)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (227254 - 464014 != -236760)
											{
												continue;
											}
											num = (float)0;
											if (246879 - 279914 != -33035)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (254152 - 202425 == 51728)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252899 - 32108 == 220792)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (94603 - 569174 != -474571)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (269718 - 238529 == 31190)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (213435 - 53913 != 159523)
								{
									this.mChar.moveSpeed = num;
									if (13964 - 412855 != -398890)
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

	// Token: 0x06001320 RID: 4896 RVA: 0x001E07A0 File Offset: 0x001DE9A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (245708 - 135478 != 110230)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (202337 - 80961 != 121377)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (228885 - 86148 != 142738)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (93274 - 27168 != 66107)
					{
						Vector3 vector2 = vector.normalized;
						if (125271 - 538102 != -412830)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (137213 - 115025 != 22189 && 283439 - 117685 != 165755)
							{
								if (gameObject)
								{
									if (114801 - 231432 != -116631)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (96556 - 313845 != -217289)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (212337 - 484607 == -272269)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (27843 - 104437 == -76593)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (210446 - 414748 == -204302)
								{
									if (gameObject == this.gameObject)
									{
										if (35068 - 24616 != 10452)
										{
											continue;
										}
										vector2 = this.transform.forward;
										if (281312 - 327978 == -46665)
										{
											continue;
										}
									}
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
									if (201465 - 127730 == 73735)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (12388 - 580708 != -568319)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
											if (33824 - 311489 != -277664)
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

	// Token: 0x06001321 RID: 4897 RVA: 0x001E0AB0 File Offset: 0x001DECB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (203570 - 22737 != 180834)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (60362 - 100518 != -40155)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (132302 - 190347 == -58045)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (101377 - 21841 != 79537)
					{
						Vector3 normalized = vector.normalized;
						if (177995 - 492073 == -314078)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (1734 - 323869 != -322134)
							{
								CharacterControl characterControl = null;
								if (299459 - 94505 == 204954)
								{
									int tID = 0;
									if (224132 - 36561 == 187571)
									{
										if (gameObject)
										{
											if (153543 - 111005 != 42538)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (200279 - 59057 != 141222)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (277905 - 287969 != -10064)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (44312 - 529977 != -485665)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (98677 - 563215 == -464537)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (175634 - 233160 != -57526)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("leoSmash") != (float)0)
										{
											if (45042 - 182068 == -137026)
											{
												Camera.main.SendMessage("newGameMessage", "leoSmash is not ready");
												if (292435 - 379034 == -86599)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_leoSmash(this.transform.position, normalized, tID));
											if (238827 - 246763 == -7936)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (198169 - 15111 != 183059)
												{
													this.ActionEvent("RPC_leoSmash", this.transform.position, normalized, tID);
													if (266632 - 366292 != -99659)
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

	// Token: 0x06001322 RID: 4898 RVA: 0x001E0E08 File Offset: 0x001DF008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x001E0E0C File Offset: 0x001DF00C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightLeopard.$RPC_nAttack$18544(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x001E0E1C File Offset: 0x001DF01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (235500 - 271947 != -36447)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (123555 - 37187 != 86368)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (61538 - 87861 == -26322)
				{
					continue;
				}
			}
			if (this.pPXt22sMLu >= Time.time)
			{
				break;
			}
			if (106214 - 274365 == -168151)
			{
				this.pPXt22sMLu = Time.time + 0.2f;
				if (141067 - 125951 == 15116)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (241594 - 418765 == -177171)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (228667 - 163649 != 65019)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x001E0F54 File Offset: 0x001DF154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leoSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightLeopard.$RPC_leoSmash$18556(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x001E0F64 File Offset: 0x001DF164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LightLeopard.$RPC_ko$18568(nArray, this).GetEnumerator();
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x001E0F74 File Offset: 0x001DF174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LightLeopard.$RPC_dead$18575(nArray, this).GetEnumerator();
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x001E0F84 File Offset: 0x001DF184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x001E0F88 File Offset: 0x001DF188
	internal static bool ifljFELclBkoQENbK6l()
	{
		return true;
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x001E0F8C File Offset: 0x001DF18C
	internal static bool aaR8PmLUKBWI2XR7CeF()
	{
		return false;
	}

	// Token: 0x04001097 RID: 4247
	public CharacterControl mChar;

	// Token: 0x04001098 RID: 4248
	private float UsntO4rflF;

	// Token: 0x04001099 RID: 4249
	public Texture LightLeopardIcon2;

	// Token: 0x0400109A RID: 4250
	public Material LightLeopard1;

	// Token: 0x0400109B RID: 4251
	public Material LightLeopard2;

	// Token: 0x0400109C RID: 4252
	public GameObject nAttack_hit;

	// Token: 0x0400109D RID: 4253
	public AudioClip nAttack_hitFx;

	// Token: 0x0400109E RID: 4254
	private float pPXt22sMLu;

	// Token: 0x0200034A RID: 842
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18544 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x001E0F90 File Offset: 0x001DF190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18544(Vector3 mPos, Vector3 tDir, LightLeopard self_)
		{
			if (158680 - 496487 != -337806)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251124 - 38923 == 212201)
				{
					base..ctor();
					if (204258 - 79595 != 124664)
					{
						this.$mPos$18553 = mPos;
						if (64751 - 596788 == -532037)
						{
							this.$tDir$18554 = tDir;
							if (153225 - 441056 != -287830)
							{
								this.$self_$18555 = self_;
								if (184387 - 64034 != 120354)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x001E106C File Offset: 0x001DF26C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightLeopard.$RPC_nAttack$18544.$(this.$mPos$18553, this.$tDir$18554, this.$self_$18555);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x001E1088 File Offset: 0x001DF288
		internal static bool yHySyaLTOwHdbMbjlwx()
		{
			return true;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x001E108C File Offset: 0x001DF28C
		internal static bool ekuKcWL3kN4b15ajTNU()
		{
			return false;
		}

		// Token: 0x0400109F RID: 4255
		internal Vector3 $mPos$18553;

		// Token: 0x040010A0 RID: 4256
		internal Vector3 $tDir$18554;

		// Token: 0x040010A1 RID: 4257
		internal LightLeopard $self_$18555;

		// Token: 0x0200034B RID: 843
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600132F RID: 4911 RVA: 0x001E1090 File Offset: 0x001DF290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightLeopard self_)
			{
				if (168524 - 256864 != -88339)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156829 - 291290 != -134460)
					{
						base..ctor();
						if (158175 - 367867 == -209692)
						{
							this.$mPos$18550 = mPos;
							if (281120 - 392651 == -111531)
							{
								this.$tDir$18551 = tDir;
								if (287207 - 15253 == 271954)
								{
									this.$self_$18552 = self_;
									if (86184 - 53636 == 32548)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001330 RID: 4912 RVA: 0x001E116C File Offset: 0x001DF36C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (55243 - 18858 != 36385)
				{
				}
				for (;;)
				{
					IL_2C6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_936;
					case 2:
						if (this.$self_$18552.mChar.actionState != "attack")
						{
							goto IL_192;
						}
						if (108093 - 540625 != -432532)
						{
							continue;
						}
						if (this.$self_$18552.mChar.myCommand != "nAttack")
						{
							if (249152 - 234170 != 14982)
							{
								continue;
							}
							goto IL_192;
						}
						else
						{
							this.$self_$18552.mChar.moveSpeed = (float)2;
							if (183440 - 398284 != -214844)
							{
								continue;
							}
							goto IL_5F2;
						}
						break;
					case 3:
						if (this.$self_$18552.mChar.actionState != "attack")
						{
							goto IL_88B;
						}
						if (285630 - 89883 != 195747)
						{
							continue;
						}
						if (this.$self_$18552.mChar.myCommand != "nAttack")
						{
							if (240091 - 506654 != -266563)
							{
								continue;
							}
							goto IL_88B;
						}
						else
						{
							this.$self_$18552.mChar.moveSpeed = (float)4;
							if (148120 - 422473 != -274352)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18552.mChar.actionState != "attack")
						{
							goto IL_85A;
						}
						if (263791 - 426520 == -162728)
						{
							continue;
						}
						if (this.$self_$18552.mChar.myCommand != "nAttack")
						{
							if (174794 - 387963 != -213168)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$self_$18552.mChar.moveSpeed = (float)0;
							if (96148 - 310020 != -213872)
							{
								continue;
							}
							if (!this.$self_$18552.mChar.isMine)
							{
								goto IL_484;
							}
							if (175116 - 360620 == -185503)
							{
								continue;
							}
							this.$hitLayer$18545 = 130816 - (1 << this.$self_$18552.gameObject.layer);
							if (143598 - 364162 == -220563)
							{
								continue;
							}
							this.$hitList$18546 = Damage.FindRecTarget(this.$self_$18552.transform.position, this.$self_$18552.transform.forward, (float)2, (float)2, (float)2, (float)2, this.$hitLayer$18545);
							if (155548 - 426095 != -270547)
							{
								continue;
							}
							this.$$iterator$10478$18549 = UnityRuntimeServices.GetEnumerator(this.$hitList$18546);
							if (28845 - 293044 == -264198)
							{
								continue;
							}
							while (this.$$iterator$10478$18549.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10478$18549.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18547 = (GameObject)obj2;
								if (240335 - 149712 != 90623)
								{
									goto IL_2C6;
								}
								if (this.$self_$18552.mChar.hit(1, this.$hitObject$18547, this.$self_$18552.mChar.atk, 2, 0, 0.5f * this.$self_$18552.transform.forward) != 0)
								{
									if (148552 - 5984 == 142569)
									{
										goto IL_2C6;
									}
									this.$hitPoint$18548 = this.$hitObject$18547.collider.ClosestPointOnBounds(this.$self_$18552.transform.position + Vector3.up);
									if (173146 - 571583 == -398436)
									{
										goto IL_2C6;
									}
									UnityRuntimeServices.Update(this.$$iterator$10478$18549, this.$hitObject$18547);
									if (291064 - 244252 != 46812)
									{
										goto IL_2C6;
									}
									this.$self_$18552.RPC_nAttack_hit(this.$hitPoint$18548, this.$self_$18552.transform.forward, 0);
									if (7265 - 488 != 6777)
									{
										goto IL_2C6;
									}
									this.$self_$18552.ActionEvent("RPC_nAttack_hit", this.$hitPoint$18548, this.$self_$18552.transform.forward, 0);
									if (52952 - 416513 != -363561)
									{
										goto IL_2C6;
									}
								}
							}
							if (199765 - 589489 != -389723)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$18552.mChar.actionState == "attack")
						{
							if (170291 - 303803 != -133512)
							{
								continue;
							}
							if (this.$self_$18552.mChar.myCommand == "nAttack")
							{
								if (244661 - 460910 == -216248)
								{
									continue;
								}
								this.$self_$18552.mChar.actionState = "standby";
								if (111934 - 429889 != -317955)
								{
									continue;
								}
								this.$self_$18552.mChar.actionTime = Time.time;
								if (236017 - 421318 == -185300)
								{
									continue;
								}
								this.$self_$18552.mChar.myCommand = "none";
								if (46317 - 510885 == -464567)
								{
									continue;
								}
								if (!this.$self_$18552.mChar.isMine)
								{
									if (179069 - 336683 == -157613)
									{
										continue;
									}
									this.$self_$18552.mChar.nPosition = this.$self_$18552.transform.position;
									if (94276 - 438149 != -343873)
									{
										continue;
									}
									this.$self_$18552.mChar.oPosition = this.$self_$18552.transform.position;
									if (30313 - 492014 == -461700)
									{
										continue;
									}
									this.$self_$18552.mChar.nDirection = this.$self_$18552.transform.forward;
									if (28384 - 565417 != -537033)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (66359 - 538653 != -472293)
						{
							goto Block_49;
						}
						continue;
					default:
						if (239025 - 464002 != -224977)
						{
							continue;
						}
						break;
					}
					this.$self_$18552.mChar.actionState = "attack";
					if (238401 - 447578 == -209177)
					{
						this.$self_$18552.mChar.actionTime = Time.time;
						if (86205 - 597277 == -511072)
						{
							this.$self_$18552.mChar.myCommand = "nAttack";
							if (158059 - 412611 == -254552)
							{
								this.$self_$18552.mChar.addTimeOut("nAttack", (float)3);
								if (202360 - 111583 == 90777)
								{
									this.$self_$18552.transform.position = this.$mPos$18550;
									if (155420 - 212756 == -57336)
									{
										this.$self_$18552.transform.LookAt(this.$mPos$18550 + global::Math.vFlat(this.$tDir$18551));
										if (248928 - 187911 == 61017)
										{
											this.$self_$18552.animation.CrossFade("nAttack");
											if (20412 - 370177 != -349764)
											{
												this.$self_$18552.animation.wrapMode = WrapMode.Once;
												if (72791 - 271915 == -199124)
												{
													this.$self_$18552.mChar.vMovement = this.$self_$18552.transform.forward;
													if (4147 - 503301 != -499153)
													{
														this.$self_$18552.mChar.moveSpeed = (float)0;
														if (172875 - 450780 == -277905)
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
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_192:
				goto IL_936;
				Block_16:
				IL_484:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_5F2:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_44:
				Block_49:
				IL_85A:
				IL_88B:
				goto IL_936;
				Block_52:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_936:
				return false;
			}

			// Token: 0x06001331 RID: 4913 RVA: 0x001E1AC4 File Offset: 0x001DFCC4
			internal static bool XMVEScLXHkBrXF0hAto()
			{
				return true;
			}

			// Token: 0x06001332 RID: 4914 RVA: 0x001E1AC8 File Offset: 0x001DFCC8
			internal static bool csp1W6LQDbb9TwJF0Q3()
			{
				return false;
			}

			// Token: 0x040010A2 RID: 4258
			internal int $hitLayer$18545;

			// Token: 0x040010A3 RID: 4259
			internal UnityScript.Lang.Array $hitList$18546;

			// Token: 0x040010A4 RID: 4260
			internal GameObject $hitObject$18547;

			// Token: 0x040010A5 RID: 4261
			internal Vector3 $hitPoint$18548;

			// Token: 0x040010A6 RID: 4262
			internal IEnumerator $$iterator$10478$18549;

			// Token: 0x040010A7 RID: 4263
			internal Vector3 $mPos$18550;

			// Token: 0x040010A8 RID: 4264
			internal Vector3 $tDir$18551;

			// Token: 0x040010A9 RID: 4265
			internal LightLeopard $self_$18552;
		}
	}

	// Token: 0x0200034C RID: 844
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leoSmash$18556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x001E1ACC File Offset: 0x001DFCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leoSmash$18556(Vector3 mPos, Vector3 tDir, LightLeopard self_)
		{
			if (83158 - 475344 != -392185)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195117 - 187700 == 7417)
				{
					base..ctor();
					if (104464 - 596048 != -491583)
					{
						this.$mPos$18565 = mPos;
						if (226859 - 442719 != -215859)
						{
							this.$tDir$18566 = tDir;
							if (210301 - 455637 == -245336)
							{
								this.$self_$18567 = self_;
								if (19247 - 27949 != -8701)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x001E1BA8 File Offset: 0x001DFDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightLeopard.$RPC_leoSmash$18556.$(this.$mPos$18565, this.$tDir$18566, this.$self_$18567);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x001E1BC4 File Offset: 0x001DFDC4
		internal static bool YucaCELknLZTWUCnFYw()
		{
			return true;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x001E1BC8 File Offset: 0x001DFDC8
		internal static bool qjg7bXLGEKCqA4KEWpC()
		{
			return false;
		}

		// Token: 0x040010AA RID: 4266
		internal Vector3 $mPos$18565;

		// Token: 0x040010AB RID: 4267
		internal Vector3 $tDir$18566;

		// Token: 0x040010AC RID: 4268
		internal LightLeopard $self_$18567;

		// Token: 0x0200034D RID: 845
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001337 RID: 4919 RVA: 0x001E1BCC File Offset: 0x001DFDCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightLeopard self_)
			{
				if (18736 - 20794 != -2058)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36749 - 582318 == -545569)
					{
						base..ctor();
						if (206573 - 264905 != -58331)
						{
							this.$mPos$18562 = mPos;
							if (264510 - 235316 != 29195)
							{
								this.$tDir$18563 = tDir;
								if (250837 - 332548 != -81710)
								{
									this.$self_$18564 = self_;
									if (59354 - 317677 == -258323)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001338 RID: 4920 RVA: 0x001E1CA8 File Offset: 0x001DFEA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33851 - 172461 != -138609)
				{
				}
				for (;;)
				{
					IL_744:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7E2;
					case 2:
						if (this.$self_$18564.mChar.actionState != "attack")
						{
							goto IL_352;
						}
						if (220421 - 350151 == -129729)
						{
							continue;
						}
						if (this.$self_$18564.mChar.myCommand != "leoSmash")
						{
							if (44343 - 91632 != -47289)
							{
								continue;
							}
							goto IL_352;
						}
						else
						{
							if (!this.$self_$18564.mChar.isMine)
							{
								goto IL_2B4;
							}
							if (92952 - 517858 != -424906)
							{
								continue;
							}
							this.$hitLayer$18557 = 130816 - (1 << this.$self_$18564.gameObject.layer);
							if (42631 - 534881 == -492249)
							{
								continue;
							}
							this.$hitList$18558 = Damage.FindRecTarget(this.$self_$18564.transform.position, this.$self_$18564.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$18557);
							if (71929 - 37995 != 33934)
							{
								continue;
							}
							this.$$iterator$10479$18561 = UnityRuntimeServices.GetEnumerator(this.$hitList$18558);
							if (194812 - 345878 == -151065)
							{
								continue;
							}
							while (this.$$iterator$10479$18561.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10479$18561.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18559 = (GameObject)obj2;
								if (208916 - 584565 == -375648)
								{
									goto IL_744;
								}
								if (this.$self_$18564.mChar.hit(1, this.$hitObject$18559, this.$self_$18564.mChar.atk + this.$self_$18564.mChar.talAdjust(20), 20, 0, 0.5f * this.$self_$18564.transform.forward) != 0)
								{
									if (253450 - 220326 != 33124)
									{
										goto IL_744;
									}
									this.$hitPoint$18560 = this.$hitObject$18559.collider.ClosestPointOnBounds(this.$self_$18564.transform.position + Vector3.up);
									if (41240 - 457559 != -416319)
									{
										goto IL_744;
									}
									UnityRuntimeServices.Update(this.$$iterator$10479$18561, this.$hitObject$18559);
									if (213637 - 67760 != 145877)
									{
										goto IL_744;
									}
									this.$self_$18564.RPC_nAttack_hit(this.$hitPoint$18560, this.$self_$18564.transform.forward, 0);
									if (82876 - 370525 == -287648)
									{
										goto IL_744;
									}
									this.$self_$18564.ActionEvent("RPC_nAttack_hit", this.$hitPoint$18560, this.$self_$18564.transform.forward, 0);
									if (266309 - 229243 != 37066)
									{
										goto IL_744;
									}
								}
							}
							if (210430 - 189092 != 21339)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18564.mChar.actionState == "attack")
						{
							if (4071 - 136580 == -132508)
							{
								continue;
							}
							if (this.$self_$18564.mChar.myCommand == "leoSmash")
							{
								if (258652 - 49606 == 209047)
								{
									continue;
								}
								this.$self_$18564.mChar.actionState = "standby";
								if (282160 - 355010 == -72849)
								{
									continue;
								}
								this.$self_$18564.mChar.actionTime = Time.time;
								if (192726 - 233979 != -41253)
								{
									continue;
								}
								this.$self_$18564.mChar.myCommand = "none";
								if (277554 - 541634 == -264079)
								{
									continue;
								}
								if (!this.$self_$18564.mChar.isMine)
								{
									if (134906 - 208521 == -73614)
									{
										continue;
									}
									this.$self_$18564.mChar.nPosition = this.$self_$18564.transform.position;
									if (97728 - 506215 == -408486)
									{
										continue;
									}
									this.$self_$18564.mChar.oPosition = this.$self_$18564.transform.position;
									if (220570 - 466928 == -246357)
									{
										continue;
									}
									this.$self_$18564.mChar.nDirection = this.$self_$18564.transform.forward;
									if (144549 - 10182 != 134367)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (37261 - 412366 != -375104)
						{
							goto Block_24;
						}
						continue;
					default:
						if (265517 - 545101 != -279584)
						{
							continue;
						}
						break;
					}
					this.$self_$18564.mChar.actionState = "attack";
					if (258849 - 391310 != -132460)
					{
						this.$self_$18564.mChar.actionTime = Time.time;
						if (209319 - 286886 == -77567)
						{
							this.$self_$18564.mChar.myCommand = "leoSmash";
							if (141155 - 148817 != -7661)
							{
								this.$self_$18564.mChar.addTimeOut("leoSmash", (float)6);
								if (24770 - 570446 != -545675)
								{
									this.$self_$18564.transform.position = this.$mPos$18562;
									if (106644 - 203725 != -97080)
									{
										this.$self_$18564.transform.LookAt(this.$mPos$18562 + global::Math.vFlat(this.$tDir$18563));
										if (62852 - 248508 == -185656)
										{
											this.$self_$18564.animation.Play("leoSmash");
											if (59568 - 47011 != 12558)
											{
												this.$self_$18564.animation.wrapMode = WrapMode.Once;
												if (288505 - 232964 != 55542)
												{
													this.$self_$18564.mChar.vMovement = this.$self_$18564.transform.forward;
													if (290956 - 321756 != -30799)
													{
														this.$self_$18564.mChar.moveSpeed = (float)0;
														if (56530 - 327228 == -270698)
														{
															this.$self_$18564.mChar.sp = this.$self_$18564.mChar.sp - 10;
															if (199293 - 267270 != -67976)
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
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_2B4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_352:
				Block_24:
				goto IL_7E2;
				Block_28:
				goto IL_2B4;
				IL_7E2:
				return false;
			}

			// Token: 0x06001339 RID: 4921 RVA: 0x001E24AC File Offset: 0x001E06AC
			internal static bool tAJUtyLHe7sLiiEgZ3a()
			{
				return true;
			}

			// Token: 0x0600133A RID: 4922 RVA: 0x001E24B0 File Offset: 0x001E06B0
			internal static bool J7SYbaLWOdwWDs5BKod()
			{
				return false;
			}

			// Token: 0x040010AD RID: 4269
			internal int $hitLayer$18557;

			// Token: 0x040010AE RID: 4270
			internal UnityScript.Lang.Array $hitList$18558;

			// Token: 0x040010AF RID: 4271
			internal GameObject $hitObject$18559;

			// Token: 0x040010B0 RID: 4272
			internal Vector3 $hitPoint$18560;

			// Token: 0x040010B1 RID: 4273
			internal IEnumerator $$iterator$10479$18561;

			// Token: 0x040010B2 RID: 4274
			internal Vector3 $mPos$18562;

			// Token: 0x040010B3 RID: 4275
			internal Vector3 $tDir$18563;

			// Token: 0x040010B4 RID: 4276
			internal LightLeopard $self_$18564;
		}
	}

	// Token: 0x0200034E RID: 846
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18568 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600133B RID: 4923 RVA: 0x001E24B4 File Offset: 0x001E06B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18568(UnityScript.Lang.Array nArray, LightLeopard self_)
		{
			if (12594 - 109043 != -96448)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28110 - 540226 == -512116)
				{
					base..ctor();
					if (217727 - 169762 == 47965)
					{
						this.$nArray$18573 = nArray;
						if (153389 - 229354 != -75964)
						{
							this.$self_$18574 = self_;
							if (17675 - 411200 != -393524)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x001E2570 File Offset: 0x001E0770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightLeopard.$RPC_ko$18568.$(this.$nArray$18573, this.$self_$18574);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x001E2584 File Offset: 0x001E0784
		internal static bool T9DE70LAVnx3RUwhdl2()
		{
			return true;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x001E2588 File Offset: 0x001E0788
		internal static bool nkOJXULlOWNemwCmbB1()
		{
			return false;
		}

		// Token: 0x040010B5 RID: 4277
		internal UnityScript.Lang.Array $nArray$18573;

		// Token: 0x040010B6 RID: 4278
		internal LightLeopard $self_$18574;

		// Token: 0x0200034F RID: 847
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600133F RID: 4927 RVA: 0x001E258C File Offset: 0x001E078C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightLeopard self_)
			{
				if (233914 - 248010 != -14095)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289151 - 549091 != -259939)
					{
						base..ctor();
						if (876 - 15365 != -14488)
						{
							this.$nArray$18571 = nArray;
							if (166622 - 272946 == -106324)
							{
								this.$self_$18572 = self_;
								if (146184 - 324523 != -178338)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001340 RID: 4928 RVA: 0x001E2648 File Offset: 0x001E0848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271868 - 62367 != 209501)
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
						if (this.$self_$18572.mChar.actionState != "ko")
						{
							if (11012 - 485193 != -474180)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$18572.animation.Play("getUp");
							if (209185 - 352584 != -143399)
							{
								continue;
							}
							this.$self_$18572.animation.wrapMode = WrapMode.Once;
							if (92568 - 573291 != -480722)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18572.mChar.actionState != "ko")
						{
							if (242505 - 259445 != -16939)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$18572.mChar.actionState = "standby";
							if (66153 - 280685 == -214531)
							{
								continue;
							}
							this.$self_$18572.mChar.actionTime = Time.time;
							if (227620 - 243046 != -15426)
							{
								continue;
							}
							this.$self_$18572.mChar.myCommand = "none";
							if (288375 - 487810 == -199434)
							{
								continue;
							}
							this.$self_$18572.mChar.ko = this.$self_$18572.mChar.mko;
							if (139026 - 88900 == 50127)
							{
								continue;
							}
							this.YieldDefault(1);
							if (287657 - 350970 != -63313)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (232766 - 498529 != -265763)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18572.mChar.actionState == "ko")
					{
						goto IL_392;
					}
					if (187796 - 231188 != -43391)
					{
						if (this.$self_$18572.mChar.actionState == "dead")
						{
							if (45342 - 307576 != -262233)
							{
								goto Block_8;
							}
						}
						else
						{
							this.$mPos$18569 = (Vector3)this.$nArray$18571[0];
							if (267742 - 174726 == 93016)
							{
								this.$mDir$18570 = (Vector3)this.$nArray$18571[1];
								if (196008 - 322265 != -126256)
								{
									this.$self_$18572.mChar.ko = 0;
									if (16336 - 446040 == -429704)
									{
										this.$self_$18572.mChar.actionState = "ko";
										if (92211 - 459388 == -367177)
										{
											this.$self_$18572.mChar.actionTime = Time.time;
											if (65580 - 17303 != 48278)
											{
												this.$self_$18572.mChar.myCommand = "none";
												if (77658 - 461679 == -384021)
												{
													this.$self_$18572.mChar.vMovement = Vector3.zero;
													if (185749 - 586516 == -400767)
													{
														this.$self_$18572.mChar.moveSpeed = (float)0;
														if (223982 - 103554 == 120428)
														{
															this.$self_$18572.animation.Play("ko");
															if (276451 - 213401 != 63051)
															{
																this.$self_$18572.animation.wrapMode = WrapMode.Once;
																if (229103 - 48713 != 180391)
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
				Block_4:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				Block_12:
				Block_15:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_392:
				IL_48C:
				return false;
			}

			// Token: 0x06001341 RID: 4929 RVA: 0x001E2AF4 File Offset: 0x001E0CF4
			internal static bool ilWCZ4LybfaQLmD0glW()
			{
				return true;
			}

			// Token: 0x06001342 RID: 4930 RVA: 0x001E2AF8 File Offset: 0x001E0CF8
			internal static bool SY1gKALSQuQCleYuFXQ()
			{
				return false;
			}

			// Token: 0x040010B7 RID: 4279
			internal Vector3 $mPos$18569;

			// Token: 0x040010B8 RID: 4280
			internal Vector3 $mDir$18570;

			// Token: 0x040010B9 RID: 4281
			internal UnityScript.Lang.Array $nArray$18571;

			// Token: 0x040010BA RID: 4282
			internal LightLeopard $self_$18572;
		}
	}

	// Token: 0x02000350 RID: 848
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001343 RID: 4931 RVA: 0x001E2AFC File Offset: 0x001E0CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18575(UnityScript.Lang.Array nArray, LightLeopard self_)
		{
			if (219578 - 309362 != -89783)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47299 - 258297 != -210997)
				{
					base..ctor();
					if (31338 - 497412 != -466073)
					{
						this.$nArray$18580 = nArray;
						if (189923 - 202636 != -12712)
						{
							this.$self_$18581 = self_;
							if (248603 - 588662 != -340058)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x001E2BB8 File Offset: 0x001E0DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightLeopard.$RPC_dead$18575.$(this.$nArray$18580, this.$self_$18581);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x001E2BCC File Offset: 0x001E0DCC
		internal static bool tbnWgBLo0dIcvedSpyC()
		{
			return true;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x001E2BD0 File Offset: 0x001E0DD0
		internal static bool HZ34dZLE2xNdMfhyPHZ()
		{
			return false;
		}

		// Token: 0x040010BB RID: 4283
		internal UnityScript.Lang.Array $nArray$18580;

		// Token: 0x040010BC RID: 4284
		internal LightLeopard $self_$18581;

		// Token: 0x02000351 RID: 849
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001347 RID: 4935 RVA: 0x001E2BD4 File Offset: 0x001E0DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightLeopard self_)
			{
				if (117894 - 111664 != 6230)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169970 - 93459 != 76512)
					{
						base..ctor();
						if (290810 - 142089 != 148722)
						{
							this.$nArray$18578 = nArray;
							if (98821 - 558086 != -459264)
							{
								this.$self_$18579 = self_;
								if (210852 - 284689 != -73836)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001348 RID: 4936 RVA: 0x001E2C90 File Offset: 0x001E0E90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57873 - 565849 != -507975)
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
						if (this.$self_$18579.mChar.actionState != "dead")
						{
							if (117652 - 259949 != -142296)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18579.mChar.isPlayer)
							{
								if (71748 - 272636 != -200888)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18579.gameObject);
								if (171853 - 233474 == -61620)
								{
									continue;
								}
							}
							else if (this.$self_$18579.mChar.isMine)
							{
								if (274435 - 202656 != 71779)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18579.gameObject);
								if (214660 - 89369 != 125291)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (76886 - 371725 != -294839)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (116095 - 165639 != -49544)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18579.mChar.actionState == "dead")
					{
						if (187222 - 279783 == -92561)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18576 = (Vector3)this.$nArray$18578[0];
						if (263715 - 235492 != 28224)
						{
							this.$myDirection$18577 = (Vector3)this.$nArray$18578[1];
							if (157730 - 101289 == 56441)
							{
								this.$self_$18579.transform.position = this.$myPosition$18576;
								if (109864 - 67403 == 42461)
								{
									this.$self_$18579.transform.LookAt(this.$myPosition$18576 + this.$myDirection$18577);
									if (298471 - 378228 == -79757)
									{
										this.$self_$18579.mChar.hp = 0;
										if (112430 - 113213 == -783)
										{
											this.$self_$18579.mChar.actionState = "dead";
											if (181469 - 150484 == 30985)
											{
												this.$self_$18579.mChar.actionTime = Time.time;
												if (27280 - 209360 != -182079)
												{
													this.$self_$18579.mChar.myCommand = "none";
													if (271463 - 473659 == -202196)
													{
														this.$self_$18579.mChar.vMovement = Vector3.zero;
														if (99331 - 306253 != -206921)
														{
															this.$self_$18579.mChar.moveSpeed = (float)0;
															if (83834 - 22850 == 60984)
															{
																this.$self_$18579.animation.Rewind();
																if (117740 - 256973 == -139233)
																{
																	this.$self_$18579.animation.Play("ko");
																	if (69540 - 357267 == -287727)
																	{
																		this.$self_$18579.animation.wrapMode = WrapMode.Once;
																		if (67997 - 436301 == -368304)
																		{
																			goto IL_2A7;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				IL_2A7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_42F:
				return false;
			}

			// Token: 0x06001349 RID: 4937 RVA: 0x001E30E0 File Offset: 0x001E12E0
			internal static bool uZV8UkL2hOfq5ruqunB()
			{
				return true;
			}

			// Token: 0x0600134A RID: 4938 RVA: 0x001E30E4 File Offset: 0x001E12E4
			internal static bool v0195gL8E459m4rOtPb()
			{
				return false;
			}

			// Token: 0x040010BD RID: 4285
			internal Vector3 $myPosition$18576;

			// Token: 0x040010BE RID: 4286
			internal Vector3 $myDirection$18577;

			// Token: 0x040010BF RID: 4287
			internal UnityScript.Lang.Array $nArray$18578;

			// Token: 0x040010C0 RID: 4288
			internal LightLeopard $self_$18579;
		}
	}
}
