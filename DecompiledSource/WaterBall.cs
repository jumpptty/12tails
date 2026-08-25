using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DFC RID: 3580
[Serializable]
public class WaterBall : MonoBehaviour
{
	// Token: 0x060050E8 RID: 20712 RVA: 0x009E9098 File Offset: 0x009E7298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterBall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060050E9 RID: 20713 RVA: 0x009E90A8 File Offset: 0x009E72A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
		this.rigidbody.velocity = this.transform.TransformDirection((float)0, (float)0, (float)24);
	}

	// Token: 0x060050EA RID: 20714 RVA: 0x009E90D4 File Offset: 0x009E72D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nOwnerID)
	{
		if (27393 - 435672 != -408279)
		{
		}
		for (;;)
		{
			this.NJUceJppCOx = nOwner;
			if (22568 - 11392 == 11176)
			{
				this.u2fce6Eigub = nOwnerID;
				if (116213 - 228421 == -112208)
				{
					this.PGPceXjDl9s = true;
					if (294271 - 451686 == -157415)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050EB RID: 20715 RVA: 0x009E9170 File Offset: 0x009E7370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (156935 - 420973 != -264037)
		{
		}
		for (;;)
		{
			this.fP2cet2DIdU += Time.deltaTime;
			if (107464 - 315144 == -207680)
			{
				if (this.fP2cet2DIdU < (float)3)
				{
					break;
				}
				if (92203 - 325329 == -233126)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (55282 - 40908 == 14374)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050EC RID: 20716 RVA: 0x009E9220 File Offset: 0x009E7420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (120130 - 346458 != -226328)
		{
		}
		for (;;)
		{
			IL_3DC:
			if (!this.PGPceXjDl9s)
			{
				if (264015 - 341992 == -77977)
				{
					break;
				}
			}
			else
			{
				if (!(mCollider.gameObject != this.NJUceJppCOx))
				{
					break;
				}
				if (144586 - 456296 == -311710)
				{
					if (mCollider.gameObject.layer == 1)
					{
						break;
					}
					if (102454 - 90551 != 11904)
					{
						if (mCollider.gameObject.layer == 2)
						{
							break;
						}
						if (294916 - 464956 == -170040)
						{
							if (Game.mGameType >= 5)
							{
								if (174085 - 82090 != 91995)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.u2fce6Eigub];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (232544 - 132656 != 99888)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (45128 - 228466 == -183337)
								{
									continue;
								}
								if (!characterControl)
								{
									if (23161 - 91585 != -68424)
									{
										continue;
									}
									break;
								}
								else if (characterControl.isMine)
								{
									if (151497 - 333946 != -182449)
									{
										continue;
									}
									int layerMask = 130816;
									if (191633 - 62748 == 128886)
									{
										continue;
									}
									UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(this.transform.position, (float)4, (float)3, layerMask);
									if (219749 - 111566 == 108184)
									{
										continue;
									}
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
									if (216152 - 86888 == 129265)
									{
										continue;
									}
									while (enumerator.MoveNext())
									{
										object obj4 = enumerator.Current;
										object obj6;
										object obj5 = obj6 = obj4;
										if (!(obj5 is GameObject))
										{
											obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
										}
										GameObject gameObject2 = (GameObject)obj6;
										if (221910 - 367559 != -145649)
										{
											goto IL_3DC;
										}
										CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (197560 - 594772 == -397211)
										{
											goto IL_3DC;
										}
										UnityRuntimeServices.Update(enumerator, gameObject2);
										if (267176 - 542611 != -275435)
										{
											goto IL_3DC;
										}
										if (characterControl2)
										{
											if (131947 - 295472 == -163524)
											{
												goto IL_3DC;
											}
											if (characterControl2.isPlayer)
											{
												if (281386 - 158738 != 122648)
												{
													goto IL_3DC;
												}
												characterControl2.RPC_AddStatus("wet", 1, 6, 0, characterControl.ActorNr);
												if (23520 - 24404 != -884)
												{
													goto IL_3DC;
												}
											}
											if (Game.mGameCode == 967)
											{
												if (83401 - 458652 != -375251)
												{
													goto IL_3DC;
												}
												Camera.main.SendMessage("onWaterBallHit", gameObject2.layer);
												if (12897 - 48691 != -35794)
												{
													goto IL_3DC;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (108201 - 217766 == -109564)
												{
													goto IL_3DC;
												}
											}
										}
									}
									if (241492 - 125661 == 115832)
									{
										continue;
									}
								}
							}
							GameObject gameObject3 = (GameObject)Resources.Load("GameAssets/Effects/Special/WaterBall_hit", typeof(GameObject));
							if (80549 - 66627 != 13923)
							{
								if (gameObject3)
								{
									if (206465 - 51103 != 155362)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(gameObject3, this.transform.position, Quaternion.identity);
									if (81480 - 331924 == -250443)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing WaterBall_hit effect");
									if (71903 - 161819 != -89916)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.gameObject);
								if (228647 - 84097 != 144551)
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

	// Token: 0x060050ED RID: 20717 RVA: 0x009E9708 File Offset: 0x009E7908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050EE RID: 20718 RVA: 0x009E970C File Offset: 0x009E790C
	internal static bool UnXqJb5em4XykOs9KObn()
	{
		return true;
	}

	// Token: 0x060050EF RID: 20719 RVA: 0x009E9710 File Offset: 0x009E7910
	internal static bool uvVL0Q5eFO9vI1rI4WY7()
	{
		return false;
	}

	// Token: 0x04005A72 RID: 23154
	private GameObject NJUceJppCOx;

	// Token: 0x04005A73 RID: 23155
	private int u2fce6Eigub;

	// Token: 0x04005A74 RID: 23156
	private float fP2cet2DIdU;

	// Token: 0x04005A75 RID: 23157
	private bool PGPceXjDl9s;
}
