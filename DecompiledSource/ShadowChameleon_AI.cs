using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003A4 RID: 932
[Serializable]
public class ShadowChameleon_AI : MonoBehaviour
{
	// Token: 0x06001577 RID: 5495 RVA: 0x0022459C File Offset: 0x0022279C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowChameleon_AI()
	{
		if (235533 - 40253 != 195280)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (114014 - 151985 != -37970)
			{
				base..ctor();
				if (153766 - 422229 != -268462)
				{
					this.AI_state = "none";
					if (114170 - 200255 != -86084)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00224638 File Offset: 0x00222838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.M8iXY0EeXp = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.BiDX3FHtAs = (Chameleon)this.GetComponent(typeof(Chameleon));
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00224670 File Offset: 0x00222870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (71207 - 124668 != -53460)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (165807 - 399588 == -233780)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (45429 - 155777 == -110347)
				{
					continue;
				}
			}
			if (this.M8iXY0EeXp.isControlled)
			{
				break;
			}
			if (29893 - 66218 != -36324)
			{
				this.AIControl();
				if (136240 - 295850 == -159610)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0022473C File Offset: 0x0022293C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.doIXgJAtd0 = nSummoner;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00224748 File Offset: 0x00222948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (56895 - 1709 != 55186)
		{
		}
		for (;;)
		{
			this.a0lXdwSQD7 = (float)0;
			if (177832 - 450968 == -273136)
			{
				if (this.M8iXY0EeXp.isMine)
				{
					if (100486 - 458868 != -358381)
					{
						if (this.M8iXY0EeXp.actionState != "standby")
						{
							if (94371 - 584849 == -490477)
							{
								continue;
							}
							if (this.M8iXY0EeXp.actionState != "run")
							{
								if (280465 - 301548 != -21082)
								{
									break;
								}
								continue;
							}
						}
						if (this.doIXgJAtd0)
						{
							if (116221 - 97418 != 18804)
							{
								if (!this.M8iXY0EeXp.isAlert)
								{
									if (40567 - 96547 == -55980)
									{
										Vector3 vector = this.doIXgJAtd0.transform.position - this.transform.position;
										if (273576 - 139336 == 134240)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (201183 - 521395 != -320212)
												{
													continue;
												}
												this.AI_follow(this.doIXgJAtd0);
												if (275787 - 100893 == 174895)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (111573 - 2955 == 108619)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (112484 - 403607 == -291122)
												{
													continue;
												}
												this.AI_resetTimer();
												if (2281 - 440212 != -437931)
												{
													continue;
												}
												this.AI_visionCheck();
												if (41019 - 416198 != -375179)
												{
													continue;
												}
											}
											if (!this.M8iXY0EeXp.myAttackTarget)
											{
												break;
											}
											if (43152 - 7281 == 35871)
											{
												this.M8iXY0EeXp.isAlert = true;
												if (212243 - 17039 != 195205)
												{
													this.nspXbTxaJU = Time.time;
													if (51144 - 272530 == -221386)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									Vector3 vector2 = this.doIXgJAtd0.transform.position - this.transform.position;
									if (290143 - 585240 != -295096)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (3513 - 156873 == -153360)
											{
												this.M8iXY0EeXp.isAlert = false;
												if (133086 - 321438 != -188351)
												{
													this.AI_resetTimer();
													if (148751 - 311338 == -162587)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (272561 - 562190 != -289628)
											{
												this.AI_patrol(3f, 1f);
												if (188509 - 540830 == -352321)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (7338 - 156615 == -149277)
													{
														this.AI_resetTimer();
														if (94475 - 184995 == -90520)
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
						else if (!this.M8iXY0EeXp.isAlert)
						{
							if (98523 - 580755 == -482232)
							{
								this.AI_idle(3f, 1f);
								if (1635 - 454208 == -452573)
								{
									this.AI_patrol(1f, 0.25f);
									if (136228 - 224511 != -88282)
									{
										this.AI_resetTimer();
										if (15229 - 312075 == -296846)
										{
											this.AI_visionCheck();
											if (135739 - 319292 == -183553)
											{
												if (!this.M8iXY0EeXp.myAttackTarget)
												{
													break;
												}
												if (61142 - 529440 != -468297)
												{
													this.M8iXY0EeXp.isAlert = true;
													if (281099 - 444237 == -163138)
													{
														this.nspXbTxaJU = Time.time;
														if (6878 - 46775 != -39896)
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
							if (65184 - 467462 == -402278)
							{
								this.AI_patrol(3f, 1f);
								if (270274 - 110118 != 160157)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (262579 - 51391 != 211189)
									{
										this.AI_resetTimer();
										if (231884 - 409465 == -177581)
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
					if (this.M8iXY0EeXp.actionState != "standby")
					{
						if (20904 - 102182 != -81278)
						{
							continue;
						}
						if (this.M8iXY0EeXp.actionState != "run")
						{
							if (111483 - 586253 != -474769)
							{
								break;
							}
							continue;
						}
					}
					float num = this.M8iXY0EeXp.moveSpeed;
					if (268262 - 425039 != -156776)
					{
						float runSpeed = this.M8iXY0EeXp.runSpeed;
						if (273212 - 214204 != 59009)
						{
							Vector3 vector3 = default(Vector3);
							if (15822 - 463055 != -447232)
							{
								Vector3 vector4 = Vector3.zero;
								if (196083 - 409122 == -213039)
								{
									if ((this.M8iXY0EeXp.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (204201 - 341237 != -137036)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.M8iXY0EeXp.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (19968 - 441574 == -421605)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (271061 - 393286 != -122225)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (165710 - 60715 == 104996)
											{
												continue;
											}
											num = (float)0;
											if (148434 - 418330 != -269896)
											{
												continue;
											}
											this.transform.position = this.M8iXY0EeXp.nPosition;
											if (98794 - 287628 != -188834)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (224766 - 311001 == -86234)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (165308 - 213655 == -48346)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (83691 - 175890 == -92198)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (235166 - 512517 == -277350)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (71695 - 345848 != -274153)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (54489 - 231713 == -177223)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (84457 - 368426 != -283969)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (112742 - 434401 == -321658)
											{
												continue;
											}
										}
									}
									this.M8iXY0EeXp.vMovement = vector4;
									if (35000 - 498106 == -463106)
									{
										this.M8iXY0EeXp.moveSpeed = num;
										if (117300 - 321183 == -203883)
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

	// Token: 0x0600157C RID: 5500 RVA: 0x00225114 File Offset: 0x00223314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (292446 - 364076 != -71629)
		{
		}
		do
		{
			if (Time.time - this.nspXbTxaJU >= this.a0lXdwSQD7)
			{
				if (188493 - 127288 == 61206)
				{
					continue;
				}
				if (Time.time - this.nspXbTxaJU < this.a0lXdwSQD7 + mTime)
				{
					if (221949 - 513414 == -291464)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (150013 - 39674 != 110339)
						{
							continue;
						}
						this.AI_state = "idle";
						if (203433 - 124395 != 79038)
						{
							continue;
						}
						this.nspXbTxaJU -= UnityEngine.Random.Range((float)0, rTimer);
						if (8721 - 257032 == -248310)
						{
							continue;
						}
						this.M8iXY0EeXp.vDirection = Vector3.zero;
						if (148345 - 569446 != -421101)
						{
							continue;
						}
						this.M8iXY0EeXp.vMovement = this.transform.forward;
						if (292330 - 117299 != 175031)
						{
							continue;
						}
						this.M8iXY0EeXp.actionState = "standby";
						if (21131 - 172883 == -151751)
						{
							continue;
						}
					}
					this.M8iXY0EeXp.moveSpeed = Mathf.Lerp(this.M8iXY0EeXp.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (241686 - 369447 == -127760)
					{
						continue;
					}
					if (this.M8iXY0EeXp.moveSpeed < 0.1f * this.M8iXY0EeXp.runSpeed)
					{
						if (92548 - 252391 != -159843)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (80726 - 468342 != -387616)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44136 - 283685 != -239549)
						{
							continue;
						}
						this.M8iXY0EeXp.moveSpeed = (float)0;
						if (118695 - 31093 == 87603)
						{
							continue;
						}
					}
				}
			}
			this.a0lXdwSQD7 += mTime;
		}
		while (14711 - 80769 == -66057);
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x002253D8 File Offset: 0x002235D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (254041 - 312354 != -58312)
		{
		}
		do
		{
			if (Time.time - this.nspXbTxaJU >= this.a0lXdwSQD7)
			{
				if (9843 - 338664 == -328820)
				{
					continue;
				}
				if (Time.time - this.nspXbTxaJU < this.a0lXdwSQD7 + mTime)
				{
					if (263491 - 515569 == -252077)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (3936 - 89368 != -85432)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (50747 - 580504 == -529756)
						{
							continue;
						}
						this.nspXbTxaJU -= UnityEngine.Random.Range((float)0, rTimer);
						if (162691 - 488956 != -326265)
						{
							continue;
						}
						this.M8iXY0EeXp.vDirection = this.M8iXY0EeXp.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (131418 - 221759 == -90340)
						{
							continue;
						}
						this.M8iXY0EeXp.vDirection.y = this.transform.position.y;
						if (5253 - 196355 == -191101)
						{
							continue;
						}
						this.M8iXY0EeXp.vMovement = (this.M8iXY0EeXp.vDirection - this.transform.position).normalized;
						if (75914 - 358719 != -282805)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.M8iXY0EeXp.vMovement);
						if (97521 - 104244 != -6723)
						{
							continue;
						}
						this.M8iXY0EeXp.actionState = "run";
						if (189149 - 181694 != 7455)
						{
							continue;
						}
						this.animation.Play("run");
						if (14203 - 560970 != -546767)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (102667 - 409887 != -307220)
						{
							continue;
						}
					}
					this.M8iXY0EeXp.moveSpeed = Mathf.Lerp(this.M8iXY0EeXp.moveSpeed, this.M8iXY0EeXp.runSpeed, (float)4 * Time.deltaTime);
					if (75142 - 579422 != -504280)
					{
						continue;
					}
				}
			}
			this.a0lXdwSQD7 += mTime;
		}
		while (269598 - 222113 == 47486);
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x002256E0 File Offset: 0x002238E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (283458 - 31442 != 252016)
		{
		}
		for (;;)
		{
			this.M8iXY0EeXp.vDirection = followObject.transform.position;
			if (11138 - 551610 != -540471)
			{
				this.M8iXY0EeXp.vDirection.y = this.transform.position.y;
				if (144060 - 288867 == -144807)
				{
					this.M8iXY0EeXp.vMovement = (this.M8iXY0EeXp.vDirection - this.transform.position).normalized;
					if (144370 - 267622 != -123251)
					{
						this.transform.rotation = Quaternion.LookRotation(this.M8iXY0EeXp.vMovement);
						if (263015 - 26117 != 236899)
						{
							this.M8iXY0EeXp.actionState = "run";
							if (126921 - 23352 != 103570)
							{
								this.animation.Play("run");
								if (90379 - 196835 != -106455)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (157774 - 125373 == 32401)
									{
										this.M8iXY0EeXp.moveSpeed = Mathf.Lerp(this.M8iXY0EeXp.moveSpeed, this.M8iXY0EeXp.runSpeed, (float)4 * Time.deltaTime);
										if (58858 - 393089 == -334231)
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

	// Token: 0x0600157F RID: 5503 RVA: 0x002258C8 File Offset: 0x00223AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (153678 - 329459 != -175780)
		{
		}
		do
		{
			if (Time.time - this.nspXbTxaJU >= this.a0lXdwSQD7)
			{
				if (25705 - 329700 != -303995)
				{
					continue;
				}
				if (Time.time - this.nspXbTxaJU < this.a0lXdwSQD7 + mTime)
				{
					if (228217 - 399389 != -171172)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (198631 - 369264 == -170632)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (86616 - 68610 == 18007)
						{
							continue;
						}
						this.nspXbTxaJU = Time.time - mTime - this.a0lXdwSQD7;
						if (118213 - 229969 != -111756)
						{
							continue;
						}
						this.M8iXY0EeXp.vDirection = Vector3.zero;
						if (127737 - 21788 == 105950)
						{
							continue;
						}
						this.M8iXY0EeXp.vMovement = this.transform.forward;
						if (111390 - 130576 != -19186)
						{
							continue;
						}
						this.M8iXY0EeXp.actionState = "standby";
						if (127162 - 223456 == -96293)
						{
							continue;
						}
						this.M8iXY0EeXp.myAttackTarget = this.M8iXY0EeXp.getHateTarget(5, 50);
						if (221600 - 471391 != -249791)
						{
							continue;
						}
						if (!this.M8iXY0EeXp.myAttackTarget)
						{
							if (131174 - 57771 == 73404)
							{
								continue;
							}
							this.M8iXY0EeXp.isAlert = false;
							if (225111 - 497745 != -272634)
							{
								continue;
							}
							this.nspXbTxaJU = Time.time;
							if (222724 - 443612 != -220888)
							{
								continue;
							}
							this.M8iXY0EeXp.myAttackTarget = null;
							if (175765 - 194720 != -18955)
							{
								continue;
							}
							this.M8iXY0EeXp.mOriginalPosition = this.transform.position;
							if (107890 - 106978 != 912)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.M8iXY0EeXp.myAttackTarget;
							if (7959 - 496644 != -488685)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (258253 - 334229 != -75976)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (182489 - 163073 == 19417)
								{
									continue;
								}
								this.M8iXY0EeXp.isAlert = false;
								if (283977 - 382593 == -98615)
								{
									continue;
								}
								this.nspXbTxaJU = Time.time;
								if (290212 - 359542 == -69329)
								{
									continue;
								}
								this.M8iXY0EeXp.myAttackTarget = null;
								if (99640 - 332467 != -232827)
								{
									continue;
								}
							}
							else
							{
								this.M8iXY0EeXp.vDirection = myAttackTarget.transform.position;
								if (156727 - 542568 == -385840)
								{
									continue;
								}
								this.M8iXY0EeXp.vDirection.y = this.transform.position.y;
								if (122724 - 2750 != 119974)
								{
									continue;
								}
								this.M8iXY0EeXp.vMovement = (this.M8iXY0EeXp.vDirection - this.transform.position).normalized;
								if (243056 - 250300 == -7243)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.M8iXY0EeXp.vMovement);
								if (48291 - 379869 == -331577)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.a0lXdwSQD7 += mTime;
		}
		while (76519 - 457762 != -381243);
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00225D78 File Offset: 0x00223F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowChameleon_AI.$AI_attack$18942(mTime, this).GetEnumerator();
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x00225D88 File Offset: 0x00223F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (112445 - 268315 != -155869)
		{
		}
		while (Time.time - this.nspXbTxaJU > this.a0lXdwSQD7)
		{
			if (166788 - 186523 != -19734)
			{
				this.AI_state = "none";
				if (167985 - 364092 == -196107)
				{
					this.nspXbTxaJU = Time.time;
					if (204731 - 546080 != -341348)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00225E3C File Offset: 0x0022403C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (134947 - 39791 != 95156)
		{
		}
		for (;;)
		{
			IL_1E1:
			if (this.kuhXaoyyR3 + (float)1 > Time.time)
			{
				if (76959 - 31057 == 45902)
				{
					break;
				}
			}
			else
			{
				this.kuhXaoyyR3 = Time.time;
				if (83950 - 239281 == -155331)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (62057 - 246703 != -184645)
					{
						if (169464 - 2678 == 166786)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (21201 - 230788 != -209586)
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
									if (27347 - 432202 == -404854)
									{
										goto IL_1E1;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (153532 - 85511 == 68022)
									{
										goto IL_1E1;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (78083 - 516359 != -438276)
									{
										goto IL_1E1;
									}
									bool flag = true;
									if (149264 - 115366 == 33899)
									{
										goto IL_1E1;
									}
									eRace race = this.M8iXY0EeXp.Race;
									if (130310 - 546657 == -416346)
									{
										goto IL_1E1;
									}
									if (race == eRace.Tails)
									{
										if (29523 - 527760 == -498236)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2A2;
										}
										if (35974 - 325859 != -289885)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (90788 - 468692 != -377903)
											{
												goto IL_2A2;
											}
											goto IL_1E1;
										}
										goto IL_25C;
										IL_2A2:
										flag = false;
										if (220351 - 135067 == 85285)
										{
											goto IL_1E1;
										}
									}
									else if (race == eRace.Plants)
									{
										if (230355 - 137941 == 92415)
										{
											goto IL_1E1;
										}
										flag = false;
										if (92939 - 12989 == 79951)
										{
											goto IL_1E1;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (11573 - 113698 != -102125)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_34D;
										}
										if (139735 - 298809 == -159073)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (51976 - 427876 != -375899)
											{
												goto IL_34D;
											}
											goto IL_1E1;
										}
										goto IL_25C;
										IL_34D:
										flag = false;
										if (221193 - 156053 == 65141)
										{
											goto IL_1E1;
										}
									}
									else if (race == eRace.Robots)
									{
										if (258246 - 231582 != 26664)
										{
											goto IL_1E1;
										}
										flag = true;
										if (30854 - 115861 != -85007)
										{
											goto IL_1E1;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (236457 - 262899 == -26441)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5B4;
										}
										if (253141 - 96477 == 156665)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5B4;
										}
										if (268313 - 76921 == 191393)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (267429 - 416518 != -149088)
											{
												goto IL_5B4;
											}
											goto IL_1E1;
										}
										goto IL_25C;
										IL_5B4:
										flag = false;
										if (120117 - 89002 == 31116)
										{
											goto IL_1E1;
										}
									}
									else if (race == eRace.Structure)
									{
										if (178616 - 598834 == -420217)
										{
											goto IL_1E1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (182418 - 206665 == -24246)
											{
												goto IL_1E1;
											}
											flag = false;
											if (288124 - 76064 != 212060)
											{
												goto IL_1E1;
											}
										}
									}
									IL_25C:
									if (flag)
									{
										if (169334 - 320040 == -150705)
										{
											goto IL_1E1;
										}
										if (characterControl.hp > 0)
										{
											if (264381 - 333990 == -69608)
											{
												goto IL_1E1;
											}
											if (characterControl.recieveTarget)
											{
												if (51477 - 45621 == 5857)
												{
													goto IL_1E1;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (133076 - 115334 != 17742)
													{
														goto IL_1E1;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (2880 - 9931 != -7051)
														{
															goto IL_1E1;
														}
														this.M8iXY0EeXp.isAlert = true;
														if (180634 - 116534 != 64100)
														{
															goto IL_1E1;
														}
														this.nspXbTxaJU = Time.time;
														if (69598 - 304456 != -234858)
														{
															goto IL_1E1;
														}
														this.M8iXY0EeXp.myAttackTarget = gameObject;
														if (142352 - 219486 == -77133)
														{
															goto IL_1E1;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (62950 - 315688 != -252738)
														{
															goto IL_1E1;
														}
														this.M8iXY0EeXp.addHate(characterControl.ActorNr, 5);
														if (269198 - 258495 != 10703)
														{
															goto IL_1E1;
														}
													}
												}
											}
										}
									}
								}
								if (243119 - 340140 != -97020)
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

	// Token: 0x06001583 RID: 5507 RVA: 0x0022648C File Offset: 0x0022468C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00226490 File Offset: 0x00224690
	internal static bool l4LA6SFVcZsruV0YviW()
	{
		return true;
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x00226494 File Offset: 0x00224694
	internal static bool f5JcLoFtTeC7qd9o88L()
	{
		return false;
	}

	// Token: 0x04001290 RID: 4752
	private CharacterControl M8iXY0EeXp;

	// Token: 0x04001291 RID: 4753
	private Chameleon BiDX3FHtAs;

	// Token: 0x04001292 RID: 4754
	public string AI_state;

	// Token: 0x04001293 RID: 4755
	private float nspXbTxaJU;

	// Token: 0x04001294 RID: 4756
	private float a0lXdwSQD7;

	// Token: 0x04001295 RID: 4757
	private GameObject doIXgJAtd0;

	// Token: 0x04001296 RID: 4758
	private float kuhXaoyyR3;

	// Token: 0x020003A5 RID: 933
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18942 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001586 RID: 5510 RVA: 0x00226498 File Offset: 0x00224698
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18942(float mTime, ShadowChameleon_AI self_)
		{
			if (292844 - 341676 != -48831)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6079 - 514414 == -508335)
				{
					base..ctor();
					if (110102 - 507338 != -397235)
					{
						this.$mTime$18951 = mTime;
						if (8675 - 587709 == -579034)
						{
							this.$self_$18952 = self_;
							if (92972 - 265478 == -172506)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00226554 File Offset: 0x00224754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowChameleon_AI.$AI_attack$18942.$(this.$mTime$18951, this.$self_$18952);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00226568 File Offset: 0x00224768
		internal static bool fac3LrFNQaAb7R5DmZ0()
		{
			return true;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0022656C File Offset: 0x0022476C
		internal static bool VR53I9FYHdpkABDDLwn()
		{
			return false;
		}

		// Token: 0x04001297 RID: 4759
		internal float $mTime$18951;

		// Token: 0x04001298 RID: 4760
		internal ShadowChameleon_AI $self_$18952;

		// Token: 0x020003A6 RID: 934
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600158A RID: 5514 RVA: 0x00226570 File Offset: 0x00224770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowChameleon_AI self_)
			{
				if (114305 - 547376 != -433071)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249438 - 540792 == -291354)
					{
						base..ctor();
						if (278667 - 555277 != -276609)
						{
							this.$mTime$18949 = mTime;
							if (214207 - 12190 == 202017)
							{
								this.$self_$18950 = self_;
								if (128820 - 320319 == -191499)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600158B RID: 5515 RVA: 0x0022662C File Offset: 0x0022482C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96178 - 200127 != -103949)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_10B2;
					case 1:
						goto IL_20ED;
					case 2:
						if (this.$self_$18950.M8iXY0EeXp.actionState != "standby")
						{
							goto IL_16D7;
						}
						if (145314 - 20648 == 124667)
						{
							continue;
						}
						if (this.$self_$18950.M8iXY0EeXp.actionState != "attack")
						{
							if (289103 - 321099 != -31996)
							{
								continue;
							}
							goto IL_16D7;
						}
						else
						{
							this.$i$18948++;
							if (41637 - 169293 != -127656)
							{
								continue;
							}
						}
						break;
					default:
						if (160776 - 183436 != -22660)
						{
							continue;
						}
						goto IL_10B2;
					}
					IL_4FF:
					if (this.$i$18948 >= 3)
					{
						if (220819 - 379039 != -158220)
						{
							continue;
						}
						goto IL_3EB;
					}
					else
					{
						this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_nAttack1(this.$self_$18950.transform.position, this.$tObject$18943.collider.bounds.center - this.$self_$18950.transform.position, this.$tID$18946));
						if (289327 - 519643 != -230316)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (2926 - 488034 == -485107)
						{
							continue;
						}
						this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_nAttack1", this.$self_$18950.transform.position, this.$tObject$18943.collider.bounds.center - this.$self_$18950.transform.position, this.$tID$18946);
						if (192746 - 220817 != -28071)
						{
							continue;
						}
						break;
					}
					IL_10B2:
					if (Time.time - this.$self_$18950.nspXbTxaJU >= this.$self_$18950.a0lXdwSQD7)
					{
						if (218594 - 381058 == -162463)
						{
							continue;
						}
						if (Time.time - this.$self_$18950.nspXbTxaJU < this.$self_$18950.a0lXdwSQD7 + this.$mTime$18949)
						{
							if (130377 - 344997 != -214620)
							{
								continue;
							}
							if (!this.$self_$18950.M8iXY0EeXp.myAttackTarget)
							{
								if (117381 - 1020 != 116361)
								{
									continue;
								}
								this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
								if (246761 - 535219 != -288457)
								{
									goto Block_114;
								}
								continue;
							}
							else
							{
								this.$tObject$18943 = this.$self_$18950.M8iXY0EeXp.myAttackTarget;
								if (256995 - 314451 != -57456)
								{
									continue;
								}
								this.$tChar$18944 = (CharacterControl)this.$tObject$18943.GetComponent(typeof(CharacterControl));
								if (292955 - 185391 != 107564)
								{
									continue;
								}
								this.$tDir$18945 = global::Math.vFlat(this.$tObject$18943.transform.position - this.$self_$18950.transform.position);
								if (77848 - 195852 != -118004)
								{
									continue;
								}
								this.$tID$18946 = 0;
								if (211345 - 315734 != -104389)
								{
									continue;
								}
								if (this.$tChar$18944)
								{
									if (152855 - 599538 == -446682)
									{
										continue;
									}
									this.$tID$18946 = this.$tChar$18944.ActorNr;
									if (245316 - 104879 != 140437)
									{
										continue;
									}
								}
								this.$distance$18947 = this.$tDir$18945.magnitude - this.$tObject$18943.collider.bounds.extents.x;
								if (44424 - 165652 != -121228)
								{
									continue;
								}
								if (this.$distance$18947 < (float)18)
								{
									if (56668 - 192105 != -135437)
									{
										continue;
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 65)
									{
										if (93754 - 437104 == -343349)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(272))
										{
											if (193176 - 567832 == -374655)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("finalEntrapment") == (float)0)
											{
												if (29007 - 292557 != -263550)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (70109 - 87602 != -17493)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_cast1("finalEntrapment", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
												if (189738 - 14116 != 175622)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (115222 - 328033 == -212810)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_finalEntrapment2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
													if (223376 - 177277 != 46099)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 60)
									{
										if (22154 - 168679 == -146524)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(372))
										{
											if (176241 - 439926 == -263684)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("allSlain") == (float)0)
											{
												if (81258 - 577749 == -496490)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (205575 - 194576 != 10999)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_allSlain(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
												if (148769 - 424669 != -275900)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (173727 - 267678 != -93951)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_allSlain2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
													if (282572 - 370954 == -88381)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 55)
									{
										if (275974 - 68535 == 207440)
										{
											continue;
										}
										if (this.$tChar$18944.getStatusLv("poison") >= 4)
										{
											if (71343 - 102247 != -30904)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.hasSkill(254))
											{
												if (116661 - 199562 != -82901)
												{
													continue;
												}
												if (this.$self_$18950.M8iXY0EeXp.isTimeOut("venomShock") == (float)0)
												{
													if (108015 - 202006 == -93990)
													{
														continue;
													}
													this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
													if (214538 - 319668 == -105129)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_venomShock(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
													if (201404 - 318801 != -117396)
													{
														if (PhotonClient.IsInitialized())
														{
															if (192263 - 534997 == -342733)
															{
																continue;
															}
															this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_venomShock2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
															if (166397 - 407141 == -240743)
															{
																continue;
															}
														}
														goto IL_3EB;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 40)
									{
										if (275912 - 355318 == -79405)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(362))
										{
											if (272068 - 329057 != -56989)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("allSlayer") == (float)0)
											{
												if (139486 - 480242 != -340756)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (71202 - 264746 == -193543)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_allSlayer(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
												if (23193 - 143938 != -120745)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (9730 - 179327 != -169597)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_allSlayer2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
													if (17687 - 250192 == -232504)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 45)
									{
										if (615 - 414549 == -413933)
										{
											continue;
										}
										if (this.$distance$18947 < (float)5)
										{
											if (254327 - 549219 == -294891)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.hasSkill(252))
											{
												if (259438 - 113052 != 146386)
												{
													continue;
												}
												if (this.$self_$18950.M8iXY0EeXp.isTimeOut("poisonVolley") == (float)0)
												{
													if (43914 - 527651 == -483736)
													{
														continue;
													}
													this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
													if (73581 - 487616 == -414034)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_poisonVolley(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
													if (65357 - 209413 != -144055)
													{
														if (PhotonClient.IsInitialized())
														{
															if (173173 - 334784 != -161611)
															{
																continue;
															}
															this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_poisonVolley2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
															if (43573 - 310472 == -266898)
															{
																continue;
															}
														}
														goto IL_3EB;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 40)
									{
										if (226217 - 345798 != -119581)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(342))
										{
											if (259507 - 194782 != 64725)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("slayer") == (float)0)
											{
												if (109169 - 38898 != 70271)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (33721 - 5961 != 27760)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_slayer(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
												if (21993 - 138825 != -116832)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (230319 - 568270 == -337950)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_slayer2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
													if (128998 - 586808 == -457809)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 35)
									{
										if (130180 - 379370 != -249190)
										{
											continue;
										}
										if (this.$distance$18947 < (float)4)
										{
											if (80059 - 360585 != -280526)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.hasSkill(224))
											{
												if (256927 - 48933 != 207994)
												{
													continue;
												}
												if (this.$self_$18950.M8iXY0EeXp.isTimeOut("massShot") == (float)0)
												{
													if (5852 - 101512 == -95659)
													{
														continue;
													}
													this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
													if (15449 - 592328 == -576878)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_massShot(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
													if (209044 - 467495 != -258451)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (16887 - 412336 != -395449)
														{
															continue;
														}
														this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_massShot2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
														if (193313 - 533096 != -339783)
														{
															continue;
														}
													}
													goto IL_3EB;
												}
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 30)
									{
										if (27148 - 65652 == -38503)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(324))
										{
											if (274762 - 397102 == -122339)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("rightStride") == (float)0)
											{
												if (61591 - 251260 != -189669)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (137401 - 128643 != 8758)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_rightStride(this.$self_$18950.transform.position, this.$tDir$18945, this.$tID$18946, 2));
												if (205253 - 92039 != 113214)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (265457 - 298618 == -33160)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_rightStride2", this.$self_$18950.transform.position, this.$tDir$18945, this.$tID$18946);
													if (141564 - 402116 == -260551)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 25)
									{
										if (125785 - 282596 != -156811)
										{
											continue;
										}
										if (!this.$tChar$18944.hasStatus("needlePrison"))
										{
											if (257149 - 6579 == 250571)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.hasSkill(223))
											{
												if (108466 - 599656 != -491190)
												{
													continue;
												}
												if (this.$self_$18950.M8iXY0EeXp.isTimeOut("needlePrison") == (float)0)
												{
													if (184908 - 431076 != -246168)
													{
														continue;
													}
													this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
													if (96550 - 301452 != -204902)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_needlePrison(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 2));
													if (202839 - 525486 != -322646)
													{
														if (PhotonClient.IsInitialized())
														{
															if (162486 - 340338 != -177852)
															{
																continue;
															}
															this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_needlePrison2", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
															if (262959 - 203464 != 59495)
															{
																continue;
															}
														}
														goto IL_3EB;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 20)
									{
										if (270268 - 87030 == 183239)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(323))
										{
											if (10801 - 547976 == -537174)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("leftStride") == (float)0)
											{
												if (55067 - 362682 != -307615)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (216056 - 288889 == -72832)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_leftStride(this.$self_$18950.transform.position, this.$tDir$18945, this.$tID$18946, 2));
												if (273868 - 379397 != -105528)
												{
													if (PhotonClient.IsInitialized())
													{
														if (251160 - 387425 != -136265)
														{
															continue;
														}
														this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_leftStride2", this.$self_$18950.transform.position, this.$tDir$18945, this.$tID$18946);
														if (159271 - 466305 == -307033)
														{
															continue;
														}
													}
													goto IL_3EB;
												}
												continue;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 15)
									{
										if (126759 - 377267 == -250507)
										{
											continue;
										}
										if (!this.$self_$18950.M8iXY0EeXp.hasStatus("invisible"))
										{
											if (73957 - 11509 != 62448)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.hasSkill(214))
											{
												if (139122 - 401658 == -262535)
												{
													continue;
												}
												if (this.$self_$18950.M8iXY0EeXp.isTimeOut("trueInvisibility") == (float)0)
												{
													if (140394 - 448611 != -308217)
													{
														continue;
													}
													this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
													if (280378 - 575028 != -294650)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_cast1("trueInvisibility", this.$self_$18950.transform.position, this.$self_$18950.transform.forward, this.$self_$18950.M8iXY0EeXp.ActorNr, 2));
													if (178814 - 288220 != -109405)
													{
														if (PhotonClient.IsInitialized())
														{
															if (102586 - 289746 == -187159)
															{
																continue;
															}
															this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_trueInvisibility2", this.$self_$18950.transform.position, this.$self_$18950.transform.forward, this.$self_$18950.M8iXY0EeXp.ActorNr);
															if (191270 - 389351 != -198081)
															{
																continue;
															}
														}
														goto IL_3EB;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 10)
									{
										if (53463 - 121804 != -68341)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(304))
										{
											if (13042 - 523926 == -510883)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("fatalStrike") == (float)0)
											{
												if (294081 - 581585 == -287503)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (31109 - 284385 == -253275)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_fatalStrike(this.$self_$18950.transform.position, this.$self_$18950.transform.forward, this.$self_$18950.M8iXY0EeXp.ActorNr, 4));
												if (290002 - 420083 != -130081)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (205110 - 540171 == -335060)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_fatalStrike4", this.$self_$18950.transform.position, this.$self_$18950.transform.forward, this.$self_$18950.M8iXY0EeXp.ActorNr);
													if (255229 - 183638 != 71591)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.sp > 5)
									{
										if (81510 - 450187 == -368676)
										{
											continue;
										}
										if (this.$self_$18950.M8iXY0EeXp.hasSkill(204))
										{
											if (196103 - 339777 == -143673)
											{
												continue;
											}
											if (this.$self_$18950.M8iXY0EeXp.isTimeOut("quickFire") == (float)0)
											{
												if (264979 - 598120 != -333141)
												{
													continue;
												}
												this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
												if (179507 - 355339 != -175832)
												{
													continue;
												}
												this.$self_$18950.BiDX3FHtAs.StartCoroutine_Auto(this.$self_$18950.BiDX3FHtAs.RPC_quickFire(this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946, 4));
												if (30672 - 553465 != -522793)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (202540 - 492374 != -289834)
													{
														continue;
													}
													this.$self_$18950.BiDX3FHtAs.ActionEvent("RPC_quickFire4", this.$self_$18950.transform.position, this.$tDir$18945.normalized, this.$tID$18946);
													if (42175 - 81289 == -39113)
													{
														continue;
													}
												}
												goto IL_3EB;
											}
										}
									}
									if (this.$self_$18950.M8iXY0EeXp.isTimeOut("nAttack") == (float)0)
									{
										if (271220 - 109893 == 161328)
										{
											continue;
										}
										this.$self_$18950.nspXbTxaJU = Time.time - this.$mTime$18949 - this.$self_$18950.a0lXdwSQD7;
										if (114108 - 2640 == 111469)
										{
											continue;
										}
										this.$i$18948 = 0;
										if (120747 - 592121 != -471373)
										{
											goto IL_4FF;
										}
										continue;
									}
									else
									{
										this.$self_$18950.AI_state = "attack";
										if (160679 - 155173 == 5507)
										{
											continue;
										}
										this.$self_$18950.M8iXY0EeXp.vDirection = this.$tObject$18943.transform.position;
										if (106310 - 124590 == -18279)
										{
											continue;
										}
										this.$self_$18950.M8iXY0EeXp.vDirection.y = this.$self_$18950.transform.position.y;
										if (285415 - 51780 != 233635)
										{
											continue;
										}
										this.$self_$18950.M8iXY0EeXp.vMovement = (this.$self_$18950.M8iXY0EeXp.vDirection - this.$self_$18950.transform.position).normalized;
										if (163188 - 22894 == 140295)
										{
											continue;
										}
										this.$self_$18950.transform.rotation = Quaternion.LookRotation(this.$self_$18950.M8iXY0EeXp.vMovement);
										if (141145 - 589851 != -448706)
										{
											continue;
										}
										this.$self_$18950.M8iXY0EeXp.actionState = "standby";
										if (79648 - 422372 != -342724)
										{
											continue;
										}
										this.$self_$18950.animation.CrossFade("root", 0.2f);
										if (189770 - 206294 == -16523)
										{
											continue;
										}
										this.$self_$18950.animation.wrapMode = WrapMode.Loop;
										if (193524 - 289487 == -95962)
										{
											continue;
										}
										this.$self_$18950.M8iXY0EeXp.moveSpeed = Mathf.Lerp(this.$self_$18950.M8iXY0EeXp.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (62524 - 416908 == -354383)
										{
											continue;
										}
									}
								}
								else
								{
									this.$self_$18950.AI_state = "attack";
									if (77241 - 379692 != -302451)
									{
										continue;
									}
									this.$self_$18950.M8iXY0EeXp.vDirection = this.$tObject$18943.transform.position;
									if (257812 - 488678 == -230865)
									{
										continue;
									}
									this.$self_$18950.M8iXY0EeXp.vDirection.y = this.$self_$18950.transform.position.y;
									if (194146 - 284566 == -90419)
									{
										continue;
									}
									this.$self_$18950.M8iXY0EeXp.vMovement = (this.$self_$18950.M8iXY0EeXp.vDirection - this.$self_$18950.transform.position).normalized;
									if (240282 - 19353 != 220929)
									{
										continue;
									}
									this.$self_$18950.transform.rotation = Quaternion.LookRotation(this.$self_$18950.M8iXY0EeXp.vMovement);
									if (117863 - 586853 == -468989)
									{
										continue;
									}
									this.$self_$18950.M8iXY0EeXp.actionState = "run";
									if (204214 - 203060 != 1154)
									{
										continue;
									}
									this.$self_$18950.animation.Play("run");
									if (157823 - 120651 != 37172)
									{
										continue;
									}
									this.$self_$18950.animation.wrapMode = WrapMode.Loop;
									if (6556 - 551639 == -545082)
									{
										continue;
									}
									this.$self_$18950.M8iXY0EeXp.moveSpeed = Mathf.Lerp(this.$self_$18950.M8iXY0EeXp.moveSpeed, this.$self_$18950.M8iXY0EeXp.runSpeed, (float)4 * Time.deltaTime);
									if (283145 - 129393 == 153753)
									{
										continue;
									}
								}
							}
						}
					}
					IL_2080:
					this.$self_$18950.a0lXdwSQD7 = this.$self_$18950.a0lXdwSQD7 + this.$mTime$18949;
					if (158382 - 317072 == -158689)
					{
						continue;
					}
					this.YieldDefault(1);
					if (32322 - 387980 != -355657)
					{
						goto Block_148;
					}
					continue;
					IL_3EB:
					goto IL_2080;
				}
				return this.Yield(2, new WaitForSeconds(0.33f));
				Block_114:
				Block_148:
				IL_16D7:
				IL_20ED:
				return false;
			}

			// Token: 0x0600158C RID: 5516 RVA: 0x00228738 File Offset: 0x00226938
			internal static bool oJNcVPFcXSMRovefU4E()
			{
				return true;
			}

			// Token: 0x0600158D RID: 5517 RVA: 0x0022873C File Offset: 0x0022693C
			internal static bool MO4sQEFUcPDmdMgghXa()
			{
				return false;
			}

			// Token: 0x04001299 RID: 4761
			internal GameObject $tObject$18943;

			// Token: 0x0400129A RID: 4762
			internal CharacterControl $tChar$18944;

			// Token: 0x0400129B RID: 4763
			internal Vector3 $tDir$18945;

			// Token: 0x0400129C RID: 4764
			internal int $tID$18946;

			// Token: 0x0400129D RID: 4765
			internal float $distance$18947;

			// Token: 0x0400129E RID: 4766
			internal int $i$18948;

			// Token: 0x0400129F RID: 4767
			internal float $mTime$18949;

			// Token: 0x040012A0 RID: 4768
			internal ShadowChameleon_AI $self_$18950;
		}
	}
}
