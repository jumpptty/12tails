using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CF6 RID: 3318
[Serializable]
public class MiniCat_AI : MonoBehaviour
{
	// Token: 0x06004A84 RID: 19076 RVA: 0x0093ACC8 File Offset: 0x00938EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniCat_AI()
	{
		if (180245 - 202623 != -22378)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (103104 - 428171 == -325067)
			{
				base..ctor();
				if (93964 - 511228 != -417263)
				{
					this.AI_state = "none";
					if (21770 - 125738 != -103967)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x0093AD64 File Offset: 0x00938F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.EQlc5T3YeyP = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.eEOc5YpsyH2 = (MiniCat)this.GetComponent(typeof(MiniCat));
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x0093AD9C File Offset: 0x00938F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (34553 - 233074 != -198521)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (73041 - 454696 != -381655)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (255152 - 166680 == 88473)
				{
					continue;
				}
			}
			if (this.EQlc5T3YeyP.isControlled)
			{
				break;
			}
			if (180219 - 353403 == -173184)
			{
				this.AIControl();
				if (105893 - 322532 != -216638)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x0093AE68 File Offset: 0x00939068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (237860 - 97359 != 140502)
		{
		}
		for (;;)
		{
			this.ijtc5b1s6CO = (float)0;
			if (288033 - 575975 == -287942)
			{
				if (this.EQlc5T3YeyP.isMine)
				{
					if (119155 - 521719 == -402564)
					{
						if (this.EQlc5T3YeyP.actionState != "standby")
						{
							if (299579 - 573144 != -273565)
							{
								continue;
							}
							if (this.EQlc5T3YeyP.actionState != "run")
							{
								if (49505 - 573939 != -524434)
								{
									continue;
								}
								break;
							}
						}
						if (!this.EQlc5T3YeyP.isAlert)
						{
							if (99126 - 324769 != -225642)
							{
								if (this.EQlc5T3YeyP.isSummon)
								{
									if (168018 - 245805 == -77786)
									{
										continue;
									}
									if (this.EQlc5T3YeyP.mSummoner != null)
									{
										if (29657 - 354656 == -324998)
										{
											continue;
										}
										Vector3 vector = this.EQlc5T3YeyP.mSummoner.transform.position - this.transform.position;
										if (139581 - 65260 != 74321)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (187250 - 22232 == 165019)
											{
												continue;
											}
											this.AI_follow(this.EQlc5T3YeyP.mSummoner);
											if (21609 - 450231 != -428622)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (106166 - 480473 == -374306)
											{
												continue;
											}
											this.AI_resetTimer();
											if (224854 - 90067 != 134787)
											{
												continue;
											}
											this.AI_visionCheck();
											if (260064 - 232471 != 27593)
											{
												continue;
											}
										}
										goto IL_6A5;
									}
								}
								this.AI_idle(3f, 1f);
								if (95935 - 496034 == -400098)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (61414 - 319041 == -257626)
								{
									continue;
								}
								this.AI_resetTimer();
								if (255925 - 409850 == -153924)
								{
									continue;
								}
								this.AI_visionCheck();
								if (152794 - 166459 != -13665)
								{
									continue;
								}
								IL_6A5:
								if (!this.EQlc5T3YeyP.myAttackTarget)
								{
									break;
								}
								if (274229 - 292246 != -18016)
								{
									this.EQlc5T3YeyP.isAlert = true;
									if (283578 - 19986 != 263593)
									{
										this.JIRc53Sb40v = Time.time;
										if (258044 - 471214 == -213170)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (55777 - 239502 == -183725)
							{
								this.AI_idle(3f, 1f);
								if (103104 - 447895 == -344791)
								{
									this.AI_attack(10f, (float)0);
									if (95455 - 520110 != -424654)
									{
										this.AI_resetTimer();
										if (199603 - 223800 == -24197)
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
					if (this.EQlc5T3YeyP.actionState != "standby")
					{
						if (269279 - 561931 != -292652)
						{
							continue;
						}
						if (this.EQlc5T3YeyP.actionState != "run")
						{
							if (112958 - 481095 != -368136)
							{
								break;
							}
							continue;
						}
					}
					float num = this.EQlc5T3YeyP.moveSpeed;
					if (208085 - 564796 != -356710)
					{
						float runSpeed = this.EQlc5T3YeyP.runSpeed;
						if (34563 - 100012 != -65448)
						{
							Vector3 vector2 = default(Vector3);
							if (211901 - 212386 != -484)
							{
								Vector3 vector3 = Vector3.zero;
								if (8767 - 76045 != -67277)
								{
									if ((this.EQlc5T3YeyP.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (261714 - 8881 != 252833)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.EQlc5T3YeyP.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (35377 - 232931 != -197554)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (79216 - 522416 == -443199)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (117608 - 561641 != -444033)
											{
												continue;
											}
											num = (float)0;
											if (115516 - 509276 == -393759)
											{
												continue;
											}
											this.transform.position = this.EQlc5T3YeyP.nPosition;
											if (91132 - 428766 == -337633)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (214929 - 514534 == -299604)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (277269 - 235570 != 41699)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (119158 - 215545 != -96387)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (212101 - 388063 == -175961)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (121644 - 75338 == 46307)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (234935 - 455583 == -220647)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (60664 - 97098 != -36434)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (184232 - 332139 != -147907)
											{
												continue;
											}
										}
									}
									this.EQlc5T3YeyP.vMovement = vector3;
									if (191117 - 328921 == -137804)
									{
										this.EQlc5T3YeyP.moveSpeed = num;
										if (128981 - 298321 == -169340)
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

	// Token: 0x06004A88 RID: 19080 RVA: 0x0093B644 File Offset: 0x00939844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (107364 - 511643 != -404278)
		{
		}
		do
		{
			if (Time.time - this.JIRc53Sb40v >= this.ijtc5b1s6CO)
			{
				if (230698 - 261303 == -30604)
				{
					continue;
				}
				if (Time.time - this.JIRc53Sb40v < this.ijtc5b1s6CO + mTime)
				{
					if (1082 - 83597 != -82515)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (256774 - 434268 != -177494)
						{
							continue;
						}
						this.AI_state = "idle";
						if (105146 - 245839 != -140693)
						{
							continue;
						}
						this.JIRc53Sb40v -= UnityEngine.Random.Range((float)0, rTimer);
						if (165442 - 57207 != 108235)
						{
							continue;
						}
						this.EQlc5T3YeyP.vDirection = Vector3.zero;
						if (141711 - 357728 == -216016)
						{
							continue;
						}
						this.EQlc5T3YeyP.vMovement = this.transform.forward;
						if (164113 - 374727 != -210614)
						{
							continue;
						}
						this.EQlc5T3YeyP.actionState = "standby";
						if (134723 - 389545 == -254821)
						{
							continue;
						}
					}
					this.EQlc5T3YeyP.moveSpeed = Mathf.Lerp(this.EQlc5T3YeyP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (207509 - 277771 == -70261)
					{
						continue;
					}
					if (this.EQlc5T3YeyP.moveSpeed < 0.1f * this.EQlc5T3YeyP.runSpeed)
					{
						if (104520 - 267114 == -162593)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (81025 - 362950 == -281924)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (123743 - 37176 == 86568)
						{
							continue;
						}
						this.EQlc5T3YeyP.moveSpeed = (float)0;
						if (123266 - 450895 == -327628)
						{
							continue;
						}
					}
				}
			}
			this.ijtc5b1s6CO += mTime;
		}
		while (236819 - 83671 == 153149);
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x0093B908 File Offset: 0x00939B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (148462 - 153447 != -4985)
		{
		}
		for (;;)
		{
			this.EQlc5T3YeyP.vDirection = followObject.transform.position;
			if (55472 - 488130 == -432658)
			{
				this.EQlc5T3YeyP.vDirection.y = this.transform.position.y;
				if (253809 - 160119 != 93691)
				{
					this.EQlc5T3YeyP.vMovement = (this.EQlc5T3YeyP.vDirection - this.transform.position).normalized;
					if (262897 - 343191 == -80294)
					{
						this.transform.rotation = Quaternion.LookRotation(this.EQlc5T3YeyP.vMovement);
						if (87130 - 66964 != 20167)
						{
							this.EQlc5T3YeyP.actionState = "run";
							if (51143 - 412930 == -361787)
							{
								this.animation.Play("run");
								if (144291 - 272123 != -127831)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (266936 - 374231 == -107295)
									{
										this.EQlc5T3YeyP.moveSpeed = Mathf.Lerp(this.EQlc5T3YeyP.moveSpeed, this.EQlc5T3YeyP.runSpeed, (float)4 * Time.deltaTime);
										if (162637 - 75774 != 86864)
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

	// Token: 0x06004A8A RID: 19082 RVA: 0x0093BAF0 File Offset: 0x00939CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (161765 - 538282 != -376517)
		{
		}
		do
		{
			if (Time.time - this.JIRc53Sb40v >= this.ijtc5b1s6CO)
			{
				if (263301 - 134133 != 129168)
				{
					continue;
				}
				if (Time.time - this.JIRc53Sb40v < this.ijtc5b1s6CO + mTime)
				{
					if (897 - 359733 != -358836)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (87244 - 249799 == -162554)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (13210 - 503264 == -490053)
						{
							continue;
						}
						this.JIRc53Sb40v -= UnityEngine.Random.Range((float)0, rTimer);
						if (270083 - 455662 == -185578)
						{
							continue;
						}
						this.EQlc5T3YeyP.vDirection = this.EQlc5T3YeyP.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (206016 - 330515 != -124499)
						{
							continue;
						}
						this.EQlc5T3YeyP.vDirection.y = this.transform.position.y;
						if (235783 - 3400 == 232384)
						{
							continue;
						}
						this.EQlc5T3YeyP.vMovement = (this.EQlc5T3YeyP.vDirection - this.transform.position).normalized;
						if (225122 - 351885 != -126763)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.EQlc5T3YeyP.vMovement);
						if (59796 - 88157 == -28360)
						{
							continue;
						}
						this.EQlc5T3YeyP.actionState = "run";
						if (149612 - 283146 != -133534)
						{
							continue;
						}
						this.animation.Play("run");
						if (113867 - 160447 != -46580)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (91941 - 289900 == -197958)
						{
							continue;
						}
					}
					this.EQlc5T3YeyP.moveSpeed = Mathf.Lerp(this.EQlc5T3YeyP.moveSpeed, this.EQlc5T3YeyP.runSpeed, (float)4 * Time.deltaTime);
					if (250448 - 143514 != 106934)
					{
						continue;
					}
				}
			}
			this.ijtc5b1s6CO += mTime;
		}
		while (299211 - 337664 != -38453);
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x0093BDF8 File Offset: 0x00939FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (220160 - 466414 != -246254)
		{
		}
		do
		{
			if (Time.time - this.JIRc53Sb40v >= this.ijtc5b1s6CO)
			{
				if (15742 - 158171 == -142428)
				{
					continue;
				}
				if (Time.time - this.JIRc53Sb40v < this.ijtc5b1s6CO + mTime)
				{
					if (207196 - 474991 != -267795)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (84295 - 301072 == -216776)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (34539 - 108735 == -74195)
						{
							continue;
						}
						this.JIRc53Sb40v = Time.time - mTime - this.ijtc5b1s6CO;
						if (17472 - 509480 == -492007)
						{
							continue;
						}
						this.EQlc5T3YeyP.vDirection = Vector3.zero;
						if (241937 - 316713 != -74776)
						{
							continue;
						}
						this.EQlc5T3YeyP.vMovement = this.transform.forward;
						if (255884 - 327786 == -71901)
						{
							continue;
						}
						this.EQlc5T3YeyP.actionState = "standby";
						if (200755 - 392478 == -191722)
						{
							continue;
						}
						this.EQlc5T3YeyP.myAttackTarget = this.EQlc5T3YeyP.getHateClosestTarget(40);
						if (24614 - 455901 != -431287)
						{
							continue;
						}
						if (!this.EQlc5T3YeyP.myAttackTarget)
						{
							if (142252 - 235159 != -92907)
							{
								continue;
							}
							this.EQlc5T3YeyP.isAlert = false;
							if (238614 - 393831 != -155217)
							{
								continue;
							}
							this.JIRc53Sb40v = Time.time;
							if (223042 - 313649 == -90606)
							{
								continue;
							}
							this.EQlc5T3YeyP.myAttackTarget = null;
							if (67840 - 85477 == -17636)
							{
								continue;
							}
							this.EQlc5T3YeyP.mOriginalPosition = this.transform.position;
							if (11 - 57197 != -57185)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.EQlc5T3YeyP.myAttackTarget;
							if (86165 - 216532 != -130367)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (178376 - 544904 == -366527)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (173849 - 437372 != -263523)
								{
									continue;
								}
								this.EQlc5T3YeyP.isAlert = false;
								if (251646 - 342203 != -90557)
								{
									continue;
								}
								this.JIRc53Sb40v = Time.time;
								if (79705 - 287663 != -207958)
								{
									continue;
								}
								this.EQlc5T3YeyP.myAttackTarget = null;
								if (124613 - 114703 != 9910)
								{
									continue;
								}
							}
							else
							{
								this.EQlc5T3YeyP.vDirection = myAttackTarget.transform.position;
								if (2249 - 511475 != -509226)
								{
									continue;
								}
								this.EQlc5T3YeyP.vDirection.y = this.transform.position.y;
								if (21984 - 170353 == -148368)
								{
									continue;
								}
								this.EQlc5T3YeyP.vMovement = (this.EQlc5T3YeyP.vDirection - this.transform.position).normalized;
								if (238108 - 479539 == -241430)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.EQlc5T3YeyP.vMovement);
								if (251999 - 242324 != 9675)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ijtc5b1s6CO += mTime;
		}
		while (297139 - 286688 == 10452);
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x0093C2A8 File Offset: 0x0093A4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (84183 - 286845 != -202661)
		{
		}
		do
		{
			if (Time.time - this.JIRc53Sb40v >= this.ijtc5b1s6CO)
			{
				if (92850 - 432512 == -339661)
				{
					continue;
				}
				if (Time.time - this.JIRc53Sb40v < this.ijtc5b1s6CO + mTime)
				{
					if (150688 - 47560 != 103128)
					{
						continue;
					}
					if (!this.EQlc5T3YeyP.myAttackTarget)
					{
						if (193411 - 354490 != -161079)
						{
							continue;
						}
						this.JIRc53Sb40v = Time.time - mTime - this.ijtc5b1s6CO;
						if (168877 - 260931 != -92054)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.EQlc5T3YeyP.myAttackTarget;
						if (79774 - 25726 == 54049)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (8073 - 498007 != -489934)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (127689 - 278939 == -151249)
						{
							continue;
						}
						int tID = 0;
						if (60913 - 560339 == -499425)
						{
							continue;
						}
						if (characterControl)
						{
							if (73637 - 508575 != -434938)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (81154 - 473119 != -391965)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (187991 - 525194 != -337203)
						{
							continue;
						}
						if (num > (float)24)
						{
							if (208467 - 175878 != 32589)
							{
								continue;
							}
							if (this.EQlc5T3YeyP.isTimeOut("cAttack") == (float)0)
							{
								if (11917 - 358424 == -346506)
								{
									continue;
								}
								this.JIRc53Sb40v = Time.time - mTime - this.ijtc5b1s6CO;
								if (276423 - 439244 != -162821)
								{
									continue;
								}
								this.eEOc5YpsyH2.StartCoroutine_Auto(this.eEOc5YpsyH2.RPC_hide(this.transform.position, vector, tID));
								if (225628 - 93670 != 131959)
								{
									if (PhotonClient.IsInitialized())
									{
										if (63887 - 448468 != -384581)
										{
											continue;
										}
										this.eEOc5YpsyH2.ActionEvent("RPC_hide", this.transform.position, vector, tID);
										if (163021 - 358178 == -195156)
										{
											continue;
										}
									}
									goto IL_16C;
								}
								continue;
							}
						}
						if (num < (float)18)
						{
							if (78466 - 107313 != -28847)
							{
								continue;
							}
							if (this.EQlc5T3YeyP.isTimeOut("nAttack") == (float)0)
							{
								if (154535 - 247544 == -93008)
								{
									continue;
								}
								this.JIRc53Sb40v = Time.time - mTime - this.ijtc5b1s6CO;
								if (84436 - 144456 == -60019)
								{
									continue;
								}
								this.eEOc5YpsyH2.StartCoroutine_Auto(this.eEOc5YpsyH2.RPC_nAttack(this.transform.position, vector, tID));
								if (57073 - 43214 != 13859)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (204508 - 3367 == 201142)
									{
										continue;
									}
									this.eEOc5YpsyH2.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (208214 - 5080 != 203134)
									{
										continue;
									}
								}
								goto IL_16C;
							}
						}
						this.AI_state = "attack";
						if (276882 - 124937 == 151946)
						{
							continue;
						}
						if (num > (float)16)
						{
							if (17996 - 482136 == -464139)
							{
								continue;
							}
							this.EQlc5T3YeyP.vDirection = myAttackTarget.transform.position;
							if (244345 - 10583 != 233762)
							{
								continue;
							}
							this.EQlc5T3YeyP.vDirection.y = this.transform.position.y;
							if (27187 - 506038 == -478850)
							{
								continue;
							}
							this.EQlc5T3YeyP.vMovement = (this.EQlc5T3YeyP.vDirection - this.transform.position).normalized;
							if (13162 - 310102 != -296940)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.EQlc5T3YeyP.vMovement);
							if (25469 - 462410 == -436940)
							{
								continue;
							}
							this.EQlc5T3YeyP.actionState = "run";
							if (99177 - 371368 == -272190)
							{
								continue;
							}
							this.animation.Play("run");
							if (243778 - 323203 == -79424)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (299398 - 73733 != 225665)
							{
								continue;
							}
							this.EQlc5T3YeyP.moveSpeed = Mathf.Lerp(this.EQlc5T3YeyP.moveSpeed, this.EQlc5T3YeyP.runSpeed, (float)4 * Time.deltaTime);
							if (187683 - 439113 != -251430)
							{
								continue;
							}
						}
						else
						{
							this.EQlc5T3YeyP.vDirection = myAttackTarget.transform.position;
							if (205018 - 183739 == 21280)
							{
								continue;
							}
							this.EQlc5T3YeyP.vDirection.y = this.transform.position.y;
							if (171359 - 387903 == -216543)
							{
								continue;
							}
							this.EQlc5T3YeyP.vMovement = (this.EQlc5T3YeyP.vDirection - this.transform.position).normalized;
							if (79060 - 633 != 78427)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.EQlc5T3YeyP.vMovement);
							if (258671 - 89309 != 169362)
							{
								continue;
							}
							this.EQlc5T3YeyP.actionState = "standby";
							if (213781 - 423921 == -210139)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (154632 - 217827 == -63194)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (210728 - 411933 == -201204)
							{
								continue;
							}
							this.EQlc5T3YeyP.moveSpeed = Mathf.Lerp(this.EQlc5T3YeyP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (58025 - 39770 == 18256)
							{
								continue;
							}
						}
					}
				}
			}
			IL_16C:
			this.ijtc5b1s6CO += mTime;
		}
		while (225490 - 557840 != -332350);
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x0093CAE4 File Offset: 0x0093ACE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (67657 - 107067 != -39410)
		{
		}
		while (Time.time - this.JIRc53Sb40v > this.ijtc5b1s6CO)
		{
			if (123776 - 412703 == -288927)
			{
				this.AI_state = "none";
				if (67055 - 400787 == -333732)
				{
					this.JIRc53Sb40v = Time.time;
					if (150981 - 287248 == -136267)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x0093CB98 File Offset: 0x0093AD98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (180764 - 414236 != -233472)
		{
		}
		for (;;)
		{
			IL_5FB:
			if (this.Tjpc5dEqiL7 > Time.time)
			{
				if (286404 - 249890 == 36514)
				{
					break;
				}
			}
			else
			{
				this.Tjpc5dEqiL7 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (221714 - 281806 != -60091)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (162339 - 391034 == -228695)
					{
						if (133958 - 459913 != -325954)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (61909 - 139597 == -77688)
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
									if (96668 - 462493 == -365824)
									{
										goto IL_5FB;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (20218 - 409147 != -388929)
									{
										goto IL_5FB;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (206148 - 439343 != -233195)
									{
										goto IL_5FB;
									}
									bool flag = true;
									if (150606 - 229127 != -78521)
									{
										goto IL_5FB;
									}
									eRace race = this.EQlc5T3YeyP.Race;
									if (48544 - 328025 == -279480)
									{
										goto IL_5FB;
									}
									if (race == eRace.Tails)
									{
										if (243471 - 308948 != -65477)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2FE;
										}
										if (20663 - 464934 != -444271)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (249299 - 476460 != -227161)
											{
												goto IL_5FB;
											}
											goto IL_2FE;
										}
										goto IL_287;
										IL_2FE:
										flag = false;
										if (72163 - 25063 != 47100)
										{
											goto IL_5FB;
										}
									}
									else if (race == eRace.Plants)
									{
										if (261149 - 154174 != 106975)
										{
											goto IL_5FB;
										}
										flag = false;
										if (275785 - 592628 != -316843)
										{
											goto IL_5FB;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (16525 - 199955 != -183430)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_6F;
										}
										if (284879 - 104556 == 180324)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (119826 - 193160 != -73334)
											{
												goto IL_5FB;
											}
											goto IL_6F;
										}
										goto IL_287;
										IL_6F:
										flag = false;
										if (270270 - 313765 != -43495)
										{
											goto IL_5FB;
										}
									}
									else if (race == eRace.Robots)
									{
										if (238929 - 77660 != 161269)
										{
											goto IL_5FB;
										}
										flag = true;
										if (47225 - 575330 == -528104)
										{
											goto IL_5FB;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (71263 - 264507 != -193244)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_162;
										}
										if (60556 - 263864 == -203307)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_162;
										}
										if (151088 - 500234 != -349146)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (118422 - 324512 != -206089)
											{
												goto IL_162;
											}
											goto IL_5FB;
										}
										goto IL_287;
										IL_162:
										flag = false;
										if (62643 - 148776 == -86132)
										{
											goto IL_5FB;
										}
									}
									else if (race == eRace.Structure)
									{
										if (86760 - 513879 == -427118)
										{
											goto IL_5FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (125980 - 244591 == -118610)
											{
												goto IL_5FB;
											}
											flag = false;
											if (228047 - 410001 != -181954)
											{
												goto IL_5FB;
											}
										}
									}
									IL_287:
									if (flag)
									{
										if (40774 - 109966 == -69191)
										{
											goto IL_5FB;
										}
										if (characterControl.hp > 0)
										{
											if (242760 - 430278 != -187518)
											{
												goto IL_5FB;
											}
											if (characterControl.recieveTarget)
											{
												if (135234 - 309029 != -173795)
												{
													goto IL_5FB;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (223529 - 597851 != -374322)
													{
														goto IL_5FB;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (94673 - 62464 != 32209)
														{
															goto IL_5FB;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (202236 - 414824 == -212587)
														{
															goto IL_5FB;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (42595 - 41288 != 1307)
															{
																goto IL_5FB;
															}
															this.EQlc5T3YeyP.myAttackTarget = gameObject;
															if (283506 - 68223 == 215284)
															{
																goto IL_5FB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (32864 - 325634 != -292770)
															{
																goto IL_5FB;
															}
															this.EQlc5T3YeyP.addHate(characterControl.ActorNr, 5);
															if (12388 - 180496 == -168107)
															{
																goto IL_5FB;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (265490 - 287081 != -21591)
															{
																goto IL_5FB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (22222 - 356399 == -334176)
															{
																goto IL_5FB;
															}
															if (num < (float)60)
															{
																if (283912 - 198787 == 85126)
																{
																	goto IL_5FB;
																}
																if (characterControl.hp > 0)
																{
																	if (122307 - 426683 == -304375)
																	{
																		goto IL_5FB;
																	}
																	this.EQlc5T3YeyP.myAttackTarget = gameObject;
																	if (45843 - 443726 == -397882)
																	{
																		goto IL_5FB;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (98605 - 315732 == -217126)
																	{
																		goto IL_5FB;
																	}
																	this.EQlc5T3YeyP.addHate(characterControl.ActorNr, 5);
																	if (207410 - 454081 != -246671)
																	{
																		goto IL_5FB;
																	}
																}
															}
														}
														if (this.EQlc5T3YeyP.myAttackTarget)
														{
															if (90443 - 52023 != 38420)
															{
																goto IL_5FB;
															}
															this.EQlc5T3YeyP.isAlert = true;
															if (281145 - 485261 == -204115)
															{
																goto IL_5FB;
															}
															this.JIRc53Sb40v = Time.time;
															if (299249 - 207807 == 91443)
															{
																goto IL_5FB;
															}
														}
													}
												}
											}
										}
									}
								}
								if (172843 - 332300 == -159457)
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

	// Token: 0x06004A8F RID: 19087 RVA: 0x0093D3B0 File Offset: 0x0093B5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x0093D3B4 File Offset: 0x0093B5B4
	internal static bool ugb5215q5l3mWQAECndV()
	{
		return true;
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x0093D3B8 File Offset: 0x0093B5B8
	internal static bool aJKW1d5qptYoi6TSQqap()
	{
		return false;
	}

	// Token: 0x0400553C RID: 21820
	private CharacterControl EQlc5T3YeyP;

	// Token: 0x0400553D RID: 21821
	private MiniCat eEOc5YpsyH2;

	// Token: 0x0400553E RID: 21822
	public string AI_state;

	// Token: 0x0400553F RID: 21823
	private float JIRc53Sb40v;

	// Token: 0x04005540 RID: 21824
	private float ijtc5b1s6CO;

	// Token: 0x04005541 RID: 21825
	private float Tjpc5dEqiL7;
}
