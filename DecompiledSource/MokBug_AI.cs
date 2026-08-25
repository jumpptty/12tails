using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000FB RID: 251
[Serializable]
public class MokBug_AI : MonoBehaviour
{
	// Token: 0x06000583 RID: 1411 RVA: 0x000929E8 File Offset: 0x00090BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MokBug_AI()
	{
		if (180065 - 406626 != -226560)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (228392 - 234409 != -6016)
			{
				base..ctor();
				if (278622 - 18556 != 260067)
				{
					this.AI_state = "none";
					if (195128 - 214874 != -19745)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00092A84 File Offset: 0x00090C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.QLtnc0aYZ5 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.JsCnnOFent = (MokBug)this.GetComponent(typeof(MokBug));
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00092ABC File Offset: 0x00090CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (247272 - 525596 != -278323)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (79627 - 365743 == -286115)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (74406 - 551775 == -477368)
				{
					continue;
				}
			}
			if (this.QLtnc0aYZ5.isControlled)
			{
				break;
			}
			if (11112 - 461757 != -450644)
			{
				this.AIControl();
				if (149672 - 401675 != -252002)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00092B88 File Offset: 0x00090D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (155406 - 81426 != 73980)
		{
		}
		for (;;)
		{
			this.Esbnel7rL0 = (float)0;
			if (182380 - 578063 == -395683)
			{
				if (this.QLtnc0aYZ5.isMine)
				{
					if (158186 - 41063 != 117124)
					{
						if (this.QLtnc0aYZ5.actionState != "standby")
						{
							if (239238 - 394105 != -154867)
							{
								continue;
							}
							if (this.QLtnc0aYZ5.actionState != "battle")
							{
								if (188520 - 221832 != -33312)
								{
									continue;
								}
								if (this.QLtnc0aYZ5.actionState != "run")
								{
									if (189073 - 578583 != -389510)
									{
										continue;
									}
									break;
								}
							}
						}
						if (!this.QLtnc0aYZ5.isAlert)
						{
							if (142193 - 242213 == -100020)
							{
								this.AI_idle(1f, 1f);
								if (167567 - 155407 != 12161)
								{
									this.AI_path(30f, 3f);
									if (42131 - 151652 == -109521)
									{
										this.AI_resetTimer();
										if (231564 - 289551 != -57986)
										{
											this.AI_visionCheck();
											if (203021 - 391664 == -188643)
											{
												if (!this.QLtnc0aYZ5.myAttackTarget)
												{
													break;
												}
												if (196049 - 598974 == -402925)
												{
													this.QLtnc0aYZ5.isAlert = true;
													if (259944 - 92653 == 167291)
													{
														this.zD9nQ0LwuH = Time.time;
														if (115252 - 120413 == -5161)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (173188 - 138852 != 34337)
							{
								this.AI_battle(1f, 0.5f);
								if (155460 - 212245 != -56784)
								{
									this.AI_attack(6f, (float)0);
									if (95334 - 345247 == -249913)
									{
										this.AI_resetTimer();
										if (114734 - 528803 == -414069)
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
					if (this.QLtnc0aYZ5.actionState != "standby")
					{
						if (207876 - 340829 == -132952)
						{
							continue;
						}
						if (this.QLtnc0aYZ5.actionState != "battle")
						{
							if (211316 - 74266 != 137050)
							{
								continue;
							}
							if (this.QLtnc0aYZ5.actionState != "run")
							{
								if (204419 - 331627 != -127208)
								{
									continue;
								}
								break;
							}
						}
					}
					float num = this.QLtnc0aYZ5.moveSpeed;
					if (117664 - 176010 == -58346)
					{
						float runSpeed = this.QLtnc0aYZ5.runSpeed;
						if (69422 - 70627 != -1204)
						{
							Vector3 vMovement = Vector3.zero;
							if (162711 - 216373 == -53662)
							{
								Vector3 lhs = Vector3.Scale(this.QLtnc0aYZ5.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
								if (95728 - 66733 != 28996)
								{
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (158114 - 198506 == -40392)
									{
										if (num <= 0.1f * runSpeed)
										{
											if (265354 - 1586 != 263768)
											{
												continue;
											}
											num = (float)0;
											if (11893 - 351324 != -339431)
											{
												continue;
											}
											this.transform.position = this.QLtnc0aYZ5.nPosition;
											if (21679 - 93833 != -72154)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (190305 - 186899 != 3406)
											{
												continue;
											}
											vMovement = this.transform.forward;
											if (286678 - 264088 == 22591)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.4f);
											if (212606 - 184002 != 28604)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69927 - 550444 == -480516)
											{
												continue;
											}
										}
										else
										{
											vMovement = this.transform.forward;
											if (73092 - 213113 != -140021)
											{
												continue;
											}
											if (this.QLtnc0aYZ5.actionState == "battle")
											{
												if (223867 - 290204 == -66336)
												{
													continue;
												}
												this.animation.CrossFade("battle", 0.4f);
												if (1502 - 589523 == -588020)
												{
													continue;
												}
											}
											else
											{
												this.animation.CrossFade("root", 0.4f);
												if (154318 - 452717 == -298398)
												{
													continue;
												}
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (107645 - 380383 == -272737)
											{
												continue;
											}
										}
										this.QLtnc0aYZ5.vMovement = vMovement;
										if (259859 - 218975 != 40885)
										{
											this.QLtnc0aYZ5.moveSpeed = num;
											if (226005 - 534523 == -308518)
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

	// Token: 0x06000587 RID: 1415 RVA: 0x00093258 File Offset: 0x00091458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (236447 - 400158 != -163711)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (132531 - 373420 != -240889)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (69173 - 574454 != -505281)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (170600 - 341438 != -170838)
						{
							continue;
						}
						this.AI_state = "idle";
						if (44618 - 52990 != -8372)
						{
							continue;
						}
						this.zD9nQ0LwuH -= UnityEngine.Random.Range((float)0, rTimer);
						if (123996 - 509858 != -385862)
						{
							continue;
						}
						this.QLtnc0aYZ5.vDirection = Vector3.zero;
						if (218210 - 394328 == -176117)
						{
							continue;
						}
						this.QLtnc0aYZ5.vMovement = this.transform.forward;
						if (227704 - 520974 == -293269)
						{
							continue;
						}
						this.QLtnc0aYZ5.actionState = "standby";
						if (191170 - 50184 != 140986)
						{
							continue;
						}
					}
					this.QLtnc0aYZ5.moveSpeed = Mathf.Lerp(this.QLtnc0aYZ5.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (96698 - 597920 != -501222)
					{
						continue;
					}
					if (this.QLtnc0aYZ5.moveSpeed < 0.1f * this.QLtnc0aYZ5.runSpeed)
					{
						if (180625 - 546409 != -365784)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.4f);
						if (266308 - 250719 != 15589)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (200097 - 172230 != 27867)
						{
							continue;
						}
						this.QLtnc0aYZ5.moveSpeed = (float)0;
						if (29165 - 418811 != -389646)
						{
							continue;
						}
					}
				}
			}
			this.Esbnel7rL0 += mTime;
		}
		while (299528 - 593353 == -293824);
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0009351C File Offset: 0x0009171C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battle(float mTime, float rTimer)
	{
		if (257922 - 12265 != 245657)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (8818 - 64545 == -55726)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (133298 - 160871 != -27573)
					{
						continue;
					}
					if (this.AI_state != "battle")
					{
						if (169650 - 64193 == 105458)
						{
							continue;
						}
						this.AI_state = "battle";
						if (84339 - 570179 == -485839)
						{
							continue;
						}
						this.zD9nQ0LwuH -= UnityEngine.Random.Range((float)0, rTimer);
						if (53004 - 396454 != -343450)
						{
							continue;
						}
						if (this.QLtnc0aYZ5.actionState != "battle")
						{
							if (203345 - 210292 == -6946)
							{
								continue;
							}
							this.QLtnc0aYZ5.actionState = "battle";
							if (48603 - 411519 != -362916)
							{
								continue;
							}
							this.JsCnnOFent.RPC_battle(this.transform.position, this.transform.forward, 0);
							if (31592 - 595323 == -563730)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (239904 - 293385 != -53481)
								{
									continue;
								}
								this.JsCnnOFent.ActionEvent("RPC_battle", this.transform.position, this.transform.forward, 0);
								if (38729 - 106814 != -68085)
								{
									continue;
								}
							}
						}
					}
					this.QLtnc0aYZ5.moveSpeed = Mathf.Lerp(this.QLtnc0aYZ5.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (120498 - 83223 == 37276)
					{
						continue;
					}
				}
			}
			this.Esbnel7rL0 += mTime;
		}
		while (89716 - 414149 != -324433);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x000937A4 File Offset: 0x000919A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (259132 - 220752 != 38380)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (1574 - 520914 != -519340)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (31231 - 387182 == -355950)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (262690 - 487378 == -224687)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (86827 - 541348 != -454521)
						{
							continue;
						}
						this.zD9nQ0LwuH -= UnityEngine.Random.Range((float)0, rTimer);
						if (274272 - 72709 != 201563)
						{
							continue;
						}
						this.QLtnc0aYZ5.vDirection = this.QLtnc0aYZ5.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (291505 - 185423 == 106083)
						{
							continue;
						}
						this.QLtnc0aYZ5.vDirection.y = this.transform.position.y;
						if (109729 - 391194 == -281464)
						{
							continue;
						}
						this.QLtnc0aYZ5.vMovement = (this.QLtnc0aYZ5.vDirection - this.transform.position).normalized;
						if (194141 - 559010 == -364868)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.QLtnc0aYZ5.vMovement);
						if (105528 - 396891 == -291362)
						{
							continue;
						}
						this.QLtnc0aYZ5.actionState = "run";
						if (7458 - 122104 == -114645)
						{
							continue;
						}
						this.animation.Play("run");
						if (292896 - 53220 == 239677)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (9204 - 297597 != -288393)
						{
							continue;
						}
					}
					this.QLtnc0aYZ5.moveSpeed = Mathf.Lerp(this.QLtnc0aYZ5.moveSpeed, this.QLtnc0aYZ5.runSpeed, (float)4 * Time.deltaTime);
					if (128429 - 448191 != -319762)
					{
						continue;
					}
				}
			}
			this.Esbnel7rL0 += mTime;
		}
		while (248472 - 17343 == 231130);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00093AAC File Offset: 0x00091CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_path(float mTime, float rTimer)
	{
		if (287295 - 366010 != -78714)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (252731 - 239692 == 13040)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (173420 - 23964 != 149456)
					{
						continue;
					}
					if (this.AI_state != "path")
					{
						if (35874 - 256389 == -220514)
						{
							continue;
						}
						this.AI_state = "path";
						if (202938 - 198581 != 4357)
						{
							continue;
						}
						this.zD9nQ0LwuH -= UnityEngine.Random.Range((float)0, rTimer);
						if (186754 - 205734 == -18979)
						{
							continue;
						}
						this.QLtnc0aYZ5.vDirection = this.transform.forward;
						if (24292 - 230376 != -206084)
						{
							continue;
						}
						this.QLtnc0aYZ5.vMovement = this.transform.forward;
						if (270233 - 86486 == 183748)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.QLtnc0aYZ5.vMovement);
						if (683 - 107226 == -106542)
						{
							continue;
						}
						this.QLtnc0aYZ5.actionState = "run";
						if (8847 - 406632 == -397784)
						{
							continue;
						}
						this.animation.CrossFade("run", 0.4f);
						if (278594 - 330422 == -51827)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (91972 - 292521 != -200549)
						{
							continue;
						}
					}
					else
					{
						this.QLtnc0aYZ5.vMovement = this.transform.forward;
						if (44085 - 430210 == -386124)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.transform.forward);
						if (7398 - 505616 != -498218)
						{
							continue;
						}
						this.QLtnc0aYZ5.moveSpeed = Mathf.Lerp(this.QLtnc0aYZ5.moveSpeed, this.QLtnc0aYZ5.runSpeed, (float)2 * Time.deltaTime);
						if (105969 - 521687 == -415717)
						{
							continue;
						}
					}
				}
			}
			this.Esbnel7rL0 += mTime;
		}
		while (107124 - 251629 != -144505);
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00093DBC File Offset: 0x00091FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (284632 - 344869 != -60237)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (89133 - 395517 == -306383)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (143921 - 176397 == -32475)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (203803 - 202971 != 832)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (34678 - 593698 == -559019)
						{
							continue;
						}
						this.zD9nQ0LwuH = Time.time - mTime - this.Esbnel7rL0;
						if (206039 - 36900 == 169140)
						{
							continue;
						}
						this.QLtnc0aYZ5.myAttackTarget = this.findBattleTarget();
						if (20022 - 112589 != -92567)
						{
							continue;
						}
						if (!this.QLtnc0aYZ5.myAttackTarget)
						{
							if (53091 - 343168 != -290077)
							{
								continue;
							}
							this.QLtnc0aYZ5.addTimeOut("battle", (float)12);
							if (138315 - 125212 != 13103)
							{
								continue;
							}
							this.QLtnc0aYZ5.isAlert = false;
							if (137142 - 134331 != 2811)
							{
								continue;
							}
							this.zD9nQ0LwuH = Time.time;
							if (238276 - 314190 == -75913)
							{
								continue;
							}
							this.QLtnc0aYZ5.actionState = "standby";
							if (74781 - 206125 == -131343)
							{
								continue;
							}
							this.QLtnc0aYZ5.mOriginalPosition = this.transform.position;
							if (284519 - 181186 != 103333)
							{
								continue;
							}
							break;
						}
						else if (this.QLtnc0aYZ5.actionState != "battle")
						{
							if (258818 - 297523 != -38705)
							{
								continue;
							}
							this.QLtnc0aYZ5.actionState = "battle";
							if (258899 - 524695 == -265795)
							{
								continue;
							}
							this.JsCnnOFent.RPC_battle(this.transform.position, this.transform.forward, 0);
							if (48762 - 370712 == -321949)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (194030 - 259025 != -64995)
								{
									continue;
								}
								this.JsCnnOFent.ActionEvent("RPC_battle", this.transform.position, this.transform.forward, 0);
								if (85646 - 285220 != -199574)
								{
									continue;
								}
							}
						}
						else if (this.QLtnc0aYZ5.isTimeOut("standby") == (float)0)
						{
							if (262982 - 15132 == 247851)
							{
								continue;
							}
							this.QLtnc0aYZ5.addTimeOut("battle", (float)12);
							if (23867 - 448730 != -424863)
							{
								continue;
							}
							this.QLtnc0aYZ5.isAlert = false;
							if (35039 - 542963 == -507923)
							{
								continue;
							}
							this.QLtnc0aYZ5.myAttackTarget = null;
							if (94238 - 285829 != -191591)
							{
								continue;
							}
							this.zD9nQ0LwuH = Time.time;
							if (5593 - 2367 != 3226)
							{
								continue;
							}
							this.QLtnc0aYZ5.actionState = "standby";
							if (262982 - 475527 != -212545)
							{
								continue;
							}
							this.QLtnc0aYZ5.mOriginalPosition = this.transform.position;
							if (291009 - 195134 != 95875)
							{
								continue;
							}
						}
					}
				}
			}
			this.Esbnel7rL0 += mTime;
		}
		while (45861 - 154667 != -108806);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00094260 File Offset: 0x00092460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject findBattleTarget()
	{
		if (23923 - 283725 != -259801)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			IL_36:
			UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position + (float)6 * this.transform.forward, (float)7, this.gameObject.layer);
			if (295397 - 432363 == -136966)
			{
				if (185354 - 581032 == -395678)
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
					if (77985 - 315114 == -237129)
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
							gameObject = (GameObject)obj4;
							if (27948 - 129818 == -101869)
							{
								goto IL_36;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (70590 - 526293 == -455702)
							{
								goto IL_36;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (116907 - 432570 != -315663)
							{
								goto IL_36;
							}
							bool flag = true;
							if (269305 - 339531 == -70225)
							{
								goto IL_36;
							}
							eRace race = this.QLtnc0aYZ5.Race;
							if (217675 - 94721 != 122954)
							{
								goto IL_36;
							}
							if (race == eRace.Tails)
							{
								if (262202 - 359214 == -97011)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Plants)
								{
									goto IL_501;
								}
								if (44284 - 6052 != 38232)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Structure)
								{
									if (61729 - 153362 != -91633)
									{
										goto IL_36;
									}
									goto IL_501;
								}
								goto IL_31D;
								IL_501:
								flag = false;
								if (186436 - 458817 != -272381)
								{
									goto IL_36;
								}
							}
							else if (race == eRace.Plants)
							{
								if (132719 - 193607 != -60888)
								{
									goto IL_36;
								}
								flag = false;
								if (110095 - 98988 != 11107)
								{
									goto IL_36;
								}
							}
							else if (race == eRace.Bugs)
							{
								if (182769 - 188439 != -5670)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Elementals)
								{
									goto IL_10E;
								}
								if (130717 - 152916 != -22199)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Robots)
								{
									if (89103 - 294263 != -205159)
									{
										goto IL_10E;
									}
									goto IL_36;
								}
								goto IL_31D;
								IL_10E:
								flag = false;
								if (53915 - 85149 != -31234)
								{
									goto IL_36;
								}
							}
							else if (race == eRace.Robots)
							{
								if (178989 - 433653 == -254663)
								{
									goto IL_36;
								}
								flag = true;
								if (109111 - 81447 == 27665)
								{
									goto IL_36;
								}
							}
							else if (race == eRace.Elementals)
							{
								if (178301 - 61755 != 116546)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Plants)
								{
									goto IL_2FC;
								}
								if (263194 - 180301 == 82894)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Bugs)
								{
									goto IL_2FC;
								}
								if (63490 - 251874 != -188384)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Structure)
								{
									if (160418 - 489826 != -329407)
									{
										goto IL_2FC;
									}
									goto IL_36;
								}
								goto IL_31D;
								IL_2FC:
								flag = false;
								if (38004 - 428740 == -390735)
								{
									goto IL_36;
								}
							}
							else if (race == eRace.Structure)
							{
								if (241727 - 370408 != -128681)
								{
									goto IL_36;
								}
								if (characterControl.Race == eRace.Plants)
								{
									if (187262 - 230351 == -43088)
									{
										goto IL_36;
									}
									flag = false;
									if (16920 - 563522 != -546602)
									{
										goto IL_36;
									}
								}
							}
							IL_31D:
							if (flag)
							{
								if (104778 - 498902 != -394124)
								{
									goto IL_36;
								}
								if (characterControl.hp > 0)
								{
									if (249995 - 461974 == -211978)
									{
										goto IL_36;
									}
									if (characterControl.recieveTarget)
									{
										if (82387 - 113517 != -31130)
										{
											goto IL_36;
										}
										if (characterControl.getStatus("invisible") == null)
										{
											if (60399 - 59179 == 1221)
											{
												goto IL_36;
											}
											if (characterControl.getStatus("blend") == null)
											{
												if (268658 - 310173 == -41514)
												{
													goto IL_36;
												}
												float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position - (float)6 * this.transform.forward);
												if (127056 - 308042 == -180985)
												{
													goto IL_36;
												}
												UnityRuntimeServices.Update(enumerator, gameObject);
												if (227797 - 564248 != -336451)
												{
													goto IL_36;
												}
												Debug.Log(num);
												if (162419 - 191220 == -28800)
												{
													goto IL_36;
												}
												if (num < (float)90)
												{
													if (260808 - 369038 == -108229)
													{
														goto IL_36;
													}
													if (characterControl.hp > 0)
													{
														if (27972 - 440418 != -412445)
														{
															goto Block_16;
														}
														goto IL_36;
													}
												}
											}
										}
									}
								}
							}
						}
						if (73783 - 521716 == -447933)
						{
							goto IL_625;
						}
					}
				}
			}
		}
		Block_16:
		return gameObject;
		IL_625:
		return null;
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x000948A4 File Offset: 0x00092AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (291903 - 148816 != 143088)
		{
		}
		do
		{
			if (Time.time - this.zD9nQ0LwuH >= this.Esbnel7rL0)
			{
				if (42818 - 234855 == -192036)
				{
					continue;
				}
				if (Time.time - this.zD9nQ0LwuH < this.Esbnel7rL0 + mTime)
				{
					if (95786 - 138034 != -42248)
					{
						continue;
					}
					if (!this.QLtnc0aYZ5.myAttackTarget)
					{
						if (265623 - 200187 != 65436)
						{
							continue;
						}
						this.zD9nQ0LwuH = Time.time - mTime - this.Esbnel7rL0;
						if (284065 - 156540 != 127526)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.QLtnc0aYZ5.myAttackTarget;
						if (13388 - 453283 == -439894)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (259676 - 421541 != -161865)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (74260 - 214654 == -140393 || 27407 - 511281 == -483873)
						{
							continue;
						}
						if (characterControl)
						{
							if (284617 - 593863 == -309245)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (77272 - 184643 == -107370)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (52350 - 547665 != -495315)
						{
							continue;
						}
						if ((float)this.QLtnc0aYZ5.hp < 0.65f * (float)this.QLtnc0aYZ5.mhp)
						{
							if (157033 - 476020 != -318987)
							{
								continue;
							}
							if (this.QLtnc0aYZ5.isTimeOut("mokStomp") == (float)0)
							{
								if (290900 - 290635 == 266)
								{
									continue;
								}
								this.JsCnnOFent.StartCoroutine_Auto(this.JsCnnOFent.RPC_mokStomp(this.transform.position, this.transform.forward, 0));
								if (165555 - 349204 != -183648)
								{
									if (PhotonClient.IsInitialized())
									{
										if (43686 - 357026 != -313340)
										{
											continue;
										}
										this.JsCnnOFent.ActionEvent("RPC_mokStomp", this.transform.position, this.transform.forward, 0);
										if (152238 - 371557 != -219319)
										{
											continue;
										}
									}
									goto IL_684;
								}
								continue;
							}
						}
						if ((float)this.QLtnc0aYZ5.hp < 0.35f * (float)this.QLtnc0aYZ5.mhp)
						{
							if (153357 - 174481 != -21124)
							{
								continue;
							}
							if (this.QLtnc0aYZ5.isTimeOut("tailSpin") == (float)0)
							{
								if (149185 - 56015 != 93170)
								{
									continue;
								}
								this.JsCnnOFent.StartCoroutine_Auto(this.JsCnnOFent.RPC_tailSpin(this.transform.position, this.transform.forward, 0));
								if (122039 - 243193 != -121154)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (293484 - 332307 == -38822)
									{
										continue;
									}
									this.JsCnnOFent.ActionEvent("RPC_tailSpin", this.transform.position, this.transform.forward, 0);
									if (232472 - 435461 != -202989)
									{
										continue;
									}
								}
								goto IL_684;
							}
						}
						if (this.QLtnc0aYZ5.isTimeOut("nAttack") == (float)0)
						{
							if (241346 - 19019 == 222328)
							{
								continue;
							}
							this.zD9nQ0LwuH = Time.time - mTime - this.Esbnel7rL0;
							if (255708 - 300167 != -44459)
							{
								continue;
							}
							int num2 = UnityEngine.Random.Range(0, 3);
							if (115545 - 65023 == 50523)
							{
								continue;
							}
							if (num2 == 1)
							{
								if (205339 - 16948 == 188392)
								{
									continue;
								}
								this.JsCnnOFent.StartCoroutine_Auto(this.JsCnnOFent.RPC_leftSmash(this.transform.position, this.transform.forward, 0));
								if (281398 - 354255 != -72857)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (242364 - 138630 == 103735)
									{
										continue;
									}
									this.JsCnnOFent.ActionEvent("RPC_leftSmash", this.transform.position, this.transform.forward, 0);
									if (9952 - 180388 != -170436)
									{
										continue;
									}
								}
							}
							else if (num2 == 2)
							{
								if (230706 - 148479 == 82228)
								{
									continue;
								}
								this.JsCnnOFent.StartCoroutine_Auto(this.JsCnnOFent.RPC_rightSweep(this.transform.position, this.transform.forward, 0));
								if (16264 - 143731 != -127467)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (78748 - 167061 != -88313)
									{
										continue;
									}
									this.JsCnnOFent.ActionEvent("RPC_rightSweep", this.transform.position, this.transform.forward, 0);
									if (120334 - 420600 != -300266)
									{
										continue;
									}
								}
							}
							else
							{
								this.JsCnnOFent.StartCoroutine_Auto(this.JsCnnOFent.RPC_headSmash(this.transform.position, this.transform.forward, 0));
								if (5108 - 71376 != -66268)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (282843 - 50143 == 232701)
									{
										continue;
									}
									this.JsCnnOFent.ActionEvent("RPC_headSmash", this.transform.position, this.transform.forward, 0);
									if (204078 - 449704 != -245626)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.animation.CrossFade("battle", 0.4f);
							if (30306 - 361191 != -330885)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (48827 - 499978 != -451151)
							{
								continue;
							}
						}
					}
				}
			}
			IL_684:
			this.Esbnel7rL0 += mTime;
		}
		while (79212 - 149763 != -70551);
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00095070 File Offset: 0x00093270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (46933 - 364745 != -317811)
		{
		}
		while (Time.time - this.zD9nQ0LwuH > this.Esbnel7rL0)
		{
			if (43992 - 247148 == -203156)
			{
				this.AI_state = "none";
				if (35134 - 245601 != -210466)
				{
					this.zD9nQ0LwuH = Time.time;
					if (45817 - 531770 == -485953)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00095124 File Offset: 0x00093324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (203977 - 480598 != -276620)
		{
		}
		for (;;)
		{
			IL_438:
			if (this.MB4nIFEFv1 + (float)1 > Time.time)
			{
				if (135833 - 390884 != -255050)
				{
					break;
				}
			}
			else
			{
				if (this.QLtnc0aYZ5.isTimeOut("battle") != (float)0)
				{
					break;
				}
				if (41257 - 62505 != -21247)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position + (float)6 * this.transform.forward, (float)7, this.gameObject.layer);
					if (46160 - 381692 == -335532)
					{
						if (101300 - 261760 == -160460)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (249173 - 19662 != 229512)
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
									if (97848 - 304326 == -206477)
									{
										goto IL_438;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (104095 - 563847 != -459752)
									{
										goto IL_438;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (209615 - 275660 != -66045)
									{
										goto IL_438;
									}
									bool flag = true;
									if (58740 - 281352 == -222611)
									{
										goto IL_438;
									}
									eRace race = this.QLtnc0aYZ5.Race;
									if (88639 - 315434 != -226795)
									{
										goto IL_438;
									}
									if (race == eRace.Tails)
									{
										if (108998 - 23838 != 85160)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_40;
										}
										if (51762 - 240256 == -188493)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (251208 - 384679 != -133470)
											{
												goto IL_40;
											}
											goto IL_438;
										}
										goto IL_54E;
										IL_40:
										flag = false;
										if (177877 - 401954 != -224077)
										{
											goto IL_438;
										}
									}
									else if (race == eRace.Plants)
									{
										if (293005 - 80084 == 212922)
										{
											goto IL_438;
										}
										flag = false;
										if (198416 - 44450 != 153966)
										{
											goto IL_438;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (278931 - 450062 == -171130)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_19E;
										}
										if (56224 - 556882 == -500657)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (244866 - 105074 != 139793)
											{
												goto IL_19E;
											}
											goto IL_438;
										}
										goto IL_54E;
										IL_19E:
										flag = false;
										if (272521 - 392528 == -120006)
										{
											goto IL_438;
										}
									}
									else if (race == eRace.Robots)
									{
										if (98698 - 498624 == -399925)
										{
											goto IL_438;
										}
										flag = true;
										if (160624 - 47957 != 112667)
										{
											goto IL_438;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (129809 - 258585 == -128775)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_182;
										}
										if (299559 - 438968 != -139409)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_182;
										}
										if (51424 - 102727 == -51302)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (253493 - 594001 != -340508)
											{
												goto IL_438;
											}
											goto IL_182;
										}
										goto IL_54E;
										IL_182:
										flag = false;
										if (4169 - 222119 == -217949)
										{
											goto IL_438;
										}
									}
									else if (race == eRace.Structure)
									{
										if (74494 - 173724 == -99229)
										{
											goto IL_438;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (281164 - 211505 == 69660)
											{
												goto IL_438;
											}
											flag = false;
											if (236220 - 182466 != 53754)
											{
												goto IL_438;
											}
										}
									}
									IL_54E:
									if (flag)
									{
										if (178241 - 468978 != -290737)
										{
											goto IL_438;
										}
										if (characterControl.hp > 0)
										{
											if (229976 - 353861 == -123884)
											{
												goto IL_438;
											}
											if (characterControl.recieveTarget)
											{
												if (19393 - 104597 != -85204)
												{
													goto IL_438;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (77144 - 123078 == -45933)
													{
														goto IL_438;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (31812 - 583213 == -551400)
														{
															goto IL_438;
														}
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position - (float)6 * this.transform.forward);
														if (96180 - 238459 != -142279)
														{
															goto IL_438;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (214145 - 267580 == -53434)
														{
															goto IL_438;
														}
														if (num < (float)90)
														{
															if (195418 - 577361 != -381943)
															{
																goto IL_438;
															}
															if (characterControl.hp > 0)
															{
																if (153212 - 100587 != 52625)
																{
																	goto IL_438;
																}
																this.QLtnc0aYZ5.isAlert = true;
																if (240359 - 379804 == -139444)
																{
																	goto IL_438;
																}
																this.zD9nQ0LwuH = Time.time;
																if (216268 - 408854 != -192586)
																{
																	goto IL_438;
																}
																this.QLtnc0aYZ5.myAttackTarget = gameObject;
																if (13892 - 488145 == -474252)
																{
																	goto IL_438;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (204226 - 267720 != -63494)
																{
																	goto IL_438;
																}
																this.QLtnc0aYZ5.addHate(characterControl.ActorNr, 5);
																if (103848 - 509990 != -406142)
																{
																	goto IL_438;
																}
															}
														}
													}
												}
											}
										}
									}
								}
								if (51043 - 306232 != -255188)
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

	// Token: 0x06000590 RID: 1424 RVA: 0x00095860 File Offset: 0x00093A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00095864 File Offset: 0x00093A64
	internal static bool qweZgxUNyas2nfZFg4U()
	{
		return true;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00095868 File Offset: 0x00093A68
	internal static bool i79eINUY3R7t0oahKF1()
	{
		return false;
	}

	// Token: 0x04000539 RID: 1337
	private CharacterControl QLtnc0aYZ5;

	// Token: 0x0400053A RID: 1338
	private MokBug JsCnnOFent;

	// Token: 0x0400053B RID: 1339
	public string AI_state;

	// Token: 0x0400053C RID: 1340
	private float zD9nQ0LwuH;

	// Token: 0x0400053D RID: 1341
	private float Esbnel7rL0;

	// Token: 0x0400053E RID: 1342
	private float MB4nIFEFv1;
}
