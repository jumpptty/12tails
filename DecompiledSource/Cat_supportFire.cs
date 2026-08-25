using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020005DA RID: 1498
[Serializable]
public class Cat_supportFire : MonoBehaviour
{
	// Token: 0x060021EF RID: 8687 RVA: 0x003E5188 File Offset: 0x003E3388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cat_supportFire()
	{
		if (241917 - 355401 != -113484)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (68674 - 323274 == -254600)
			{
				base..ctor();
				if (49681 - 454379 != -404697)
				{
					this.mVelocity = new Vector3((float)0, (float)0, (float)30);
					if (31190 - 51567 != -20376)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x003E522C File Offset: 0x003E342C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nOwnerID)
	{
		if (26433 - 16924 != 9510)
		{
		}
		for (;;)
		{
			this.huFTY1f1T6 = nOwnerID;
			if (49910 - 184771 == -134861)
			{
				this.u2PTTORycU = (float)10;
				if (1168 - 344648 == -343480)
				{
					this.gameObject.layer = 1;
					if (6318 - 598997 != -592678)
					{
						this.rigidbody.velocity = this.transform.TransformDirection(this.mVelocity);
						if (281089 - 471850 != -190760)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x003E5304 File Offset: 0x003E3504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (88345 - 534806 != -446461)
		{
		}
		for (;;)
		{
			this.u2PTTORycU -= Time.deltaTime;
			if (83571 - 54409 == 29162)
			{
				if (this.u2PTTORycU <= (float)0)
				{
					if (125060 - 396378 == -271318)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (201918 - 285331 != -83412)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (293147 - 134827 != 158321)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x003E53FC File Offset: 0x003E35FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (223132 - 489111 != -265979)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[this.huFTY1f1T6];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (206121 - 187708 != 18414)
			{
				if (!gameObject)
				{
					if (178116 - 59902 != 118215)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (9865 - 260556 == -250691)
					{
						if (!characterControl)
						{
							if (216309 - 546910 != -330600)
							{
								break;
							}
						}
						else
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								break;
							}
							if (273966 - 590269 == -316303)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (170593 - 145720 == 24873)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (117232 - 225305 != -108072)
									{
										if (characterControl.isMine)
										{
											if (161518 - 380811 == -219292)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (210227 - 365300 != -155073)
											{
												continue;
											}
											Cat cat = (Cat)gameObject.GetComponent(typeof(Cat));
											if (58642 - 392629 != -333987)
											{
												continue;
											}
											if (cat != null)
											{
												if (221798 - 506603 != -284805)
												{
													continue;
												}
												cat.RPC_supportFire_hit(vector, Vector3.zero, 0);
												if (233953 - 222607 == 11347)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (133005 - 397003 != -263998)
													{
														continue;
													}
													cat.ActionEvent("RPC_supportFire_hit", vector, Vector3.zero, 0);
													if (62638 - 434023 == -371384)
													{
														continue;
													}
												}
											}
											else
											{
												Debug.LogError("Cannot find Cat Script");
												if (298987 - 202184 == 96804)
												{
													continue;
												}
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (205112 - 161897 == 43215)
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

	// Token: 0x060021F3 RID: 8691 RVA: 0x003E5704 File Offset: 0x003E3904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x003E5708 File Offset: 0x003E3908
	internal static bool xEYYjd0yX6Bydcig9yy()
	{
		return true;
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x003E570C File Offset: 0x003E390C
	internal static bool aLovYE0SXDwtLr9Zv15()
	{
		return false;
	}

	// Token: 0x04002319 RID: 8985
	public Vector3 mVelocity;

	// Token: 0x0400231A RID: 8986
	private float u2PTTORycU;

	// Token: 0x0400231B RID: 8987
	private int huFTY1f1T6;
}
