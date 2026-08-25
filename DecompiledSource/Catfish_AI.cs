using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BB6 RID: 2998
[Serializable]
public class Catfish_AI : MonoBehaviour
{
	// Token: 0x060042D3 RID: 17107 RVA: 0x0086C50C File Offset: 0x0086A70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Catfish_AI()
	{
		if (5095 - 491250 != -486155)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (168244 - 155078 == 13166)
			{
				base..ctor();
				if (204944 - 403819 != -198874)
				{
					this.AI_state = "none";
					if (34517 - 390939 == -356422)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060042D4 RID: 17108 RVA: 0x0086C5A8 File Offset: 0x0086A7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.iK1Vj7OtBy = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.jLhVoXvMk4 = (Catfish)this.GetComponent(typeof(Catfish));
	}

	// Token: 0x060042D5 RID: 17109 RVA: 0x0086C5E0 File Offset: 0x0086A7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (293352 - 559324 != -265971)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (293185 - 374525 == -81339)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (24942 - 350202 == -325259)
				{
					continue;
				}
			}
			if (this.iK1Vj7OtBy.isControlled)
			{
				break;
			}
			if (250700 - 318745 != -68044)
			{
				this.AIControl();
				if (17385 - 396640 != -379254)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060042D6 RID: 17110 RVA: 0x0086C6AC File Offset: 0x0086A8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (151599 - 234224 != -82624)
		{
		}
		for (;;)
		{
			this.YB6VFhP2In = (float)0;
			if (117585 - 35728 == 81857)
			{
				if (this.iK1Vj7OtBy.isMine)
				{
					if (127005 - 448069 != -321063)
					{
						if (this.iK1Vj7OtBy.actionState != "standby")
						{
							if (287934 - 365727 == -77792)
							{
								continue;
							}
							if (this.iK1Vj7OtBy.actionState != "run")
							{
								if (78300 - 53456 != 24845)
								{
									break;
								}
								continue;
							}
						}
						if (!this.iK1Vj7OtBy.isAlert)
						{
							if (92877 - 309446 == -216569)
							{
								if (!this.iK1Vj7OtBy.isSummon)
								{
									goto IL_6B2;
								}
								if (129157 - 105969 != 23188)
								{
									continue;
								}
								if (!(this.iK1Vj7OtBy.mSummoner != null))
								{
									goto IL_6B2;
								}
								if (248379 - 26403 != 221976)
								{
									continue;
								}
								Vector3 vector = this.iK1Vj7OtBy.mSummoner.transform.position - this.transform.position;
								if (279176 - 385400 != -106224)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (27627 - 76456 != -48829)
									{
										continue;
									}
									this.AI_follow(this.iK1Vj7OtBy.mSummoner);
									if (262931 - 253382 != 9549)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (213937 - 387750 != -173813)
									{
										continue;
									}
									this.AI_resetTimer();
									if (230632 - 23279 == 207354)
									{
										continue;
									}
									this.AI_visionCheck();
									if (255697 - 254839 == 859)
									{
										continue;
									}
								}
								IL_1F7:
								if (!this.iK1Vj7OtBy.myAttackTarget)
								{
									break;
								}
								if (44170 - 48458 == -4287)
								{
									continue;
								}
								this.iK1Vj7OtBy.isAlert = true;
								if (196503 - 27444 != 169059)
								{
									continue;
								}
								this.TaVVke3xQO = Time.time;
								if (107360 - 325276 != -217915)
								{
									break;
								}
								continue;
								IL_6B2:
								this.AI_idle(3f, 1f);
								if (210085 - 540684 != -330598)
								{
									this.AI_patrol(1f, 0.25f);
									if (189042 - 144906 != 44137)
									{
										this.AI_resetTimer();
										if (13152 - 107089 != -93936)
										{
											this.AI_visionCheck();
											if (41905 - 529173 == -487268)
											{
												goto IL_1F7;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (110700 - 558254 != -447553)
							{
								this.AI_idle(3f, 1f);
								if (136205 - 369109 != -232903)
								{
									this.AI_attack(10f, (float)0);
									if (188918 - 16489 == 172429)
									{
										this.AI_resetTimer();
										if (62524 - 136103 != -73578)
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
					if (this.iK1Vj7OtBy.actionState != "standby")
					{
						if (174782 - 274620 == -99837)
						{
							continue;
						}
						if (this.iK1Vj7OtBy.actionState != "run")
						{
							if (77809 - 584337 != -506528)
							{
								continue;
							}
							break;
						}
					}
					float num = this.iK1Vj7OtBy.moveSpeed;
					if (290539 - 359533 == -68994)
					{
						float runSpeed = this.iK1Vj7OtBy.runSpeed;
						if (106541 - 460484 == -353943)
						{
							Vector3 vector2 = default(Vector3);
							if (57676 - 134394 != -76717)
							{
								Vector3 vector3 = Vector3.zero;
								if (113779 - 553209 != -439429)
								{
									if ((this.iK1Vj7OtBy.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (249170 - 33008 == 216163)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.iK1Vj7OtBy.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (224099 - 252726 != -28627)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (294140 - 370750 != -76610)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (234349 - 457566 == -223216)
											{
												continue;
											}
											num = (float)0;
											if (64696 - 81835 == -17138)
											{
												continue;
											}
											this.transform.position = this.iK1Vj7OtBy.nPosition;
											if (203911 - 114633 == 89279)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (116543 - 460904 == -344360)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (199579 - 195294 != 4285)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (231702 - 65497 != 166205)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (151041 - 314698 != -163657)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (194831 - 141226 == 53606)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (60837 - 360213 != -299376)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (24774 - 281013 != -256239)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (101006 - 229796 == -128789)
											{
												continue;
											}
										}
									}
									this.iK1Vj7OtBy.vMovement = vector3;
									if (92849 - 340297 != -247447)
									{
										this.iK1Vj7OtBy.moveSpeed = num;
										if (96148 - 466665 == -370517)
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

	// Token: 0x060042D7 RID: 17111 RVA: 0x0086CE88 File Offset: 0x0086B088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (293923 - 371131 != -77208)
		{
		}
		do
		{
			if (Time.time - this.TaVVke3xQO >= this.YB6VFhP2In)
			{
				if (99357 - 99496 == -138)
				{
					continue;
				}
				if (Time.time - this.TaVVke3xQO < this.YB6VFhP2In + mTime)
				{
					if (25548 - 16217 == 9332)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (102780 - 101287 != 1493)
						{
							continue;
						}
						this.AI_state = "idle";
						if (137099 - 315059 == -177959)
						{
							continue;
						}
						this.TaVVke3xQO -= UnityEngine.Random.Range((float)0, rTimer);
						if (264020 - 290301 == -26280)
						{
							continue;
						}
						this.iK1Vj7OtBy.vDirection = Vector3.zero;
						if (150473 - 1760 != 148713)
						{
							continue;
						}
						this.iK1Vj7OtBy.vMovement = this.transform.forward;
						if (285144 - 172040 != 113104)
						{
							continue;
						}
						this.iK1Vj7OtBy.actionState = "standby";
						if (163243 - 561214 == -397970)
						{
							continue;
						}
					}
					this.iK1Vj7OtBy.moveSpeed = Mathf.Lerp(this.iK1Vj7OtBy.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (40910 - 453239 != -412329)
					{
						continue;
					}
					if (this.iK1Vj7OtBy.moveSpeed < 0.1f * this.iK1Vj7OtBy.runSpeed)
					{
						if (91938 - 86557 != 5381)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (156177 - 251546 != -95369)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (258304 - 271228 == -12923)
						{
							continue;
						}
						this.iK1Vj7OtBy.moveSpeed = (float)0;
						if (23496 - 346554 != -323058)
						{
							continue;
						}
					}
				}
			}
			this.YB6VFhP2In += mTime;
		}
		while (152642 - 563277 == -410634);
	}

	// Token: 0x060042D8 RID: 17112 RVA: 0x0086D14C File Offset: 0x0086B34C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (200606 - 176443 != 24163)
		{
		}
		for (;;)
		{
			this.iK1Vj7OtBy.vDirection = followObject.transform.position;
			if (81435 - 354450 == -273015)
			{
				this.iK1Vj7OtBy.vDirection.y = this.transform.position.y;
				if (72418 - 352067 == -279649)
				{
					this.iK1Vj7OtBy.vMovement = (this.iK1Vj7OtBy.vDirection - this.transform.position).normalized;
					if (141991 - 88349 == 53642)
					{
						this.transform.rotation = Quaternion.LookRotation(this.iK1Vj7OtBy.vMovement);
						if (89052 - 227575 != -138522)
						{
							this.iK1Vj7OtBy.actionState = "run";
							if (110094 - 585040 == -474946)
							{
								this.animation.Play("run");
								if (292844 - 115778 != 177067)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (88879 - 347569 != -258689)
									{
										this.iK1Vj7OtBy.moveSpeed = Mathf.Lerp(this.iK1Vj7OtBy.moveSpeed, this.iK1Vj7OtBy.runSpeed, (float)4 * Time.deltaTime);
										if (223429 - 126479 == 96950)
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

	// Token: 0x060042D9 RID: 17113 RVA: 0x0086D334 File Offset: 0x0086B534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (299914 - 75595 != 224319)
		{
		}
		do
		{
			if (Time.time - this.TaVVke3xQO >= this.YB6VFhP2In)
			{
				if (69098 - 410592 == -341493)
				{
					continue;
				}
				if (Time.time - this.TaVVke3xQO < this.YB6VFhP2In + mTime)
				{
					if (94703 - 517795 != -423092)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (201303 - 288606 == -87302)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (190143 - 122208 != 67935)
						{
							continue;
						}
						this.TaVVke3xQO -= UnityEngine.Random.Range((float)0, rTimer);
						if (209866 - 61467 == 148400)
						{
							continue;
						}
						this.iK1Vj7OtBy.vDirection = this.iK1Vj7OtBy.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (230371 - 465418 == -235046)
						{
							continue;
						}
						this.iK1Vj7OtBy.vDirection.y = this.transform.position.y;
						if (136035 - 69873 == 66163)
						{
							continue;
						}
						this.iK1Vj7OtBy.vMovement = (this.iK1Vj7OtBy.vDirection - this.transform.position).normalized;
						if (63318 - 547763 == -484444)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.iK1Vj7OtBy.vMovement);
						if (224454 - 468949 == -244494)
						{
							continue;
						}
						this.iK1Vj7OtBy.actionState = "run";
						if (160840 - 264010 != -103170)
						{
							continue;
						}
						this.animation.Play("run");
						if (16470 - 316799 == -300328)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (225561 - 445932 != -220371)
						{
							continue;
						}
					}
					this.iK1Vj7OtBy.moveSpeed = Mathf.Lerp(this.iK1Vj7OtBy.moveSpeed, this.iK1Vj7OtBy.runSpeed, (float)4 * Time.deltaTime);
					if (160134 - 365874 == -205739)
					{
						continue;
					}
				}
			}
			this.YB6VFhP2In += mTime;
		}
		while (181117 - 143010 == 38108);
	}

	// Token: 0x060042DA RID: 17114 RVA: 0x0086D63C File Offset: 0x0086B83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (280536 - 550936 != -270399)
		{
		}
		do
		{
			if (Time.time - this.TaVVke3xQO >= this.YB6VFhP2In)
			{
				if (267509 - 99910 != 167599)
				{
					continue;
				}
				if (Time.time - this.TaVVke3xQO < this.YB6VFhP2In + mTime)
				{
					if (165405 - 214461 == -49055)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (210510 - 50581 == 159930)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (184626 - 139089 == 45538)
						{
							continue;
						}
						this.TaVVke3xQO = Time.time - mTime - this.YB6VFhP2In;
						if (28902 - 534630 != -505728)
						{
							continue;
						}
						this.iK1Vj7OtBy.vDirection = Vector3.zero;
						if (279711 - 434714 == -155002)
						{
							continue;
						}
						this.iK1Vj7OtBy.vMovement = this.transform.forward;
						if (212736 - 87748 != 124988)
						{
							continue;
						}
						this.iK1Vj7OtBy.actionState = "standby";
						if (13524 - 577463 == -563938)
						{
							continue;
						}
						this.iK1Vj7OtBy.myAttackTarget = this.iK1Vj7OtBy.getHateTarget(5, 50);
						if (158121 - 520614 == -362492)
						{
							continue;
						}
						if (!this.iK1Vj7OtBy.myAttackTarget)
						{
							if (289654 - 5092 == 284563)
							{
								continue;
							}
							this.iK1Vj7OtBy.isAlert = false;
							if (236990 - 216053 != 20937)
							{
								continue;
							}
							this.TaVVke3xQO = Time.time;
							if (240518 - 515936 == -275417)
							{
								continue;
							}
							this.iK1Vj7OtBy.myAttackTarget = null;
							if (276911 - 484344 != -207433)
							{
								continue;
							}
							this.iK1Vj7OtBy.mOriginalPosition = this.transform.position;
							if (235557 - 167849 != 67709)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.iK1Vj7OtBy.myAttackTarget;
							if (51653 - 575305 != -523652)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (231131 - 280263 == -49131)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (97449 - 173621 == -76171)
								{
									continue;
								}
								this.iK1Vj7OtBy.isAlert = false;
								if (53394 - 149109 != -95715)
								{
									continue;
								}
								this.TaVVke3xQO = Time.time;
								if (142877 - 500145 != -357268)
								{
									continue;
								}
								this.iK1Vj7OtBy.myAttackTarget = null;
								if (91522 - 203077 == -111554)
								{
									continue;
								}
							}
							else
							{
								this.iK1Vj7OtBy.vDirection = myAttackTarget.transform.position;
								if (146050 - 585169 != -439119)
								{
									continue;
								}
								this.iK1Vj7OtBy.vDirection.y = this.transform.position.y;
								if (203871 - 513597 != -309726)
								{
									continue;
								}
								this.iK1Vj7OtBy.vMovement = (this.iK1Vj7OtBy.vDirection - this.transform.position).normalized;
								if (298930 - 339666 == -40735)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.iK1Vj7OtBy.vMovement);
								if (248821 - 359276 == -110454)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.YB6VFhP2In += mTime;
		}
		while (75590 - 24836 == 50755);
	}

	// Token: 0x060042DB RID: 17115 RVA: 0x0086DAEC File Offset: 0x0086BCEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (178904 - 436459 != -257554)
		{
		}
		do
		{
			if (Time.time - this.TaVVke3xQO >= this.YB6VFhP2In)
			{
				if (150028 - 175290 != -25262)
				{
					continue;
				}
				if (Time.time - this.TaVVke3xQO < this.YB6VFhP2In + mTime)
				{
					if (74401 - 336946 == -262544)
					{
						continue;
					}
					if (!this.iK1Vj7OtBy.myAttackTarget)
					{
						if (61680 - 530459 != -468779)
						{
							continue;
						}
						this.TaVVke3xQO = Time.time - mTime - this.YB6VFhP2In;
						if (252385 - 570481 != -318095)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.iK1Vj7OtBy.myAttackTarget;
						if (112339 - 295127 != -182788)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (63026 - 328760 != -265734)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (22498 - 236507 != -214009)
						{
							continue;
						}
						if (276065 - 261019 != 15046)
						{
							continue;
						}
						if (characterControl)
						{
							if (19632 - 226599 == -206966)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (103949 - 184044 != -80095)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (142753 - 303791 == -161037)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (30808 - 534567 != -503759)
							{
								continue;
							}
							if (this.iK1Vj7OtBy.isTimeOut("nAttack") == (float)0)
							{
								if (188978 - 552069 != -363091)
								{
									continue;
								}
								this.TaVVke3xQO = Time.time - mTime - this.YB6VFhP2In;
								if (128317 - 498574 != -370257)
								{
									continue;
								}
								Vector3 vector2 = global::Math.vFlat(vector);
								if (25956 - 301161 == -275204)
								{
									continue;
								}
								vector = vector2.normalized;
								if (165016 - 396100 != -231084)
								{
									continue;
								}
								this.jLhVoXvMk4.StartCoroutine_Auto(this.jLhVoXvMk4.RPC_millionaire(this.transform.position, vector, 0));
								if (110709 - 189732 != -79023)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (23581 - 331492 != -307911)
									{
										continue;
									}
									this.jLhVoXvMk4.ActionEvent("RPC_millionaire", this.transform.position, vector, 0);
									if (25026 - 590251 == -565224)
									{
										continue;
									}
								}
								goto IL_45;
							}
						}
						this.AI_state = "attack";
						if (50223 - 542445 == -492221)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (52712 - 515330 != -462618)
							{
								continue;
							}
							this.iK1Vj7OtBy.vDirection = myAttackTarget.transform.position;
							if (93162 - 438280 != -345118)
							{
								continue;
							}
							this.iK1Vj7OtBy.vDirection.y = this.transform.position.y;
							if (55735 - 371109 != -315374)
							{
								continue;
							}
							this.iK1Vj7OtBy.vMovement = (this.iK1Vj7OtBy.vDirection - this.transform.position).normalized;
							if (210464 - 525901 != -315437)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.iK1Vj7OtBy.vMovement);
							if (172426 - 538845 != -366419)
							{
								continue;
							}
							this.iK1Vj7OtBy.actionState = "run";
							if (234887 - 158167 == 76721)
							{
								continue;
							}
							this.animation.Play("run");
							if (271739 - 189781 != 81958)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (183908 - 246452 != -62544)
							{
								continue;
							}
							this.iK1Vj7OtBy.moveSpeed = Mathf.Lerp(this.iK1Vj7OtBy.moveSpeed, this.iK1Vj7OtBy.runSpeed, (float)4 * Time.deltaTime);
							if (279575 - 36400 != 243175)
							{
								continue;
							}
						}
						else
						{
							this.iK1Vj7OtBy.vDirection = myAttackTarget.transform.position;
							if (143975 - 10721 == 133255)
							{
								continue;
							}
							this.iK1Vj7OtBy.vDirection.y = this.transform.position.y;
							if (13179 - 340893 == -327713)
							{
								continue;
							}
							this.iK1Vj7OtBy.vMovement = (this.iK1Vj7OtBy.vDirection - this.transform.position).normalized;
							if (277107 - 71894 == 205214)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.iK1Vj7OtBy.vMovement);
							if (128084 - 131625 == -3540)
							{
								continue;
							}
							this.iK1Vj7OtBy.actionState = "standby";
							if (265296 - 552033 == -286736)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (196118 - 193250 != 2868)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (280326 - 373266 != -92940)
							{
								continue;
							}
							this.iK1Vj7OtBy.moveSpeed = Mathf.Lerp(this.iK1Vj7OtBy.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (92484 - 46707 == 45778)
							{
								continue;
							}
						}
					}
				}
			}
			IL_45:
			this.YB6VFhP2In += mTime;
		}
		while (111991 - 179570 != -67579);
	}

	// Token: 0x060042DC RID: 17116 RVA: 0x0086E248 File Offset: 0x0086C448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (81402 - 141806 != -60404)
		{
		}
		while (Time.time - this.TaVVke3xQO > this.YB6VFhP2In)
		{
			if (112305 - 410208 == -297903)
			{
				this.AI_state = "none";
				if (116950 - 337907 == -220957)
				{
					this.TaVVke3xQO = Time.time;
					if (220130 - 433896 != -213765)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060042DD RID: 17117 RVA: 0x0086E2FC File Offset: 0x0086C4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (56458 - 409971 != -353513)
		{
		}
		for (;;)
		{
			IL_30E:
			if (this.cNoVAmaAW2 > Time.time)
			{
				if (145547 - 77014 != 68534)
				{
					break;
				}
			}
			else
			{
				this.cNoVAmaAW2 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (47210 - 486084 == -438874)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (28913 - 282018 != -253104)
					{
						if (143291 - 7626 == 135665)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (136451 - 144791 == -8340)
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
									if (10155 - 594201 == -584045)
									{
										goto IL_30E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (191172 - 597740 != -406568)
									{
										goto IL_30E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (146584 - 480999 == -334414)
									{
										goto IL_30E;
									}
									bool flag = true;
									if (266623 - 116665 == 149959)
									{
										goto IL_30E;
									}
									eRace race = this.iK1Vj7OtBy.Race;
									if (206473 - 274496 == -68022)
									{
										goto IL_30E;
									}
									if (race == eRace.Tails)
									{
										if (284192 - 459456 == -175263)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7B8;
										}
										if (270652 - 6556 == 264097)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (4301 - 156381 != -152080)
											{
												goto IL_30E;
											}
											goto IL_7B8;
										}
										goto IL_B6;
										IL_7B8:
										flag = false;
										if (221671 - 530641 == -308969)
										{
											goto IL_30E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (12845 - 563941 == -551095)
										{
											goto IL_30E;
										}
										flag = false;
										if (170617 - 99702 == 70916)
										{
											goto IL_30E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (280713 - 451146 == -170432)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_256;
										}
										if (242671 - 276350 != -33679)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (44508 - 172079 != -127570)
											{
												goto IL_256;
											}
											goto IL_30E;
										}
										goto IL_B6;
										IL_256:
										flag = false;
										if (296707 - 37155 == 259553)
										{
											goto IL_30E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (2225 - 285317 == -283091)
										{
											goto IL_30E;
										}
										flag = true;
										if (237877 - 589049 != -351172)
										{
											goto IL_30E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (81555 - 239512 == -157956)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_F2;
										}
										if (3705 - 315345 == -311639)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_F2;
										}
										if (193485 - 553219 == -359733)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (16149 - 273263 != -257113)
											{
												goto IL_F2;
											}
											goto IL_30E;
										}
										goto IL_B6;
										IL_F2:
										flag = false;
										if (160883 - 437558 != -276675)
										{
											goto IL_30E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (287375 - 115804 == 171572)
										{
											goto IL_30E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (157647 - 381189 == -223541)
											{
												goto IL_30E;
											}
											flag = false;
											if (231690 - 276934 != -45244)
											{
												goto IL_30E;
											}
										}
									}
									IL_B6:
									if (flag)
									{
										if (183770 - 573258 != -389488)
										{
											goto IL_30E;
										}
										if (characterControl.hp > 0)
										{
											if (64827 - 82378 != -17551)
											{
												goto IL_30E;
											}
											if (characterControl.recieveTarget)
											{
												if (281695 - 174225 == 107471)
												{
													goto IL_30E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (189851 - 208005 == -18153)
													{
														goto IL_30E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (164318 - 82337 != 81981)
														{
															goto IL_30E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (159373 - 425055 != -265682)
														{
															goto IL_30E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (117691 - 67890 != 49801)
															{
																goto IL_30E;
															}
															this.iK1Vj7OtBy.myAttackTarget = gameObject;
															if (172412 - 318140 == -145727)
															{
																goto IL_30E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (86780 - 507549 == -420768)
															{
																goto IL_30E;
															}
															this.iK1Vj7OtBy.addHate(characterControl.ActorNr, 5);
															if (57743 - 41950 != 15793)
															{
																goto IL_30E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (224889 - 442614 != -217725)
															{
																goto IL_30E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (246655 - 193206 != 53449)
															{
																goto IL_30E;
															}
															if (num < (float)60)
															{
																if (18445 - 21792 == -3346)
																{
																	goto IL_30E;
																}
																if (characterControl.hp > 0)
																{
																	if (262456 - 136262 == 126195)
																	{
																		goto IL_30E;
																	}
																	this.iK1Vj7OtBy.myAttackTarget = gameObject;
																	if (19953 - 295234 == -275280)
																	{
																		goto IL_30E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (268779 - 454861 == -186081)
																	{
																		goto IL_30E;
																	}
																	this.iK1Vj7OtBy.addHate(characterControl.ActorNr, 5);
																	if (132997 - 174096 == -41098)
																	{
																		goto IL_30E;
																	}
																}
															}
														}
														if (this.iK1Vj7OtBy.myAttackTarget)
														{
															if (259881 - 154123 == 105759)
															{
																goto IL_30E;
															}
															this.iK1Vj7OtBy.isAlert = true;
															if (75341 - 307185 == -231843)
															{
																goto IL_30E;
															}
															this.TaVVke3xQO = Time.time;
															if (119214 - 266527 != -147313)
															{
																goto IL_30E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (260619 - 256469 != 4151)
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

	// Token: 0x060042DE RID: 17118 RVA: 0x0086EB14 File Offset: 0x0086CD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x0086EB18 File Offset: 0x0086CD18
	internal static bool xPukCD5fRfsHp8kfGiw9()
	{
		return true;
	}

	// Token: 0x060042E0 RID: 17120 RVA: 0x0086EB1C File Offset: 0x0086CD1C
	internal static bool zNKuQh5fwTaUyw1tBBPg()
	{
		return false;
	}

	// Token: 0x04004EB6 RID: 20150
	private CharacterControl iK1Vj7OtBy;

	// Token: 0x04004EB7 RID: 20151
	private Catfish jLhVoXvMk4;

	// Token: 0x04004EB8 RID: 20152
	public string AI_state;

	// Token: 0x04004EB9 RID: 20153
	private float TaVVke3xQO;

	// Token: 0x04004EBA RID: 20154
	private float YB6VFhP2In;

	// Token: 0x04004EBB RID: 20155
	private float cNoVAmaAW2;
}
