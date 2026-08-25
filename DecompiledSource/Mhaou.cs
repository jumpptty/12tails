using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E3E RID: 3646
[Serializable]
public class Mhaou : MonoBehaviour
{
	// Token: 0x0600527E RID: 21118 RVA: 0x00A11BAC File Offset: 0x00A0FDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mhaou()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x00A11BBC File Offset: 0x00A0FDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (118563 - 468182 != -349618)
		{
		}
		for (;;)
		{
			this.RR1cI51q6nP = this.transform;
			if (246411 - 493136 == -246725)
			{
				this.uRIcIcVUSsK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (176622 - 259523 != -82900)
				{
					this.uRIcIcVUSsK.actionState = "standby";
					if (196765 - 331907 == -135142)
					{
						this.uRIcIcVUSsK.actionTime = Time.time;
						if (216064 - 220931 != -4866)
						{
							this.uRIcIcVUSsK.myCommand = "none";
							if (280929 - 202068 != 78862)
							{
								this.uRIcIcVUSsK.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"sticky",
									"swallow",
									"paralysis",
									"needlePrison",
									"invisible",
									"petrify",
									"snowMan",
									"snowBall",
									"charm",
									"mindControl",
									"coma"
								});
								if (140425 - 169279 != -28853)
								{
									if (Game.mGameType != 99)
									{
										break;
									}
									if (28383 - 478708 == -450325)
									{
										this.uRIcIcVUSsK.isMine = true;
										if (73403 - 534623 != -461219)
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

	// Token: 0x06005280 RID: 21120 RVA: 0x00A11DA4 File Offset: 0x00A0FFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297388 - 185724 != 111665)
		{
		}
		for (;;)
		{
			if (this.uRIcIcVUSsK.isControlled)
			{
				if (216145 - 261852 == -45706)
				{
					continue;
				}
				if (!(this.uRIcIcVUSsK.actionState == "standby"))
				{
					if (117311 - 189898 != -72587)
					{
						continue;
					}
					if (!(this.uRIcIcVUSsK.actionState == "run"))
					{
						goto IL_CD;
					}
					if (37117 - 383183 != -346066)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (150767 - 592435 != -441668)
				{
					continue;
				}
			}
			IL_CD:
			if (this.uRIcIcVUSsK.hp <= 0)
			{
				if (287001 - 169430 != 117571)
				{
					continue;
				}
				if (this.uRIcIcVUSsK.actionState != "dead")
				{
					if (55263 - 360124 != -304861)
					{
						continue;
					}
					if (this.uRIcIcVUSsK.isMine)
					{
						if (148987 - 50340 != 98647)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (268349 - 329491 != -61142)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (110918 - 197666 == -86747)
						{
							continue;
						}
						this.uRIcIcVUSsK.DeadEvent();
						if (190613 - 471449 != -280835)
						{
							break;
						}
						continue;
					}
					else
					{
						this.uRIcIcVUSsK.hp = 1;
						if (112263 - 443668 != -331404)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.uRIcIcVUSsK.hp <= 0)
			{
				break;
			}
			if (229003 - 595481 != -366477)
			{
				if (this.uRIcIcVUSsK.ko > 0)
				{
					break;
				}
				if (186881 - 20167 != 166715)
				{
					if (!(this.uRIcIcVUSsK.actionState != "ko"))
					{
						break;
					}
					if (68974 - 231672 != -162697)
					{
						if (!(this.uRIcIcVUSsK.actionState != "dead"))
						{
							break;
						}
						if (132020 - 354035 == -222015)
						{
							if (this.uRIcIcVUSsK.isMine)
							{
								if (46925 - 64295 != -17369)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (159399 - 585768 == -426369)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (224728 - 67764 == 156964)
										{
											this.uRIcIcVUSsK.KoEvent();
											if (190484 - 133605 == 56879)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.uRIcIcVUSsK.ko = 1;
								if (296321 - 3239 != 293083)
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

	// Token: 0x06005281 RID: 21121 RVA: 0x00A1219C File Offset: 0x00A1039C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (42763 - 571993 != -529230)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (207508 - 288403 != -80894)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (141930 - 223089 == -81159)
				{
					if (292680 - 245788 != 46893)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (68611 - 462418 == -393806)
							{
								continue;
							}
							v = 1;
							if (228683 - 363433 == -134749)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (2247 - 540806 == -538558)
							{
								continue;
							}
							v = 11;
							if (218372 - 556252 != -337880)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_groundStomp")
						{
							if (147496 - 16532 != 130964)
							{
								continue;
							}
							v = 21;
							if (282183 - 234839 == 47345)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (222522 - 42320 == 180203)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (62329 - 367415 == -305086)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (142905 - 478846 == -335941)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (103040 - 448673 != -345632)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (148685 - 159711 != -11025)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (188684 - 510293 == -321609)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (8991 - 414489 == -405498)
											{
												Hashtable hashtable = new Hashtable();
												if (46528 - 153447 == -106919)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (232444 - 155730 != 76715)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (159634 - 365848 == -206214)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (208057 - 591393 != -383335)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (232996 - 77982 == 155014)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (43175 - 276207 != -233031)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (155503 - 73085 != 82419)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (244794 - 462784 == -217990)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (66559 - 471973 == -405414)
																				{
																					PhotonClient.SendEvent(this.uRIcIcVUSsK.ActorNr, 74, hashtable, true, true);
																					if (65945 - 225636 == -159691)
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

	// Token: 0x06005282 RID: 21122 RVA: 0x00A12668 File Offset: 0x00A10868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (131599 - 293264 != -161664)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (180165 - 327815 != -147649)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (102770 - 76532 == 26238)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (31002 - 524514 != -493511)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (143413 - 463790 == -320377)
						{
							int num2 = num;
							if (195430 - 500720 != -305289)
							{
								if (num2 == 1)
								{
									if (35648 - 365636 != -329987)
									{
										if (this.uRIcIcVUSsK.isMine)
										{
											break;
										}
										if (282460 - 423518 != -141057)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (193525 - 39434 != 154092)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (66012 - 448180 != -382167)
									{
										if (this.uRIcIcVUSsK.isMine)
										{
											break;
										}
										if (151618 - 69352 != 82267)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(mPos, tDir, tID));
											if (240437 - 151856 != 88582)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (177275 - 134790 == 42485)
									{
										if (this.uRIcIcVUSsK.isMine)
										{
											break;
										}
										if (99020 - 564249 != -465228)
										{
											this.StartCoroutine_Auto(this.RPC_groundStomp(mPos, tDir, tID));
											if (222036 - 44191 == 177845)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (148572 - 15397 != 133176)
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

	// Token: 0x06005283 RID: 21123 RVA: 0x00A12980 File Offset: 0x00A10B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (114587 - 453934 != -339346)
		{
		}
		for (;;)
		{
			float num = this.uRIcIcVUSsK.moveSpeed;
			if (278861 - 420865 == -142004)
			{
				float runSpeed = this.uRIcIcVUSsK.runSpeed;
				if (78165 - 65823 != 12343)
				{
					Vector3 a = default(Vector3);
					if (255422 - 17867 != 237556)
					{
						Vector3 vector = Vector3.zero;
						if (244318 - 389184 == -144866)
						{
							float num2 = (float)0;
							if (33482 - 111338 != -77855)
							{
								if (this.uRIcIcVUSsK.isMine)
								{
									if (201476 - 85329 != 116147)
									{
										continue;
									}
									if ((this.uRIcIcVUSsK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (257428 - 65297 == 192132)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (180775 - 75312 == 105464)
										{
											continue;
										}
										a.y = (float)0;
										if (150453 - 28521 != 121932)
										{
											continue;
										}
										a = a.normalized;
										if (49839 - 418086 == -368246)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (240554 - 514043 != -273489)
										{
											continue;
										}
										vector = vector.normalized;
										if (240812 - 109926 == 130887)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (52456 - 40904 == 11553)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (5392 - 120689 == -115296)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (146820 - 396814 != -249994)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (217897 - 333557 == -115659)
														{
															continue;
														}
														this.uRIcIcVUSsK.actionState = "run";
														if (219744 - 303412 == -83667)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (101170 - 569335 != -468165)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (123191 - 357188 != -233997)
														{
															continue;
														}
														this.animation.Play("run");
														if (196591 - 119609 == 76983)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (290364 - 220956 != 69408)
														{
															continue;
														}
														goto IL_7AE;
													}
												}
											}
										}
										this.uRIcIcVUSsK.actionState = "standby";
										if (73595 - 564413 == -490817)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (29577 - 187132 != -157555)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (137722 - 311416 == -173693)
											{
												continue;
											}
											num = (float)0;
											if (179268 - 454797 == -275528)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (189648 - 577955 != -388307)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (82482 - 178604 == -96121)
										{
											continue;
										}
									}
									IL_7AE:;
								}
								else
								{
									vector = global::Math.vFlat(this.uRIcIcVUSsK.nPosition - this.transform.position);
									if (226019 - 346801 == -120781)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (106732 - 260481 == -153748)
									{
										continue;
									}
									if (this.uRIcIcVUSsK.nSpeed != (float)0)
									{
										if (208528 - 176792 == 31737)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (114732 - 221718 == -106985)
											{
												continue;
											}
											this.transform.position = this.uRIcIcVUSsK.nPosition;
											if (216607 - 537824 == -321216)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (254940 - 499144 == -244203)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (120835 - 511264 != -390429)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (276051 - 250111 != 25940)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.uRIcIcVUSsK.nSpeed, (float)10 * Time.deltaTime);
												if (255227 - 414392 != -159165)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (140886 - 585476 == -444589)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (253320 - 244645 == 8676)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (22842 - 367254 != -344412)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (246329 - 113989 != 132340)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (34466 - 192928 == -158461)
											{
												continue;
											}
										}
										else if (Time.time > this.uRIcIcVUSsK.nSpeed + 0.3f)
										{
											if (178486 - 482997 == -304510)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (172034 - 295041 == -123006)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (174399 - 248464 == -74064)
												{
													continue;
												}
												num = (float)0;
												if (136575 - 264516 == -127940)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.uRIcIcVUSsK.nDirection);
											if (162459 - 385874 == -223414)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (41294 - 392287 == -350992)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (16466 - 475681 == -459214)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (100365 - 119554 == -19188)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (142985 - 11212 == 131774)
											{
												continue;
											}
											this.transform.position = this.uRIcIcVUSsK.nPosition;
											if (232111 - 379107 == -146995)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (199785 - 540329 != -340544)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (65525 - 156612 == -91086)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (196661 - 456789 != -260128)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (17056 - 80404 == -63347)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (42606 - 213640 != -171034)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (151895 - 284397 == -132501)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (88199 - 140604 == -52404)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.uRIcIcVUSsK.nDirection);
											if (240418 - 369590 != -129172)
											{
												continue;
											}
											num = (float)0;
											if (132874 - 599527 == -466652)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (140632 - 74407 != 66225)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69533 - 185511 != -115978)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (39974 - 427367 != -387393)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (266649 - 87323 != 179326)
										{
											continue;
										}
									}
								}
								this.uRIcIcVUSsK.vMovement = vector;
								if (172976 - 87967 != 85010)
								{
									this.uRIcIcVUSsK.moveSpeed = num;
									if (201810 - 537908 != -336097)
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

	// Token: 0x06005284 RID: 21124 RVA: 0x00A134E4 File Offset: 0x00A116E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (13100 - 67505 != -54405)
		{
		}
		for (;;)
		{
			if (!this.uRIcIcVUSsK.isMine)
			{
				if (172359 - 580261 != -407901)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (167128 - 447445 == -280317)
				{
					Vector3 tDir = a - this.transform.position;
					if (29210 - 282003 == -252793)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (9671 - 285052 == -275381)
						{
							CharacterControl characterControl = null;
							if (215300 - 433488 == -218188)
							{
								if (210423 - 479527 != -269103)
								{
									if (gameObject)
									{
										if (55847 - 527867 != -472020)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (48450 - 133886 != -85436)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (88226 - 379822 == -291595)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (120457 - 241030 == -120572)
										{
											continue;
										}
									}
									if (!(this.uRIcIcVUSsK.actionState == "standby"))
									{
										if (296333 - 472118 != -175785)
										{
											continue;
										}
										if (!(this.uRIcIcVUSsK.actionState == "run"))
										{
											break;
										}
										if (14826 - 22152 == -7325)
										{
											continue;
										}
									}
									if (this.uRIcIcVUSsK.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (54965 - 47127 == 7838)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
										if (181997 - 335988 == -153991)
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

	// Token: 0x06005285 RID: 21125 RVA: 0x00A1378C File Offset: 0x00A1198C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (97323 - 193768 != -96445)
		{
		}
		for (;;)
		{
			if (!this.uRIcIcVUSsK.isMine)
			{
				if (153229 - 425104 == -271875)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (153458 - 28161 == 125297)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (211680 - 405383 == -193703)
					{
						Vector3 normalized = vector.normalized;
						if (63869 - 340785 == -276916)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (187124 - 400643 == -213519)
							{
								CharacterControl characterControl = null;
								if (271715 - 53075 != 218641)
								{
									int tID = 0;
									if (117020 - 257164 != -140143)
									{
										if (gameObject)
										{
											if (40672 - 367818 == -327145)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (230578 - 184848 == 45731)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (21419 - 458400 != -436981)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (283275 - 511787 == -228511)
											{
												continue;
											}
										}
										if (!(this.uRIcIcVUSsK.actionState == "standby"))
										{
											if (257437 - 598087 != -340650)
											{
												continue;
											}
											if (!(this.uRIcIcVUSsK.actionState == "run"))
											{
												break;
											}
											if (124341 - 452092 != -327751)
											{
												continue;
											}
										}
										if (this.uRIcIcVUSsK.isTimeOut("cAttack") == (float)0)
										{
											if (297223 - 150557 != 146667)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, a - this.transform.position, tID));
												if (107679 - 405294 == -297615)
												{
													break;
												}
											}
										}
										else
										{
											if (this.uRIcIcVUSsK.isTimeOut("groundStomp") != (float)0)
											{
												break;
											}
											if (103033 - 63007 != 40027)
											{
												this.StartCoroutine_Auto(this.RPC_groundStomp(this.transform.position, normalized, tID));
												if (287468 - 591734 == -304266)
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

	// Token: 0x06005286 RID: 21126 RVA: 0x00A13AD8 File Offset: 0x00A11CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x00A13ADC File Offset: 0x00A11CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Mhaou.$RPC_nAttack$34066(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x00A13AEC File Offset: 0x00A11CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Mhaou.$RPC_cAttack$34079(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005289 RID: 21129 RVA: 0x00A13AFC File Offset: 0x00A11CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_groundStomp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Mhaou.$RPC_groundStomp$34090(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x00A13B0C File Offset: 0x00A11D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Mhaou.$RPC_ko$34101(nArray, this).GetEnumerator();
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x00A13B1C File Offset: 0x00A11D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Mhaou.$RPC_dead$34108(nArray, this).GetEnumerator();
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x00A13B2C File Offset: 0x00A11D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x00A13B30 File Offset: 0x00A11D30
	internal static bool xbK4175jiGaivqTNEg5A()
	{
		return true;
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x00A13B34 File Offset: 0x00A11D34
	internal static bool eXBk0U5jK9xplaBZOKJY()
	{
		return false;
	}

	// Token: 0x04005BED RID: 23533
	private Transform RR1cI51q6nP;

	// Token: 0x04005BEE RID: 23534
	private CharacterControl uRIcIcVUSsK;

	// Token: 0x04005BEF RID: 23535
	public GameObject nAttack_hit;

	// Token: 0x04005BF0 RID: 23536
	public AudioClip nAttack_slash;

	// Token: 0x04005BF1 RID: 23537
	public AudioClip nAttack_vc;

	// Token: 0x04005BF2 RID: 23538
	public GameObject cAttack_ring;

	// Token: 0x04005BF3 RID: 23539
	public GameObject groundStomp_ring;

	// Token: 0x02000E3F RID: 3647
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34066 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600528F RID: 21135 RVA: 0x00A13B38 File Offset: 0x00A11D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34066(Vector3 mPos, Vector3 tDir, Mhaou self_)
		{
			if (199084 - 575690 != -376605)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72918 - 306729 == -233811)
				{
					base..ctor();
					if (292886 - 31028 != 261859)
					{
						this.$mPos$34076 = mPos;
						if (227362 - 200734 != 26629)
						{
							this.$tDir$34077 = tDir;
							if (102696 - 324680 == -221984)
							{
								this.$self_$34078 = self_;
								if (94696 - 50238 == 44458)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00A13C14 File Offset: 0x00A11E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mhaou.$RPC_nAttack$34066.$(this.$mPos$34076, this.$tDir$34077, this.$self_$34078);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00A13C30 File Offset: 0x00A11E30
		internal static bool fRCUtJ5jdk0OegRYdyLF()
		{
			return true;
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00A13C34 File Offset: 0x00A11E34
		internal static bool dDDj7f5jJWQu7nEmAPWG()
		{
			return false;
		}

		// Token: 0x04005BF4 RID: 23540
		internal Vector3 $mPos$34076;

		// Token: 0x04005BF5 RID: 23541
		internal Vector3 $tDir$34077;

		// Token: 0x04005BF6 RID: 23542
		internal Mhaou $self_$34078;

		// Token: 0x02000E40 RID: 3648
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005293 RID: 21139 RVA: 0x00A13C38 File Offset: 0x00A11E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Mhaou self_)
			{
				if (203629 - 531660 != -328030)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263059 - 190268 != 72792)
					{
						base..ctor();
						if (122199 - 210491 != -88291)
						{
							this.$mPos$34073 = mPos;
							if (139457 - 95030 != 44428)
							{
								this.$tDir$34074 = tDir;
								if (112995 - 39654 != 73342)
								{
									this.$self_$34075 = self_;
									if (186975 - 369180 != -182204)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005294 RID: 21140 RVA: 0x00A13D14 File Offset: 0x00A11F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111793 - 102603 != 9191)
				{
				}
				for (;;)
				{
					IL_5E3:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CF6;
					case 2:
						if (this.$self_$34075.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_4E0;
						}
						if (21581 - 64416 != -42835)
						{
							continue;
						}
						if (this.$self_$34075.uRIcIcVUSsK.myCommand != "nAttack")
						{
							if (150590 - 464519 != -313928)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34075.nAttack_slash)
							{
								goto IL_349;
							}
							if (146706 - 575962 == -429255)
							{
								continue;
							}
							this.$self_$34075.audio.PlayOneShot(this.$self_$34075.nAttack_slash);
							if (105641 - 384651 != -279010)
							{
								continue;
							}
							goto IL_349;
						}
						break;
					case 3:
						if (this.$self_$34075.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_DD;
						}
						if (138382 - 5107 != 133275)
						{
							continue;
						}
						if (this.$self_$34075.uRIcIcVUSsK.myCommand != "nAttack")
						{
							if (62137 - 569333 != -507195)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (this.$self_$34075.nAttack_hit)
							{
								if (177944 - 344955 != -167011)
								{
									continue;
								}
								this.$self_$34075.uRIcIcVUSsK.createEffect(this.$self_$34075.nAttack_hit, this.$self_$34075.transform.position + (float)8 * this.$self_$34075.transform.forward, this.$self_$34075.transform.rotation);
								if (20633 - 156066 == -135432)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find nAttack ring Effect");
								if (150442 - 176949 != -26507)
								{
									continue;
								}
							}
							this.$hitLayer$34067 = 130816 - (1 << this.$self_$34075.gameObject.layer);
							if (134313 - 578433 != -444120)
							{
								continue;
							}
							this.$hitList$34068 = null;
							if (126772 - 580546 == -453773)
							{
								continue;
							}
							if (!this.$self_$34075.uRIcIcVUSsK.isMine)
							{
								goto IL_53E;
							}
							if (193974 - 391521 == -197546)
							{
								continue;
							}
							this.$hitList$34068 = Damage.FindAreaTarget(this.$self_$34075.transform.position + (float)8 * this.$self_$34075.transform.forward, (float)12, (float)4, this.$hitLayer$34067);
							if (119640 - 566374 != -446734)
							{
								continue;
							}
							this.$$iterator$10877$34070 = UnityRuntimeServices.GetEnumerator(this.$hitList$34068);
							if (166743 - 205437 == -38693)
							{
								continue;
							}
							while (this.$$iterator$10877$34070.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10877$34070.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34069 = (GameObject)obj2;
								if (289748 - 125123 != 164625)
								{
									goto IL_5E3;
								}
								this.$self_$34075.uRIcIcVUSsK.hit(1, this.$hitObject$34069, (int)(0.5f * (float)this.$self_$34075.uRIcIcVUSsK.atk), 2, 0, Vector3.zero);
								if (91204 - 435359 == -344154)
								{
									goto IL_5E3;
								}
								UnityRuntimeServices.Update(this.$$iterator$10877$34070, this.$hitObject$34069);
								if (10118 - 535624 != -525506)
								{
									goto IL_5E3;
								}
							}
							if (56007 - 123247 != -67239)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34075.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_4AC;
						}
						if (153259 - 574175 != -420916)
						{
							continue;
						}
						if (this.$self_$34075.uRIcIcVUSsK.myCommand != "nAttack")
						{
							if (74981 - 590698 != -515716)
							{
								goto Block_73;
							}
							continue;
						}
						else
						{
							this.$self_$34075.animation.CrossFade("nAttack2");
							if (4353 - 519371 != -515018)
							{
								continue;
							}
							this.$self_$34075.animation.wrapMode = WrapMode.Once;
							if (235508 - 293093 == -57584)
							{
								continue;
							}
							if (this.$self_$34075.nAttack_slash)
							{
								if (153789 - 577383 == -423593)
								{
									continue;
								}
								this.$self_$34075.audio.PlayOneShot(this.$self_$34075.nAttack_slash);
								if (70433 - 227405 != -156972)
								{
									continue;
								}
							}
							this.$self_$34075.uRIcIcVUSsK.vMovement = this.$self_$34075.transform.forward;
							if (164047 - 229782 == -65734)
							{
								continue;
							}
							this.$self_$34075.uRIcIcVUSsK.moveSpeed = (float)0;
							if (25104 - 286337 != -261232)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34075.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_CC2;
						}
						if (214399 - 458900 == -244500)
						{
							continue;
						}
						if (this.$self_$34075.uRIcIcVUSsK.myCommand != "nAttack")
						{
							if (86394 - 216458 != -130064)
							{
								continue;
							}
							goto IL_CC2;
						}
						else
						{
							if (!this.$self_$34075.uRIcIcVUSsK.isMine)
							{
								goto IL_714;
							}
							if (139524 - 581206 != -441682)
							{
								continue;
							}
							this.$hitList$34068 = Damage.FindAreaTarget(this.$self_$34075.transform.position + (float)8 * this.$self_$34075.transform.forward, (float)12, (float)4, this.$hitLayer$34067);
							if (159316 - 332268 == -172951)
							{
								continue;
							}
							this.$$iterator$10878$34072 = UnityRuntimeServices.GetEnumerator(this.$hitList$34068);
							if (65378 - 94165 != -28787)
							{
								continue;
							}
							while (this.$$iterator$10878$34072.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10878$34072.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34071 = (GameObject)obj4;
								if (246336 - 423245 != -176909)
								{
									goto IL_5E3;
								}
								this.$self_$34075.uRIcIcVUSsK.hit(1, this.$hitObject$34071, (int)(0.66f * (float)this.$self_$34075.uRIcIcVUSsK.atk), 2, 0, Vector3.zero);
								if (279730 - 363608 != -83878)
								{
									goto IL_5E3;
								}
								UnityRuntimeServices.Update(this.$$iterator$10878$34072, this.$hitObject$34071);
								if (77496 - 31042 != 46454)
								{
									goto IL_5E3;
								}
							}
							if (251937 - 373409 != -121472)
							{
								continue;
							}
							goto IL_714;
						}
						break;
					case 6:
						if (this.$self_$34075.uRIcIcVUSsK.actionState == "attack")
						{
							if (88291 - 284994 == -196702)
							{
								continue;
							}
							if (this.$self_$34075.uRIcIcVUSsK.myCommand == "nAttack")
							{
								if (256027 - 98881 == 157147)
								{
									continue;
								}
								this.$self_$34075.uRIcIcVUSsK.actionState = "standby";
								if (249537 - 520750 != -271213)
								{
									continue;
								}
								this.$self_$34075.uRIcIcVUSsK.actionTime = Time.time;
								if (73917 - 244797 == -170879)
								{
									continue;
								}
								this.$self_$34075.uRIcIcVUSsK.myCommand = "none";
								if (135148 - 489972 != -354824)
								{
									continue;
								}
								if (!this.$self_$34075.uRIcIcVUSsK.isMine)
								{
									if (220081 - 198647 == 21435)
									{
										continue;
									}
									this.$self_$34075.uRIcIcVUSsK.nPosition = this.$self_$34075.transform.position;
									if (214124 - 229586 != -15462)
									{
										continue;
									}
									this.$self_$34075.uRIcIcVUSsK.oPosition = this.$self_$34075.transform.position;
									if (102105 - 79507 == 22599)
									{
										continue;
									}
									this.$self_$34075.uRIcIcVUSsK.nDirection = this.$self_$34075.transform.forward;
									if (195117 - 587318 != -392201)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (124151 - 483015 != -358864)
						{
							continue;
						}
						goto IL_CF6;
					default:
						if (86810 - 134586 != -47776)
						{
							continue;
						}
						break;
					}
					this.$self_$34075.uRIcIcVUSsK.actionState = "attack";
					if (129599 - 312883 != -183283)
					{
						this.$self_$34075.uRIcIcVUSsK.actionTime = Time.time;
						if (17126 - 519697 == -502571)
						{
							this.$self_$34075.uRIcIcVUSsK.myCommand = "nAttack";
							if (60939 - 489198 == -428259)
							{
								this.$self_$34075.uRIcIcVUSsK.addTimeOut("nAttack", (float)3);
								if (217956 - 333208 == -115252)
								{
									this.$self_$34075.transform.position = this.$mPos$34073;
									if (141 - 193820 == -193679)
									{
										this.$self_$34075.transform.LookAt(this.$mPos$34073 + global::Math.vFlat(this.$tDir$34074));
										if (205532 - 209984 == -4452)
										{
											this.$self_$34075.animation.CrossFade("nAttack1");
											if (180841 - 111734 == 69107)
											{
												this.$self_$34075.animation.wrapMode = WrapMode.Once;
												if (24343 - 13579 == 10764)
												{
													this.$self_$34075.uRIcIcVUSsK.vMovement = this.$self_$34075.transform.forward;
													if (81166 - 298218 != -217051)
													{
														this.$self_$34075.uRIcIcVUSsK.moveSpeed = (float)0;
														if (261845 - 309277 != -47431)
														{
															if (!this.$self_$34075.nAttack_vc)
															{
																goto IL_A59;
															}
															if (83364 - 40976 != 42389)
															{
																this.$self_$34075.audio.PlayOneShot(this.$self_$34075.nAttack_vc);
																if (67850 - 240854 != -173003)
																{
																	goto Block_42;
																}
															}
														}
													}
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
				goto IL_CF6;
				Block_12:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_349:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_28:
				IL_4AC:
				IL_4E0:
				goto IL_CF6;
				IL_53E:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_38:
				goto IL_53E;
				Block_42:
				goto IL_A59;
				IL_714:
				return this.Yield(6, new WaitForSeconds(0.3f));
				Block_49:
				goto IL_DD;
				IL_A59:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_73:
				IL_CC2:
				IL_CF6:
				return false;
			}

			// Token: 0x06005295 RID: 21141 RVA: 0x00A14A2C File Offset: 0x00A12C2C
			internal static bool aWwv5c5jD1byVVt1sqrA()
			{
				return true;
			}

			// Token: 0x06005296 RID: 21142 RVA: 0x00A14A30 File Offset: 0x00A12C30
			internal static bool TuGAKA5jv3FqyeUQFX67()
			{
				return false;
			}

			// Token: 0x04005BF7 RID: 23543
			internal int $hitLayer$34067;

			// Token: 0x04005BF8 RID: 23544
			internal UnityScript.Lang.Array $hitList$34068;

			// Token: 0x04005BF9 RID: 23545
			internal GameObject $hitObject$34069;

			// Token: 0x04005BFA RID: 23546
			internal IEnumerator $$iterator$10877$34070;

			// Token: 0x04005BFB RID: 23547
			internal GameObject $hitObject$34071;

			// Token: 0x04005BFC RID: 23548
			internal IEnumerator $$iterator$10878$34072;

			// Token: 0x04005BFD RID: 23549
			internal Vector3 $mPos$34073;

			// Token: 0x04005BFE RID: 23550
			internal Vector3 $tDir$34074;

			// Token: 0x04005BFF RID: 23551
			internal Mhaou $self_$34075;
		}
	}

	// Token: 0x02000E41 RID: 3649
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$34079 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005297 RID: 21143 RVA: 0x00A14A34 File Offset: 0x00A12C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$34079(Vector3 mPos, Vector3 tDir, Mhaou self_)
		{
			if (82823 - 119826 != -37002)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242673 - 558887 == -316214)
				{
					base..ctor();
					if (249871 - 444751 == -194880)
					{
						this.$mPos$34087 = mPos;
						if (25224 - 26151 == -927)
						{
							this.$tDir$34088 = tDir;
							if (255246 - 597037 == -341791)
							{
								this.$self_$34089 = self_;
								if (10791 - 405958 == -395167)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00A14B10 File Offset: 0x00A12D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mhaou.$RPC_cAttack$34079.$(this.$mPos$34087, this.$tDir$34088, this.$self_$34089);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00A14B2C File Offset: 0x00A12D2C
		internal static bool T5wPdl5jRlFWAYfJnL9y()
		{
			return true;
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00A14B30 File Offset: 0x00A12D30
		internal static bool yy3Ed85jwFaVJb44lRAq()
		{
			return false;
		}

		// Token: 0x04005C00 RID: 23552
		internal Vector3 $mPos$34087;

		// Token: 0x04005C01 RID: 23553
		internal Vector3 $tDir$34088;

		// Token: 0x04005C02 RID: 23554
		internal Mhaou $self_$34089;

		// Token: 0x02000E42 RID: 3650
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600529B RID: 21147 RVA: 0x00A14B34 File Offset: 0x00A12D34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Mhaou self_)
			{
				if (229889 - 262549 != -32660)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250284 - 266221 == -15937)
					{
						base..ctor();
						if (102821 - 57389 != 45433)
						{
							this.$mPos$34084 = mPos;
							if (114109 - 507398 == -393289)
							{
								this.$tDir$34085 = tDir;
								if (207851 - 107350 != 100502)
								{
									this.$self_$34086 = self_;
									if (77390 - 69509 != 7882)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600529C RID: 21148 RVA: 0x00A14C10 File Offset: 0x00A12E10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185913 - 410938 != -225024)
				{
				}
				for (;;)
				{
					IL_38E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7EA;
					case 2:
						if (this.$self_$34086.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_214;
						}
						if (117002 - 400877 != -283875)
						{
							continue;
						}
						if (this.$self_$34086.uRIcIcVUSsK.myCommand != "cAttack")
						{
							if (181817 - 160861 != 20957)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (this.$self_$34086.cAttack_ring)
							{
								if (167093 - 78191 != 88902)
								{
									continue;
								}
								this.$self_$34086.uRIcIcVUSsK.createEffect(this.$self_$34086.cAttack_ring, this.$mPos$34084 + (float)4 * this.$tDir$34085.normalized, this.$self_$34086.transform.rotation);
								if (125291 - 198217 == -72925)
								{
									continue;
								}
								this.$self_$34086.uRIcIcVUSsK.createEffect(this.$self_$34086.cAttack_ring, this.$mPos$34084 + this.$tDir$34085, this.$self_$34086.transform.rotation);
								if (280873 - 502678 != -221805)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring");
								if (80122 - 466114 == -385991)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 2);
							if (170715 - 103489 != 67226)
							{
								continue;
							}
							if (!this.$self_$34086.uRIcIcVUSsK.isMine)
							{
								goto IL_4D6;
							}
							if (177934 - 253917 != -75983)
							{
								continue;
							}
							this.$hitLayer$34080 = 130816 - (1 << this.$self_$34086.gameObject.layer);
							if (56432 - 49000 == 7433)
							{
								continue;
							}
							this.$hitList$34081 = Damage.FindAreaTarget(this.$mPos$34084 + this.$tDir$34085, (float)15, (float)4, this.$hitLayer$34080);
							if (142026 - 279095 != -137069)
							{
								continue;
							}
							this.$$iterator$10879$34083 = UnityRuntimeServices.GetEnumerator(this.$hitList$34081);
							if (245020 - 134485 == 110536)
							{
								continue;
							}
							while (this.$$iterator$10879$34083.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10879$34083.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34082 = (GameObject)obj2;
								if (30265 - 236273 != -206008)
								{
									goto IL_38E;
								}
								this.$self_$34086.uRIcIcVUSsK.hit(11, this.$hitObject$34082, (int)(0.8f * (float)this.$self_$34086.uRIcIcVUSsK.atk), 50, 0, Vector3.zero);
								if (55034 - 400752 == -345717)
								{
									goto IL_38E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10879$34083, this.$hitObject$34082);
								if (76049 - 518506 != -442457)
								{
									goto IL_38E;
								}
							}
							if (196441 - 480147 != -283706)
							{
								continue;
							}
							goto IL_4D6;
						}
						break;
					case 3:
						if (this.$self_$34086.uRIcIcVUSsK.actionState == "attack")
						{
							if (284906 - 217462 != 67444)
							{
								continue;
							}
							if (this.$self_$34086.uRIcIcVUSsK.myCommand == "cAttack")
							{
								if (103689 - 222205 == -118515)
								{
									continue;
								}
								this.$self_$34086.uRIcIcVUSsK.actionState = "standby";
								if (103792 - 512504 == -408711)
								{
									continue;
								}
								this.$self_$34086.uRIcIcVUSsK.actionTime = Time.time;
								if (124737 - 443833 != -319096)
								{
									continue;
								}
								this.$self_$34086.uRIcIcVUSsK.myCommand = "none";
								if (246152 - 121016 == 125137)
								{
									continue;
								}
								if (!this.$self_$34086.uRIcIcVUSsK.isMine)
								{
									if (147842 - 475711 == -327868)
									{
										continue;
									}
									this.$self_$34086.uRIcIcVUSsK.nPosition = this.$self_$34086.transform.position;
									if (258846 - 542944 != -284098)
									{
										continue;
									}
									this.$self_$34086.uRIcIcVUSsK.oPosition = this.$self_$34086.transform.position;
									if (13874 - 510265 != -496391)
									{
										continue;
									}
									this.$self_$34086.uRIcIcVUSsK.nDirection = this.$self_$34086.transform.forward;
									if (37372 - 382602 == -345229)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (139388 - 171968 != -32580)
						{
							continue;
						}
						goto IL_7EA;
					default:
						if (98975 - 526233 != -427258)
						{
							continue;
						}
						break;
					}
					this.$self_$34086.uRIcIcVUSsK.actionState = "attack";
					if (241160 - 125395 == 115765)
					{
						this.$self_$34086.uRIcIcVUSsK.actionTime = Time.time;
						if (137782 - 549656 == -411874)
						{
							this.$self_$34086.uRIcIcVUSsK.myCommand = "cAttack";
							if (208140 - 217458 == -9318)
							{
								this.$self_$34086.uRIcIcVUSsK.addTimeOut("cAttack", (float)13);
								if (61601 - 230810 == -169209)
								{
									this.$self_$34086.transform.position = this.$mPos$34084;
									if (34209 - 412401 != -378191)
									{
										this.$self_$34086.transform.LookAt(this.$mPos$34084 + global::Math.vFlat(this.$tDir$34085));
										if (180136 - 33069 != 147068)
										{
											this.$self_$34086.animation.CrossFade("cAttack");
											if (148764 - 214231 != -65466)
											{
												this.$self_$34086.animation.wrapMode = WrapMode.Once;
												if (211748 - 211938 == -190)
												{
													this.$self_$34086.uRIcIcVUSsK.vMovement = this.$self_$34086.transform.forward;
													if (182070 - 388612 != -206541)
													{
														this.$self_$34086.uRIcIcVUSsK.moveSpeed = (float)0;
														if (15639 - 283842 == -268203)
														{
															goto IL_5C4;
														}
													}
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
				IL_214:
				goto IL_7EA;
				IL_4D6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_5C4:
				return this.Yield(2, new WaitForSeconds(1.8f));
				IL_7EA:
				return false;
			}

			// Token: 0x0600529D RID: 21149 RVA: 0x00A1541C File Offset: 0x00A1361C
			internal static bool WpEPtk5jqPvyxGxv73ws()
			{
				return true;
			}

			// Token: 0x0600529E RID: 21150 RVA: 0x00A15420 File Offset: 0x00A13620
			internal static bool IWfR4Z5j7RCVVmH9vGqp()
			{
				return false;
			}

			// Token: 0x04005C03 RID: 23555
			internal int $hitLayer$34080;

			// Token: 0x04005C04 RID: 23556
			internal UnityScript.Lang.Array $hitList$34081;

			// Token: 0x04005C05 RID: 23557
			internal GameObject $hitObject$34082;

			// Token: 0x04005C06 RID: 23558
			internal IEnumerator $$iterator$10879$34083;

			// Token: 0x04005C07 RID: 23559
			internal Vector3 $mPos$34084;

			// Token: 0x04005C08 RID: 23560
			internal Vector3 $tDir$34085;

			// Token: 0x04005C09 RID: 23561
			internal Mhaou $self_$34086;
		}
	}

	// Token: 0x02000E43 RID: 3651
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_groundStomp$34090 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600529F RID: 21151 RVA: 0x00A15424 File Offset: 0x00A13624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_groundStomp$34090(Vector3 mPos, Vector3 tDir, Mhaou self_)
		{
			if (251212 - 383846 != -132634)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154151 - 384489 == -230338)
				{
					base..ctor();
					if (262273 - 24478 != 237796)
					{
						this.$mPos$34098 = mPos;
						if (179413 - 123772 == 55641)
						{
							this.$tDir$34099 = tDir;
							if (79440 - 38586 == 40854)
							{
								this.$self_$34100 = self_;
								if (257881 - 488437 != -230555)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00A15500 File Offset: 0x00A13700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mhaou.$RPC_groundStomp$34090.$(this.$mPos$34098, this.$tDir$34099, this.$self_$34100);
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00A1551C File Offset: 0x00A1371C
		internal static bool TjKm2v5jP6b5rQ7nn2NY()
		{
			return true;
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00A15520 File Offset: 0x00A13720
		internal static bool HkXktb5j0JMkQmZROf8Q()
		{
			return false;
		}

		// Token: 0x04005C0A RID: 23562
		internal Vector3 $mPos$34098;

		// Token: 0x04005C0B RID: 23563
		internal Vector3 $tDir$34099;

		// Token: 0x04005C0C RID: 23564
		internal Mhaou $self_$34100;

		// Token: 0x02000E44 RID: 3652
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060052A3 RID: 21155 RVA: 0x00A15524 File Offset: 0x00A13724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Mhaou self_)
			{
				if (134156 - 103561 != 30596)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281087 - 175115 == 105972)
					{
						base..ctor();
						if (162453 - 316457 != -154003)
						{
							this.$mPos$34095 = mPos;
							if (299913 - 279827 != 20087)
							{
								this.$tDir$34096 = tDir;
								if (143329 - 553194 == -409865)
								{
									this.$self_$34097 = self_;
									if (181806 - 348395 == -166589)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060052A4 RID: 21156 RVA: 0x00A15600 File Offset: 0x00A13800
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20067 - 242108 != -222041)
				{
				}
				for (;;)
				{
					IL_3EA:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_77D;
					case 2:
						if (this.$self_$34097.uRIcIcVUSsK.actionState != "attack")
						{
							goto IL_66A;
						}
						if (290734 - 406119 == -115384)
						{
							continue;
						}
						if (this.$self_$34097.uRIcIcVUSsK.myCommand != "groundStomp")
						{
							if (240465 - 326018 != -85552)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (this.$self_$34097.groundStomp_ring)
							{
								if (119467 - 139438 == -19970)
								{
									continue;
								}
								this.$self_$34097.uRIcIcVUSsK.createEffect(this.$self_$34097.groundStomp_ring, this.$self_$34097.transform.position, this.$self_$34097.transform.rotation);
								if (194667 - 179868 == 14800)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing groundStomp_ring");
								if (147330 - 126202 != 21128)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 3);
							if (262685 - 211921 != 50764)
							{
								continue;
							}
							if (!this.$self_$34097.uRIcIcVUSsK.isMine)
							{
								goto IL_72E;
							}
							if (236254 - 257633 != -21379)
							{
								continue;
							}
							this.$hitLayer$34091 = 130816 - (1 << this.$self_$34097.gameObject.layer);
							if (153417 - 371747 == -218329)
							{
								continue;
							}
							this.$hitList$34092 = Damage.FindAreaTarget(this.$self_$34097.transform.position, (float)40, (float)4, this.$hitLayer$34091);
							if (105563 - 330999 != -225436)
							{
								continue;
							}
							this.$$iterator$10880$34094 = UnityRuntimeServices.GetEnumerator(this.$hitList$34092);
							if (6127 - 589980 != -583853)
							{
								continue;
							}
							while (this.$$iterator$10880$34094.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10880$34094.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34093 = (GameObject)obj2;
								if (139384 - 379650 != -240266)
								{
									goto IL_3EA;
								}
								this.$self_$34097.uRIcIcVUSsK.hit(21, this.$hitObject$34093, this.$self_$34097.uRIcIcVUSsK.atk, 50, 0, Vector3.zero);
								if (163084 - 287630 != -124546)
								{
									goto IL_3EA;
								}
								UnityRuntimeServices.Update(this.$$iterator$10880$34094, this.$hitObject$34093);
								if (85669 - 340130 == -254460)
								{
									goto IL_3EA;
								}
							}
							if (203830 - 112662 != 91169)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34097.uRIcIcVUSsK.actionState == "attack")
						{
							if (44949 - 577096 == -532146)
							{
								continue;
							}
							if (this.$self_$34097.uRIcIcVUSsK.myCommand == "groundStomp")
							{
								if (7972 - 587889 == -579916)
								{
									continue;
								}
								this.$self_$34097.uRIcIcVUSsK.actionState = "standby";
								if (270426 - 330344 != -59918)
								{
									continue;
								}
								this.$self_$34097.uRIcIcVUSsK.actionTime = Time.time;
								if (87972 - 414580 != -326608)
								{
									continue;
								}
								this.$self_$34097.uRIcIcVUSsK.myCommand = "none";
								if (286802 - 113767 != 173035)
								{
									continue;
								}
								if (!this.$self_$34097.uRIcIcVUSsK.isMine)
								{
									if (142042 - 251794 != -109752)
									{
										continue;
									}
									this.$self_$34097.uRIcIcVUSsK.nPosition = this.$self_$34097.transform.position;
									if (221446 - 248459 == -27012)
									{
										continue;
									}
									this.$self_$34097.uRIcIcVUSsK.oPosition = this.$self_$34097.transform.position;
									if (230848 - 461509 == -230660)
									{
										continue;
									}
									this.$self_$34097.uRIcIcVUSsK.nDirection = this.$self_$34097.transform.forward;
									if (152478 - 402659 != -250181)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (297422 - 347539 != -50116)
						{
							goto Block_10;
						}
						continue;
					default:
						if (290114 - 58572 == 231543)
						{
							continue;
						}
						break;
					}
					this.$self_$34097.uRIcIcVUSsK.actionState = "attack";
					if (98435 - 78043 != 20393)
					{
						this.$self_$34097.uRIcIcVUSsK.actionTime = Time.time;
						if (213338 - 58287 == 155051)
						{
							this.$self_$34097.uRIcIcVUSsK.myCommand = "groundStomp";
							if (254488 - 26582 != 227907)
							{
								this.$self_$34097.uRIcIcVUSsK.addTimeOut("groundStomp", (float)36);
								if (72166 - 401332 == -329166)
								{
									this.$self_$34097.transform.position = this.$mPos$34095;
									if (48860 - 442998 != -394137)
									{
										this.$self_$34097.transform.LookAt(this.$mPos$34095 + global::Math.vFlat(this.$tDir$34096));
										if (81744 - 531423 == -449679)
										{
											this.$self_$34097.animation.CrossFade("groundStomp");
											if (102465 - 60768 != 41698)
											{
												this.$self_$34097.animation.wrapMode = WrapMode.Once;
												if (283790 - 514414 != -230623)
												{
													this.$self_$34097.uRIcIcVUSsK.vMovement = this.$self_$34097.transform.forward;
													if (187118 - 123358 == 63760)
													{
														this.$self_$34097.uRIcIcVUSsK.moveSpeed = (float)0;
														if (166090 - 279951 != -113860)
														{
															goto Block_34;
														}
													}
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
				Block_10:
				goto IL_77D;
				Block_21:
				goto IL_72E;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_66A:
				goto IL_77D;
				IL_72E:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_77D:
				return false;
			}

			// Token: 0x060052A5 RID: 21157 RVA: 0x00A15D9C File Offset: 0x00A13F9C
			internal static bool frTr7e5jbq7hhgA7aAOF()
			{
				return true;
			}

			// Token: 0x060052A6 RID: 21158 RVA: 0x00A15DA0 File Offset: 0x00A13FA0
			internal static bool JBW1nA5juEuACsDcwDtg()
			{
				return false;
			}

			// Token: 0x04005C0D RID: 23565
			internal int $hitLayer$34091;

			// Token: 0x04005C0E RID: 23566
			internal UnityScript.Lang.Array $hitList$34092;

			// Token: 0x04005C0F RID: 23567
			internal GameObject $hitObject$34093;

			// Token: 0x04005C10 RID: 23568
			internal IEnumerator $$iterator$10880$34094;

			// Token: 0x04005C11 RID: 23569
			internal Vector3 $mPos$34095;

			// Token: 0x04005C12 RID: 23570
			internal Vector3 $tDir$34096;

			// Token: 0x04005C13 RID: 23571
			internal Mhaou $self_$34097;
		}
	}

	// Token: 0x02000E45 RID: 3653
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34101 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060052A7 RID: 21159 RVA: 0x00A15DA4 File Offset: 0x00A13FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34101(UnityScript.Lang.Array nArray, Mhaou self_)
		{
			if (79496 - 124871 != -45375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106568 - 394732 == -288164)
				{
					base..ctor();
					if (269665 - 143370 == 126295)
					{
						this.$nArray$34106 = nArray;
						if (234524 - 462609 == -228085)
						{
							this.$self_$34107 = self_;
							if (134936 - 448304 == -313368)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00A15E60 File Offset: 0x00A14060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mhaou.$RPC_ko$34101.$(this.$nArray$34106, this.$self_$34107);
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00A15E74 File Offset: 0x00A14074
		internal static bool DxwQ4u5jIS22GmRZBqQY()
		{
			return true;
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00A15E78 File Offset: 0x00A14078
		internal static bool YqDCOd5jB9gnAYBfubwr()
		{
			return false;
		}

		// Token: 0x04005C14 RID: 23572
		internal UnityScript.Lang.Array $nArray$34106;

		// Token: 0x04005C15 RID: 23573
		internal Mhaou $self_$34107;

		// Token: 0x02000E46 RID: 3654
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060052AB RID: 21163 RVA: 0x00A15E7C File Offset: 0x00A1407C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mhaou self_)
			{
				if (103228 - 528748 != -425520)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197117 - 163196 == 33921)
					{
						base..ctor();
						if (29048 - 53177 != -24128)
						{
							this.$nArray$34104 = nArray;
							if (187184 - 473889 != -286704)
							{
								this.$self_$34105 = self_;
								if (199734 - 557697 != -357962)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060052AC RID: 21164 RVA: 0x00A15F38 File Offset: 0x00A14138
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (54224 - 8455 != 45770)
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
						if (this.$self_$34105.uRIcIcVUSsK.actionState != "ko")
						{
							if (126851 - 37695 != 89156)
							{
								continue;
							}
							goto IL_3C0;
						}
						else
						{
							this.$self_$34105.animation.Play("getUp");
							if (88634 - 521817 != -433183)
							{
								continue;
							}
							this.$self_$34105.animation.wrapMode = WrapMode.Once;
							if (263256 - 433283 != -170026)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34105.uRIcIcVUSsK.actionState != "ko")
						{
							if (33107 - 500056 != -466948)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$34105.uRIcIcVUSsK.actionState = "standby";
							if (139622 - 246704 != -107082)
							{
								continue;
							}
							this.$self_$34105.uRIcIcVUSsK.actionTime = Time.time;
							if (276031 - 422896 == -146864)
							{
								continue;
							}
							this.$self_$34105.uRIcIcVUSsK.myCommand = "none";
							if (63465 - 308317 != -244852)
							{
								continue;
							}
							this.$self_$34105.uRIcIcVUSsK.ko = this.$self_$34105.uRIcIcVUSsK.mko;
							if (219273 - 482753 == -263479)
							{
								continue;
							}
							this.YieldDefault(1);
							if (215415 - 534433 != -319017)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (292063 - 594697 == -302633)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34105.uRIcIcVUSsK.actionState == "ko")
					{
						break;
					}
					if (123896 - 152818 != -28921)
					{
						if (this.$self_$34105.uRIcIcVUSsK.actionState == "dead")
						{
							if (207028 - 49183 != 157846)
							{
								break;
							}
						}
						else
						{
							this.$mPos$34102 = (Vector3)this.$nArray$34104[0];
							if (253535 - 131288 == 122247)
							{
								this.$mDir$34103 = (Vector3)this.$nArray$34104[1];
								if (273481 - 591832 == -318351)
								{
									this.$self_$34105.uRIcIcVUSsK.ko = 0;
									if (170974 - 302309 == -131335)
									{
										this.$self_$34105.uRIcIcVUSsK.actionState = "ko";
										if (152694 - 82652 != 70043)
										{
											this.$self_$34105.uRIcIcVUSsK.actionTime = Time.time;
											if (199657 - 182333 != 17325)
											{
												this.$self_$34105.uRIcIcVUSsK.myCommand = "none";
												if (130800 - 140129 != -9328)
												{
													this.$self_$34105.uRIcIcVUSsK.vMovement = Vector3.zero;
													if (277920 - 257286 != 20635)
													{
														this.$self_$34105.uRIcIcVUSsK.moveSpeed = (float)0;
														if (71132 - 348200 != -277067)
														{
															this.$self_$34105.animation.Play("ko");
															if (97983 - 579434 == -481451)
															{
																this.$self_$34105.animation.wrapMode = WrapMode.Once;
																if (129063 - 515167 == -386104)
																{
																	goto IL_292;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_48C;
				IL_292:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				goto IL_48C;
				Block_20:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3C0:
				IL_48C:
				return false;
			}

			// Token: 0x060052AD RID: 21165 RVA: 0x00A163E4 File Offset: 0x00A145E4
			internal static bool fPReeK5jeZ0O1HRRjZkN()
			{
				return true;
			}

			// Token: 0x060052AE RID: 21166 RVA: 0x00A163E8 File Offset: 0x00A145E8
			internal static bool NyYUZV5jrLTr0x708n9M()
			{
				return false;
			}

			// Token: 0x04005C16 RID: 23574
			internal Vector3 $mPos$34102;

			// Token: 0x04005C17 RID: 23575
			internal Vector3 $mDir$34103;

			// Token: 0x04005C18 RID: 23576
			internal UnityScript.Lang.Array $nArray$34104;

			// Token: 0x04005C19 RID: 23577
			internal Mhaou $self_$34105;
		}
	}

	// Token: 0x02000E47 RID: 3655
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34108 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060052AF RID: 21167 RVA: 0x00A163EC File Offset: 0x00A145EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34108(UnityScript.Lang.Array nArray, Mhaou self_)
		{
			if (297494 - 437487 != -139993)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137785 - 254893 != -117107)
				{
					base..ctor();
					if (220530 - 201889 == 18641)
					{
						this.$nArray$34113 = nArray;
						if (285800 - 118232 != 167569)
						{
							this.$self_$34114 = self_;
							if (128087 - 333112 != -205024)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00A164A8 File Offset: 0x00A146A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mhaou.$RPC_dead$34108.$(this.$nArray$34113, this.$self_$34114);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00A164BC File Offset: 0x00A146BC
		internal static bool YPlEWc5jjJLO6nYfEWfu()
		{
			return true;
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00A164C0 File Offset: 0x00A146C0
		internal static bool sQwlpB5jhbN0P6qePc8f()
		{
			return false;
		}

		// Token: 0x04005C1A RID: 23578
		internal UnityScript.Lang.Array $nArray$34113;

		// Token: 0x04005C1B RID: 23579
		internal Mhaou $self_$34114;

		// Token: 0x02000E48 RID: 3656
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060052B3 RID: 21171 RVA: 0x00A164C4 File Offset: 0x00A146C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mhaou self_)
			{
				if (49505 - 580237 != -530732)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173764 - 175543 == -1779)
					{
						base..ctor();
						if (198051 - 15124 != 182928)
						{
							this.$nArray$34111 = nArray;
							if (225342 - 227871 != -2528)
							{
								this.$self_$34112 = self_;
								if (56906 - 392569 == -335663)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060052B4 RID: 21172 RVA: 0x00A16580 File Offset: 0x00A14780
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248847 - 548018 != -299171)
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
						if (this.$self_$34112.uRIcIcVUSsK.actionState != "dead")
						{
							if (24742 - 217732 != -192990)
							{
								continue;
							}
							goto IL_1FD;
						}
						else
						{
							if (!this.$self_$34112.uRIcIcVUSsK.isPlayer)
							{
								if (291265 - 27384 == 263882)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34112.gameObject);
								if (31974 - 442018 == -410043)
								{
									continue;
								}
							}
							else if (this.$self_$34112.uRIcIcVUSsK.isMine)
							{
								if (24153 - 171874 != -147721)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34112.gameObject);
								if (41443 - 500035 == -458591)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (211379 - 290276 != -78896)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (252591 - 486244 != -233653)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34112.uRIcIcVUSsK.actionState == "dead")
					{
						if (259598 - 189478 == 70120)
						{
							goto IL_253;
						}
					}
					else
					{
						this.$myPosition$34109 = (Vector3)this.$nArray$34111[0];
						if (170050 - 293618 != -123567)
						{
							this.$myDirection$34110 = (Vector3)this.$nArray$34111[1];
							if (208751 - 594227 == -385476)
							{
								this.$self_$34112.transform.position = this.$myPosition$34109;
								if (14223 - 399623 == -385400)
								{
									this.$self_$34112.transform.LookAt(this.$myPosition$34109 + this.$myDirection$34110);
									if (39769 - 122459 != -82689)
									{
										this.$self_$34112.uRIcIcVUSsK.hp = 0;
										if (119743 - 134404 == -14661)
										{
											this.$self_$34112.uRIcIcVUSsK.actionState = "dead";
											if (279321 - 587785 == -308464)
											{
												this.$self_$34112.uRIcIcVUSsK.actionTime = Time.time;
												if (188778 - 356970 != -168191)
												{
													this.$self_$34112.uRIcIcVUSsK.myCommand = "none";
													if (132422 - 249087 != -116664)
													{
														this.$self_$34112.uRIcIcVUSsK.vMovement = Vector3.zero;
														if (73494 - 183580 == -110086)
														{
															this.$self_$34112.uRIcIcVUSsK.moveSpeed = (float)0;
															if (112037 - 510267 != -398229)
															{
																this.$self_$34112.animation.Rewind();
																if (91201 - 475488 != -384286)
																{
																	this.$self_$34112.animation.Play("ko");
																	if (269971 - 114039 == 155932)
																	{
																		this.$self_$34112.animation.wrapMode = WrapMode.Once;
																		if (51766 - 473691 == -421925)
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
				IL_1FD:
				Block_16:
				IL_253:
				IL_42F:
				return false;
			}

			// Token: 0x060052B5 RID: 21173 RVA: 0x00A169D0 File Offset: 0x00A14BD0
			internal static bool hZMPnu5jsBhJGgHH74GW()
			{
				return true;
			}

			// Token: 0x060052B6 RID: 21174 RVA: 0x00A169D4 File Offset: 0x00A14BD4
			internal static bool WrnBZG5j9h3YX8Ayy5Ms()
			{
				return false;
			}

			// Token: 0x04005C1C RID: 23580
			internal Vector3 $myPosition$34109;

			// Token: 0x04005C1D RID: 23581
			internal Vector3 $myDirection$34110;

			// Token: 0x04005C1E RID: 23582
			internal UnityScript.Lang.Array $nArray$34111;

			// Token: 0x04005C1F RID: 23583
			internal Mhaou $self_$34112;
		}
	}
}
