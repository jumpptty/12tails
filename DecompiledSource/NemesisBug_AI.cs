using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200011C RID: 284
[Serializable]
public class NemesisBug_AI : MonoBehaviour
{
	// Token: 0x06000648 RID: 1608 RVA: 0x000A53B8 File Offset: 0x000A35B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NemesisBug_AI()
	{
		if (191062 - 56537 != 134526)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (241000 - 148027 != 92974)
			{
				base..ctor();
				if (270564 - 40338 == 230226)
				{
					this.AI_state = "none";
					if (171729 - 282113 != -110383)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000A5454 File Offset: 0x000A3654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (50606 - 93605 != -42998)
		{
		}
		for (;;)
		{
			this.gI7npUOr8R = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (167037 - 519390 == -352353)
			{
				GameObject gameObject = global::Math.findChildObject(this.transform, "head").gameObject;
				if (225766 - 1237 != 224530)
				{
					if (gameObject)
					{
						if (165375 - 277979 == -112603)
						{
							continue;
						}
						this.DEbnRowPnM = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (263954 - 364711 == -100756)
						{
							continue;
						}
					}
					GameObject gameObject2 = global::Math.findChildObject(this.transform, "bodyArmor").gameObject;
					if (292009 - 572803 != -280793)
					{
						if (gameObject2)
						{
							if (261784 - 198012 != 63772)
							{
								continue;
							}
							this.Pg9nrKuLT2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (135078 - 414913 != -279835)
							{
								continue;
							}
						}
						this.rDKnxfVIMi = (NemesisBug)this.GetComponent(typeof(NemesisBug));
						if (199566 - 585126 != -385559)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000A560C File Offset: 0x000A380C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (7278 - 396654 != -389375)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (260459 - 279996 != -19537)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (69493 - 578090 == -508596)
				{
					continue;
				}
			}
			if (this.gI7npUOr8R.isControlled)
			{
				break;
			}
			if (57959 - 233114 != -175154)
			{
				this.AIControl();
				if (227393 - 206463 == 20930)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000A56D8 File Offset: 0x000A38D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (95569 - 209425 != -113856)
		{
		}
		for (;;)
		{
			this.JDqnYAqKk2 = (float)0;
			if (62488 - 19734 != 42755)
			{
				if (this.gI7npUOr8R.isMine)
				{
					if (165896 - 111501 == 54395)
					{
						if (this.gI7npUOr8R.actionState != "standby")
						{
							if (138557 - 295589 == -157031)
							{
								continue;
							}
							if (this.gI7npUOr8R.actionState != "run")
							{
								if (213841 - 81027 != 132814)
								{
									continue;
								}
								break;
							}
						}
						if (!this.gI7npUOr8R.isAlert)
						{
							if (182504 - 598438 != -415934)
							{
								continue;
							}
							this.AI_idle(6f, 3f);
							if (89168 - 119512 == -30343)
							{
								continue;
							}
							this.AI_resetTimer();
							if (152431 - 280922 == -128490)
							{
								continue;
							}
							this.AI_visionCheck();
							if (37042 - 11149 != 25893)
							{
								continue;
							}
							if (this.gI7npUOr8R.myAttackTarget)
							{
								if (153675 - 294004 != -140329)
								{
									continue;
								}
								this.gI7npUOr8R.isAlert = true;
								if (266050 - 277587 == -11536)
								{
									continue;
								}
								this.ILynTxBfW1 = Time.time;
								if (110171 - 302614 != -192443)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (54750 - 253071 != -198321)
							{
								continue;
							}
							this.AI_idle(2f, 1f);
							if (205498 - 159999 == 45500)
							{
								continue;
							}
							this.AI_attack(10f, (float)0);
							if (6290 - 276513 != -270223)
							{
								continue;
							}
							this.AI_resetTimer();
							if (34644 - 545288 == -510643)
							{
								continue;
							}
						}
						if (this.vvXn3kIroe >= Time.time)
						{
							break;
						}
						if (198275 - 124068 != 74208)
						{
							this.vvXn3kIroe = Time.time + 1f;
							if (251342 - 562519 == -311177)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (154540 - 302778 == -148238)
								{
									this.rDKnxfVIMi.ActionEvent("RPC_turn", this.transform.position, this.transform.forward, 0);
									if (248959 - 394273 != -145313)
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
					if (this.gI7npUOr8R.actionState != "standby")
					{
						if (114483 - 87816 == 26668)
						{
							continue;
						}
						if (this.gI7npUOr8R.actionState != "run")
						{
							if (221060 - 202907 != 18154)
							{
								break;
							}
							continue;
						}
					}
					this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, this.rDKnxfVIMi.mNetworkRotation, 0.1f));
					if (110763 - 584878 == -474115)
					{
						this.animation.CrossFade("root", 0.2f);
						if (97247 - 94567 != 2681)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (61229 - 317094 == -255865)
							{
								this.gI7npUOr8R.moveSpeed = (float)0;
								if (71120 - 577574 != -506453)
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

	// Token: 0x0600064C RID: 1612 RVA: 0x000A5B68 File Offset: 0x000A3D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (68918 - 32075 != 36843)
		{
		}
		do
		{
			if (Time.time - this.ILynTxBfW1 >= this.JDqnYAqKk2)
			{
				if (150684 - 451983 != -301299)
				{
					continue;
				}
				if (Time.time - this.ILynTxBfW1 < this.JDqnYAqKk2 + mTime)
				{
					if (36815 - 120931 != -84116)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (176341 - 512193 == -335851)
						{
							continue;
						}
						this.AI_state = "idle";
						if (141575 - 144555 == -2979)
						{
							continue;
						}
						this.ILynTxBfW1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (68890 - 149752 != -80862)
						{
							continue;
						}
						this.gI7npUOr8R.vDirection = Vector3.zero;
						if (133956 - 7014 == 126943)
						{
							continue;
						}
						this.gI7npUOr8R.vMovement = this.transform.forward;
						if (41995 - 100650 == -58654)
						{
							continue;
						}
						this.gI7npUOr8R.actionState = "standby";
						if (102143 - 463214 != -361071)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (275867 - 563056 == -287188)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (129146 - 462188 == -333041)
					{
						continue;
					}
					this.gI7npUOr8R.moveSpeed = (float)0;
					if (147164 - 426695 != -279531)
					{
						continue;
					}
				}
			}
			this.JDqnYAqKk2 += mTime;
		}
		while (34307 - 459647 != -425340);
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000A5DB0 File Offset: 0x000A3FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (241512 - 68252 != 173261)
		{
		}
		do
		{
			if (Time.time - this.ILynTxBfW1 >= this.JDqnYAqKk2)
			{
				if (28041 - 227182 == -199140)
				{
					continue;
				}
				if (Time.time - this.ILynTxBfW1 < this.JDqnYAqKk2 + mTime)
				{
					if (57091 - 174976 != -117885)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (112505 - 560556 == -448050)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (247991 - 439282 != -191291)
						{
							continue;
						}
						this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
						if (176929 - 413466 == -236536)
						{
							continue;
						}
						this.gI7npUOr8R.vDirection = Vector3.zero;
						if (165744 - 481869 == -316124)
						{
							continue;
						}
						this.gI7npUOr8R.vMovement = this.transform.forward;
						if (131573 - 318509 == -186935)
						{
							continue;
						}
						this.gI7npUOr8R.actionState = "standby";
						if (124369 - 111132 != 13237)
						{
							continue;
						}
						this.gI7npUOr8R.myAttackTarget = this.gI7npUOr8R.getHateTarget(5, 80);
						if (281077 - 331823 != -50746)
						{
							continue;
						}
						if (!this.gI7npUOr8R.myAttackTarget)
						{
							if (29986 - 92886 != -62900)
							{
								continue;
							}
							this.gI7npUOr8R.isAlert = false;
							if (72198 - 341628 == -269429)
							{
								continue;
							}
							this.ILynTxBfW1 = Time.time;
							if (228975 - 76178 != 152797)
							{
								continue;
							}
							this.gI7npUOr8R.myAttackTarget = null;
							if (100662 - 424462 != -323800)
							{
								continue;
							}
							this.gI7npUOr8R.mOriginalPosition = this.transform.position;
							if (64202 - 196155 != -131953)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.gI7npUOr8R.myAttackTarget;
							if (248664 - 395913 == -147248)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (166575 - 504832 == -338256)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (40700 - 313299 == -272598)
								{
									continue;
								}
								this.gI7npUOr8R.isAlert = false;
								if (152051 - 290395 == -138343)
								{
									continue;
								}
								this.ILynTxBfW1 = Time.time;
								if (156422 - 10579 != 145843)
								{
									continue;
								}
								this.gI7npUOr8R.myAttackTarget = null;
								if (92426 - 67240 == 25187)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JDqnYAqKk2 += mTime;
		}
		while (207063 - 20150 == 186914);
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000A6170 File Offset: 0x000A4370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (171726 - 168052 != 3675)
		{
		}
		do
		{
			if (Time.time - this.ILynTxBfW1 >= this.JDqnYAqKk2)
			{
				if (210217 - 264994 != -54777)
				{
					continue;
				}
				if (Time.time - this.ILynTxBfW1 < this.JDqnYAqKk2 + mTime)
				{
					if (109834 - 586924 != -477090)
					{
						continue;
					}
					if (!this.gI7npUOr8R.myAttackTarget)
					{
						if (76057 - 496810 == -420752)
						{
							continue;
						}
						this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
						if (183426 - 535716 != -352289)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.gI7npUOr8R.myAttackTarget;
						if (247921 - 296096 != -48175)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (268463 - 179999 == 88465)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (41770 - 269810 != -228040)
						{
							continue;
						}
						int tID = 0;
						if (236806 - 486925 == -250118)
						{
							continue;
						}
						if (characterControl)
						{
							if (73494 - 259847 == -186352)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (280708 - 244320 != 36388)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (201261 - 21150 != 180111)
						{
							continue;
						}
						if ((float)(this.DEbnRowPnM.hp + this.Pg9nrKuLT2.hp) < 0.5f * (float)(this.DEbnRowPnM.mhp + this.Pg9nrKuLT2.mhp))
						{
							if (77150 - 58980 != 18170)
							{
								continue;
							}
							if (this.gI7npUOr8R.isTimeOut("chaosRay") == (float)0)
							{
								if (87666 - 392127 == -304460)
								{
									continue;
								}
								this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
								if (286626 - 470671 != -184045)
								{
									continue;
								}
								this.rDKnxfVIMi.StartCoroutine_Auto(this.rDKnxfVIMi.RPC_chaosRay(this.transform.position + this.transform.forward, vector, tID));
								if (24731 - 192701 != -167969)
								{
									if (PhotonClient.IsInitialized())
									{
										if (105708 - 361643 == -255934)
										{
											continue;
										}
										this.rDKnxfVIMi.ActionEvent("RPC_chaosRay", this.transform.position + this.transform.forward, vector, tID);
										if (88474 - 420805 == -332330)
										{
											continue;
										}
									}
									goto IL_FD;
								}
								continue;
							}
						}
						if ((float)(this.DEbnRowPnM.hp + this.Pg9nrKuLT2.hp) < 0.8f * (float)(this.DEbnRowPnM.mhp + this.Pg9nrKuLT2.mhp))
						{
							if (41248 - 345447 == -304198)
							{
								continue;
							}
							if (this.gI7npUOr8R.isTimeOut("nemesisLarva") == (float)0)
							{
								if (192249 - 39550 == 152700)
								{
									continue;
								}
								this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
								if (283702 - 138193 != 145509)
								{
									continue;
								}
								this.rDKnxfVIMi.StartCoroutine_Auto(this.rDKnxfVIMi.RPC_nemesisLarva(this.transform.position + this.transform.forward, vector, tID));
								if (229814 - 327066 != -97252)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (165331 - 353056 == -187724)
									{
										continue;
									}
									this.rDKnxfVIMi.ActionEvent("RPC_nemesisLarva", this.transform.position + this.transform.forward, vector, tID);
									if (100286 - 265726 == -165439)
									{
										continue;
									}
								}
								goto IL_FD;
							}
						}
						if (this.gI7npUOr8R.isTimeOut("genesisSeed") == (float)0)
						{
							if (92803 - 313765 != -220962)
							{
								continue;
							}
							this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
							if (159329 - 158385 != 944)
							{
								continue;
							}
							this.rDKnxfVIMi.StartCoroutine_Auto(this.rDKnxfVIMi.RPC_genesisSeed(this.transform.position + this.transform.forward, vector, tID));
							if (146357 - 201247 == -54889)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (72717 - 228846 != -156129)
								{
									continue;
								}
								this.rDKnxfVIMi.ActionEvent("RPC_genesisSeed", this.transform.position + this.transform.forward, vector, tID);
								if (192207 - 562573 != -370366)
								{
									continue;
								}
							}
						}
						else if (this.gI7npUOr8R.isTimeOut("cAttack") == (float)0)
						{
							if (91395 - 475597 != -384202)
							{
								continue;
							}
							this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
							if (218816 - 60714 == 158103)
							{
								continue;
							}
							this.rDKnxfVIMi.StartCoroutine_Auto(this.rDKnxfVIMi.RPC_cAttack(this.transform.position + this.transform.forward, vector, tID));
							if (74803 - 185371 != -110568)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (163228 - 68946 == 94283)
								{
									continue;
								}
								this.rDKnxfVIMi.ActionEvent("RPC_cAttack", this.transform.position + this.transform.forward, vector, tID);
								if (263557 - 88806 != 174751)
								{
									continue;
								}
							}
						}
						else if (this.gI7npUOr8R.isTimeOut("nAttack") == (float)0)
						{
							if (259518 - 23653 == 235866)
							{
								continue;
							}
							this.ILynTxBfW1 = Time.time - mTime - this.JDqnYAqKk2;
							if (75607 - 133089 == -57481)
							{
								continue;
							}
							this.rDKnxfVIMi.StartCoroutine_Auto(this.rDKnxfVIMi.RPC_nAttack(this.transform.position + this.transform.forward, vector, tID));
							if (24668 - 263648 != -238980)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (183271 - 562114 == -378842)
								{
									continue;
								}
								this.rDKnxfVIMi.ActionEvent("RPC_nAttack", this.transform.position + this.transform.forward, vector, tID);
								if (207511 - 33404 == 174108)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (255523 - 579382 == -323858)
							{
								continue;
							}
							this.gI7npUOr8R.vMovement = Vector3.RotateTowards(this.transform.forward, (myAttackTarget.transform.position - this.transform.position).normalized, 0.1f * Time.deltaTime, 0.1f);
							if (24492 - 340057 != -315565)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.gI7npUOr8R.vMovement);
							if (136493 - 193207 != -56714)
							{
								continue;
							}
							this.gI7npUOr8R.actionState = "standby";
							if (238416 - 268857 == -30440)
							{
								continue;
							}
							this.animation.Play("root");
							if (92149 - 46760 == 45390)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (85111 - 47790 != 37321)
							{
								continue;
							}
						}
					}
				}
			}
			IL_FD:
			this.JDqnYAqKk2 += mTime;
		}
		while (251100 - 357831 != -106731);
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000A6B40 File Offset: 0x000A4D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (264272 - 466240 != -201968)
		{
		}
		while (Time.time - this.ILynTxBfW1 > this.JDqnYAqKk2)
		{
			if (116984 - 363415 == -246431)
			{
				this.AI_state = "none";
				if (119677 - 357336 != -237658)
				{
					this.ILynTxBfW1 = Time.time;
					if (145067 - 531912 != -386844)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000A6BF4 File Offset: 0x000A4DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (128207 - 473160 != -344953)
		{
		}
		for (;;)
		{
			IL_45F:
			if (this.ogrnbZCgbb > Time.time)
			{
				if (43129 - 269178 != -226048)
				{
					break;
				}
			}
			else
			{
				this.ogrnbZCgbb = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (49399 - 232574 == -183175)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)80, this.gameObject.layer);
					if (34664 - 31083 == 3581)
					{
						if (259057 - 233888 == 25169)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (11968 - 395207 != -383238)
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
									if (68689 - 306269 != -237580)
									{
										goto IL_45F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (50863 - 593140 != -542277)
									{
										goto IL_45F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (164087 - 368489 == -204401)
									{
										goto IL_45F;
									}
									bool flag = true;
									if (259949 - 287515 != -27566)
									{
										goto IL_45F;
									}
									eRace race = this.gI7npUOr8R.Race;
									if (281124 - 384746 == -103621)
									{
										goto IL_45F;
									}
									if (race == eRace.Tails)
									{
										if (35984 - 500005 != -464021)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_443;
										}
										if (175271 - 106100 == 69172)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (160838 - 358722 != -197883)
											{
												goto IL_443;
											}
											goto IL_45F;
										}
										goto IL_423;
										IL_443:
										flag = false;
										if (106803 - 110570 != -3767)
										{
											goto IL_45F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (214867 - 562869 != -348002)
										{
											goto IL_45F;
										}
										flag = false;
										if (195421 - 458305 != -262884)
										{
											goto IL_45F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (42756 - 340938 == -298181)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_402;
										}
										if (14701 - 476766 == -462064)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (280237 - 446675 != -166438)
											{
												goto IL_45F;
											}
											goto IL_402;
										}
										goto IL_423;
										IL_402:
										flag = false;
										if (235866 - 120435 == 115432)
										{
											goto IL_45F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (35182 - 584194 == -549011)
										{
											goto IL_45F;
										}
										flag = true;
										if (227513 - 566827 != -339314)
										{
											goto IL_45F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (36861 - 589071 == -552209)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1F0;
										}
										if (258129 - 229119 != 29010)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1F0;
										}
										if (164363 - 290103 == -125739)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (211809 - 123339 != 88471)
											{
												goto IL_1F0;
											}
											goto IL_45F;
										}
										goto IL_423;
										IL_1F0:
										flag = false;
										if (52638 - 253177 == -200538)
										{
											goto IL_45F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (3032 - 277165 == -274132)
										{
											goto IL_45F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (293744 - 182298 == 111447)
											{
												goto IL_45F;
											}
											flag = false;
											if (18331 - 434045 == -415713)
											{
												goto IL_45F;
											}
										}
									}
									IL_423:
									if (flag)
									{
										if (174591 - 435040 != -260449)
										{
											goto IL_45F;
										}
										if (characterControl.hp > 0)
										{
											if (215011 - 591102 != -376091)
											{
												goto IL_45F;
											}
											if (characterControl.recieveTarget)
											{
												if (78695 - 87163 != -8468)
												{
													goto IL_45F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (170963 - 547797 == -376833)
													{
														goto IL_45F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (197230 - 87786 == 109445)
														{
															goto IL_45F;
														}
														this.gI7npUOr8R.myAttackTarget = gameObject;
														if (99784 - 339315 == -239530)
														{
															goto IL_45F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (182313 - 598168 == -415854)
														{
															goto IL_45F;
														}
														this.gI7npUOr8R.addHate(characterControl.ActorNr, 60);
														if (82990 - 177763 == -94772)
														{
															goto IL_45F;
														}
														if (this.gI7npUOr8R.myAttackTarget)
														{
															if (10499 - 456535 == -446035)
															{
																goto IL_45F;
															}
															this.gI7npUOr8R.isAlert = true;
															if (35995 - 439381 == -403385)
															{
																goto IL_45F;
															}
															this.ILynTxBfW1 = Time.time;
															if (135515 - 502934 == -367418)
															{
																goto IL_45F;
															}
														}
													}
												}
											}
										}
									}
								}
								if (28144 - 272448 == -244304)
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

	// Token: 0x06000651 RID: 1617 RVA: 0x000A7280 File Offset: 0x000A5480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000A7284 File Offset: 0x000A5484
	internal static bool KAfIX8TToalG3Y4j0P5()
	{
		return true;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x000A7288 File Offset: 0x000A5488
	internal static bool i4L8fXT39MxGFNMaCSo()
	{
		return false;
	}

	// Token: 0x040005D2 RID: 1490
	private CharacterControl gI7npUOr8R;

	// Token: 0x040005D3 RID: 1491
	private CharacterControl DEbnRowPnM;

	// Token: 0x040005D4 RID: 1492
	private CharacterControl Pg9nrKuLT2;

	// Token: 0x040005D5 RID: 1493
	private NemesisBug rDKnxfVIMi;

	// Token: 0x040005D6 RID: 1494
	public string AI_state;

	// Token: 0x040005D7 RID: 1495
	private float ILynTxBfW1;

	// Token: 0x040005D8 RID: 1496
	private float JDqnYAqKk2;

	// Token: 0x040005D9 RID: 1497
	private float vvXn3kIroe;

	// Token: 0x040005DA RID: 1498
	private float ogrnbZCgbb;
}
