using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C28 RID: 3112
[Serializable]
public class FirstWhale_javelin : MonoBehaviour
{
	// Token: 0x0600459E RID: 17822 RVA: 0x008B8F28 File Offset: 0x008B7128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FirstWhale_javelin()
	{
		if (30165 - 417155 != -386989)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (198909 - 219833 != -20923)
			{
				base..ctor();
				if (159993 - 456447 != -296453)
				{
					this.EX9KcqvsIO = new Vector3((float)0, (float)0, (float)24);
					if (69070 - 325387 == -256317)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x008B8FCC File Offset: 0x008B71CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (145109 - 417440 != -272331)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (117135 - 312568 == -195433)
			{
				this.L2IhKkgIN0 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (289656 - 116410 == 173246)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.EX9KcqvsIO);
					if (16703 - 369951 != -353247)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x008B9098 File Offset: 0x008B7298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.wPvhzNYt8a = nOwner;
		this.w3NK5Fac1p = (CharacterControl)this.wPvhzNYt8a.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x008B90C4 File Offset: 0x008B72C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (224359 - 147827 != 76533)
		{
		}
		for (;;)
		{
			this.oqZKnul4es += Time.deltaTime;
			if (64310 - 98207 == -33897)
			{
				if (this.oqZKnul4es >= this.L2IhKkgIN0.life)
				{
					if (216291 - 319840 == -103549)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (280780 - 511257 == -230477)
						{
							break;
						}
					}
				}
				else if (!this.soWKeyHnbl)
				{
					if (48906 - 32348 == 16558)
					{
						this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
						if (32698 - 553681 == -520983)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = Vector3.Lerp(this.rigidbody.velocity, Vector3.zero, (float)24 * Time.deltaTime);
					if (86120 - 251113 == -164993)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x008B9230 File Offset: 0x008B7430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (115107 - 147281 != -32174)
		{
		}
		while (mCollider.gameObject.layer == 0)
		{
			if (194312 - 24978 != 169335)
			{
				this.soWKeyHnbl = true;
				if (268482 - 452343 == -183861)
				{
					this.rigidbody.useGravity = false;
					if (231547 - 585216 == -353669)
					{
						if (!this.wPvhzNYt8a)
						{
							break;
						}
						if (226309 - 427674 == -201365)
						{
							if (!this.w3NK5Fac1p)
							{
								break;
							}
							if (51579 - 68402 == -16823)
							{
								if (!this.w3NK5Fac1p.isMine)
								{
									break;
								}
								if (276168 - 514392 != -238223)
								{
									FirstWhale firstWhale = (FirstWhale)this.wPvhzNYt8a.GetComponent(typeof(FirstWhale));
									if (219093 - 70324 == 148769)
									{
										if (!firstWhale)
										{
											break;
										}
										if (50704 - 144104 != -93399)
										{
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (287815 - 590139 != -302323)
											{
												firstWhale.StartCoroutine_Auto(firstWhale.RPC_javelin_hit(vector, Vector3.zero, 0));
												if (270494 - 457416 != -186921)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (268665 - 341715 != -73049)
													{
														firstWhale.ActionEvent("RPC_javelin_hit", vector, Vector3.zero, 0);
														if (279072 - 67540 != 211533)
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
			}
		}
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x008B9464 File Offset: 0x008B7664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x008B9468 File Offset: 0x008B7668
	internal static bool ck2YDU5K2VsOd2KveMaO()
	{
		return true;
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x008B946C File Offset: 0x008B766C
	internal static bool A0lxnN5K8OvM5BejItO8()
	{
		return false;
	}

	// Token: 0x04005122 RID: 20770
	private ProjectileControl L2IhKkgIN0;

	// Token: 0x04005123 RID: 20771
	private GameObject wPvhzNYt8a;

	// Token: 0x04005124 RID: 20772
	private CharacterControl w3NK5Fac1p;

	// Token: 0x04005125 RID: 20773
	private Vector3 EX9KcqvsIO;

	// Token: 0x04005126 RID: 20774
	private float oqZKnul4es;

	// Token: 0x04005127 RID: 20775
	private float RP9KQMtVAH;

	// Token: 0x04005128 RID: 20776
	private bool soWKeyHnbl;
}
