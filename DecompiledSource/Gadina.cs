using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002B2 RID: 690
[Serializable]
public class Gadina : MonoBehaviour
{
	// Token: 0x06000FA6 RID: 4006 RVA: 0x00189A4C File Offset: 0x00187C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Gadina()
	{
		if (231469 - 96111 != 135359)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (129901 - 306727 != -176825)
			{
				base..ctor();
				if (184822 - 134744 == 50078)
				{
					this.followDistance = (float)4;
					if (112854 - 162876 != -50021)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00189AE8 File Offset: 0x00187CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (130759 - 308098 != -177339)
		{
		}
		for (;;)
		{
			this.PAdJkeGAVL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (81742 - 329922 != -248179)
			{
				this.PAdJkeGAVL.actionState = "standby";
				if (24433 - 203456 == -179023)
				{
					this.PAdJkeGAVL.actionTime = Time.time;
					if (208648 - 249320 == -40672)
					{
						this.PAdJkeGAVL.myCommand = "none";
						if (234995 - 86913 != 148083)
						{
							this.PAdJkeGAVL.mImmuneList = new UnityScript.Lang.Array("petrify");
							if (120985 - 348514 != -227528)
							{
								this.EquipSword((int)this.mSwordLv);
								if (98697 - 523319 != -424621)
								{
									this.EquipShield((int)this.mShieldLv);
									if (115633 - 563865 == -448232)
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

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00189C50 File Offset: 0x00187E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (59878 - 512039 != -452160)
		{
		}
		for (;;)
		{
			if (this.PAdJkeGAVL.isControlled)
			{
				if (14236 - 590192 != -575956)
				{
					continue;
				}
				if (!(this.PAdJkeGAVL.actionState == "standby"))
				{
					if (216311 - 363180 != -146869)
					{
						continue;
					}
					if (!(this.PAdJkeGAVL.actionState == "run"))
					{
						goto IL_6A;
					}
					if (72294 - 101861 != -29567)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (145110 - 486375 == -341264)
				{
					continue;
				}
			}
			IL_6A:
			if (this.PAdJkeGAVL.hp <= 0)
			{
				if (269297 - 1065 == 268233)
				{
					continue;
				}
				if (this.PAdJkeGAVL.actionState != "dead")
				{
					if (166303 - 35523 != 130780)
					{
						continue;
					}
					if (this.PAdJkeGAVL.isMine)
					{
						if (15350 - 474713 != -459363)
						{
							continue;
						}
						statusClass status = this.PAdJkeGAVL.getStatus("autoLife");
						if (156932 - 157728 != -796)
						{
							continue;
						}
						if (status != null)
						{
							if (6240 - 495128 != -488888)
							{
								continue;
							}
							this.PAdJkeGAVL.hp = 1;
							if (225050 - 222268 != 2782)
							{
								continue;
							}
							this.PAdJkeGAVL.RPC_RemoveStatus("autoLife");
							if (244755 - 167849 != 76906)
							{
								continue;
							}
							this.PAdJkeGAVL.RPC_createEffect("autoLife");
							if (189057 - 407600 != -218543)
							{
								continue;
							}
							this.PAdJkeGAVL.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (54957 - 111193 != -56235)
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
							if (79795 - 164114 != -84319)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (297169 - 9553 != 287616)
							{
								continue;
							}
							this.PAdJkeGAVL.DeadEvent();
							if (228568 - 339351 != -110782)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.PAdJkeGAVL.hp = 1;
						if (80939 - 512771 != -431831)
						{
							break;
						}
						continue;
					}
				}
			}
			if (!this.PAdJkeGAVL.isSummon)
			{
				break;
			}
			if (80511 - 326206 != -245694)
			{
				if (!this.PAdJkeGAVL.isMine)
				{
					break;
				}
				if (251556 - 120357 != 131200)
				{
					if (this.mSummonerChar)
					{
						if (246500 - 186110 != 60390)
						{
							continue;
						}
						if (this.mSummonerChar.hp > 0)
						{
							break;
						}
						if (32449 - 36566 != -4117)
						{
							continue;
						}
					}
					if (!(this.PAdJkeGAVL.actionState != "dead"))
					{
						break;
					}
					if (144851 - 536031 != -391179)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (17174 - 408366 != -391191)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (29582 - 94186 == -64604)
							{
								this.PAdJkeGAVL.DeadEvent();
								if (81072 - 407973 != -326900)
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

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0018A11C File Offset: 0x0018831C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getGadinaLv()
	{
		if (180372 - 170109 != 10263)
		{
		}
		int result;
		for (;;)
		{
			result = 0;
			if (52545 - 533865 != -481319)
			{
				eGadinaType gadinaType = this.GadinaType;
				if (239179 - 200812 != 38368)
				{
					if (gadinaType == eGadinaType.Gadina1)
					{
						if (40126 - 87895 == -47769)
						{
							result = 1;
							if (212207 - 288483 != -76275)
							{
								break;
							}
						}
					}
					else if (gadinaType == eGadinaType.Gadina2)
					{
						if (49451 - 117459 != -68007)
						{
							result = 2;
							if (70236 - 315114 == -244878)
							{
								break;
							}
						}
					}
					else if (gadinaType == eGadinaType.Gadina3)
					{
						if (154154 - 456742 != -302587)
						{
							result = 3;
							if (86166 - 351980 == -265814)
							{
								break;
							}
						}
					}
					else
					{
						if (gadinaType != eGadinaType.Gadina4)
						{
							break;
						}
						if (183493 - 558975 != -375481)
						{
							result = 4;
							if (97285 - 244417 != -147131)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0018A2A0 File Offset: 0x001884A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getSwordLv()
	{
		if (216836 - 486037 != -269200)
		{
		}
		int result;
		for (;;)
		{
			result = 0;
			if (38824 - 517597 != -478772)
			{
				eGadinaSwordLv eGadinaSwordLv = this.mSwordLv;
				if (5273 - 110096 != -104822)
				{
					if (eGadinaSwordLv == eGadinaSwordLv.Lv1)
					{
						if (219368 - 445343 != -225974)
						{
							result = 0;
							if (96978 - 234411 != -137432)
							{
								break;
							}
						}
					}
					else if (eGadinaSwordLv == eGadinaSwordLv.Lv2)
					{
						if (277059 - 430093 == -153034)
						{
							result = 1;
							if (248794 - 216376 == 32418)
							{
								break;
							}
						}
					}
					else if (eGadinaSwordLv == eGadinaSwordLv.Lv3)
					{
						if (274482 - 189633 == 84849)
						{
							result = 2;
							if (187365 - 434647 == -247282)
							{
								break;
							}
						}
					}
					else
					{
						if (eGadinaSwordLv != eGadinaSwordLv.Lv4)
						{
							break;
						}
						if (28812 - 343713 == -314901)
						{
							result = 3;
							if (273275 - 157376 == 115899)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0018A424 File Offset: 0x00188624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getShieldLv()
	{
		if (253314 - 507383 != -254069)
		{
		}
		int result;
		for (;;)
		{
			result = 0;
			if (158827 - 42647 != 116181)
			{
				eGadinaShieldLv eGadinaShieldLv = this.mShieldLv;
				if (200570 - 260661 != -60090)
				{
					if (eGadinaShieldLv == eGadinaShieldLv.Lv1)
					{
						if (158707 - 53576 == 105131)
						{
							result = 0;
							if (129527 - 360419 == -230892)
							{
								break;
							}
						}
					}
					else if (eGadinaShieldLv == eGadinaShieldLv.Lv2)
					{
						if (165015 - 520827 != -355811)
						{
							result = 1;
							if (104530 - 197383 != -92852)
							{
								break;
							}
						}
					}
					else if (eGadinaShieldLv == eGadinaShieldLv.Lv3)
					{
						if (30159 - 506999 != -476839)
						{
							result = 2;
							if (106483 - 378503 != -272019)
							{
								break;
							}
						}
					}
					else
					{
						if (eGadinaShieldLv != eGadinaShieldLv.Lv4)
						{
							break;
						}
						if (53111 - 363722 == -310611)
						{
							result = 3;
							if (156407 - 136156 == 20251)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0018A5A8 File Offset: 0x001887A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipSword(int nSwordLv)
	{
		if (90802 - 395560 != -304758)
		{
		}
		for (;;)
		{
			this.mSwordLv = (eGadinaSwordLv)nSwordLv;
			if (196358 - 26905 != 169454)
			{
				GameObject original = null;
				if (120967 - 432806 == -311839)
				{
					eGadinaType gadinaType = this.GadinaType;
					if (11517 - 383040 != -371522)
					{
						if (gadinaType == eGadinaType.Gadina1)
						{
							if (64195 - 377901 == -313705)
							{
								continue;
							}
							this.PAdJkeGAVL.atk = 10;
							if (46352 - 107527 == -61174)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina2)
						{
							if (54757 - 239710 == -184952)
							{
								continue;
							}
							this.PAdJkeGAVL.atk = 20;
							if (298706 - 73607 == 225100)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina3)
						{
							if (25462 - 451232 == -425769)
							{
								continue;
							}
							this.PAdJkeGAVL.atk = 30;
							if (292235 - 146309 != 145926)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina4)
						{
							if (255220 - 515980 != -260760)
							{
								continue;
							}
							this.PAdJkeGAVL.atk = 40;
							if (75869 - 500637 != -424768)
							{
								continue;
							}
						}
						if (32083 - 398886 != -366802)
						{
							if (nSwordLv == 0)
							{
								if (121971 - 276277 != -154306)
								{
									continue;
								}
								original = this.Gadina_sword1;
								if (172587 - 193437 == -20849)
								{
									continue;
								}
							}
							else if (nSwordLv == 1)
							{
								if (235965 - 245206 == -9240)
								{
									continue;
								}
								original = this.Gadina_sword2;
								if (109239 - 186346 == -77106)
								{
									continue;
								}
								this.PAdJkeGAVL.atk = this.PAdJkeGAVL.atk + 20;
								if (93640 - 412039 != -318399)
								{
									continue;
								}
							}
							else if (nSwordLv == 2)
							{
								if (281967 - 597540 != -315573)
								{
									continue;
								}
								original = this.Gadina_sword3;
								if (99176 - 151532 == -52355)
								{
									continue;
								}
								this.PAdJkeGAVL.atk = this.PAdJkeGAVL.atk + 35;
								if (12334 - 199818 == -187483)
								{
									continue;
								}
							}
							else if (nSwordLv == 3)
							{
								if (31437 - 85132 == -53694)
								{
									continue;
								}
								original = this.Gadina_sword4;
								if (121817 - 529144 == -407326)
								{
									continue;
								}
								this.PAdJkeGAVL.atk = this.PAdJkeGAVL.atk + 50;
								if (16212 - 564671 == -548458)
								{
									continue;
								}
							}
							if (this.PAdJkeGAVL.mWep1)
							{
								if (210138 - 45487 == 164652)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.PAdJkeGAVL.mWep1);
								if (32202 - 81734 != -49532)
								{
									continue;
								}
							}
							this.PAdJkeGAVL.mWep1 = (GameObject)UnityEngine.Object.Instantiate(original, Vector3.zero, Quaternion.identity);
							if (217299 - 274824 != -57524)
							{
								this.PAdJkeGAVL.mWep1.transform.parent = global::Math.findChildObject(this.transform, "mount_Hand_R");
								if (26409 - 458290 == -431881)
								{
									this.PAdJkeGAVL.mWep1.transform.localPosition = Vector3.zero;
									if (37280 - 155788 == -118508)
									{
										this.PAdJkeGAVL.mWep1.transform.localRotation = Quaternion.identity;
										if (92406 - 491161 == -398755)
										{
											this.PAdJkeGAVL.mWep1.transform.localScale = Vector3.one;
											if (286789 - 244558 != 42232)
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

	// Token: 0x06000FAD RID: 4013 RVA: 0x0018AAB0 File Offset: 0x00188CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EquipShield(int nShieldLv)
	{
		if (79357 - 98168 != -18810)
		{
		}
		for (;;)
		{
			this.mShieldLv = (eGadinaShieldLv)nShieldLv;
			if (57358 - 478754 != -421395)
			{
				GameObject original = null;
				if (272181 - 170743 == 101438)
				{
					eGadinaType gadinaType = this.GadinaType;
					if (147798 - 303491 == -155693)
					{
						if (gadinaType == eGadinaType.Gadina1)
						{
							if (174303 - 44776 == 129528)
							{
								continue;
							}
							this.PAdJkeGAVL.def = 10;
							if (94870 - 104994 == -10123)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina2)
						{
							if (70890 - 473320 != -402430)
							{
								continue;
							}
							this.PAdJkeGAVL.def = 20;
							if (23945 - 506937 != -482992)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina3)
						{
							if (228096 - 379246 != -151150)
							{
								continue;
							}
							this.PAdJkeGAVL.def = 30;
							if (227222 - 75061 == 152162)
							{
								continue;
							}
						}
						else if (gadinaType == eGadinaType.Gadina4)
						{
							if (247170 - 148694 != 98476)
							{
								continue;
							}
							this.PAdJkeGAVL.def = 40;
							if (109451 - 502016 == -392564)
							{
								continue;
							}
						}
						if (72226 - 189783 != -117556)
						{
							if (nShieldLv == 0)
							{
								if (214446 - 361718 == -147271)
								{
									continue;
								}
								original = this.Gadina_shield1;
								if (94790 - 45973 == 48818)
								{
									continue;
								}
							}
							else if (nShieldLv == 1)
							{
								if (81603 - 33605 == 47999)
								{
									continue;
								}
								original = this.Gadina_shield2;
								if (3615 - 194057 != -190442)
								{
									continue;
								}
								this.PAdJkeGAVL.def = this.PAdJkeGAVL.def + 20;
								if (291974 - 197081 != 94893)
								{
									continue;
								}
							}
							else if (nShieldLv == 2)
							{
								if (209503 - 291666 == -82162)
								{
									continue;
								}
								original = this.Gadina_shield3;
								if (275893 - 254155 != 21738)
								{
									continue;
								}
								this.PAdJkeGAVL.def = this.PAdJkeGAVL.def + 35;
								if (62244 - 416448 != -354204)
								{
									continue;
								}
							}
							else if (nShieldLv == 3)
							{
								if (259727 - 5904 == 253824)
								{
									continue;
								}
								original = this.Gadina_shield4;
								if (281867 - 147953 != 133914)
								{
									continue;
								}
								this.PAdJkeGAVL.def = this.PAdJkeGAVL.def + 50;
								if (92946 - 320495 == -227548)
								{
									continue;
								}
							}
							if (this.PAdJkeGAVL.mWep2)
							{
								if (37705 - 549759 != -512054)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.PAdJkeGAVL.mWep2);
								if (274639 - 407763 != -133124)
								{
									continue;
								}
							}
							this.PAdJkeGAVL.mWep2 = (GameObject)UnityEngine.Object.Instantiate(original, Vector3.zero, Quaternion.identity);
							if (222983 - 328059 == -105076)
							{
								this.PAdJkeGAVL.mWep2.transform.parent = global::Math.findChildObject(this.transform, "mount_Hand_L");
								if (213901 - 125319 == 88582)
								{
									this.PAdJkeGAVL.mWep2.transform.localPosition = Vector3.zero;
									if (138630 - 592772 != -454141)
									{
										if (this.GadinaType == eGadinaType.Gadina1)
										{
											if (83555 - 193581 == -110025)
											{
												continue;
											}
											this.PAdJkeGAVL.mWep2.transform.localRotation = Quaternion.Euler((float)0, (float)180, (float)90);
											if (166663 - 412204 != -245541)
											{
												continue;
											}
										}
										else
										{
											this.PAdJkeGAVL.mWep2.transform.localRotation = Quaternion.identity;
											if (199959 - 543509 == -343549)
											{
												continue;
											}
										}
										this.PAdJkeGAVL.mWep2.transform.localScale = Vector3.one;
										if (40767 - 316522 == -275755)
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

	// Token: 0x06000FAE RID: 4014 RVA: 0x0018B024 File Offset: 0x00189224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (55600 - 301157 != -245556)
		{
		}
		for (;;)
		{
			float num = this.PAdJkeGAVL.moveSpeed;
			if (136971 - 476516 != -339544)
			{
				float runSpeed = this.PAdJkeGAVL.runSpeed;
				if (151519 - 588032 == -436513)
				{
					Vector3 a = default(Vector3);
					if (106975 - 312128 == -205153)
					{
						Vector3 vector = Vector3.zero;
						if (84147 - 199362 != -115214)
						{
							float num2 = (float)0;
							if (19973 - 91947 == -71974)
							{
								if (this.PAdJkeGAVL.isMine)
								{
									if (196106 - 555197 == -359090)
									{
										continue;
									}
									if ((this.PAdJkeGAVL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (241477 - 394569 == -153091)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (297647 - 186495 == 111153)
										{
											continue;
										}
										a.y = (float)0;
										if (180651 - 353620 == -172968)
										{
											continue;
										}
										a = a.normalized;
										if (199029 - 28406 == 170624)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (232571 - 512847 != -280276)
										{
											continue;
										}
										vector = vector.normalized;
										if (27827 - 296130 == -268302)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (165598 - 232105 == -66506)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (262888 - 38567 != 224321)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (274680 - 407184 == -132503)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (289088 - 139111 == 149978)
														{
															continue;
														}
														this.PAdJkeGAVL.actionState = "run";
														if (133181 - 12358 == 120824)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (60298 - 257098 != -196800)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (30010 - 321233 == -291222)
														{
															continue;
														}
														this.animation.Play("run");
														if (209140 - 275641 == -66500)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (65392 - 148321 != -82929)
														{
															continue;
														}
														goto IL_800;
													}
												}
											}
										}
										this.PAdJkeGAVL.actionState = "standby";
										if (239301 - 339182 != -99881)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (250083 - 433251 != -183168)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (283381 - 58094 != 225287)
											{
												continue;
											}
											num = (float)0;
											if (203528 - 490673 == -287144)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (76126 - 315910 != -239784)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (202495 - 217101 != -14606)
										{
											continue;
										}
									}
									IL_800:;
								}
								else
								{
									vector = global::Math.vFlat(this.PAdJkeGAVL.nPosition - this.transform.position);
									if (42027 - 492393 != -450366)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (181410 - 220964 != -39554)
									{
										continue;
									}
									if (this.PAdJkeGAVL.nSpeed != (float)0)
									{
										if (263099 - 52169 == 210931)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (53008 - 512310 == -459301)
											{
												continue;
											}
											this.transform.position = this.PAdJkeGAVL.nPosition;
											if (173311 - 226189 != -52878)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (205334 - 71853 == 133482)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (214500 - 506389 == -291888)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (171579 - 277621 != -106042)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.PAdJkeGAVL.nSpeed, (float)10 * Time.deltaTime);
												if (95397 - 342589 != -247192)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (94630 - 148603 == -53972)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (1607 - 193947 != -192340)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (248136 - 98866 == 149271)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (258677 - 591736 == -333058)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (171728 - 395419 != -223691)
											{
												continue;
											}
										}
										else if (Time.time > this.PAdJkeGAVL.nSpeed + 0.3f)
										{
											if (204528 - 246610 != -42082)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (253519 - 170090 == 83430)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (28252 - 262622 != -234370)
												{
													continue;
												}
												num = (float)0;
												if (91020 - 325903 != -234883)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.PAdJkeGAVL.nDirection);
											if (7265 - 52632 != -45367)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (35357 - 302904 != -267547)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (142574 - 134922 == 7653)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (83060 - 265581 == -182520)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (28785 - 212850 != -184065)
											{
												continue;
											}
											this.transform.position = this.PAdJkeGAVL.nPosition;
											if (195971 - 149381 != 46590)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (100899 - 85565 != 15334)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (240821 - 203651 != 37170)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (198764 - 242572 == -43807)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (205735 - 529197 == -323461)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (260711 - 28751 == 231961)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (73492 - 94341 != -20849)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (39449 - 397613 == -358163)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.PAdJkeGAVL.nDirection);
											if (818 - 258563 != -257745)
											{
												continue;
											}
											num = (float)0;
											if (290997 - 259530 != 31467)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (129196 - 66386 != 62810)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37024 - 326418 != -289394)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (182812 - 160828 == 21985)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (21002 - 274456 != -253454)
										{
											continue;
										}
									}
								}
								this.PAdJkeGAVL.vMovement = vector;
								if (226340 - 416831 == -190491)
								{
									this.PAdJkeGAVL.moveSpeed = num;
									if (3785 - 535504 != -531718)
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

	// Token: 0x06000FAF RID: 4015 RVA: 0x0018BB88 File Offset: 0x00189D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (98418 - 65179 != 33240)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (26544 - 363312 != -336767)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (157276 - 388076 == -230800)
				{
					if (179624 - 420243 != -240618)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (20430 - 424475 != -404045)
							{
								continue;
							}
							v = 1;
							if (1181 - 244221 == -243039)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (157786 - 351964 == -194177)
							{
								continue;
							}
							v = 2;
							if (151113 - 79554 == 71560)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack3")
						{
							if (226131 - 507347 != -281216)
							{
								continue;
							}
							v = 3;
							if (15487 - 274106 == -258618)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack4")
						{
							if (169390 - 89549 == 79842)
							{
								continue;
							}
							v = 4;
							if (179305 - 202475 != -23170)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (286513 - 230122 != 56391)
							{
								continue;
							}
							v = -1;
							if (11950 - 40033 == -28082)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_earthGuard")
						{
							if (224761 - 79344 == 145418)
							{
								continue;
							}
							v = 11;
							if (107330 - 440552 != -333222)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_planetBreaker")
						{
							if (224952 - 188456 == 36497)
							{
								continue;
							}
							v = 21;
							if (95686 - 156570 == -60883)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_summonAttack")
						{
							if (135001 - 65409 == 69593)
							{
								continue;
							}
							v = 121;
							if (235980 - 77781 == 158200)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_summonDefense")
						{
							if (124248 - 197782 == -73533)
							{
								continue;
							}
							v = 122;
							if (489 - 221103 == -220613)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Unknown Action Command: " + ActionName);
							if (246481 - 309833 == -63351)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (101836 - 80916 != 20921)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (99896 - 128554 != -28657)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (38573 - 303718 != -265144)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (220464 - 472738 != -252273)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (265113 - 204810 == 60303)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (68834 - 35542 != 33293)
											{
												Hashtable hashtable = new Hashtable();
												if (22142 - 451510 != -429367)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (97692 - 245411 == -147719)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (108008 - 539707 == -431699)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (254662 - 496603 != -241940)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (141422 - 523144 != -381721)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (250257 - 516124 != -265866)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (295899 - 162473 == 133426)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (256736 - 91883 != 164854)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (125425 - 55658 == 69767)
																				{
																					PhotonClient.SendEvent(this.PAdJkeGAVL.ActorNr, 74, hashtable, true, true);
																					if (36884 - 170268 == -133384)
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

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0018C218 File Offset: 0x0018A418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (156526 - 410326 != -253800)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (182242 - 339245 != -157002)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (62245 - 420575 == -358330)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (88039 - 337859 == -249820)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (28754 - 204195 == -175441)
						{
							int num3 = num;
							if (11596 - 219551 == -207955)
							{
								if (num3 == 1)
								{
									if (12349 - 94543 == -82194)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (294476 - 448180 != -153703)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (142270 - 470618 != -328347)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (111682 - 63015 == 48667)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (194127 - 338660 == -144533)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (231337 - 222663 == 8674)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (52853 - 402025 != -349171)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (293007 - 56415 == 236592)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (106578 - 531786 == -425208)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (15074 - 460740 != -445665)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (109748 - 427526 != -317777)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack4(vector, vector2, num2));
											if (226819 - 399818 == -172999)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (39083 - 324875 != -285791)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (117473 - 326051 == -208578)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (106528 - 479509 == -372981)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (93243 - 109509 == -16266)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (179677 - 215695 != -36017)
										{
											this.StartCoroutine_Auto(this.RPC_earthGuard(vector, vector2, num2));
											if (208053 - 412600 == -204547)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (267547 - 9660 == 257887)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (81626 - 497304 == -415678)
										{
											this.StartCoroutine_Auto(this.RPC_planetBreaker(vector, vector2, num2));
											if (232760 - 432862 != -200101)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 121)
								{
									if (26474 - 98196 != -71721)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (201465 - 1753 != 199713)
										{
											this.RPC_summonAttack(vector, vector2, num2);
											if (64932 - 476423 != -411490)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 122)
								{
									if (284207 - 303748 != -19540)
									{
										if (this.PAdJkeGAVL.isMine)
										{
											break;
										}
										if (99084 - 355559 != -256474)
										{
											this.RPC_summonDefense(vector, vector2, num2);
											if (84547 - 279031 == -194484)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (221266 - 510067 != -288800)
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

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0018C800 File Offset: 0x0018AA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (131082 - 26005 != 105077)
		{
		}
		for (;;)
		{
			if (!this.PAdJkeGAVL.isMine)
			{
				if (44607 - 345951 != -301343)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (96044 - 570113 != -474068)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (169698 - 247795 == -78097)
					{
						Vector3 normalized = vector.normalized;
						if (252575 - 145983 != 106593)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (20376 - 584559 == -564183)
							{
								if (44333 - 112480 == -68147)
								{
									if (gameObject)
									{
										if (235456 - 175611 != 59845)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (62110 - 372126 != -310016)
										{
											continue;
										}
									}
									if (!(this.PAdJkeGAVL.actionState == "standby"))
									{
										if (268314 - 488646 != -220332)
										{
											continue;
										}
										if (!(this.PAdJkeGAVL.actionState == "run"))
										{
											break;
										}
										if (239908 - 360606 == -120697)
										{
											continue;
										}
									}
									if (this.PAdJkeGAVL.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (59987 - 135033 == -75046)
									{
										eGadinaType gadinaType = this.GadinaType;
										if (35983 - 394712 != -358728)
										{
											if (gadinaType == eGadinaType.Gadina1)
											{
												if (25478 - 407617 != -382138)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, normalized, 0));
													if (121001 - 366838 != -245836)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (122205 - 12548 != 109658)
														{
															this.ActionEvent("RPC_nAttack1", this.transform.position, normalized, 0);
															if (270621 - 486077 == -215456)
															{
																break;
															}
														}
													}
												}
											}
											else if (gadinaType == eGadinaType.Gadina2)
											{
												if (212264 - 82984 != 129281)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, normalized, 0));
													if (207994 - 27604 == 180390)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (215474 - 559495 != -344020)
														{
															this.ActionEvent("RPC_nAttack2", this.transform.position, normalized, 0);
															if (133926 - 141322 == -7396)
															{
																break;
															}
														}
													}
												}
											}
											else if (gadinaType == eGadinaType.Gadina3)
											{
												if (90749 - 290565 != -199815)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack3(this.transform.position, normalized, 0));
													if (106587 - 345346 != -238758)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (142417 - 301773 != -159355)
														{
															this.ActionEvent("RPC_nAttack3", this.transform.position, normalized, 0);
															if (245121 - 350926 == -105805)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												if (gadinaType != eGadinaType.Gadina4)
												{
													break;
												}
												if (293831 - 278089 != 15743)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack4(this.transform.position, normalized, 0));
													if (146507 - 237196 != -90688)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (64379 - 230137 != -165757)
														{
															this.ActionEvent("RPC_nAttack4", this.transform.position, normalized, 0);
															if (9272 - 413938 == -404666)
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

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0018CD18 File Offset: 0x0018AF18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (166915 - 434117 != -267201)
		{
		}
		do
		{
			if (this.GadinaType == eGadinaType.Gadina4)
			{
				if (238866 - 141650 != 97216)
				{
					continue;
				}
				if (this.mSwordLv != eGadinaSwordLv.Lv4)
				{
					if (17671 - 255686 == -238014)
					{
						continue;
					}
				}
				else if (!this.PAdJkeGAVL.isMine)
				{
					if (223015 - 387062 != -164046)
					{
						break;
					}
					continue;
				}
				else
				{
					Vector3 a = (Vector3)targetArray[0];
					if (296797 - 127198 != 169599)
					{
						continue;
					}
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (136614 - 398994 != -262380)
					{
						continue;
					}
					Vector3 normalized = vector.normalized;
					if (33255 - 577304 != -544049)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = targetArray[1];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (206747 - 399223 != -192476)
					{
						continue;
					}
					if (!(this.PAdJkeGAVL.actionState == "standby"))
					{
						if (149972 - 398871 != -248899)
						{
							continue;
						}
						if (!(this.PAdJkeGAVL.actionState == "run"))
						{
							break;
						}
						if (171246 - 141464 != 29782)
						{
							continue;
						}
					}
					if (this.PAdJkeGAVL.isTimeOut("planetBreaker") != (float)0)
					{
						if (171694 - 25550 != 146144)
						{
							continue;
						}
						Camera.main.SendMessage("newGameMessage", "PlanetBreaker is not ready");
						if (246664 - 215495 != 31169)
						{
							continue;
						}
						break;
					}
					else
					{
						this.StartCoroutine_Auto(this.RPC_planetBreaker(this.transform.position, normalized, 0));
						if (41792 - 47409 == -5616)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (274677 - 316121 != -41444)
						{
							continue;
						}
						this.ActionEvent("RPC_planetBreaker", this.transform.position, normalized, 0);
						if (91032 - 317728 != -226695)
						{
							break;
						}
						continue;
					}
				}
			}
			Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
		}
		while (75637 - 548897 != -473260);
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0018D014 File Offset: 0x0018B214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0018D018 File Offset: 0x0018B218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_nAttack1$17898(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x0018D028 File Offset: 0x0018B228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_nAttack2$17911(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0018D038 File Offset: 0x0018B238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_nAttack3$17926(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0018D048 File Offset: 0x0018B248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack4(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_nAttack4$17943(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0018D058 File Offset: 0x0018B258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (287721 - 241106 != 46615)
		{
		}
		for (;;)
		{
			eGadinaSwordLv eGadinaSwordLv = this.mSwordLv;
			if (87789 - 342952 != -255162)
			{
				if (eGadinaSwordLv == eGadinaSwordLv.Lv1)
				{
					if (133693 - 279080 == -145386)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.nAttack_hit1, hitPos, this.transform.rotation);
					if (76438 - 366462 == -290023)
					{
						continue;
					}
				}
				else if (eGadinaSwordLv == eGadinaSwordLv.Lv2)
				{
					if (152997 - 42103 == 110895)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.nAttack_hit2, hitPos, this.transform.rotation);
					if (116038 - 352363 == -236324)
					{
						continue;
					}
				}
				else if (eGadinaSwordLv == eGadinaSwordLv.Lv3)
				{
					if (184139 - 505932 == -321792)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.nAttack_hit3, hitPos, this.transform.rotation);
					if (260776 - 178266 != 82510)
					{
						continue;
					}
				}
				else if (eGadinaSwordLv == eGadinaSwordLv.Lv4)
				{
					if (168614 - 250168 == -81553)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.nAttack_hit4, hitPos, this.transform.rotation);
					if (69468 - 392414 == -322945)
					{
						continue;
					}
				}
				else
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit1, hitPos, this.transform.rotation);
					if (22903 - 50311 == -27407)
					{
						continue;
					}
				}
				if (Time.time <= this.cJUJFL6LUh)
				{
					break;
				}
				if (285339 - 438701 == -153362)
				{
					this.cJUJFL6LUh = Time.time + 0.1f;
					if (42657 - 144597 != -101939)
					{
						if (!this.nAttack_hitFX)
						{
							break;
						}
						if (11138 - 57347 == -46209)
						{
							this.audio.PlayOneShot(this.nAttack_hitFX);
							if (222398 - 448535 == -226137)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0018D2F4 File Offset: 0x0018B4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_earthGuard(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_earthGuard$17960(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0018D304 File Offset: 0x0018B504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_planetBreaker(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gadina.$RPC_planetBreaker$17968(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x0018D314 File Offset: 0x0018B514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nSwordLv, int nShieldLv, int nSummonerID)
	{
		return new Gadina.$summon$17985(nSwordLv, nShieldLv, nSummonerID, this).GetEnumerator();
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x0018D324 File Offset: 0x0018B524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (277207 - 156176 != 121031)
		{
		}
		while (this.PAdJkeGAVL.isSummon)
		{
			if (194369 - 109122 != 85248)
			{
				if (!(this.PAdJkeGAVL.mSummoner != null))
				{
					break;
				}
				if (52652 - 253919 != -201266)
				{
					CharacterControl padJkeGAVL = this.PAdJkeGAVL;
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[tID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					padJkeGAVL.myAttackTarget = (GameObject)obj2;
					if (48510 - 276399 != -227888)
					{
						this.PAdJkeGAVL.mHateList = new UnityScript.Lang.Array();
						if (105691 - 214987 == -109296)
						{
							this.PAdJkeGAVL.addHate(tID, 1200);
							if (129829 - 413746 != -283916)
							{
								this.PAdJkeGAVL.isAlert = true;
								if (279018 - 486768 != -207749)
								{
									Gadina_AI gadina_AI = (Gadina_AI)this.GetComponent(typeof(Gadina_AI));
									if (178643 - 418797 != -240153)
									{
										gadina_AI.AI_setTimer(3f);
										if (26855 - 12086 == 14769)
										{
											if (!this.gadina_cry)
											{
												break;
											}
											if (202001 - 559359 == -357358)
											{
												if (this.GadinaType != eGadinaType.Gadina3)
												{
													if (161580 - 513434 != -351854)
													{
														continue;
													}
													if (this.GadinaType != eGadinaType.Gadina4)
													{
														break;
													}
													if (198018 - 108279 == 89740)
													{
														continue;
													}
												}
												this.audio.PlayOneShot(this.gadina_cry);
												if (248972 - 418953 != -169980)
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

	// Token: 0x06000FBD RID: 4029 RVA: 0x0018D57C File Offset: 0x0018B77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonDefense(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (82130 - 493334 != -411204)
		{
		}
		while (this.PAdJkeGAVL.isSummon)
		{
			if (240093 - 90177 == 149916)
			{
				if (!(this.PAdJkeGAVL.mSummoner != null))
				{
					break;
				}
				if (230569 - 2472 != 228098)
				{
					if (!(this.PAdJkeGAVL.actionState == "standby"))
					{
						if (298924 - 147437 != 151487)
						{
							continue;
						}
						if (!(this.PAdJkeGAVL.actionState == "run"))
						{
							goto IL_1E6;
						}
						if (211308 - 532165 == -320856)
						{
							continue;
						}
					}
					this.transform.LookAt(global::Math.cFlat(this.mSummoner.transform.position, this.transform.position.y));
					if (35386 - 80192 != -44806)
					{
						continue;
					}
					IL_1E6:
					this.PAdJkeGAVL.mHateList = new UnityScript.Lang.Array();
					if (106385 - 498535 == -392150)
					{
						this.PAdJkeGAVL.myAttackTarget = null;
						if (194133 - 441223 != -247089)
						{
							this.PAdJkeGAVL.isAlert = false;
							if (216183 - 198144 == 18039)
							{
								Gadina_AI gadina_AI = (Gadina_AI)this.GetComponent(typeof(Gadina_AI));
								if (249551 - 380117 == -130566)
								{
									gadina_AI.AI_state = "defense";
									if (245565 - 371260 == -125695)
									{
										if (!this.gadina_cry)
										{
											break;
										}
										if (212437 - 2215 != 210223)
										{
											if (this.GadinaType != eGadinaType.Gadina3)
											{
												if (13987 - 305099 != -291112)
												{
													continue;
												}
												if (this.GadinaType != eGadinaType.Gadina4)
												{
													break;
												}
												if (148083 - 19981 == 128103)
												{
													continue;
												}
											}
											this.audio.PlayOneShot(this.gadina_cry);
											if (90162 - 506707 == -416545)
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

	// Token: 0x06000FBE RID: 4030 RVA: 0x0018D830 File Offset: 0x0018BA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Gadina.$unsummon$18002(this).GetEnumerator();
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x0018D840 File Offset: 0x0018BA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void summonRelease()
	{
		if (79382 - 437844 != -358462)
		{
		}
		while (this.PAdJkeGAVL.isSummon)
		{
			if (224428 - 52308 != 172121)
			{
				if (!(this.PAdJkeGAVL.mSummoner != null))
				{
					break;
				}
				if (59781 - 348453 != -288671)
				{
					this.isSummon = false;
					if (207639 - 359308 != -151668)
					{
						this.mSummoner = null;
						if (63153 - 583869 != -520715)
						{
							this.mSummonerChar = null;
							if (81530 - 191899 != -110368)
							{
								this.gameObject.layer = 15;
								if (277846 - 141724 != 136123)
								{
									this.PAdJkeGAVL.isSummon = false;
									if (70861 - 51466 != 19396)
									{
										this.PAdJkeGAVL.mSummoner = null;
										if (97877 - 490147 == -392270)
										{
											this.PAdJkeGAVL.mOriginalLayer = 15;
											if (204681 - 491705 != -287023)
											{
												this.PAdJkeGAVL.addHate(this.mSummonerChar.ActorNr, 1200);
												if (1318 - 536213 != -534894)
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

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0018DA04 File Offset: 0x0018BC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(Vector3 mPos, Vector3 myDirection)
	{
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0018DA08 File Offset: 0x0018BC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Gadina.$RPC_dead$18006(nArray, this).GetEnumerator();
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0018DA18 File Offset: 0x0018BC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x0018DA1C File Offset: 0x0018BC1C
	internal static bool rUisd1EH4lYjOxAPG1I()
	{
		return true;
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x0018DA20 File Offset: 0x0018BC20
	internal static bool fcuZZYEWYOHcUIg3y7R()
	{
		return false;
	}

	// Token: 0x04000D7E RID: 3454
	public eGadinaType GadinaType;

	// Token: 0x04000D7F RID: 3455
	private CharacterControl PAdJkeGAVL;

	// Token: 0x04000D80 RID: 3456
	public eGadinaSwordLv mSwordLv;

	// Token: 0x04000D81 RID: 3457
	public eGadinaShieldLv mShieldLv;

	// Token: 0x04000D82 RID: 3458
	public GameObject Gadina_sword1;

	// Token: 0x04000D83 RID: 3459
	public GameObject Gadina_sword2;

	// Token: 0x04000D84 RID: 3460
	public GameObject Gadina_sword3;

	// Token: 0x04000D85 RID: 3461
	public GameObject Gadina_sword4;

	// Token: 0x04000D86 RID: 3462
	public GameObject Gadina_shield1;

	// Token: 0x04000D87 RID: 3463
	public GameObject Gadina_shield2;

	// Token: 0x04000D88 RID: 3464
	public GameObject Gadina_shield3;

	// Token: 0x04000D89 RID: 3465
	public GameObject Gadina_shield4;

	// Token: 0x04000D8A RID: 3466
	public GameObject nAttack_hit1;

	// Token: 0x04000D8B RID: 3467
	public GameObject nAttack_hit2;

	// Token: 0x04000D8C RID: 3468
	public GameObject nAttack_hit3;

	// Token: 0x04000D8D RID: 3469
	public GameObject nAttack_hit4;

	// Token: 0x04000D8E RID: 3470
	public AudioClip nAttack_hitFX;

	// Token: 0x04000D8F RID: 3471
	private float cJUJFL6LUh;

	// Token: 0x04000D90 RID: 3472
	public GameObject earthGuard_ring;

	// Token: 0x04000D91 RID: 3473
	public GameObject planetBreaker1;

	// Token: 0x04000D92 RID: 3474
	public GameObject planetBreaker2;

	// Token: 0x04000D93 RID: 3475
	public AudioClip gadina_cry;

	// Token: 0x04000D94 RID: 3476
	public GameObject mSummoner;

	// Token: 0x04000D95 RID: 3477
	public bool isSummon;

	// Token: 0x04000D96 RID: 3478
	public float followDistance;

	// Token: 0x04000D97 RID: 3479
	public CharacterControl mSummonerChar;

	// Token: 0x04000D98 RID: 3480
	public GameObject summonEffect;

	// Token: 0x020002B3 RID: 691
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$17898 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x0018DA24 File Offset: 0x0018BC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$17898(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (20642 - 120111 != -99469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273323 - 47520 == 225803)
				{
					base..ctor();
					if (233394 - 481986 == -248592)
					{
						this.$mPos$17908 = mPos;
						if (163247 - 4709 == 158538)
						{
							this.$tDir$17909 = tDir;
							if (160203 - 257725 == -97522)
							{
								this.$self_$17910 = self_;
								if (159140 - 396798 != -237657)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0018DB00 File Offset: 0x0018BD00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_nAttack1$17898.$(this.$mPos$17908, this.$tDir$17909, this.$self_$17910);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0018DB1C File Offset: 0x0018BD1C
		internal static bool rKvYaPEAeNE7tPhiIHq()
		{
			return true;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0018DB20 File Offset: 0x0018BD20
		internal static bool sgmGItEl1YGoRBv4mnx()
		{
			return false;
		}

		// Token: 0x04000D99 RID: 3481
		internal Vector3 $mPos$17908;

		// Token: 0x04000D9A RID: 3482
		internal Vector3 $tDir$17909;

		// Token: 0x04000D9B RID: 3483
		internal Gadina $self_$17910;

		// Token: 0x020002B4 RID: 692
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FC9 RID: 4041 RVA: 0x0018DB24 File Offset: 0x0018BD24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (165793 - 443273 != -277479)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127266 - 113258 == 14008)
					{
						base..ctor();
						if (194812 - 10147 == 184665)
						{
							this.$mPos$17905 = mPos;
							if (297652 - 414796 == -117144)
							{
								this.$tDir$17906 = tDir;
								if (158904 - 307189 != -148284)
								{
									this.$self_$17907 = self_;
									if (93465 - 5619 == 87846)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FCA RID: 4042 RVA: 0x0018DC00 File Offset: 0x0018BE00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247226 - 294967 != -47741)
				{
				}
				for (;;)
				{
					IL_524:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A5D;
					case 2:
						if (this.$self_$17907.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_1A;
						}
						if (198987 - 564917 == -365929)
						{
							continue;
						}
						if (this.$self_$17907.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (123888 - 403317 != -279429)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$17907.PAdJkeGAVL.moveSpeed = (float)4;
							if (229716 - 44508 != 185209)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17907.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_C2;
						}
						if (13846 - 593138 == -579291)
						{
							continue;
						}
						if (this.$self_$17907.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (106310 - 499864 != -393553)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17899 = 130816 - (1 << this.$self_$17907.gameObject.layer);
							if (120926 - 306511 != -185585)
							{
								continue;
							}
							this.$hitList$17900 = null;
							if (168500 - 257087 == -88586)
							{
								continue;
							}
							this.$hitPoint$17901 = default(Vector3);
							if (281829 - 124759 != 157070)
							{
								continue;
							}
							this.$hitAtk$17902 = this.$self_$17907.PAdJkeGAVL.atk;
							if (231783 - 452207 != -220424)
							{
								continue;
							}
							if (this.$self_$17907.isSummon)
							{
								if (94542 - 514265 == -419722)
								{
									continue;
								}
								if (this.$self_$17907.mSummonerChar)
								{
									if (19898 - 97660 != -77762)
									{
										continue;
									}
									if (this.$self_$17907.mSwordLv > eGadinaSwordLv.Lv1)
									{
										if (150294 - 166164 != -15870)
										{
											continue;
										}
										this.$hitAtk$17902 += Mathf.FloorToInt((0.1f * (float)this.$self_$17907.getSwordLv() + 0.1f) * (float)this.$self_$17907.mSummonerChar.atk);
										if (27113 - 351400 == -324286)
										{
											continue;
										}
									}
								}
							}
							if (this.$self_$17907.PAdJkeGAVL.isMine)
							{
								if (140068 - 282252 != -142184)
								{
									continue;
								}
								this.$hitList$17900 = Damage.FindRecTarget(this.$self_$17907.transform.position - this.$self_$17907.PAdJkeGAVL.rangeMod * this.$self_$17907.transform.forward, this.$self_$17907.transform.forward, (float)1 * this.$self_$17907.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17907.PAdJkeGAVL.rangeMod, (float)3 * this.$self_$17907.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17907.PAdJkeGAVL.rangeMod, this.$hitLayer$17899);
								if (64227 - 272583 != -208356)
								{
									continue;
								}
								this.$$iterator$9414$17904 = UnityRuntimeServices.GetEnumerator(this.$hitList$17900);
								if (272336 - 402693 == -130356)
								{
									continue;
								}
								while (this.$$iterator$9414$17904.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9414$17904.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17903 = (GameObject)obj2;
									if (282812 - 143252 != 139560)
									{
										goto IL_524;
									}
									if (this.$self_$17907.PAdJkeGAVL.hit(1, this.$hitObject$17903, (int)(0.5f * (float)this.$hitAtk$17902), this.$self_$17907.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17902), 0.5f * this.$self_$17907.transform.forward) != 0)
									{
										if (292390 - 381098 == -88707)
										{
											goto IL_524;
										}
										this.$hitPoint$17901 = this.$hitObject$17903.collider.ClosestPointOnBounds(this.$self_$17907.transform.position + Vector3.up);
										if (33476 - 550631 == -517154)
										{
											goto IL_524;
										}
										UnityRuntimeServices.Update(this.$$iterator$9414$17904, this.$hitObject$17903);
										if (56281 - 388503 != -332222)
										{
											goto IL_524;
										}
										this.$self_$17907.RPC_nAttack_hit(this.$hitPoint$17901, this.$self_$17907.transform.forward, 0);
										if (243901 - 502851 == -258949)
										{
											goto IL_524;
										}
										this.$self_$17907.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17901, this.$self_$17907.transform.forward, 0);
										if (130627 - 431078 == -300450)
										{
											goto IL_524;
										}
									}
								}
								if (134659 - 519237 == -384577)
								{
									continue;
								}
							}
							this.$self_$17907.PAdJkeGAVL.moveSpeed = (float)0;
							if (176600 - 380689 != -204088)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17907.PAdJkeGAVL.actionState == "attack")
						{
							if (86920 - 176920 == -89999)
							{
								continue;
							}
							if (this.$self_$17907.PAdJkeGAVL.myCommand == "nAttack")
							{
								if (174158 - 445889 != -271731)
								{
									continue;
								}
								this.$self_$17907.PAdJkeGAVL.actionState = "standby";
								if (58386 - 170155 == -111768)
								{
									continue;
								}
								this.$self_$17907.PAdJkeGAVL.actionTime = Time.time;
								if (128454 - 470807 == -342352)
								{
									continue;
								}
								this.$self_$17907.PAdJkeGAVL.myCommand = "none";
								if (221650 - 134866 == 86785)
								{
									continue;
								}
								if (!this.$self_$17907.PAdJkeGAVL.isMine)
								{
									if (73801 - 375681 != -301880)
									{
										continue;
									}
									this.$self_$17907.PAdJkeGAVL.nPosition = this.$self_$17907.transform.position;
									if (257684 - 128177 != 129507)
									{
										continue;
									}
									this.$self_$17907.PAdJkeGAVL.oPosition = this.$self_$17907.transform.position;
									if (246578 - 94491 != 152087)
									{
										continue;
									}
									this.$self_$17907.PAdJkeGAVL.nDirection = this.$self_$17907.transform.forward;
									if (126209 - 579236 != -453027)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (187591 - 216676 != -29084)
						{
							goto Block_31;
						}
						continue;
					default:
						if (203618 - 460198 == -256579)
						{
							continue;
						}
						break;
					}
					this.$self_$17907.PAdJkeGAVL.actionState = "attack";
					if (1160 - 384471 != -383310)
					{
						this.$self_$17907.PAdJkeGAVL.actionTime = Time.time;
						if (88953 - 392833 == -303880)
						{
							this.$self_$17907.PAdJkeGAVL.myCommand = "nAttack";
							if (212387 - 447354 != -234966)
							{
								this.$self_$17907.PAdJkeGAVL.addTimeOut("nAttack", this.$self_$17907.PAdJkeGAVL.agiAdjust((float)3));
								if (160903 - 515599 == -354696)
								{
									this.$self_$17907.transform.position = this.$mPos$17905;
									if (52825 - 476851 == -424026)
									{
										this.$self_$17907.transform.LookAt(this.$mPos$17905 + global::Math.vFlat(this.$tDir$17906));
										if (101103 - 535007 == -433904)
										{
											this.$self_$17907.animation.CrossFade("nAttack1");
											if (223814 - 511569 == -287755)
											{
												this.$self_$17907.animation.wrapMode = WrapMode.Once;
												if (89889 - 64840 != 25050)
												{
													this.$self_$17907.PAdJkeGAVL.vMovement = this.$self_$17907.transform.forward;
													if (255273 - 113056 == 142217)
													{
														this.$self_$17907.PAdJkeGAVL.moveSpeed = (float)0;
														if (225527 - 418649 != -193121)
														{
															goto Block_16;
														}
													}
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
				goto IL_A5D;
				Block_2:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_C2:
				goto IL_A5D;
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_24:
				Block_31:
				goto IL_A5D;
				Block_50:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_A5D:
				return false;
			}

			// Token: 0x06000FCB RID: 4043 RVA: 0x0018E67C File Offset: 0x0018C87C
			internal static bool hKg8rlEyRsNKStbEK3k()
			{
				return true;
			}

			// Token: 0x06000FCC RID: 4044 RVA: 0x0018E680 File Offset: 0x0018C880
			internal static bool gD2kWaES5nXwicqXsKk()
			{
				return false;
			}

			// Token: 0x04000D9C RID: 3484
			internal int $hitLayer$17899;

			// Token: 0x04000D9D RID: 3485
			internal UnityScript.Lang.Array $hitList$17900;

			// Token: 0x04000D9E RID: 3486
			internal Vector3 $hitPoint$17901;

			// Token: 0x04000D9F RID: 3487
			internal int $hitAtk$17902;

			// Token: 0x04000DA0 RID: 3488
			internal GameObject $hitObject$17903;

			// Token: 0x04000DA1 RID: 3489
			internal IEnumerator $$iterator$9414$17904;

			// Token: 0x04000DA2 RID: 3490
			internal Vector3 $mPos$17905;

			// Token: 0x04000DA3 RID: 3491
			internal Vector3 $tDir$17906;

			// Token: 0x04000DA4 RID: 3492
			internal Gadina $self_$17907;
		}
	}

	// Token: 0x020002B5 RID: 693
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$17911 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FCD RID: 4045 RVA: 0x0018E684 File Offset: 0x0018C884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$17911(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (199450 - 366822 != -167372)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136376 - 177362 != -40985)
				{
					base..ctor();
					if (228973 - 171389 == 57584)
					{
						this.$mPos$17923 = mPos;
						if (52890 - 483100 != -430209)
						{
							this.$tDir$17924 = tDir;
							if (80316 - 283733 == -203417)
							{
								this.$self_$17925 = self_;
								if (239320 - 455931 != -216610)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0018E760 File Offset: 0x0018C960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_nAttack2$17911.$(this.$mPos$17923, this.$tDir$17924, this.$self_$17925);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0018E77C File Offset: 0x0018C97C
		internal static bool VaqaL6EoWGuW87PaSI6()
		{
			return true;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0018E780 File Offset: 0x0018C980
		internal static bool fGnWU0EEoeyMOJqeXvx()
		{
			return false;
		}

		// Token: 0x04000DA5 RID: 3493
		internal Vector3 $mPos$17923;

		// Token: 0x04000DA6 RID: 3494
		internal Vector3 $tDir$17924;

		// Token: 0x04000DA7 RID: 3495
		internal Gadina $self_$17925;

		// Token: 0x020002B6 RID: 694
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FD1 RID: 4049 RVA: 0x0018E784 File Offset: 0x0018C984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (261836 - 262254 != -417)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (52370 - 324301 != -271930)
					{
						base..ctor();
						if (115610 - 478661 == -363051)
						{
							this.$mPos$17920 = mPos;
							if (132293 - 97712 == 34581)
							{
								this.$tDir$17921 = tDir;
								if (63183 - 214671 != -151487)
								{
									this.$self_$17922 = self_;
									if (157337 - 539640 == -382303)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FD2 RID: 4050 RVA: 0x0018E860 File Offset: 0x0018CA60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62288 - 51689 != 10599)
				{
				}
				for (;;)
				{
					IL_358:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1032;
					case 2:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_727;
						}
						if (91823 - 546975 != -455152)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (83960 - 488216 != -404256)
							{
								continue;
							}
							goto IL_727;
						}
						else
						{
							this.$self_$17922.PAdJkeGAVL.moveSpeed = (float)6;
							if (7003 - 245571 != -238567)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_1D2;
						}
						if (10144 - 455621 != -445477)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (196646 - 560964 != -364318)
							{
								continue;
							}
							goto IL_1D2;
						}
						else
						{
							this.$hitLayer$17912 = 130816 - (1 << this.$self_$17922.gameObject.layer);
							if (241002 - 65560 == 175443)
							{
								continue;
							}
							this.$hitList$17913 = null;
							if (76893 - 421863 == -344969)
							{
								continue;
							}
							this.$hitPoint$17914 = default(Vector3);
							if (37892 - 329978 == -292085)
							{
								continue;
							}
							this.$hitAtk$17915 = this.$self_$17922.PAdJkeGAVL.atk;
							if (211382 - 135554 != 75828)
							{
								continue;
							}
							if (this.$self_$17922.isSummon)
							{
								if (29922 - 388466 != -358544)
								{
									continue;
								}
								if (this.$self_$17922.mSummonerChar)
								{
									if (128546 - 113001 == 15546)
									{
										continue;
									}
									if (this.$self_$17922.mSwordLv > eGadinaSwordLv.Lv1)
									{
										if (87308 - 406051 == -318742)
										{
											continue;
										}
										this.$hitAtk$17915 += Mathf.FloorToInt((0.1f * (float)this.$self_$17922.getSwordLv() + 0.1f) * (float)this.$self_$17922.mSummonerChar.atk);
										if (114455 - 103460 == 10996)
										{
											continue;
										}
									}
								}
							}
							if (!this.$self_$17922.PAdJkeGAVL.isMine)
							{
								goto IL_7E2;
							}
							if (83255 - 298121 == -214865)
							{
								continue;
							}
							this.$hitList$17913 = Damage.FindRecTarget(this.$self_$17922.transform.position - this.$self_$17922.PAdJkeGAVL.rangeMod * this.$self_$17922.transform.forward, this.$self_$17922.transform.forward, (float)1 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)4 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17922.PAdJkeGAVL.rangeMod, this.$hitLayer$17912);
							if (25935 - 28503 == -2567)
							{
								continue;
							}
							this.$$iterator$9415$17917 = UnityRuntimeServices.GetEnumerator(this.$hitList$17913);
							if (211204 - 407990 != -196786)
							{
								continue;
							}
							while (this.$$iterator$9415$17917.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9415$17917.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17916 = (GameObject)obj2;
								if (41489 - 161872 != -120383)
								{
									goto IL_358;
								}
								if (this.$self_$17922.PAdJkeGAVL.hit(1, this.$hitObject$17916, (int)(0.5f * (float)this.$hitAtk$17915), this.$self_$17922.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17915), 0.5f * this.$self_$17922.transform.forward) != 0)
								{
									if (124429 - 270866 == -146436)
									{
										goto IL_358;
									}
									this.$hitPoint$17914 = this.$hitObject$17916.collider.ClosestPointOnBounds(this.$self_$17922.transform.position + Vector3.up);
									if (186235 - 310149 != -123914)
									{
										goto IL_358;
									}
									UnityRuntimeServices.Update(this.$$iterator$9415$17917, this.$hitObject$17916);
									if (290248 - 123705 == 166544)
									{
										goto IL_358;
									}
									this.$self_$17922.RPC_nAttack_hit(this.$hitPoint$17914, this.$self_$17922.transform.forward, 0);
									if (131521 - 546698 == -415176)
									{
										goto IL_358;
									}
									this.$self_$17922.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17914, this.$self_$17922.transform.forward, 0);
									if (219905 - 37839 != 182066)
									{
										goto IL_358;
									}
								}
							}
							if (247054 - 189479 != 57575)
							{
								continue;
							}
							goto IL_7E2;
						}
						break;
					case 4:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_327;
						}
						if (48951 - 274332 == -225380)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (166679 - 326815 != -160136)
							{
								continue;
							}
							goto IL_327;
						}
						else
						{
							this.$self_$17922.PAdJkeGAVL.moveSpeed = (float)0;
							if (107011 - 26013 != 80998)
							{
								continue;
							}
							goto IL_54;
						}
						break;
					case 5:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_512;
						}
						if (190639 - 296962 == -106322)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (71094 - 565433 != -494339)
							{
								continue;
							}
							goto IL_512;
						}
						else
						{
							this.$self_$17922.PAdJkeGAVL.moveSpeed = (float)6;
							if (297248 - 351947 != -54698)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_F59;
						}
						if (222177 - 279234 == -57056)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (121749 - 228606 != -106857)
							{
								continue;
							}
							goto IL_F59;
						}
						else
						{
							if (!this.$self_$17922.PAdJkeGAVL.isMine)
							{
								goto IL_FE3;
							}
							if (89531 - 37423 == 52109)
							{
								continue;
							}
							this.$hitLayer$17912 = 130816 - (1 << this.$self_$17922.gameObject.layer) + 2 + 4;
							if (78490 - 139622 == -61131)
							{
								continue;
							}
							this.$hitList$17913 = Damage.FindRecTarget(this.$self_$17922.transform.position - this.$self_$17922.PAdJkeGAVL.rangeMod * this.$self_$17922.transform.forward, this.$self_$17922.transform.forward, (float)1 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)4 * this.$self_$17922.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17922.PAdJkeGAVL.rangeMod, this.$hitLayer$17912);
							if (236000 - 221166 != 14834)
							{
								continue;
							}
							this.$$iterator$9416$17919 = UnityRuntimeServices.GetEnumerator(this.$hitList$17913);
							if (101970 - 315603 != -213633)
							{
								continue;
							}
							while (this.$$iterator$9416$17919.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9416$17919.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17918 = (GameObject)obj4;
								if (287236 - 444193 == -156956)
								{
									goto IL_358;
								}
								if (this.$self_$17922.PAdJkeGAVL.hit(1, this.$hitObject$17918, (int)(0.5f * (float)this.$hitAtk$17915), this.$self_$17922.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17915), 0.5f * this.$self_$17922.transform.forward) != 0)
								{
									if (125388 - 150423 == -25034)
									{
										goto IL_358;
									}
									this.$hitPoint$17914 = this.$hitObject$17918.collider.ClosestPointOnBounds(this.$self_$17922.transform.position + Vector3.up);
									if (240369 - 211246 != 29123)
									{
										goto IL_358;
									}
									UnityRuntimeServices.Update(this.$$iterator$9416$17919, this.$hitObject$17918);
									if (154568 - 382338 == -227769)
									{
										goto IL_358;
									}
									this.$self_$17922.RPC_nAttack_hit(this.$hitPoint$17914, this.$self_$17922.transform.forward, 0);
									if (14962 - 447937 != -432975)
									{
										goto IL_358;
									}
									this.$self_$17922.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17914, this.$self_$17922.transform.forward, 0);
									if (272027 - 454287 == -182259)
									{
										goto IL_358;
									}
								}
							}
							if (56473 - 494327 != -437854)
							{
								continue;
							}
							goto IL_FE3;
						}
						break;
					case 7:
						if (this.$self_$17922.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_41B;
						}
						if (217827 - 35995 != 181832)
						{
							continue;
						}
						if (this.$self_$17922.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (219462 - 25201 != 194261)
							{
								continue;
							}
							goto IL_41B;
						}
						else
						{
							this.$self_$17922.PAdJkeGAVL.moveSpeed = (float)0;
							if (78368 - 474403 != -396035)
							{
								continue;
							}
							goto IL_3CC;
						}
						break;
					case 8:
						if (this.$self_$17922.PAdJkeGAVL.actionState == "attack")
						{
							if (201758 - 42021 != 159737)
							{
								continue;
							}
							if (this.$self_$17922.PAdJkeGAVL.myCommand == "nAttack")
							{
								if (137832 - 333094 != -195262)
								{
									continue;
								}
								this.$self_$17922.PAdJkeGAVL.actionState = "standby";
								if (98344 - 471576 != -373232)
								{
									continue;
								}
								this.$self_$17922.PAdJkeGAVL.actionTime = Time.time;
								if (120321 - 248245 != -127924)
								{
									continue;
								}
								this.$self_$17922.PAdJkeGAVL.myCommand = "none";
								if (234945 - 473997 == -239051)
								{
									continue;
								}
								if (!this.$self_$17922.PAdJkeGAVL.isMine)
								{
									if (134206 - 220356 != -86150)
									{
										continue;
									}
									this.$self_$17922.PAdJkeGAVL.nPosition = this.$self_$17922.transform.position;
									if (183786 - 450062 == -266275)
									{
										continue;
									}
									this.$self_$17922.PAdJkeGAVL.oPosition = this.$self_$17922.transform.position;
									if (31051 - 75612 != -44561)
									{
										continue;
									}
									this.$self_$17922.PAdJkeGAVL.nDirection = this.$self_$17922.transform.forward;
									if (178421 - 285605 != -107184)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (232360 - 211591 != 20770)
						{
							goto Block_40;
						}
						continue;
					default:
						if (104940 - 201199 != -96259)
						{
							continue;
						}
						break;
					}
					this.$self_$17922.PAdJkeGAVL.actionState = "attack";
					if (297265 - 451611 != -154345)
					{
						this.$self_$17922.PAdJkeGAVL.actionTime = Time.time;
						if (139069 - 522906 != -383836)
						{
							this.$self_$17922.PAdJkeGAVL.myCommand = "nAttack";
							if (71750 - 101792 == -30042)
							{
								this.$self_$17922.PAdJkeGAVL.addTimeOut("nAttack", this.$self_$17922.PAdJkeGAVL.agiAdjust((float)3));
								if (111360 - 418562 != -307201)
								{
									this.$self_$17922.transform.position = this.$mPos$17920;
									if (294202 - 366183 == -71981)
									{
										this.$self_$17922.transform.LookAt(this.$mPos$17920 + global::Math.vFlat(this.$tDir$17921));
										if (21802 - 305757 == -283955)
										{
											this.$self_$17922.animation.CrossFade("nAttack2");
											if (142839 - 441896 == -299057)
											{
												this.$self_$17922.animation.wrapMode = WrapMode.Once;
												if (225690 - 386598 == -160908)
												{
													this.$self_$17922.PAdJkeGAVL.vMovement = this.$self_$17922.transform.forward;
													if (46365 - 188345 != -141979)
													{
														this.$self_$17922.PAdJkeGAVL.moveSpeed = (float)0;
														if (202300 - 36099 != 166202)
														{
															goto Block_79;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_54:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_1D2:
				IL_327:
				goto IL_1032;
				IL_3CC:
				return this.Yield(8, new WaitForSeconds(0.1f));
				IL_41B:
				IL_512:
				goto IL_1032;
				Block_27:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_727:
				goto IL_1032;
				Block_37:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_40:
				goto IL_1032;
				IL_7E2:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_79:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_F59:
				goto IL_1032;
				IL_FE3:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_1032:
				return false;
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x0018F8B4 File Offset: 0x0018DAB4
			internal static bool cVRV4KE2YnjGhP9Pnyd()
			{
				return true;
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x0018F8B8 File Offset: 0x0018DAB8
			internal static bool UaiCKbE8cea84BBFZK3()
			{
				return false;
			}

			// Token: 0x04000DA8 RID: 3496
			internal int $hitLayer$17912;

			// Token: 0x04000DA9 RID: 3497
			internal UnityScript.Lang.Array $hitList$17913;

			// Token: 0x04000DAA RID: 3498
			internal Vector3 $hitPoint$17914;

			// Token: 0x04000DAB RID: 3499
			internal int $hitAtk$17915;

			// Token: 0x04000DAC RID: 3500
			internal GameObject $hitObject$17916;

			// Token: 0x04000DAD RID: 3501
			internal IEnumerator $$iterator$9415$17917;

			// Token: 0x04000DAE RID: 3502
			internal GameObject $hitObject$17918;

			// Token: 0x04000DAF RID: 3503
			internal IEnumerator $$iterator$9416$17919;

			// Token: 0x04000DB0 RID: 3504
			internal Vector3 $mPos$17920;

			// Token: 0x04000DB1 RID: 3505
			internal Vector3 $tDir$17921;

			// Token: 0x04000DB2 RID: 3506
			internal Gadina $self_$17922;
		}
	}

	// Token: 0x020002B7 RID: 695
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$17926 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x0018F8BC File Offset: 0x0018DABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$17926(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (263968 - 287159 != -23191)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50807 - 482338 != -431530)
				{
					base..ctor();
					if (159425 - 287411 == -127986)
					{
						this.$mPos$17940 = mPos;
						if (206093 - 297882 == -91789)
						{
							this.$tDir$17941 = tDir;
							if (91773 - 34045 != 57729)
							{
								this.$self_$17942 = self_;
								if (22628 - 524334 == -501706)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0018F998 File Offset: 0x0018DB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_nAttack3$17926.$(this.$mPos$17940, this.$tDir$17941, this.$self_$17942);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0018F9B4 File Offset: 0x0018DBB4
		internal static bool sTD3q0EZrQmdauoItbo()
		{
			return true;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0018F9B8 File Offset: 0x0018DBB8
		internal static bool pNLAoIECyX9Sqfg4o7x()
		{
			return false;
		}

		// Token: 0x04000DB3 RID: 3507
		internal Vector3 $mPos$17940;

		// Token: 0x04000DB4 RID: 3508
		internal Vector3 $tDir$17941;

		// Token: 0x04000DB5 RID: 3509
		internal Gadina $self_$17942;

		// Token: 0x020002B8 RID: 696
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FD9 RID: 4057 RVA: 0x0018F9BC File Offset: 0x0018DBBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (287847 - 320452 != -32605)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (287107 - 19163 == 267944)
					{
						base..ctor();
						if (267447 - 554532 != -287084)
						{
							this.$mPos$17937 = mPos;
							if (297153 - 516776 == -219623)
							{
								this.$tDir$17938 = tDir;
								if (30717 - 279902 == -249185)
								{
									this.$self_$17939 = self_;
									if (248127 - 286375 != -38247)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FDA RID: 4058 RVA: 0x0018FA98 File Offset: 0x0018DC98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50570 - 232912 != -182342)
				{
				}
				for (;;)
				{
					IL_F5B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1470;
					case 2:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_E89;
						}
						if (72537 - 295810 != -223273)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (220705 - 412886 != -192180)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)6;
							if (249612 - 464947 != -215334)
							{
								goto Block_82;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_E1D;
						}
						if (56309 - 534283 == -477973)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (152452 - 496996 != -344543)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$hitPoint$17927 = default(Vector3);
							if (33504 - 77880 != -44376)
							{
								continue;
							}
							this.$hitLayer$17928 = 130816 - (1 << this.$self_$17939.gameObject.layer);
							if (267806 - 151007 != 116799)
							{
								continue;
							}
							this.$hitList$17929 = null;
							if (56483 - 554551 != -498068)
							{
								continue;
							}
							this.$hitAtk$17930 = this.$self_$17939.PAdJkeGAVL.atk;
							if (45475 - 302009 != -256534)
							{
								continue;
							}
							if (this.$self_$17939.isSummon)
							{
								if (138128 - 81997 != 56131)
								{
									continue;
								}
								if (this.$self_$17939.mSummonerChar)
								{
									if (36847 - 372935 == -336087)
									{
										continue;
									}
									if (this.$self_$17939.mSwordLv > eGadinaSwordLv.Lv1)
									{
										if (173442 - 284 == 173159)
										{
											continue;
										}
										this.$hitAtk$17930 += Mathf.FloorToInt((0.1f * (float)this.$self_$17939.getSwordLv() + 0.1f) * (float)this.$self_$17939.mSummonerChar.atk);
										if (212683 - 95416 == 117268)
										{
											continue;
										}
									}
								}
							}
							if (!this.$self_$17939.PAdJkeGAVL.isMine)
							{
								goto IL_518;
							}
							if (227857 - 369962 != -142105)
							{
								continue;
							}
							this.$hitList$17929 = Damage.FindRecTarget(this.$self_$17939.transform.position - this.$self_$17939.PAdJkeGAVL.rangeMod * this.$self_$17939.transform.forward, this.$self_$17939.transform.forward, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17939.PAdJkeGAVL.rangeMod, this.$hitLayer$17928);
							if (74034 - 292190 == -218155)
							{
								continue;
							}
							this.$$iterator$9417$17932 = UnityRuntimeServices.GetEnumerator(this.$hitList$17929);
							if (24343 - 158216 == -133872)
							{
								continue;
							}
							while (this.$$iterator$9417$17932.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9417$17932.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17931 = (GameObject)obj2;
								if (130343 - 177631 == -47287)
								{
									goto IL_F5B;
								}
								if (this.$self_$17939.PAdJkeGAVL.hit(1, this.$hitObject$17931, (int)(0.5f * (float)this.$hitAtk$17930), this.$self_$17939.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17930), 0.5f * this.$self_$17939.transform.forward) != 0)
								{
									if (254273 - 284841 == -30567)
									{
										goto IL_F5B;
									}
									this.$hitPoint$17927 = this.$hitObject$17931.collider.ClosestPointOnBounds(this.$self_$17939.transform.position + Vector3.up);
									if (195717 - 397823 == -202105)
									{
										goto IL_F5B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9417$17932, this.$hitObject$17931);
									if (105272 - 541689 != -436417)
									{
										goto IL_F5B;
									}
									this.$self_$17939.RPC_nAttack_hit(this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (24466 - 536144 != -511678)
									{
										goto IL_F5B;
									}
									this.$self_$17939.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (295236 - 550501 != -255265)
									{
										goto IL_F5B;
									}
								}
							}
							if (219280 - 140302 != 78979)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_1006;
						}
						if (172994 - 513637 != -340643)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (211473 - 523727 != -312253)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)0;
							if (65185 - 102323 != -37137)
							{
								goto Block_91;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_CA8;
						}
						if (184207 - 197431 == -13223)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (35921 - 9401 != 26521)
							{
								goto Block_107;
							}
							continue;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)6;
							if (30751 - 140964 != -110213)
							{
								continue;
							}
							goto IL_1078;
						}
						break;
					case 6:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_1D9;
						}
						if (165893 - 285940 == -120046)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (57606 - 459026 != -401419)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17939.PAdJkeGAVL.isMine)
							{
								goto IL_10C7;
							}
							if (231016 - 428813 != -197797)
							{
								continue;
							}
							this.$hitList$17929 = Damage.FindRecTarget(this.$self_$17939.transform.position - this.$self_$17939.PAdJkeGAVL.rangeMod * this.$self_$17939.transform.forward, this.$self_$17939.transform.forward, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17939.PAdJkeGAVL.rangeMod, this.$hitLayer$17928);
							if (37499 - 477644 != -440145)
							{
								continue;
							}
							this.$$iterator$9418$17934 = UnityRuntimeServices.GetEnumerator(this.$hitList$17929);
							if (327 - 526620 != -526293)
							{
								continue;
							}
							while (this.$$iterator$9418$17934.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9418$17934.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17933 = (GameObject)obj4;
								if (248789 - 546348 == -297558)
								{
									goto IL_F5B;
								}
								if (this.$self_$17939.PAdJkeGAVL.hit(1, this.$hitObject$17933, (int)(0.5f * (float)this.$hitAtk$17930), this.$self_$17939.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17930), 0.5f * this.$self_$17939.transform.forward) != 0)
								{
									if (24089 - 393416 != -369327)
									{
										goto IL_F5B;
									}
									this.$hitPoint$17927 = this.$hitObject$17933.collider.ClosestPointOnBounds(this.$self_$17939.transform.position + Vector3.up);
									if (243428 - 396073 != -152645)
									{
										goto IL_F5B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9418$17934, this.$hitObject$17933);
									if (294715 - 589820 != -295105)
									{
										goto IL_F5B;
									}
									this.$self_$17939.RPC_nAttack_hit(this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (251390 - 452062 != -200672)
									{
										goto IL_F5B;
									}
									this.$self_$17939.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (273435 - 54646 == 218790)
									{
										goto IL_F5B;
									}
								}
							}
							if (264705 - 408240 != -143535)
							{
								continue;
							}
							goto IL_10C7;
						}
						break;
					case 7:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_CD9;
						}
						if (243235 - 76197 == 167039)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (36850 - 407126 != -370276)
							{
								continue;
							}
							goto IL_CD9;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)0;
							if (29184 - 355080 != -325896)
							{
								continue;
							}
							goto IL_408;
						}
						break;
					case 8:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_A76;
						}
						if (97406 - 265194 != -167788)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (20114 - 429477 != -409363)
							{
								continue;
							}
							goto IL_A76;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)-3;
							if (93747 - 33392 != 60355)
							{
								continue;
							}
							goto IL_628;
						}
						break;
					case 9:
						if (this.$self_$17939.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_99A;
						}
						if (151410 - 124008 == 27403)
						{
							continue;
						}
						if (this.$self_$17939.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (202719 - 329889 != -127170)
							{
								continue;
							}
							goto IL_99A;
						}
						else
						{
							this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)0;
							if (261222 - 347567 != -86345)
							{
								continue;
							}
							if (!this.$self_$17939.PAdJkeGAVL.isMine)
							{
								goto IL_AF;
							}
							if (265770 - 289850 == -24079)
							{
								continue;
							}
							this.$hitList$17929 = Damage.FindRecTarget(this.$self_$17939.transform.position - this.$self_$17939.PAdJkeGAVL.rangeMod * this.$self_$17939.transform.forward, this.$self_$17939.transform.forward, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17939.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17939.PAdJkeGAVL.rangeMod, this.$hitLayer$17928);
							if (44174 - 350325 != -306151)
							{
								continue;
							}
							this.$$iterator$9419$17936 = UnityRuntimeServices.GetEnumerator(this.$hitList$17929);
							if (283605 - 167697 != 115908)
							{
								continue;
							}
							while (this.$$iterator$9419$17936.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$9419$17936.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$17935 = (GameObject)obj6;
								if (24256 - 571560 == -547303)
								{
									goto IL_F5B;
								}
								if (this.$self_$17939.PAdJkeGAVL.hit(1, this.$hitObject$17935, (int)(0.5f * (float)this.$hitAtk$17930), this.$self_$17939.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17930), 0.5f * this.$self_$17939.transform.forward) != 0)
								{
									if (292323 - 286410 != 5913)
									{
										goto IL_F5B;
									}
									this.$hitPoint$17927 = this.$hitObject$17935.collider.ClosestPointOnBounds(this.$self_$17939.transform.position + Vector3.up);
									if (125637 - 27601 == 98037)
									{
										goto IL_F5B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9419$17936, this.$hitObject$17935);
									if (5964 - 450371 != -444407)
									{
										goto IL_F5B;
									}
									this.$self_$17939.RPC_nAttack_hit(this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (20101 - 381947 != -361846)
									{
										goto IL_F5B;
									}
									this.$self_$17939.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17927, this.$self_$17939.transform.forward, 0);
									if (235681 - 529167 == -293485)
									{
										goto IL_F5B;
									}
								}
							}
							if (34492 - 146143 != -111651)
							{
								continue;
							}
							goto IL_AF;
						}
						break;
					case 10:
						if (this.$self_$17939.PAdJkeGAVL.actionState == "attack")
						{
							if (107683 - 147133 != -39450)
							{
								continue;
							}
							if (this.$self_$17939.PAdJkeGAVL.myCommand == "nAttack")
							{
								if (12288 - 187427 != -175139)
								{
									continue;
								}
								this.$self_$17939.PAdJkeGAVL.actionState = "standby";
								if (13912 - 532287 == -518374)
								{
									continue;
								}
								this.$self_$17939.PAdJkeGAVL.actionTime = Time.time;
								if (64841 - 461204 == -396362)
								{
									continue;
								}
								this.$self_$17939.PAdJkeGAVL.myCommand = "none";
								if (127303 - 591117 != -463814)
								{
									continue;
								}
								if (!this.$self_$17939.PAdJkeGAVL.isMine)
								{
									if (176315 - 576150 == -399834)
									{
										continue;
									}
									this.$self_$17939.PAdJkeGAVL.nPosition = this.$self_$17939.transform.position;
									if (133852 - 153811 != -19959)
									{
										continue;
									}
									this.$self_$17939.PAdJkeGAVL.oPosition = this.$self_$17939.transform.position;
									if (199744 - 61648 == 138097)
									{
										continue;
									}
									this.$self_$17939.PAdJkeGAVL.nDirection = this.$self_$17939.transform.forward;
									if (286747 - 469325 == -182577)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (202288 - 520437 != -318149)
						{
							continue;
						}
						goto IL_1470;
					default:
						if (9747 - 59281 == -49533)
						{
							continue;
						}
						break;
					}
					this.$self_$17939.PAdJkeGAVL.actionState = "attack";
					if (111331 - 516223 != -404891)
					{
						this.$self_$17939.PAdJkeGAVL.actionTime = Time.time;
						if (197104 - 564986 == -367882)
						{
							this.$self_$17939.PAdJkeGAVL.myCommand = "nAttack";
							if (243274 - 580002 != -336727)
							{
								this.$self_$17939.PAdJkeGAVL.addTimeOut("nAttack", this.$self_$17939.PAdJkeGAVL.agiAdjust((float)4));
								if (84889 - 166854 != -81964)
								{
									this.$self_$17939.transform.position = this.$mPos$17937;
									if (202319 - 239097 != -36777)
									{
										this.$self_$17939.transform.LookAt(this.$mPos$17937 + global::Math.vFlat(this.$tDir$17938));
										if (222632 - 136898 == 85734)
										{
											this.$self_$17939.animation.CrossFade("nAttack3");
											if (184830 - 579624 != -394793)
											{
												this.$self_$17939.animation.wrapMode = WrapMode.Once;
												if (48856 - 269911 == -221055)
												{
													this.$self_$17939.PAdJkeGAVL.vMovement = this.$self_$17939.transform.forward;
													if (285765 - 220093 == 65672)
													{
														this.$self_$17939.PAdJkeGAVL.moveSpeed = (float)0;
														if (233719 - 542183 != -308463)
														{
															goto Block_83;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AF:
				return this.Yield(10, new WaitForSeconds(0.3f));
				IL_1D9:
				Block_25:
				goto IL_E89;
				IL_408:
				return this.Yield(8, new WaitForSeconds(0.2f));
				IL_518:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_628:
				return this.Yield(9, new WaitForSeconds(0.1f));
				Block_39:
				Block_44:
				goto IL_E1D;
				Block_53:
				goto IL_518;
				IL_99A:
				Block_58:
				IL_A76:
				IL_CA8:
				IL_CD9:
				IL_E1D:
				IL_E89:
				goto IL_1470;
				Block_82:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_83:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_1006:
				goto IL_1470;
				Block_91:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_1078:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_10C7:
				return this.Yield(7, new WaitForSeconds(0.1f));
				Block_107:
				IL_1470:
				return false;
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x00190F28 File Offset: 0x0018F128
			internal static bool tYXMmfELmBNF8IDjwws()
			{
				return true;
			}

			// Token: 0x06000FDC RID: 4060 RVA: 0x00190F2C File Offset: 0x0018F12C
			internal static bool a8Fe4hEOtXLZ7au7Viv()
			{
				return false;
			}

			// Token: 0x04000DB6 RID: 3510
			internal Vector3 $hitPoint$17927;

			// Token: 0x04000DB7 RID: 3511
			internal int $hitLayer$17928;

			// Token: 0x04000DB8 RID: 3512
			internal UnityScript.Lang.Array $hitList$17929;

			// Token: 0x04000DB9 RID: 3513
			internal int $hitAtk$17930;

			// Token: 0x04000DBA RID: 3514
			internal GameObject $hitObject$17931;

			// Token: 0x04000DBB RID: 3515
			internal IEnumerator $$iterator$9417$17932;

			// Token: 0x04000DBC RID: 3516
			internal GameObject $hitObject$17933;

			// Token: 0x04000DBD RID: 3517
			internal IEnumerator $$iterator$9418$17934;

			// Token: 0x04000DBE RID: 3518
			internal GameObject $hitObject$17935;

			// Token: 0x04000DBF RID: 3519
			internal IEnumerator $$iterator$9419$17936;

			// Token: 0x04000DC0 RID: 3520
			internal Vector3 $mPos$17937;

			// Token: 0x04000DC1 RID: 3521
			internal Vector3 $tDir$17938;

			// Token: 0x04000DC2 RID: 3522
			internal Gadina $self_$17939;
		}
	}

	// Token: 0x020002B9 RID: 697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack4$17943 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x00190F30 File Offset: 0x0018F130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack4$17943(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (218968 - 323280 != -104312)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121133 - 34752 != 86382)
				{
					base..ctor();
					if (107970 - 473501 == -365531)
					{
						this.$mPos$17957 = mPos;
						if (242066 - 318737 != -76670)
						{
							this.$tDir$17958 = tDir;
							if (203819 - 532537 != -328717)
							{
								this.$self_$17959 = self_;
								if (180296 - 217673 == -37377)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0019100C File Offset: 0x0018F20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_nAttack4$17943.$(this.$mPos$17957, this.$tDir$17958, this.$self_$17959);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00191028 File Offset: 0x0018F228
		internal static bool EFuxlZEmh5GMX5yvSu4()
		{
			return true;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0019102C File Offset: 0x0018F22C
		internal static bool yGvVSHEFlPfFTC1bA5E()
		{
			return false;
		}

		// Token: 0x04000DC3 RID: 3523
		internal Vector3 $mPos$17957;

		// Token: 0x04000DC4 RID: 3524
		internal Vector3 $tDir$17958;

		// Token: 0x04000DC5 RID: 3525
		internal Gadina $self_$17959;

		// Token: 0x020002BA RID: 698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FE1 RID: 4065 RVA: 0x00191030 File Offset: 0x0018F230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (133989 - 288328 != -154338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46969 - 559962 != -512992)
					{
						base..ctor();
						if (103636 - 503813 == -400177)
						{
							this.$mPos$17954 = mPos;
							if (84429 - 262246 != -177816)
							{
								this.$tDir$17955 = tDir;
								if (144847 - 256223 != -111375)
								{
									this.$self_$17956 = self_;
									if (166424 - 91073 != 75352)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FE2 RID: 4066 RVA: 0x0019110C File Offset: 0x0018F30C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20648 - 412536 != -391887)
				{
				}
				for (;;)
				{
					IL_460:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1470;
					case 2:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_3D3;
						}
						if (33542 - 523745 != -490203)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (124688 - 326671 != -201983)
							{
								continue;
							}
							goto IL_3D3;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)6;
							if (24618 - 176452 != -151834)
							{
								continue;
							}
							goto IL_10FA;
						}
						break;
					case 3:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_A76;
						}
						if (121234 - 293045 != -171811)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (47708 - 560838 != -513129)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$hitPoint$17944 = default(Vector3);
							if (26899 - 336699 != -309800)
							{
								continue;
							}
							this.$hitLayer$17945 = 130816 - (1 << this.$self_$17956.gameObject.layer);
							if (283817 - 166512 == 117306)
							{
								continue;
							}
							this.$hitList$17946 = null;
							if (73350 - 177755 != -104405)
							{
								continue;
							}
							this.$hitAtk$17947 = this.$self_$17956.PAdJkeGAVL.atk;
							if (49078 - 399015 == -349936)
							{
								continue;
							}
							if (this.$self_$17956.isSummon)
							{
								if (191751 - 300111 == -108359)
								{
									continue;
								}
								if (this.$self_$17956.mSummonerChar)
								{
									if (217697 - 68225 != 149472)
									{
										continue;
									}
									if (this.$self_$17956.mSwordLv > eGadinaSwordLv.Lv1)
									{
										if (2000 - 367659 != -365659)
										{
											continue;
										}
										this.$hitAtk$17947 += Mathf.FloorToInt((0.1f * (float)this.$self_$17956.getSwordLv() + 0.1f) * (float)this.$self_$17956.mSummonerChar.atk);
										if (85861 - 528662 == -442800)
										{
											continue;
										}
									}
								}
							}
							if (!this.$self_$17956.PAdJkeGAVL.isMine)
							{
								goto IL_1A4;
							}
							if (246645 - 442660 != -196015)
							{
								continue;
							}
							this.$hitList$17946 = Damage.FindRecTarget(this.$self_$17956.transform.position - this.$self_$17956.PAdJkeGAVL.rangeMod * this.$self_$17956.transform.forward, this.$self_$17956.transform.forward, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17956.PAdJkeGAVL.rangeMod, this.$hitLayer$17945);
							if (129532 - 285234 != -155702)
							{
								continue;
							}
							this.$$iterator$9420$17949 = UnityRuntimeServices.GetEnumerator(this.$hitList$17946);
							if (174104 - 447084 == -272979)
							{
								continue;
							}
							while (this.$$iterator$9420$17949.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9420$17949.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17948 = (GameObject)obj2;
								if (120810 - 297232 == -176421)
								{
									goto IL_460;
								}
								if (this.$self_$17956.PAdJkeGAVL.hit(1, this.$hitObject$17948, (int)(0.5f * (float)this.$hitAtk$17947), this.$self_$17956.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17947), 0.5f * this.$self_$17956.transform.forward) != 0)
								{
									if (45541 - 593404 != -547863)
									{
										goto IL_460;
									}
									this.$hitPoint$17944 = this.$hitObject$17948.collider.ClosestPointOnBounds(this.$self_$17956.transform.position + Vector3.up);
									if (89084 - 336996 == -247911)
									{
										goto IL_460;
									}
									UnityRuntimeServices.Update(this.$$iterator$9420$17949, this.$hitObject$17948);
									if (44501 - 180867 == -136365)
									{
										goto IL_460;
									}
									this.$self_$17956.RPC_nAttack_hit(this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (273682 - 721 != 272961)
									{
										goto IL_460;
									}
									this.$self_$17956.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (21140 - 406484 == -385343)
									{
										goto IL_460;
									}
								}
							}
							if (293911 - 431558 != -137647)
							{
								continue;
							}
							goto IL_1A4;
						}
						break;
					case 4:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_1285;
						}
						if (40968 - 428024 == -387055)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (59910 - 440955 != -381044)
							{
								goto Block_99;
							}
							continue;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)0;
							if (56980 - 596361 != -539381)
							{
								continue;
							}
							goto IL_C15;
						}
						break;
					case 5:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_11EE;
						}
						if (124842 - 391358 == -266515)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (166711 - 389379 != -222668)
							{
								continue;
							}
							goto IL_11EE;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)6;
							if (195855 - 141006 != 54849)
							{
								continue;
							}
							goto IL_F7C;
						}
						break;
					case 6:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_DCA;
						}
						if (159310 - 98157 != 61153)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (291103 - 565659 != -274555)
							{
								goto Block_77;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17956.PAdJkeGAVL.isMine)
							{
								goto IL_259;
							}
							if (231243 - 284906 != -53663)
							{
								continue;
							}
							this.$hitList$17946 = Damage.FindRecTarget(this.$self_$17956.transform.position - this.$self_$17956.PAdJkeGAVL.rangeMod * this.$self_$17956.transform.forward, this.$self_$17956.transform.forward, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17956.PAdJkeGAVL.rangeMod, this.$hitLayer$17945);
							if (92617 - 48615 == 44003)
							{
								continue;
							}
							this.$$iterator$9421$17951 = UnityRuntimeServices.GetEnumerator(this.$hitList$17946);
							if (164458 - 317006 == -152547)
							{
								continue;
							}
							while (this.$$iterator$9421$17951.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9421$17951.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17950 = (GameObject)obj4;
								if (89357 - 272537 == -183179)
								{
									goto IL_460;
								}
								if (this.$self_$17956.PAdJkeGAVL.hit(1, this.$hitObject$17950, (int)(0.5f * (float)this.$hitAtk$17947), this.$self_$17956.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17947), 0.5f * this.$self_$17956.transform.forward) != 0)
								{
									if (138119 - 142417 != -4298)
									{
										goto IL_460;
									}
									this.$hitPoint$17944 = this.$hitObject$17950.collider.ClosestPointOnBounds(this.$self_$17956.transform.position + Vector3.up);
									if (108583 - 479882 == -371298)
									{
										goto IL_460;
									}
									UnityRuntimeServices.Update(this.$$iterator$9421$17951, this.$hitObject$17950);
									if (245438 - 483860 != -238422)
									{
										goto IL_460;
									}
									this.$self_$17956.RPC_nAttack_hit(this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (270603 - 417009 != -146406)
									{
										goto IL_460;
									}
									this.$self_$17956.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (213306 - 1438 != 211868)
									{
										goto IL_460;
									}
								}
							}
							if (44591 - 436706 != -392115)
							{
								continue;
							}
							goto IL_259;
						}
						break;
					case 7:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_404;
						}
						if (239159 - 308869 == -69709)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (214660 - 494098 != -279438)
							{
								continue;
							}
							goto IL_404;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)0;
							if (139071 - 400386 != -261314)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 8:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_820;
						}
						if (37956 - 121637 != -83681)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (251534 - 550350 != -298815)
							{
								goto Block_90;
							}
							continue;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)-3;
							if (131644 - 309133 != -177489)
							{
								continue;
							}
							goto IL_768;
						}
						break;
					case 9:
						if (this.$self_$17956.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_369;
						}
						if (272405 - 94913 != 177492)
						{
							continue;
						}
						if (this.$self_$17956.PAdJkeGAVL.myCommand != "nAttack")
						{
							if (51864 - 214136 != -162272)
							{
								continue;
							}
							goto IL_369;
						}
						else
						{
							this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)0;
							if (189139 - 305060 != -115921)
							{
								continue;
							}
							if (!this.$self_$17956.PAdJkeGAVL.isMine)
							{
								goto IL_1033;
							}
							if (65069 - 392365 == -327295)
							{
								continue;
							}
							this.$hitList$17946 = Damage.FindRecTarget(this.$self_$17956.transform.position - this.$self_$17956.PAdJkeGAVL.rangeMod * this.$self_$17956.transform.forward, this.$self_$17956.transform.forward, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)1 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)5 * this.$self_$17956.PAdJkeGAVL.rangeMod, (float)2 * this.$self_$17956.PAdJkeGAVL.rangeMod, this.$hitLayer$17945);
							if (84037 - 160753 == -76715)
							{
								continue;
							}
							this.$$iterator$9422$17953 = UnityRuntimeServices.GetEnumerator(this.$hitList$17946);
							if (39434 - 502003 != -462569)
							{
								continue;
							}
							while (this.$$iterator$9422$17953.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$9422$17953.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$17952 = (GameObject)obj6;
								if (205706 - 437281 == -231574)
								{
									goto IL_460;
								}
								if (this.$self_$17956.PAdJkeGAVL.hit(1, this.$hitObject$17952, (int)(0.5f * (float)this.$hitAtk$17947), this.$self_$17956.getSwordLv(), (int)(0.5f * (float)this.$hitAtk$17947), 0.5f * this.$self_$17956.transform.forward) != 0)
								{
									if (136316 - 346080 != -209764)
									{
										goto IL_460;
									}
									this.$hitPoint$17944 = this.$hitObject$17952.collider.ClosestPointOnBounds(this.$self_$17956.transform.position + Vector3.up);
									if (67494 - 513667 != -446173)
									{
										goto IL_460;
									}
									UnityRuntimeServices.Update(this.$$iterator$9422$17953, this.$hitObject$17952);
									if (53670 - 506149 == -452478)
									{
										goto IL_460;
									}
									this.$self_$17956.RPC_nAttack_hit(this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (296243 - 417642 == -121398)
									{
										goto IL_460;
									}
									this.$self_$17956.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17944, this.$self_$17956.transform.forward, 0);
									if (60494 - 347264 != -286770)
									{
										goto IL_460;
									}
								}
							}
							if (130164 - 391013 != -260849)
							{
								continue;
							}
							goto IL_1033;
						}
						break;
					case 10:
						if (this.$self_$17956.PAdJkeGAVL.actionState == "attack")
						{
							if (32882 - 539005 == -506122)
							{
								continue;
							}
							if (this.$self_$17956.PAdJkeGAVL.myCommand == "nAttack")
							{
								if (31393 - 292684 != -261291)
								{
									continue;
								}
								this.$self_$17956.PAdJkeGAVL.actionState = "standby";
								if (3730 - 169308 == -165577)
								{
									continue;
								}
								this.$self_$17956.PAdJkeGAVL.actionTime = Time.time;
								if (8671 - 271390 == -262718)
								{
									continue;
								}
								this.$self_$17956.PAdJkeGAVL.myCommand = "none";
								if (190107 - 354788 != -164681)
								{
									continue;
								}
								if (!this.$self_$17956.PAdJkeGAVL.isMine)
								{
									if (151976 - 559977 != -408001)
									{
										continue;
									}
									this.$self_$17956.PAdJkeGAVL.nPosition = this.$self_$17956.transform.position;
									if (135257 - 331384 == -196126)
									{
										continue;
									}
									this.$self_$17956.PAdJkeGAVL.oPosition = this.$self_$17956.transform.position;
									if (73582 - 39101 == 34482)
									{
										continue;
									}
									this.$self_$17956.PAdJkeGAVL.nDirection = this.$self_$17956.transform.forward;
									if (275505 - 315027 != -39522)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (31595 - 132657 != -101062)
						{
							continue;
						}
						goto IL_1470;
					default:
						if (31053 - 599743 != -568690)
						{
							continue;
						}
						break;
					}
					this.$self_$17956.PAdJkeGAVL.actionState = "attack";
					if (164396 - 248312 != -83915)
					{
						this.$self_$17956.PAdJkeGAVL.actionTime = Time.time;
						if (161760 - 152866 == 8894)
						{
							this.$self_$17956.PAdJkeGAVL.myCommand = "nAttack";
							if (78155 - 300425 == -222270)
							{
								this.$self_$17956.PAdJkeGAVL.addTimeOut("nAttack", this.$self_$17956.PAdJkeGAVL.agiAdjust((float)4));
								if (143285 - 420081 != -276795)
								{
									this.$self_$17956.transform.position = this.$mPos$17954;
									if (47206 - 284436 != -237229)
									{
										this.$self_$17956.transform.LookAt(this.$mPos$17954 + global::Math.vFlat(this.$tDir$17955));
										if (166839 - 538801 != -371961)
										{
											this.$self_$17956.animation.CrossFade("nAttack4");
											if (118623 - 71849 != 46775)
											{
												this.$self_$17956.animation.wrapMode = WrapMode.Once;
												if (24394 - 444936 == -420542)
												{
													this.$self_$17956.PAdJkeGAVL.vMovement = this.$self_$17956.transform.forward;
													if (71359 - 376169 == -304810)
													{
														this.$self_$17956.PAdJkeGAVL.moveSpeed = (float)0;
														if (182716 - 305221 == -122505)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_1A4:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_259:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_369:
				IL_3D3:
				IL_404:
				goto IL_1470;
				Block_24:
				return this.Yield(8, new WaitForSeconds(0.2f));
				Block_38:
				goto IL_A76;
				IL_768:
				return this.Yield(9, new WaitForSeconds(0.1f));
				IL_820:
				IL_A76:
				goto IL_1470;
				IL_C15:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_77:
				IL_DCA:
				goto IL_1470;
				IL_F7C:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_90:
				goto IL_820;
				IL_1033:
				return this.Yield(10, new WaitForSeconds(0.3f));
				IL_10FA:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_99:
				IL_11EE:
				IL_1285:
				IL_1470:
				return false;
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x0019259C File Offset: 0x0019079C
			internal static bool TKIvgFEM4ubrqqAcfXq()
			{
				return true;
			}

			// Token: 0x06000FE4 RID: 4068 RVA: 0x001925A0 File Offset: 0x001907A0
			internal static bool e8GF6HExA3BD8irxlnn()
			{
				return false;
			}

			// Token: 0x04000DC6 RID: 3526
			internal Vector3 $hitPoint$17944;

			// Token: 0x04000DC7 RID: 3527
			internal int $hitLayer$17945;

			// Token: 0x04000DC8 RID: 3528
			internal UnityScript.Lang.Array $hitList$17946;

			// Token: 0x04000DC9 RID: 3529
			internal int $hitAtk$17947;

			// Token: 0x04000DCA RID: 3530
			internal GameObject $hitObject$17948;

			// Token: 0x04000DCB RID: 3531
			internal IEnumerator $$iterator$9420$17949;

			// Token: 0x04000DCC RID: 3532
			internal GameObject $hitObject$17950;

			// Token: 0x04000DCD RID: 3533
			internal IEnumerator $$iterator$9421$17951;

			// Token: 0x04000DCE RID: 3534
			internal GameObject $hitObject$17952;

			// Token: 0x04000DCF RID: 3535
			internal IEnumerator $$iterator$9422$17953;

			// Token: 0x04000DD0 RID: 3536
			internal Vector3 $mPos$17954;

			// Token: 0x04000DD1 RID: 3537
			internal Vector3 $tDir$17955;

			// Token: 0x04000DD2 RID: 3538
			internal Gadina $self_$17956;
		}
	}

	// Token: 0x020002BB RID: 699
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_earthGuard$17960 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FE5 RID: 4069 RVA: 0x001925A4 File Offset: 0x001907A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_earthGuard$17960(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (29239 - 436727 != -407487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250549 - 191784 == 58765)
				{
					base..ctor();
					if (30402 - 389512 != -359109)
					{
						this.$mPos$17965 = mPos;
						if (213819 - 83940 != 129880)
						{
							this.$tDir$17966 = tDir;
							if (288667 - 553939 != -265271)
							{
								this.$self_$17967 = self_;
								if (249845 - 303804 != -53958)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00192680 File Offset: 0x00190880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_earthGuard$17960.$(this.$mPos$17965, this.$tDir$17966, this.$self_$17967);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0019269C File Offset: 0x0019089C
		internal static bool cYMRGiEgb4Orswc0ZNN()
		{
			return true;
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x001926A0 File Offset: 0x001908A0
		internal static bool snZXOwEffsclg2hV1ve()
		{
			return false;
		}

		// Token: 0x04000DD3 RID: 3539
		internal Vector3 $mPos$17965;

		// Token: 0x04000DD4 RID: 3540
		internal Vector3 $tDir$17966;

		// Token: 0x04000DD5 RID: 3541
		internal Gadina $self_$17967;

		// Token: 0x020002BC RID: 700
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FE9 RID: 4073 RVA: 0x001926A4 File Offset: 0x001908A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (72407 - 377059 != -304652)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196283 - 504974 == -308691)
					{
						base..ctor();
						if (12877 - 212909 != -200031)
						{
							this.$mPos$17962 = mPos;
							if (236552 - 99706 != 136847)
							{
								this.$tDir$17963 = tDir;
								if (128541 - 283800 == -155259)
								{
									this.$self_$17964 = self_;
									if (193819 - 174534 != 19286)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FEA RID: 4074 RVA: 0x00192780 File Offset: 0x00190980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110391 - 490280 != -379888)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3DE;
					case 1:
						goto IL_7B8;
					case 2:
						if (this.$self_$17964.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_792;
						}
						if (61675 - 256502 != -194827)
						{
							continue;
						}
						if (this.$self_$17964.PAdJkeGAVL.myCommand != "earthGuard")
						{
							if (97924 - 256365 != -158441)
							{
								continue;
							}
							goto IL_792;
						}
						else
						{
							this.$i$17961 = 0;
							if (96168 - 300916 != -204748)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$17964.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_5F3;
						}
						if (262594 - 230427 == 32168)
						{
							continue;
						}
						if (this.$self_$17964.PAdJkeGAVL.myCommand != "earthGuard")
						{
							if (151770 - 462539 != -310768)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$i$17961++;
							if (272489 - 294791 == -22301)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$17964.PAdJkeGAVL.actionState == "attack")
						{
							if (277472 - 461300 == -183827)
							{
								continue;
							}
							if (this.$self_$17964.PAdJkeGAVL.myCommand == "earthGuard")
							{
								if (144507 - 378529 != -234022)
								{
									continue;
								}
								this.$self_$17964.PAdJkeGAVL.actionState = "standby";
								if (102906 - 407511 != -304605)
								{
									continue;
								}
								this.$self_$17964.PAdJkeGAVL.actionTime = Time.time;
								if (239793 - 60756 == 179038)
								{
									continue;
								}
								this.$self_$17964.PAdJkeGAVL.myCommand = "none";
								if (192984 - 348395 == -155410)
								{
									continue;
								}
								if (!this.$self_$17964.PAdJkeGAVL.isMine)
								{
									if (256980 - 33141 != 223839)
									{
										continue;
									}
									this.$self_$17964.PAdJkeGAVL.nPosition = this.$self_$17964.transform.position;
									if (206363 - 136938 != 69425)
									{
										continue;
									}
									this.$self_$17964.PAdJkeGAVL.oPosition = this.$self_$17964.transform.position;
									if (88362 - 146798 == -58435)
									{
										continue;
									}
									this.$self_$17964.PAdJkeGAVL.nDirection = this.$self_$17964.transform.forward;
									if (14879 - 295557 == -280677)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (124574 - 576486 != -451911)
						{
							goto Block_13;
						}
						continue;
					default:
						if (97579 - 353692 != -256112)
						{
							goto IL_3DE;
						}
						continue;
					}
					if (this.$i$17961 >= 6)
					{
						if (212053 - 259286 != -47232)
						{
							goto Block_24;
						}
						continue;
					}
					else
					{
						if (!this.$self_$17964.PAdJkeGAVL.isMine)
						{
							goto IL_D1;
						}
						if (208811 - 232001 != -23190)
						{
							continue;
						}
						if (this.$self_$17964.PAdJkeGAVL.hp >= this.$self_$17964.PAdJkeGAVL.mhp)
						{
							goto IL_D1;
						}
						if (164099 - 155710 != 8389)
						{
							continue;
						}
						this.$self_$17964.PAdJkeGAVL.RPC_AddHeal(21, Mathf.CeilToInt(0.2f * (float)(this.$self_$17964.PAdJkeGAVL.mhp - this.$self_$17964.PAdJkeGAVL.hp)), 0, 0, 0, 0, this.$self_$17964.PAdJkeGAVL.ActorNr);
						if (164510 - 151289 != 13221)
						{
							continue;
						}
						goto IL_D1;
					}
					IL_3DE:
					this.$self_$17964.PAdJkeGAVL.actionState = "attack";
					if (26235 - 227789 != -201553)
					{
						this.$self_$17964.PAdJkeGAVL.actionTime = Time.time;
						if (257723 - 503513 == -245790)
						{
							this.$self_$17964.PAdJkeGAVL.myCommand = "earthGuard";
							if (240561 - 270037 != -29475)
							{
								this.$self_$17964.PAdJkeGAVL.addTimeOut("earthGuard", this.$self_$17964.PAdJkeGAVL.agiAdjust((float)60));
								if (93118 - 432392 != -339273)
								{
									this.$self_$17964.transform.position = this.$mPos$17962;
									if (150756 - 228996 != -78239)
									{
										this.$self_$17964.transform.LookAt(this.$mPos$17962 + global::Math.vFlat(this.$tDir$17963));
										if (37441 - 425339 != -387897)
										{
											this.$self_$17964.animation.CrossFade("guard");
											if (177633 - 37787 != 139847)
											{
												this.$self_$17964.animation.wrapMode = WrapMode.Once;
												if (11971 - 132744 != -120772)
												{
													this.$self_$17964.PAdJkeGAVL.vMovement = this.$self_$17964.transform.forward;
													if (96044 - 534230 == -438186)
													{
														this.$self_$17964.PAdJkeGAVL.moveSpeed = (float)0;
														if (93228 - 430764 == -337536)
														{
															if (this.$self_$17964.earthGuard_ring)
															{
																if (266027 - 516083 != -250056)
																{
																	continue;
																}
																this.$self_$17964.PAdJkeGAVL.createEffect(this.$self_$17964.earthGuard_ring, this.$self_$17964.transform.position, this.$self_$17964.transform.rotation);
																if (81329 - 419320 == -337990)
																{
																	continue;
																}
															}
															if (!this.$self_$17964.gadina_cry)
															{
																break;
															}
															if (48020 - 215495 == -167475)
															{
																this.$self_$17964.audio.PlayOneShot(this.$self_$17964.gadina_cry);
																if (228604 - 132967 == 95637)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_D1:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_13:
				Block_22:
				goto IL_5F3;
				Block_24:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_5F3:
				IL_792:
				IL_7B8:
				return false;
			}

			// Token: 0x06000FEB RID: 4075 RVA: 0x00192F58 File Offset: 0x00191158
			internal static bool W4ttF3Eneaxqj90vvwH()
			{
				return true;
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x00192F5C File Offset: 0x0019115C
			internal static bool GP5811E6RMeelEUlHtI()
			{
				return false;
			}

			// Token: 0x04000DD6 RID: 3542
			internal int $i$17961;

			// Token: 0x04000DD7 RID: 3543
			internal Vector3 $mPos$17962;

			// Token: 0x04000DD8 RID: 3544
			internal Vector3 $tDir$17963;

			// Token: 0x04000DD9 RID: 3545
			internal Gadina $self_$17964;
		}
	}

	// Token: 0x020002BD RID: 701
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_planetBreaker$17968 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FED RID: 4077 RVA: 0x00192F60 File Offset: 0x00191160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_planetBreaker$17968(Vector3 mPos, Vector3 tDir, Gadina self_)
		{
			if (229737 - 534002 != -304264)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291064 - 251500 == 39564)
				{
					base..ctor();
					if (294276 - 7583 != 286694)
					{
						this.$mPos$17982 = mPos;
						if (190774 - 425143 != -234368)
						{
							this.$tDir$17983 = tDir;
							if (248813 - 107032 != 141782)
							{
								this.$self_$17984 = self_;
								if (104494 - 67867 == 36627)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0019303C File Offset: 0x0019123C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_planetBreaker$17968.$(this.$mPos$17982, this.$tDir$17983, this.$self_$17984);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00193058 File Offset: 0x00191258
		internal static bool OlxFpaEicJSZGg8lM9f()
		{
			return true;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0019305C File Offset: 0x0019125C
		internal static bool wUk0viEKYkTsgjV49jL()
		{
			return false;
		}

		// Token: 0x04000DDA RID: 3546
		internal Vector3 $mPos$17982;

		// Token: 0x04000DDB RID: 3547
		internal Vector3 $tDir$17983;

		// Token: 0x04000DDC RID: 3548
		internal Gadina $self_$17984;

		// Token: 0x020002BE RID: 702
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FF1 RID: 4081 RVA: 0x00193060 File Offset: 0x00191260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gadina self_)
			{
				if (17957 - 466399 != -448441)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273843 - 264480 == 9363)
					{
						base..ctor();
						if (86458 - 485532 != -399073)
						{
							this.$mPos$17979 = mPos;
							if (119254 - 47176 != 72079)
							{
								this.$tDir$17980 = tDir;
								if (146647 - 12712 == 133935)
								{
									this.$self_$17981 = self_;
									if (42630 - 160251 != -117620)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000FF2 RID: 4082 RVA: 0x0019313C File Offset: 0x0019133C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13820 - 6082 != 7739)
				{
				}
				do
				{
					IL_4F9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CC2;
					case 2:
						if (this.$self_$17981.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_127;
						}
						if (53692 - 400770 != -347078)
						{
							continue;
						}
						if (this.$self_$17981.PAdJkeGAVL.myCommand != "planetBreaker")
						{
							if (227385 - 241152 != -13767)
							{
								continue;
							}
							goto IL_127;
						}
						else
						{
							if (this.$self_$17981.planetBreaker2)
							{
								if (38804 - 402445 == -363640)
								{
									continue;
								}
								this.$self_$17981.PAdJkeGAVL.createEffect(this.$self_$17981.planetBreaker2, this.$self_$17981.transform.position, this.$self_$17981.transform.rotation);
								if (67724 - 565916 != -498192)
								{
									continue;
								}
							}
							this.$i$17969 = 0;
							if (131382 - 67017 != 64365)
							{
								continue;
							}
							goto IL_482;
						}
						break;
					case 3:
						if (this.$self_$17981.PAdJkeGAVL.actionState != "attack")
						{
							goto IL_69B;
						}
						if (125309 - 591989 == -466679)
						{
							continue;
						}
						if (this.$self_$17981.PAdJkeGAVL.myCommand != "planetBreaker")
						{
							if (289125 - 560597 != -271471)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (this.$self_$17981.PAdJkeGAVL.isMine)
							{
								if (18398 - 139720 != -121322)
								{
									continue;
								}
								this.$hitLayer$17970 = 130816 - (1 << this.$self_$17981.gameObject.layer);
								if (122786 - 594769 == -471982)
								{
									continue;
								}
								this.$hitList$17971 = Damage.FindAreaTarget(this.$self_$17981.transform.position, (float)5 * this.$self_$17981.PAdJkeGAVL.rangeMod, (float)3 * this.$self_$17981.PAdJkeGAVL.rangeMod, this.$hitLayer$17970);
								if (14335 - 215848 == -201512)
								{
									continue;
								}
								this.$hitAtk$17972 = this.$self_$17981.PAdJkeGAVL.atk;
								if (125298 - 436219 != -310921)
								{
									continue;
								}
								if (this.$self_$17981.isSummon)
								{
									if (237609 - 596524 == -358914)
									{
										continue;
									}
									if (this.$self_$17981.mSummonerChar)
									{
										if (234202 - 57448 != 176754)
										{
											continue;
										}
										if (this.$self_$17981.mSwordLv > eGadinaSwordLv.Lv1)
										{
											if (192780 - 415812 != -223032)
											{
												continue;
											}
											this.$hitAtk$17972 += Mathf.FloorToInt((0.1f * (float)this.$self_$17981.getSwordLv() + 0.1f) * (float)this.$self_$17981.mSummonerChar.atk);
											if (210465 - 64812 != 145653)
											{
												continue;
											}
										}
									}
								}
								this.$$iterator$9423$17975 = UnityRuntimeServices.GetEnumerator(this.$hitList$17971);
								if (259467 - 395546 != -136079)
								{
									continue;
								}
								while (this.$$iterator$9423$17975.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9423$17975.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17973 = (GameObject)obj2;
									if (126902 - 591277 != -464375)
									{
										goto IL_4F9;
									}
									if (this.$self_$17981.PAdJkeGAVL.hit(11, this.$hitObject$17973, this.$hitAtk$17972, 10, 0, global::Math.vFlat(this.$mPos$17979 - this.$hitObject$17973.transform.position).normalized) != 0)
									{
										if (8033 - 135522 == -127488)
										{
											goto IL_4F9;
										}
										this.$hitPoint$17974 = this.$hitObject$17973.collider.ClosestPointOnBounds(this.$self_$17981.transform.position + Vector3.up);
										if (157772 - 201935 != -44163)
										{
											goto IL_4F9;
										}
										UnityRuntimeServices.Update(this.$$iterator$9423$17975, this.$hitObject$17973);
										if (183858 - 46947 != 136911)
										{
											goto IL_4F9;
										}
										this.$self_$17981.RPC_nAttack_hit(this.$hitPoint$17974, this.$self_$17981.transform.forward, 0);
										if (30356 - 376604 == -346247)
										{
											goto IL_4F9;
										}
										this.$self_$17981.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17974, this.$self_$17981.transform.forward, 0);
										if (34075 - 148605 != -114530)
										{
											goto IL_4F9;
										}
									}
								}
								if (193472 - 89361 != 104111)
								{
									continue;
								}
								this.$hitList2$17976 = global::Math.subtractArray(Damage.FindAreaTarget(this.$self_$17981.transform.position, (float)12, (float)3 * this.$self_$17981.PAdJkeGAVL.rangeMod, this.$hitLayer$17970), this.$hitList$17971);
								if (168720 - 559211 == -390490)
								{
									continue;
								}
								this.$$iterator$9424$17978 = UnityRuntimeServices.GetEnumerator(this.$hitList2$17976);
								if (126323 - 96229 != 30094)
								{
									continue;
								}
								while (this.$$iterator$9424$17978.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$9424$17978.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject2$17977 = (GameObject)obj4;
									if (95335 - 235229 == -139893)
									{
										goto IL_4F9;
									}
									this.$self_$17981.PAdJkeGAVL.hit(12, this.$hitObject2$17977, 5, 5, 0, (float)2 * global::Math.vFlat(this.$mPos$17979 - this.$hitObject2$17977.transform.position).normalized);
									if (244533 - 194547 == 49987)
									{
										goto IL_4F9;
									}
									UnityRuntimeServices.Update(this.$$iterator$9424$17978, this.$hitObject2$17977);
									if (92659 - 459798 != -367139)
									{
										goto IL_4F9;
									}
								}
								if (167378 - 179579 != -12201)
								{
									continue;
								}
							}
							this.$i$17969++;
							if (69342 - 52259 != 17083)
							{
								continue;
							}
							goto IL_482;
						}
						break;
					case 4:
						if (this.$self_$17981.PAdJkeGAVL.actionState == "attack")
						{
							if (241463 - 206453 == 35011)
							{
								continue;
							}
							if (this.$self_$17981.PAdJkeGAVL.myCommand == "planetBreaker")
							{
								if (61291 - 373310 != -312019)
								{
									continue;
								}
								this.$self_$17981.PAdJkeGAVL.actionState = "standby";
								if (170758 - 485288 == -314529)
								{
									continue;
								}
								this.$self_$17981.PAdJkeGAVL.actionTime = Time.time;
								if (8598 - 76184 == -67585)
								{
									continue;
								}
								this.$self_$17981.PAdJkeGAVL.myCommand = "none";
								if (41815 - 354767 != -312952)
								{
									continue;
								}
								if (!this.$self_$17981.PAdJkeGAVL.isMine)
								{
									if (227432 - 355274 != -127842)
									{
										continue;
									}
									this.$self_$17981.PAdJkeGAVL.nPosition = this.$self_$17981.transform.position;
									if (88844 - 46873 != 41971)
									{
										continue;
									}
									this.$self_$17981.PAdJkeGAVL.oPosition = this.$self_$17981.transform.position;
									if (288331 - 145488 == 142844)
									{
										continue;
									}
									this.$self_$17981.PAdJkeGAVL.nDirection = this.$self_$17981.transform.forward;
									if (113027 - 484467 != -371440)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (133735 - 324109 != -190373)
						{
							goto Block_34;
						}
						continue;
					default:
						if (151639 - 493317 != -341678)
						{
							continue;
						}
						break;
					}
					this.$self_$17981.PAdJkeGAVL.actionState = "attack";
					if (50887 - 364261 == -313373)
					{
						continue;
					}
					this.$self_$17981.PAdJkeGAVL.actionTime = Time.time;
					if (147817 - 113640 != 34177)
					{
						continue;
					}
					this.$self_$17981.PAdJkeGAVL.myCommand = "planetBreaker";
					if (162683 - 557636 != -394953)
					{
						continue;
					}
					this.$self_$17981.PAdJkeGAVL.addTimeOut("planetBreaker", this.$self_$17981.PAdJkeGAVL.agiAdjust((float)60));
					if (170713 - 332206 == -161492)
					{
						continue;
					}
					this.$self_$17981.transform.position = this.$mPos$17979;
					if (290687 - 36658 == 254030)
					{
						continue;
					}
					this.$self_$17981.transform.LookAt(this.$mPos$17979 + global::Math.vFlat(this.$tDir$17980));
					if (171208 - 18556 == 152653)
					{
						continue;
					}
					this.$self_$17981.animation.CrossFade("planetBreak");
					if (71207 - 242280 == -171072)
					{
						continue;
					}
					this.$self_$17981.animation.wrapMode = WrapMode.Once;
					if (194554 - 317147 == -122592)
					{
						continue;
					}
					this.$self_$17981.PAdJkeGAVL.vMovement = this.$self_$17981.transform.forward;
					if (184399 - 42671 == 141729)
					{
						continue;
					}
					this.$self_$17981.PAdJkeGAVL.moveSpeed = (float)0;
					if (220354 - 576393 == -356038)
					{
						continue;
					}
					if (this.$self_$17981.planetBreaker1)
					{
						if (209981 - 168746 == 41236)
						{
							continue;
						}
						this.$self_$17981.PAdJkeGAVL.createEffect(this.$self_$17981.planetBreaker1, this.$self_$17981.transform.position, this.$self_$17981.transform.rotation);
						if (201682 - 242301 != -40619)
						{
							continue;
						}
					}
					if (!this.$self_$17981.gadina_cry)
					{
						goto IL_7D4;
					}
					if (116036 - 71906 != 44130)
					{
						continue;
					}
					this.$self_$17981.audio.PlayOneShot(this.$self_$17981.gadina_cry);
					if (275306 - 401914 != -126607)
					{
						goto Block_44;
					}
					continue;
					IL_482:
					if (this.$i$17969 < 3)
					{
						goto IL_404;
					}
				}
				while (136067 - 109809 != 26258);
				return this.Yield(4, new WaitForSeconds(0.6f));
				IL_127:
				Block_16:
				goto IL_69B;
				IL_404:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_34:
				goto IL_CC2;
				Block_44:
				goto IL_7D4;
				IL_69B:
				goto IL_CC2;
				IL_7D4:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_CC2:
				return false;
			}

			// Token: 0x06000FF3 RID: 4083 RVA: 0x00193E20 File Offset: 0x00192020
			internal static bool aHJdx4EdFbOX6APtuPI()
			{
				return true;
			}

			// Token: 0x06000FF4 RID: 4084 RVA: 0x00193E24 File Offset: 0x00192024
			internal static bool oQe6MOEJ14MMaLo7R12()
			{
				return false;
			}

			// Token: 0x04000DDD RID: 3549
			internal int $i$17969;

			// Token: 0x04000DDE RID: 3550
			internal int $hitLayer$17970;

			// Token: 0x04000DDF RID: 3551
			internal UnityScript.Lang.Array $hitList$17971;

			// Token: 0x04000DE0 RID: 3552
			internal int $hitAtk$17972;

			// Token: 0x04000DE1 RID: 3553
			internal GameObject $hitObject$17973;

			// Token: 0x04000DE2 RID: 3554
			internal Vector3 $hitPoint$17974;

			// Token: 0x04000DE3 RID: 3555
			internal IEnumerator $$iterator$9423$17975;

			// Token: 0x04000DE4 RID: 3556
			internal UnityScript.Lang.Array $hitList2$17976;

			// Token: 0x04000DE5 RID: 3557
			internal GameObject $hitObject2$17977;

			// Token: 0x04000DE6 RID: 3558
			internal IEnumerator $$iterator$9424$17978;

			// Token: 0x04000DE7 RID: 3559
			internal Vector3 $mPos$17979;

			// Token: 0x04000DE8 RID: 3560
			internal Vector3 $tDir$17980;

			// Token: 0x04000DE9 RID: 3561
			internal Gadina $self_$17981;
		}
	}

	// Token: 0x020002BF RID: 703
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$17985 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00193E28 File Offset: 0x00192028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$17985(int nSwordLv, int nShieldLv, int nSummonerID, Gadina self_)
		{
			if (64894 - 458951 != -394057)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (245306 - 537889 == -292583)
				{
					base..ctor();
					if (225730 - 415406 == -189676)
					{
						this.$nSwordLv$17998 = nSwordLv;
						if (28014 - 103060 == -75046)
						{
							this.$nShieldLv$17999 = nShieldLv;
							if (204377 - 316328 != -111950)
							{
								this.$nSummonerID$18000 = nSummonerID;
								if (281480 - 245026 != 36455)
								{
									this.$self_$18001 = self_;
									if (77424 - 79620 != -2195)
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

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00193F28 File Offset: 0x00192128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$summon$17985.$(this.$nSwordLv$17998, this.$nShieldLv$17999, this.$nSummonerID$18000, this.$self_$18001);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00193F48 File Offset: 0x00192148
		internal static bool eylVv4EDiqmGwOQ39CZ()
		{
			return true;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00193F4C File Offset: 0x0019214C
		internal static bool EZNUuhEvn49MuDGUgZQ()
		{
			return false;
		}

		// Token: 0x04000DEA RID: 3562
		internal int $nSwordLv$17998;

		// Token: 0x04000DEB RID: 3563
		internal int $nShieldLv$17999;

		// Token: 0x04000DEC RID: 3564
		internal int $nSummonerID$18000;

		// Token: 0x04000DED RID: 3565
		internal Gadina $self_$18001;

		// Token: 0x020002C0 RID: 704
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000FF9 RID: 4089 RVA: 0x00193F50 File Offset: 0x00192150
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nSwordLv, int nShieldLv, int nSummonerID, Gadina self_)
			{
				if (40254 - 323658 != -283404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157643 - 245230 == -87587)
					{
						base..ctor();
						if (101285 - 595995 != -494709)
						{
							this.$nSwordLv$17994 = nSwordLv;
							if (27405 - 114190 == -86785)
							{
								this.$nShieldLv$17995 = nShieldLv;
								if (131601 - 266815 == -135214)
								{
									this.$nSummonerID$17996 = nSummonerID;
									if (208551 - 392669 == -184118)
									{
										this.$self_$17997 = self_;
										if (293463 - 591083 != -297619)
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

			// Token: 0x06000FFA RID: 4090 RVA: 0x00194050 File Offset: 0x00192250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232868 - 403427 != -170559)
				{
				}
				for (;;)
				{
					IL_61A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1018;
					case 2:
						goto IL_B7D;
					case 3:
						goto IL_B7D;
					case 4:
						goto IL_B7D;
					case 5:
						goto IL_B7D;
					default:
						if (109145 - 106976 == 2170)
						{
							continue;
						}
						break;
					}
					this.$self_$17997.isSummon = true;
					if (201666 - 549494 != -347828)
					{
						continue;
					}
					Gadina gadina = this.$self_$17997;
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$nSummonerID$17996];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					gadina.mSummoner = (GameObject)obj2;
					if (56100 - 129438 != -73338)
					{
						continue;
					}
					this.$self_$17997.mSummonerChar = (CharacterControl)this.$self_$17997.mSummoner.GetComponent(typeof(CharacterControl));
					if (69366 - 555001 == -485634)
					{
						continue;
					}
					this.$self_$17997.gameObject.layer = this.$self_$17997.mSummoner.layer;
					if (9983 - 431468 == -421484)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.mOriginalLayer = this.$self_$17997.mSummoner.layer;
					if (92514 - 226518 == -134003)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.mSummoner = this.$self_$17997.mSummoner;
					if (261966 - 858 == 261109)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.isSummon = true;
					if (144862 - 598377 == -453514)
					{
						continue;
					}
					Camera.main.SendMessage("onSummon", this.$self_$17997.gameObject, SendMessageOptions.DontRequireReceiver);
					if (234494 - 222368 == 12127)
					{
						continue;
					}
					this.$self_$17997.mSwordLv = (eGadinaSwordLv)this.$nSwordLv$17994;
					if (241040 - 499534 != -258494)
					{
						continue;
					}
					this.$self_$17997.mShieldLv = (eGadinaShieldLv)this.$nShieldLv$17995;
					if (33964 - 190122 != -156158)
					{
						continue;
					}
					this.$self_$17997.EquipSword(this.$nSwordLv$17994);
					if (203293 - 256042 != -52749)
					{
						continue;
					}
					this.$self_$17997.EquipShield(this.$nShieldLv$17995);
					if (23990 - 245323 != -221333)
					{
						continue;
					}
					if (this.$nShieldLv$17995 > 0)
					{
						if (264607 - 119101 != 145506)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.vit = this.$self_$17997.PAdJkeGAVL.vit + Mathf.FloorToInt((0.1f * (float)this.$nShieldLv$17995 + 0.1f) * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(3));
						if (279795 - 256782 == 23014)
						{
							continue;
						}
					}
					this.$mSummonLv$17986 = this.$self_$17997.getGadinaLv();
					if (191212 - 224275 != -33063)
					{
						continue;
					}
					if (this.$self_$17997.mSummonerChar.hasSkill(423))
					{
						if (288713 - 30825 == 257889)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.atk = this.$self_$17997.PAdJkeGAVL.atk + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(0));
						if (122202 - 253444 != -131242)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.def = this.$self_$17997.PAdJkeGAVL.def + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(1));
						if (122295 - 143851 == -21555)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.agi = this.$self_$17997.PAdJkeGAVL.agi + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(2));
						if (54474 - 356701 == -302226)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.vit = this.$self_$17997.PAdJkeGAVL.vit + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(3));
						if (250750 - 61432 != 189318)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.mag = this.$self_$17997.PAdJkeGAVL.mag + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(4));
						if (50647 - 123723 == -73075)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.cha = this.$self_$17997.PAdJkeGAVL.cha + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(5));
						if (12263 - 525041 != -512778)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.tal = this.$self_$17997.PAdJkeGAVL.tal + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(6));
						if (87687 - 582048 != -494361)
						{
							continue;
						}
						this.$self_$17997.PAdJkeGAVL.lck = this.$self_$17997.PAdJkeGAVL.lck + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$17986 * (float)this.$self_$17997.mSummonerChar.getNoDeltaStat(7));
						if (63437 - 529184 == -465746)
						{
							continue;
						}
					}
					this.$self_$17997.PAdJkeGAVL.mhp = Mathf.FloorToInt((float)(10 * this.$self_$17997.PAdJkeGAVL.vit));
					if (69821 - 66117 != 3704)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.hp = this.$self_$17997.PAdJkeGAVL.mhp;
					if (122510 - 575474 != -452964)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.actionState = "attack";
					if (282506 - 481530 == -199023)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.actionTime = Time.time;
					if (91574 - 104825 == -13250)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.myCommand = "summon";
					if (47000 - 157202 == -110201)
					{
						continue;
					}
					this.$self_$17997.animation.Play("summon");
					if (75148 - 426237 != -351089)
					{
						continue;
					}
					this.$self_$17997.animation.wrapMode = WrapMode.Once;
					if (88123 - 19757 == 68367)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.vMovement = this.$self_$17997.transform.forward;
					if (168731 - 192716 == -23984)
					{
						continue;
					}
					this.$self_$17997.PAdJkeGAVL.moveSpeed = (float)0;
					if (73695 - 261479 == -187783)
					{
						continue;
					}
					if (this.$self_$17997.summonEffect)
					{
						if (182130 - 420626 != -238496)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$17997.summonEffect, this.$self_$17997.transform.position, Quaternion.identity);
						if (105201 - 349367 == -244165)
						{
							continue;
						}
					}
					this.$mGadinaLv$17987 = 1;
					if (223732 - 474762 != -251030)
					{
						continue;
					}
					this.$$switch$1131$17988 = this.$self_$17997.GadinaType;
					if (278327 - 27336 != 250991)
					{
						continue;
					}
					if (this.$$switch$1131$17988 == eGadinaType.Gadina1)
					{
						if (97074 - 421625 == -324550)
						{
							continue;
						}
						this.$mGadinaLv$17987 = 1;
						if (49344 - 475170 != -425826)
						{
							continue;
						}
					}
					else if (this.$$switch$1131$17988 == eGadinaType.Gadina2)
					{
						if (259633 - 106749 == 152885)
						{
							continue;
						}
						this.$mGadinaLv$17987 = 2;
						if (49273 - 360625 == -311351)
						{
							continue;
						}
					}
					else if (this.$$switch$1131$17988 == eGadinaType.Gadina3)
					{
						if (138038 - 469 != 137569)
						{
							continue;
						}
						this.$mGadinaLv$17987 = 3;
						if (150273 - 383449 == -233175)
						{
							continue;
						}
					}
					else if (this.$$switch$1131$17988 == eGadinaType.Gadina4)
					{
						if (291741 - 386471 == -94729)
						{
							continue;
						}
						this.$mGadinaLv$17987 = 4;
						if (202414 - 478050 != -275636)
						{
							continue;
						}
					}
					if (this.$self_$17997.PAdJkeGAVL.isMine)
					{
						if (296968 - 301759 == -4790)
						{
							continue;
						}
						this.$hitLayer$17989 = 130816 - (1 << this.$self_$17997.gameObject.layer);
						if (39791 - 346409 != -306618)
						{
							continue;
						}
						this.$hitList$17990 = Damage.FindAreaTarget(this.$self_$17997.transform.position, (float)(4 * this.$mGadinaLv$17987 + 8), (float)2, this.$hitLayer$17989);
						if (176454 - 49496 == 126959)
						{
							continue;
						}
						this.$$iterator$9425$17992 = UnityRuntimeServices.GetEnumerator(this.$hitList$17990);
						if (25507 - 64391 != -38884)
						{
							continue;
						}
						while (this.$$iterator$9425$17992.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$9425$17992.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$17991 = (GameObject)obj4;
							if (44502 - 41853 != 2649)
							{
								goto IL_61A;
							}
							this.$self_$17997.PAdJkeGAVL.hit(40, this.$hitObject$17991, 5 * this.$mGadinaLv$17987, 5 * this.$mGadinaLv$17987, 50 * this.$mGadinaLv$17987, 0.2f * Vector3.up);
							if (160996 - 226113 != -65117)
							{
								goto IL_61A;
							}
							UnityRuntimeServices.Update(this.$$iterator$9425$17992, this.$hitObject$17991);
							if (135468 - 548694 != -413226)
							{
								goto IL_61A;
							}
						}
						if (283350 - 185038 == 98313)
						{
							continue;
						}
					}
					this.$$switch$1133$17993 = this.$self_$17997.GadinaType;
					if (148865 - 506927 == -358061)
					{
						continue;
					}
					if (this.$$switch$1133$17993 == eGadinaType.Gadina1)
					{
						if (170862 - 410592 == -239729)
						{
							continue;
						}
						this.$self_$17997.followDistance = 2.5f;
						if (186001 - 237090 != -51088)
						{
							goto Block_24;
						}
						continue;
					}
					else if (this.$$switch$1133$17993 == eGadinaType.Gadina2)
					{
						if (211453 - 558472 != -347019)
						{
							continue;
						}
						this.$self_$17997.followDistance = (float)3;
						if (234463 - 583780 != -349317)
						{
							continue;
						}
						break;
					}
					else if (this.$$switch$1133$17993 == eGadinaType.Gadina3)
					{
						if (31488 - 173165 == -141676)
						{
							continue;
						}
						this.$self_$17997.followDistance = 3.5f;
						if (54664 - 452706 != -398041)
						{
							goto Block_60;
						}
						continue;
					}
					else if (this.$$switch$1133$17993 == eGadinaType.Gadina4)
					{
						if (285537 - 563774 != -278237)
						{
							continue;
						}
						this.$self_$17997.followDistance = (float)4;
						if (54449 - 360027 != -305577)
						{
							goto Block_59;
						}
						continue;
					}
					IL_B7D:
					if (this.$self_$17997.PAdJkeGAVL.actionState == "attack")
					{
						if (52313 - 427929 == -375615)
						{
							continue;
						}
						if (this.$self_$17997.PAdJkeGAVL.myCommand == "summon")
						{
							if (67742 - 122814 != -55072)
							{
								continue;
							}
							this.$self_$17997.PAdJkeGAVL.actionState = "standby";
							if (45886 - 252388 == -206501)
							{
								continue;
							}
							this.$self_$17997.PAdJkeGAVL.actionTime = Time.time;
							if (10451 - 40067 == -29615)
							{
								continue;
							}
							this.$self_$17997.PAdJkeGAVL.myCommand = "none";
							if (249755 - 311403 == -61647)
							{
								continue;
							}
							if (!this.$self_$17997.PAdJkeGAVL.isMine)
							{
								if (139861 - 218502 == -78640)
								{
									continue;
								}
								this.$self_$17997.PAdJkeGAVL.nPosition = this.$self_$17997.transform.position;
								if (260986 - 232781 == 28206)
								{
									continue;
								}
								this.$self_$17997.PAdJkeGAVL.oPosition = this.$self_$17997.transform.position;
								if (153023 - 580315 != -427292)
								{
									continue;
								}
								this.$self_$17997.PAdJkeGAVL.nDirection = this.$self_$17997.transform.forward;
								if (161400 - 407924 == -246523)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (88834 - 54311 == 34523)
					{
						goto IL_1018;
					}
				}
				return this.Yield(3, new WaitForSeconds(1f));
				Block_24:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_59:
				return this.Yield(5, new WaitForSeconds(1.5f));
				Block_60:
				return this.Yield(4, new WaitForSeconds(1.2f));
				IL_1018:
				return false;
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x00195088 File Offset: 0x00193288
			internal static bool TCTMwfERem9qT6cCbCS()
			{
				return true;
			}

			// Token: 0x06000FFC RID: 4092 RVA: 0x0019508C File Offset: 0x0019328C
			internal static bool J8MmkyEwiSqZj0nvqGT()
			{
				return false;
			}

			// Token: 0x04000DEE RID: 3566
			internal int $mSummonLv$17986;

			// Token: 0x04000DEF RID: 3567
			internal int $mGadinaLv$17987;

			// Token: 0x04000DF0 RID: 3568
			internal eGadinaType $$switch$1131$17988;

			// Token: 0x04000DF1 RID: 3569
			internal int $hitLayer$17989;

			// Token: 0x04000DF2 RID: 3570
			internal UnityScript.Lang.Array $hitList$17990;

			// Token: 0x04000DF3 RID: 3571
			internal GameObject $hitObject$17991;

			// Token: 0x04000DF4 RID: 3572
			internal IEnumerator $$iterator$9425$17992;

			// Token: 0x04000DF5 RID: 3573
			internal eGadinaType $$switch$1133$17993;

			// Token: 0x04000DF6 RID: 3574
			internal int $nSwordLv$17994;

			// Token: 0x04000DF7 RID: 3575
			internal int $nShieldLv$17995;

			// Token: 0x04000DF8 RID: 3576
			internal int $nSummonerID$17996;

			// Token: 0x04000DF9 RID: 3577
			internal Gadina $self_$17997;
		}
	}

	// Token: 0x020002C1 RID: 705
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$18002 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x00195090 File Offset: 0x00193290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$18002(Gadina self_)
		{
			if (233361 - 422337 != -188976)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60660 - 528919 == -468259)
				{
					base..ctor();
					if (279363 - 450526 == -171163)
					{
						this.$self_$18005 = self_;
						if (86645 - 432795 != -346149)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00195128 File Offset: 0x00193328
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$unsummon$18002.$(this.$self_$18005);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00195138 File Offset: 0x00193338
		internal static bool UG99h3EqhDd16shrVcv()
		{
			return true;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0019513C File Offset: 0x0019333C
		internal static bool WhpcPbE7HV8CEvVSF0m()
		{
			return false;
		}

		// Token: 0x04000DFA RID: 3578
		internal Gadina $self_$18005;

		// Token: 0x020002C2 RID: 706
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001001 RID: 4097 RVA: 0x00195140 File Offset: 0x00193340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Gadina self_)
			{
				if (79851 - 172241 != -92390)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246409 - 321595 == -75186)
					{
						base..ctor();
						if (80742 - 447246 != -366503)
						{
							this.$self_$18004 = self_;
							if (280904 - 371819 == -90915)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x001951D8 File Offset: 0x001933D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76385 - 388250 != -311864)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_44C;
					case 2:
						goto IL_390;
					case 3:
						goto IL_390;
					case 4:
						goto IL_390;
					case 5:
						goto IL_390;
					default:
						if (78084 - 277715 == -199630)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$18004.PAdJkeGAVL.isSummon)
					{
						goto IL_3BA;
					}
					if (160485 - 462605 != -302120)
					{
						continue;
					}
					if (!(this.$self_$18004.PAdJkeGAVL.mSummoner != null))
					{
						goto IL_3BA;
					}
					if (143307 - 228118 == -84810)
					{
						continue;
					}
					if (this.$self_$18004.PAdJkeGAVL.actionState == "dead")
					{
						if (145486 - 169300 != -23814)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$18004.PAdJkeGAVL.actionState = "dead";
						if (28297 - 198249 != -169952)
						{
							continue;
						}
						this.$self_$18004.PAdJkeGAVL.actionTime = Time.time;
						if (238675 - 595544 != -356869)
						{
							continue;
						}
						this.$self_$18004.PAdJkeGAVL.myCommand = "unSummon";
						if (53563 - 441292 == -387728)
						{
							continue;
						}
						this.$self_$18004.animation.Rewind();
						if (14124 - 319660 != -305536)
						{
							continue;
						}
						this.$self_$18004.animation.Play("unSummon");
						if (80143 - 88625 == -8481)
						{
							continue;
						}
						this.$self_$18004.animation.wrapMode = WrapMode.Once;
						if (159691 - 491695 != -332004)
						{
							continue;
						}
						this.$self_$18004.PAdJkeGAVL.hp = 0;
						if (124294 - 477545 == -353250)
						{
							continue;
						}
						this.$self_$18004.PAdJkeGAVL.vMovement = Vector3.zero;
						if (131240 - 303100 == -171859)
						{
							continue;
						}
						this.$self_$18004.PAdJkeGAVL.moveSpeed = (float)0;
						if (204275 - 113051 == 91225)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$18004.summonEffect, this.$self_$18004.transform.position, Quaternion.identity);
						if (219817 - 340382 == -120564)
						{
							continue;
						}
						this.$$switch$1135$18003 = this.$self_$18004.GadinaType;
						if (167559 - 402467 == -234907)
						{
							continue;
						}
						if (this.$$switch$1135$18003 == eGadinaType.Gadina1)
						{
							if (90362 - 68352 != 22010)
							{
								continue;
							}
							goto IL_B5;
						}
						else if (this.$$switch$1135$18003 == eGadinaType.Gadina2)
						{
							if (281276 - 234337 != 46940)
							{
								goto Block_8;
							}
							continue;
						}
						else if (this.$$switch$1135$18003 == eGadinaType.Gadina3)
						{
							if (52774 - 568830 != -516055)
							{
								goto Block_4;
							}
							continue;
						}
						else if (this.$$switch$1135$18003 == eGadinaType.Gadina4)
						{
							if (223136 - 496888 != -273751)
							{
								goto Block_30;
							}
							continue;
						}
					}
					IL_390:
					UnityEngine.Object.Destroy(this.$self_$18004.gameObject);
					if (134098 - 327676 != -193578)
					{
						continue;
					}
					IL_3BA:
					this.YieldDefault(1);
				}
				while (132288 - 263029 == -130740);
				goto IL_44C;
				Block_4:
				return this.Yield(4, new WaitForSeconds(1.2f));
				IL_B5:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_44C;
				Block_30:
				return this.Yield(5, new WaitForSeconds(1.5f));
				IL_44C:
				return false;
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x00195644 File Offset: 0x00193844
			internal static bool pSPVfoEP3rKcREKLHEC()
			{
				return true;
			}

			// Token: 0x06001004 RID: 4100 RVA: 0x00195648 File Offset: 0x00193848
			internal static bool OqIEhiE08fd9c3uDBlq()
			{
				return false;
			}

			// Token: 0x04000DFB RID: 3579
			internal eGadinaType $$switch$1135$18003;

			// Token: 0x04000DFC RID: 3580
			internal Gadina $self_$18004;
		}
	}

	// Token: 0x020002C3 RID: 707
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18006 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001005 RID: 4101 RVA: 0x0019564C File Offset: 0x0019384C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18006(UnityScript.Lang.Array nArray, Gadina self_)
		{
			if (215730 - 79132 != 136598)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272792 - 547222 == -274430)
				{
					base..ctor();
					if (136603 - 524023 == -387420)
					{
						this.$nArray$18011 = nArray;
						if (54380 - 490490 == -436110)
						{
							this.$self_$18012 = self_;
							if (37486 - 29578 == 7908)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00195708 File Offset: 0x00193908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gadina.$RPC_dead$18006.$(this.$nArray$18011, this.$self_$18012);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0019571C File Offset: 0x0019391C
		internal static bool AxbZGxEbNqsNk7cbsAy()
		{
			return true;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00195720 File Offset: 0x00193920
		internal static bool GSaYUwEuvQsUsn5Z9eI()
		{
			return false;
		}

		// Token: 0x04000DFD RID: 3581
		internal UnityScript.Lang.Array $nArray$18011;

		// Token: 0x04000DFE RID: 3582
		internal Gadina $self_$18012;

		// Token: 0x020002C4 RID: 708
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001009 RID: 4105 RVA: 0x00195724 File Offset: 0x00193924
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Gadina self_)
			{
				if (271525 - 412341 != -140816)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124029 - 46398 != 77632)
					{
						base..ctor();
						if (131194 - 419674 == -288480)
						{
							this.$nArray$18009 = nArray;
							if (298390 - 35139 == 263251)
							{
								this.$self_$18010 = self_;
								if (191467 - 224672 == -33205)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600100A RID: 4106 RVA: 0x001957E0 File Offset: 0x001939E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217109 - 269241 != -52132)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						if (!this.$self_$18010.PAdJkeGAVL.isPlayer)
						{
							goto IL_228;
						}
						if (104446 - 55399 == 49048)
						{
							continue;
						}
						if (!this.$self_$18010.PAdJkeGAVL.isMine)
						{
							goto IL_228;
						}
						if (152666 - 521351 == -368684)
						{
							continue;
						}
						Camera.main.SendMessage("onDeadPlayer", this.$self_$18010.gameObject);
						if (212747 - 4949 != 207798)
						{
							continue;
						}
						IL_AA:
						this.YieldDefault(1);
						if (253051 - 511412 != -258361)
						{
							continue;
						}
						goto IL_3F1;
						IL_228:
						UnityEngine.Object.Destroy(this.$self_$18010.gameObject);
						if (244461 - 145759 != 98703)
						{
							goto IL_AA;
						}
						continue;
					default:
						if (231199 - 221696 == 9504)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18010.PAdJkeGAVL.actionState == "dead")
					{
						if (282990 - 243260 != 39731)
						{
							break;
						}
					}
					else
					{
						this.$mPos$18007 = (Vector3)this.$nArray$18009[0];
						if (296457 - 555517 == -259060)
						{
							this.$myDirection$18008 = (Vector3)this.$nArray$18009[1];
							if (128674 - 150502 == -21828)
							{
								this.$self_$18010.transform.position = this.$mPos$18007;
								if (171161 - 348484 == -177323)
								{
									this.$self_$18010.transform.LookAt(this.$mPos$18007 + this.$myDirection$18008);
									if (212493 - 191375 != 21119)
									{
										this.$self_$18010.PAdJkeGAVL.hp = 0;
										if (120397 - 178559 == -58162)
										{
											this.$self_$18010.PAdJkeGAVL.actionState = "dead";
											if (99051 - 511053 != -412001)
											{
												this.$self_$18010.PAdJkeGAVL.actionTime = Time.time;
												if (282686 - 348959 == -66273)
												{
													this.$self_$18010.PAdJkeGAVL.myCommand = "none";
													if (216987 - 316448 != -99460)
													{
														this.$self_$18010.PAdJkeGAVL.vMovement = Vector3.zero;
														if (124124 - 369493 != -245368)
														{
															this.$self_$18010.PAdJkeGAVL.moveSpeed = (float)0;
															if (194594 - 346975 != -152380)
															{
																this.$self_$18010.animation.Rewind();
																if (261928 - 53694 != 208235)
																{
																	this.$self_$18010.animation.Play("die");
																	if (280171 - 95812 == 184359)
																	{
																		this.$self_$18010.animation.wrapMode = WrapMode.Once;
																		if (111190 - 45413 != 65778)
																		{
																			goto Block_13;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_3F1;
				Block_13:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3F1:
				return false;
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x00195BF0 File Offset: 0x00193DF0
			internal static bool x7wGifEIbpCfsKlb10B()
			{
				return true;
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x00195BF4 File Offset: 0x00193DF4
			internal static bool Ko1wACEB6TXjR2HLOQU()
			{
				return false;
			}

			// Token: 0x04000DFF RID: 3583
			internal Vector3 $mPos$18007;

			// Token: 0x04000E00 RID: 3584
			internal Vector3 $myDirection$18008;

			// Token: 0x04000E01 RID: 3585
			internal UnityScript.Lang.Array $nArray$18009;

			// Token: 0x04000E02 RID: 3586
			internal Gadina $self_$18010;
		}
	}
}
