using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000413 RID: 1043
[Serializable]
public class FakeShadowGod : MonoBehaviour
{
	// Token: 0x06001857 RID: 6231 RVA: 0x0027F50C File Offset: 0x0027D70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeShadowGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x0027F51C File Offset: 0x0027D71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (237342 - 344276 != -106934)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (144001 - 568586 != -424584)
			{
				this.mChar.actionState = "standby";
				if (252864 - 377979 != -125114)
				{
					this.mChar.actionTime = Time.time;
					if (287447 - 62342 == 225105)
					{
						this.mChar.myCommand = "none";
						if (172272 - 97510 == 74762)
						{
							this.mChar.hp = (this.mChar.mhp = 333333);
							if (116117 - 593500 == -477383)
							{
								this.mChar.ko = (this.mChar.mko = 999);
								if (201854 - 297150 != -95295)
								{
									this.mChar.atk = 605;
									if (214827 - 536991 != -322163)
									{
										this.mChar.def = 454;
										if (157847 - 446683 == -288836)
										{
											this.mChar.agi = 320;
											if (211515 - 376227 == -164712)
											{
												this.mChar.vit = 33333;
												if (107191 - 70646 == 36545)
												{
													this.mChar.mag = 766;
													if (72765 - 389252 == -316487)
													{
														this.mChar.cha = 999;
														if (185226 - 72574 == 112652)
														{
															this.mChar.tal = 899;
															if (95089 - 422614 != -327524)
															{
																this.mChar.lck = 300;
																if (56068 - 215308 != -159239)
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

	// Token: 0x06001859 RID: 6233 RVA: 0x0027F7C8 File Offset: 0x0027D9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (38845 - 297319 != -258474)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (119790 - 244186 == -124395)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (122516 - 477007 != -354491)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (219781 - 421564 == -201783)
			{
				this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
				{
					"artCancel",
					"swallow",
					"paralysis",
					"needlePrison",
					"invisible",
					"petrify",
					"snowMan",
					"snowBall",
					"sleep",
					"charm",
					"mindControl",
					"coma"
				});
				if (134868 - 353998 != -219129)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x0027F90C File Offset: 0x0027DB0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (84145 - 84103 != 43)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (204283 - 315600 != -111317)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (142687 - 161877 != -19190)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_17D;
					}
					if (118298 - 22019 != 96279)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (71174 - 479936 != -408762)
				{
					continue;
				}
			}
			IL_17D:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (182431 - 161818 == 20613)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (202363 - 187506 == 14857)
				{
					if (this.mChar.isMine)
					{
						if (177616 - 158089 != 19528)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (167845 - 371394 != -203548)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (154807 - 509892 != -355084)
								{
									this.mChar.DeadEvent();
									if (196422 - 569711 == -373289)
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
						if (159090 - 470205 != -311114)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x0027FB4C File Offset: 0x0027DD4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (44900 - 291318 != -246417)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (90662 - 561425 == -470763)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (26999 - 431178 == -404179)
				{
					if (112858 - 92824 != 20035)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (57352 - 80157 == -22804)
							{
								continue;
							}
							v = 1;
							if (211958 - 9261 != 202697)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (104593 - 64039 != 40554)
							{
								continue;
							}
							v = -1;
							if (161279 - 499738 != -338459)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_randomCast")
						{
							if (110939 - 503750 == -392810)
							{
								continue;
							}
							v = 11;
							if (149440 - 282069 != -132629)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (65259 - 239194 != -173935)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (194452 - 42296 == 152156)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (88674 - 357978 != -269303)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (83843 - 200957 == -117114)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (258132 - 460863 != -202730)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (174885 - 240561 != -65675)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (1221 - 273527 == -272306)
											{
												Hashtable hashtable = new Hashtable();
												if (176323 - 453426 != -277102)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (22143 - 129055 != -106911)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (58438 - 19226 != 39213)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (278819 - 105645 == 173174)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (170100 - 46985 == 123115)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (176769 - 145709 == 31060)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (1857 - 97131 != -95273)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (60213 - 374772 != -314558)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (9148 - 138872 != -129723)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (120354 - 48146 == 72208)
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

	// Token: 0x0600185C RID: 6236 RVA: 0x00280018 File Offset: 0x0027E218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (274604 - 239849 != 34756)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (179917 - 490793 != -310875)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (116573 - 467700 != -351126)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (261623 - 269421 != -7797)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (131477 - 405710 == -274233)
						{
							int num2 = num;
							if (260809 - 81269 != 179541)
							{
								if (num2 == 1)
								{
									if (185601 - 123361 != 62241)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (265331 - 279644 != -14312)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (119429 - 492410 != -372980)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (67945 - 43039 != 24907)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (109293 - 420724 != -311430)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_fire(mPos, tDir, tID));
											if (65681 - 283568 != -217886)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (270420 - 444987 == -174567)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (52893 - 509434 != -456540)
										{
											this.StartCoroutine_Auto(this.RPC_randomCast(mPos, tDir, tID));
											if (4764 - 146314 == -141550)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (54660 - 406124 != -351463)
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

	// Token: 0x0600185D RID: 6237 RVA: 0x00280330 File Offset: 0x0027E530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00280334 File Offset: 0x0027E534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (298132 - 243129 != 55004)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (84194 - 582505 != -498310)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (34291 - 358336 != -324044)
				{
					Vector3 vector = a - this.transform.position;
					if (55742 - 99864 != -44121)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (110762 - 582746 == -471984)
						{
							CharacterControl characterControl = null;
							if (15023 - 265859 != -250835)
							{
								if (246828 - 191849 == 54979)
								{
									if (gameObject)
									{
										if (168830 - 151447 == 17384)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (200466 - 427149 != -226683)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (193449 - 326364 == -132914)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (123161 - 189457 == -66295)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (80465 - 538864 == -458398)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (175445 - 372437 == -196991)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (252747 - 579784 != -327036)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (55167 - 343419 != -288251)
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

	// Token: 0x0600185F RID: 6239 RVA: 0x002805D8 File Offset: 0x0027E7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (114814 - 506308 != -391494)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (126089 - 464667 == -338578)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (217029 - 55500 != 161530)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (200047 - 311472 == -111425)
					{
						Vector3 normalized = vector.normalized;
						if (147678 - 294616 == -146938)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (21863 - 177325 == -155462)
							{
								CharacterControl characterControl = null;
								if (57858 - 232892 == -175034)
								{
									if (14997 - 464673 != -449675)
									{
										if (gameObject)
										{
											if (43357 - 175468 == -132110)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (218372 - 232452 != -14080)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (197133 - 494531 != -297398)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (31188 - 267166 != -235978)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (270819 - 52501 != 218318)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (184035 - 413370 != -229335)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (16208 - 469913 == -453705)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (220001 - 45109 == 174892)
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

	// Token: 0x06001860 RID: 6240 RVA: 0x002808A4 File Offset: 0x0027EAA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x002808A8 File Offset: 0x0027EAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FakeShadowGod.$RPC_nAttack$19418(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x002808B8 File Offset: 0x0027EAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FakeShadowGod.$RPC_nAttack_fire$19426(mPos, this).GetEnumerator();
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x002808C8 File Offset: 0x0027EAC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_randomCast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FakeShadowGod.$RPC_randomCast$19436(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x002808D8 File Offset: 0x0027EAD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FakeShadowGod.$RPC_dead$19445(nArray, this).GetEnumerator();
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x002808E8 File Offset: 0x0027EAE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onHide()
	{
		if (20729 - 545897 != -525167)
		{
		}
		for (;;)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = null;
			if (253116 - 163486 == 89630)
			{
				GameObject gameObject = this.transform.Find("FakeShadowGod_tri").gameObject;
				if (225346 - 539413 == -314067)
				{
					if (gameObject)
					{
						if (147574 - 532846 != -385272)
						{
							continue;
						}
						skinnedMeshRenderer = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
						if (110251 - 194131 == -83879)
						{
							continue;
						}
					}
					if (!skinnedMeshRenderer)
					{
						break;
					}
					if (102200 - 410420 != -308219)
					{
						skinnedMeshRenderer.enabled = false;
						if (218199 - 216795 != 1405)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00280A08 File Offset: 0x0027EC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onFadeIn()
	{
		return new FakeShadowGod.$onFadeIn$19456(this).GetEnumerator();
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00280A18 File Offset: 0x0027EC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onMachineGodCoreExplosion()
	{
		return new FakeShadowGod.$onMachineGodCoreExplosion$19464(this).GetEnumerator();
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00280A28 File Offset: 0x0027EC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00280A2C File Offset: 0x0027EC2C
	internal static bool z5A7wtgdLOBtuWrxa2b()
	{
		return true;
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00280A30 File Offset: 0x0027EC30
	internal static bool jxHcYXgJVCeNljwD1GL()
	{
		return false;
	}

	// Token: 0x040014F3 RID: 5363
	public CharacterControl mChar;

	// Token: 0x040014F4 RID: 5364
	public GameObject doomFire;

	// Token: 0x040014F5 RID: 5365
	public GameObject castEffect;

	// Token: 0x040014F6 RID: 5366
	public GameObject castRing;

	// Token: 0x040014F7 RID: 5367
	public GameObject deadEffect;

	// Token: 0x02000414 RID: 1044
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19418 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600186B RID: 6251 RVA: 0x00280A34 File Offset: 0x0027EC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19418(Vector3 mPos, int tID, FakeShadowGod self_)
		{
			if (203587 - 433341 != -229754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40023 - 217728 == -177705)
				{
					base..ctor();
					if (123064 - 266343 == -143279)
					{
						this.$mPos$19423 = mPos;
						if (26690 - 226977 != -200286)
						{
							this.$tID$19424 = tID;
							if (138090 - 204140 != -66049)
							{
								this.$self_$19425 = self_;
								if (277314 - 102595 == 174719)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00280B10 File Offset: 0x0027ED10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FakeShadowGod.$RPC_nAttack$19418.$(this.$mPos$19423, this.$tID$19424, this.$self_$19425);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00280B2C File Offset: 0x0027ED2C
		internal static bool YnXVYYgDZCVFAggO306()
		{
			return true;
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00280B30 File Offset: 0x0027ED30
		internal static bool qosCwygv6JsEY6b3olv()
		{
			return false;
		}

		// Token: 0x040014F8 RID: 5368
		internal Vector3 $mPos$19423;

		// Token: 0x040014F9 RID: 5369
		internal int $tID$19424;

		// Token: 0x040014FA RID: 5370
		internal FakeShadowGod $self_$19425;

		// Token: 0x02000415 RID: 1045
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600186F RID: 6255 RVA: 0x00280B34 File Offset: 0x0027ED34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, FakeShadowGod self_)
			{
				if (107889 - 595198 != -487309)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244000 - 27965 == 216035)
					{
						base..ctor();
						if (217599 - 520221 != -302621)
						{
							this.$mPos$19420 = mPos;
							if (288887 - 122865 == 166022)
							{
								this.$tID$19421 = tID;
								if (16563 - 514161 != -497597)
								{
									this.$self_$19422 = self_;
									if (230026 - 506752 == -276726)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001870 RID: 6256 RVA: 0x00280C10 File Offset: 0x0027EE10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (296134 - 531659 != -235524)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_564;
					case 2:
						if (this.$self_$19422.mChar.actionState != "attack")
						{
							goto IL_4F7;
						}
						if (154289 - 133881 != 20408)
						{
							continue;
						}
						if (this.$self_$19422.mChar.myCommand != "nAttack")
						{
							if (104433 - 344223 != -239789)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19422.mChar.isMine)
							{
								goto IL_1E5;
							}
							if (77247 - 577443 == -500195)
							{
								continue;
							}
							if (this.$tID$19421 == 0)
							{
								goto IL_1E5;
							}
							if (219713 - 403650 != -183937)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19421];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19419 = (GameObject)obj2;
							if (261474 - 329042 == -67567)
							{
								continue;
							}
							if (!this.$tObject$19419)
							{
								goto IL_1E5;
							}
							if (133644 - 194147 != -60503)
							{
								continue;
							}
							this.$self_$19422.StartCoroutine_Auto(this.$self_$19422.RPC_nAttack_fire(this.$tObject$19419.transform.position, this.$self_$19422.transform.forward, this.$tID$19421));
							if (296874 - 509847 != -212973)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1E5;
							}
							if (7972 - 192679 == -184706)
							{
								continue;
							}
							this.$self_$19422.ActionEvent("RPC_nAttack_fire", this.$tObject$19419.transform.position, this.$self_$19422.transform.forward, this.$tID$19421);
							if (4878 - 261184 != -256306)
							{
								continue;
							}
							goto IL_1E5;
						}
						break;
					case 3:
						if (this.$self_$19422.mChar.actionState == "attack")
						{
							if (286960 - 441528 != -154568)
							{
								continue;
							}
							if (this.$self_$19422.mChar.myCommand == "nAttack")
							{
								if (143875 - 268185 == -124309)
								{
									continue;
								}
								this.$self_$19422.mChar.actionState = "standby";
								if (221255 - 579046 != -357791)
								{
									continue;
								}
								this.$self_$19422.mChar.actionTime = Time.time;
								if (183796 - 188684 != -4888)
								{
									continue;
								}
								this.$self_$19422.mChar.myCommand = "none";
								if (84720 - 233836 != -149116)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (48580 - 138709 != -90128)
						{
							goto Block_16;
						}
						continue;
					default:
						if (168863 - 579337 != -410474)
						{
							continue;
						}
						break;
					}
					this.$self_$19422.mChar.actionState = "attack";
					if (149401 - 102873 == 46528)
					{
						this.$self_$19422.mChar.actionTime = Time.time;
						if (254901 - 182051 == 72850)
						{
							this.$self_$19422.mChar.myCommand = "nAttack";
							if (241231 - 123921 != 117311)
							{
								this.$self_$19422.mChar.addTimeOut("nAttack", (float)12);
								if (65683 - 136039 != -70355)
								{
									this.$self_$19422.transform.position = this.$mPos$19420;
									if (113997 - 142699 == -28702)
									{
										this.$self_$19422.animation.CrossFade("nAttack", 0.5f);
										if (281568 - 397323 != -115754)
										{
											this.$self_$19422.animation.wrapMode = WrapMode.Once;
											if (38269 - 591521 == -553252)
											{
												this.$self_$19422.mChar.vMovement = this.$self_$19422.transform.forward;
												if (248309 - 418212 != -169902)
												{
													this.$self_$19422.mChar.moveSpeed = (float)0;
													if (289789 - 12607 != 277183)
													{
														goto Block_15;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1E5:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_15:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_16:
				Block_20:
				IL_4F7:
				IL_564:
				return false;
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x00281194 File Offset: 0x0027F394
			internal static bool FEj8sogRx7umrZpCWPW()
			{
				return true;
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x00281198 File Offset: 0x0027F398
			internal static bool SwrE5Kgw3FMu7SUwYhT()
			{
				return false;
			}

			// Token: 0x040014FB RID: 5371
			internal GameObject $tObject$19419;

			// Token: 0x040014FC RID: 5372
			internal Vector3 $mPos$19420;

			// Token: 0x040014FD RID: 5373
			internal int $tID$19421;

			// Token: 0x040014FE RID: 5374
			internal FakeShadowGod $self_$19422;
		}
	}

	// Token: 0x02000416 RID: 1046
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_fire$19426 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x0028119C File Offset: 0x0027F39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_fire$19426(Vector3 mPos, FakeShadowGod self_)
		{
			if (74016 - 31850 != 42167)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186540 - 546367 != -359826)
				{
					base..ctor();
					if (45378 - 477865 != -432486)
					{
						this.$mPos$19434 = mPos;
						if (285096 - 68387 == 216709)
						{
							this.$self_$19435 = self_;
							if (272793 - 209129 == 63664)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00281258 File Offset: 0x0027F458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FakeShadowGod.$RPC_nAttack_fire$19426.$(this.$mPos$19434, this.$self_$19435);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0028126C File Offset: 0x0027F46C
		internal static bool EKtYjOgqq0L5PvDokbp()
		{
			return true;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00281270 File Offset: 0x0027F470
		internal static bool VmhtWxg7iULIBIqsEdw()
		{
			return false;
		}

		// Token: 0x040014FF RID: 5375
		internal Vector3 $mPos$19434;

		// Token: 0x04001500 RID: 5376
		internal FakeShadowGod $self_$19435;

		// Token: 0x02000417 RID: 1047
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001877 RID: 6263 RVA: 0x00281274 File Offset: 0x0027F474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, FakeShadowGod self_)
			{
				if (197011 - 473137 != -276125)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240744 - 324871 != -84126)
					{
						base..ctor();
						if (292742 - 184462 == 108280)
						{
							this.$mPos$19432 = mPos;
							if (148689 - 570501 != -421811)
							{
								this.$self_$19433 = self_;
								if (128065 - 70722 != 57344)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001878 RID: 6264 RVA: 0x00281330 File Offset: 0x0027F530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109808 - 161233 != -51425)
				{
				}
				for (;;)
				{
					IL_2F1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_322;
					case 2:
						if (this.$self_$19433.mChar.isMine)
						{
							if (174981 - 583992 != -409011)
							{
								continue;
							}
							this.$hitLayer$19427 = 130816 - (1 << this.$self_$19433.gameObject.layer);
							if (38097 - 145642 != -107545)
							{
								continue;
							}
							this.$hitList$19428 = Damage.FindAreaTarget(this.$mPos$19432, (float)2, (float)4, this.$hitLayer$19427);
							if (23748 - 79318 != -55570)
							{
								continue;
							}
							this.$$iterator$10531$19431 = UnityRuntimeServices.GetEnumerator(this.$hitList$19428);
							if (234868 - 459177 == -224308)
							{
								continue;
							}
							while (this.$$iterator$10531$19431.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10531$19431.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19429 = (GameObject)obj2;
								if (37035 - 319827 == -282791)
								{
									goto IL_2F1;
								}
								this.$hitChar$19430 = (CharacterControl)this.$hitObject$19429.GetComponent(typeof(CharacterControl));
								if (158211 - 181275 == -23063)
								{
									goto IL_2F1;
								}
								UnityRuntimeServices.Update(this.$$iterator$10531$19431, this.$hitObject$19429);
								if (98704 - 517871 == -419166)
								{
									goto IL_2F1;
								}
								if (this.$hitChar$19430)
								{
									if (7471 - 307474 == -300002)
									{
										goto IL_2F1;
									}
									this.$hitChar$19430.RPC_AddEffectDamage(1, 300, 0, 0, Vector3.zero, this.$self_$19433.mChar.ActorNr);
									if (73066 - 133292 != -60226)
									{
										goto IL_2F1;
									}
								}
							}
							if (147185 - 335329 == -188143)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (37645 - 350553 != -312907)
						{
							goto Block_12;
						}
						continue;
					default:
						if (213561 - 273595 == -60033)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19433.doomFire)
					{
						if (235765 - 351070 != -115304)
						{
							UnityEngine.Object.Instantiate(this.$self_$19433.doomFire, this.$mPos$19432, Quaternion.identity);
							if (56922 - 310939 != -254016)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find doomFire Effect");
						if (211354 - 43658 != 167697)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_12:
				IL_322:
				return false;
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x00281674 File Offset: 0x0027F874
			internal static bool jLliQugP5M5CG4D31oi()
			{
				return true;
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x00281678 File Offset: 0x0027F878
			internal static bool o3CDZqg0vQbuDrovGXZ()
			{
				return false;
			}

			// Token: 0x04001501 RID: 5377
			internal int $hitLayer$19427;

			// Token: 0x04001502 RID: 5378
			internal UnityScript.Lang.Array $hitList$19428;

			// Token: 0x04001503 RID: 5379
			internal GameObject $hitObject$19429;

			// Token: 0x04001504 RID: 5380
			internal CharacterControl $hitChar$19430;

			// Token: 0x04001505 RID: 5381
			internal IEnumerator $$iterator$10531$19431;

			// Token: 0x04001506 RID: 5382
			internal Vector3 $mPos$19432;

			// Token: 0x04001507 RID: 5383
			internal FakeShadowGod $self_$19433;
		}
	}

	// Token: 0x02000418 RID: 1048
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_randomCast$19436 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x0028167C File Offset: 0x0027F87C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_randomCast$19436(Vector3 mPos, int tID, FakeShadowGod self_)
		{
			if (117761 - 551507 != -433746)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224678 - 116962 == 107716)
				{
					base..ctor();
					if (297249 - 333282 == -36033)
					{
						this.$mPos$19442 = mPos;
						if (31960 - 520666 == -488706)
						{
							this.$tID$19443 = tID;
							if (183542 - 394067 == -210525)
							{
								this.$self_$19444 = self_;
								if (59670 - 201392 != -141721)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00281758 File Offset: 0x0027F958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FakeShadowGod.$RPC_randomCast$19436.$(this.$mPos$19442, this.$tID$19443, this.$self_$19444);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00281774 File Offset: 0x0027F974
		internal static bool oSUNwLgbBdUUYxUfsRv()
		{
			return true;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00281778 File Offset: 0x0027F978
		internal static bool jn1QviguS9xnyQDZKxA()
		{
			return false;
		}

		// Token: 0x04001508 RID: 5384
		internal Vector3 $mPos$19442;

		// Token: 0x04001509 RID: 5385
		internal int $tID$19443;

		// Token: 0x0400150A RID: 5386
		internal FakeShadowGod $self_$19444;

		// Token: 0x02000419 RID: 1049
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600187F RID: 6271 RVA: 0x0028177C File Offset: 0x0027F97C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, FakeShadowGod self_)
			{
				if (140028 - 90008 != 50021)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46052 - 441873 == -395821)
					{
						base..ctor();
						if (77671 - 16785 == 60886)
						{
							this.$mPos$19439 = mPos;
							if (93835 - 112472 == -18637)
							{
								this.$tID$19440 = tID;
								if (266673 - 89385 != 177289)
								{
									this.$self_$19441 = self_;
									if (116335 - 593676 == -477341)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001880 RID: 6272 RVA: 0x00281858 File Offset: 0x0027FA58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25643 - 552756 != -527112)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6D3;
					case 2:
						if (this.$self_$19441.mChar.actionState != "attack")
						{
							goto IL_666;
						}
						if (131848 - 405503 == -273654)
						{
							continue;
						}
						if (this.$self_$19441.mChar.myCommand != "randomCast")
						{
							if (65008 - 191549 != -126541)
							{
								continue;
							}
							goto IL_666;
						}
						else if (this.$self_$19441.castEffect)
						{
							if (67475 - 459502 != -392027)
							{
								continue;
							}
							this.$self_$19441.mChar.createEffect(this.$self_$19441.castEffect, this.$self_$19441.transform.position, this.$self_$19441.transform.rotation);
							if (122203 - 567870 != -445666)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find castEffect Effect");
							if (219916 - 554972 != -335055)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19441.mChar.actionState != "attack")
						{
							goto IL_4D4;
						}
						if (63199 - 462529 == -399329)
						{
							continue;
						}
						if (this.$self_$19441.mChar.myCommand != "randomCast")
						{
							if (119263 - 77208 != 42056)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19440];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19437 = (GameObject)obj2;
							if (112399 - 55395 == 57005)
							{
								continue;
							}
							if (!this.$tObject$19437)
							{
								goto IL_125;
							}
							if (85343 - 165697 != -80354)
							{
								continue;
							}
							this.$tChar$19438 = (CharacterControl)this.$tObject$19437.GetComponent(typeof(CharacterControl));
							if (188230 - 275010 == -86779)
							{
								continue;
							}
							if (!this.$tChar$19438)
							{
								goto IL_125;
							}
							if (267954 - 434504 != -166550)
							{
								continue;
							}
							if (this.$self_$19441.castRing)
							{
								if (276210 - 120176 == 156035)
								{
									continue;
								}
								this.$tChar$19438.createEffect(this.$self_$19441.castRing, this.$tObject$19437.transform.position, Quaternion.identity);
								if (91551 - 144709 != -53158)
								{
									continue;
								}
							}
							if (!this.$self_$19441.mChar.isMine)
							{
								goto IL_125;
							}
							if (241959 - 290714 == -48754)
							{
								continue;
							}
							this.$tChar$19438.RPC_AddStatus("coma", 1, 13, this.$tChar$19438.hp, this.$self_$19441.mChar.ActorNr);
							if (22812 - 63492 != -40680)
							{
								continue;
							}
							goto IL_125;
						}
						break;
					case 4:
						if (this.$self_$19441.mChar.actionState == "attack")
						{
							if (86954 - 533252 == -446297)
							{
								continue;
							}
							if (this.$self_$19441.mChar.myCommand == "randomCast")
							{
								if (205697 - 299302 == -93604)
								{
									continue;
								}
								this.$self_$19441.mChar.actionState = "standby";
								if (50225 - 447549 != -397324)
								{
									continue;
								}
								this.$self_$19441.mChar.actionTime = Time.time;
								if (57174 - 459457 == -402282)
								{
									continue;
								}
								this.$self_$19441.mChar.myCommand = "none";
								if (239109 - 404482 != -165373)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (273374 - 281123 != -7748)
						{
							goto Block_29;
						}
						continue;
					default:
						if (177752 - 331592 == -153839)
						{
							continue;
						}
						break;
					}
					this.$self_$19441.mChar.actionState = "attack";
					if (24668 - 580837 == -556169)
					{
						this.$self_$19441.mChar.actionTime = Time.time;
						if (160712 - 587169 == -426457)
						{
							this.$self_$19441.mChar.myCommand = "randomCast";
							if (108192 - 574743 == -466551)
							{
								this.$self_$19441.mChar.addTimeOut("randomCast", (float)6);
								if (259675 - 60456 != 199220)
								{
									this.$self_$19441.transform.position = this.$mPos$19439;
									if (19086 - 287415 != -268328)
									{
										this.$self_$19441.animation.CrossFade("cast", 0.5f);
										if (99019 - 35651 != 63369)
										{
											this.$self_$19441.animation.wrapMode = WrapMode.Once;
											if (112023 - 567943 != -455919)
											{
												this.$self_$19441.mChar.vMovement = this.$self_$19441.transform.forward;
												if (108361 - 442408 != -334046)
												{
													this.$self_$19441.mChar.moveSpeed = (float)0;
													if (14621 - 561003 == -546382)
													{
														goto IL_3FB;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_125:
				return this.Yield(4, new WaitForSeconds(1.5f));
				IL_237:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_25:
				goto IL_237;
				IL_3FB:
				return this.Yield(2, new WaitForSeconds(1.6f));
				Block_29:
				IL_4D4:
				goto IL_6D3;
				Block_38:
				goto IL_237;
				Block_40:
				IL_666:
				IL_6D3:
				return false;
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x00281F4C File Offset: 0x0028014C
			internal static bool m1xoR5gI6L90LZvkd48()
			{
				return true;
			}

			// Token: 0x06001882 RID: 6274 RVA: 0x00281F50 File Offset: 0x00280150
			internal static bool IuFyVDgBBx61f39tLEF()
			{
				return false;
			}

			// Token: 0x0400150B RID: 5387
			internal GameObject $tObject$19437;

			// Token: 0x0400150C RID: 5388
			internal CharacterControl $tChar$19438;

			// Token: 0x0400150D RID: 5389
			internal Vector3 $mPos$19439;

			// Token: 0x0400150E RID: 5390
			internal int $tID$19440;

			// Token: 0x0400150F RID: 5391
			internal FakeShadowGod $self_$19441;
		}
	}

	// Token: 0x0200041A RID: 1050
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19445 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x00281F54 File Offset: 0x00280154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19445(UnityScript.Lang.Array nArray, FakeShadowGod self_)
		{
			if (1449 - 331435 != -329985)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92887 - 401873 != -308985)
				{
					base..ctor();
					if (160770 - 511009 != -350238)
					{
						this.$nArray$19454 = nArray;
						if (3838 - 29137 == -25299)
						{
							this.$self_$19455 = self_;
							if (87075 - 290437 == -203362)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00282010 File Offset: 0x00280210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FakeShadowGod.$RPC_dead$19445.$(this.$nArray$19454, this.$self_$19455);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00282024 File Offset: 0x00280224
		internal static bool qqgetGgekPu5WRVKKNk()
		{
			return true;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00282028 File Offset: 0x00280228
		internal static bool WMbFdlgrVj6OiLqTL3U()
		{
			return false;
		}

		// Token: 0x04001510 RID: 5392
		internal UnityScript.Lang.Array $nArray$19454;

		// Token: 0x04001511 RID: 5393
		internal FakeShadowGod $self_$19455;

		// Token: 0x0200041B RID: 1051
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001887 RID: 6279 RVA: 0x0028202C File Offset: 0x0028022C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FakeShadowGod self_)
			{
				if (258171 - 359697 != -101526)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158196 - 97928 == 60268)
					{
						base..ctor();
						if (222289 - 487146 != -264856)
						{
							this.$nArray$19452 = nArray;
							if (57884 - 568095 == -510211)
							{
								this.$self_$19453 = self_;
								if (159064 - 373865 == -214801)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001888 RID: 6280 RVA: 0x002820E8 File Offset: 0x002802E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249906 - 347910 != -98003)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6AB;
					case 2:
						if (this.$self_$19453.mChar.actionState != "dead")
						{
							if (62564 - 412011 != -349447)
							{
								continue;
							}
							goto IL_685;
						}
						else
						{
							this.$mFakeShadowGodRenderer$19448 = null;
							if (73461 - 39317 == 34145)
							{
								continue;
							}
							this.$mModel$19449 = this.$self_$19453.transform.Find("FakeShadowGod_tri").gameObject;
							if (221822 - 593809 != -371987)
							{
								continue;
							}
							if (this.$mModel$19449)
							{
								if (188484 - 195365 != -6881)
								{
									continue;
								}
								this.$mFakeShadowGodRenderer$19448 = (SkinnedMeshRenderer)this.$mModel$19449.GetComponent(typeof(SkinnedMeshRenderer));
								if (177507 - 334249 == -156741)
								{
									continue;
								}
							}
							goto IL_397;
						}
						break;
					case 3:
						goto IL_397;
					default:
						if (2219 - 494172 != -491953)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19453.mChar.actionState == "dead")
					{
						if (289099 - 487679 != -198580)
						{
							continue;
						}
						goto IL_473;
					}
					else
					{
						this.$myPosition$19446 = (Vector3)this.$nArray$19452[0];
						if (54883 - 183556 != -128673)
						{
							continue;
						}
						this.$myDirection$19447 = (Vector3)this.$nArray$19452[1];
						if (202725 - 110494 == 92232)
						{
							continue;
						}
						this.$self_$19453.transform.position = this.$myPosition$19446;
						if (141331 - 86672 != 54659)
						{
							continue;
						}
						this.$self_$19453.transform.LookAt(this.$myPosition$19446 + this.$myDirection$19447);
						if (267944 - 185066 == 82879)
						{
							continue;
						}
						this.$self_$19453.mChar.hp = 0;
						if (35390 - 491620 != -456230)
						{
							continue;
						}
						this.$self_$19453.mChar.actionState = "dead";
						if (154598 - 13479 == 141120)
						{
							continue;
						}
						this.$self_$19453.mChar.actionTime = Time.time;
						if (57562 - 501933 != -444371)
						{
							continue;
						}
						this.$self_$19453.mChar.myCommand = "none";
						if (117077 - 389963 != -272886)
						{
							continue;
						}
						this.$self_$19453.mChar.vMovement = Vector3.zero;
						if (136267 - 95921 == 40347)
						{
							continue;
						}
						this.$self_$19453.mChar.moveSpeed = (float)0;
						if (234893 - 592273 != -357380)
						{
							continue;
						}
						this.$self_$19453.animation.Rewind();
						if (186718 - 523206 != -336488)
						{
							continue;
						}
						this.$self_$19453.animation.Play("ko");
						if (24204 - 79231 != -55027)
						{
							continue;
						}
						this.$self_$19453.animation.wrapMode = WrapMode.Once;
						if (17876 - 91350 == -73473)
						{
							continue;
						}
						if (this.$self_$19453.deadEffect)
						{
							if (116695 - 238568 == -121872)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$19453.deadEffect, this.$self_$19453.transform.position, Quaternion.identity);
							if (191764 - 236564 != -44800)
							{
								continue;
							}
							break;
						}
						else
						{
							Debug.Log("Missing deadEffect");
							if (105725 - 538803 != -433077)
							{
								break;
							}
							continue;
						}
					}
					IL_397:
					if (Time.time >= this.$self_$19453.mChar.actionTime + (float)6)
					{
						if (133965 - 342563 != -208597)
						{
							UnityEngine.Object.Destroy(this.$self_$19453.gameObject);
							if (152696 - 283483 != -130786)
							{
								this.YieldDefault(1);
								if (180414 - 269124 == -88710)
								{
									goto IL_6AB;
								}
							}
						}
					}
					else
					{
						if (!this.$mFakeShadowGodRenderer$19448)
						{
							goto IL_38B;
						}
						if (86764 - 50738 != 36027)
						{
							this.$$13742$19450 = 0.5f * (this.$self_$19453.mChar.actionTime - Time.time + (float)6);
							if (42934 - 77847 != -34912 && 91925 - 264475 != -172549)
							{
								Color color = this.$$13743$19451 = this.$mFakeShadowGodRenderer$19448.materials[0].color;
								if (256631 - 74240 == 182391)
								{
									if (213445 - 369041 == -155596)
									{
										float num = this.$$13743$19451.a = this.$$13742$19450;
										if (6834 - 403486 == -396652)
										{
											if (34786 - 447020 == -412234)
											{
												Color color2 = this.$mFakeShadowGodRenderer$19448.materials[0].color = this.$$13743$19451;
												if (228835 - 388634 != -159798)
												{
													if (217140 - 197155 == 19985)
													{
														goto IL_38B;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_5C1;
				IL_38B:
				return this.YieldDefault(3);
				IL_473:
				goto IL_6AB;
				IL_5C1:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_685:
				IL_6AB:
				return false;
			}

			// Token: 0x06001889 RID: 6281 RVA: 0x002827B4 File Offset: 0x002809B4
			internal static bool geWaMEgjsNtk7ghZOSt()
			{
				return true;
			}

			// Token: 0x0600188A RID: 6282 RVA: 0x002827B8 File Offset: 0x002809B8
			internal static bool s6K0ygghtwuZe1Dg46l()
			{
				return false;
			}

			// Token: 0x04001512 RID: 5394
			internal Vector3 $myPosition$19446;

			// Token: 0x04001513 RID: 5395
			internal Vector3 $myDirection$19447;

			// Token: 0x04001514 RID: 5396
			internal SkinnedMeshRenderer $mFakeShadowGodRenderer$19448;

			// Token: 0x04001515 RID: 5397
			internal GameObject $mModel$19449;

			// Token: 0x04001516 RID: 5398
			internal float $$13742$19450;

			// Token: 0x04001517 RID: 5399
			internal Color $$13743$19451;

			// Token: 0x04001518 RID: 5400
			internal UnityScript.Lang.Array $nArray$19452;

			// Token: 0x04001519 RID: 5401
			internal FakeShadowGod $self_$19453;
		}
	}

	// Token: 0x0200041C RID: 1052
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onFadeIn$19456 : GenericGenerator<object>
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x002827BC File Offset: 0x002809BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onFadeIn$19456(FakeShadowGod self_)
		{
			if (154017 - 373214 != -219196)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142862 - 354240 == -211378)
				{
					base..ctor();
					if (156721 - 436183 == -279462)
					{
						this.$self_$19463 = self_;
						if (93205 - 94128 != -922)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00282854 File Offset: 0x00280A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new FakeShadowGod.$onFadeIn$19456.$(this.$self_$19463);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00282864 File Offset: 0x00280A64
		internal static bool Cw3bBtgsnCrUucEM6uw()
		{
			return true;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00282868 File Offset: 0x00280A68
		internal static bool NjDZGkg9V6wuiOQgCk9()
		{
			return false;
		}

		// Token: 0x0400151A RID: 5402
		internal FakeShadowGod $self_$19463;

		// Token: 0x0200041D RID: 1053
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x0600188F RID: 6287 RVA: 0x0028286C File Offset: 0x00280A6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(FakeShadowGod self_)
			{
				if (291240 - 48161 != 243079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285621 - 134666 != 150956)
					{
						base..ctor();
						if (270541 - 455743 != -185201)
						{
							this.$self_$19462 = self_;
							if (98742 - 202020 != -103277)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001890 RID: 6288 RVA: 0x00282904 File Offset: 0x00280B04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202311 - 124856 != 77455)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_342;
					case 2:
						goto IL_19E;
					default:
						if (9393 - 431982 == -422588)
						{
							continue;
						}
						break;
					}
					this.$mFakeShadowGodRenderer$19457 = null;
					if (281262 - 543386 != -262124)
					{
						continue;
					}
					this.$mModel$19458 = this.$self_$19462.transform.Find("FakeShadowGod_tri").gameObject;
					if (210802 - 202526 == 8277)
					{
						continue;
					}
					if (this.$mModel$19458)
					{
						if (123035 - 483013 == -359977)
						{
							continue;
						}
						this.$mFakeShadowGodRenderer$19457 = (SkinnedMeshRenderer)this.$mModel$19458.GetComponent(typeof(SkinnedMeshRenderer));
						if (260995 - 214244 != 46751)
						{
							continue;
						}
					}
					if (this.$mFakeShadowGodRenderer$19457)
					{
						if (234584 - 406906 == -172321)
						{
							continue;
						}
						this.$mFakeShadowGodRenderer$19457.enabled = true;
						if (205233 - 18762 != 186471)
						{
							continue;
						}
					}
					this.$mFadeInTimer$19459 = Time.time;
					if (170898 - 113203 == 57696)
					{
						continue;
					}
					IL_19E:
					if (Time.time >= this.$mFadeInTimer$19459 + (float)2)
					{
						if (25268 - 78749 != -53480)
						{
							this.YieldDefault(1);
							if (168688 - 535682 != -366993)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$mFakeShadowGodRenderer$19457)
						{
							goto IL_192;
						}
						if (294677 - 452099 != -157421)
						{
							this.$$13744$19460 = 0.5f * (Time.time - this.$mFadeInTimer$19459);
							if (206598 - 531529 == -324931)
							{
								if (216733 - 247142 != -30408)
								{
									this.$$13745$19461 = this.$mFakeShadowGodRenderer$19457.materials[0].color;
									if (139621 - 223597 == -83976)
									{
										if (123159 - 138306 == -15147)
										{
											float num = this.$$13745$19461.a = this.$$13744$19460;
											if (51858 - 303532 != -251673)
											{
												if (4197 - 99432 == -95235)
												{
													Color color = this.$mFakeShadowGodRenderer$19457.materials[0].color = this.$$13745$19461;
													if (294757 - 223359 == 71398)
													{
														if (191101 - 259618 != -68516)
														{
															goto Block_25;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_342;
				IL_192:
				return this.YieldDefault(2);
				Block_25:
				goto IL_192;
				IL_342:
				return false;
			}

			// Token: 0x06001891 RID: 6289 RVA: 0x00282C68 File Offset: 0x00280E68
			internal static bool MK3Astg1eZiRgsi9IEr()
			{
				return true;
			}

			// Token: 0x06001892 RID: 6290 RVA: 0x00282C6C File Offset: 0x00280E6C
			internal static bool ai35jdg4c9d338R2EIm()
			{
				return false;
			}

			// Token: 0x0400151B RID: 5403
			internal SkinnedMeshRenderer $mFakeShadowGodRenderer$19457;

			// Token: 0x0400151C RID: 5404
			internal GameObject $mModel$19458;

			// Token: 0x0400151D RID: 5405
			internal float $mFadeInTimer$19459;

			// Token: 0x0400151E RID: 5406
			internal float $$13744$19460;

			// Token: 0x0400151F RID: 5407
			internal Color $$13745$19461;

			// Token: 0x04001520 RID: 5408
			internal FakeShadowGod $self_$19462;
		}
	}

	// Token: 0x0200041E RID: 1054
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onMachineGodCoreExplosion$19464 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00282C70 File Offset: 0x00280E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onMachineGodCoreExplosion$19464(FakeShadowGod self_)
		{
			if (172789 - 414090 != -241300)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282609 - 577700 != -295090)
				{
					base..ctor();
					if (27146 - 410098 != -382951)
					{
						this.$self_$19466 = self_;
						if (172606 - 503213 == -330607)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00282D08 File Offset: 0x00280F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FakeShadowGod.$onMachineGodCoreExplosion$19464.$(this.$self_$19466);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00282D18 File Offset: 0x00280F18
		internal static bool p0wja1gzqy56vb3H7MM()
		{
			return true;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00282D1C File Offset: 0x00280F1C
		internal static bool i1KCwBfaH6O8oNIoUAl()
		{
			return false;
		}

		// Token: 0x04001521 RID: 5409
		internal FakeShadowGod $self_$19466;

		// Token: 0x0200041F RID: 1055
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001897 RID: 6295 RVA: 0x00282D20 File Offset: 0x00280F20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(FakeShadowGod self_)
			{
				if (295467 - 499965 != -204498)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66845 - 476760 != -409914)
					{
						base..ctor();
						if (168744 - 533126 == -364382)
						{
							this.$self_$19465 = self_;
							if (46465 - 219265 != -172799)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x00282DB8 File Offset: 0x00280FB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127362 - 151439 != -24077)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_585;
					case 2:
						if (this.$self_$19465.mChar.actionState != "ko")
						{
							if (297880 - 359544 != -61664)
							{
								continue;
							}
							goto IL_23C;
						}
						else
						{
							if (!this.$self_$19465.mChar.isMine)
							{
								goto IL_172;
							}
							if (152203 - 583815 == -431611)
							{
								continue;
							}
							this.$self_$19465.mChar.RPC_AddDamage(99, 19999, 0, 0, Vector3.zero, this.$self_$19465.mChar.ActorNr);
							if (259090 - 203809 != 55282)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19465.mChar.actionState != "ko")
						{
							if (59578 - 199116 != -139537)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$19465.animation.CrossFade("cast", 0.5f);
							if (173430 - 59037 != 114393)
							{
								continue;
							}
							this.$self_$19465.animation.wrapMode = WrapMode.Once;
							if (235536 - 395963 != -160427)
							{
								continue;
							}
							goto IL_123;
						}
						break;
					case 4:
						if (this.$self_$19465.mChar.actionState != "ko")
						{
							if (259627 - 582797 != -323169)
							{
								goto Block_9;
							}
							continue;
						}
						else if (this.$self_$19465.castEffect)
						{
							if (222534 - 11931 != 210603)
							{
								continue;
							}
							this.$self_$19465.mChar.createEffect(this.$self_$19465.castEffect, this.$self_$19465.transform.position, this.$self_$19465.transform.rotation);
							if (187749 - 128569 != 59180)
							{
								continue;
							}
							goto IL_47E;
						}
						else
						{
							Debug.LogError("Cannot find castEffect Effect");
							if (98493 - 165472 != -66979)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 5:
						if (this.$self_$19465.mChar.actionState != "ko")
						{
							if (85390 - 298581 != -213191)
							{
								continue;
							}
							goto IL_328;
						}
						else
						{
							this.$self_$19465.mChar.actionState = "standby";
							if (159962 - 108522 != 51440)
							{
								continue;
							}
							this.$self_$19465.mChar.actionTime = Time.time;
							if (170364 - 61009 == 109356)
							{
								continue;
							}
							this.$self_$19465.mChar.myCommand = "none";
							if (205607 - 137400 == 68208)
							{
								continue;
							}
							this.YieldDefault(1);
							if (134610 - 151512 != -16901)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (295692 - 534949 == -239256)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19465.mChar.actionState == "dead")
					{
						if (205933 - 463749 != -257815)
						{
							goto Block_26;
						}
					}
					else
					{
						this.$self_$19465.mChar.actionState = "ko";
						if (298747 - 314144 == -15397)
						{
							this.$self_$19465.mChar.actionTime = Time.time;
							if (114117 - 553301 == -439184)
							{
								this.$self_$19465.mChar.myCommand = "none";
								if (259086 - 426680 != -167593)
								{
									this.$self_$19465.mChar.vMovement = Vector3.zero;
									if (277613 - 308398 == -30785)
									{
										this.$self_$19465.mChar.moveSpeed = (float)0;
										if (46878 - 545568 != -498689)
										{
											this.$self_$19465.animation.Rewind();
											if (165594 - 377200 == -211606)
											{
												this.$self_$19465.animation.Play("getHit");
												if (280985 - 55485 != 225501)
												{
													this.$self_$19465.animation.wrapMode = WrapMode.Once;
													if (102713 - 320565 != -217851)
													{
														goto Block_4;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_4:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_5:
				goto IL_585;
				IL_123:
				return this.Yield(4, new WaitForSeconds(1.6f));
				Block_9:
				goto IL_585;
				IL_172:
				return this.Yield(3, new WaitForSeconds(1.5f));
				Block_11:
				IL_23C:
				IL_328:
				Block_26:
				goto IL_585;
				Block_27:
				goto IL_172;
				IL_47E:
				goto IL_1A;
				IL_585:
				return false;
			}

			// Token: 0x06001899 RID: 6297 RVA: 0x0028335C File Offset: 0x0028155C
			internal static bool lgY5vJf5gMd80feXaJ4()
			{
				return true;
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x00283360 File Offset: 0x00281560
			internal static bool JCtRWlfpp0mydUp3kGH()
			{
				return false;
			}

			// Token: 0x04001522 RID: 5410
			internal FakeShadowGod $self_$19465;
		}
	}
}
