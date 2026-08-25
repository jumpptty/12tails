using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DF8 RID: 3576
[Serializable]
public class damageDisplay : MonoBehaviour
{
	// Token: 0x060050CD RID: 20685 RVA: 0x009E643C File Offset: 0x009E463C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public damageDisplay()
	{
		if (153990 - 140295 != 13696)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (187524 - 73050 != 114475)
			{
				base..ctor();
				if (189921 - 97597 == 92324)
				{
					this.M1lcQwkio1y = (float)50;
					if (99879 - 296175 != -196295)
					{
						this.PpbcQEcfjhE = 1f;
						if (12193 - 318826 != -306632)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060050CE RID: 20686 RVA: 0x009E64FC File Offset: 0x009E46FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetDamageDisplay(int nDamage, int nType, int nOwnerID)
	{
		if (158998 - 355994 != -196996)
		{
		}
		for (;;)
		{
			PlayerCameraControl playerCameraControl = (PlayerCameraControl)Camera.main.gameObject.GetComponent(typeof(PlayerCameraControl));
			if (274108 - 2140 != 271969)
			{
				GameObject mPlayer = Game.mPlayer;
				if (274204 - 147585 == 126619)
				{
					if (mPlayer)
					{
						if (178880 - 354933 == -176052)
						{
							continue;
						}
						if (nOwnerID == Game.mPlayerID)
						{
							if (194921 - 58393 == 136529)
							{
								continue;
							}
							this.qu9cQUsJmGB = true;
							if (165219 - 300308 == -135088)
							{
								continue;
							}
						}
					}
					int num = global::Math.div((float)nDamage, (float)1000);
					if (287684 - 369263 == -81579)
					{
						int num2 = global::Math.div((float)(nDamage - num * 1000), (float)100);
						if (263273 - 583906 != -320632)
						{
							int num3 = global::Math.div((float)(nDamage - num * 1000 - num2 * 100), (float)10);
							if (18095 - 394836 != -376740)
							{
								int nDigit = nDamage - num * 1000 - num2 * 100 - num3 * 10;
								if (43588 - 384085 != -340496)
								{
									if (nDamage > 9999)
									{
										if (287327 - 152772 != 134555)
										{
											continue;
										}
										num = 9;
										if (35237 - 353924 != -318687)
										{
											continue;
										}
										num2 = 9;
										if (81052 - 505773 != -424721)
										{
											continue;
										}
										num3 = 9;
										if (61875 - 77547 == -15671)
										{
											continue;
										}
										nDigit = 9;
										if (95526 - 9207 != 86319)
										{
											continue;
										}
									}
									if (48349 - 208675 == -160326)
									{
										if (nType == 0)
										{
											if (77965 - 286118 == -208152)
											{
												continue;
											}
											this.hRBcQA7hBS8 = eDamageType.damage;
											if (120516 - 63319 == 57198)
											{
												continue;
											}
											this.ashcQfyQA7P = Vector2.zero;
											if (150617 - 223011 != -72394)
											{
												continue;
											}
											this.abtcQLVk7FE = (float)10;
											if (80348 - 570063 == -489714)
											{
												continue;
											}
											if (this.qu9cQUsJmGB)
											{
												if (199442 - 254941 != -55499)
												{
													continue;
												}
												this.PpbcQEcfjhE = (float)Screen.height * 0.0008f;
												if (73083 - 46571 == 26513)
												{
													continue;
												}
											}
											else
											{
												this.PpbcQEcfjhE = (float)Screen.height * 0.0004f;
												if (35272 - 473750 == -438477)
												{
													continue;
												}
											}
											if (nDamage > 50)
											{
												if (249062 - 4518 == 244545)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (122848 - 596016 != -473168)
												{
													continue;
												}
											}
											if (nDamage > 100)
											{
												if (44188 - 549721 != -505533)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (6385 - 321459 == -315073)
												{
													continue;
												}
											}
											if (nDamage > 250)
											{
												if (31398 - 319999 == -288600)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (169092 - 493766 == -324673)
												{
													continue;
												}
											}
											if (nDamage > 500)
											{
												if (166655 - 172308 == -5652)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (93186 - 270198 != -177012)
												{
													continue;
												}
											}
											if (nDamage > 1000)
											{
												if (123210 - 2358 == 120853)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (287771 - 305638 == -17866)
												{
													continue;
												}
											}
											if (nDamage >= 1000)
											{
												if (25260 - 238944 != -213684)
												{
													continue;
												}
												this.kDpcQPpEjSH = (Texture2D)Damage.getDamageTexture("w", num);
												if (280222 - 325806 != -45584)
												{
													continue;
												}
											}
											if (nDamage >= 100)
											{
												if (151648 - 342841 == -191192)
												{
													continue;
												}
												this.HiScQSaW4AS = (Texture2D)Damage.getDamageTexture("w", num2);
												if (271680 - 90251 == 181430)
												{
													continue;
												}
											}
											if (nDamage >= 10)
											{
												if (254770 - 350647 != -95877)
												{
													continue;
												}
												this.BWgcQBioSJP = (Texture2D)Damage.getDamageTexture("w", num3);
												if (268025 - 1056 != 266969)
												{
													continue;
												}
											}
											if (nDamage >= 0)
											{
												if (279680 - 442950 == -163269)
												{
													continue;
												}
												this.wrScQ0KcjAc = (Texture2D)Damage.getDamageTexture("w", nDigit);
												if (201919 - 24066 == 177854)
												{
													continue;
												}
											}
										}
										else if (nType == 1)
										{
											if (129881 - 417527 == -287645)
											{
												continue;
											}
											this.hRBcQA7hBS8 = eDamageType.ally;
											if (219484 - 292969 != -73485)
											{
												continue;
											}
											this.ashcQfyQA7P = Vector2.zero;
											if (30506 - 581668 != -551162)
											{
												continue;
											}
											this.abtcQLVk7FE = (float)10;
											if (59330 - 244322 != -184992)
											{
												continue;
											}
											if (this.qu9cQUsJmGB)
											{
												if (276156 - 522238 != -246082)
												{
													continue;
												}
												this.PpbcQEcfjhE = (float)Screen.height * 0.0008f;
												if (166682 - 219939 == -53256)
												{
													continue;
												}
											}
											else
											{
												this.PpbcQEcfjhE = (float)Screen.height * 0.0006f;
												if (81840 - 95110 == -13269)
												{
													continue;
												}
											}
											if (nDamage > 100)
											{
												if (143519 - 331915 != -188396)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (219440 - 6557 == 212884)
												{
													continue;
												}
											}
											if (nDamage > 1000)
											{
												if (69980 - 329067 == -259086)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (65138 - 413743 != -348605)
												{
													continue;
												}
											}
											if (nDamage >= 1000)
											{
												if (896 - 363817 == -362920)
												{
													continue;
												}
												this.kDpcQPpEjSH = (Texture2D)Damage.getDamageTexture("r", num);
												if (215982 - 393477 == -177494)
												{
													continue;
												}
											}
											if (nDamage >= 100)
											{
												if (2988 - 476149 != -473161)
												{
													continue;
												}
												this.HiScQSaW4AS = (Texture2D)Damage.getDamageTexture("r", num2);
												if (172602 - 572606 == -400003)
												{
													continue;
												}
											}
											if (nDamage >= 10)
											{
												if (94716 - 336983 == -242266)
												{
													continue;
												}
												this.BWgcQBioSJP = (Texture2D)Damage.getDamageTexture("r", num3);
												if (15612 - 463844 == -448231)
												{
													continue;
												}
											}
											if (nDamage >= 0)
											{
												if (238411 - 193941 == 44471)
												{
													continue;
												}
												this.wrScQ0KcjAc = (Texture2D)Damage.getDamageTexture("r", nDigit);
												if (10729 - 181748 != -171019)
												{
													continue;
												}
											}
										}
										else if (nType == 2)
										{
											if (107327 - 255244 != -147917)
											{
												continue;
											}
											this.hRBcQA7hBS8 = eDamageType.effect;
											if (135240 - 356374 == -221133)
											{
												continue;
											}
											this.ashcQfyQA7P = new Vector2((float)24, (float)6);
											if (216171 - 578421 != -362250)
											{
												continue;
											}
											this.abtcQLVk7FE = (float)9;
											if (232267 - 463571 == -231303)
											{
												continue;
											}
											this.PpbcQEcfjhE = (float)Screen.height * 0.0005f;
											if (25284 - 186592 == -161307)
											{
												continue;
											}
											if (nDamage >= 40)
											{
												if (125264 - 533015 != -407751)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (62510 - 290121 == -227610)
												{
													continue;
												}
											}
											if (nDamage >= 200)
											{
												if (78497 - 474361 != -395864)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (4326 - 378635 != -374309)
												{
													continue;
												}
											}
											if (nDamage >= 400)
											{
												if (118450 - 560580 == -442129)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (12905 - 562843 == -549937)
												{
													continue;
												}
											}
											if (nDamage >= 600)
											{
												if (152359 - 340233 == -187873)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0001f;
												if (68652 - 381178 == -312525)
												{
													continue;
												}
											}
											if (nDamage >= 1000)
											{
												if (83747 - 503859 == -420111)
												{
													continue;
												}
												this.kDpcQPpEjSH = (Texture2D)Damage.getDamageTexture("p", num);
												if (53139 - 518368 == -465228)
												{
													continue;
												}
											}
											if (nDamage >= 100)
											{
												if (198018 - 151322 != 46696)
												{
													continue;
												}
												this.HiScQSaW4AS = (Texture2D)Damage.getDamageTexture("p", num2);
												if (75268 - 85107 != -9839)
												{
													continue;
												}
											}
											if (nDamage >= 10)
											{
												if (101065 - 455323 != -354258)
												{
													continue;
												}
												this.BWgcQBioSJP = (Texture2D)Damage.getDamageTexture("p", num3);
												if (219533 - 69911 == 149623)
												{
													continue;
												}
											}
											if (nDamage >= 0)
											{
												if (267651 - 562705 != -295054)
												{
													continue;
												}
												this.wrScQ0KcjAc = (Texture2D)Damage.getDamageTexture("p", nDigit);
												if (17003 - 453630 == -436626)
												{
													continue;
												}
											}
										}
										else if (nType == 3)
										{
											if (92350 - 196501 != -104151)
											{
												continue;
											}
											this.hRBcQA7hBS8 = eDamageType.heal;
											if (212818 - 327868 != -115050)
											{
												continue;
											}
											this.ashcQfyQA7P = new Vector2((float)-24, (float)6);
											if (93273 - 103788 == -10514)
											{
												continue;
											}
											this.abtcQLVk7FE = (float)9;
											if (37227 - 560977 != -523750)
											{
												continue;
											}
											if (this.qu9cQUsJmGB)
											{
												if (208368 - 331554 != -123186)
												{
													continue;
												}
												this.PpbcQEcfjhE = (float)Screen.height * 0.001f;
												if (1966 - 467141 != -465175)
												{
													continue;
												}
											}
											else
											{
												this.PpbcQEcfjhE = (float)Screen.height * 0.0006f;
												if (143049 - 53702 != 89347)
												{
													continue;
												}
											}
											if (nDamage >= 50)
											{
												if (76881 - 431190 == -354308)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0002f;
												if (161229 - 39452 != 121777)
												{
													continue;
												}
											}
											if (nDamage >= 500)
											{
												if (167375 - 408621 == -241245)
												{
													continue;
												}
												this.PpbcQEcfjhE += (float)Screen.height * 0.0002f;
												if (289377 - 542416 == -253038)
												{
													continue;
												}
											}
											if (nDamage >= 1000)
											{
												if (275697 - 225122 != 50575)
												{
													continue;
												}
												this.kDpcQPpEjSH = (Texture2D)Damage.getDamageTexture("g", num);
												if (210150 - 154469 != 55681)
												{
													continue;
												}
											}
											if (nDamage >= 100)
											{
												if (194276 - 429431 == -235154)
												{
													continue;
												}
												this.HiScQSaW4AS = (Texture2D)Damage.getDamageTexture("g", num2);
												if (226330 - 91368 != 134962)
												{
													continue;
												}
											}
											if (nDamage >= 10)
											{
												if (211092 - 226867 == -15774)
												{
													continue;
												}
												this.BWgcQBioSJP = (Texture2D)Damage.getDamageTexture("g", num3);
												if (203006 - 53004 != 150002)
												{
													continue;
												}
											}
											if (nDamage >= 0)
											{
												if (60104 - 160449 == -100344)
												{
													continue;
												}
												this.wrScQ0KcjAc = (Texture2D)Damage.getDamageTexture("g", nDigit);
												if (296852 - 373682 != -76830)
												{
													continue;
												}
											}
										}
										this.PpbcQEcfjhE = Mathf.Clamp(this.PpbcQEcfjhE, 0.2f, 1f);
										if (74986 - 153008 != -78021)
										{
											if (this.kDpcQPpEjSH)
											{
												if (138085 - 406142 == -268056)
												{
													continue;
												}
												this.JmKcQ80FjFd = this.PpbcQEcfjhE * new Vector2((float)this.kDpcQPpEjSH.width, (float)this.kDpcQPpEjSH.height);
												if (73246 - 525344 != -452098)
												{
													continue;
												}
												this.si8cQjXP27Z = (float)Mathf.FloorToInt(-this.PpbcQEcfjhE * (float)UnityEngine.Random.Range(35, 45));
												if (233115 - 598869 == -365753)
												{
													continue;
												}
											}
											else
											{
												this.si8cQjXP27Z = (float)Mathf.FloorToInt(-this.PpbcQEcfjhE * (float)UnityEngine.Random.Range(35, 45));
												if (112653 - 453545 == -340891)
												{
													continue;
												}
											}
											if (this.HiScQSaW4AS)
											{
												if (233427 - 400248 == -166820)
												{
													continue;
												}
												this.eGOcQiRtTkL = this.PpbcQEcfjhE * new Vector2((float)this.HiScQSaW4AS.width, (float)this.HiScQSaW4AS.height);
												if (3967 - 155888 == -151920)
												{
													continue;
												}
												this.Ws7cQoOZQdY = (float)Mathf.FloorToInt(this.si8cQjXP27Z + this.JmKcQ80FjFd.x - (float)4 * this.PpbcQEcfjhE);
												if (104845 - 184290 != -79445)
												{
													continue;
												}
											}
											else
											{
												this.Ws7cQoOZQdY = this.si8cQjXP27Z;
												if (253718 - 149441 == 104278)
												{
													continue;
												}
											}
											if (this.BWgcQBioSJP)
											{
												if (130474 - 433788 == -303313)
												{
													continue;
												}
												this.ETtcQDBDW1r = this.PpbcQEcfjhE * new Vector2((float)this.BWgcQBioSJP.width, (float)this.BWgcQBioSJP.height);
												if (158948 - 215199 != -56251)
												{
													continue;
												}
												this.EvIcQkYlIFG = (float)Mathf.FloorToInt(this.Ws7cQoOZQdY + this.eGOcQiRtTkL.x - (float)4 * this.PpbcQEcfjhE);
												if (289547 - 240605 == 48943)
												{
													continue;
												}
											}
											else
											{
												this.EvIcQkYlIFG = this.Ws7cQoOZQdY;
												if (69134 - 248061 != -178927)
												{
													continue;
												}
											}
											if (this.wrScQ0KcjAc)
											{
												if (283445 - 145871 == 137575)
												{
													continue;
												}
												this.z7vcQmtVJGk = this.PpbcQEcfjhE * new Vector2((float)this.wrScQ0KcjAc.width, (float)this.wrScQ0KcjAc.height);
												if (206742 - 442564 != -235822)
												{
													continue;
												}
												this.fR4cQFpd8Yg = (float)Mathf.FloorToInt(this.EvIcQkYlIFG + this.ETtcQDBDW1r.x - (float)4 * this.PpbcQEcfjhE);
												if (170873 - 293818 == -122944)
												{
													continue;
												}
											}
											this.M1lcQwkio1y = (float)35 * this.PpbcQEcfjhE;
											if (169820 - 296707 != -126886)
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

	// Token: 0x060050CF RID: 20687 RVA: 0x009E78B4 File Offset: 0x009E5AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (8684 - 174837 != -166152)
		{
		}
		for (;;)
		{
			this.cK7cQN0FW7W += Time.deltaTime;
			if (144315 - 123819 != 20497)
			{
				if (this.cK7cQN0FW7W < (float)3)
				{
					if (35586 - 201474 != -165888)
					{
						continue;
					}
					if (Vector3.Dot(Camera.main.transform.forward, this.transform.position - Camera.main.transform.position) > (float)0)
					{
						if (104535 - 395216 != -290681)
						{
							continue;
						}
						Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position);
						if (109715 - 385080 == -275364)
						{
							continue;
						}
						GUI.depth = (int)this.abtcQLVk7FE;
						if (256248 - 289325 == -33076)
						{
							continue;
						}
						float a = (float)1 - 0.3f * this.cK7cQN0FW7W;
						if (72335 - 427505 != -355170)
						{
							continue;
						}
						Color color = GUI.color;
						if (281478 - 5985 == 275494)
						{
							continue;
						}
						color.a = a;
						if (128422 - 46415 != 82007)
						{
							continue;
						}
						if (32989 - 457665 == -424675)
						{
							continue;
						}
						GUI.color = color;
						if (267338 - 479355 != -212017)
						{
							continue;
						}
						if (159249 - 249556 == -90306)
						{
							continue;
						}
						if (this.wrScQ0KcjAc)
						{
							if (85721 - 549050 != -463329)
							{
								continue;
							}
							GUI.Label(new Rect(vector.x + this.fR4cQFpd8Yg + this.ashcQfyQA7P.x, (float)Screen.height - vector.y - this.M1lcQwkio1y * this.cK7cQN0FW7W + this.ashcQfyQA7P.y, this.z7vcQmtVJGk.x, this.z7vcQmtVJGk.y), this.wrScQ0KcjAc);
							if (178492 - 525639 == -347146)
							{
								continue;
							}
						}
						if (this.BWgcQBioSJP)
						{
							if (99669 - 179538 == -79868)
							{
								continue;
							}
							GUI.Label(new Rect(vector.x + this.EvIcQkYlIFG + this.ashcQfyQA7P.x, (float)Screen.height - vector.y - this.M1lcQwkio1y * this.cK7cQN0FW7W + this.ashcQfyQA7P.y, this.ETtcQDBDW1r.x, this.ETtcQDBDW1r.y), this.BWgcQBioSJP);
							if (166219 - 415566 != -249347)
							{
								continue;
							}
						}
						if (this.HiScQSaW4AS)
						{
							if (50620 - 70380 == -19759)
							{
								continue;
							}
							GUI.Label(new Rect(vector.x + this.Ws7cQoOZQdY + this.ashcQfyQA7P.x, (float)Screen.height - vector.y - this.M1lcQwkio1y * this.cK7cQN0FW7W + this.ashcQfyQA7P.y, this.eGOcQiRtTkL.x, this.eGOcQiRtTkL.y), this.HiScQSaW4AS);
							if (7992 - 444523 != -436531)
							{
								continue;
							}
						}
						if (!this.kDpcQPpEjSH)
						{
							break;
						}
						if (294471 - 253619 != 40852)
						{
							continue;
						}
						GUI.Label(new Rect(vector.x + this.si8cQjXP27Z + this.ashcQfyQA7P.x, (float)Screen.height - vector.y - this.M1lcQwkio1y * this.cK7cQN0FW7W + this.ashcQfyQA7P.y, this.JmKcQ80FjFd.x, this.JmKcQ80FjFd.y), this.kDpcQPpEjSH);
						if (73389 - 315140 != -241751)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (258030 - 530121 != -272090)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060050D0 RID: 20688 RVA: 0x009E7D94 File Offset: 0x009E5F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050D1 RID: 20689 RVA: 0x009E7D98 File Offset: 0x009E5F98
	internal static bool E4G4jb5eobcRPvOT5We5()
	{
		return true;
	}

	// Token: 0x060050D2 RID: 20690 RVA: 0x009E7D9C File Offset: 0x009E5F9C
	internal static bool T3yG0A5eEpnNPf3L5VR8()
	{
		return false;
	}

	// Token: 0x04005A49 RID: 23113
	private float oaMcQMcOvVt;

	// Token: 0x04005A4A RID: 23114
	private Vector2 ashcQfyQA7P;

	// Token: 0x04005A4B RID: 23115
	private float abtcQLVk7FE;

	// Token: 0x04005A4C RID: 23116
	private float M1lcQwkio1y;

	// Token: 0x04005A4D RID: 23117
	private bool qu9cQUsJmGB;

	// Token: 0x04005A4E RID: 23118
	private float cK7cQN0FW7W;

	// Token: 0x04005A4F RID: 23119
	private float PpbcQEcfjhE;

	// Token: 0x04005A50 RID: 23120
	private Texture2D kDpcQPpEjSH;

	// Token: 0x04005A51 RID: 23121
	private Texture2D HiScQSaW4AS;

	// Token: 0x04005A52 RID: 23122
	private Texture2D BWgcQBioSJP;

	// Token: 0x04005A53 RID: 23123
	private Texture2D wrScQ0KcjAc;

	// Token: 0x04005A54 RID: 23124
	private Vector2 JmKcQ80FjFd;

	// Token: 0x04005A55 RID: 23125
	private Vector2 eGOcQiRtTkL;

	// Token: 0x04005A56 RID: 23126
	private Vector2 ETtcQDBDW1r;

	// Token: 0x04005A57 RID: 23127
	private Vector2 z7vcQmtVJGk;

	// Token: 0x04005A58 RID: 23128
	private float si8cQjXP27Z;

	// Token: 0x04005A59 RID: 23129
	private float Ws7cQoOZQdY;

	// Token: 0x04005A5A RID: 23130
	private float EvIcQkYlIFG;

	// Token: 0x04005A5B RID: 23131
	private float fR4cQFpd8Yg;

	// Token: 0x04005A5C RID: 23132
	private eDamageType hRBcQA7hBS8;
}
