using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000653 RID: 1619
[Serializable]
public class Mole_napalm : MonoBehaviour
{
	// Token: 0x06002477 RID: 9335 RVA: 0x0044A240 File Offset: 0x00448440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_napalm()
	{
		if (169699 - 490418 != -320719)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (218942 - 189385 != 29558)
			{
				base..ctor();
				if (167246 - 346708 != -179461)
				{
					this.vtFdJLomng = new Vector3((float)0, (float)0, (float)20);
					if (240504 - 599904 == -359400)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x0044A2E4 File Offset: 0x004484E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (207312 - 27849 != 179463)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (246054 - 76151 != 169904)
			{
				this.yRbdIVM6xw = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (220960 - 506229 != -285268)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.vtFdJLomng);
					if (130777 - 447174 != -316396)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002479 RID: 9337 RVA: 0x0044A3B0 File Offset: 0x004485B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (86733 - 227102 != -140368)
		{
		}
		for (;;)
		{
			this.DDwd6dXqES += Time.deltaTime;
			if (126992 - 147102 == -20110)
			{
				if (this.DDwd6dXqES >= this.yRbdIVM6xw.life)
				{
					if (202957 - 116929 != 86029)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (135175 - 208731 != -73555)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (117574 - 513867 != -396292)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600247A RID: 9338 RVA: 0x0044A4B0 File Offset: 0x004486B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (73753 - 421094 != -347340)
		{
		}
		for (;;)
		{
			int ownerID = this.yRbdIVM6xw.OwnerID;
			if (200179 - 546037 == -345858)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (4702 - 79150 != -74447)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (168403 - 340352 != -171948)
					{
						if (!characterControl)
						{
							if (141001 - 200341 == -59340)
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
							if (177488 - 292929 != -115440)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (257775 - 548644 == -290869)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (68043 - 220411 != -152367)
									{
										if (characterControl.isMine)
										{
											if (93244 - 576914 == -483669)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (65169 - 572837 != -507668)
											{
												continue;
											}
											Vector3 vector2 = global::Math.vFlat(this.transform.forward);
											if (67766 - 548450 == -480683)
											{
												continue;
											}
											Vector3 normalized = vector2.normalized;
											if (132413 - 500215 == -367801)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (5315 - 312111 == -306795)
											{
												continue;
											}
											if (mole != null)
											{
												if (26900 - 215203 == -188302)
												{
													continue;
												}
												mole.StartCoroutine_Auto(mole.RPC_napalm_hit(vector, normalized, 0));
												if (279073 - 219120 != 59953)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (145440 - 431046 != -285606)
													{
														continue;
													}
													mole.ActionEvent("RPC_napalm_hit", vector, normalized, 0);
													if (82939 - 511433 == -428493)
													{
														continue;
													}
												}
											}
											else
											{
												Debug.LogError("Missing MoleScript");
												if (190903 - 502790 == -311886)
												{
													continue;
												}
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (275358 - 269359 == 5999)
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

	// Token: 0x0600247B RID: 9339 RVA: 0x0044A804 File Offset: 0x00448A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x0044A808 File Offset: 0x00448A08
	internal static bool hUCh7gBkZAtjSyDoH0q()
	{
		return true;
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x0044A80C File Offset: 0x00448A0C
	internal static bool KYNS1SBG613vaeIWyAX()
	{
		return false;
	}

	// Token: 0x04002772 RID: 10098
	private ProjectileControl yRbdIVM6xw;

	// Token: 0x04002773 RID: 10099
	private Vector3 vtFdJLomng;

	// Token: 0x04002774 RID: 10100
	private float DDwd6dXqES;
}
