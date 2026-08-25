using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000087 RID: 135
[Serializable]
public class GiantSandBug : MonoBehaviour
{
	// Token: 0x060002D9 RID: 729 RVA: 0x00049FFC File Offset: 0x000481FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantSandBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0004A00C File Offset: 0x0004820C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35850 - 81492 != -45642)
		{
		}
		for (;;)
		{
			this.CoXccBsG7P = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (86762 - 544957 == -458195)
			{
				this.CoXccBsG7P.actionState = "standby";
				if (93630 - 168769 == -75139)
				{
					this.CoXccBsG7P.actionTime = Time.time;
					if (279430 - 335864 == -56434)
					{
						this.CoXccBsG7P.myCommand = "none";
						if (54752 - 197199 == -142447)
						{
							Transform transform = this.transform.Find("ParticleEmitter");
							if (135825 - 364570 == -228745)
							{
								if (transform)
								{
									if (276830 - 385019 == -108189)
									{
										this.KIMcnsYYJo = (ParticleEmitter)transform.GetComponent(typeof(ParticleEmitter));
										if (278330 - 498292 != -219961)
										{
											if (this.KIMcnsYYJo)
											{
												break;
											}
											if (284006 - 34801 != 249206)
											{
												Debug.LogError("Cannot find ParticleEmitter Component");
												if (16336 - 109483 != -93146)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find ParticleEmitter GameObject");
									if (161370 - 8634 == 152736)
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

	// Token: 0x060002DB RID: 731 RVA: 0x0004A1F4 File Offset: 0x000483F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.CoXccBsG7P.isMine = true;
		}
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0004A210 File Offset: 0x00048410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (235911 - 257304 != -21392)
		{
		}
		for (;;)
		{
			if (this.CoXccBsG7P.isControlled)
			{
				if (66408 - 333428 != -267020)
				{
					continue;
				}
				if (!(this.CoXccBsG7P.actionState == "standby"))
				{
					if (3664 - 229962 != -226298)
					{
						continue;
					}
					if (!(this.CoXccBsG7P.actionState == "run"))
					{
						goto IL_589;
					}
					if (184168 - 367963 != -183795)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (182784 - 168359 == 14426)
				{
					continue;
				}
			}
			IL_589:
			if (this.CoXccBsG7P.hp > 0)
			{
				goto IL_302;
			}
			if (58913 - 242670 == -183756)
			{
				continue;
			}
			if (!(this.CoXccBsG7P.actionState != "dead"))
			{
				goto IL_302;
			}
			if (223864 - 380046 != -156182)
			{
				continue;
			}
			if (this.CoXccBsG7P.isMine)
			{
				if (171093 - 257954 != -86861)
				{
					continue;
				}
				statusClass status = this.CoXccBsG7P.getStatus("autoLife");
				if (93884 - 146025 != -52141)
				{
					continue;
				}
				if (status != null)
				{
					if (224244 - 11217 == 213028)
					{
						continue;
					}
					this.CoXccBsG7P.hp = 1;
					if (182029 - 570502 == -388472)
					{
						continue;
					}
					this.CoXccBsG7P.RPC_RemoveStatus("autoLife");
					if (164258 - 448740 != -284482)
					{
						continue;
					}
					this.CoXccBsG7P.RPC_createEffect("autoLife");
					if (178883 - 157137 == 21747)
					{
						continue;
					}
					this.CoXccBsG7P.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
					if (31347 - 411226 == -379878)
					{
						continue;
					}
				}
				else
				{
					this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
					{
						this.transform.position,
						this.transform.forward
					})));
					if (229869 - 524750 != -294881)
					{
						continue;
					}
					if (PhotonClient.IsInitialized())
					{
						if (125627 - 340550 != -214923)
						{
							continue;
						}
						this.CoXccBsG7P.DeadEvent();
						if (65204 - 458115 == -392910)
						{
							continue;
						}
					}
				}
			}
			else
			{
				this.CoXccBsG7P.hp = 1;
				if (108161 - 176009 == -67847)
				{
					continue;
				}
			}
			IL_2A3:
			if (!(this.CoXccBsG7P.actionState != "run"))
			{
				break;
			}
			if (250904 - 195901 != 55003)
			{
				continue;
			}
			if (this.audio.isPlaying)
			{
				if (57966 - 146359 != -88393)
				{
					continue;
				}
				this.audio.Stop();
				if (180049 - 73433 != 106616)
				{
					continue;
				}
			}
			if (!this.KIMcnsYYJo)
			{
				break;
			}
			if (76216 - 586915 != -510699)
			{
				continue;
			}
			this.KIMcnsYYJo.emit = false;
			if (3403 - 34208 != -30804)
			{
				break;
			}
			continue;
			IL_302:
			if (this.CoXccBsG7P.hp <= 0)
			{
				goto IL_2A3;
			}
			if (265824 - 521549 != -255724)
			{
				if (this.CoXccBsG7P.ko > 0)
				{
					goto IL_2A3;
				}
				if (126829 - 148393 != -21563)
				{
					if (!(this.CoXccBsG7P.actionState != "ko"))
					{
						goto IL_2A3;
					}
					if (125331 - 503181 == -377850)
					{
						if (!(this.CoXccBsG7P.actionState != "dead"))
						{
							goto IL_2A3;
						}
						if (84041 - 423083 != -339041)
						{
							if (this.CoXccBsG7P.isMine)
							{
								if (17420 - 564344 == -546924)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (242940 - 105681 != 137260)
									{
										if (PhotonClient.IsInitialized())
										{
											if (17905 - 432900 != -414995)
											{
												continue;
											}
											this.CoXccBsG7P.KoEvent();
											if (216837 - 327862 == -111024)
											{
												continue;
											}
										}
										goto IL_2A3;
									}
								}
							}
							else
							{
								this.CoXccBsG7P.ko = 1;
								if (291136 - 16269 == 274867)
								{
									goto IL_2A3;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0004A7E4 File Offset: 0x000489E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (114257 - 32681 != 81577)
		{
		}
		for (;;)
		{
			float num = this.CoXccBsG7P.moveSpeed;
			if (105784 - 462758 == -356974)
			{
				float runSpeed = this.CoXccBsG7P.runSpeed;
				if (101036 - 100320 != 717)
				{
					Vector3 a = default(Vector3);
					if (207403 - 212797 != -5393)
					{
						Vector3 vector = Vector3.zero;
						if (78951 - 43667 != 35285)
						{
							if ((this.CoXccBsG7P.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (21160 - 396182 != -375021)
							{
								if (this.CoXccBsG7P.isMine)
								{
									if (178418 - 595858 != -417440)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (10893 - 340089 == -329195)
									{
										continue;
									}
									a.y = (float)0;
									if (125135 - 148421 != -23286)
									{
										continue;
									}
									a = a.normalized;
									if (273497 - 454460 == -180962)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (52717 - 506181 == -453463)
									{
										continue;
									}
									vector = vector.normalized;
									if (131188 - 377956 == -246767)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (106896 - 377726 != -270830)
										{
											continue;
										}
										this.CoXccBsG7P.actionState = "run";
										if (296985 - 60259 == 236727)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (95381 - 468134 != -372753)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (24569 - 241571 == -217001)
										{
											continue;
										}
										this.animation.CrossFade("run", (float)1);
										if (82428 - 550155 == -467726)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (151090 - 266001 == -114910)
										{
											continue;
										}
										if (!this.audio.isPlaying)
										{
											if (170811 - 232771 == -61959)
											{
												continue;
											}
											this.audio.Play();
											if (9561 - 327778 != -318217)
											{
												continue;
											}
										}
										if (this.KIMcnsYYJo)
										{
											if (63669 - 289038 == -225368)
											{
												continue;
											}
											this.KIMcnsYYJo.emit = true;
											if (128499 - 593436 == -464936)
											{
												continue;
											}
										}
									}
									else
									{
										this.CoXccBsG7P.actionState = "standby";
										if (26692 - 155457 == -128764)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (200444 - 313553 == -113108)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (211021 - 151314 == 59708)
											{
												continue;
											}
											num = (float)0;
											if (77708 - 236774 != -159066)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", (float)1);
										if (246959 - 562329 == -315369)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (60226 - 19521 != 40705)
										{
											continue;
										}
										if (this.audio.isPlaying)
										{
											if (168270 - 360308 != -192038)
											{
												continue;
											}
											this.audio.Stop();
											if (127701 - 207490 == -79788)
											{
												continue;
											}
										}
										if (this.KIMcnsYYJo)
										{
											if (49351 - 306959 == -257607)
											{
												continue;
											}
											this.KIMcnsYYJo.emit = false;
											if (265456 - 108090 != 157366)
											{
												continue;
											}
										}
									}
								}
								else if ((this.CoXccBsG7P.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (273909 - 86632 == 187278)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.CoXccBsG7P.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (142088 - 267605 != -125517)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (110681 - 508184 != -397503)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (170885 - 209272 != -38387)
										{
											continue;
										}
										num = (float)0;
										if (278040 - 560854 == -282813)
										{
											continue;
										}
										this.transform.position = this.CoXccBsG7P.nPosition;
										if (203697 - 203089 != 608)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (43721 - 65133 != -21412)
										{
											continue;
										}
										vector = lhs.normalized;
										if (79962 - 60223 == 19740)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (160056 - 46534 == 113523)
										{
											continue;
										}
										this.animation.CrossFade("run", (float)1);
										if (78822 - 254540 != -175718)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (292930 - 381586 != -88656)
										{
											continue;
										}
										if (!this.audio.isPlaying)
										{
											if (231235 - 301272 == -70036)
											{
												continue;
											}
											this.audio.Play();
											if (220890 - 546068 == -325177)
											{
												continue;
											}
										}
										if (this.KIMcnsYYJo)
										{
											if (285926 - 448307 == -162380)
											{
												continue;
											}
											this.KIMcnsYYJo.emit = true;
											if (238346 - 500769 != -262423)
											{
												continue;
											}
										}
									}
									else
									{
										vector = this.transform.forward;
										if (11578 - 521469 == -509890)
										{
											continue;
										}
										this.animation.CrossFade("root", (float)1);
										if (19120 - 42389 == -23268)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (56942 - 389649 == -332706)
										{
											continue;
										}
										if (this.audio.isPlaying)
										{
											if (60098 - 437352 == -377253)
											{
												continue;
											}
											this.audio.Stop();
											if (207121 - 468003 == -260881)
											{
												continue;
											}
										}
										if (this.KIMcnsYYJo)
										{
											if (54352 - 257486 != -203134)
											{
												continue;
											}
											this.KIMcnsYYJo.emit = false;
											if (294087 - 507769 != -213682)
											{
												continue;
											}
										}
									}
								}
								this.CoXccBsG7P.vMovement = vector;
								if (258126 - 310377 != -52250)
								{
									this.CoXccBsG7P.moveSpeed = num;
									if (284306 - 27877 != 256430)
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

	// Token: 0x060002DE RID: 734 RVA: 0x0004B10C File Offset: 0x0004930C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (58956 - 481804 != -422847)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (157040 - 483582 != -326541)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (134472 - 534468 == -399996)
				{
					if (105775 - 506149 == -400374)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (109799 - 39358 == 70442)
							{
								continue;
							}
							v = 1;
							if (28987 - 500666 == -471678)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (11169 - 568593 != -557424)
							{
								continue;
							}
							v = -1;
							if (28412 - 111777 != -83365)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sandDive")
						{
							if (254254 - 127085 == 127170)
							{
								continue;
							}
							v = 11;
							if (56240 - 158873 != -102633)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sandDive_hit")
						{
							if (227278 - 3137 != 224141)
							{
								continue;
							}
							v = -11;
							if (199027 - 538522 == -339494)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (84798 - 194768 != -109969)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (164699 - 75565 == 89134)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (23761 - 451600 == -427839)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (241941 - 556384 != -314442)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (267672 - 328176 != -60503)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (83732 - 555839 != -472106)
											{
												Hashtable hashtable = new Hashtable();
												if (155460 - 224089 != -68628)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (273035 - 98826 == 174209)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (189455 - 383844 == -194389)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (198259 - 190406 == 7853)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (165794 - 203821 == -38027)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (117752 - 137040 == -19288)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (243464 - 264338 == -20874)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (5994 - 465103 == -459109)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (21919 - 592381 == -570462)
																				{
																					PhotonClient.SendEvent(this.CoXccBsG7P.ActorNr, 74, hashtable, true, true);
																					if (195704 - 51929 == 143775)
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

	// Token: 0x060002DF RID: 735 RVA: 0x0004B5F8 File Offset: 0x000497F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (4214 - 46906 != -42692)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (90795 - 324511 != -233715)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (181624 - 5277 == 176347)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (160771 - 563682 != -402910)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (39797 - 78901 == -39104)
						{
							int num3 = num;
							if (276085 - 237017 == 39068)
							{
								if (num3 == 1)
								{
									if (211286 - 525877 != -314590)
									{
										if (this.CoXccBsG7P.isMine)
										{
											break;
										}
										if (208719 - 240226 == -31507)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (279198 - 315373 != -36174)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (282720 - 530989 != -248268)
									{
										if (this.CoXccBsG7P.isMine)
										{
											break;
										}
										if (120160 - 366168 != -246007)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (225804 - 555363 != -329558)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (113068 - 518720 == -405652)
									{
										if (this.CoXccBsG7P.isMine)
										{
											break;
										}
										if (200625 - 101899 == 98726)
										{
											this.StartCoroutine_Auto(this.RPC_sandDive(vector, vector2, num2));
											if (8296 - 123347 != -115050)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (52376 - 319844 == -267468)
									{
										if (this.CoXccBsG7P.isMine)
										{
											break;
										}
										if (25654 - 428571 == -402917)
										{
											this.RPC_sandDive_hit(vector, vector2, num2);
											if (223104 - 321047 == -97943)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (185864 - 111751 == 74113)
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

	// Token: 0x060002E0 RID: 736 RVA: 0x0004B97C File Offset: 0x00049B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (25108 - 593164 != -568055)
		{
		}
		for (;;)
		{
			if (!this.CoXccBsG7P.isMine)
			{
				if (89021 - 128888 == -39867)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (286366 - 18647 != 267720)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (118843 - 292241 == -173398)
					{
						Vector3 normalized = vector.normalized;
						if (257784 - 567905 == -310121)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (101701 - 156994 != -55292)
							{
								if (210319 - 380096 == -169777)
								{
									if (gameObject)
									{
										if (782 - 275938 == -275155)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (133046 - 90617 != 42429)
										{
											continue;
										}
									}
									if (!(this.CoXccBsG7P.actionState == "standby"))
									{
										if (263435 - 492223 != -228788)
										{
											continue;
										}
										if (!(this.CoXccBsG7P.actionState == "run"))
										{
											break;
										}
										if (202467 - 111515 != 90952)
										{
											continue;
										}
									}
									if (this.CoXccBsG7P.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (72272 - 441551 == -369279)
									{
										if (this.CoXccBsG7P.actionState == "standby")
										{
											if (3088 - 223597 != -220508)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
												if (124434 - 293568 == -169134)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (108193 - 185076 != -76882)
													{
														this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
														if (4278 - 467932 != -463653)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (!(this.CoXccBsG7P.actionState == "run"))
											{
												break;
											}
											if (6595 - 121823 != -115227)
											{
												this.StartCoroutine_Auto(this.RPC_sandDive(this.transform.position, normalized, 0));
												if (295230 - 584692 == -289462)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (52097 - 389411 != -337313)
													{
														this.ActionEvent("RPC_sandDive", this.transform.position, normalized, 0);
														if (2501 - 320707 == -318206)
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

	// Token: 0x060002E1 RID: 737 RVA: 0x0004BD30 File Offset: 0x00049F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0004BD34 File Offset: 0x00049F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0004BD38 File Offset: 0x00049F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GiantSandBug.$RPC_nAttack$15697(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0004BD48 File Offset: 0x00049F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (258592 - 68739 != 189853)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (245847 - 223482 != 22366)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (211755 - 124097 == 87658)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (7760 - 90359 == -82599)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0004BE08 File Offset: 0x0004A008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sandDive(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GiantSandBug.$RPC_sandDive$15710(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0004BE18 File Offset: 0x0004A018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sandDive_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (224253 - 518313 != -294059)
		{
		}
		for (;;)
		{
			if (this.sandDive_hit)
			{
				if (178756 - 486533 != -307776)
				{
					UnityEngine.Object.Instantiate(this.sandDive_hit, hitPos, this.transform.rotation);
					if (76125 - 322950 != -246824)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (114996 - 329012 == -214016)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0004BED8 File Offset: 0x0004A0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new GiantSandBug.$RPC_ko$15723(nArray, this).GetEnumerator();
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0004BEE8 File Offset: 0x0004A0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GiantSandBug.$RPC_dead$15730(nArray, this).GetEnumerator();
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0004BEF8 File Offset: 0x0004A0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0004BEFC File Offset: 0x0004A0FC
	internal static bool aYUMR7touRNV2tGjey7()
	{
		return true;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0004BF00 File Offset: 0x0004A100
	internal static bool anpXcitEb8u3w8N7n13()
	{
		return false;
	}

	// Token: 0x040002DA RID: 730
	private CharacterControl CoXccBsG7P;

	// Token: 0x040002DB RID: 731
	private ParticleEmitter KIMcnsYYJo;

	// Token: 0x040002DC RID: 732
	public GameObject nAttack_ring;

	// Token: 0x040002DD RID: 733
	public GameObject nAttack_hit;

	// Token: 0x040002DE RID: 734
	public GameObject sandDive_ring;

	// Token: 0x040002DF RID: 735
	public GameObject sandDive_hit;

	// Token: 0x040002E0 RID: 736
	public GameObject deadEffect;

	// Token: 0x02000088 RID: 136
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$15697 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002EC RID: 748 RVA: 0x0004BF04 File Offset: 0x0004A104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$15697(Vector3 mPos, Vector3 tDir, GiantSandBug self_)
		{
			if (216049 - 20536 != 195514)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13188 - 201395 == -188207)
				{
					base..ctor();
					if (10419 - 27261 != -16841)
					{
						this.$mPos$15707 = mPos;
						if (94001 - 283551 != -189549)
						{
							this.$tDir$15708 = tDir;
							if (126868 - 327476 != -200607)
							{
								this.$self_$15709 = self_;
								if (148617 - 13109 != 135509)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0004BFE0 File Offset: 0x0004A1E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantSandBug.$RPC_nAttack$15697.$(this.$mPos$15707, this.$tDir$15708, this.$self_$15709);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0004BFFC File Offset: 0x0004A1FC
		internal static bool JEKcAmt2aPCKlEXyAun()
		{
			return true;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0004C000 File Offset: 0x0004A200
		internal static bool rRMQ6Rt8NkEM535mmGn()
		{
			return false;
		}

		// Token: 0x040002E1 RID: 737
		internal Vector3 $mPos$15707;

		// Token: 0x040002E2 RID: 738
		internal Vector3 $tDir$15708;

		// Token: 0x040002E3 RID: 739
		internal GiantSandBug $self_$15709;

		// Token: 0x02000089 RID: 137
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002F0 RID: 752 RVA: 0x0004C004 File Offset: 0x0004A204
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GiantSandBug self_)
			{
				if (90962 - 558918 != -467956)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245483 - 236073 != 9411)
					{
						base..ctor();
						if (230178 - 450106 != -219927)
						{
							this.$mPos$15704 = mPos;
							if (239465 - 196251 != 43215)
							{
								this.$tDir$15705 = tDir;
								if (254916 - 398666 == -143750)
								{
									this.$self_$15706 = self_;
									if (224589 - 217104 != 7486)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x0004C0E0 File Offset: 0x0004A2E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133792 - 256932 != -123140)
				{
				}
				for (;;)
				{
					IL_A04:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A3D;
					case 2:
						if (this.$self_$15706.CoXccBsG7P.actionState != "attack")
						{
							goto IL_6B9;
						}
						if (44103 - 317491 != -273388)
						{
							continue;
						}
						if (this.$self_$15706.CoXccBsG7P.myCommand != "nAttack")
						{
							if (10600 - 146281 != -135681)
							{
								continue;
							}
							goto IL_6B9;
						}
						else
						{
							this.$self_$15706.CoXccBsG7P.moveSpeed = (float)6;
							if (70122 - 258472 == -188349)
							{
								continue;
							}
							if (this.$self_$15706.nAttack_ring)
							{
								if (269659 - 247274 == 22386)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15706.nAttack_ring, this.$self_$15706.transform.position, Quaternion.identity);
								if (41074 - 63875 == -22800)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring effect");
								if (102612 - 45440 == 57173)
								{
									continue;
								}
							}
							this.$i$15698 = 0;
							if (101421 - 303564 != -202142)
							{
								goto IL_7EE;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15706.CoXccBsG7P.actionState != "attack")
						{
							goto IL_6EA;
						}
						if (173708 - 370235 != -196527)
						{
							continue;
						}
						if (this.$self_$15706.CoXccBsG7P.myCommand != "nAttack")
						{
							if (27952 - 215075 != -187122)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$self_$15706.CoXccBsG7P.moveSpeed = (float)0;
							if (106657 - 367499 == -260841)
							{
								continue;
							}
							if (this.$self_$15706.CoXccBsG7P.isMine)
							{
								if (208483 - 581222 != -372739)
								{
									continue;
								}
								this.$hitLayer$15699 = 130816 - (1 << this.$self_$15706.gameObject.layer);
								if (290632 - 280722 == 9911)
								{
									continue;
								}
								this.$hitList$15700 = Damage.FindRecTarget(this.$self_$15706.transform.position, this.$self_$15706.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$15699);
								if (259771 - 94642 == 165130)
								{
									continue;
								}
								this.$$iterator$9909$15703 = UnityRuntimeServices.GetEnumerator(this.$hitList$15700);
								if (3021 - 303160 == -300138)
								{
									continue;
								}
								while (this.$$iterator$9909$15703.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9909$15703.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15701 = (GameObject)obj2;
									if (215171 - 51496 != 163675)
									{
										goto IL_A04;
									}
									if (this.$self_$15706.CoXccBsG7P.hit(1, this.$hitObject$15701, this.$self_$15706.CoXccBsG7P.atk, 1, 0, this.$self_$15706.transform.forward) != 0)
									{
										if (206844 - 561157 == -354312)
										{
											goto IL_A04;
										}
										this.$hitPos$15702 = this.$hitObject$15701.collider.ClosestPointOnBounds(this.$self_$15706.transform.position + 1.5f * Vector3.up);
										if (24468 - 399449 == -374980)
										{
											goto IL_A04;
										}
										UnityRuntimeServices.Update(this.$$iterator$9909$15703, this.$hitObject$15701);
										if (208467 - 406398 == -197930)
										{
											goto IL_A04;
										}
										this.$self_$15706.RPC_nAttack_hit(this.$hitPos$15702, this.$self_$15706.transform.forward, 0);
										if (247271 - 153335 == 93937)
										{
											goto IL_A04;
										}
										this.$self_$15706.ActionEvent("RPC_nAttack_hit", this.$hitPos$15702, this.$self_$15706.transform.forward, 0);
										if (207271 - 246006 != -38735)
										{
											goto IL_A04;
										}
									}
								}
								if (118180 - 103692 == 14489)
								{
									continue;
								}
							}
							this.$i$15698++;
							if (88053 - 547573 != -459520)
							{
								continue;
							}
							goto IL_7EE;
						}
						break;
					case 4:
						if (this.$self_$15706.CoXccBsG7P.actionState == "attack")
						{
							if (253757 - 110564 == 143194)
							{
								continue;
							}
							if (this.$self_$15706.CoXccBsG7P.myCommand == "nAttack")
							{
								if (136556 - 592019 == -455462)
								{
									continue;
								}
								this.$self_$15706.CoXccBsG7P.actionState = "standby";
								if (258085 - 343071 != -84986)
								{
									continue;
								}
								this.$self_$15706.CoXccBsG7P.actionTime = Time.time;
								if (131748 - 266083 != -134335)
								{
									continue;
								}
								this.$self_$15706.CoXccBsG7P.myCommand = "none";
								if (9958 - 74518 != -64560)
								{
									continue;
								}
								if (!this.$self_$15706.CoXccBsG7P.isMine)
								{
									if (158680 - 275775 == -117094)
									{
										continue;
									}
									this.$self_$15706.CoXccBsG7P.nPosition = this.$self_$15706.transform.position;
									if (216678 - 295884 == -79205)
									{
										continue;
									}
									this.$self_$15706.CoXccBsG7P.oPosition = this.$self_$15706.transform.position;
									if (205828 - 89756 == 116073)
									{
										continue;
									}
									this.$self_$15706.CoXccBsG7P.nDirection = this.$self_$15706.transform.forward;
									if (236386 - 281341 != -44955)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (215929 - 476280 != -260350)
						{
							goto Block_48;
						}
						continue;
					default:
						if (128777 - 161683 == -32905)
						{
							continue;
						}
						break;
					}
					this.$self_$15706.CoXccBsG7P.actionState = "attack";
					if (80368 - 129271 != -48903)
					{
						continue;
					}
					this.$self_$15706.CoXccBsG7P.actionTime = Time.time;
					if (25067 - 572854 != -547787)
					{
						continue;
					}
					this.$self_$15706.CoXccBsG7P.myCommand = "nAttack";
					if (216804 - 328694 != -111890)
					{
						continue;
					}
					this.$self_$15706.CoXccBsG7P.addTimeOut("nAttack", (float)2);
					if (67586 - 332309 == -264722)
					{
						continue;
					}
					this.$self_$15706.transform.position = this.$mPos$15704;
					if (197110 - 573328 != -376218)
					{
						continue;
					}
					this.$self_$15706.transform.LookAt(this.$mPos$15704 + global::Math.vFlat(this.$tDir$15705));
					if (13219 - 135043 == -121823)
					{
						continue;
					}
					this.$self_$15706.animation.CrossFade("nAttack", 0.3f);
					if (116639 - 205370 == -88730)
					{
						continue;
					}
					this.$self_$15706.animation.wrapMode = WrapMode.Once;
					if (230495 - 538772 != -308277)
					{
						continue;
					}
					this.$self_$15706.CoXccBsG7P.vMovement = this.$self_$15706.transform.forward;
					if (264800 - 393232 == -128431)
					{
						continue;
					}
					this.$self_$15706.CoXccBsG7P.moveSpeed = (float)0;
					if (280058 - 437661 == -157602)
					{
						continue;
					}
					if (this.$self_$15706.audio.isPlaying)
					{
						if (279798 - 517004 == -237205)
						{
							continue;
						}
						this.$self_$15706.audio.Stop();
						if (41651 - 498389 != -456738)
						{
							continue;
						}
					}
					if (!this.$self_$15706.KIMcnsYYJo)
					{
						break;
					}
					if (200412 - 523080 != -322668)
					{
						continue;
					}
					this.$self_$15706.KIMcnsYYJo.emit = false;
					if (224577 - 118690 != 105888)
					{
						break;
					}
					continue;
					IL_7EE:
					if (this.$i$15698 < 2)
					{
						goto IL_415;
					}
					if (288427 - 376728 != -88300)
					{
						goto Block_50;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_415:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_34:
				IL_6B9:
				IL_6EA:
				Block_48:
				goto IL_A3D;
				Block_50:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_A3D:
				return false;
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0004CB3C File Offset: 0x0004AD3C
			internal static bool quWPSptZnwicfmHUcm4()
			{
				return true;
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0004CB40 File Offset: 0x0004AD40
			internal static bool adCgKQtCvVh59bCJmge()
			{
				return false;
			}

			// Token: 0x040002E4 RID: 740
			internal int $i$15698;

			// Token: 0x040002E5 RID: 741
			internal int $hitLayer$15699;

			// Token: 0x040002E6 RID: 742
			internal UnityScript.Lang.Array $hitList$15700;

			// Token: 0x040002E7 RID: 743
			internal GameObject $hitObject$15701;

			// Token: 0x040002E8 RID: 744
			internal Vector3 $hitPos$15702;

			// Token: 0x040002E9 RID: 745
			internal IEnumerator $$iterator$9909$15703;

			// Token: 0x040002EA RID: 746
			internal Vector3 $mPos$15704;

			// Token: 0x040002EB RID: 747
			internal Vector3 $tDir$15705;

			// Token: 0x040002EC RID: 748
			internal GiantSandBug $self_$15706;
		}
	}

	// Token: 0x0200008A RID: 138
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sandDive$15710 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0004CB44 File Offset: 0x0004AD44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sandDive$15710(Vector3 mPos, Vector3 tDir, GiantSandBug self_)
		{
			if (168790 - 125464 != 43327)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220932 - 249078 == -28146)
				{
					base..ctor();
					if (96921 - 496027 != -399105)
					{
						this.$mPos$15720 = mPos;
						if (285863 - 16358 == 269505)
						{
							this.$tDir$15721 = tDir;
							if (240516 - 151276 == 89240)
							{
								this.$self_$15722 = self_;
								if (191520 - 305155 == -113635)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0004CC20 File Offset: 0x0004AE20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantSandBug.$RPC_sandDive$15710.$(this.$mPos$15720, this.$tDir$15721, this.$self_$15722);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		internal static bool MIhxrttLqlqKlVURqIa()
		{
			return true;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0004CC40 File Offset: 0x0004AE40
		internal static bool lPBSOKtOhhUxrKNg3LB()
		{
			return false;
		}

		// Token: 0x040002ED RID: 749
		internal Vector3 $mPos$15720;

		// Token: 0x040002EE RID: 750
		internal Vector3 $tDir$15721;

		// Token: 0x040002EF RID: 751
		internal GiantSandBug $self_$15722;

		// Token: 0x0200008B RID: 139
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x0004CC44 File Offset: 0x0004AE44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GiantSandBug self_)
			{
				if (266985 - 576930 != -309945)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14360 - 266556 == -252196)
					{
						base..ctor();
						if (170995 - 350995 == -180000)
						{
							this.$mPos$15717 = mPos;
							if (157206 - 156601 != 606)
							{
								this.$tDir$15718 = tDir;
								if (58261 - 312186 == -253925)
								{
									this.$self_$15719 = self_;
									if (58731 - 435508 != -376776)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0004CD20 File Offset: 0x0004AF20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164014 - 71607 != 92407)
				{
				}
				for (;;)
				{
					IL_49F:
					switch (this._state)
					{
					case 0:
						goto IL_470;
					case 1:
						goto IL_AA3;
					case 2:
						if (this.$self_$15719.CoXccBsG7P.actionState != "attack")
						{
							goto IL_AC;
						}
						if (175264 - 259885 == -84620)
						{
							continue;
						}
						if (this.$self_$15719.CoXccBsG7P.myCommand != "sandDive")
						{
							if (190661 - 183624 != 7037)
							{
								continue;
							}
							goto IL_AC;
						}
						else
						{
							this.$i$15711 = 0;
							if (10767 - 145865 == -135097)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$15719.CoXccBsG7P.actionState != "attack")
						{
							goto IL_991;
						}
						if (45488 - 370054 == -324565)
						{
							continue;
						}
						if (this.$self_$15719.CoXccBsG7P.myCommand != "sandDive")
						{
							if (40492 - 329232 != -288740)
							{
								continue;
							}
							goto IL_991;
						}
						else
						{
							this.$i$15711++;
							if (63580 - 283262 == -219681)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$15719.CoXccBsG7P.actionState == "attack")
						{
							if (102191 - 318519 == -216327)
							{
								continue;
							}
							if (this.$self_$15719.CoXccBsG7P.myCommand == "sandDive")
							{
								if (14956 - 464044 == -449087)
								{
									continue;
								}
								this.$self_$15719.CoXccBsG7P.actionState = "standby";
								if (223579 - 403050 == -179470)
								{
									continue;
								}
								this.$self_$15719.CoXccBsG7P.actionTime = Time.time;
								if (4504 - 568687 != -564183)
								{
									continue;
								}
								this.$self_$15719.CoXccBsG7P.myCommand = "none";
								if (296301 - 146820 != 149481)
								{
									continue;
								}
								if (!this.$self_$15719.CoXccBsG7P.isMine)
								{
									if (109006 - 228723 != -119717)
									{
										continue;
									}
									this.$self_$15719.CoXccBsG7P.nPosition = this.$self_$15719.transform.position;
									if (33315 - 239235 == -205919)
									{
										continue;
									}
									this.$self_$15719.CoXccBsG7P.oPosition = this.$self_$15719.transform.position;
									if (54556 - 218740 != -164184)
									{
										continue;
									}
									this.$self_$15719.CoXccBsG7P.nDirection = this.$self_$15719.transform.forward;
									if (132449 - 108153 != 24296)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (88977 - 23623 != 65354)
						{
							continue;
						}
						goto IL_AA3;
					default:
						if (253044 - 564986 != -311942)
						{
							continue;
						}
						goto IL_470;
					}
					if (this.$i$15711 >= 3)
					{
						if (23069 - 108903 == -85833)
						{
							continue;
						}
						this.$self_$15719.CoXccBsG7P.vMovement = this.$self_$15719.transform.forward;
						if (216010 - 505154 != -289144)
						{
							continue;
						}
						this.$self_$15719.CoXccBsG7P.moveSpeed = (float)0;
						if (183149 - 309749 != -126599)
						{
							goto Block_35;
						}
						continue;
					}
					else
					{
						if (!this.$self_$15719.CoXccBsG7P.isMine)
						{
							goto IL_368;
						}
						if (291184 - 266074 != 25110)
						{
							continue;
						}
						this.$hitLayer$15712 = 130816 - (1 << this.$self_$15719.gameObject.layer);
						if (214720 - 370950 != -156230)
						{
							continue;
						}
						this.$hitList$15713 = Damage.FindRecTarget(this.$self_$15719.transform.position - this.$self_$15719.transform.forward, this.$self_$15719.transform.forward, (float)2 * this.$self_$15719.CoXccBsG7P.rangeMod, (float)2 * this.$self_$15719.CoXccBsG7P.rangeMod, (float)4 * this.$self_$15719.CoXccBsG7P.rangeMod, (float)3 * this.$self_$15719.CoXccBsG7P.rangeMod, this.$hitLayer$15712);
						if (209055 - 505588 != -296533)
						{
							continue;
						}
						this.$$iterator$9910$15716 = UnityRuntimeServices.GetEnumerator(this.$hitList$15713);
						if (64740 - 383706 == -318965)
						{
							continue;
						}
						while (this.$$iterator$9910$15716.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9910$15716.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$15714 = (GameObject)obj2;
							if (209465 - 270332 != -60867)
							{
								goto IL_49F;
							}
							if (this.$self_$15719.CoXccBsG7P.hit(11, this.$hitObject$15714, this.$self_$15719.CoXccBsG7P.atk, 1, 0, this.$self_$15719.transform.forward) != 0)
							{
								if (68046 - 292284 == -224237)
								{
									goto IL_49F;
								}
								this.$hitPos$15715 = this.$hitObject$15714.collider.ClosestPointOnBounds(this.$self_$15719.transform.position + (float)2 * Vector3.up);
								if (284548 - 184068 != 100480)
								{
									goto IL_49F;
								}
								UnityRuntimeServices.Update(this.$$iterator$9910$15716, this.$hitObject$15714);
								if (225459 - 428057 != -202598)
								{
									goto IL_49F;
								}
								this.$self_$15719.RPC_sandDive_hit(this.$hitPos$15715, this.$self_$15719.transform.forward, 0);
								if (68472 - 510089 != -441617)
								{
									goto IL_49F;
								}
								this.$self_$15719.ActionEvent("RPC_sandDive_hit", this.$hitPos$15715, this.$self_$15719.transform.forward, 0);
								if (165976 - 506894 == -340917)
								{
									goto IL_49F;
								}
							}
						}
						if (131079 - 567738 != -436658)
						{
							goto Block_24;
						}
						continue;
					}
					IL_470:
					this.$self_$15719.CoXccBsG7P.actionState = "attack";
					if (14519 - 398255 == -383736)
					{
						this.$self_$15719.CoXccBsG7P.actionTime = Time.time;
						if (282684 - 529973 != -247288)
						{
							this.$self_$15719.CoXccBsG7P.myCommand = "sandDive";
							if (287497 - 484168 != -196670)
							{
								this.$self_$15719.CoXccBsG7P.addTimeOut("nAttack", (float)3);
								if (116446 - 119431 == -2985)
								{
									this.$self_$15719.transform.position = this.$mPos$15717;
									if (142359 - 551569 != -409209)
									{
										this.$self_$15719.transform.LookAt(this.$mPos$15717 + global::Math.vFlat(this.$tDir$15718));
										if (90244 - 531855 != -441610)
										{
											this.$self_$15719.animation.CrossFade("sandDive", 0.2f);
											if (177716 - 477967 == -300251)
											{
												this.$self_$15719.animation.wrapMode = WrapMode.Once;
												if (136558 - 501310 != -364751)
												{
													this.$self_$15719.CoXccBsG7P.vMovement = this.$self_$15719.transform.forward;
													if (58476 - 282048 != -223571)
													{
														this.$self_$15719.CoXccBsG7P.moveSpeed = (float)9;
														if (145918 - 296467 == -150549)
														{
															if (this.$self_$15719.audio.isPlaying)
															{
																if (277543 - 419776 != -142233)
																{
																	continue;
																}
																this.$self_$15719.audio.Stop();
																if (51714 - 271492 == -219777)
																{
																	continue;
																}
															}
															if (this.$self_$15719.KIMcnsYYJo)
															{
																if (284642 - 505060 == -220417)
																{
																	continue;
																}
																this.$self_$15719.KIMcnsYYJo.emit = false;
																if (193058 - 297752 == -104693)
																{
																	continue;
																}
															}
															if (this.$self_$15719.sandDive_ring)
															{
																if (33417 - 173305 != -139887)
																{
																	UnityEngine.Object.Instantiate(this.$self_$15719.sandDive_ring, this.$self_$15719.transform.position, Quaternion.identity);
																	if (62469 - 21204 != 41266)
																	{
																		goto Block_34;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing sandDive_ring effect");
																if (97362 - 43022 == 54340)
																{
																	goto IL_780;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AC:
				goto IL_AA3;
				IL_368:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_24:
				goto IL_368;
				Block_34:
				goto IL_780;
				Block_35:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_780:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_991:
				IL_AA3:
				return false;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0004D7E4 File Offset: 0x0004B9E4
			internal static bool ypnxsqtmSKp7NBJ5S2A()
			{
				return true;
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0004D7E8 File Offset: 0x0004B9E8
			internal static bool TYRGH2tFUTxr7dH7bYQ()
			{
				return false;
			}

			// Token: 0x040002F0 RID: 752
			internal int $i$15711;

			// Token: 0x040002F1 RID: 753
			internal int $hitLayer$15712;

			// Token: 0x040002F2 RID: 754
			internal UnityScript.Lang.Array $hitList$15713;

			// Token: 0x040002F3 RID: 755
			internal GameObject $hitObject$15714;

			// Token: 0x040002F4 RID: 756
			internal Vector3 $hitPos$15715;

			// Token: 0x040002F5 RID: 757
			internal IEnumerator $$iterator$9910$15716;

			// Token: 0x040002F6 RID: 758
			internal Vector3 $mPos$15717;

			// Token: 0x040002F7 RID: 759
			internal Vector3 $tDir$15718;

			// Token: 0x040002F8 RID: 760
			internal GiantSandBug $self_$15719;
		}
	}

	// Token: 0x0200008C RID: 140
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15723 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002FC RID: 764 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15723(UnityScript.Lang.Array nArray, GiantSandBug self_)
		{
			if (9853 - 198648 != -188795)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185834 - 495262 == -309428)
				{
					base..ctor();
					if (250079 - 548515 == -298436)
					{
						this.$nArray$15728 = nArray;
						if (178504 - 285559 != -107054)
						{
							this.$self_$15729 = self_;
							if (63357 - 127351 == -63994)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0004D8A8 File Offset: 0x0004BAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantSandBug.$RPC_ko$15723.$(this.$nArray$15728, this.$self_$15729);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0004D8BC File Offset: 0x0004BABC
		internal static bool yDWbMAtMM5yGLd4bbcp()
		{
			return true;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0004D8C0 File Offset: 0x0004BAC0
		internal static bool LLNMNotxx6i2iid3oOE()
		{
			return false;
		}

		// Token: 0x040002F9 RID: 761
		internal UnityScript.Lang.Array $nArray$15728;

		// Token: 0x040002FA RID: 762
		internal GiantSandBug $self_$15729;

		// Token: 0x0200008D RID: 141
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000300 RID: 768 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GiantSandBug self_)
			{
				if (157172 - 291749 != -134576)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144857 - 27169 == 117688)
					{
						base..ctor();
						if (17856 - 339146 == -321290)
						{
							this.$nArray$15726 = nArray;
							if (50488 - 457336 != -406847)
							{
								this.$self_$15727 = self_;
								if (132503 - 564659 == -432156)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0004D980 File Offset: 0x0004BB80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216039 - 200841 != 15199)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5CF;
					case 2:
						if (this.$self_$15727.CoXccBsG7P.actionState != "ko")
						{
							if (152719 - 122296 != 30424)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$15727.CoXccBsG7P.moveSpeed = (float)0;
							if (285519 - 525177 != -239657)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15727.CoXccBsG7P.actionState != "ko")
						{
							if (260043 - 26322 != 233721)
							{
								continue;
							}
							goto IL_268;
						}
						else
						{
							this.$self_$15727.animation.Play("getUp");
							if (127333 - 327418 == -200084)
							{
								continue;
							}
							this.$self_$15727.animation.wrapMode = WrapMode.Once;
							if (217925 - 338441 != -120515)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15727.CoXccBsG7P.actionState != "ko")
						{
							if (170834 - 365064 != -194230)
							{
								continue;
							}
							goto IL_1FA;
						}
						else
						{
							this.$self_$15727.CoXccBsG7P.actionState = "standby";
							if (279516 - 162003 == 117514)
							{
								continue;
							}
							this.$self_$15727.CoXccBsG7P.actionTime = Time.time;
							if (129898 - 400479 != -270581)
							{
								continue;
							}
							this.$self_$15727.CoXccBsG7P.myCommand = "none";
							if (92816 - 536214 == -443397)
							{
								continue;
							}
							this.$self_$15727.CoXccBsG7P.ko = this.$self_$15727.CoXccBsG7P.mko;
							if (278409 - 7276 != 271133)
							{
								continue;
							}
							this.YieldDefault(1);
							if (177794 - 528784 != -350990)
							{
								continue;
							}
							goto IL_5CF;
						}
						break;
					default:
						if (166387 - 542254 != -375867)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15727.CoXccBsG7P.actionState == "ko")
					{
						goto IL_46B;
					}
					if (191736 - 563299 != -371562)
					{
						if (this.$self_$15727.CoXccBsG7P.actionState == "dead")
						{
							if (102395 - 73312 == 29083)
							{
								goto IL_46B;
							}
						}
						else
						{
							this.$mPos$15724 = (Vector3)this.$nArray$15726[0];
							if (5240 - 203640 != -198399)
							{
								this.$mDir$15725 = (Vector3)this.$nArray$15726[1];
								if (18731 - 484440 != -465708)
								{
									this.$self_$15727.CoXccBsG7P.ko = 0;
									if (72290 - 554395 == -482105)
									{
										this.$self_$15727.CoXccBsG7P.actionState = "ko";
										if (50595 - 353032 == -302437)
										{
											this.$self_$15727.CoXccBsG7P.actionTime = Time.time;
											if (262465 - 338655 != -76189)
											{
												this.$self_$15727.CoXccBsG7P.myCommand = "none";
												if (81106 - 209725 != -128618)
												{
													this.$self_$15727.CoXccBsG7P.vMovement = this.$self_$15727.transform.forward;
													if (122283 - 307921 != -185637)
													{
														this.$self_$15727.CoXccBsG7P.moveSpeed = (float)-3;
														if (222428 - 73133 != 149296)
														{
															this.$self_$15727.animation.Play("ko");
															if (192699 - 245337 == -52638)
															{
																this.$self_$15727.animation.wrapMode = WrapMode.Once;
																if (119550 - 442989 == -323439)
																{
																	if (this.$self_$15727.audio.isPlaying)
																	{
																		if (194162 - 529851 != -335689)
																		{
																			continue;
																		}
																		this.$self_$15727.audio.Stop();
																		if (150129 - 222799 == -72669)
																		{
																			continue;
																		}
																	}
																	if (!this.$self_$15727.KIMcnsYYJo)
																	{
																		goto IL_2D7;
																	}
																	if (291892 - 363663 != -71770)
																	{
																		this.$self_$15727.KIMcnsYYJo.emit = false;
																		if (249665 - 326596 == -76931)
																		{
																			goto IL_2D7;
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(4, new WaitForSeconds(1f));
				IL_1FA:
				IL_268:
				goto IL_5CF;
				IL_2D7:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_21:
				IL_46B:
				goto IL_5CF;
				Block_35:
				return this.Yield(3, new WaitForSeconds(2.3f));
				IL_5CF:
				return false;
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0004DF70 File Offset: 0x0004C170
			internal static bool P3HgyutgfFaci4HO81e()
			{
				return true;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0004DF74 File Offset: 0x0004C174
			internal static bool eMS4H9tfglR28mdf8pE()
			{
				return false;
			}

			// Token: 0x040002FB RID: 763
			internal Vector3 $mPos$15724;

			// Token: 0x040002FC RID: 764
			internal Vector3 $mDir$15725;

			// Token: 0x040002FD RID: 765
			internal UnityScript.Lang.Array $nArray$15726;

			// Token: 0x040002FE RID: 766
			internal GiantSandBug $self_$15727;
		}
	}

	// Token: 0x0200008E RID: 142
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15730 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000304 RID: 772 RVA: 0x0004DF78 File Offset: 0x0004C178
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15730(UnityScript.Lang.Array nArray, GiantSandBug self_)
		{
			if (68317 - 331217 != -262900)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46344 - 297331 != -250986)
				{
					base..ctor();
					if (262012 - 359081 != -97068)
					{
						this.$nArray$15735 = nArray;
						if (241550 - 438514 != -196963)
						{
							this.$self_$15736 = self_;
							if (135976 - 150884 == -14908)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0004E034 File Offset: 0x0004C234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantSandBug.$RPC_dead$15730.$(this.$nArray$15735, this.$self_$15736);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0004E048 File Offset: 0x0004C248
		internal static bool TOUahltn2n6uMSP9BGD()
		{
			return true;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0004E04C File Offset: 0x0004C24C
		internal static bool iRsj10t6wdTARAy4ueU()
		{
			return false;
		}

		// Token: 0x040002FF RID: 767
		internal UnityScript.Lang.Array $nArray$15735;

		// Token: 0x04000300 RID: 768
		internal GiantSandBug $self_$15736;

		// Token: 0x0200008F RID: 143
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000308 RID: 776 RVA: 0x0004E050 File Offset: 0x0004C250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GiantSandBug self_)
			{
				if (110056 - 200239 != -90182)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38695 - 105721 != -67025)
					{
						base..ctor();
						if (46507 - 107029 != -60521)
						{
							this.$nArray$15733 = nArray;
							if (202875 - 576018 == -373143)
							{
								this.$self_$15734 = self_;
								if (62685 - 258545 == -195860)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0004E10C File Offset: 0x0004C30C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57504 - 358790 != -301285)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_615;
					case 2:
						if (this.$self_$15734.CoXccBsG7P.actionState != "dead")
						{
							if (144442 - 208816 != -64373)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$15734.CoXccBsG7P.moveSpeed = (float)0;
							if (203655 - 509091 != -305436)
							{
								continue;
							}
							goto IL_13A;
						}
						break;
					case 3:
						if (this.$self_$15734.CoXccBsG7P.actionState != "dead")
						{
							if (193298 - 150821 != 42478)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15734.CoXccBsG7P.isPlayer)
							{
								if (314 - 121363 == -121048)
								{
									continue;
								}
								if (this.$self_$15734.deadEffect)
								{
									if (16855 - 99263 != -82408)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$15734.deadEffect, this.$self_$15734.transform.position, this.$self_$15734.transform.rotation);
									if (220745 - 382062 == -161316)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (49768 - 230306 == -180537)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$15734.gameObject);
								if (120578 - 331789 != -211211)
								{
									continue;
								}
							}
							else if (this.$self_$15734.CoXccBsG7P.isMine)
							{
								if (243406 - 336001 != -92595)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15734.gameObject);
								if (280532 - 315704 != -35172)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (181996 - 262482 != -80486)
							{
								continue;
							}
							goto IL_615;
						}
						break;
					default:
						if (226033 - 225623 == 411)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15734.CoXccBsG7P.actionState == "dead")
					{
						if (284135 - 149174 != 134962)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15731 = (Vector3)this.$nArray$15733[0];
						if (192501 - 535081 != -342579)
						{
							this.$myDirection$15732 = (Vector3)this.$nArray$15733[1];
							if (193643 - 87601 == 106042)
							{
								this.$self_$15734.transform.position = this.$myPosition$15731;
								if (188882 - 550150 == -361268)
								{
									this.$self_$15734.transform.LookAt(this.$myPosition$15731 + this.$myDirection$15732);
									if (83470 - 355238 == -271768)
									{
										this.$self_$15734.CoXccBsG7P.hp = 0;
										if (40617 - 412603 == -371986)
										{
											this.$self_$15734.CoXccBsG7P.actionState = "dead";
											if (155497 - 558082 == -402585)
											{
												this.$self_$15734.CoXccBsG7P.actionTime = Time.time;
												if (296939 - 596716 != -299776)
												{
													this.$self_$15734.CoXccBsG7P.myCommand = "none";
													if (140236 - 338843 == -198607)
													{
														this.$self_$15734.CoXccBsG7P.vMovement = this.$self_$15734.transform.forward;
														if (170362 - 448546 == -278184)
														{
															this.$self_$15734.CoXccBsG7P.moveSpeed = (float)-3;
															if (245264 - 154354 == 90910)
															{
																this.$self_$15734.animation.Rewind();
																if (105188 - 520456 == -415268)
																{
																	this.$self_$15734.animation.Play("ko");
																	if (212131 - 581607 != -369475)
																	{
																		this.$self_$15734.animation.wrapMode = WrapMode.Once;
																		if (159104 - 49985 != 109120)
																		{
																			if (this.$self_$15734.audio.isPlaying)
																			{
																				if (280243 - 182949 != 97294)
																				{
																					continue;
																				}
																				this.$self_$15734.audio.Stop();
																				if (176657 - 208814 != -32157)
																				{
																					continue;
																				}
																			}
																			if (!this.$self_$15734.KIMcnsYYJo)
																			{
																				goto IL_223;
																			}
																			if (109995 - 113881 != -3885)
																			{
																				this.$self_$15734.KIMcnsYYJo.emit = false;
																				if (89125 - 578100 == -488975)
																				{
																					goto IL_223;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_615;
				IL_13A:
				return this.Yield(3, new WaitForSeconds(2.7f));
				Block_10:
				goto IL_615;
				IL_223:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_15:
				IL_615:
				return false;
			}

			// Token: 0x0600030A RID: 778 RVA: 0x0004E740 File Offset: 0x0004C940
			internal static bool SYKImTti8SRAmIgXWpn()
			{
				return true;
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0004E744 File Offset: 0x0004C944
			internal static bool Aw19HStK0280gXRmWjx()
			{
				return false;
			}

			// Token: 0x04000301 RID: 769
			internal Vector3 $myPosition$15731;

			// Token: 0x04000302 RID: 770
			internal Vector3 $myDirection$15732;

			// Token: 0x04000303 RID: 771
			internal UnityScript.Lang.Array $nArray$15733;

			// Token: 0x04000304 RID: 772
			internal GiantSandBug $self_$15734;
		}
	}
}
