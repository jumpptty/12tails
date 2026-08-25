using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200064D RID: 1613
[Serializable]
public class Mole_mine : MonoBehaviour
{
	// Token: 0x06002452 RID: 9298 RVA: 0x00447C80 File Offset: 0x00445E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_mine()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x00447C90 File Offset: 0x00445E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.aAEbkVCf9W;
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x00447C98 File Offset: 0x00445E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nID, int nOwnerID)
	{
		if (100942 - 278871 != -177929)
		{
		}
		for (;;)
		{
			IL_269:
			this.aAEbkVCf9W = nID;
			if (274024 - 392054 == -118030)
			{
				this.S9sbFkm2f3 = nOwnerID;
				if (135326 - 128152 != 7175)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.S9sbFkm2f3];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.ls2buOyGlC = (GameObject)obj2;
					if (247623 - 273854 == -26231)
					{
						this.Eg7bAWufsc = this.ls2buOyGlC.layer;
						if (208182 - 42298 != 165885)
						{
							this.lwlbygsWTr = (CharacterControl)this.ls2buOyGlC.GetComponent(typeof(CharacterControl));
							if (276027 - 248844 == 27183)
							{
								this.aO9boyDZyA = (int)((float)this.lwlbygsWTr.chaAdjust(60) + Time.time);
								if (8567 - 422793 != -414225)
								{
									if (Game.mPlayer)
									{
										if (153618 - 584408 != -430790)
										{
											continue;
										}
										if (Game.mPlayer.layer != this.ls2buOyGlC.layer)
										{
											if (151806 - 428089 == -276282)
											{
												continue;
											}
											Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
											if (182875 - 168767 != 14108)
											{
												continue;
											}
											int i = 0;
											if (222544 - 181631 != 40913)
											{
												continue;
											}
											Component[] array = componentsInChildren;
											if (249682 - 199596 == 50087)
											{
												continue;
											}
											int length = array.Length;
											if (111765 - 24599 != 87166)
											{
												continue;
											}
											while (i < length)
											{
												((Renderer)array[i]).enabled = false;
												if (204476 - 30813 == 173664)
												{
													goto IL_269;
												}
												i++;
												if (188085 - 551840 != -363755)
												{
													goto IL_269;
												}
											}
											if (291131 - 390236 != -99105)
											{
												continue;
											}
										}
									}
									this.ByLb9kLKhM = true;
									if (184920 - 41321 == 143599)
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

	// Token: 0x06002455 RID: 9301 RVA: 0x00447F78 File Offset: 0x00446178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (102851 - 382803 != -279952)
		{
		}
		for (;;)
		{
			if (!this.ByLb9kLKhM)
			{
				if (153412 - 576467 != -423054)
				{
					break;
				}
			}
			else
			{
				if ((float)this.aO9boyDZyA <= Time.time)
				{
					if (257434 - 42698 != 214736)
					{
						continue;
					}
					if (!this.qRBbWp2vJs)
					{
						if (252636 - 240779 == 11858)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (76267 - 143565 != -67298)
						{
							continue;
						}
						break;
					}
				}
				if (!this.ls2buOyGlC)
				{
					if (42711 - 455036 == -412325)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (42704 - 342665 == -299961)
						{
							break;
						}
					}
				}
				else if (!this.lwlbygsWTr)
				{
					if (267867 - 166402 != 101466)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (224204 - 584730 != -360525)
						{
							break;
						}
					}
				}
				else
				{
					if (this.lwlbygsWTr.hp > 0)
					{
						break;
					}
					if (252609 - 589685 != -337075)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (114614 - 480539 == -365925)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x0044814C File Offset: 0x0044634C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnTriggerEnter(Collider mCollider)
	{
		return new Mole_mine.$OnTriggerEnter$23393(mCollider, this).GetEnumerator();
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x0044815C File Offset: 0x0044635C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x00448160 File Offset: 0x00446360
	internal static bool apsAbvB5vdjCbKxWonE()
	{
		return true;
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x00448164 File Offset: 0x00446364
	internal static bool jtjr87Bpy6Yn6o1TEKp()
	{
		return false;
	}

	// Token: 0x04002759 RID: 10073
	private int aO9boyDZyA;

	// Token: 0x0400275A RID: 10074
	private int aAEbkVCf9W;

	// Token: 0x0400275B RID: 10075
	public int mLv;

	// Token: 0x0400275C RID: 10076
	private int S9sbFkm2f3;

	// Token: 0x0400275D RID: 10077
	private int Eg7bAWufsc;

	// Token: 0x0400275E RID: 10078
	private bool ByLb9kLKhM;

	// Token: 0x0400275F RID: 10079
	private bool qRBbWp2vJs;

	// Token: 0x04002760 RID: 10080
	private GameObject ls2buOyGlC;

	// Token: 0x04002761 RID: 10081
	private CharacterControl lwlbygsWTr;

	// Token: 0x0200064E RID: 1614
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnTriggerEnter$23393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600245A RID: 9306 RVA: 0x00448168 File Offset: 0x00446368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnTriggerEnter$23393(Collider mCollider, Mole_mine self_)
		{
			if (201491 - 107075 != 94416)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1888 - 97458 == -95570)
				{
					base..ctor();
					if (284137 - 56084 != 228054)
					{
						this.$mCollider$23398 = mCollider;
						if (284064 - 427862 == -143798)
						{
							this.$self_$23399 = self_;
							if (123632 - 412437 == -288805)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00448224 File Offset: 0x00446424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_mine.$OnTriggerEnter$23393.$(this.$mCollider$23398, this.$self_$23399);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00448238 File Offset: 0x00446438
		internal static bool yqGdAqBVfuoHUqLTxQV()
		{
			return true;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0044823C File Offset: 0x0044643C
		internal static bool xnkKHJBtI9Xl5domVYJ()
		{
			return false;
		}

		// Token: 0x04002762 RID: 10082
		internal Collider $mCollider$23398;

		// Token: 0x04002763 RID: 10083
		internal Mole_mine $self_$23399;

		// Token: 0x0200064F RID: 1615
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600245E RID: 9310 RVA: 0x00448240 File Offset: 0x00446440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Collider mCollider, Mole_mine self_)
			{
				if (44816 - 41102 != 3714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (234541 - 67811 != 166731)
					{
						base..ctor();
						if (31611 - 563081 != -531469)
						{
							this.$mCollider$23396 = mCollider;
							if (97002 - 311580 == -214578)
							{
								this.$self_$23397 = self_;
								if (128601 - 31147 == 97454)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600245F RID: 9311 RVA: 0x004482FC File Offset: 0x004464FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68568 - 156096 != -87527)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_239;
					case 1:
						goto IL_4FE;
					case 2:
						this.$mMoleScript$23395 = (Mole)this.$self_$23397.ls2buOyGlC.GetComponent(typeof(Mole));
						if (187776 - 570907 != -383131)
						{
							continue;
						}
						if (this.$mMoleScript$23395)
						{
							if (69888 - 284842 == -214953)
							{
								continue;
							}
							this.$mMoleScript$23395.RPC_mine_hit(this.$self_$23397.transform.position, Vector3.zero, this.$self_$23397.aAEbkVCf9W, this.$self_$23397.mLv);
							if (274181 - 469327 == -195145)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (221895 - 548487 != -326592)
								{
									continue;
								}
								this.$mMoleScript$23395.ActionEvent("RPC_mine_hit" + this.$self_$23397.mLv, this.$self_$23397.transform.position, Vector3.zero, this.$self_$23397.aAEbkVCf9W);
								if (141300 - 28039 != 113261)
								{
									continue;
								}
							}
							if (this.$mMoleScript$23395.getSmartShellLv() == 1)
							{
								if (215219 - 194059 != 21160)
								{
									continue;
								}
								this.$mMoleScript$23395.RPC_smartShell_hit(this.$self_$23397.transform.position, Vector3.zero, this.$self_$23397.aAEbkVCf9W);
								if (51313 - 389394 != -338081)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (158728 - 527311 != -368583)
									{
										continue;
									}
									this.$mMoleScript$23395.ActionEvent("RPC_smartShell_hit", this.$self_$23397.transform.position, Vector3.zero, this.$self_$23397.aAEbkVCf9W);
									if (214002 - 386917 == -172914)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Cannot find MoleScript");
							if (48570 - 269196 != -220626)
							{
								continue;
							}
						}
						break;
					default:
						if (171448 - 449164 != -277715)
						{
							goto IL_239;
						}
						continue;
					}
					IL_1B8:
					this.YieldDefault(1);
					if (286110 - 186021 != 100090)
					{
						break;
					}
					continue;
					IL_239:
					if (!this.$self_$23397.ByLb9kLKhM)
					{
						break;
					}
					if (39518 - 509399 != -469880)
					{
						if (this.$self_$23397.qRBbWp2vJs)
						{
							if (218670 - 196678 != 21993)
							{
								break;
							}
						}
						else
						{
							if (this.$self_$23397.ls2buOyGlC)
							{
								if (83530 - 124251 == -40720)
								{
									continue;
								}
								if (!this.$self_$23397.lwlbygsWTr)
								{
									if (277967 - 356063 == -78095)
									{
										continue;
									}
								}
								else if (!this.$self_$23397.lwlbygsWTr.isMine)
								{
									if (112976 - 6390 != 106587)
									{
										break;
									}
									continue;
								}
								else
								{
									this.$mCollideObject$23394 = this.$mCollider$23396.gameObject;
									if (1413 - 224969 == -223555)
									{
										continue;
									}
									if (!(this.$mCollideObject$23394.tag == "Player"))
									{
										if (68204 - 370825 != -302621)
										{
											continue;
										}
										if (!(this.$mCollideObject$23394.tag == "Enemy"))
										{
											goto IL_1B8;
										}
										if (31885 - 444836 == -412950)
										{
											continue;
										}
									}
									if (this.$mCollideObject$23394.layer == this.$self_$23397.Eg7bAWufsc)
									{
										goto IL_1B8;
									}
									if (163457 - 144712 != 18745)
									{
										continue;
									}
									if (this.$mCollideObject$23394.layer <= 2)
									{
										if (297414 - 394692 != -97278)
										{
											continue;
										}
										break;
									}
									else
									{
										this.$self_$23397.qRBbWp2vJs = true;
										if (166971 - 100415 != 66557)
										{
											goto Block_9;
										}
										continue;
									}
								}
							}
							UnityEngine.Object.Destroy(this.$self_$23397.gameObject);
							if (233444 - 420078 == -186634)
							{
								break;
							}
						}
					}
				}
				goto IL_4FE;
				Block_9:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4FE:
				return false;
			}

			// Token: 0x06002460 RID: 9312 RVA: 0x0044881C File Offset: 0x00446A1C
			internal static bool GMTnhcBNwkNXVRk8EHU()
			{
				return true;
			}

			// Token: 0x06002461 RID: 9313 RVA: 0x00448820 File Offset: 0x00446A20
			internal static bool WlBBUeBY7DiU5G0vBas()
			{
				return false;
			}

			// Token: 0x04002764 RID: 10084
			internal GameObject $mCollideObject$23394;

			// Token: 0x04002765 RID: 10085
			internal Mole $mMoleScript$23395;

			// Token: 0x04002766 RID: 10086
			internal Collider $mCollider$23396;

			// Token: 0x04002767 RID: 10087
			internal Mole_mine $self_$23397;
		}
	}
}
