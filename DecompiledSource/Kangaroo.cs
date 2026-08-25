using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C9B RID: 3227
[Serializable]
public class Kangaroo : MonoBehaviour
{
	// Token: 0x06004858 RID: 18520 RVA: 0x008FD724 File Offset: 0x008FB924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Kangaroo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x008FD734 File Offset: 0x008FB934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (102888 - 79445 != 23443)
		{
		}
		for (;;)
		{
			this.yEXzR6MJc4 = this.transform;
			if (76952 - 272319 != -195366)
			{
				this.G0vzrKIyjS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (137973 - 242577 != -104603)
				{
					this.G0vzrKIyjS.actionState = "standby";
					if (185190 - 37325 == 147865)
					{
						this.G0vzrKIyjS.actionTime = Time.time;
						if (191301 - 1682 == 189619)
						{
							this.G0vzrKIyjS.myCommand = "none";
							if (161735 - 514993 != -353257)
							{
								if (Game.mGameType == 99)
								{
									if (286601 - 230919 == 55683)
									{
										continue;
									}
									this.G0vzrKIyjS.isMine = true;
									if (223970 - 458983 == -235012)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (265511 - 388959 == -123448)
								{
									if (!this.G0vzrKIyjS.isSummon)
									{
										break;
									}
									if (283025 - 368754 == -85729)
									{
										if (this.awake_vc)
										{
											if (168122 - 227770 == -59648)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (207742 - 322686 != -114943)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (19351 - 341579 == -322228)
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

	// Token: 0x0600485A RID: 18522 RVA: 0x008FD964 File Offset: 0x008FBB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (298950 - 569013 != -270062)
		{
		}
		for (;;)
		{
			if (this.G0vzrKIyjS.isControlled)
			{
				if (296357 - 505938 == -209580)
				{
					continue;
				}
				if (!(this.G0vzrKIyjS.actionState == "standby"))
				{
					if (37481 - 450846 == -413364)
					{
						continue;
					}
					if (!(this.G0vzrKIyjS.actionState == "run"))
					{
						goto IL_189;
					}
					if (254902 - 57657 != 197245)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (194245 - 221342 == -27096)
				{
					continue;
				}
			}
			IL_189:
			if (this.G0vzrKIyjS.hp <= 0)
			{
				if (260362 - 277553 != -17191)
				{
					continue;
				}
				if (this.G0vzrKIyjS.actionState != "dead")
				{
					if (1758 - 431146 != -429388)
					{
						continue;
					}
					if (this.G0vzrKIyjS.isMine)
					{
						if (222203 - 444838 != -222635)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (225250 - 349218 != -123968)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (262326 - 396178 == -133851)
						{
							continue;
						}
						this.G0vzrKIyjS.DeadEvent();
						if (74650 - 114530 != -39879)
						{
							break;
						}
						continue;
					}
					else
					{
						this.G0vzrKIyjS.hp = 1;
						if (153352 - 75613 != 77739)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.G0vzrKIyjS.hp <= 0)
			{
				break;
			}
			if (98880 - 125862 == -26982)
			{
				if (this.G0vzrKIyjS.ko > 0)
				{
					break;
				}
				if (269224 - 426567 != -157342)
				{
					if (!(this.G0vzrKIyjS.actionState != "ko"))
					{
						break;
					}
					if (104539 - 200853 != -96313)
					{
						if (!(this.G0vzrKIyjS.actionState != "dead"))
						{
							break;
						}
						if (72654 - 478769 == -406115)
						{
							if (this.G0vzrKIyjS.isMine)
							{
								if (260777 - 72634 != 188144)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (93813 - 421286 == -327473)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (167667 - 413010 != -245342)
										{
											this.G0vzrKIyjS.KoEvent();
											if (211407 - 392286 == -180879)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.G0vzrKIyjS.ko = 1;
								if (280088 - 257873 == 22215)
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

	// Token: 0x0600485B RID: 18523 RVA: 0x008FDD5C File Offset: 0x008FBF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (133257 - 33535 != 99722)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (103629 - 366060 != -262430)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (177468 - 449021 == -271553)
				{
					if (240875 - 524850 != -283974)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (76746 - 495890 != -419144)
							{
								continue;
							}
							v = 1;
							if (97157 - 599845 == -502687)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (48930 - 135718 != -86788)
							{
								continue;
							}
							v = -1;
							if (213296 - 355966 != -142670)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_scan")
						{
							if (93164 - 532037 != -438873)
							{
								continue;
							}
							v = 11;
							if (228740 - 331924 == -103183)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (257699 - 339495 == -81795)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (127013 - 332294 == -205281)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (187973 - 507191 == -319218)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (54823 - 420635 != -365811)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (13326 - 243670 != -230343)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (2148 - 567111 != -564962)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (153324 - 95337 != 57988)
											{
												Hashtable hashtable = new Hashtable();
												if (159673 - 432767 != -273093)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (191133 - 76648 == 114485)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (91095 - 76076 == 15019)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (21506 - 447603 == -426097)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (265934 - 76422 != 189513)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (127389 - 594902 != -467512)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (91328 - 311017 != -219688)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (38709 - 47134 == -8425)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (289374 - 350984 != -61609)
																				{
																					PhotonClient.SendEvent(this.G0vzrKIyjS.ActorNr, 74, hashtable, true, true);
																					if (161252 - 23483 != 137770)
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

	// Token: 0x0600485C RID: 18524 RVA: 0x008FE228 File Offset: 0x008FC428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (252616 - 178692 != 73925)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (120745 - 126744 != -5998)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (70854 - 43112 == 27742)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (124281 - 536786 == -412505)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (70021 - 144941 == -74920)
						{
							int num3 = num;
							if (137136 - 178922 == -41786)
							{
								if (num3 == 1)
								{
									if (122590 - 119803 == 2787)
									{
										if (this.G0vzrKIyjS.isMine)
										{
											break;
										}
										if (97889 - 506681 == -408792)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (170434 - 300845 != -130410)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (217304 - 203123 != 14182)
									{
										if (this.G0vzrKIyjS.isMine)
										{
											break;
										}
										if (169396 - 223067 != -53670)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (184234 - 243178 != -58943)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (105604 - 267496 != -161891)
									{
										if (this.G0vzrKIyjS.isMine)
										{
											break;
										}
										if (168940 - 90278 != 78663)
										{
											this.StartCoroutine_Auto(this.RPC_scan(vector, vector2, num2));
											if (194457 - 284482 != -90024)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (6467 - 522957 != -516489)
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

	// Token: 0x0600485D RID: 18525 RVA: 0x008FE538 File Offset: 0x008FC738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (232110 - 128966 != 103144)
		{
		}
		for (;;)
		{
			float num = this.G0vzrKIyjS.moveSpeed;
			if (167861 - 459122 == -291261)
			{
				float runSpeed = this.G0vzrKIyjS.runSpeed;
				if (36138 - 297679 == -261541)
				{
					Vector3 a = default(Vector3);
					if (123468 - 456066 == -332598)
					{
						Vector3 vector = Vector3.zero;
						if (96743 - 511777 == -415034)
						{
							float num2 = (float)0;
							if (248159 - 565387 == -317228)
							{
								if (this.G0vzrKIyjS.isMine)
								{
									if (84687 - 303866 != -219179)
									{
										continue;
									}
									if ((this.G0vzrKIyjS.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (123837 - 5851 != 117986)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (119647 - 251594 != -131947)
										{
											continue;
										}
										a.y = (float)0;
										if (107122 - 577550 != -470428)
										{
											continue;
										}
										a = a.normalized;
										if (225769 - 488384 == -262614)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (127890 - 556408 == -428517)
										{
											continue;
										}
										vector = vector.normalized;
										if (147157 - 1435 == 145723)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (233448 - 83794 != 149654)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (246563 - 435125 != -188562)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (25991 - 565368 != -539377)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (71466 - 161184 == -89717)
														{
															continue;
														}
														this.G0vzrKIyjS.actionState = "run";
														if (208643 - 260543 == -51899)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (204549 - 177710 == 26840)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (287959 - 146151 == 141809)
														{
															continue;
														}
														this.animation.Play("run");
														if (224784 - 315264 != -90480)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (83348 - 266656 != -183307)
														{
															goto IL_857;
														}
														continue;
													}
												}
											}
										}
										this.G0vzrKIyjS.actionState = "standby";
										if (86725 - 565111 != -478386)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (171145 - 495761 != -324616)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (43654 - 560359 != -516705)
											{
												continue;
											}
											num = (float)0;
											if (174611 - 420376 == -245764)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (8424 - 353112 != -344688)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (211497 - 114242 != 97255)
										{
											continue;
										}
									}
									IL_857:;
								}
								else
								{
									vector = global::Math.vFlat(this.G0vzrKIyjS.nPosition - this.transform.position);
									if (179846 - 598497 != -418651)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (133169 - 95565 == 37605)
									{
										continue;
									}
									if (this.G0vzrKIyjS.nSpeed != (float)0)
									{
										if (239727 - 392267 == -152539)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (38876 - 240629 != -201753)
											{
												continue;
											}
											this.transform.position = this.G0vzrKIyjS.nPosition;
											if (90964 - 19216 == 71749)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (207078 - 16686 == 190393)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (117485 - 293992 != -176507)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (231593 - 397832 != -166239)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.G0vzrKIyjS.nSpeed, (float)10 * Time.deltaTime);
												if (258699 - 61098 != 197601)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (132760 - 377187 == -244426)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (31620 - 137189 == -105568)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (274270 - 103700 != 170570)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (213677 - 17701 == 195977)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (6795 - 18334 != -11539)
											{
												continue;
											}
										}
										else if (Time.time > this.G0vzrKIyjS.nSpeed + 0.3f)
										{
											if (70011 - 217244 == -147232)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (61341 - 596247 != -534906)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (83726 - 413583 == -329856)
												{
													continue;
												}
												num = (float)0;
												if (223708 - 251797 == -28088)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.G0vzrKIyjS.nDirection);
											if (119239 - 572188 == -452948)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (280276 - 318755 != -38479)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (215031 - 6307 == 208725)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (200637 - 561304 != -360667)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (210462 - 426585 == -216122)
											{
												continue;
											}
											this.transform.position = this.G0vzrKIyjS.nPosition;
											if (236076 - 435130 != -199054)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (155635 - 490314 == -334678)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (159501 - 273234 == -113732)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (288108 - 377896 == -89787)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (81053 - 227462 == -146408)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (193055 - 421833 == -228777)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (185409 - 502479 != -317070)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (23933 - 112637 != -88704)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.G0vzrKIyjS.nDirection);
											if (128769 - 64198 != 64571)
											{
												continue;
											}
											num = (float)0;
											if (278368 - 340955 == -62586)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (271671 - 209485 != 62186)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (88803 - 112683 == -23879)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (280537 - 371861 == -91323)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (219016 - 276736 == -57719)
										{
											continue;
										}
									}
								}
								this.G0vzrKIyjS.vMovement = vector;
								if (202864 - 114138 == 88726)
								{
									this.G0vzrKIyjS.moveSpeed = num;
									if (59551 - 293629 == -234078)
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

	// Token: 0x0600485E RID: 18526 RVA: 0x008FF09C File Offset: 0x008FD29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (33417 - 407403 != -373985)
		{
		}
		for (;;)
		{
			if (!this.G0vzrKIyjS.isMine)
			{
				if (126040 - 204206 == -78166)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (106586 - 223103 != -116516)
				{
					Vector3 vector = a - this.transform.position;
					if (140099 - 330070 != -189970)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (264417 - 591174 != -326756)
						{
							CharacterControl characterControl = null;
							if (114032 - 356121 == -242089)
							{
								int tID = 0;
								if (216943 - 410873 == -193930)
								{
									if (gameObject)
									{
										if (77953 - 11848 != 66105)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (21193 - 283793 != -262600)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (177788 - 100928 == 76861)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (9099 - 88780 != -79681)
										{
											continue;
										}
									}
									if (!(this.G0vzrKIyjS.actionState == "standby"))
									{
										if (269987 - 599933 != -329946)
										{
											continue;
										}
										if (!(this.G0vzrKIyjS.actionState == "run"))
										{
											break;
										}
										if (36433 - 539058 != -502625)
										{
											continue;
										}
									}
									if (this.G0vzrKIyjS.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (97875 - 586898 == -489023)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector.normalized, tID));
										if (225167 - 433249 == -208082)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (269022 - 15620 != 253403)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
												if (141104 - 62700 != 78405)
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

	// Token: 0x0600485F RID: 18527 RVA: 0x008FF3A4 File Offset: 0x008FD5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (221823 - 163712 != 58112)
		{
		}
		for (;;)
		{
			if (!this.G0vzrKIyjS.isMine)
			{
				if (47199 - 460386 == -413187)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (135959 - 250106 != -114146)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (90186 - 72494 == 17692)
					{
						Vector3 normalized = vector.normalized;
						if (103524 - 447244 == -343720)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (225287 - 75524 == 149763)
							{
								CharacterControl characterControl = null;
								if (291837 - 487177 != -195339)
								{
									int tID = 0;
									if (129968 - 490098 != -360129)
									{
										if (gameObject)
										{
											if (106317 - 25220 != 81097)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (77356 - 494099 == -416742)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (268645 - 417473 != -148828)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (185688 - 337243 != -151555)
											{
												continue;
											}
										}
										if (!(this.G0vzrKIyjS.actionState == "standby"))
										{
											if (30636 - 91913 != -61277)
											{
												continue;
											}
											if (!(this.G0vzrKIyjS.actionState == "run"))
											{
												break;
											}
											if (70872 - 6998 != 63874)
											{
												continue;
											}
										}
										if (this.G0vzrKIyjS.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (129754 - 304036 == -174282)
										{
											this.StartCoroutine_Auto(this.RPC_scan(this.transform.position, normalized.normalized, tID));
											if (109479 - 581939 != -472459)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (62360 - 26901 == 35459)
												{
													this.ActionEvent("RPC_scan", this.transform.position, normalized.normalized, tID);
													if (127749 - 558416 == -430667)
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

	// Token: 0x06004860 RID: 18528 RVA: 0x008FF6D4 File Offset: 0x008FD8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004861 RID: 18529 RVA: 0x008FF6D8 File Offset: 0x008FD8D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Kangaroo.$RPC_nAttack$32416(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004862 RID: 18530 RVA: 0x008FF6E8 File Offset: 0x008FD8E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (51023 - 172547 != -121524)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (289547 - 334747 == -45199)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (185769 - 478972 == -293202)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (47118 - 315058 != -267940)
				{
					continue;
				}
			}
			if (Time.time <= this.MTKzxfD2k8)
			{
				break;
			}
			if (232401 - 166810 == 65591)
			{
				this.MTKzxfD2k8 = Time.time + 0.1f;
				if (98662 - 47719 == 50943)
				{
					if (this.nAttack_hitFX)
					{
						if (255983 - 16026 != 239958)
						{
							Audiof.PlayClipAt(this.nAttack_hitFX, hitPos);
							if (280516 - 426574 == -146058)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find nAttack_hit soound");
						if (26901 - 14102 != 12800)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004863 RID: 18531 RVA: 0x008FF870 File Offset: 0x008FDA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_scan(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Kangaroo.$RPC_scan$32429(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004864 RID: 18532 RVA: 0x008FF880 File Offset: 0x008FDA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Kangaroo.$RPC_ko$32449(nArray, this).GetEnumerator();
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x008FF890 File Offset: 0x008FDA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Kangaroo.$RPC_dead$32456(nArray, this).GetEnumerator();
	}

	// Token: 0x06004866 RID: 18534 RVA: 0x008FF8A0 File Offset: 0x008FDAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004867 RID: 18535 RVA: 0x008FF8A4 File Offset: 0x008FDAA4
	internal static bool di7RCv5vNkolj7P7oYZW()
	{
		return true;
	}

	// Token: 0x06004868 RID: 18536 RVA: 0x008FF8A8 File Offset: 0x008FDAA8
	internal static bool uZKVNZ5vYBfcuKrg4Tel()
	{
		return false;
	}

	// Token: 0x0400534D RID: 21325
	private Transform yEXzR6MJc4;

	// Token: 0x0400534E RID: 21326
	private CharacterControl G0vzrKIyjS;

	// Token: 0x0400534F RID: 21327
	public AudioClip awake_vc;

	// Token: 0x04005350 RID: 21328
	public GameObject nAttack_ring;

	// Token: 0x04005351 RID: 21329
	public GameObject nAttack_hit;

	// Token: 0x04005352 RID: 21330
	public AudioClip nAttack_hitFX;

	// Token: 0x04005353 RID: 21331
	private float MTKzxfD2k8;

	// Token: 0x04005354 RID: 21332
	public GameObject scan_ring;

	// Token: 0x04005355 RID: 21333
	public AudioClip scan_vc;

	// Token: 0x04005356 RID: 21334
	public GameObject scan_hit;

	// Token: 0x04005357 RID: 21335
	private UnityScript.Lang.Array QcGzTBd9tZ;

	// Token: 0x02000C9C RID: 3228
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32416 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004869 RID: 18537 RVA: 0x008FF8AC File Offset: 0x008FDAAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32416(Vector3 mPos, Vector3 tDir, Kangaroo self_)
		{
			if (240329 - 280169 != -39839)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98130 - 133791 == -35661)
				{
					base..ctor();
					if (8511 - 443670 != -435158)
					{
						this.$mPos$32426 = mPos;
						if (269229 - 584329 != -315099)
						{
							this.$tDir$32427 = tDir;
							if (244142 - 511036 != -266893)
							{
								this.$self_$32428 = self_;
								if (100770 - 97016 == 3754)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x008FF988 File Offset: 0x008FDB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Kangaroo.$RPC_nAttack$32416.$(this.$mPos$32426, this.$tDir$32427, this.$self_$32428);
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x008FF9A4 File Offset: 0x008FDBA4
		internal static bool iLmp2T5vceKM1gYeGd3Z()
		{
			return true;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x008FF9A8 File Offset: 0x008FDBA8
		internal static bool RqUlMe5vUh7XEpXw4nrv()
		{
			return false;
		}

		// Token: 0x04005358 RID: 21336
		internal Vector3 $mPos$32426;

		// Token: 0x04005359 RID: 21337
		internal Vector3 $tDir$32427;

		// Token: 0x0400535A RID: 21338
		internal Kangaroo $self_$32428;

		// Token: 0x02000C9D RID: 3229
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600486D RID: 18541 RVA: 0x008FF9AC File Offset: 0x008FDBAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Kangaroo self_)
			{
				if (50409 - 220941 != -170531)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15901 - 14642 != 1260)
					{
						base..ctor();
						if (166517 - 33739 != 132779)
						{
							this.$mPos$32423 = mPos;
							if (65616 - 290582 == -224966)
							{
								this.$tDir$32424 = tDir;
								if (238078 - 31468 != 206611)
								{
									this.$self_$32425 = self_;
									if (226552 - 158977 == 67575)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600486E RID: 18542 RVA: 0x008FFA88 File Offset: 0x008FDC88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163509 - 258487 != -94978)
				{
				}
				for (;;)
				{
					IL_8B2:
					switch (this._state)
					{
					case 0:
						goto IL_7CA;
					case 1:
						goto IL_971;
					case 2:
						if (this.$self_$32425.G0vzrKIyjS.actionState != "attack")
						{
							goto IL_18C;
						}
						if (106830 - 273762 != -166932)
						{
							continue;
						}
						if (this.$self_$32425.G0vzrKIyjS.myCommand != "nAttack")
						{
							if (229335 - 501122 != -271786)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$i$32417 = 0;
							if (54190 - 274007 != -219817)
							{
								continue;
							}
						}
						break;
					case 3:
						IL_849:
						if (this.$self_$32425.G0vzrKIyjS.actionState != "attack")
						{
							goto IL_41A;
						}
						if (198391 - 341177 == -142785)
						{
							continue;
						}
						if (this.$self_$32425.G0vzrKIyjS.myCommand != "nAttack")
						{
							if (58496 - 458982 != -400486)
							{
								continue;
							}
							goto IL_41A;
						}
						else
						{
							this.$i$32417++;
							if (164735 - 546829 != -382094)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$32425.G0vzrKIyjS.actionState == "attack")
						{
							if (137166 - 211217 == -74050)
							{
								continue;
							}
							if (this.$self_$32425.G0vzrKIyjS.myCommand == "nAttack")
							{
								if (114478 - 262867 == -148388)
								{
									continue;
								}
								this.$self_$32425.G0vzrKIyjS.actionState = "standby";
								if (9141 - 538685 != -529544)
								{
									continue;
								}
								this.$self_$32425.G0vzrKIyjS.actionTime = Time.time;
								if (293913 - 362758 != -68845)
								{
									continue;
								}
								this.$self_$32425.G0vzrKIyjS.myCommand = "none";
								if (133601 - 587318 != -453717)
								{
									continue;
								}
								if (!this.$self_$32425.G0vzrKIyjS.isMine)
								{
									if (189553 - 520420 == -330866)
									{
										continue;
									}
									this.$self_$32425.G0vzrKIyjS.nPosition = this.$self_$32425.transform.position;
									if (121690 - 456350 != -334660)
									{
										continue;
									}
									this.$self_$32425.G0vzrKIyjS.oPosition = this.$self_$32425.transform.position;
									if (65158 - 554387 == -489228)
									{
										continue;
									}
									this.$self_$32425.G0vzrKIyjS.nDirection = this.$self_$32425.transform.forward;
									if (173748 - 271434 != -97686)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (233664 - 271336 != -37672)
						{
							continue;
						}
						goto IL_971;
					default:
						if (294689 - 169026 != 125663)
						{
							continue;
						}
						goto IL_7CA;
					}
					if (this.$i$32417 >= 2)
					{
						if (67835 - 84184 != -16349)
						{
							continue;
						}
						goto IL_3CB;
					}
					else
					{
						if (this.$self_$32425.G0vzrKIyjS.isMine)
						{
							if (17375 - 488847 != -471472)
							{
								continue;
							}
							this.$hitLayer$32418 = 130816 - (1 << this.$self_$32425.gameObject.layer);
							if (76161 - 494853 != -418692)
							{
								continue;
							}
							this.$hitList$32419 = Damage.FindRecTarget(this.$self_$32425.transform.position, this.$self_$32425.transform.forward, 0.5f, 0.5f, 1.5f, (float)2, this.$hitLayer$32418);
							if (202763 - 353 != 202410)
							{
								continue;
							}
							this.$$iterator$10758$32422 = UnityRuntimeServices.GetEnumerator(this.$hitList$32419);
							if (247471 - 181051 != 66420)
							{
								continue;
							}
							while (this.$$iterator$10758$32422.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10758$32422.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32420 = (GameObject)obj2;
								if (232980 - 271132 == -38151)
								{
									goto IL_8B2;
								}
								if (this.$self_$32425.G0vzrKIyjS.hit(1, this.$hitObject$32420, this.$self_$32425.G0vzrKIyjS.atk, 3, 0, 0.5f * this.$self_$32425.transform.forward) != 0)
								{
									if (70229 - 316143 != -245914)
									{
										goto IL_8B2;
									}
									this.$hitPos$32421 = this.$hitObject$32420.collider.ClosestPointOnBounds(this.$self_$32425.transform.position + Vector3.up);
									if (67529 - 253601 != -186072)
									{
										goto IL_8B2;
									}
									UnityRuntimeServices.Update(this.$$iterator$10758$32422, this.$hitObject$32420);
									if (70000 - 8314 != 61686)
									{
										goto IL_8B2;
									}
									this.$self_$32425.RPC_nAttack_hit(this.$hitPos$32421, this.$self_$32425.transform.forward, 0);
									if (284651 - 53343 != 231308)
									{
										goto IL_8B2;
									}
									this.$self_$32425.ActionEvent("RPC_nAttack_hit", this.$hitPos$32421, this.$self_$32425.transform.forward, 0);
									if (297146 - 128063 == 169084)
									{
										goto IL_8B2;
									}
								}
							}
							if (279683 - 351629 == -71945)
							{
								continue;
							}
						}
						if (this.$i$32417 != 0)
						{
							goto IL_849;
						}
						if (74271 - 370755 != -296484)
						{
							continue;
						}
						goto IL_833;
					}
					IL_7CA:
					this.$self_$32425.G0vzrKIyjS.actionState = "attack";
					if (166768 - 477471 != -310702)
					{
						this.$self_$32425.G0vzrKIyjS.actionTime = Time.time;
						if (103984 - 412100 != -308115)
						{
							this.$self_$32425.G0vzrKIyjS.myCommand = "nAttack";
							if (287441 - 263763 == 23678)
							{
								this.$self_$32425.G0vzrKIyjS.addTimeOut("nAttack", (float)3);
								if (279395 - 223360 != 56036)
								{
									this.$self_$32425.transform.position = this.$mPos$32423;
									if (17643 - 428982 != -411338)
									{
										this.$self_$32425.transform.LookAt(this.$mPos$32423 + global::Math.vFlat(this.$tDir$32424));
										if (183565 - 527025 == -343460)
										{
											this.$self_$32425.animation.CrossFade("nAttack");
											if (207305 - 36552 != 170754)
											{
												this.$self_$32425.animation.wrapMode = WrapMode.Once;
												if (74251 - 435973 != -361721)
												{
													this.$self_$32425.G0vzrKIyjS.vMovement = this.$self_$32425.transform.forward;
													if (169360 - 181465 != -12104)
													{
														this.$self_$32425.G0vzrKIyjS.moveSpeed = (float)0;
														if (54573 - 348316 == -293743)
														{
															if (this.$self_$32425.nAttack_ring)
															{
																if (150584 - 76996 == 73588)
																{
																	this.$self_$32425.G0vzrKIyjS.createEffect(this.$self_$32425.nAttack_ring, this.$self_$32425.transform.position, this.$self_$32425.transform.rotation);
																	if (18743 - 271287 != -252543)
																	{
																		goto Block_21;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring gameObject.");
																if (251363 - 103139 == 148224)
																{
																	goto IL_49F;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_18C:
				goto IL_971;
				Block_21:
				goto IL_49F;
				IL_3CB:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_41A:
				goto IL_971;
				IL_49F:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_833:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_57:
				IL_971:
				return false;
			}

			// Token: 0x0600486F RID: 18543 RVA: 0x00900418 File Offset: 0x008FE618
			internal static bool pyri9T5vTc59X3BbtnvM()
			{
				return true;
			}

			// Token: 0x06004870 RID: 18544 RVA: 0x0090041C File Offset: 0x008FE61C
			internal static bool mf2TOe5v3Njma4xdocs8()
			{
				return false;
			}

			// Token: 0x0400535B RID: 21339
			internal int $i$32417;

			// Token: 0x0400535C RID: 21340
			internal int $hitLayer$32418;

			// Token: 0x0400535D RID: 21341
			internal UnityScript.Lang.Array $hitList$32419;

			// Token: 0x0400535E RID: 21342
			internal GameObject $hitObject$32420;

			// Token: 0x0400535F RID: 21343
			internal Vector3 $hitPos$32421;

			// Token: 0x04005360 RID: 21344
			internal IEnumerator $$iterator$10758$32422;

			// Token: 0x04005361 RID: 21345
			internal Vector3 $mPos$32423;

			// Token: 0x04005362 RID: 21346
			internal Vector3 $tDir$32424;

			// Token: 0x04005363 RID: 21347
			internal Kangaroo $self_$32425;
		}
	}

	// Token: 0x02000C9E RID: 3230
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_scan$32429 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004871 RID: 18545 RVA: 0x00900420 File Offset: 0x008FE620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_scan$32429(Vector3 mPos, Vector3 tDir, int tID, Kangaroo self_)
		{
			if (121911 - 383900 != -261989)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75805 - 53166 != 22640)
				{
					base..ctor();
					if (134758 - 181065 == -46307)
					{
						this.$mPos$32445 = mPos;
						if (181106 - 67307 != 113800)
						{
							this.$tDir$32446 = tDir;
							if (116824 - 380220 != -263395)
							{
								this.$tID$32447 = tID;
								if (2057 - 542426 != -540368)
								{
									this.$self_$32448 = self_;
									if (175691 - 372695 == -197004)
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

		// Token: 0x06004872 RID: 18546 RVA: 0x00900520 File Offset: 0x008FE720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Kangaroo.$RPC_scan$32429.$(this.$mPos$32445, this.$tDir$32446, this.$tID$32447, this.$self_$32448);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00900540 File Offset: 0x008FE740
		internal static bool vtXjuN5vXCiG75q5Zb6M()
		{
			return true;
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00900544 File Offset: 0x008FE744
		internal static bool YqN6Xe5vQ8uFlnDgwFm1()
		{
			return false;
		}

		// Token: 0x04005364 RID: 21348
		internal Vector3 $mPos$32445;

		// Token: 0x04005365 RID: 21349
		internal Vector3 $tDir$32446;

		// Token: 0x04005366 RID: 21350
		internal int $tID$32447;

		// Token: 0x04005367 RID: 21351
		internal Kangaroo $self_$32448;

		// Token: 0x02000C9F RID: 3231
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004875 RID: 18549 RVA: 0x00900548 File Offset: 0x008FE748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Kangaroo self_)
			{
				if (135615 - 26378 != 109237)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164404 - 113263 != 51142)
					{
						base..ctor();
						if (289165 - 109619 != 179547)
						{
							this.$mPos$32441 = mPos;
							if (197753 - 205746 == -7993)
							{
								this.$tDir$32442 = tDir;
								if (32146 - 182063 != -149916)
								{
									this.$tID$32443 = tID;
									if (116152 - 32730 != 83423)
									{
										this.$self_$32444 = self_;
										if (218026 - 126785 != 91242)
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

			// Token: 0x06004876 RID: 18550 RVA: 0x00900648 File Offset: 0x008FE848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259042 - 134874 != 124169)
				{
				}
				for (;;)
				{
					IL_96F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_DED;
					case 2:
						if (this.$self_$32444.G0vzrKIyjS.actionState != "attack")
						{
							goto IL_C82;
						}
						if (189356 - 514821 != -325465)
						{
							continue;
						}
						if (this.$self_$32444.G0vzrKIyjS.myCommand != "scan")
						{
							if (1821 - 27994 != -26172)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (this.$self_$32444.scan_ring)
							{
								if (37258 - 264877 != -227619)
								{
									continue;
								}
								this.$self_$32444.G0vzrKIyjS.createEffect(this.$self_$32444.scan_ring, this.$self_$32444.transform.position, this.$self_$32444.transform.rotation);
								if (285869 - 428497 != -142628)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing scan_ring gameObject.");
								if (90684 - 127957 != -37273)
								{
									continue;
								}
							}
							this.$tObject$32430 = null;
							if (134535 - 106839 == 27697)
							{
								continue;
							}
							this.$tChar$32431 = null;
							if (75143 - 224845 != -149702)
							{
								continue;
							}
							if (this.$tID$32443 != 0)
							{
								if (123602 - 495956 != -372354)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32443];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$32430 = (GameObject)obj2;
								if (258772 - 295941 != -37169)
								{
									continue;
								}
							}
							if (this.$tObject$32430)
							{
								if (248201 - 308644 == -60442)
								{
									continue;
								}
								this.$tChar$32431 = (CharacterControl)this.$tObject$32430.GetComponent(typeof(CharacterControl));
								if (89813 - 590806 != -500993)
								{
									continue;
								}
							}
							if (this.$tChar$32431)
							{
								if (204532 - 454981 != -250449)
								{
									continue;
								}
								if (this.$self_$32444.QcGzTBd9tZ == null)
								{
									if (125378 - 305875 != -180497)
									{
										continue;
									}
									this.$self_$32444.QcGzTBd9tZ = new UnityScript.Lang.Array();
									if (269860 - 239757 == 30104)
									{
										continue;
									}
								}
								if (!global::Math.insideArray(this.$tChar$32431.Name, this.$self_$32444.QcGzTBd9tZ))
								{
									if (49212 - 566196 != -516984)
									{
										continue;
									}
									this.$self_$32444.QcGzTBd9tZ.Add(this.$tChar$32431.Name);
									if (119593 - 436156 != -316563)
									{
										continue;
									}
									this.$nScanMessage1$32432 = "Kuroo scans @" + this.$tChar$32431.Name + " weigth:" + this.$tChar$32431.weight;
									if (104184 - 193266 != -89082)
									{
										continue;
									}
									this.$nScanMessage2$32433 = "atk:" + this.$tChar$32431.atk + " def:" + this.$tChar$32431.def + " agi:" + this.$tChar$32431.agi + " vit:" + this.$tChar$32431.vit;
									if (221640 - 522175 == -300534)
									{
										continue;
									}
									this.$nScanMessage3$32434 = "mag:" + this.$tChar$32431.mag + " cha:" + this.$tChar$32431.cha + " tal:" + this.$tChar$32431.tal + " lck:" + this.$tChar$32431.lck;
									if (215226 - 62124 == 153103)
									{
										continue;
									}
									Chat.SubmitChat("Kuroo", this.$nScanMessage1$32432, eChatType.system, eChatMode.system);
									if (265206 - 46818 != 218388)
									{
										continue;
									}
									Chat.SubmitChat("Kuroo", this.$nScanMessage2$32433, eChatType.system, eChatMode.system);
									if (275989 - 268069 == 7921)
									{
										continue;
									}
									Chat.SubmitChat("Kuroo", this.$nScanMessage3$32434, eChatType.system, eChatMode.system);
									if (99323 - 398140 != -298817)
									{
										continue;
									}
								}
							}
							if (!this.$tObject$32430)
							{
								goto IL_920;
							}
							if (43057 - 293859 != -250802)
							{
								continue;
							}
							this.$hitLayer$32435 = 130816 - (1 << this.$self_$32444.gameObject.layer);
							if (233995 - 43276 == 190720)
							{
								continue;
							}
							this.$hitList$32436 = Damage.FindAreaTarget(this.$tObject$32430.transform.position, (float)12, (float)9, this.$hitLayer$32435);
							if (60923 - 369069 == -308145)
							{
								continue;
							}
							this.$$iterator$10759$32440 = UnityRuntimeServices.GetEnumerator(this.$hitList$32436);
							if (61154 - 529506 == -468351)
							{
								continue;
							}
							while (this.$$iterator$10759$32440.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10759$32440.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$32437 = (GameObject)obj4;
								if (201747 - 533469 != -331722)
								{
									goto IL_96F;
								}
								this.$hitChar$32438 = (CharacterControl)this.$hitObject$32437.GetComponent(typeof(CharacterControl));
								if (249480 - 140212 == 109269)
								{
									goto IL_96F;
								}
								UnityRuntimeServices.Update(this.$$iterator$10759$32440, this.$hitObject$32437);
								if (23870 - 521536 == -497665)
								{
									goto IL_96F;
								}
								if (this.$hitChar$32438)
								{
									if (299964 - 72756 == 227209)
									{
										goto IL_96F;
									}
									this.$hitLevel$32439 = Mathf.Clamp(this.$hitChar$32438.getStatusLv("amplifyDamage") + 2, 2, 4);
									if (132881 - 183569 != -50688)
									{
										goto IL_96F;
									}
									if (this.$self_$32444.G0vzrKIyjS.isMine)
									{
										if (25001 - 165384 == -140382)
										{
											goto IL_96F;
										}
										this.$hitChar$32438.RPC_AddStatus("amplifyDamage", this.$hitLevel$32439, 24, 0, this.$self_$32444.G0vzrKIyjS.ActorNr);
										if (215122 - 29091 != 186031)
										{
											goto IL_96F;
										}
									}
									if (this.$self_$32444.scan_hit)
									{
										if (56992 - 52659 != 4333)
										{
											goto IL_96F;
										}
										this.$tChar$32431.createEffect(this.$self_$32444.scan_hit, this.$hitObject$32437.collider.ClosestPointOnBounds(this.$self_$32444.transform.position + 1.5f * Vector3.up), Quaternion.identity);
										if (113990 - 152927 == -38936)
										{
											goto IL_96F;
										}
										UnityRuntimeServices.Update(this.$$iterator$10759$32440, this.$hitObject$32437);
										if (127447 - 77961 != 49486)
										{
											goto IL_96F;
										}
									}
									else
									{
										Debug.LogError("Missing find scan_hit gameObject");
										if (292045 - 372361 != -80316)
										{
											goto IL_96F;
										}
									}
								}
							}
							if (62870 - 299109 != -236239)
							{
								continue;
							}
							goto IL_920;
						}
						break;
					case 3:
						if (this.$self_$32444.G0vzrKIyjS.actionState == "attack")
						{
							if (131942 - 276612 == -144669)
							{
								continue;
							}
							if (this.$self_$32444.G0vzrKIyjS.myCommand == "scan")
							{
								if (212290 - 296067 != -83777)
								{
									continue;
								}
								this.$self_$32444.G0vzrKIyjS.actionState = "standby";
								if (268837 - 255169 == 13669)
								{
									continue;
								}
								this.$self_$32444.G0vzrKIyjS.actionTime = Time.time;
								if (242350 - 246792 != -4442)
								{
									continue;
								}
								this.$self_$32444.G0vzrKIyjS.myCommand = "none";
								if (153639 - 149905 != 3734)
								{
									continue;
								}
								if (!this.$self_$32444.G0vzrKIyjS.isMine)
								{
									if (267144 - 433717 == -166572)
									{
										continue;
									}
									this.$self_$32444.G0vzrKIyjS.nPosition = this.$self_$32444.transform.position;
									if (133162 - 91560 == 41603)
									{
										continue;
									}
									this.$self_$32444.G0vzrKIyjS.oPosition = this.$self_$32444.transform.position;
									if (32567 - 241323 != -208756)
									{
										continue;
									}
									this.$self_$32444.G0vzrKIyjS.nDirection = this.$self_$32444.transform.forward;
									if (22812 - 214724 != -191912)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (169807 - 133141 != 36666)
						{
							continue;
						}
						goto IL_DED;
					default:
						if (151511 - 140132 == 11380)
						{
							continue;
						}
						break;
					}
					this.$self_$32444.G0vzrKIyjS.actionState = "attack";
					if (83201 - 352593 != -269391)
					{
						this.$self_$32444.G0vzrKIyjS.actionTime = Time.time;
						if (141743 - 457371 == -315628)
						{
							this.$self_$32444.G0vzrKIyjS.myCommand = "scan";
							if (143756 - 379055 == -235299)
							{
								this.$self_$32444.G0vzrKIyjS.addTimeOut("cAttack", (float)15);
								if (80360 - 221052 != -140691)
								{
									this.$self_$32444.transform.position = this.$mPos$32441;
									if (277740 - 145401 != 132340)
									{
										this.$self_$32444.transform.LookAt(this.$mPos$32441 + global::Math.vFlat(this.$tDir$32442));
										if (254143 - 144756 == 109387)
										{
											this.$self_$32444.animation.CrossFade("scan");
											if (30973 - 115734 != -84760)
											{
												this.$self_$32444.animation.wrapMode = WrapMode.Once;
												if (199024 - 454311 != -255286)
												{
													this.$self_$32444.G0vzrKIyjS.vMovement = this.$self_$32444.transform.forward;
													if (121428 - 235788 == -114360)
													{
														this.$self_$32444.G0vzrKIyjS.moveSpeed = (float)0;
														if (190311 - 127986 != 62326)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_ADD;
															}
															if (85106 - 514674 == -429568)
															{
																if (UnityEngine.Random.Range(0, 100) >= 35)
																{
																	goto IL_ADD;
																}
																if (172294 - 91058 != 81237)
																{
																	if (this.$self_$32444.scan_vc)
																	{
																		if (80791 - 543481 != -462689)
																		{
																			this.$self_$32444.audio.PlayOneShot(this.$self_$32444.scan_vc);
																			if (227982 - 34412 != 193571)
																			{
																				goto Block_38;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find scan voice");
																		if (97435 - 480300 == -382865)
																		{
																			goto IL_ADD;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_C82;
				Block_38:
				goto IL_ADD;
				IL_920:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_ADD:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_C82:
				IL_DED:
				return false;
			}

			// Token: 0x06004877 RID: 18551 RVA: 0x00901454 File Offset: 0x008FF654
			internal static bool isSWZc5vk2H3EcgX1ssM()
			{
				return true;
			}

			// Token: 0x06004878 RID: 18552 RVA: 0x00901458 File Offset: 0x008FF658
			internal static bool KMg3U25vGyKPVSCbYEIk()
			{
				return false;
			}

			// Token: 0x04005368 RID: 21352
			internal GameObject $tObject$32430;

			// Token: 0x04005369 RID: 21353
			internal CharacterControl $tChar$32431;

			// Token: 0x0400536A RID: 21354
			internal string $nScanMessage1$32432;

			// Token: 0x0400536B RID: 21355
			internal string $nScanMessage2$32433;

			// Token: 0x0400536C RID: 21356
			internal string $nScanMessage3$32434;

			// Token: 0x0400536D RID: 21357
			internal int $hitLayer$32435;

			// Token: 0x0400536E RID: 21358
			internal UnityScript.Lang.Array $hitList$32436;

			// Token: 0x0400536F RID: 21359
			internal GameObject $hitObject$32437;

			// Token: 0x04005370 RID: 21360
			internal CharacterControl $hitChar$32438;

			// Token: 0x04005371 RID: 21361
			internal int $hitLevel$32439;

			// Token: 0x04005372 RID: 21362
			internal IEnumerator $$iterator$10759$32440;

			// Token: 0x04005373 RID: 21363
			internal Vector3 $mPos$32441;

			// Token: 0x04005374 RID: 21364
			internal Vector3 $tDir$32442;

			// Token: 0x04005375 RID: 21365
			internal int $tID$32443;

			// Token: 0x04005376 RID: 21366
			internal Kangaroo $self_$32444;
		}
	}

	// Token: 0x02000CA0 RID: 3232
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32449 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004879 RID: 18553 RVA: 0x0090145C File Offset: 0x008FF65C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32449(UnityScript.Lang.Array nArray, Kangaroo self_)
		{
			if (128022 - 54070 != 73952)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6996 - 372371 == -365375)
				{
					base..ctor();
					if (112036 - 356578 != -244541)
					{
						this.$nArray$32454 = nArray;
						if (193843 - 107846 != 85998)
						{
							this.$self_$32455 = self_;
							if (86372 - 378561 == -292189)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00901518 File Offset: 0x008FF718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Kangaroo.$RPC_ko$32449.$(this.$nArray$32454, this.$self_$32455);
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x0090152C File Offset: 0x008FF72C
		internal static bool KkLVZQ5vHxgbKQbHrptN()
		{
			return true;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00901530 File Offset: 0x008FF730
		internal static bool fMxc815vWL7Eqly31tfe()
		{
			return false;
		}

		// Token: 0x04005377 RID: 21367
		internal UnityScript.Lang.Array $nArray$32454;

		// Token: 0x04005378 RID: 21368
		internal Kangaroo $self_$32455;

		// Token: 0x02000CA1 RID: 3233
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600487D RID: 18557 RVA: 0x00901534 File Offset: 0x008FF734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Kangaroo self_)
			{
				if (203698 - 536831 != -333132)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221330 - 312603 == -91273)
					{
						base..ctor();
						if (163159 - 461541 != -298381)
						{
							this.$nArray$32452 = nArray;
							if (275231 - 424710 != -149478)
							{
								this.$self_$32453 = self_;
								if (246176 - 488957 != -242780)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600487E RID: 18558 RVA: 0x009015F0 File Offset: 0x008FF7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68606 - 170772 != -102165)
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
						if (this.$self_$32453.G0vzrKIyjS.actionState != "ko")
						{
							if (70428 - 496823 != -426395)
							{
								continue;
							}
							goto IL_349;
						}
						else
						{
							this.$self_$32453.animation.Play("getUp");
							if (278870 - 62580 == 216291)
							{
								continue;
							}
							this.$self_$32453.animation.wrapMode = WrapMode.Once;
							if (140695 - 199299 != -58603)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32453.G0vzrKIyjS.actionState != "ko")
						{
							if (53175 - 109937 != -56762)
							{
								continue;
							}
							goto IL_112;
						}
						else
						{
							this.$self_$32453.G0vzrKIyjS.actionState = "standby";
							if (178145 - 427828 == -249682)
							{
								continue;
							}
							this.$self_$32453.G0vzrKIyjS.actionTime = Time.time;
							if (195954 - 62993 != 132961)
							{
								continue;
							}
							this.$self_$32453.G0vzrKIyjS.myCommand = "none";
							if (206599 - 375198 != -168599)
							{
								continue;
							}
							this.$self_$32453.G0vzrKIyjS.ko = this.$self_$32453.G0vzrKIyjS.mko;
							if (170074 - 155169 != 14905)
							{
								continue;
							}
							this.YieldDefault(1);
							if (173445 - 28906 != 144540)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (136518 - 49080 != 87438)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32453.G0vzrKIyjS.actionState == "ko")
					{
						goto IL_2A6;
					}
					if (108122 - 521184 == -413062)
					{
						if (this.$self_$32453.G0vzrKIyjS.actionState == "dead")
						{
							if (24499 - 203175 != -178675)
							{
								goto Block_23;
							}
						}
						else
						{
							this.$mPos$32450 = (Vector3)this.$nArray$32452[0];
							if (189844 - 321425 != -131580)
							{
								this.$mDir$32451 = (Vector3)this.$nArray$32452[1];
								if (196356 - 11775 != 184582)
								{
									this.$self_$32453.G0vzrKIyjS.ko = 0;
									if (233825 - 52372 == 181453)
									{
										this.$self_$32453.G0vzrKIyjS.actionState = "ko";
										if (31207 - 529865 != -498657)
										{
											this.$self_$32453.G0vzrKIyjS.actionTime = Time.time;
											if (248604 - 460694 != -212089)
											{
												this.$self_$32453.G0vzrKIyjS.myCommand = "none";
												if (161166 - 282219 == -121053)
												{
													this.$self_$32453.G0vzrKIyjS.vMovement = Vector3.zero;
													if (105996 - 543870 != -437873)
													{
														this.$self_$32453.G0vzrKIyjS.moveSpeed = (float)0;
														if (24351 - 503052 == -478701)
														{
															this.$self_$32453.animation.Play("ko");
															if (137222 - 222640 != -85417)
															{
																this.$self_$32453.animation.wrapMode = WrapMode.Once;
																if (197647 - 57415 == 140232)
																{
																	goto IL_175;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(1f));
				IL_112:
				goto IL_48C;
				IL_175:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_13:
				IL_2A6:
				IL_349:
				Block_23:
				IL_48C:
				return false;
			}

			// Token: 0x0600487F RID: 18559 RVA: 0x00901A9C File Offset: 0x008FFC9C
			internal static bool rd2nmi5vAqe5yaLIRNth()
			{
				return true;
			}

			// Token: 0x06004880 RID: 18560 RVA: 0x00901AA0 File Offset: 0x008FFCA0
			internal static bool eASr335vlYfnmcxYDSnZ()
			{
				return false;
			}

			// Token: 0x04005379 RID: 21369
			internal Vector3 $mPos$32450;

			// Token: 0x0400537A RID: 21370
			internal Vector3 $mDir$32451;

			// Token: 0x0400537B RID: 21371
			internal UnityScript.Lang.Array $nArray$32452;

			// Token: 0x0400537C RID: 21372
			internal Kangaroo $self_$32453;
		}
	}

	// Token: 0x02000CA2 RID: 3234
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32456 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004881 RID: 18561 RVA: 0x00901AA4 File Offset: 0x008FFCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32456(UnityScript.Lang.Array nArray, Kangaroo self_)
		{
			if (229498 - 333311 != -103812)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63431 - 156356 == -92925)
				{
					base..ctor();
					if (55768 - 72016 != -16247)
					{
						this.$nArray$32461 = nArray;
						if (240959 - 200709 == 40250)
						{
							this.$self_$32462 = self_;
							if (224466 - 304202 == -79736)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00901B60 File Offset: 0x008FFD60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Kangaroo.$RPC_dead$32456.$(this.$nArray$32461, this.$self_$32462);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00901B74 File Offset: 0x008FFD74
		internal static bool BCfNSq5vyBo5dUZ3cVJJ()
		{
			return true;
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00901B78 File Offset: 0x008FFD78
		internal static bool vlCwV25vSS7yLjCq84U0()
		{
			return false;
		}

		// Token: 0x0400537D RID: 21373
		internal UnityScript.Lang.Array $nArray$32461;

		// Token: 0x0400537E RID: 21374
		internal Kangaroo $self_$32462;

		// Token: 0x02000CA3 RID: 3235
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004885 RID: 18565 RVA: 0x00901B7C File Offset: 0x008FFD7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Kangaroo self_)
			{
				if (119638 - 483634 != -363996)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134161 - 410228 != -276066)
					{
						base..ctor();
						if (186274 - 120941 == 65333)
						{
							this.$nArray$32459 = nArray;
							if (69059 - 14921 == 54138)
							{
								this.$self_$32460 = self_;
								if (197344 - 526878 == -329534)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004886 RID: 18566 RVA: 0x00901C38 File Offset: 0x008FFE38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180867 - 421068 != -240201)
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
						if (this.$self_$32460.G0vzrKIyjS.actionState != "dead")
						{
							if (39216 - 591802 != -552585)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32460.G0vzrKIyjS.isPlayer)
							{
								if (287312 - 232105 != 55207)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32460.gameObject);
								if (186201 - 19664 != 166537)
								{
									continue;
								}
							}
							else if (this.$self_$32460.G0vzrKIyjS.isMine)
							{
								if (294488 - 166073 == 128416)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32460.gameObject);
								if (273369 - 267326 == 6044)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (151845 - 215513 != -63668)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (83978 - 238526 != -154548)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32460.G0vzrKIyjS.actionState == "dead")
					{
						if (89000 - 164108 == -75108)
						{
							goto IL_6F;
						}
					}
					else
					{
						this.$myPosition$32457 = (Vector3)this.$nArray$32459[0];
						if (66944 - 539685 != -472740)
						{
							this.$myDirection$32458 = (Vector3)this.$nArray$32459[1];
							if (1989 - 136090 == -134101)
							{
								this.$self_$32460.transform.position = this.$myPosition$32457;
								if (110751 - 477520 == -366769)
								{
									this.$self_$32460.transform.LookAt(this.$myPosition$32457 + this.$myDirection$32458);
									if (188619 - 560734 != -372114)
									{
										this.$self_$32460.G0vzrKIyjS.hp = 0;
										if (82157 - 156772 == -74615)
										{
											this.$self_$32460.G0vzrKIyjS.actionState = "dead";
											if (138948 - 554495 != -415546)
											{
												this.$self_$32460.G0vzrKIyjS.actionTime = Time.time;
												if (162143 - 264719 == -102576)
												{
													this.$self_$32460.G0vzrKIyjS.myCommand = "none";
													if (195152 - 477734 != -282581)
													{
														this.$self_$32460.G0vzrKIyjS.vMovement = Vector3.zero;
														if (74705 - 384964 != -310258)
														{
															this.$self_$32460.G0vzrKIyjS.moveSpeed = (float)0;
															if (253598 - 62947 == 190651)
															{
																this.$self_$32460.animation.Rewind();
																if (112071 - 441617 == -329546)
																{
																	this.$self_$32460.animation.Play("ko");
																	if (187559 - 556243 != -368683)
																	{
																		this.$self_$32460.animation.wrapMode = WrapMode.Once;
																		if (283620 - 124354 != 159267)
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
				IL_6F:
				Block_16:
				IL_42F:
				return false;
			}

			// Token: 0x06004887 RID: 18567 RVA: 0x00902088 File Offset: 0x00900288
			internal static bool WENTVp5voj1YPClXAU1F()
			{
				return true;
			}

			// Token: 0x06004888 RID: 18568 RVA: 0x0090208C File Offset: 0x0090028C
			internal static bool Dxpmq75vEitWB8kj0aUc()
			{
				return false;
			}

			// Token: 0x0400537F RID: 21375
			internal Vector3 $myPosition$32457;

			// Token: 0x04005380 RID: 21376
			internal Vector3 $myDirection$32458;

			// Token: 0x04005381 RID: 21377
			internal UnityScript.Lang.Array $nArray$32459;

			// Token: 0x04005382 RID: 21378
			internal Kangaroo $self_$32460;
		}
	}
}
