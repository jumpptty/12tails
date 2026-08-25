using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000090 RID: 144
[Serializable]
public class GiantSandBug_AI : MonoBehaviour
{
	// Token: 0x0600030C RID: 780 RVA: 0x0004E748 File Offset: 0x0004C948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantSandBug_AI()
	{
		if (44986 - 254913 != -209927)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (145179 - 167829 == -22650)
			{
				base..ctor();
				if (158641 - 538910 != -380268)
				{
					this.AI_state = "none";
					if (138111 - 36073 != 102039)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (228844 - 126637 != 102207)
		{
		}
		for (;;)
		{
			this.ogYcQFJ9V9 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (20759 - 557429 == -536670)
			{
				this.LubcePlIg2 = (GiantSandBug)this.GetComponent(typeof(GiantSandBug));
				if (263748 - 167213 == 96535)
				{
					Transform transform = this.transform.Find("ParticleEmitter");
					if (43377 - 159041 != -115663)
					{
						if (transform)
						{
							if (161877 - 413636 == -251759)
							{
								this.KCrcIgeCkH = (ParticleEmitter)transform.GetComponent(typeof(ParticleEmitter));
								if (293952 - 234868 != 59085)
								{
									if (this.KCrcIgeCkH)
									{
										break;
									}
									if (80444 - 23268 != 57177)
									{
										Debug.LogError("Cannot find ParticleEmitter Component");
										if (172260 - 593251 == -420991)
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
							if (120699 - 8892 == 111807)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0004E984 File Offset: 0x0004CB84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (293642 - 229226 != 64417)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (294809 - 360549 != -65740)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (81496 - 109923 != -28427)
				{
					continue;
				}
			}
			if (this.ogYcQFJ9V9.isControlled)
			{
				break;
			}
			if (293975 - 540001 != -246025)
			{
				this.AIControl();
				if (139694 - 196056 == -56362)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0004EA50 File Offset: 0x0004CC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (292822 - 254543 != 38279)
		{
		}
		for (;;)
		{
			this.ghRc62G0je = (float)0;
			if (268557 - 67047 != 201511)
			{
				if (this.ogYcQFJ9V9.isMine)
				{
					if (105377 - 540792 == -435415)
					{
						if (this.ogYcQFJ9V9.actionState != "standby")
						{
							if (184447 - 386773 == -202325)
							{
								continue;
							}
							if (this.ogYcQFJ9V9.actionState != "run")
							{
								if (177264 - 83804 != 93460)
								{
									continue;
								}
								break;
							}
						}
						if (!this.ogYcQFJ9V9.isAlert)
						{
							if (97057 - 535339 == -438282)
							{
								this.AI_idle(3f, 1f);
								if (155147 - 159348 == -4201)
								{
									this.AI_resetTimer();
									if (42971 - 308265 == -265294)
									{
										this.AI_visionCheck();
										if (173847 - 545935 != -372087)
										{
											if (!this.ogYcQFJ9V9.myAttackTarget)
											{
												break;
											}
											if (16727 - 191440 != -174712)
											{
												this.ogYcQFJ9V9.isAlert = true;
												if (219647 - 309537 == -89890)
												{
													this.KvFcJLV5NG = Time.time;
													if (258139 - 38869 == 219270)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (187106 - 284030 != -96923)
							{
								this.AI_idle(2f, 1f);
								if (253566 - 20106 == 233460)
								{
									this.AI_attack(6f, (float)0);
									if (99753 - 337340 != -237586)
									{
										this.AI_resetTimer();
										if (63172 - 364156 != -300983)
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
					if (this.ogYcQFJ9V9.actionState != "standby")
					{
						if (67419 - 178566 == -111146)
						{
							continue;
						}
						if (this.ogYcQFJ9V9.actionState != "run")
						{
							if (121419 - 71694 != 49726)
							{
								break;
							}
							continue;
						}
					}
					float num = this.ogYcQFJ9V9.moveSpeed;
					if (129755 - 554636 == -424881)
					{
						float runSpeed = this.ogYcQFJ9V9.runSpeed;
						if (235435 - 251904 != -16468)
						{
							Vector3 vector = default(Vector3);
							if (1416 - 577060 == -575644)
							{
								Vector3 vector2 = Vector3.zero;
								if (189057 - 29547 != 159511)
								{
									if ((this.ogYcQFJ9V9.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (192046 - 380893 == -188846)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ogYcQFJ9V9.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (20652 - 435516 == -414863)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (166232 - 226733 == -60500)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (32095 - 209048 == -176952)
											{
												continue;
											}
											num = (float)0;
											if (196645 - 389475 != -192830)
											{
												continue;
											}
											this.transform.position = this.ogYcQFJ9V9.nPosition;
											if (85078 - 302363 == -217284)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (226427 - 163821 == 62607)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (93390 - 113335 != -19945)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (110 - 461964 == -461853)
											{
												continue;
											}
											this.animation.CrossFade("run", (float)1);
											if (42245 - 535513 == -493267)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (71105 - 293534 != -222429)
											{
												continue;
											}
											if (!this.audio.isPlaying)
											{
												if (98863 - 2717 == 96147)
												{
													continue;
												}
												this.audio.Play();
												if (4238 - 448730 != -444492)
												{
													continue;
												}
											}
											if (this.KCrcIgeCkH)
											{
												if (145696 - 339298 != -193602)
												{
													continue;
												}
												this.KCrcIgeCkH.emit = true;
												if (20402 - 567923 != -547521)
												{
													continue;
												}
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (215169 - 525098 == -309928)
											{
												continue;
											}
											this.animation.CrossFade("root", (float)1);
											if (225758 - 346529 != -120771)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (297524 - 40378 == 257147)
											{
												continue;
											}
											if (this.audio.isPlaying)
											{
												if (32900 - 582439 == -549538)
												{
													continue;
												}
												this.audio.Stop();
												if (108691 - 514063 == -405371)
												{
													continue;
												}
											}
											if (this.KCrcIgeCkH)
											{
												if (4123 - 221976 == -217852)
												{
													continue;
												}
												this.KCrcIgeCkH.emit = false;
												if (273448 - 486454 == -213005)
												{
													continue;
												}
											}
										}
									}
									this.ogYcQFJ9V9.vMovement = vector2;
									if (236732 - 371361 != -134628)
									{
										this.ogYcQFJ9V9.moveSpeed = num;
										if (208066 - 254775 != -46708)
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

	// Token: 0x06000310 RID: 784 RVA: 0x0004F1D4 File Offset: 0x0004D3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (86752 - 208983 != -122230)
		{
		}
		do
		{
			if (Time.time - this.KvFcJLV5NG >= this.ghRc62G0je)
			{
				if (13570 - 289836 == -276265)
				{
					continue;
				}
				if (Time.time - this.KvFcJLV5NG < this.ghRc62G0je + mTime)
				{
					if (112927 - 472984 == -360056)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (101898 - 519594 != -417696)
						{
							continue;
						}
						this.AI_state = "idle";
						if (76122 - 427951 == -351828)
						{
							continue;
						}
						this.KvFcJLV5NG -= UnityEngine.Random.Range((float)0, rTimer);
						if (168066 - 236965 != -68899)
						{
							continue;
						}
						this.ogYcQFJ9V9.vDirection = Vector3.zero;
						if (237993 - 38681 == 199313)
						{
							continue;
						}
						this.ogYcQFJ9V9.vMovement = this.transform.forward;
						if (176573 - 558594 != -382021)
						{
							continue;
						}
						this.ogYcQFJ9V9.actionState = "standby";
						if (172608 - 257141 != -84533)
						{
							continue;
						}
					}
					this.ogYcQFJ9V9.moveSpeed = Mathf.Lerp(this.ogYcQFJ9V9.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (38221 - 536498 == -498276)
					{
						continue;
					}
					if (this.ogYcQFJ9V9.moveSpeed < 0.1f * this.ogYcQFJ9V9.runSpeed)
					{
						if (125325 - 393535 == -268209)
						{
							continue;
						}
						this.animation.CrossFade("root", (float)1);
						if (258387 - 131829 == 126559)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (105649 - 249065 != -143416)
						{
							continue;
						}
						this.ogYcQFJ9V9.moveSpeed = (float)0;
						if (24079 - 273637 != -249558)
						{
							continue;
						}
					}
				}
			}
			this.ghRc62G0je += mTime;
		}
		while (277168 - 361025 == -83856);
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0004F494 File Offset: 0x0004D694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (261722 - 566987 != -305265)
		{
		}
		do
		{
			if (Time.time - this.KvFcJLV5NG >= this.ghRc62G0je)
			{
				if (76770 - 110282 != -33512)
				{
					continue;
				}
				if (Time.time - this.KvFcJLV5NG < this.ghRc62G0je + mTime)
				{
					if (38087 - 280951 != -242864)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (107947 - 295874 == -187926)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (162070 - 143132 != 18938)
						{
							continue;
						}
						this.KvFcJLV5NG = Time.time - mTime - this.ghRc62G0je;
						if (124630 - 316101 != -191471)
						{
							continue;
						}
						this.ogYcQFJ9V9.vDirection = Vector3.zero;
						if (248396 - 280808 == -32411)
						{
							continue;
						}
						this.ogYcQFJ9V9.vMovement = this.transform.forward;
						if (211858 - 520871 == -309012)
						{
							continue;
						}
						this.ogYcQFJ9V9.actionState = "standby";
						if (1800 - 593202 != -591402)
						{
							continue;
						}
						this.ogYcQFJ9V9.myAttackTarget = this.ogYcQFJ9V9.getHateClosestTarget(40);
						if (122201 - 81505 != 40696)
						{
							continue;
						}
						if (!this.ogYcQFJ9V9.myAttackTarget)
						{
							if (128551 - 146068 == -17516)
							{
								continue;
							}
							this.ogYcQFJ9V9.isAlert = false;
							if (30346 - 527236 == -496889)
							{
								continue;
							}
							this.KvFcJLV5NG = Time.time;
							if (15520 - 146645 == -131124)
							{
								continue;
							}
							this.ogYcQFJ9V9.myAttackTarget = null;
							if (268902 - 67092 == 201811)
							{
								continue;
							}
							this.ogYcQFJ9V9.mOriginalPosition = this.transform.position;
							if (12175 - 214449 != -202274)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.ogYcQFJ9V9.myAttackTarget;
							if (285807 - 539384 == -253576)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (168369 - 229535 == -61165)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (72410 - 499957 != -427547)
								{
									continue;
								}
								this.ogYcQFJ9V9.isAlert = false;
								if (155779 - 551424 != -395645)
								{
									continue;
								}
								this.KvFcJLV5NG = Time.time;
								if (269696 - 55656 != 214040)
								{
									continue;
								}
								this.ogYcQFJ9V9.myAttackTarget = null;
								if (169359 - 201781 != -32422)
								{
									continue;
								}
							}
							else
							{
								this.ogYcQFJ9V9.vDirection = myAttackTarget.transform.position;
								if (252612 - 258073 != -5461)
								{
									continue;
								}
								this.ogYcQFJ9V9.vDirection.y = this.transform.position.y;
								if (76205 - 55671 != 20534)
								{
									continue;
								}
								this.ogYcQFJ9V9.vMovement = (this.ogYcQFJ9V9.vDirection - this.transform.position).normalized;
								if (271288 - 366013 != -94725)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ogYcQFJ9V9.vMovement);
								if (288646 - 562449 != -273803)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ghRc62G0je += mTime;
		}
		while (149042 - 578307 == -429264);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0004F944 File Offset: 0x0004DB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (67819 - 367062 != -299242)
		{
		}
		do
		{
			if (Time.time - this.KvFcJLV5NG >= this.ghRc62G0je)
			{
				if (675 - 459113 != -458438)
				{
					continue;
				}
				if (Time.time - this.KvFcJLV5NG < this.ghRc62G0je + mTime)
				{
					if (165507 - 41506 != 124001)
					{
						continue;
					}
					if (!this.ogYcQFJ9V9.myAttackTarget)
					{
						if (253937 - 319214 != -65277)
						{
							continue;
						}
						this.KvFcJLV5NG = Time.time - mTime - this.ghRc62G0je;
						if (146504 - 108553 != 37952)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.ogYcQFJ9V9.myAttackTarget;
						if (145341 - 81829 == 63513)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (283708 - 441384 != -157676)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (237198 - 564253 != -327055)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (201574 - 76728 != 124846)
							{
								continue;
							}
							if (this.ogYcQFJ9V9.actionState == "standby")
							{
								if (177834 - 108915 == 68920)
								{
									continue;
								}
								if (this.ogYcQFJ9V9.isTimeOut("nAttack") == (float)0)
								{
									if (298269 - 255415 != 42854)
									{
										continue;
									}
									this.KvFcJLV5NG = Time.time - mTime - this.ghRc62G0je;
									if (75437 - 335258 != -259821)
									{
										continue;
									}
									this.LubcePlIg2.StartCoroutine_Auto(this.LubcePlIg2.RPC_nAttack(this.transform.position, vector, 0));
									if (131019 - 494929 != -363909)
									{
										if (PhotonClient.IsInitialized())
										{
											if (163721 - 319898 == -156176)
											{
												continue;
											}
											this.LubcePlIg2.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (281329 - 490863 == -209533)
											{
												continue;
											}
										}
										goto IL_35F;
									}
									continue;
								}
							}
						}
						if (num < (float)5)
						{
							if (154146 - 585228 != -431082)
							{
								continue;
							}
							if (this.ogYcQFJ9V9.actionState == "run")
							{
								if (268384 - 96291 == 172094)
								{
									continue;
								}
								if (this.ogYcQFJ9V9.isTimeOut("nAttack") == (float)0)
								{
									if (124587 - 385333 == -260745)
									{
										continue;
									}
									this.KvFcJLV5NG = Time.time - mTime - this.ghRc62G0je;
									if (82175 - 397606 == -315430)
									{
										continue;
									}
									this.LubcePlIg2.StartCoroutine_Auto(this.LubcePlIg2.RPC_sandDive(this.transform.position, vector, 0));
									if (286763 - 184782 != 101982)
									{
										if (PhotonClient.IsInitialized())
										{
											if (217498 - 561680 != -344182)
											{
												continue;
											}
											this.LubcePlIg2.ActionEvent("RPC_sandDive", this.transform.position, vector, 0);
											if (23219 - 225720 == -202500)
											{
												continue;
											}
										}
										goto IL_35F;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (153262 - 45600 != 107662)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (154475 - 161033 == -6557)
							{
								continue;
							}
							this.ogYcQFJ9V9.vDirection = myAttackTarget.transform.position;
							if (33715 - 44077 != -10362)
							{
								continue;
							}
							this.ogYcQFJ9V9.vDirection.y = this.transform.position.y;
							if (112257 - 249331 != -137074)
							{
								continue;
							}
							this.ogYcQFJ9V9.vMovement = (this.ogYcQFJ9V9.vDirection - this.transform.position).normalized;
							if (119161 - 254374 == -135212)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ogYcQFJ9V9.vMovement);
							if (286705 - 546950 == -260244)
							{
								continue;
							}
							this.ogYcQFJ9V9.actionState = "standby";
							if (18649 - 467094 != -448445)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (78310 - 68575 != 9735)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (293508 - 79015 != 214493)
							{
								continue;
							}
							if (this.audio.isPlaying)
							{
								if (46975 - 291130 == -244154)
								{
									continue;
								}
								this.audio.Stop();
								if (251589 - 183581 != 68008)
								{
									continue;
								}
							}
							if (this.KCrcIgeCkH)
							{
								if (27186 - 158194 != -131008)
								{
									continue;
								}
								this.KCrcIgeCkH.emit = false;
								if (41219 - 381370 != -340151)
								{
									continue;
								}
							}
							this.ogYcQFJ9V9.moveSpeed = Mathf.Lerp(this.ogYcQFJ9V9.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (4880 - 161677 == -156796)
							{
								continue;
							}
						}
						else
						{
							this.ogYcQFJ9V9.vDirection = myAttackTarget.transform.position;
							if (100174 - 1165 == 99010)
							{
								continue;
							}
							this.ogYcQFJ9V9.vDirection.y = this.transform.position.y;
							if (33910 - 346316 != -312406)
							{
								continue;
							}
							this.ogYcQFJ9V9.vMovement = (this.ogYcQFJ9V9.vDirection - this.transform.position).normalized;
							if (91974 - 104809 == -12834)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ogYcQFJ9V9.vMovement);
							if (104909 - 577549 != -472640)
							{
								continue;
							}
							this.ogYcQFJ9V9.actionState = "run";
							if (236895 - 447976 == -211080)
							{
								continue;
							}
							this.animation.CrossFade("run", (float)1);
							if (231487 - 137131 == 94357)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (79175 - 480060 != -400885)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (94376 - 345477 != -251101)
								{
									continue;
								}
								this.audio.Play();
								if (15705 - 63545 != -47840)
								{
									continue;
								}
							}
							if (this.KCrcIgeCkH)
							{
								if (181550 - 379060 != -197510)
								{
									continue;
								}
								this.KCrcIgeCkH.emit = true;
								if (106693 - 383450 == -276756)
								{
									continue;
								}
							}
							this.ogYcQFJ9V9.moveSpeed = Mathf.Lerp(this.ogYcQFJ9V9.moveSpeed, this.ogYcQFJ9V9.runSpeed, (float)4 * Time.deltaTime);
							if (102277 - 203801 != -101524)
							{
								continue;
							}
						}
					}
				}
			}
			IL_35F:
			this.ghRc62G0je += mTime;
		}
		while (250791 - 431120 == -180328);
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0005028C File Offset: 0x0004E48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (14947 - 37220 != -22273)
		{
		}
		while (Time.time - this.KvFcJLV5NG > this.ghRc62G0je)
		{
			if (235268 - 483521 == -248253)
			{
				this.AI_state = "none";
				if (262657 - 112544 == 150113)
				{
					this.KvFcJLV5NG = Time.time;
					if (112745 - 342520 == -229775)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00050340 File Offset: 0x0004E540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (33638 - 596071 != -562433)
		{
		}
		for (;;)
		{
			IL_133:
			if (this.yhsctSGlcW + (float)1 > Time.time)
			{
				if (72333 - 306274 != -233940)
				{
					break;
				}
			}
			else
			{
				this.yhsctSGlcW = Time.time;
				if (19512 - 539858 == -520346)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (192540 - 304057 != -111516)
					{
						if (79336 - 334084 == -254748)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (195486 - 295455 == -99969)
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
									if (240805 - 558308 != -317503)
									{
										goto IL_133;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (162364 - 376832 != -214468)
									{
										goto IL_133;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (22544 - 567005 != -544461)
									{
										goto IL_133;
									}
									bool flag = true;
									if (212708 - 151503 == 61206)
									{
										goto IL_133;
									}
									eRace race = this.ogYcQFJ9V9.Race;
									if (78589 - 525470 != -446881)
									{
										goto IL_133;
									}
									if (race == eRace.Tails)
									{
										if (71593 - 599815 != -528222)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5FC;
										}
										if (290789 - 286338 != 4451)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (76979 - 356870 != -279891)
											{
												goto IL_133;
											}
											goto IL_5FC;
										}
										goto IL_19D;
										IL_5FC:
										flag = false;
										if (205496 - 256705 != -51209)
										{
											goto IL_133;
										}
									}
									else if (race == eRace.Plants)
									{
										if (79175 - 127285 != -48110)
										{
											goto IL_133;
										}
										flag = false;
										if (142759 - 439427 == -296667)
										{
											goto IL_133;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (40303 - 470338 != -430035)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1E3;
										}
										if (103904 - 210380 != -106476)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (246534 - 510689 != -264155)
											{
												goto IL_133;
											}
											goto IL_1E3;
										}
										goto IL_19D;
										IL_1E3:
										flag = false;
										if (147709 - 408913 != -261204)
										{
											goto IL_133;
										}
									}
									else if (race == eRace.Robots)
									{
										if (147517 - 220357 == -72839)
										{
											goto IL_133;
										}
										flag = true;
										if (23123 - 231038 == -207914)
										{
											goto IL_133;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (293355 - 117784 == 175572)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_160;
										}
										if (91312 - 49898 != 41414)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_160;
										}
										if (239771 - 517864 == -278092)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (175769 - 337093 != -161324)
											{
												goto IL_133;
											}
											goto IL_160;
										}
										goto IL_19D;
										IL_160:
										flag = false;
										if (3969 - 291284 != -287315)
										{
											goto IL_133;
										}
									}
									else if (race == eRace.Structure)
									{
										if (21667 - 20232 == 1436)
										{
											goto IL_133;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (284276 - 24969 == 259308)
											{
												goto IL_133;
											}
											flag = false;
											if (287112 - 411361 == -124248)
											{
												goto IL_133;
											}
										}
									}
									IL_19D:
									if (flag)
									{
										if (75678 - 418306 != -342628)
										{
											goto IL_133;
										}
										if (characterControl.hp > 0)
										{
											if (260109 - 141778 == 118332)
											{
												goto IL_133;
											}
											if (characterControl.recieveTarget)
											{
												if (15641 - 290745 == -275103)
												{
													goto IL_133;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (152739 - 172152 != -19413)
													{
														goto IL_133;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (138956 - 153920 == -14963)
														{
															goto IL_133;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (206553 - 210988 != -4435)
														{
															goto IL_133;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (35247 - 444745 == -409497)
															{
																goto IL_133;
															}
															this.ogYcQFJ9V9.isAlert = true;
															if (50642 - 348410 != -297768)
															{
																goto IL_133;
															}
															this.KvFcJLV5NG = Time.time;
															if (277352 - 265738 == 11615)
															{
																goto IL_133;
															}
															this.ogYcQFJ9V9.myAttackTarget = gameObject;
															if (52576 - 385695 != -333119)
															{
																goto IL_133;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (31710 - 514179 != -482469)
															{
																goto IL_133;
															}
															this.ogYcQFJ9V9.addHate(characterControl.ActorNr, 5);
															if (17883 - 258828 != -240945)
															{
																goto IL_133;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (26426 - 28317 != -1891)
															{
																goto IL_133;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (221803 - 456980 == -235176)
															{
																goto IL_133;
															}
															if (num < (float)60)
															{
																if (88864 - 509940 == -421075)
																{
																	goto IL_133;
																}
																if (characterControl.hp > 0)
																{
																	if (160425 - 234582 != -74157)
																	{
																		goto IL_133;
																	}
																	this.ogYcQFJ9V9.isAlert = true;
																	if (149670 - 520292 == -370621)
																	{
																		goto IL_133;
																	}
																	this.KvFcJLV5NG = Time.time;
																	if (150013 - 147420 == 2594)
																	{
																		goto IL_133;
																	}
																	this.ogYcQFJ9V9.myAttackTarget = gameObject;
																	if (126710 - 589663 == -462952)
																	{
																		goto IL_133;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (239403 - 379467 != -140064)
																	{
																		goto IL_133;
																	}
																	this.ogYcQFJ9V9.addHate(characterControl.ActorNr, 5);
																	if (5950 - 362672 != -356722)
																	{
																		goto IL_133;
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
								if (137011 - 562098 != -425086)
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

	// Token: 0x06000315 RID: 789 RVA: 0x00050B68 File Offset: 0x0004ED68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00050B6C File Offset: 0x0004ED6C
	internal static bool rkygH3tdyrN8Ny5jIpG()
	{
		return true;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00050B70 File Offset: 0x0004ED70
	internal static bool wjuAt8tJwLjshHYgvjp()
	{
		return false;
	}

	// Token: 0x04000305 RID: 773
	private CharacterControl ogYcQFJ9V9;

	// Token: 0x04000306 RID: 774
	private GiantSandBug LubcePlIg2;

	// Token: 0x04000307 RID: 775
	private ParticleEmitter KCrcIgeCkH;

	// Token: 0x04000308 RID: 776
	public string AI_state;

	// Token: 0x04000309 RID: 777
	private float KvFcJLV5NG;

	// Token: 0x0400030A RID: 778
	private float ghRc62G0je;

	// Token: 0x0400030B RID: 779
	private float yhsctSGlcW;
}
