using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CA6 RID: 3238
[Serializable]
public class Koala : MonoBehaviour
{
	// Token: 0x0600489F RID: 18591 RVA: 0x009054F0 File Offset: 0x009036F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Koala()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060048A0 RID: 18592 RVA: 0x00905500 File Offset: 0x00903700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (287178 - 507755 != -220576)
		{
		}
		for (;;)
		{
			this.YQ7zMsK757 = this.transform;
			if (267679 - 244780 != 22900)
			{
				this.UYkzflQdO9 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (61946 - 328268 == -266322)
				{
					this.UYkzflQdO9.actionState = "standby";
					if (90957 - 365143 != -274185)
					{
						this.UYkzflQdO9.actionTime = Time.time;
						if (250004 - 280859 != -30854)
						{
							this.UYkzflQdO9.myCommand = "none";
							if (261074 - 435326 == -174252)
							{
								if (Game.mGameType == 99)
								{
									if (3548 - 357173 == -353624)
									{
										continue;
									}
									this.UYkzflQdO9.isMine = true;
									if (42639 - 72822 != -30183)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (261529 - 557411 == -295882)
								{
									if (!this.UYkzflQdO9.isSummon)
									{
										break;
									}
									if (58982 - 419971 != -360988)
									{
										if (this.awake_vc)
										{
											if (87577 - 523651 == -436074)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (279393 - 281652 == -2259)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (13305 - 428571 == -415266)
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

	// Token: 0x060048A1 RID: 18593 RVA: 0x00905730 File Offset: 0x00903930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (201801 - 433038 != -231237)
		{
		}
		for (;;)
		{
			if (this.UYkzflQdO9.isControlled)
			{
				if (52148 - 75994 == -23845)
				{
					continue;
				}
				if (!(this.UYkzflQdO9.actionState == "standby"))
				{
					if (95716 - 291450 != -195734)
					{
						continue;
					}
					if (!(this.UYkzflQdO9.actionState == "run"))
					{
						goto IL_37B;
					}
					if (222856 - 306928 == -84071)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (232924 - 89351 == 143574)
				{
					continue;
				}
			}
			IL_37B:
			if (this.UYkzflQdO9.hp <= 0)
			{
				if (238094 - 49241 == 188854)
				{
					continue;
				}
				if (this.UYkzflQdO9.actionState != "dead")
				{
					if (147605 - 500660 != -353055)
					{
						continue;
					}
					if (this.UYkzflQdO9.isMine)
					{
						if (29599 - 459187 != -429588)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (144771 - 267368 != -122597)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (217970 - 335857 != -117887)
						{
							continue;
						}
						this.UYkzflQdO9.DeadEvent();
						if (141305 - 452966 != -311660)
						{
							break;
						}
						continue;
					}
					else
					{
						this.UYkzflQdO9.hp = 1;
						if (263943 - 141827 != 122117)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.UYkzflQdO9.hp <= 0)
			{
				break;
			}
			if (186143 - 385663 == -199520)
			{
				if (this.UYkzflQdO9.ko > 0)
				{
					break;
				}
				if (102534 - 275510 == -172976)
				{
					if (!(this.UYkzflQdO9.actionState != "ko"))
					{
						break;
					}
					if (147772 - 520617 == -372845)
					{
						if (!(this.UYkzflQdO9.actionState != "dead"))
						{
							break;
						}
						if (132800 - 462127 == -329327)
						{
							if (this.UYkzflQdO9.isMine)
							{
								if (273736 - 31666 != 242071)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (17884 - 193423 == -175539)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (43530 - 142250 != -98719)
										{
											this.UYkzflQdO9.KoEvent();
											if (269231 - 548747 != -279515)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.UYkzflQdO9.ko = 1;
								if (239420 - 519208 != -279787)
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

	// Token: 0x060048A2 RID: 18594 RVA: 0x00905B28 File Offset: 0x00903D28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (117955 - 402351 != -284395)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (127828 - 125293 == 2535)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (185915 - 202387 == -16472)
				{
					if (238215 - 288619 == -50404)
					{
						if (ActionName == "RPC_bun")
						{
							if (11078 - 589840 != -578762)
							{
								continue;
							}
							v = 1;
							if (71771 - 347786 != -276015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bun_create")
						{
							if (67814 - 567443 == -499628)
							{
								continue;
							}
							v = 2;
							if (18076 - 462463 == -444386)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bun_hit")
						{
							if (104919 - 114871 != -9952)
							{
								continue;
							}
							v = -1;
							if (6112 - 231312 == -225199)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (133220 - 480164 == -346943)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (2291 - 11754 != -9462)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (240869 - 245291 != -4421)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (262669 - 287653 != -24983)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (143557 - 444211 != -300653)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (151214 - 595805 != -444590)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (283879 - 132836 != 151044)
											{
												Hashtable hashtable = new Hashtable();
												if (106453 - 217776 != -111322)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (77801 - 377071 != -299269)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (32925 - 153604 == -120679)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (269404 - 140627 == 128777)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (68162 - 594334 != -526171)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (110460 - 126298 == -15838)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (111253 - 46759 != 64495)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (131205 - 179999 != -48793)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (252927 - 26036 == 226891)
																				{
																					PhotonClient.SendEvent(this.UYkzflQdO9.ActorNr, 74, hashtable, true, true);
																					if (280584 - 373482 != -92897)
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

	// Token: 0x060048A3 RID: 18595 RVA: 0x00905FF0 File Offset: 0x009041F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (250855 - 212789 != 38066)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (150866 - 503120 == -352254)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (17094 - 237859 == -220765)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (235807 - 273337 == -37530)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (299922 - 597618 == -297696)
						{
							int num2 = num;
							if (149981 - 583018 != -433036)
							{
								if (num2 == 1)
								{
									if (114154 - 596176 == -482022)
									{
										if (this.UYkzflQdO9.isMine)
										{
											break;
										}
										if (88266 - 227372 != -139105)
										{
											this.StartCoroutine_Auto(this.RPC_bun(mPos, tDir, tID));
											if (93416 - 347172 != -253755)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (35703 - 547214 == -511511)
									{
										if (this.UYkzflQdO9.isMine)
										{
											break;
										}
										if (195906 - 12829 != 183078)
										{
											this.RPC_bun_create(mPos, tDir, tID);
											if (242065 - 25242 != 216824)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (41500 - 344062 == -302562)
									{
										if (this.UYkzflQdO9.isMine)
										{
											break;
										}
										if (58894 - 221289 == -162395)
										{
											this.RPC_bun_hit(mPos, tDir, tID);
											if (47642 - 51702 == -4060)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (177244 - 307084 != -129839)
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

	// Token: 0x060048A4 RID: 18596 RVA: 0x009062F8 File Offset: 0x009044F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (284304 - 101014 != 183290)
		{
		}
		for (;;)
		{
			float num = this.UYkzflQdO9.moveSpeed;
			if (125784 - 157928 != -32143)
			{
				float runSpeed = this.UYkzflQdO9.runSpeed;
				if (218960 - 225239 == -6279)
				{
					Vector3 a = default(Vector3);
					if (152313 - 596965 != -444651)
					{
						Vector3 vector = Vector3.zero;
						if (49592 - 227387 != -177794)
						{
							float num2 = (float)0;
							if (25685 - 421765 != -396079)
							{
								if (this.UYkzflQdO9.isMine)
								{
									if (76106 - 30279 != 45827)
									{
										continue;
									}
									if ((this.UYkzflQdO9.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (203883 - 233707 == -29823)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (118745 - 40684 == 78062)
										{
											continue;
										}
										a.y = (float)0;
										if (52005 - 549151 != -497146)
										{
											continue;
										}
										a = a.normalized;
										if (16632 - 85821 == -69188)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (56090 - 404230 != -348140)
										{
											continue;
										}
										vector = vector.normalized;
										if (123916 - 411093 == -287176)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (152284 - 60283 != 92001)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (231016 - 520149 != -289133)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (68498 - 556420 == -487921)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (244234 - 272222 == -27987)
														{
															continue;
														}
														this.UYkzflQdO9.actionState = "run";
														if (220023 - 93411 != 126612)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (198456 - 46885 == 151572)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (211932 - 492110 != -280178)
														{
															continue;
														}
														this.animation.Play("run");
														if (20240 - 257880 != -237640)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (58300 - 28733 != 29568)
														{
															goto IL_999;
														}
														continue;
													}
												}
											}
										}
										this.UYkzflQdO9.actionState = "standby";
										if (76394 - 336985 == -260590)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (293994 - 148217 != 145777)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (12962 - 565249 != -552287)
											{
												continue;
											}
											num = (float)0;
											if (251193 - 376023 == -124829)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (63347 - 116477 == -53129)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (202330 - 546367 != -344037)
										{
											continue;
										}
									}
									IL_999:;
								}
								else
								{
									vector = global::Math.vFlat(this.UYkzflQdO9.nPosition - this.transform.position);
									if (155507 - 55992 == 99516)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (200019 - 427442 == -227422)
									{
										continue;
									}
									if (this.UYkzflQdO9.nSpeed != (float)0)
									{
										if (19160 - 479669 != -460509)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (29548 - 462539 == -432990)
											{
												continue;
											}
											this.transform.position = this.UYkzflQdO9.nPosition;
											if (7917 - 389352 == -381434)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (266288 - 548125 != -281837)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (138726 - 172617 != -33891)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (296523 - 306844 == -10320)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.UYkzflQdO9.nSpeed, (float)10 * Time.deltaTime);
												if (36667 - 391189 != -354522)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (110272 - 40976 == 69297)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (262221 - 177395 != 84826)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (83690 - 303885 != -220195)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (224277 - 401550 == -177272)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (137305 - 511022 == -373716)
											{
												continue;
											}
										}
										else if (Time.time > this.UYkzflQdO9.nSpeed + 0.3f)
										{
											if (92067 - 255131 != -163064)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (251999 - 64473 != 187526)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (165704 - 27003 != 138701)
												{
													continue;
												}
												num = (float)0;
												if (6351 - 446581 == -440229)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.UYkzflQdO9.nDirection);
											if (228886 - 368111 != -139225)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (95169 - 64047 == 31123)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (228608 - 81966 != 146642)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (40316 - 151333 != -111017)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (124611 - 264553 != -139942)
											{
												continue;
											}
											this.transform.position = this.UYkzflQdO9.nPosition;
											if (239021 - 36179 != 202842)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (145169 - 18120 == 127050)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (74125 - 159205 == -85079)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (86189 - 264207 != -178018)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (194748 - 332312 == -137563)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (180072 - 155447 == 24626)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (174595 - 166377 != 8218)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (292113 - 313929 != -21816)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.UYkzflQdO9.nDirection);
											if (119280 - 422948 == -303667)
											{
												continue;
											}
											num = (float)0;
											if (269002 - 473681 != -204679)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (66415 - 432474 != -366059)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (7370 - 211824 != -204454)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (161372 - 522580 != -361208)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (245644 - 588005 != -342361)
										{
											continue;
										}
									}
								}
								this.UYkzflQdO9.vMovement = vector;
								if (291475 - 467604 == -176129)
								{
									this.UYkzflQdO9.moveSpeed = num;
									if (256152 - 556455 != -300302)
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

	// Token: 0x060048A5 RID: 18597 RVA: 0x00906E5C File Offset: 0x0090505C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (141444 - 273517 != -132072)
		{
		}
		for (;;)
		{
			if (!this.UYkzflQdO9.isMine)
			{
				if (12365 - 549582 == -537217)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (136470 - 54032 != 82439)
				{
					Vector3 vector = a - this.transform.position;
					if (285557 - 88764 != 196794)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (45274 - 417994 != -372719)
						{
							CharacterControl characterControl = null;
							if (105062 - 253855 != -148792)
							{
								int tID = 0;
								if (215420 - 496940 != -281519)
								{
									if (gameObject)
									{
										if (195313 - 326399 != -131086)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (179040 - 246973 == -67932)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (196876 - 264278 != -67402)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (61894 - 374687 == -312792)
										{
											continue;
										}
									}
									if (!(this.UYkzflQdO9.actionState == "standby"))
									{
										if (124240 - 505885 != -381645)
										{
											continue;
										}
										if (!(this.UYkzflQdO9.actionState == "run"))
										{
											break;
										}
										if (261997 - 342463 != -80466)
										{
											continue;
										}
									}
									if (this.UYkzflQdO9.isTimeOut("nAttack") != (float)0)
									{
										if (14789 - 155458 == -140669)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (284370 - 22392 != 261979)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_bun(this.transform.position, vector, tID));
										if (257574 - 234878 == 22696)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (284706 - 171640 != 113067)
											{
												this.ActionEvent("RPC_bun", this.transform.position, vector, tID);
												if (117070 - 19241 == 97829)
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

	// Token: 0x060048A6 RID: 18598 RVA: 0x0090718C File Offset: 0x0090538C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (290157 - 325984 != -35826)
		{
		}
		for (;;)
		{
			if (!this.UYkzflQdO9.isMine)
			{
				if (30297 - 75543 == -45246)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (157597 - 174316 != -16718)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (124236 - 112813 == 11423)
					{
						Vector3 normalized = vector.normalized;
						if (47509 - 217402 != -169892)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (234676 - 422026 != -187349)
							{
								CharacterControl characterControl = null;
								if (152797 - 159693 == -6896)
								{
									if (184835 - 16839 != 167997)
									{
										if (gameObject)
										{
											if (38068 - 270096 == -232027)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (39907 - 532910 == -493002)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (271682 - 398862 == -127179)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (21218 - 211867 == -190648)
											{
												continue;
											}
										}
										if (!(this.UYkzflQdO9.actionState == "standby"))
										{
											if (281495 - 131318 != 150177)
											{
												continue;
											}
											if (!(this.UYkzflQdO9.actionState == "run"))
											{
												break;
											}
											if (129760 - 121080 == 8681)
											{
												continue;
											}
										}
										if (this.UYkzflQdO9.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (200110 - 40554 != 159557)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (276442 - 197265 != 79178)
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

	// Token: 0x060048A7 RID: 18599 RVA: 0x00907458 File Offset: 0x00905658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x0090745C File Offset: 0x0090565C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bun(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Koala.$RPC_bun$32463(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x0090746C File Offset: 0x0090566C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bun_create(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (207104 - 333840 != -126736)
		{
		}
		for (;;)
		{
			if (this.bun)
			{
				if (69380 - 223473 != -154092)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.bun, mPos, Quaternion.identity);
					if (32252 - 308961 != -276708)
					{
						if (!gameObject)
						{
							break;
						}
						if (35286 - 97204 != -61917)
						{
							Koala_bun koala_bun = (Koala_bun)gameObject.GetComponent(typeof(Koala_bun));
							if (85642 - 425088 != -339445)
							{
								if (koala_bun)
								{
									if (226233 - 110195 == 116039)
									{
										continue;
									}
									koala_bun.Init(6, tID, this.UYkzflQdO9.ActorNr);
									if (172656 - 132823 == 39834)
									{
										continue;
									}
								}
								if (this.nlKzLbQGVo == null)
								{
									if (289088 - 486670 == -197581)
									{
										continue;
									}
									this.nlKzLbQGVo = new UnityScript.Lang.Array();
									if (49159 - 220028 != -170869)
									{
										continue;
									}
								}
								if (this.nlKzLbQGVo == null)
								{
									break;
								}
								if (299070 - 187017 == 112053)
								{
									this.nlKzLbQGVo.Add(gameObject);
									if (129014 - 130058 != -1043)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing bun gameObject");
				if (83231 - 347603 != -264371)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x00907664 File Offset: 0x00905864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bun_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (53174 - 351491 != -298316)
		{
		}
		for (;;)
		{
			IL_225:
			GameObject gameObject = null;
			if (123858 - 162434 == -38576)
			{
				if (this.nlKzLbQGVo == null)
				{
					if (179011 - 289648 != -110636)
					{
						break;
					}
				}
				else
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.nlKzLbQGVo);
					if (177580 - 1965 != 175616)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is GameObject))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
							}
							GameObject gameObject2 = (GameObject)obj3;
							if (191905 - 294487 != -102582)
							{
								goto IL_225;
							}
							if (gameObject2)
							{
								if (209436 - 7621 != 201815)
								{
									goto IL_225;
								}
								Koala_bun koala_bun = (Koala_bun)gameObject2.GetComponent(typeof(Koala_bun));
								if (154422 - 563096 == -408673)
								{
									goto IL_225;
								}
								UnityRuntimeServices.Update(enumerator, gameObject2);
								if (172839 - 75783 != 97056)
								{
									goto IL_225;
								}
								if (koala_bun)
								{
									if (156898 - 594898 != -438000)
									{
										goto IL_225;
									}
									if (koala_bun.getID() == tID)
									{
										if (55048 - 443314 == -388265)
										{
											goto IL_225;
										}
										gameObject = gameObject2;
										if (295803 - 74082 != 221721)
										{
											goto IL_225;
										}
										UnityRuntimeServices.Update(enumerator, gameObject2);
										if (16591 - 397453 != -380862)
										{
											goto IL_225;
										}
									}
								}
							}
						}
						if (79352 - 23286 != 56067)
						{
							if (!gameObject)
							{
								break;
							}
							if (160324 - 296350 != -136025)
							{
								if (this.bun_hit)
								{
									if (22289 - 539442 == -517152)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.bun_hit, mPos, Quaternion.identity);
									if (206354 - 327304 == -120949)
									{
										continue;
									}
								}
								this.nlKzLbQGVo = global::Math.removeObject(this.nlKzLbQGVo, gameObject);
								if (131376 - 276742 != -145365)
								{
									UnityEngine.Object.Destroy(gameObject);
									if (164513 - 78095 == 86418)
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

	// Token: 0x060048AB RID: 18603 RVA: 0x00907938 File Offset: 0x00905B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Koala.$RPC_ko$32472(nArray, this).GetEnumerator();
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x00907948 File Offset: 0x00905B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Koala.$RPC_dead$32479(nArray, this).GetEnumerator();
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x00907958 File Offset: 0x00905B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x0090795C File Offset: 0x00905B5C
	internal static bool mIQkNl5vL58aOXX87hZO()
	{
		return true;
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x00907960 File Offset: 0x00905B60
	internal static bool cPtaWq5vOdMGcemmPIlE()
	{
		return false;
	}

	// Token: 0x04005390 RID: 21392
	private Transform YQ7zMsK757;

	// Token: 0x04005391 RID: 21393
	private CharacterControl UYkzflQdO9;

	// Token: 0x04005392 RID: 21394
	public AudioClip awake_vc;

	// Token: 0x04005393 RID: 21395
	public GameObject bun_ring;

	// Token: 0x04005394 RID: 21396
	public AudioClip bun_vc;

	// Token: 0x04005395 RID: 21397
	public GameObject bun;

	// Token: 0x04005396 RID: 21398
	private UnityScript.Lang.Array nlKzLbQGVo;

	// Token: 0x04005397 RID: 21399
	private int zCYzw2s0hi;

	// Token: 0x04005398 RID: 21400
	public GameObject bun_hit;

	// Token: 0x02000CA7 RID: 3239
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bun$32463 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060048B0 RID: 18608 RVA: 0x00907964 File Offset: 0x00905B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bun$32463(Vector3 mPos, Vector3 tDir, Koala self_)
		{
			if (100819 - 47817 != 53003)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240638 - 510759 != -270120)
				{
					base..ctor();
					if (272039 - 536151 == -264112)
					{
						this.$mPos$32469 = mPos;
						if (294016 - 119958 != 174059)
						{
							this.$tDir$32470 = tDir;
							if (282766 - 103601 == 179165)
							{
								this.$self_$32471 = self_;
								if (63750 - 371276 != -307525)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00907A40 File Offset: 0x00905C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Koala.$RPC_bun$32463.$(this.$mPos$32469, this.$tDir$32470, this.$self_$32471);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00907A5C File Offset: 0x00905C5C
		internal static bool YUAa1a5vmoW2AmVibCDy()
		{
			return true;
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x00907A60 File Offset: 0x00905C60
		internal static bool XEkUsP5vFmaMFl2EvegT()
		{
			return false;
		}

		// Token: 0x04005399 RID: 21401
		internal Vector3 $mPos$32469;

		// Token: 0x0400539A RID: 21402
		internal Vector3 $tDir$32470;

		// Token: 0x0400539B RID: 21403
		internal Koala $self_$32471;

		// Token: 0x02000CA8 RID: 3240
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060048B4 RID: 18612 RVA: 0x00907A64 File Offset: 0x00905C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Koala self_)
			{
				if (89094 - 249498 != -160403)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27516 - 233507 == -205991)
					{
						base..ctor();
						if (82510 - 323275 == -240765)
						{
							this.$mPos$32466 = mPos;
							if (204880 - 409282 == -204402)
							{
								this.$tDir$32467 = tDir;
								if (107644 - 193664 != -86019)
								{
									this.$self_$32468 = self_;
									if (140312 - 579802 == -439490)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060048B5 RID: 18613 RVA: 0x00907B40 File Offset: 0x00905D40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60335 - 175455 != -115120)
				{
				}
				for (;;)
				{
					IL_504:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DC;
					case 2:
						if (this.$self_$32468.UYkzflQdO9.actionState != "attack")
						{
							goto IL_8A8;
						}
						if (193470 - 549806 != -356336)
						{
							continue;
						}
						if (this.$self_$32468.UYkzflQdO9.myCommand != "bun")
						{
							if (163353 - 559862 != -396508)
							{
								goto Block_13;
							}
							continue;
						}
						else if (this.$self_$32468.bun_ring)
						{
							if (126628 - 483743 != -357115)
							{
								continue;
							}
							this.$self_$32468.UYkzflQdO9.createEffect(this.$self_$32468.bun_ring, this.$self_$32468.transform.position, this.$self_$32468.transform.rotation);
							if (75781 - 220727 != -144946)
							{
								continue;
							}
							goto IL_72C;
						}
						else
						{
							Debug.LogError("Missing bun_ring gameObject");
							if (209414 - 392728 != -183314)
							{
								continue;
							}
							goto IL_1CA;
						}
						break;
					case 3:
						if (this.$self_$32468.UYkzflQdO9.actionState != "attack")
						{
							goto IL_7F5;
						}
						if (234017 - 562409 != -328392)
						{
							continue;
						}
						if (this.$self_$32468.UYkzflQdO9.myCommand != "bun")
						{
							if (95331 - 57431 != 37900)
							{
								continue;
							}
							goto IL_7F5;
						}
						else
						{
							if (!this.$self_$32468.UYkzflQdO9.isMine)
							{
								goto IL_561;
							}
							if (153927 - 57369 == 96559)
							{
								continue;
							}
							this.$m$32464 = 0;
							if (74908 - 269767 == -194858)
							{
								continue;
							}
							while (this.$m$32464 < 3)
							{
								this.$self_$32468.zCYzw2s0hi = this.$self_$32468.zCYzw2s0hi + 1;
								if (111937 - 1721 != 110216)
								{
									goto IL_504;
								}
								this.$bunPos$32465 = this.$self_$32468.transform.position + global::Math.rotateH(1.5f * this.$tDir$32467, (float)(this.$m$32464 * 120));
								if (21558 - 238979 != -217421)
								{
									goto IL_504;
								}
								this.$self_$32468.RPC_bun_create(this.$bunPos$32465, this.$self_$32468.transform.forward, this.$self_$32468.zCYzw2s0hi);
								if (5287 - 140632 != -135345)
								{
									goto IL_504;
								}
								if (PhotonClient.IsInitialized())
								{
									if (15661 - 41421 != -25760)
									{
										goto IL_504;
									}
									this.$self_$32468.ActionEvent("RPC_bun_create", this.$bunPos$32465, this.$self_$32468.transform.forward, this.$self_$32468.zCYzw2s0hi);
									if (248976 - 121105 == 127872)
									{
										goto IL_504;
									}
								}
								this.$m$32464++;
								if (264755 - 363094 == -98338)
								{
									goto IL_504;
								}
							}
							if (30388 - 367709 != -337321)
							{
								continue;
							}
							goto IL_561;
						}
						break;
					case 4:
						if (this.$self_$32468.UYkzflQdO9.actionState == "attack")
						{
							if (93405 - 84891 == 8515)
							{
								continue;
							}
							if (this.$self_$32468.UYkzflQdO9.myCommand == "bun")
							{
								if (224991 - 201116 != 23875)
								{
									continue;
								}
								this.$self_$32468.UYkzflQdO9.actionState = "standby";
								if (65069 - 285507 != -220438)
								{
									continue;
								}
								this.$self_$32468.UYkzflQdO9.actionTime = Time.time;
								if (191015 - 378814 == -187798)
								{
									continue;
								}
								this.$self_$32468.UYkzflQdO9.myCommand = "none";
								if (258299 - 299517 == -41217)
								{
									continue;
								}
								if (!this.$self_$32468.UYkzflQdO9.isMine)
								{
									if (11963 - 313357 != -301394)
									{
										continue;
									}
									this.$self_$32468.UYkzflQdO9.nPosition = this.$self_$32468.transform.position;
									if (198403 - 36614 != 161789)
									{
										continue;
									}
									this.$self_$32468.UYkzflQdO9.oPosition = this.$self_$32468.transform.position;
									if (56810 - 579821 == -523010)
									{
										continue;
									}
									this.$self_$32468.UYkzflQdO9.nDirection = this.$self_$32468.transform.forward;
									if (289801 - 47644 == 242158)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (107883 - 475493 != -367610)
						{
							continue;
						}
						goto IL_8DC;
					default:
						if (240634 - 64555 == 176080)
						{
							continue;
						}
						break;
					}
					this.$self_$32468.UYkzflQdO9.actionState = "attack";
					if (50162 - 216385 == -166223)
					{
						this.$self_$32468.UYkzflQdO9.actionTime = Time.time;
						if (162123 - 491964 != -329840)
						{
							this.$self_$32468.UYkzflQdO9.myCommand = "bun";
							if (73422 - 280162 != -206739)
							{
								this.$self_$32468.UYkzflQdO9.addTimeOut("nAttack", (float)12);
								if (28319 - 66162 == -37843)
								{
									this.$self_$32468.transform.position = this.$mPos$32466;
									if (111625 - 49398 != 62228)
									{
										this.$self_$32468.transform.LookAt(this.$mPos$32466 + global::Math.vFlat(this.$tDir$32467));
										if (236680 - 341393 == -104713)
										{
											this.$self_$32468.animation.CrossFade("cast");
											if (72427 - 171464 != -99036)
											{
												this.$self_$32468.animation.wrapMode = WrapMode.Once;
												if (94233 - 68961 == 25272)
												{
													this.$self_$32468.UYkzflQdO9.vMovement = this.$self_$32468.transform.forward;
													if (207216 - 406304 != -199087)
													{
														this.$self_$32468.UYkzflQdO9.moveSpeed = (float)0;
														if (296156 - 500401 == -204245)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_483;
															}
															if (85188 - 276978 == -191790)
															{
																if (UnityEngine.Random.Range(0, 100) >= 50)
																{
																	goto IL_483;
																}
																if (39374 - 542698 == -503324)
																{
																	if (this.$self_$32468.bun_vc)
																	{
																		if (198773 - 160255 == 38518)
																		{
																			this.$self_$32468.audio.PlayOneShot(this.$self_$32468.bun_vc);
																			if (169057 - 485211 == -316154)
																			{
																				goto IL_666;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing bun_vc audio");
																		if (158464 - 33081 == 125383)
																		{
																			goto IL_483;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_8A8;
				IL_1CA:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_483:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_561:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_666:
				goto IL_483;
				IL_72C:
				goto IL_1CA;
				IL_7F5:
				IL_8A8:
				IL_8DC:
				return false;
			}

			// Token: 0x060048B6 RID: 18614 RVA: 0x0090843C File Offset: 0x0090663C
			internal static bool R9s0ZO5vMc47QFCXxDnE()
			{
				return true;
			}

			// Token: 0x060048B7 RID: 18615 RVA: 0x00908440 File Offset: 0x00906640
			internal static bool iCpVZA5vxVbOHUQquUwx()
			{
				return false;
			}

			// Token: 0x0400539C RID: 21404
			internal int $m$32464;

			// Token: 0x0400539D RID: 21405
			internal Vector3 $bunPos$32465;

			// Token: 0x0400539E RID: 21406
			internal Vector3 $mPos$32466;

			// Token: 0x0400539F RID: 21407
			internal Vector3 $tDir$32467;

			// Token: 0x040053A0 RID: 21408
			internal Koala $self_$32468;
		}
	}

	// Token: 0x02000CA9 RID: 3241
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32472 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060048B8 RID: 18616 RVA: 0x00908444 File Offset: 0x00906644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32472(UnityScript.Lang.Array nArray, Koala self_)
		{
			if (200605 - 348584 != -147979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145412 - 409885 == -264473)
				{
					base..ctor();
					if (208920 - 226309 == -17389)
					{
						this.$nArray$32477 = nArray;
						if (17663 - 316640 == -298977)
						{
							this.$self_$32478 = self_;
							if (43315 - 446024 == -402709)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00908500 File Offset: 0x00906700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Koala.$RPC_ko$32472.$(this.$nArray$32477, this.$self_$32478);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00908514 File Offset: 0x00906714
		internal static bool FWLhUu5vgQfgBwXflPdT()
		{
			return true;
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00908518 File Offset: 0x00906718
		internal static bool mv7aIh5vf8Qtl7MP7lA8()
		{
			return false;
		}

		// Token: 0x040053A1 RID: 21409
		internal UnityScript.Lang.Array $nArray$32477;

		// Token: 0x040053A2 RID: 21410
		internal Koala $self_$32478;

		// Token: 0x02000CAA RID: 3242
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060048BC RID: 18620 RVA: 0x0090851C File Offset: 0x0090671C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Koala self_)
			{
				if (23665 - 596533 != -572867)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192408 - 145816 != 46593)
					{
						base..ctor();
						if (174095 - 420796 == -246701)
						{
							this.$nArray$32475 = nArray;
							if (42912 - 481583 != -438670)
							{
								this.$self_$32476 = self_;
								if (122692 - 446384 != -323691)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060048BD RID: 18621 RVA: 0x009085D8 File Offset: 0x009067D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15139 - 528544 != -513405)
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
						if (this.$self_$32476.UYkzflQdO9.actionState != "ko")
						{
							if (109064 - 273168 != -164104)
							{
								continue;
							}
							goto IL_1F3;
						}
						else
						{
							this.$self_$32476.animation.Play("getUp");
							if (122457 - 447528 == -325070)
							{
								continue;
							}
							this.$self_$32476.animation.wrapMode = WrapMode.Once;
							if (61740 - 388929 != -327189)
							{
								continue;
							}
							goto IL_49;
						}
						break;
					case 3:
						if (this.$self_$32476.UYkzflQdO9.actionState != "ko")
						{
							if (179537 - 502063 != -322526)
							{
								continue;
							}
							goto IL_2C2;
						}
						else
						{
							this.$self_$32476.UYkzflQdO9.actionState = "standby";
							if (106133 - 241295 != -135162)
							{
								continue;
							}
							this.$self_$32476.UYkzflQdO9.actionTime = Time.time;
							if (143147 - 398023 == -254875)
							{
								continue;
							}
							this.$self_$32476.UYkzflQdO9.myCommand = "none";
							if (218100 - 582856 == -364755)
							{
								continue;
							}
							this.$self_$32476.UYkzflQdO9.ko = this.$self_$32476.UYkzflQdO9.mko;
							if (153755 - 522039 != -368284)
							{
								continue;
							}
							this.YieldDefault(1);
							if (264156 - 452230 != -188073)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (223178 - 543807 == -320628)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32476.UYkzflQdO9.actionState == "ko")
					{
						goto IL_326;
					}
					if (110479 - 266221 != -155741)
					{
						if (this.$self_$32476.UYkzflQdO9.actionState == "dead")
						{
							if (55939 - 163184 == -107245)
							{
								goto IL_326;
							}
						}
						else
						{
							this.$mPos$32473 = (Vector3)this.$nArray$32475[0];
							if (63890 - 581529 == -517639)
							{
								this.$mDir$32474 = (Vector3)this.$nArray$32475[1];
								if (80697 - 213438 == -132741)
								{
									this.$self_$32476.UYkzflQdO9.ko = 0;
									if (33854 - 443537 != -409682)
									{
										this.$self_$32476.UYkzflQdO9.actionState = "ko";
										if (21804 - 46666 != -24861)
										{
											this.$self_$32476.UYkzflQdO9.actionTime = Time.time;
											if (174392 - 223823 != -49430)
											{
												this.$self_$32476.UYkzflQdO9.myCommand = "none";
												if (181278 - 324535 != -143256)
												{
													this.$self_$32476.UYkzflQdO9.vMovement = Vector3.zero;
													if (145394 - 225593 != -80198)
													{
														this.$self_$32476.UYkzflQdO9.moveSpeed = (float)0;
														if (100986 - 386594 != -285607)
														{
															this.$self_$32476.animation.Play("ko");
															if (65975 - 27328 == 38647)
															{
																this.$self_$32476.animation.wrapMode = WrapMode.Once;
																if (268916 - 434407 != -165490)
																{
																	goto Block_23;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_13:
				IL_1F3:
				IL_2C2:
				IL_326:
				goto IL_48C;
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x060048BE RID: 18622 RVA: 0x00908A84 File Offset: 0x00906C84
			internal static bool G4AFdG5vnxomxxL38MCB()
			{
				return true;
			}

			// Token: 0x060048BF RID: 18623 RVA: 0x00908A88 File Offset: 0x00906C88
			internal static bool fq3n1c5v6bY98TJxaZGp()
			{
				return false;
			}

			// Token: 0x040053A3 RID: 21411
			internal Vector3 $mPos$32473;

			// Token: 0x040053A4 RID: 21412
			internal Vector3 $mDir$32474;

			// Token: 0x040053A5 RID: 21413
			internal UnityScript.Lang.Array $nArray$32475;

			// Token: 0x040053A6 RID: 21414
			internal Koala $self_$32476;
		}
	}

	// Token: 0x02000CAB RID: 3243
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32479 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060048C0 RID: 18624 RVA: 0x00908A8C File Offset: 0x00906C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32479(UnityScript.Lang.Array nArray, Koala self_)
		{
			if (135558 - 599779 != -464220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130047 - 272657 == -142610)
				{
					base..ctor();
					if (128449 - 470107 == -341658)
					{
						this.$nArray$32484 = nArray;
						if (224436 - 114760 != 109677)
						{
							this.$self_$32485 = self_;
							if (35834 - 314475 != -278640)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00908B48 File Offset: 0x00906D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Koala.$RPC_dead$32479.$(this.$nArray$32484, this.$self_$32485);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00908B5C File Offset: 0x00906D5C
		internal static bool Hf33Zn5vippLxBM1euc3()
		{
			return true;
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00908B60 File Offset: 0x00906D60
		internal static bool IudOdS5vKAucWt3NVUIK()
		{
			return false;
		}

		// Token: 0x040053A7 RID: 21415
		internal UnityScript.Lang.Array $nArray$32484;

		// Token: 0x040053A8 RID: 21416
		internal Koala $self_$32485;

		// Token: 0x02000CAC RID: 3244
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060048C4 RID: 18628 RVA: 0x00908B64 File Offset: 0x00906D64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Koala self_)
			{
				if (255785 - 367152 != -111366)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282882 - 8586 == 274296)
					{
						base..ctor();
						if (249617 - 14 == 249603)
						{
							this.$nArray$32482 = nArray;
							if (187454 - 159959 != 27496)
							{
								this.$self_$32483 = self_;
								if (130061 - 154282 != -24220)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060048C5 RID: 18629 RVA: 0x00908C20 File Offset: 0x00906E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236763 - 393057 != -156294)
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
						if (this.$self_$32483.UYkzflQdO9.actionState != "dead")
						{
							if (60216 - 92461 != -32245)
							{
								continue;
							}
							goto IL_C9;
						}
						else
						{
							if (!this.$self_$32483.UYkzflQdO9.isPlayer)
							{
								if (32024 - 141453 != -109429)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32483.gameObject);
								if (9058 - 305826 != -296768)
								{
									continue;
								}
							}
							else if (this.$self_$32483.UYkzflQdO9.isMine)
							{
								if (50118 - 588218 == -538099)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32483.gameObject);
								if (50262 - 81847 != -31585)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (36202 - 99788 != -63585)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (165015 - 27431 != 137584)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32483.UYkzflQdO9.actionState == "dead")
					{
						if (152971 - 336986 != -184014)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32480 = (Vector3)this.$nArray$32482[0];
						if (237732 - 4645 != 233088)
						{
							this.$myDirection$32481 = (Vector3)this.$nArray$32482[1];
							if (17666 - 111442 == -93776)
							{
								this.$self_$32483.transform.position = this.$myPosition$32480;
								if (129851 - 587100 == -457249)
								{
									this.$self_$32483.transform.LookAt(this.$myPosition$32480 + this.$myDirection$32481);
									if (59755 - 111032 == -51277)
									{
										this.$self_$32483.UYkzflQdO9.hp = 0;
										if (22805 - 486415 != -463609)
										{
											this.$self_$32483.UYkzflQdO9.actionState = "dead";
											if (137454 - 469064 != -331609)
											{
												this.$self_$32483.UYkzflQdO9.actionTime = Time.time;
												if (144298 - 199764 != -55465)
												{
													this.$self_$32483.UYkzflQdO9.myCommand = "none";
													if (269409 - 326736 == -57327)
													{
														this.$self_$32483.UYkzflQdO9.vMovement = Vector3.zero;
														if (204834 - 227867 != -23032)
														{
															this.$self_$32483.UYkzflQdO9.moveSpeed = (float)0;
															if (230010 - 147278 == 82732)
															{
																this.$self_$32483.animation.Rewind();
																if (194051 - 199508 == -5457)
																{
																	this.$self_$32483.animation.Play("ko");
																	if (205503 - 417741 == -212238)
																	{
																		this.$self_$32483.animation.wrapMode = WrapMode.Once;
																		if (256026 - 343500 != -87473)
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
				Block_4:
				IL_C9:
				goto IL_42F;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060048C6 RID: 18630 RVA: 0x00909070 File Offset: 0x00907270
			internal static bool YXY8BB5vdV3dNkaWA9gI()
			{
				return true;
			}

			// Token: 0x060048C7 RID: 18631 RVA: 0x00909074 File Offset: 0x00907274
			internal static bool VAVbtV5vJYESVsd7OHJ1()
			{
				return false;
			}

			// Token: 0x040053A9 RID: 21417
			internal Vector3 $myPosition$32480;

			// Token: 0x040053AA RID: 21418
			internal Vector3 $myDirection$32481;

			// Token: 0x040053AB RID: 21419
			internal UnityScript.Lang.Array $nArray$32482;

			// Token: 0x040053AC RID: 21420
			internal Koala $self_$32483;
		}
	}
}
