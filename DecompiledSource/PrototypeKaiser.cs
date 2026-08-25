using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000ECE RID: 3790
[Serializable]
public class PrototypeKaiser : MonoBehaviour
{
	// Token: 0x060055EA RID: 21994 RVA: 0x00A66CA8 File Offset: 0x00A64EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PrototypeKaiser()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x00A66CB8 File Offset: 0x00A64EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (122846 - 295628 != -172782)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (61785 - 592390 == -530605)
			{
				this.mChar.actionState = "standby";
				if (159910 - 271963 == -112053)
				{
					this.mChar.actionTime = Time.time;
					if (177806 - 433834 == -256028)
					{
						this.mChar.myCommand = "none";
						if (243142 - 324895 == -81753)
						{
							this.mChar.hp = (this.mChar.mhp = 1450);
							if (98315 - 167128 == -68813)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x00A66DDC File Offset: 0x00A64FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x00A66DF8 File Offset: 0x00A64FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_left);
		}
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x00A66E1C File Offset: 0x00A6501C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_right);
		}
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x00A66E40 File Offset: 0x00A65040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (129412 - 112266 != 17147)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (46749 - 142719 != -95970)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (253265 - 512714 == -259448)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2D9;
					}
					if (168479 - 384293 != -215814)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (244475 - 282631 == -38155)
				{
					continue;
				}
			}
			IL_2D9:
			if (this.mChar.hp <= 0)
			{
				if (66378 - 63893 == 2486)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (156547 - 360139 != -203592)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (276957 - 512302 != -235345)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (267987 - 438823 == -170835)
						{
							continue;
						}
						if (status != null)
						{
							if (69959 - 401470 != -331511)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (111282 - 567710 != -456428)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (139720 - 316272 == -176551)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (277571 - 171051 != 106520)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (25339 - 60947 != -35607)
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
							if (143965 - 342388 != -198423)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (117114 - 504253 != -387139)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (7201 - 61416 != -54215)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (29409 - 128560 != -99151)
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
			if (155455 - 207233 == -51778)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (208208 - 18775 == 189433)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (180735 - 274248 != -93512)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (181053 - 491104 != -310050)
						{
							if (this.mChar.isMine)
							{
								if (284846 - 354105 == -69259)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (135627 - 32374 != 103254)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (95694 - 452174 != -356479)
										{
											this.mChar.KoEvent();
											if (263376 - 573722 != -310345)
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
								if (239335 - 505988 != -266652)
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

	// Token: 0x060055F0 RID: 22000 RVA: 0x00A67340 File Offset: 0x00A65540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (136833 - 596539 != -459706)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (218279 - 492912 == -274633)
			{
				float runSpeed = this.mChar.runSpeed;
				if (114711 - 462324 != -347612)
				{
					Vector3 a = default(Vector3);
					if (148096 - 17737 != 130360)
					{
						Vector3 vector = Vector3.zero;
						if (61828 - 172857 == -111029)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (78115 - 232380 == -154265)
							{
								if (this.mChar.isMine)
								{
									if (139570 - 262536 == -122965)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (292095 - 158048 == 134048)
									{
										continue;
									}
									a.y = (float)0;
									if (175393 - 235100 == -59706)
									{
										continue;
									}
									a = a.normalized;
									if (62736 - 581544 == -518807)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (87273 - 133550 != -46277)
									{
										continue;
									}
									vector = vector.normalized;
									if (236295 - 171156 != 65139)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (78331 - 354342 != -276011)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (298282 - 5960 != 292322)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (70195 - 306775 != -236580)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (59897 - 144580 != -84683)
										{
											continue;
										}
										this.animation.Play("run");
										if (16908 - 514784 != -497876)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (194457 - 468665 == -274207)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (144084 - 378002 == -233917)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (82575 - 383043 != -300468)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (264497 - 38741 == 225757)
											{
												continue;
											}
											num = (float)0;
											if (133685 - 114406 != 19279)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (280175 - 143840 == 136336)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (284815 - 427512 != -142697)
										{
											continue;
										}
									}
								}
								else
								{
									Vector3 vector2 = this.mChar.nPosition - this.transform.position;
									if (233217 - 229850 == 3368)
									{
										continue;
									}
									if (vector2.magnitude > runSpeed)
									{
										if (210790 - 256270 != -45480)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (5916 - 173267 != -167351)
										{
											continue;
										}
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (195062 - 452775 != -257713)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (77024 - 164324 != -87300)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (87483 - 511114 != -423631)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (157318 - 575939 == -418620)
											{
												continue;
											}
											num = (float)0;
											if (285830 - 303309 != -17479)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (121928 - 521443 != -399515)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (9449 - 144451 == -135001)
											{
												continue;
											}
											vector = lhs.normalized;
											if (268069 - 256708 == 11362)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector);
											if (98219 - 420313 == -322093)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.3f);
											if (228564 - 45656 != 182908)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (220259 - 107042 == 113218)
											{
												continue;
											}
										}
										else
										{
											vector = this.transform.forward;
											if (66427 - 75016 != -8589)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (275368 - 400397 == -125028)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (251102 - 540316 != -289214)
											{
												continue;
											}
										}
									}
								}
								this.mChar.vMovement = vector;
								if (272860 - 34566 == 238294)
								{
									this.mChar.moveSpeed = num;
									if (22097 - 156707 == -134610)
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

	// Token: 0x060055F1 RID: 22001 RVA: 0x00A67A84 File Offset: 0x00A65C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (297106 - 292283 != 4824)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (100142 - 352865 == -252723)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (165449 - 286266 != -120816)
				{
					if (83405 - 443551 == -360146)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (130565 - 177904 != -47339)
							{
								continue;
							}
							v = 1;
							if (234179 - 586680 == -352500)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (45295 - 170478 != -125183)
							{
								continue;
							}
							v = -1;
							if (118396 - 274187 == -155790)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kaiserCannon")
						{
							if (182740 - 449942 != -267202)
							{
								continue;
							}
							v = 11;
							if (224742 - 387975 == -163232)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kaiserCannon_hit")
						{
							if (33146 - 372290 != -339144)
							{
								continue;
							}
							v = -11;
							if (680 - 213106 == -212425)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (260858 - 287742 != -26883)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (207662 - 386835 != -179172)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (295240 - 558857 == -263617)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (29955 - 228284 != -198328)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (224425 - 510185 != -285759)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (287402 - 210421 == 76981)
											{
												Hashtable hashtable = new Hashtable();
												if (104145 - 404033 == -299888)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (141367 - 503211 == -361844)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (277113 - 313161 != -36047)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (103146 - 278859 == -175713)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (288271 - 319264 != -30992)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (18269 - 51115 != -32845)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (54132 - 352891 != -298758)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (282371 - 199078 == 83293)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (131615 - 91729 != 39887)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (260274 - 490161 == -229887)
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

	// Token: 0x060055F2 RID: 22002 RVA: 0x00A67F70 File Offset: 0x00A66170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (9503 - 554083 != -544579)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (25290 - 593200 == -567910)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (12706 - 434964 != -422257)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (212474 - 5375 == 207099)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (140435 - 449915 != -309479)
						{
							int num3 = num;
							if (157918 - 163018 == -5100)
							{
								if (num3 == 1)
								{
									if (268509 - 256691 != 11819)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (294608 - 57308 != 237301)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (143264 - 412749 != -269484)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (144777 - 9730 != 135048)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (137995 - 204015 != -66019)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (21500 - 250020 != -228519)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (46626 - 567503 != -520876)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (24051 - 296746 == -272695)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserCannon(vector, vector2, num2));
											if (183599 - 431940 == -248341)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (134929 - 333538 != -198608)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (95764 - 142708 != -46943)
										{
											this.RPC_kaiserCannon_hit(vector, vector2, num2);
											if (21909 - 308506 == -286597)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (135291 - 564088 == -428797)
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

	// Token: 0x060055F3 RID: 22003 RVA: 0x00A682F4 File Offset: 0x00A664F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (293813 - 366857 != -73044)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (90655 - 267829 != -177173)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (14089 - 370541 == -356452)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (216417 - 363563 == -147146)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (33237 - 480195 == -446958)
						{
							if (gameObject)
							{
								if (32429 - 525699 != -493270)
								{
									continue;
								}
								vector = global::Math.vFlat(gameObject.transform.position - this.transform.position);
								if (66160 - 151302 == -85141)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (78429 - 494645 != -416216)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (141936 - 193107 != -51171)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (273837 - 231753 == 42084)
							{
								if (vector.sqrMagnitude > (float)64)
								{
									if (204756 - 79411 != 125346)
									{
										this.StartCoroutine_Auto(this.RPC_kaiserCannon(this.transform.position, vector, 0));
										if (15131 - 261945 != -246813)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (243693 - 334289 != -90595)
											{
												this.ActionEvent("RPC_kaiserCannon", this.transform.position, vector, 0);
												if (30289 - 172174 == -141885)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (246232 - 31747 == 214485)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (229994 - 538152 == -308158)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (185955 - 157488 == 28467)
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

	// Token: 0x060055F4 RID: 22004 RVA: 0x00A68634 File Offset: 0x00A66834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x00A6864C File Offset: 0x00A6684C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x00A68664 File Offset: 0x00A66864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PrototypeKaiser.$RPC_nAttack$34656(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x00A68674 File Offset: 0x00A66874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (84980 - 45707 != 39273)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (183367 - 574945 != -391577)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (98871 - 4992 == 93879)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find nAttack_hit");
				if (206151 - 31415 == 174736)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x00A68734 File Offset: 0x00A66934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kaiserCannon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PrototypeKaiser.$RPC_kaiserCannon$34670(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x00A68744 File Offset: 0x00A66944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_kaiserCannon_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (249382 - 117922 != 131460)
		{
		}
		for (;;)
		{
			IL_107:
			if (this.kaiserCannon_hit)
			{
				if (140058 - 490339 != -350281)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.kaiserCannon_hit, hitPos, this.transform.rotation);
				if (131377 - 85697 == 45681)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find kaiserCannon_hit");
				if (40514 - 331070 == -290555)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (287476 - 163977 != 123500)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (200788 - 524688 == -323900)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)5, (float)5, layerMask);
					if (65932 - 86410 != -20477)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (293493 - 506514 != -213020)
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
								if (274687 - 310880 == -36192)
								{
									goto IL_107;
								}
								if (this.mChar.hit(21, gameObject, 50, 5, 0, (gameObject.transform.position - hitPos).normalized) != 0)
								{
									if (71571 - 535458 != -463887)
									{
										goto IL_107;
									}
									this.mChar.sp = this.mChar.sp + 1;
									if (175892 - 140646 == 35247)
									{
										goto IL_107;
									}
								}
							}
							if (177512 - 453818 != -276305)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x00A68988 File Offset: 0x00A66B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PrototypeKaiser.$RPC_ko$34679(nArray, this).GetEnumerator();
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x00A68998 File Offset: 0x00A66B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PrototypeKaiser.$RPC_dead$34686(nArray, this).GetEnumerator();
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x00A689A8 File Offset: 0x00A66BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x00A689AC File Offset: 0x00A66BAC
	internal static bool jYsjqp54HIErgXu8sFC3()
	{
		return true;
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x00A689B0 File Offset: 0x00A66BB0
	internal static bool G8II7A54WEURAw0NLr0E()
	{
		return false;
	}

	// Token: 0x04005EC6 RID: 24262
	public CharacterControl mChar;

	// Token: 0x04005EC7 RID: 24263
	public AudioClip footStep_left;

	// Token: 0x04005EC8 RID: 24264
	public AudioClip footStep_right;

	// Token: 0x04005EC9 RID: 24265
	public GameObject nAttack_hit;

	// Token: 0x04005ECA RID: 24266
	public GameObject kaiserCannon;

	// Token: 0x04005ECB RID: 24267
	public GameObject kaiserCannon_hit;

	// Token: 0x04005ECC RID: 24268
	public AudioClip kaiser_cryFx;

	// Token: 0x02000ECF RID: 3791
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34656 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055FF RID: 22015 RVA: 0x00A689B4 File Offset: 0x00A66BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34656(Vector3 mPos, Vector3 tDir, PrototypeKaiser self_)
		{
			if (220025 - 112381 != 107645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38070 - 346140 == -308070)
				{
					base..ctor();
					if (127526 - 396534 != -269007)
					{
						this.$mPos$34667 = mPos;
						if (85447 - 415046 != -329598)
						{
							this.$tDir$34668 = tDir;
							if (261910 - 460810 == -198900)
							{
								this.$self_$34669 = self_;
								if (236513 - 557040 == -320527)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00A68A90 File Offset: 0x00A66C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PrototypeKaiser.$RPC_nAttack$34656.$(this.$mPos$34667, this.$tDir$34668, this.$self_$34669);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x00A68AAC File Offset: 0x00A66CAC
		internal static bool kwrndv54ASmURxINLu8A()
		{
			return true;
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x00A68AB0 File Offset: 0x00A66CB0
		internal static bool I3Vr6l54ltaa8a5aE09b()
		{
			return false;
		}

		// Token: 0x04005ECD RID: 24269
		internal Vector3 $mPos$34667;

		// Token: 0x04005ECE RID: 24270
		internal Vector3 $tDir$34668;

		// Token: 0x04005ECF RID: 24271
		internal PrototypeKaiser $self_$34669;

		// Token: 0x02000ED0 RID: 3792
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005603 RID: 22019 RVA: 0x00A68AB4 File Offset: 0x00A66CB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PrototypeKaiser self_)
			{
				if (151363 - 388525 != -237161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99557 - 361552 != -261994)
					{
						base..ctor();
						if (236568 - 133334 != 103235)
						{
							this.$mPos$34664 = mPos;
							if (271603 - 506213 == -234610)
							{
								this.$tDir$34665 = tDir;
								if (153605 - 154236 == -631)
								{
									this.$self_$34666 = self_;
									if (58389 - 109105 != -50715)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005604 RID: 22020 RVA: 0x00A68B90 File Offset: 0x00A66D90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46833 - 30404 != 16429)
				{
				}
				for (;;)
				{
					IL_BFC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EA4;
					case 2:
						if (this.$self_$34666.mChar.actionState != "attack")
						{
							goto IL_638;
						}
						if (52036 - 443260 != -391224)
						{
							continue;
						}
						if (this.$self_$34666.mChar.myCommand != "nAttack")
						{
							if (244162 - 452226 != -208064)
							{
								continue;
							}
							goto IL_638;
						}
						else
						{
							this.$self_$34666.mChar.moveSpeed = (float)2;
							if (170976 - 341786 != -170810)
							{
								continue;
							}
							goto IL_FA;
						}
						break;
					case 3:
						if (this.$self_$34666.mChar.actionState != "attack")
						{
							goto IL_454;
						}
						if (266114 - 151997 != 114117)
						{
							continue;
						}
						if (this.$self_$34666.mChar.myCommand != "nAttack")
						{
							if (35100 - 192739 != -157638)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$self_$34666.mChar.moveSpeed = (float)0;
							if (86334 - 477304 != -390970)
							{
								continue;
							}
							this.$hitLayer$34657 = 130816 - (1 << this.$self_$34666.gameObject.layer);
							if (186501 - 430259 == -243757)
							{
								continue;
							}
							this.$hitList$34658 = null;
							if (289427 - 165665 == 123763)
							{
								continue;
							}
							this.$hitPos$34659 = default(Vector3);
							if (56803 - 51236 == 5568)
							{
								continue;
							}
							if (!this.$self_$34666.mChar.isMine)
							{
								goto IL_485;
							}
							if (117500 - 343813 == -226312)
							{
								continue;
							}
							this.$hitList$34658 = Damage.FindRecTarget(this.$self_$34666.transform.position + this.$self_$34666.transform.right, this.$self_$34666.transform.forward, (float)2 * this.$self_$34666.mChar.rangeMod, (float)2 * this.$self_$34666.mChar.rangeMod, (float)5 * this.$self_$34666.mChar.rangeMod, (float)3 * this.$self_$34666.mChar.rangeMod, this.$hitLayer$34657);
							if (126546 - 105371 == 21176)
							{
								continue;
							}
							this.$$iterator$10907$34661 = UnityRuntimeServices.GetEnumerator(this.$hitList$34658);
							if (80282 - 479142 == -398859)
							{
								continue;
							}
							while (this.$$iterator$10907$34661.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10907$34661.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34660 = (GameObject)obj2;
								if (209833 - 584108 == -374274)
								{
									goto IL_BFC;
								}
								if (this.$self_$34666.mChar.hit(1, this.$hitObject$34660, (int)(0.5f * (float)this.$self_$34666.mChar.atk), 1, 0, (float)2 * this.$self_$34666.transform.forward) != 0)
								{
									if (204197 - 249985 == -45787)
									{
										goto IL_BFC;
									}
									this.$self_$34666.mChar.sp = this.$self_$34666.mChar.sp + 1;
									if (217482 - 552167 == -334684)
									{
										goto IL_BFC;
									}
									this.$hitPos$34659 = this.$hitObject$34660.collider.ClosestPointOnBounds(this.$self_$34666.transform.position + this.$self_$34666.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (38121 - 124040 != -85919)
									{
										goto IL_BFC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10907$34661, this.$hitObject$34660);
									if (19625 - 31080 == -11454)
									{
										goto IL_BFC;
									}
									this.$self_$34666.RPC_nAttack_hit(this.$hitPos$34659, this.$self_$34666.transform.forward, 0);
									if (272924 - 3414 == 269511)
									{
										goto IL_BFC;
									}
									if (PhotonClient.IsInitialized())
									{
										if (17781 - 484716 == -466934)
										{
											goto IL_BFC;
										}
										this.$self_$34666.ActionEvent("RPC_nAttack_hit", this.$hitPos$34659, this.$self_$34666.transform.forward, 0);
										if (173253 - 598056 == -424802)
										{
											goto IL_BFC;
										}
									}
								}
							}
							if (202909 - 301436 != -98526)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34666.mChar.actionState != "attack")
						{
							goto IL_D20;
						}
						if (230425 - 209963 == 20463)
						{
							continue;
						}
						if (this.$self_$34666.mChar.myCommand != "nAttack")
						{
							if (293177 - 127887 != 165291)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$34666.mChar.moveSpeed = (float)3;
							if (13968 - 366271 != -352303)
							{
								continue;
							}
							goto IL_A97;
						}
						break;
					case 5:
						if (this.$self_$34666.mChar.actionState != "attack")
						{
							goto IL_C41;
						}
						if (211300 - 534152 == -322851)
						{
							continue;
						}
						if (this.$self_$34666.mChar.myCommand != "nAttack")
						{
							if (212050 - 284812 != -72761)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34666.mChar.isMine)
							{
								goto IL_786;
							}
							if (52023 - 2243 != 49780)
							{
								continue;
							}
							this.$hitList$34658 = Damage.FindRecTarget(this.$self_$34666.transform.position, this.$self_$34666.transform.forward, 1.5f * this.$self_$34666.mChar.rangeMod, 1.5f * this.$self_$34666.mChar.rangeMod, (float)4 * this.$self_$34666.mChar.rangeMod, (float)3 * this.$self_$34666.mChar.rangeMod, this.$hitLayer$34657);
							if (122597 - 225866 == -103268)
							{
								continue;
							}
							this.$$iterator$10908$34663 = UnityRuntimeServices.GetEnumerator(this.$hitList$34658);
							if (7400 - 302706 != -295306)
							{
								continue;
							}
							while (this.$$iterator$10908$34663.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10908$34663.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34662 = (GameObject)obj4;
								if (271827 - 237492 == 34336)
								{
									goto IL_BFC;
								}
								if (this.$self_$34666.mChar.hit(2, this.$hitObject$34662, (int)(0.6f * (float)this.$self_$34666.mChar.atk), 1, 0, (float)2 * this.$self_$34666.transform.forward) != 0)
								{
									if (103335 - 46829 != 56506)
									{
										goto IL_BFC;
									}
									this.$hitPos$34659 = this.$hitObject$34662.collider.ClosestPointOnBounds(this.$self_$34666.transform.position + this.$self_$34666.transform.TransformDirection(0.2f, (float)2, 2.4f));
									if (228335 - 552617 != -324282)
									{
										goto IL_BFC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10908$34663, this.$hitObject$34662);
									if (294758 - 592129 == -297370)
									{
										goto IL_BFC;
									}
									this.$self_$34666.RPC_nAttack_hit(this.$hitPos$34659, this.$self_$34666.transform.forward, 0);
									if (137588 - 435550 == -297961)
									{
										goto IL_BFC;
									}
									if (PhotonClient.IsInitialized())
									{
										if (119059 - 198586 == -79526)
										{
											goto IL_BFC;
										}
										this.$self_$34666.ActionEvent("RPC_nAttack_hit", this.$hitPos$34659, this.$self_$34666.transform.forward, 0);
										if (220705 - 72244 == 148462)
										{
											goto IL_BFC;
										}
									}
								}
							}
							if (251893 - 459393 != -207500)
							{
								continue;
							}
							goto IL_786;
						}
						break;
					case 6:
						if (this.$self_$34666.mChar.actionState != "attack")
						{
							goto IL_669;
						}
						if (26051 - 209782 == -183730)
						{
							continue;
						}
						if (this.$self_$34666.mChar.myCommand != "nAttack")
						{
							if (294289 - 138465 != 155824)
							{
								continue;
							}
							goto IL_669;
						}
						else
						{
							this.$self_$34666.mChar.moveSpeed = (float)0;
							if (171010 - 259669 != -88658)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$34666.mChar.actionState == "attack")
						{
							if (4463 - 591838 != -587375)
							{
								continue;
							}
							if (this.$self_$34666.mChar.myCommand == "nAttack")
							{
								if (53467 - 208476 != -155009)
								{
									continue;
								}
								this.$self_$34666.mChar.actionState = "standby";
								if (79706 - 247432 != -167726)
								{
									continue;
								}
								this.$self_$34666.mChar.actionTime = Time.time;
								if (219791 - 520106 != -300315)
								{
									continue;
								}
								this.$self_$34666.mChar.myCommand = "none";
								if (215012 - 292995 == -77982)
								{
									continue;
								}
								if (!this.$self_$34666.mChar.isMine)
								{
									if (222128 - 510955 != -288827)
									{
										continue;
									}
									this.$self_$34666.mChar.nPosition = this.$self_$34666.transform.position;
									if (286064 - 110287 != 175777)
									{
										continue;
									}
									this.$self_$34666.mChar.oPosition = this.$self_$34666.transform.position;
									if (86166 - 228661 != -142495)
									{
										continue;
									}
									this.$self_$34666.mChar.nDirection = this.$self_$34666.transform.forward;
									if (172908 - 525378 == -352469)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (231065 - 123602 != 107463)
						{
							continue;
						}
						goto IL_EA4;
					default:
						if (254812 - 164797 == 90016)
						{
							continue;
						}
						break;
					}
					this.$self_$34666.mChar.actionState = "attack";
					if (271110 - 438843 == -167733)
					{
						this.$self_$34666.mChar.actionTime = Time.time;
						if (53488 - 29351 != 24138)
						{
							this.$self_$34666.mChar.myCommand = "nAttack";
							if (134533 - 283119 != -148585)
							{
								this.$self_$34666.mChar.addTimeOut("nAttack", (float)4);
								if (185140 - 310831 != -125690)
								{
									this.$self_$34666.transform.position = this.$mPos$34664;
									if (17549 - 279637 == -262088)
									{
										this.$self_$34666.transform.LookAt(this.$mPos$34664 + global::Math.vFlat(this.$tDir$34665));
										if (4436 - 458997 != -454560)
										{
											this.$self_$34666.animation.CrossFade("punch");
											if (178551 - 489346 == -310795)
											{
												this.$self_$34666.animation.wrapMode = WrapMode.Once;
												if (155316 - 573224 == -417908)
												{
													this.$self_$34666.mChar.vMovement = this.$self_$34666.transform.forward;
													if (241573 - 779 != 240795)
													{
														this.$self_$34666.mChar.moveSpeed = (float)0;
														if (212716 - 209834 != 2883)
														{
															goto Block_52;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_FA:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_21:
				IL_454:
				goto IL_EA4;
				IL_485:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_638:
				IL_669:
				goto IL_EA4;
				Block_33:
				return this.Yield(7, new WaitForSeconds(0.2f));
				Block_38:
				goto IL_C41;
				IL_786:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_48:
				goto IL_485;
				Block_50:
				goto IL_454;
				Block_52:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_A97:
				return this.Yield(5, new WaitForSeconds(0.6f));
				IL_C41:
				IL_D20:
				IL_EA4:
				return false;
			}

			// Token: 0x06005605 RID: 22021 RVA: 0x00A69A54 File Offset: 0x00A67C54
			internal static bool NFjC0x54ywiBLX1YYHnM()
			{
				return true;
			}

			// Token: 0x06005606 RID: 22022 RVA: 0x00A69A58 File Offset: 0x00A67C58
			internal static bool w52S0G54S0GiH4eVHc5Y()
			{
				return false;
			}

			// Token: 0x04005ED0 RID: 24272
			internal int $hitLayer$34657;

			// Token: 0x04005ED1 RID: 24273
			internal UnityScript.Lang.Array $hitList$34658;

			// Token: 0x04005ED2 RID: 24274
			internal Vector3 $hitPos$34659;

			// Token: 0x04005ED3 RID: 24275
			internal GameObject $hitObject$34660;

			// Token: 0x04005ED4 RID: 24276
			internal IEnumerator $$iterator$10907$34661;

			// Token: 0x04005ED5 RID: 24277
			internal GameObject $hitObject$34662;

			// Token: 0x04005ED6 RID: 24278
			internal IEnumerator $$iterator$10908$34663;

			// Token: 0x04005ED7 RID: 24279
			internal Vector3 $mPos$34664;

			// Token: 0x04005ED8 RID: 24280
			internal Vector3 $tDir$34665;

			// Token: 0x04005ED9 RID: 24281
			internal PrototypeKaiser $self_$34666;
		}
	}

	// Token: 0x02000ED1 RID: 3793
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kaiserCannon$34670 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005607 RID: 22023 RVA: 0x00A69A5C File Offset: 0x00A67C5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kaiserCannon$34670(Vector3 mPos, Vector3 tDir, PrototypeKaiser self_)
		{
			if (55890 - 288634 != -232744)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45907 - 311097 == -265190)
				{
					base..ctor();
					if (88834 - 19493 == 69341)
					{
						this.$mPos$34676 = mPos;
						if (90863 - 277772 != -186908)
						{
							this.$tDir$34677 = tDir;
							if (185886 - 370410 == -184524)
							{
								this.$self_$34678 = self_;
								if (222817 - 518501 == -295684)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00A69B38 File Offset: 0x00A67D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PrototypeKaiser.$RPC_kaiserCannon$34670.$(this.$mPos$34676, this.$tDir$34677, this.$self_$34678);
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00A69B54 File Offset: 0x00A67D54
		internal static bool m8FV5n54o6JQa9ioVsmT()
		{
			return true;
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00A69B58 File Offset: 0x00A67D58
		internal static bool T5Ihx354EAgWyFuAD8cG()
		{
			return false;
		}

		// Token: 0x04005EDA RID: 24282
		internal Vector3 $mPos$34676;

		// Token: 0x04005EDB RID: 24283
		internal Vector3 $tDir$34677;

		// Token: 0x04005EDC RID: 24284
		internal PrototypeKaiser $self_$34678;

		// Token: 0x02000ED2 RID: 3794
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600560B RID: 22027 RVA: 0x00A69B5C File Offset: 0x00A67D5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PrototypeKaiser self_)
			{
				if (218679 - 452170 != -233490)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190491 - 452491 == -262000)
					{
						base..ctor();
						if (185120 - 193087 != -7966)
						{
							this.$mPos$34673 = mPos;
							if (30531 - 163365 != -132833)
							{
								this.$tDir$34674 = tDir;
								if (273630 - 372272 != -98641)
								{
									this.$self_$34675 = self_;
									if (67315 - 102780 != -35464)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600560C RID: 22028 RVA: 0x00A69C38 File Offset: 0x00A67E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258398 - 432743 != -174345)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_83C;
					case 2:
						if (this.$self_$34675.mChar.actionState != "attack")
						{
							goto IL_110;
						}
						if (147285 - 479169 != -331884)
						{
							continue;
						}
						if (this.$self_$34675.mChar.myCommand != "kaiserCannon")
						{
							if (237195 - 454557 != -217362)
							{
								continue;
							}
							goto IL_110;
						}
						else
						{
							if (this.$self_$34675.kaiserCannon)
							{
								if (110095 - 504589 != -394494)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34675.kaiserCannon, this.$self_$34675.transform.position + this.$self_$34675.transform.TransformDirection(-1.4f, 2.2f, 2.2f), this.$self_$34675.transform.rotation);
								if (236830 - 6641 != 230189)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34675.kaiserCannon, this.$self_$34675.transform.position + this.$self_$34675.transform.TransformDirection(1.4f, 2.2f, 2.2f), this.$self_$34675.transform.rotation);
								if (12360 - 6751 != 5609)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find kaiserCannon");
								if (239304 - 388857 != -149553)
								{
									continue;
								}
							}
							if (!this.$self_$34675.mChar.isMine)
							{
								goto IL_5B0;
							}
							if (263027 - 325915 != -62888)
							{
								continue;
							}
							this.$hitPos1$34671 = global::Math.getSpawnPos(this.$self_$34675.transform.position + this.$tDir$34674 + this.$self_$34675.transform.TransformDirection((float)-2, (float)0, (float)0));
							if (196325 - 524466 == -328140)
							{
								continue;
							}
							this.$hitPos2$34672 = global::Math.getSpawnPos(this.$self_$34675.transform.position + this.$tDir$34674 + this.$self_$34675.transform.TransformDirection((float)2, (float)0, (float)0));
							if (282910 - 247606 == 35305)
							{
								continue;
							}
							this.$self_$34675.RPC_kaiserCannon_hit(this.$hitPos1$34671, this.$self_$34675.transform.forward, 0);
							if (262508 - 165545 != 96963)
							{
								continue;
							}
							this.$self_$34675.RPC_kaiserCannon_hit(this.$hitPos2$34672, this.$self_$34675.transform.forward, 0);
							if (45232 - 470962 == -425729)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (115525 - 334850 != -219325)
								{
									continue;
								}
								this.$self_$34675.ActionEvent("RPC_kaiserCannon_hit", this.$hitPos1$34671, this.$self_$34675.transform.forward, 0);
								if (25194 - 492020 != -466826)
								{
									continue;
								}
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5B0;
							}
							if (22530 - 587069 != -564539)
							{
								continue;
							}
							this.$self_$34675.ActionEvent("RPC_kaiserCannon_hit", this.$hitPos2$34672, this.$self_$34675.transform.forward, 0);
							if (272057 - 124709 != 147349)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34675.mChar.actionState == "attack")
						{
							if (243003 - 59309 == 183695)
							{
								continue;
							}
							if (this.$self_$34675.mChar.myCommand == "kaiserCannon")
							{
								if (268598 - 479401 != -210803)
								{
									continue;
								}
								this.$self_$34675.mChar.actionState = "standby";
								if (64337 - 264263 != -199926)
								{
									continue;
								}
								this.$self_$34675.mChar.actionTime = Time.time;
								if (24622 - 52224 != -27602)
								{
									continue;
								}
								this.$self_$34675.mChar.myCommand = "none";
								if (34612 - 73029 == -38416)
								{
									continue;
								}
								if (!this.$self_$34675.mChar.isMine)
								{
									if (282858 - 386568 == -103709)
									{
										continue;
									}
									this.$self_$34675.mChar.nPosition = this.$self_$34675.transform.position;
									if (215759 - 418259 != -202500)
									{
										continue;
									}
									this.$self_$34675.mChar.oPosition = this.$self_$34675.transform.position;
									if (149063 - 105414 == 43650)
									{
										continue;
									}
									this.$self_$34675.mChar.nDirection = this.$self_$34675.transform.forward;
									if (84859 - 399860 == -315000)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (30586 - 67014 != -36427)
						{
							goto Block_25;
						}
						continue;
					default:
						if (293363 - 507077 == -213713)
						{
							continue;
						}
						break;
					}
					this.$self_$34675.mChar.actionState = "attack";
					if (29469 - 188250 != -158780)
					{
						this.$self_$34675.mChar.actionTime = Time.time;
						if (241012 - 581267 != -340254)
						{
							this.$self_$34675.mChar.myCommand = "kaiserCannon";
							if (204335 - 121577 != 82759)
							{
								this.$self_$34675.mChar.addTimeOut("nAttack", (float)4);
								if (247226 - 337897 == -90671)
								{
									this.$self_$34675.transform.position = this.$mPos$34673;
									if (18921 - 285441 != -266519)
									{
										this.$self_$34675.transform.LookAt(this.$mPos$34673 + global::Math.vFlat(this.$tDir$34674));
										if (71210 - 16936 == 54274)
										{
											this.$self_$34675.animation.CrossFade("cannon");
											if (57656 - 103611 != -45954)
											{
												this.$self_$34675.animation.wrapMode = WrapMode.Once;
												if (202449 - 18604 == 183845)
												{
													this.$self_$34675.mChar.vMovement = this.$self_$34675.transform.forward;
													if (160712 - 98627 == 62085)
													{
														this.$self_$34675.mChar.moveSpeed = (float)0;
														if (233271 - 261948 == -28677)
														{
															goto IL_77D;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_110:
				goto IL_83C;
				Block_17:
				goto IL_5B0;
				Block_25:
				goto IL_83C;
				IL_5B0:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_77D:
				return this.Yield(2, new WaitForSeconds(0.9f));
				IL_83C:
				return false;
			}

			// Token: 0x0600560D RID: 22029 RVA: 0x00A6A494 File Offset: 0x00A68694
			internal static bool lKi72e542Z11CqLxGLfy()
			{
				return true;
			}

			// Token: 0x0600560E RID: 22030 RVA: 0x00A6A498 File Offset: 0x00A68698
			internal static bool BLMHO0548gyG9uxN0OKt()
			{
				return false;
			}

			// Token: 0x04005EDD RID: 24285
			internal Vector3 $hitPos1$34671;

			// Token: 0x04005EDE RID: 24286
			internal Vector3 $hitPos2$34672;

			// Token: 0x04005EDF RID: 24287
			internal Vector3 $mPos$34673;

			// Token: 0x04005EE0 RID: 24288
			internal Vector3 $tDir$34674;

			// Token: 0x04005EE1 RID: 24289
			internal PrototypeKaiser $self_$34675;
		}
	}

	// Token: 0x02000ED3 RID: 3795
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34679 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600560F RID: 22031 RVA: 0x00A6A49C File Offset: 0x00A6869C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34679(UnityScript.Lang.Array nArray, PrototypeKaiser self_)
		{
			if (35097 - 275898 != -240801)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85821 - 483418 == -397597)
				{
					base..ctor();
					if (282429 - 239800 != 42630)
					{
						this.$nArray$34684 = nArray;
						if (193231 - 208165 == -14934)
						{
							this.$self_$34685 = self_;
							if (42232 - 377092 == -334860)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x00A6A558 File Offset: 0x00A68758
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PrototypeKaiser.$RPC_ko$34679.$(this.$nArray$34684, this.$self_$34685);
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00A6A56C File Offset: 0x00A6876C
		internal static bool G9x2K054Zt7uyAR7RaSX()
		{
			return true;
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00A6A570 File Offset: 0x00A68770
		internal static bool sbZjaF54CAIBnc00xtu6()
		{
			return false;
		}

		// Token: 0x04005EE2 RID: 24290
		internal UnityScript.Lang.Array $nArray$34684;

		// Token: 0x04005EE3 RID: 24291
		internal PrototypeKaiser $self_$34685;

		// Token: 0x02000ED4 RID: 3796
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005613 RID: 22035 RVA: 0x00A6A574 File Offset: 0x00A68774
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PrototypeKaiser self_)
			{
				if (53674 - 31677 != 21998)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272076 - 408835 != -136758)
					{
						base..ctor();
						if (58127 - 434352 == -376225)
						{
							this.$nArray$34682 = nArray;
							if (277643 - 30519 != 247125)
							{
								this.$self_$34683 = self_;
								if (73019 - 419069 != -346049)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005614 RID: 22036 RVA: 0x00A6A630 File Offset: 0x00A68830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266211 - 586490 != -320279)
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
						if (this.$self_$34683.mChar.actionState != "ko")
						{
							if (56718 - 490682 != -433963)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$self_$34683.animation.Play("getUp");
							if (153553 - 301860 == -148306)
							{
								continue;
							}
							this.$self_$34683.animation.wrapMode = WrapMode.Once;
							if (1911 - 454791 != -452880)
							{
								continue;
							}
							goto IL_CF;
						}
						break;
					case 3:
						if (this.$self_$34683.mChar.actionState != "ko")
						{
							if (228222 - 483461 != -255238)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$34683.mChar.actionState = "standby";
							if (261927 - 533975 == -272047)
							{
								continue;
							}
							this.$self_$34683.mChar.actionTime = Time.time;
							if (125184 - 383852 == -258667)
							{
								continue;
							}
							this.$self_$34683.mChar.myCommand = "none";
							if (156042 - 285775 != -129733)
							{
								continue;
							}
							this.$self_$34683.mChar.ko = this.$self_$34683.mChar.mko;
							if (233289 - 292543 != -59254)
							{
								continue;
							}
							this.YieldDefault(1);
							if (262265 - 334575 != -72309)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (134271 - 462756 == -328484)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34683.mChar.actionState == "ko")
					{
						goto IL_254;
					}
					if (265971 - 116668 == 149303)
					{
						if (this.$self_$34683.mChar.actionState == "dead")
						{
							if (125341 - 139701 != -14359)
							{
								goto Block_29;
							}
						}
						else
						{
							this.$mPos$34680 = (Vector3)this.$nArray$34682[0];
							if (205825 - 257746 != -51920)
							{
								this.$mDir$34681 = (Vector3)this.$nArray$34682[1];
								if (19171 - 385320 == -366149)
								{
									this.$self_$34683.mChar.ko = 0;
									if (142420 - 322249 != -179828)
									{
										this.$self_$34683.mChar.actionState = "ko";
										if (227330 - 583829 != -356498)
										{
											this.$self_$34683.mChar.actionTime = Time.time;
											if (38085 - 22083 == 16002)
											{
												this.$self_$34683.mChar.myCommand = "none";
												if (147282 - 218253 != -70970)
												{
													this.$self_$34683.mChar.vMovement = Vector3.zero;
													if (149598 - 265603 != -116004)
													{
														this.$self_$34683.mChar.moveSpeed = (float)0;
														if (17195 - 121151 == -103956)
														{
															this.$self_$34683.animation.Play("ko");
															if (168747 - 531431 == -362684)
															{
																this.$self_$34683.animation.wrapMode = WrapMode.Once;
																if (252633 - 381143 != -128509)
																{
																	if (!this.$self_$34683.kaiser_cryFx)
																	{
																		goto IL_4A1;
																	}
																	if (124131 - 64546 == 59585)
																	{
																		this.$self_$34683.audio.PlayOneShot(this.$self_$34683.kaiser_cryFx);
																		if (7163 - 20390 != -13226)
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
					}
				}
				IL_CF:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_7:
				IL_254:
				Block_16:
				goto IL_4F0;
				Block_23:
				goto IL_4A1;
				Block_29:
				goto IL_254;
				IL_4A1:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_31:
				IL_4F0:
				return false;
			}

			// Token: 0x06005615 RID: 22037 RVA: 0x00A6AB40 File Offset: 0x00A68D40
			internal static bool cHfWHn54LYNV7dT504qd()
			{
				return true;
			}

			// Token: 0x06005616 RID: 22038 RVA: 0x00A6AB44 File Offset: 0x00A68D44
			internal static bool dSw3QX54O7EkfttJ6Du6()
			{
				return false;
			}

			// Token: 0x04005EE4 RID: 24292
			internal Vector3 $mPos$34680;

			// Token: 0x04005EE5 RID: 24293
			internal Vector3 $mDir$34681;

			// Token: 0x04005EE6 RID: 24294
			internal UnityScript.Lang.Array $nArray$34682;

			// Token: 0x04005EE7 RID: 24295
			internal PrototypeKaiser $self_$34683;
		}
	}

	// Token: 0x02000ED5 RID: 3797
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34686 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005617 RID: 22039 RVA: 0x00A6AB48 File Offset: 0x00A68D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34686(UnityScript.Lang.Array nArray, PrototypeKaiser self_)
		{
			if (140013 - 272803 != -132789)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227744 - 239402 == -11658)
				{
					base..ctor();
					if (110862 - 76398 != 34465)
					{
						this.$nArray$34691 = nArray;
						if (193830 - 97155 != 96676)
						{
							this.$self_$34692 = self_;
							if (232620 - 199090 == 33530)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00A6AC04 File Offset: 0x00A68E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PrototypeKaiser.$RPC_dead$34686.$(this.$nArray$34691, this.$self_$34692);
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x00A6AC18 File Offset: 0x00A68E18
		internal static bool nXONS354maIOVAFEwd4i()
		{
			return true;
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00A6AC1C File Offset: 0x00A68E1C
		internal static bool JOXAoB54FkYO90olaxuW()
		{
			return false;
		}

		// Token: 0x04005EE8 RID: 24296
		internal UnityScript.Lang.Array $nArray$34691;

		// Token: 0x04005EE9 RID: 24297
		internal PrototypeKaiser $self_$34692;

		// Token: 0x02000ED6 RID: 3798
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600561B RID: 22043 RVA: 0x00A6AC20 File Offset: 0x00A68E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PrototypeKaiser self_)
			{
				if (173342 - 500722 != -327380)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143 - 475716 != -475572)
					{
						base..ctor();
						if (249874 - 110088 != 139787)
						{
							this.$nArray$34689 = nArray;
							if (67630 - 144662 != -77031)
							{
								this.$self_$34690 = self_;
								if (281862 - 283262 == -1400)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600561C RID: 22044 RVA: 0x00A6ACDC File Offset: 0x00A68EDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114535 - 405194 != -290658)
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
						if (this.$self_$34690.mChar.actionState != "dead")
						{
							if (117825 - 251450 != -133624)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34690.mChar.isPlayer)
							{
								if (196439 - 360134 != -163695)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34690.gameObject);
								if (193520 - 13708 != 179812)
								{
									continue;
								}
							}
							else if (this.$self_$34690.mChar.isMine)
							{
								if (96799 - 559686 != -462887)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34690.gameObject);
								if (10830 - 327934 == -317103)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (150737 - 281784 != -131046)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (2978 - 316669 == -313690)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34690.mChar.actionState == "dead")
					{
						if (284444 - 388573 != -104128)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34687 = (Vector3)this.$nArray$34689[0];
						if (51916 - 39561 == 12355)
						{
							this.$myDirection$34688 = (Vector3)this.$nArray$34689[1];
							if (98221 - 50055 == 48166)
							{
								this.$self_$34690.transform.position = this.$myPosition$34687;
								if (229158 - 53768 != 175391)
								{
									this.$self_$34690.transform.LookAt(this.$myPosition$34687 + this.$myDirection$34688);
									if (180815 - 139117 == 41698)
									{
										this.$self_$34690.mChar.hp = 0;
										if (36798 - 512297 == -475499)
										{
											this.$self_$34690.mChar.actionState = "dead";
											if (64262 - 66379 != -2116)
											{
												this.$self_$34690.mChar.actionTime = Time.time;
												if (282859 - 275507 != 7353)
												{
													this.$self_$34690.mChar.myCommand = "none";
													if (156980 - 320757 == -163777)
													{
														this.$self_$34690.mChar.vMovement = Vector3.zero;
														if (222101 - 340641 == -118540)
														{
															this.$self_$34690.mChar.moveSpeed = (float)0;
															if (175557 - 72176 == 103381)
															{
																this.$self_$34690.animation.Rewind();
																if (110196 - 419502 != -309305)
																{
																	this.$self_$34690.animation.Play("ko");
																	if (151704 - 362119 == -210415)
																	{
																		this.$self_$34690.animation.wrapMode = WrapMode.Once;
																		if (84861 - 252207 == -167346)
																		{
																			if (!this.$self_$34690.kaiser_cryFx)
																			{
																				goto IL_3E0;
																			}
																			if (37352 - 14193 == 23159)
																			{
																				this.$self_$34690.audio.PlayOneShot(this.$self_$34690.kaiser_cryFx);
																				if (190382 - 158725 == 31657)
																				{
																					goto IL_3E0;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				goto IL_493;
				IL_3E0:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_26:
				IL_493:
				return false;
			}

			// Token: 0x0600561D RID: 22045 RVA: 0x00A6B190 File Offset: 0x00A69390
			internal static bool ALDgLv54M77or4jDriuy()
			{
				return true;
			}

			// Token: 0x0600561E RID: 22046 RVA: 0x00A6B194 File Offset: 0x00A69394
			internal static bool FlcoNn54xN3HqvgtmQad()
			{
				return false;
			}

			// Token: 0x04005EEA RID: 24298
			internal Vector3 $myPosition$34687;

			// Token: 0x04005EEB RID: 24299
			internal Vector3 $myDirection$34688;

			// Token: 0x04005EEC RID: 24300
			internal UnityScript.Lang.Array $nArray$34689;

			// Token: 0x04005EED RID: 24301
			internal PrototypeKaiser $self_$34690;
		}
	}
}
